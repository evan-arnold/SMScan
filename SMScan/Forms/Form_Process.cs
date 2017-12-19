using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SMScan;

namespace SMScan.Forms
{
    public partial class Form_Process : Form
    {
        #region Variables
        private List<Process> ProcessList;
        public Process TargetProcess;
        private int[] IDsList;
        #endregion

        #region Functions & Initialization
        public Form_Process()
        {
            InitializeComponent();
        }

        private void Form_Process_Load(object sender, EventArgs e)
        {
            UpdateProcessInfo();
        }

        private unsafe void UpdateProcessInfo()
        {
            ListView_Process.SuspendLayout();
            ListView_Process.BeginUpdate();
            ListView_Process.Items.Clear();

            ProcessList = new List<Process>(Process.GetProcesses());
            ProcessList.Sort(ProcessComparer.Reverse);
            IDsList = new int[ProcessList.Count];
            ImageList ImageListSmall = new ImageList();
            Icon Ico;
            int ImageCount = 0;

            for (int ecx = 0; ecx < ProcessList.Count; ecx++)
            {
                Ico = null;
                try
                {
                    if (!ProcessList[ecx].MainModule.FileName.Contains("system32"))
                    {
                        Ico = GetIcon(ProcessList[ecx].MainModule.FileName, 0);
                        //Ico = ExtractIconFromExe(ProcessList[ecx].MainModule.FileName, false); //Medium
                        //Ico = SHGetFileIcon(ProcessList[ecx].MainModule.FileName, 0, false); //Fast
                    }
                }
                catch { }

                if (ProcessList[ecx].MainWindowTitle != "")
                {
                    ListView_Process.Items.Add(
                        Conversions.Conversions.ToAddress(Convert.ToString(ProcessList[ecx].Id)) + " - " +
                        ProcessList[ecx].ProcessName + " - (" + ProcessList[ecx].MainWindowTitle + ")");
                }
                else
                {
                    ListView_Process.Items.Add(
                        Conversions.Conversions.ToAddress(Convert.ToString(ProcessList[ecx].Id)) + " - " +
                        ProcessList[ecx].ProcessName);
                }

                IDsList[ecx] = ProcessList[ecx].Id;
                if (Ico != null)
                {
                    ImageListSmall.Images.Add(Ico);
                    ListView_Process.Items[ecx].ImageIndex = ImageCount++;
                }
            }
            ListView_Process.SmallImageList = ImageListSmall;
            ListView_Process.ResumeLayout();
            ListView_Process.EndUpdate();
        }

