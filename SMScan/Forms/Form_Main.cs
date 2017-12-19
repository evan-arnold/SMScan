using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using SMScan.MemoryScanner;
using SMScan.Conversions;
using SMScan.Forms;

namespace SMScan
{
    public partial class Form_Main : Form
    {
        #region Variables & Initialization
        private Stopwatch ScanTimeStopwatch;
        private List<TableEntry> TableData = new List<TableEntry>();
        private List<TableEntry> DeletedData = new List<TableEntry>();
        private ProcessMemoryEditor ProcessMemoryEditor = new ProcessMemoryEditor();
        private ScanMemory Scan;
        private ScanDataType SelectedScanType;
        private const UInt64 SystemMaxAddress = 0x7FFFFFFF;
        private bool Canceled = false;
        private MemoryMappedFile CurrentScanAddresses;
        private MemoryMappedViewAccessor CurrentAddressAccessor;
        private bool DisplayFoundAsSigned = false;
        private int StartSelectionIndex = -1;
        private int EndSelectionIndex = -1;
        private int CurrentScrollVal = 0;
        private string ExecutablePath = Path.GetDirectoryName(Application.ExecutablePath);
        private Process TargetProcess;
        public Process Process
        {
            set
            {
                TargetProcess = value;
                ToolStrip_Label_Process.Text = "Process: " + Conversions.Conversions.ToAddress(Convert.ToString(TargetProcess.Id)) + " - " + TargetProcess.ProcessName;
                ProcessMemoryEditor.OpenProcess(TargetProcess.Id);
            }
            get
            {
                return TargetProcess;
            }
        }

        public Form_Main()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            ShowFirstScanOptions();
            ComboBox_CompareType.Width = ComboBox_CompareType.Width;
            ComboBox_DataType.SelectedIndex = 3;
            CheckedListBox_Protection.SetItemChecked(2, true);
            CheckedListBox_Protection.SetItemChecked(6, true);
            CheckedListBox_Type.SetItemChecked(0, true);
            CheckedListBox_Type.SetItemChecked(1, true);
        }
        #endregion

        #region Form Events
        private void CheckBox_OptimizeScan_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_OptimizeScan.Checked)
            {
                NUD_OptimizeScan.Enabled = true;
                RadioButton_Allignment.Enabled = true;
                RadioButton_LastDigits.Enabled = true;
            }
            else
            {
                NUD_OptimizeScan.Enabled = false;
                RadioButton_Allignment.Enabled = false;
                RadioButton_LastDigits.Enabled = false;
            }
        }
        private void ComboBox_DataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioButton_Truncated.Visible = false;
            RadioButton_Rounded.Visible = false;

            ScanDataType _ScanValueType = (ScanDataType)ComboBox_DataType.SelectedIndex;
            switch (_ScanValueType)
            {
                case ScanDataType.Binary:
                case ScanDataType.Byte:
                    NUD_OptimizeScan.Value = 1;
                    break;
                case ScanDataType.Int16:
                    NUD_OptimizeScan.Value = 2;
                    break;
                case ScanDataType.Single:
                case ScanDataType.Double:
                    RadioButton_Truncated.Visible = true;
                    RadioButton_Rounded.Visible = true;
                    NUD_OptimizeScan.Value = 4;
                    break;
                case ScanDataType.Int32:
                case ScanDataType.Int64:
                    NUD_OptimizeScan.Value = 4;
                    break;
            }
        }
        private void ShowFirstScanOptions()
        {
            ComboBox_CompareType.Items.Clear();
            ComboBox_CompareType.Items.Add("=");
            ComboBox_CompareType.Items.Add("≠");
            ComboBox_CompareType.Items.Add("<");
            ComboBox_CompareType.Items.Add(">");
            ComboBox_CompareType.Items.Add("≤");
            ComboBox_CompareType.Items.Add("≥");
            ComboBox_CompareType.Items.Add("> <");
            ComboBox_CompareType.Items.Add("≥ ≤");
            ComboBox_CompareType.Items.Add("??");
            ComboBox_CompareType.SelectedIndex = 0;
        }
        private void ShowSecondScanOptions()
        {
            ComboBox_CompareType.Items.Clear();
            ComboBox_CompareType.Items.Add("=");
            ComboBox_CompareType.Items.Add("Ø");
            ComboBox_CompareType.Items.Add("±");
            ComboBox_CompareType.Items.Add("≠");
            ComboBox_CompareType.Items.Add("+");
            ComboBox_CompareType.Items.Add("-");
            ComboBox_CompareType.Items.Add("+x");
            ComboBox_CompareType.Items.Add("-x");
            ComboBox_CompareType.Items.Add("<");
            ComboBox_CompareType.Items.Add(">");
            ComboBox_CompareType.Items.Add("≤");
            ComboBox_CompareType.Items.Add("≥");
            ComboBox_CompareType.Items.Add("> <");
            ComboBox_CompareType.Items.Add("≥ ≤");
            ComboBox_CompareType.Items.Add("??");
            ComboBox_CompareType.SelectedIndex = 0;
        }
        private string OldValueText = "";
        private string OldSecondValueText = "";
        private void ComboBox_CompareType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScanCompareType RescanCompareType =
                Conversions.Conversions.StringToScanType(ComboBox_CompareType.Items[ComboBox_CompareType.SelectedIndex].ToString());

            if (TextBox_ScanValue.Enabled)
                OldValueText = TextBox_ScanValue.Text;
            if (ScanSecondValueTextBox.Visible)
                OldSecondValueText = ScanSecondValueTextBox.Text;

            Label_CompareType.Text = RescanCompareType.ToString().Replace('_', ' ');

            switch (RescanCompareType)
            {
                case ScanCompareType.Exact_Value:
                case ScanCompareType.Not_Equal_to_Value:
                case ScanCompareType.Increased_by_Value:
                case ScanCompareType.Decreased_by_Value:
                case ScanCompareType.Less_Than:
                case ScanCompareType.Greater_Than:
                    ScanSecondValueTextBox.Text = "";
                    TextBox_ScanValue.Text = OldValueText;
                    ScanSecondValueTextBox.Visible = false;
                    TextBox_ScanValue.Enabled = true;
                    TextBox_ScanValue.Width = 214;
                    break;

                case ScanCompareType.Changed_Value:
                case ScanCompareType.Unchanged_Value:
                case ScanCompareType.Increased_Value:
                case ScanCompareType.Decreased_Value:
                case ScanCompareType.Unknown_Value:
                    TextBox_ScanValue.Text = "";
                    ScanSecondValueTextBox.Text = "";
                    ScanSecondValueTextBox.Visible = false;
                    TextBox_ScanValue.Enabled = false;
                    TextBox_ScanValue.Width = 214;
                    break;

                case ScanCompareType.Between_Exclusive:
                    ScanSecondValueTextBox.Text = OldSecondValueText;
                    ScanSecondValueTextBox.Visible = true;
                    TextBox_ScanValue.Visible = true;
                    TextBox_ScanValue.Enabled = true;
                    TextBox_ScanValue.Width = ScanSecondValueTextBox.Width;
                    break;
            }
        }
        #endregion

        #region Scan Events
        void scan_ScanCanceled(object sender, ScanCanceledEventArgs e)
        {
            Canceled = true;
            ListView_Address.VirtualListSize = 0;
            UpdateFoundTimer.Enabled = false;
            ListView_Address.Items.Clear();
            ProgressBar.Value = 0;
            Button_Scan_Abort.Enabled = false;
            Button_Scan_Start.Enabled = false;

            MessageBox.Show("Scan canceled by the user.", "Scan canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        delegate void Completed(object sender, ScanCompletedEventArgs e);
        void scan_ScanCompleted(object sender, ScanCompletedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Completed completed = new Completed(scan_ScanCompleted);
                this.Invoke(completed, new object[] { sender, e });
            }
            else
            {
                if (!Canceled)
                {
                    ProgressBar.Value = 0;
                    int TotalFound = (int)(e.TotalFoundSize / (Int64)DataTypeSize.Int64);
                    if (TotalFound > 0)
                    {
                        CurrentScanAddresses = MemoryMappedFile.CreateFromFile(@ExecutablePath + @"/Scan Data/CurrentScanAddresses", FileMode.Open, "CurrentScanAddresses", e.TotalFoundSize);
                        CurrentAddressAccessor = CurrentScanAddresses.CreateViewAccessor(0, e.TotalFoundSize);
                    }
                    ListView_Address.VirtualListSize = TotalFound;

                    Button_Scan_New.Enabled = true;
                    Button_Scan_Abort.Enabled = false;
                    UpdateFoundTimer.Enabled = true;
                    Button_Scan_Next.Enabled = true;
                }
            }
        }
        delegate void Progress(object sender, ScanProgressChangedEventArgs e);
        void scan_ScanProgressChanged(object sender, ScanProgressChangedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Progress progress = new Progress(scan_ScanProgressChanged);
                this.Invoke(progress, new object[] { sender, e });
            }
            else
            {
                if (e.Progress > 100)
                    e.Progress = 100;
                ProgressBar.Value = e.Progress;
                if (e.Progress == 100)
                {
                    ScanTimeStopwatch.Stop();
                }
            }
        }
        #endregion

        #region Scan UI Events
        private void Button_Scan_New_Click(object sender, EventArgs e)
        {
            ListView_Address.VirtualListSize = 0;
            ListView_Address.Items.Clear();
            CurrentAddressAccessor.Dispose();

            UpdateFoundTimer.Enabled = false;
            Button_Scan_Next.Enabled = false;
            Button_Scan_New.Enabled = false;
            Button_Scan_Start.Enabled = false;
            ComboBox_DataType.Enabled = true;
            TextBox_StartAddress.Enabled = true;
            TextBox_EndAddress.Enabled = true;
            Button_Scan_Start.Enabled = true;

            ShowFirstScanOptions();
        }

        private void Button_Scan_Start_Click(object sender, EventArgs e)
        {
            UInt64 FirstAddress;
            UInt64 LastAddress;

            if (!CheckSyntax.Address(TextBox_EndAddress.Text) || !CheckSyntax.Address(TextBox_StartAddress.Text))
            {
                MessageBox.Show("Address range must be in hexadecimal format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirstAddress = Conversions.Conversions.HexToUInt64(TextBox_StartAddress.Text);
            LastAddress = Conversions.Conversions.HexToUInt64(TextBox_EndAddress.Text);

            if ((FirstAddress < 0 || FirstAddress > SystemMaxAddress) || (LastAddress < 0 || LastAddress > SystemMaxAddress))
            {
                MessageBox.Show("Addresses must be between 0 and " + SystemMaxAddress.ToString() + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (LastAddress < FirstAddress)
            {
                MessageBox.Show("Invalid address range. Swapping values and attempting to proceed anyways.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UInt64 Temp = FirstAddress;
                FirstAddress = LastAddress;
                LastAddress = Temp;
            }

            if (CheckBox_OptimizeScan.Checked && !RadioButton_LastDigits.Checked)
            {
                while (FirstAddress % NUD_OptimizeScan.Value != 0)
                    FirstAddress++;
                while (LastAddress % NUD_OptimizeScan.Value != 0)
                    LastAddress--;

                if ((FirstAddress < 0 || FirstAddress > SystemMaxAddress) || (LastAddress < 0 || LastAddress > SystemMaxAddress))
                {
                    MessageBox.Show("Specified allignment results in invalid address range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!ScanButtonShared(false, FirstAddress, LastAddress))
                return;

            TextBox_StartAddress.Enabled = false;
            TextBox_EndAddress.Enabled = false;
            ComboBox_DataType.Enabled = false;
            Button_Scan_Start.Enabled = false;
            Canceled = false;
            Button_Scan_Abort.Enabled = true;
            ListView_Address.Items.Clear();
            ShowSecondScanOptions();
        }

        private void Button_Scan_Next_Click(object sender, EventArgs e)
        {
            UInt64 FirstAddress = 0;
            UInt64 LastAddress = 0;

            if (CurrentAddressAccessor.Capacity > 0)
                CurrentAddressAccessor.Read(0, out FirstAddress);

            if (CurrentAddressAccessor.Capacity > 0)
                CurrentAddressAccessor.Read(CurrentAddressAccessor.Capacity - (Int64)DataTypeSize.Int64, out LastAddress);

            if (!ScanButtonShared(true, FirstAddress, LastAddress))
                return;

            Canceled = false;
            Button_Scan_Abort.Enabled = true;
            ListView_Address.SelectedIndices.Clear();
        }

        private bool ScanButtonShared(bool IsRescan, UInt64 FirstAddress, UInt64 LastAddress)
        {
            object ScanValue;
            object SecondScanValue;

            SelectedScanType = (ScanDataType)ComboBox_DataType.SelectedIndex;

            #region Collect scan data from form and check for errors
            if (TargetProcess == null)
            {
                MessageBox.Show("Please select a process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!CheckSyntax.Value(TextBox_ScanValue.Text, (ScanDataType)ComboBox_DataType.SelectedIndex, CheckBox_IsHex.Checked) && TextBox_ScanValue.Enabled == true ||
                !CheckSyntax.Value(ScanSecondValueTextBox.Text, (ScanDataType)ComboBox_DataType.SelectedIndex, CheckBox_IsHex.Checked) && ScanSecondValueTextBox.Visible == true)
            {
                MessageBox.Show("Invalid value format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TextBox_ScanValue.Enabled == true)
                ScanValue = Conversions.Conversions.ToUnsigned(TextBox_ScanValue.Text, SelectedScanType);
            else
                ScanValue = null;

            if (ScanSecondValueTextBox.Visible == true)
                SecondScanValue = Conversions.Conversions.ToUnsigned(ScanSecondValueTextBox.Text, SelectedScanType);
            else
                SecondScanValue = null;
            #endregion

            #region Prescan events
            uint[] Protect = new uint[8];
            int CheckedItems = CheckedListBox_Protection.CheckedIndices.Count;
            for (int ecx = 0; ecx < CheckedItems; ecx++)
                Protect[CheckedListBox_Protection.CheckedIndices[ecx]] = 1;
            uint[] Type = new uint[3];
            CheckedItems = CheckedListBox_Type.CheckedIndices.Count;
            for (int ecx = 0; ecx < CheckedItems; ecx++)
                Type[CheckedListBox_Type.CheckedIndices[ecx]] = 1;

            ScanOptimizationData ScanOptimizationData = new ScanOptimizationData(CheckBox_OptimizeScan.Checked, (UInt64)NUD_OptimizeScan.Value, RadioButton_LastDigits.Checked);

            bool CompareToFirstScan = false;
            if (IsRescan && CheckBox_CompareToFirstCB.Checked == true)
                CompareToFirstScan = true;

            Scan = new ScanMemory(TargetProcess, FirstAddress, LastAddress, SelectedScanType,
                Conversions.Conversions.StringToScanType(ComboBox_CompareType.Items[ComboBox_CompareType.SelectedIndex].ToString()),
                ScanValue, SecondScanValue, Protect, Type, RadioButton_Truncated.Checked, ScanOptimizationData, ExecutablePath, CompareToFirstScan);

            Scan.ScanProgressChanged += new ScanMemory.ScanProgressedEventHandler(scan_ScanProgressChanged);
            Scan.ScanCompleted += new ScanMemory.ScanCompletedEventHandler(scan_ScanCompleted);
            Scan.ScanCanceled += new ScanMemory.ScanCanceledEventHandler(scan_ScanCanceled);

            ListView_Address.VirtualListSize = 0;
            ListView_Address.Items.Clear();

            if (CurrentAddressAccessor != null)
                CurrentAddressAccessor.Dispose();
            if (CurrentScanAddresses != null)
                CurrentScanAddresses.Dispose();

            ProgressBar.Value = 0;
            #endregion

            #region Start scan
            ScanTimeStopwatch = Stopwatch.StartNew();
            try
            {
                Scan.StartScan(IsRescan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Scan.CancelScan();
                return false;
            }
            return true;
            #endregion
        }

        private void Button_Scan_Abort_Click(object sender, EventArgs e)
        {
            Scan.CancelScan();
            ProgressBar.Value = 0;
            Button_Scan_New_Click(sender, e);
        }
        #endregion

        #region Found List Events
        private void AddCurrentSelectedRange()
        {
            for (int ecx = StartSelectionIndex; ecx <= EndSelectionIndex; ecx++)
            {
                AddTable("No Description", Conversions.Conversions.HexToUInt64(Convert.ToString(ListView_Address.Items[ecx].Text)),
                    SelectedScanType, false, false, false, "");
            }
        }
        private void addItemToTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCurrentSelectedRange();
        }
        private void showItemsAsSignedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem MenuItem = sender as ToolStripMenuItem;
            MenuItem.Checked = !MenuItem.Checked;
            DisplayFoundAsSigned = MenuItem.Checked;
        }
        private const int HeaderPixels = 27;
        private void ListView_Address_MouseDown(object sender, MouseEventArgs e)
        {
            if (ListView_Address.Items.Count <= 0)
                return;

            int Height = ListView_Address.Items[0].Bounds.Height;
            int HeaderHeight = ListView_Address.Items[0].Bounds.Top;

            int TargetIndex = (Cursor.Position.Y - this.Location.Y - HeaderHeight - ListView_Address.Location.Y - HeaderPixels)
                / Height;

            if (ModifierKeys == Keys.Shift)
            {
                EndSelectionIndex = TargetIndex;
                if (StartSelectionIndex == -1)
                    StartSelectionIndex = EndSelectionIndex;
            }
            else
            {
                if (e.Button == MouseButtons.Left || TargetIndex < StartSelectionIndex || TargetIndex > EndSelectionIndex)
                {
                    StartSelectionIndex = TargetIndex;
                    EndSelectionIndex = StartSelectionIndex;
                }
            }

            if (EndSelectionIndex < StartSelectionIndex)
            {
                int Temp = StartSelectionIndex;
                StartSelectionIndex = EndSelectionIndex;
                EndSelectionIndex = Temp;
            }
        }
        private bool GetScrollIndex = false;
        private void UpdateFoundTimer_Tick(object sender, EventArgs e)
        {
            ListView_Address.BeginUpdate();

            GetScrollIndex = true;
            ListView_Address.Refresh();
            GetScrollIndex = false;

            ListView_Address.EndUpdate();
        }
        private void ListView_Address_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (GetScrollIndex && e.ItemIndex != -1)
            {
                GetScrollIndex = false;
                CurrentScrollVal = e.ItemIndex;
            }

            UInt64 FoundAddress;
            CurrentAddressAccessor.Read(e.ItemIndex * (Int64)DataTypeSize.Int64, out FoundAddress);
            ListViewItem lvi = new ListViewItem(Conversions.Conversions.ToAddress(FoundAddress.ToString()));

            switch (SelectedScanType)
            {
                case ScanDataType.Binary:
                    lvi.SubItems.Add(ProcessMemoryEditor.ReadByte(FoundAddress).ToString());
                    break;
                case ScanDataType.Byte:
                    if (DisplayFoundAsSigned)
                        lvi.SubItems.Add(ProcessMemoryEditor.ReadSByte(FoundAddress).ToString());
                    else
                        lvi.SubItems.Add(ProcessMemoryEditor.ReadByte(FoundAddress).ToString());
                    break;
                case ScanDataType.Int16:
                    if (DisplayFoundAsSigned)
                        lvi.SubItems.Add(ProcessMemoryEditor.ReadInt16(FoundAddress).ToString());
                    else
                        lvi.SubItems.Add(ProcessMemoryEditor.ReadUInt16(FoundAddress).ToString());
                    break;
                case ScanDataType.Int32:
                    if (DisplayFoundAsSigned)
                        lvi.SubItems.Add(ProcessMemoryEditor.ReadInt32(FoundAddress).ToString());
                    else
                        lvi.SubItems.Add(ProcessMemoryEditor.ReadUInt32(FoundAddress).ToString());
                    break;
                case ScanDataType.Int64:
                    if (DisplayFoundAsSigned)
                        lvi.SubItems.Add(ProcessMemoryEditor.ReadInt64(FoundAddress).ToString());
                    else
                        lvi.SubItems.Add(ProcessMemoryEditor.ReadUInt64(FoundAddress).ToString());
                    break;
                case ScanDataType.Single:
                    lvi.SubItems.Add(ProcessMemoryEditor.ReadSingle(FoundAddress).ToString());
                    break;
                case ScanDataType.Double:
                    lvi.SubItems.Add(ProcessMemoryEditor.ReadDouble(FoundAddress).ToString());
                    break;
                case ScanDataType.Text:
                    lvi.SubItems.Add(ProcessMemoryEditor.ReadUInt32(FoundAddress).ToString());
                    break;
                case ScanDataType.AOB:
                    lvi.SubItems.Add(ProcessMemoryEditor.ReadUInt32(FoundAddress).ToString());
                    break;
                case ScanDataType.All:
                    lvi.SubItems.Add(ProcessMemoryEditor.ReadUInt32(FoundAddress).ToString());
                    break;
                default:
                    lvi.SubItems.Add("Unknown data type.");
                    break;
            }
            e.Item = lvi;
        }
        #endregion

        #region Table Events
        private void WriteTimer_Tick(object sender, EventArgs e)
        {
            int TableIndex = 0;
            foreach (TableEntry Table in TableData)
            {
                Table.CheckState = ListView_Table.Items[TableIndex].Checked;
                if (Table.CheckState == false)
                {
                    switch (Table.ScanType)
                    {
                        case ScanDataType.Binary:
                            Table.Value = ProcessMemoryEditor.ReadByte(Table.Address);
                            break;
                        case ScanDataType.Byte:
                            Table.Value = ProcessMemoryEditor.ReadByte(Table.Address);
                            break;
                        case ScanDataType.Int16:
                            Table.Value = ProcessMemoryEditor.ReadUInt16(Table.Address);
                            break;
                        case ScanDataType.Int32:
                            Table.Value = ProcessMemoryEditor.ReadUInt32(Table.Address);
                            break;
                        case ScanDataType.Int64:
                            Table.Value = ProcessMemoryEditor.ReadUInt64(Table.Address);
                            break;
                        case ScanDataType.Single:
                            Table.Value = ProcessMemoryEditor.ReadSingle(Table.Address);
                            break;
                        case ScanDataType.Double:
                            Table.Value = ProcessMemoryEditor.ReadDouble(Table.Address);
                            break;
                        case ScanDataType.Text:
                            Table.Value = ProcessMemoryEditor.ReadString(Table.Address, 20, 0);
                            break;
                        case ScanDataType.AOB:
                            break;
                        case ScanDataType.All:
                            break;
                        default:
                            ListView_Table.Items[TableIndex].SubItems[4].Text = "Error";
                            break;
                    }

                    if (ListView_Table.Items[TableIndex].SubItems[4].Text != Table.Value.ToString())
                        ListView_Table.Items[TableIndex].SubItems[4].Text = Table.Value.ToString();

                }
                TableWriteMemory(Table, Table.CheckState);
                TableIndex++;
            }
        }
        private void TableWriteMemory(TableEntry Table, bool CheckState)
        {
            if (Table.Value != null && CheckState == true)
            {
                switch (Table.ScanType)
                {
                    case ScanDataType.Binary:
                        ProcessMemoryEditor.Write(Table.Address, Convert.ToByte(Table.Value));
                        break;
                    case ScanDataType.Byte:
                        ProcessMemoryEditor.Write(Table.Address, Convert.ToByte(Table.Value));
                        break;
                    case ScanDataType.Int16:
                        ProcessMemoryEditor.Write(Table.Address, Convert.ToUInt16(Table.Value));
                        break;
                    case ScanDataType.Int32:
                        ProcessMemoryEditor.Write(Table.Address, Convert.ToUInt32(Table.Value));
                        break;
                    case ScanDataType.Int64:
                        ProcessMemoryEditor.Write(Table.Address, Convert.ToUInt64(Table.Value));
                        break;
                    case ScanDataType.Single:
                        ProcessMemoryEditor.Write(Table.Address, Convert.ToSingle(Table.Value));
                        break;
                    case ScanDataType.Double:
                        ProcessMemoryEditor.Write(Table.Address, Convert.ToDouble(Table.Value));
                        break;
                    case ScanDataType.Text:
                        ProcessMemoryEditor.Write(Table.Address, Convert.ToString(Table.Value), 0);
                        break;
                    case ScanDataType.AOB:
                        break;
                    case ScanDataType.All:
                        break;
                }
            }
        }
        private void Button_Table_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all data in table?", "Clear Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DeletedData.AddRange(TableData);
                ListView_Table.Items.Clear();
                TableData.Clear();
                Button_Table_Clear.Enabled = false;
            }
        }
        private Form_EditAddress AddressWindow;
        private Form_EditDescription DescriptionWindow;
        private Form_EditValue ValueWindow;
        private Form_EditType TypeWindow;
        private void Button_AddSpecific_Click(object sender, EventArgs e)
        {
            Form_AddSpecific AddSpecificAddress = new Form_AddSpecific(false, "", "", ScanDataType.All);
            AddSpecificAddress.ShowDialog();
            if (AddSpecificAddress.Description != null)
            {
                AddTable(AddSpecificAddress.Description, Conversions.Conversions.HexToUInt64(AddSpecificAddress.Address),
                    AddSpecificAddress.ScanType, false, false, false, "");
            }
        }
        private void Button_AddSelected_Click(object sender, EventArgs e)
        {
            AddCurrentSelectedRange();
        }
        private void ListView_Address_DoubleClick(object sender, EventArgs e)
        {
            AddTable("No Description", Conversions.Conversions.HexToUInt64(Convert.ToString(ListView_Address.Items[ListView_Address.SelectedIndices[0]].Text)),
                SelectedScanType, false, false, false, "");
        }
        public void AddTable(string Description, UInt64 Address, ScanDataType scantype, bool Signed, bool ValueAsHex, bool AddressAsHex, string ASMScript)
        {
            TableData.Add(new TableEntry(Description, Address, scantype, Signed, ValueAsHex, AddressAsHex, ASMScript));

            int TableIndex = TableData.Count - 1;
            string[] AddInfo = new string[4];
            AddInfo[0] = TableData[TableIndex].Description;
            AddInfo[1] = Conversions.Conversions.ToAddress((TableData[TableIndex].Address.ToString()));
            AddInfo[2] = Conversions.Conversions.ScanTypeToName(TableData[TableIndex].ScanType);
            AddInfo[3] = "???";
            ListView_Table.Items.Add("").SubItems.AddRange(AddInfo);

            Button_Table_Clear.Enabled = true;
        }
        private const int PixelsBeforeCB = 9;
        private const int PixelsAfterCB = 21;
        private void ListView_Table_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int CursorRelativeToWindow = Cursor.Position.X - this.Location.X;
            if (CursorRelativeToWindow > ListView_Table.Location.X + PixelsAfterCB ||
                CursorRelativeToWindow < ListView_Table.Location.X + PixelsBeforeCB)
            {
                if (e.NewValue == CheckState.Checked)
                    e.NewValue = CheckState.Unchecked;
                else
                    e.NewValue = CheckState.Checked;
            }
        }
        private void ListView_Table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListView_Table.SelectedItems.Count <= 0)
                return;

            if (ListView_Table.SelectedItems[0].Checked == true)
                ListView_Table.SelectedItems[0].Checked = false;
            else
                ListView_Table.SelectedItems[0].Checked = true;

            TableData[ListView_Table.SelectedIndices[0]].CheckState = ListView_Table.SelectedItems[0].Checked;

            int index = ListView_Table.SelectedItems[0].Index;

            if (Cursor.Position.X - this.Location.X > ListView_Table.Items[index].SubItems[1].Bounds.Left &&
                Cursor.Position.X - this.Location.X < ListView_Table.Items[index].SubItems[1].Bounds.X + ListView_Table.Items[0].SubItems[1].Bounds.Width)
            {
                if (DescriptionWindow == null || DescriptionWindow.IsDisposed)
                {
                    DescriptionWindow = new Form_EditDescription(ListView_Table.Items[index].SubItems[1].Text);
                    if (DescriptionWindow.ShowDialog(this) == DialogResult.OK)
                    {
                        TableData[index].Description = DescriptionWindow.Description;
                        ListView_Table.Items[index].SubItems[1].Text = DescriptionWindow.Description;
                    }
                    DescriptionWindow.Dispose();
                }
            }
            else if (Cursor.Position.X - this.Location.X > ListView_Table.Items[ListView_Table.SelectedItems[0].Index].SubItems[2].Bounds.Left &&
                Cursor.Position.X - this.Location.X < ListView_Table.Items[index].SubItems[2].Bounds.X + ListView_Table.Items[0].SubItems[2].Bounds.Width)
            {
                if (AddressWindow == null || AddressWindow.IsDisposed)
                {
                    AddressWindow = new Form_EditAddress(ListView_Table.Items[index].SubItems[2].Text);
                    if (AddressWindow.ShowDialog(this) == DialogResult.OK)
                    {
                        TableData[index].Address = AddressWindow.Address;
                        ListView_Table.Items[index].SubItems[2].Text = Conversions.Conversions.ToAddress(TableData[index].Address.ToString());
                    }
                    AddressWindow.Dispose();
                }

            }
            else if (Cursor.Position.X - this.Location.X > ListView_Table.Items[ListView_Table.SelectedItems[0].Index].SubItems[3].Bounds.Left &&
                Cursor.Position.X - this.Location.X < ListView_Table.Items[index].SubItems[3].Bounds.X + ListView_Table.Items[0].SubItems[3].Bounds.Width)
            {
                if (TypeWindow == null || TypeWindow.IsDisposed)
                {
                    TypeWindow = new Form_EditType(TableData[index].ScanType);
                    if (TypeWindow.ShowDialog(this) == DialogResult.OK)
                    {
                        string type = Conversions.Conversions.ScanTypeToName(TypeWindow.ScanType);
                        TableData[index].ScanType = TypeWindow.ScanType;
                        ListView_Table.Items[index].SubItems[3].Text = type;
                    }
                    TypeWindow.Dispose();
                }
            }
            else if (Cursor.Position.X - this.Location.X > ListView_Table.Items[index].SubItems[4].Bounds.Left &&
                Cursor.Position.X - this.Location.X < ListView_Table.Items[index].SubItems[4].Bounds.X + ListView_Table.Items[0].SubItems[4].Bounds.Width)
            {
                if (ValueWindow == null || ValueWindow.IsDisposed)
                {
                    ValueWindow = new Form_EditValue(TableData[index].ScanType, TableData[index].Value);
                    if (ValueWindow.ShowDialog(this) == DialogResult.OK)
                    {
                        TableData[index].Value = ValueWindow.Value;
                        TableWriteMemory(TableData[index], true);
                        ListView_Table.Items[index].SubItems[4].Text = ValueWindow.Value.ToString();
                    }
                    ValueWindow.Dispose();
                }
            }
        }
        #endregion

        #region Tools
        private void Button_SelectProcess_Click(object sender, EventArgs e)
        {
            Form_Process SelectProcess = new Form_Process();
            SelectProcess.ShowDialog();
            if (SelectProcess.TargetProcess != null)
            {
                this.Process = SelectProcess.TargetProcess;
            }
        }
        #endregion
    }

    public enum ScanDataType
    {
        Binary = 0,
        Byte = 1,
        Int16 = 2,
        Int32 = 3,
        Int64 = 4,
        Single = 5,
        Double = 6,
        Text = 7,
        AOB = 8,
        All = 9
    }
}