        public unsafe static Icon ExtractIconFromEXE(string file, bool large)
        {
            int readIconCount = 0;
            IntPtr[] hDummy = new IntPtr[1] { IntPtr.Zero };
            IntPtr[] hIconEx = new IntPtr[1] { IntPtr.Zero };
            try
            {
                if (large)
                    readIconCount = (int)Icons.ExtractIconEx(file, 0, hIconEx, hDummy, 1);
                else
                    readIconCount = (int)Icons.ExtractIconEx(file, 0, hDummy, hIconEx, 1);

                if (readIconCount > 0 && hIconEx[0] != IntPtr.Zero)
                {
                    Icon extractedIcon = (Icon)Icon.FromHandle(hIconEx[0]).Clone();
                    return extractedIcon;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Could not extract icon", ex);
            }
            finally
            {
                foreach (IntPtr ptr in hIconEx)
                    if (ptr != IntPtr.Zero)
                        Icons.DestroyIcon(ptr);

                foreach (IntPtr ptr in hDummy)
                    if (ptr != IntPtr.Zero)
                        Icons.DestroyIcon(ptr);
            }
        }

        private Icon GetIcon(string fileName, int iconID)
        {
            try
            {
                IntPtr hc = Icons.ExtractIcon(this.Handle, fileName, iconID);
                if (!hc.Equals(IntPtr.Zero))
                    return (Icon.FromHandle(hc));
            }
            catch { }
            return null;
        }

        private Icon SHGetFileIcon(string fileName, int iconID, bool large)
        {
            Icons.SHFILEINFO info = new Icons.SHFILEINFO();
            int cbFileInfo = Marshal.SizeOf(info);
            Icons.SHGFI flags;
            if (large)
                flags = Icons.SHGFI.Icon | Icons.SHGFI.LargeIcon | Icons.SHGFI.UseFileAttributes;
            else
                flags = Icons.SHGFI.Icon | Icons.SHGFI.SmallIcon | Icons.SHGFI.UseFileAttributes;

            Icons.SHGetFileInfo(fileName, 0x00000100, out info, (uint)cbFileInfo, flags);
            return Icon.FromHandle(info.hIcon);
        }

        private void MakeSelection()
        {
            try
            {
                TargetProcess = Process.GetProcessById(IDsList[ListView_Process.SelectedIndices[0]]);
                this.Close();
            }
            catch
            {
                MessageBox.Show("No process is selected.", "Selection error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Events
        private void Button_Accept_Click(object sender, EventArgs e)
        {
            MakeSelection();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            UpdateProcessInfo();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListView_Process_DoubleClick(object sender, EventArgs e)
        {
            MakeSelection();
        }
        #endregion
    }

    class ProcessComparer : IComparer<Process>
    {
        public static readonly ProcessComparer Default = new ProcessComparer();
        public static readonly ProcessComparer Reverse = new ProcessComparer(true, false);

        private readonly bool _reverse;
        private readonly bool _ignoreCase;

        public ProcessComparer() : this(false, false) { }

        public ProcessComparer(bool reverse, bool ignoreCase)
        {
            this._reverse = reverse;
            this._ignoreCase = ignoreCase;
        }

        public int Compare(Process x, Process y)
        {
            sbyte reverse = 1;
            if (_reverse == true)
                reverse *= -1;

            if (x == y) return 0;

            if (x.BasePriority == 0 && y.BasePriority == 0)
                return 0;
            if (x.BasePriority == 0)
                return -1 * reverse;
            if (y.BasePriority == 0)
                return 1 * reverse;

            if (this._reverse)
                return DateTime.Compare(y.StartTime, x.StartTime);
            else
                return DateTime.Compare(x.StartTime, y.StartTime);
        }
    }

    class Icons
    {

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        [Flags]
        public enum SHGFI : int
        {
            Icon = 0x000000100,
            DisplayName = 0x000000200,
            TypeName = 0x000000400,
            Attributes = 0x000000800,
            IconLocation = 0x000001000,
            ExeType = 0x000002000,
            SysIconIndex = 0x000004000,
            LinkOverlay = 0x000008000,
            Selected = 0x000010000,
            Attr_Specified = 0x000020000,
            LargeIcon = 0x000000000,
            SmallIcon = 0x000000001,
            OpenIcon = 0x000000002,
            ShellIconSize = 0x000000004,
            PIDL = 0x000000008,
            UseFileAttributes = 0x000000010,
            AddOverlays = 0x000000020,
            OverlayIndex = 0x000000040,
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern uint ExtractIconEx(string szFileName, int nIconIndex,
           IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons);

        [DllImport("shell32.dll", SetLastError = true)]
        public static extern IntPtr ExtractIcon(IntPtr hInst, string lpszExeFileName, int nIconIndex);

        //[DllImport("shell32.dll", CharSet = CharSet.Auto)]
        //public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes,
        //    ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern int SHGetFileInfo(string pszPath, int dwFileAttributes,
            out SHFILEINFO psfi, uint cbfileInfo, SHGFI uFlags);

        [DllImport("user32.dll", EntryPoint = "DestroyIcon", SetLastError = true)]
        public static extern int DestroyIcon(IntPtr hIcon);
    }
}
