namespace SMScan
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Button_Table_Clear = new System.Windows.Forms.Button();
            this.Button_AddSpecific = new System.Windows.Forms.Button();
            this.Button_AddSelected = new System.Windows.Forms.Button();
            this.ListView_Address = new System.Windows.Forms.ListView();
            this._AddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._ValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView_Table = new System.Windows.Forms.ListView();
            this.CheckBoxHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStrip_Label_Process = new System.Windows.Forms.ToolStripLabel();
            this.ToolStrip_Label_Credits = new System.Windows.Forms.ToolStripLabel();
            this.Button_Scan_Abort = new System.Windows.Forms.Button();
            this.Button_Scan_Next = new System.Windows.Forms.Button();
            this.Button_Scan_Start = new System.Windows.Forms.Button();
            this.Button_Scan_New = new System.Windows.Forms.Button();
            this.Button_SelectProcess = new System.Windows.Forms.Button();
            this.RadioButton_Truncated = new System.Windows.Forms.RadioButton();
            this.TextBox_EndAddress = new System.Windows.Forms.TextBox();
            this.Label_From = new System.Windows.Forms.Label();
            this.TextBox_StartAddress = new System.Windows.Forms.TextBox();
            this.Label_To = new System.Windows.Forms.Label();
            this.NUD_OptimizeScan = new System.Windows.Forms.NumericUpDown();
            this.CheckBox_OptimizeScan = new System.Windows.Forms.CheckBox();
            this.CheckBox_CompareToFirstCB = new System.Windows.Forms.CheckBox();
            this.ComboBox_DataType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioButton_Rounded = new System.Windows.Forms.RadioButton();
            this.Label_Compare = new System.Windows.Forms.Label();
            this.ComboBox_CompareType = new System.Windows.Forms.ComboBox();
            this.Label_CompareType = new System.Windows.Forms.Label();
            this.CheckedListBox_Type = new System.Windows.Forms.CheckedListBox();
            this.CheckedListBox_Protection = new System.Windows.Forms.CheckedListBox();
            this.Label_MemoryType = new System.Windows.Forms.Label();
            this.Label_MemoryProtection = new System.Windows.Forms.Label();
            this.RadioButton_LastDigits = new System.Windows.Forms.RadioButton();
            this.TextBox_ScanValue = new System.Windows.Forms.TextBox();
            this.ScanSecondValueTextBox = new System.Windows.Forms.TextBox();
            this.CheckBox_IsHex = new System.Windows.Forms.CheckBox();
            this.RadioButton_Allignment = new System.Windows.Forms.RadioButton();
            this.UpdateFoundTimer = new System.Windows.Forms.Timer(this.components);
            this.WriteTimer = new System.Windows.Forms.Timer(this.components);
            this.RightClickMenu_AddressList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showItemsAsSignedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_OptimizeScan)).BeginInit();
            this.RightClickMenu_AddressList.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ProgressBar.ForeColor = System.Drawing.Color.SteelBlue;
            this.ProgressBar.Location = new System.Drawing.Point(7, 232);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(197, 15);
            this.ProgressBar.Step = 1;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 69;
            // 
            // Button_Table_Clear
            // 
            this.Button_Table_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Table_Clear.Location = new System.Drawing.Point(163, 255);
            this.Button_Table_Clear.Name = "Button_Table_Clear";
            this.Button_Table_Clear.Size = new System.Drawing.Size(50, 25);
            this.Button_Table_Clear.TabIndex = 74;
            this.Button_Table_Clear.Text = "Clear";
            this.Button_Table_Clear.UseVisualStyleBackColor = true;
            this.Button_Table_Clear.Click += new System.EventHandler(this.Button_Table_Clear_Click);
            // 
            // Button_AddSpecific
            // 
            this.Button_AddSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddSpecific.Location = new System.Drawing.Point(81, 255);
            this.Button_AddSpecific.Name = "Button_AddSpecific";
            this.Button_AddSpecific.Size = new System.Drawing.Size(83, 25);
            this.Button_AddSpecific.TabIndex = 73;
            this.Button_AddSpecific.Text = "Add Specific";
            this.Button_AddSpecific.UseVisualStyleBackColor = true;
            this.Button_AddSpecific.Click += new System.EventHandler(this.Button_AddSpecific_Click);
            // 
            // Button_AddSelected
            // 
            this.Button_AddSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddSelected.Location = new System.Drawing.Point(-1, 255);
            this.Button_AddSelected.Name = "Button_AddSelected";
            this.Button_AddSelected.Size = new System.Drawing.Size(83, 25);
            this.Button_AddSelected.TabIndex = 72;
            this.Button_AddSelected.Text = "Add Selected";
            this.Button_AddSelected.UseVisualStyleBackColor = true;
            this.Button_AddSelected.Click += new System.EventHandler(this.Button_AddSelected_Click);
            // 
            // ListView_Address
            // 
            this.ListView_Address.BackColor = System.Drawing.SystemColors.Control;
            this.ListView_Address.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._AddressHeader,
            this._ValueHeader});
            this.ListView_Address.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_Address.FullRowSelect = true;
            this.ListView_Address.Location = new System.Drawing.Point(-1, -1);
            this.ListView_Address.Name = "ListView_Address";
            this.ListView_Address.Size = new System.Drawing.Size(214, 226);
            this.ListView_Address.TabIndex = 71;
            this.ListView_Address.UseCompatibleStateImageBehavior = false;
            this.ListView_Address.View = System.Windows.Forms.View.Details;
            this.ListView_Address.VirtualMode = true;
            this.ListView_Address.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.ListView_Address_RetrieveVirtualItem);
            this.ListView_Address.DoubleClick += new System.EventHandler(this.ListView_Address_DoubleClick);
            this.ListView_Address.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListView_Address_MouseDown);
            // 
            // _AddressHeader
            // 
            this._AddressHeader.Text = "Address";
            this._AddressHeader.Width = 72;
            // 
            // _ValueHeader
            // 
            this._ValueHeader.Text = "Value";
            this._ValueHeader.Width = 134;
            // 
            // ListView_Table
            // 
            this.ListView_Table.BackColor = System.Drawing.SystemColors.Control;
            this.ListView_Table.CheckBoxes = true;
            this.ListView_Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CheckBoxHeader,
            this.DescriptionHeader,
            this.AddressHeader,
            this.TypeHeader,
            this.ValueHeader});
            this.ListView_Table.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_Table.FullRowSelect = true;
            this.ListView_Table.Location = new System.Drawing.Point(-1, 279);
            this.ListView_Table.Name = "ListView_Table";
            this.ListView_Table.ShowGroups = false;
            this.ListView_Table.Size = new System.Drawing.Size(572, 197);
            this.ListView_Table.TabIndex = 70;
            this.ListView_Table.UseCompatibleStateImageBehavior = false;
            this.ListView_Table.View = System.Windows.Forms.View.Details;
            this.ListView_Table.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListView_Table_ItemCheck);
            this.ListView_Table.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Table_MouseDoubleClick);
            // 
            // CheckBoxHeader
            // 
            this.CheckBoxHeader.Text = "";
            this.CheckBoxHeader.Width = 27;
            // 
            // DescriptionHeader
            // 
            this.DescriptionHeader.Text = "Description";
            this.DescriptionHeader.Width = 146;
            // 
            // AddressHeader
            // 
            this.AddressHeader.Text = "Address";
            this.AddressHeader.Width = 93;
            // 
            // TypeHeader
            // 
            this.TypeHeader.Text = "Type";
            this.TypeHeader.Width = 70;
            // 
            // ValueHeader
            // 
            this.ValueHeader.Text = "Value";
            this.ValueHeader.Width = 204;
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Label_Process,
            this.ToolStrip_Label_Credits});
            this.ToolStrip.Location = new System.Drawing.Point(0, 476);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(569, 25);
            this.ToolStrip.TabIndex = 75;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStrip_Label_Process
            // 
            this.ToolStrip_Label_Process.Name = "ToolStrip_Label_Process";
            this.ToolStrip_Label_Process.Size = new System.Drawing.Size(120, 22);
            this.ToolStrip_Label_Process.Text = "Process: Not Selected";
            // 
            // ToolStrip_Label_Credits
            // 
            this.ToolStrip_Label_Credits.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStrip_Label_Credits.Name = "ToolStrip_Label_Credits";
            this.ToolStrip_Label_Credits.Size = new System.Drawing.Size(146, 22);
            // 
            // Button_Scan_Abort
            // 
            this.Button_Scan_Abort.Enabled = false;
            this.Button_Scan_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Scan_Abort.Location = new System.Drawing.Point(494, -1);
            this.Button_Scan_Abort.Name = "Button_Scan_Abort";
            this.Button_Scan_Abort.Size = new System.Drawing.Size(70, 25);
            this.Button_Scan_Abort.TabIndex = 81;
            this.Button_Scan_Abort.Text = "Abort";
            this.Button_Scan_Abort.UseVisualStyleBackColor = true;
            this.Button_Scan_Abort.Click += new System.EventHandler(this.Button_Scan_Abort_Click);
            // 
            // Button_Scan_Next
            // 
            this.Button_Scan_Next.Enabled = false;
            this.Button_Scan_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Scan_Next.Location = new System.Drawing.Point(425, -1);
            this.Button_Scan_Next.Name = "Button_Scan_Next";
            this.Button_Scan_Next.Size = new System.Drawing.Size(70, 25);
            this.Button_Scan_Next.TabIndex = 80;
            this.Button_Scan_Next.Text = "Next Scan";
            this.Button_Scan_Next.UseVisualStyleBackColor = true;
            this.Button_Scan_Next.Click += new System.EventHandler(this.Button_Scan_Next_Click);
            // 
            // Button_Scan_Start
            // 
            this.Button_Scan_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Scan_Start.Location = new System.Drawing.Point(356, -1);
            this.Button_Scan_Start.Name = "Button_Scan_Start";
            this.Button_Scan_Start.Size = new System.Drawing.Size(70, 25);
            this.Button_Scan_Start.TabIndex = 79;
            this.Button_Scan_Start.Text = "Start Scan";
            this.Button_Scan_Start.UseVisualStyleBackColor = true;
            this.Button_Scan_Start.Click += new System.EventHandler(this.Button_Scan_Start_Click);
            // 
            // Button_Scan_New
            // 
            this.Button_Scan_New.Enabled = false;
            this.Button_Scan_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Scan_New.Location = new System.Drawing.Point(287, -1);
            this.Button_Scan_New.Name = "Button_Scan_New";
            this.Button_Scan_New.Size = new System.Drawing.Size(70, 25);
            this.Button_Scan_New.TabIndex = 78;
            this.Button_Scan_New.Text = "New Scan";
            this.Button_Scan_New.UseVisualStyleBackColor = true;
            this.Button_Scan_New.Click += new System.EventHandler(this.Button_Scan_New_Click);
            // 
            // Button_SelectProcess
            // 
            this.Button_SelectProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SelectProcess.Location = new System.Drawing.Point(218, -1);
            this.Button_SelectProcess.Name = "Button_SelectProcess";
            this.Button_SelectProcess.Size = new System.Drawing.Size(70, 25);
            this.Button_SelectProcess.TabIndex = 77;
            this.Button_SelectProcess.Text = "Process";
            this.Button_SelectProcess.UseVisualStyleBackColor = true;
            this.Button_SelectProcess.Click += new System.EventHandler(this.Button_SelectProcess_Click);
            // 
            // RadioButton_Truncated
            // 
            this.RadioButton_Truncated.AutoSize = true;
            this.RadioButton_Truncated.Checked = true;
            this.RadioButton_Truncated.Location = new System.Drawing.Point(464, 74);
            this.RadioButton_Truncated.Name = "RadioButton_Truncated";
            this.RadioButton_Truncated.Size = new System.Drawing.Size(74, 17);
            this.RadioButton_Truncated.TabIndex = 91;
            this.RadioButton_Truncated.TabStop = true;
            this.RadioButton_Truncated.Text = "Truncated";
            this.RadioButton_Truncated.UseVisualStyleBackColor = true;
            // 
            // TextBox_EndAddress
            // 
            this.TextBox_EndAddress.Location = new System.Drawing.Point(261, 184);
            this.TextBox_EndAddress.MaxLength = 8;
            this.TextBox_EndAddress.Name = "TextBox_EndAddress";
            this.TextBox_EndAddress.Size = new System.Drawing.Size(139, 20);
            this.TextBox_EndAddress.TabIndex = 99;
            this.TextBox_EndAddress.Text = "7FFFFFFF";
            // 
            // Label_From
            // 
            this.Label_From.AutoSize = true;
            this.Label_From.BackColor = System.Drawing.Color.Transparent;
            this.Label_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_From.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_From.Location = new System.Drawing.Point(232, 161);
            this.Label_From.Name = "Label_From";
            this.Label_From.Size = new System.Drawing.Size(33, 13);
            this.Label_From.TabIndex = 106;
            this.Label_From.Text = "From:";
            // 
            // TextBox_StartAddress
            // 
            this.TextBox_StartAddress.Location = new System.Drawing.Point(268, 158);
            this.TextBox_StartAddress.MaxLength = 8;
            this.TextBox_StartAddress.Name = "TextBox_StartAddress";
            this.TextBox_StartAddress.Size = new System.Drawing.Size(132, 20);
            this.TextBox_StartAddress.TabIndex = 98;
            this.TextBox_StartAddress.Text = "00000000";
            // 
            // Label_To
            // 
            this.Label_To.AutoSize = true;
            this.Label_To.BackColor = System.Drawing.Color.Transparent;
            this.Label_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_To.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_To.Location = new System.Drawing.Point(232, 186);
            this.Label_To.Name = "Label_To";
            this.Label_To.Size = new System.Drawing.Size(23, 13);
            this.Label_To.TabIndex = 107;
            this.Label_To.Text = "To:";
            // 
            // NUD_OptimizeScan
            // 
            this.NUD_OptimizeScan.Hexadecimal = true;
            this.NUD_OptimizeScan.Location = new System.Drawing.Point(486, 170);
            this.NUD_OptimizeScan.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUD_OptimizeScan.Name = "NUD_OptimizeScan";
            this.NUD_OptimizeScan.Size = new System.Drawing.Size(63, 20);
            this.NUD_OptimizeScan.TabIndex = 101;
            this.NUD_OptimizeScan.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // CheckBox_OptimizeScan
            // 
            this.CheckBox_OptimizeScan.AutoSize = true;
            this.CheckBox_OptimizeScan.Checked = true;
            this.CheckBox_OptimizeScan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_OptimizeScan.Location = new System.Drawing.Point(439, 138);
            this.CheckBox_OptimizeScan.Name = "CheckBox_OptimizeScan";
            this.CheckBox_OptimizeScan.Size = new System.Drawing.Size(94, 17);
            this.CheckBox_OptimizeScan.TabIndex = 100;
            this.CheckBox_OptimizeScan.Text = "Optimize Scan";
            this.CheckBox_OptimizeScan.UseVisualStyleBackColor = true;
            this.CheckBox_OptimizeScan.CheckedChanged += new System.EventHandler(this.CheckBox_OptimizeScan_CheckedChanged);
            // 
            // CheckBox_CompareToFirstCB
            // 
            this.CheckBox_CompareToFirstCB.AutoSize = true;
            this.CheckBox_CompareToFirstCB.Location = new System.Drawing.Point(284, 135);
            this.CheckBox_CompareToFirstCB.Name = "CheckBox_CompareToFirstCB";
            this.CheckBox_CompareToFirstCB.Size = new System.Drawing.Size(130, 17);
            this.CheckBox_CompareToFirstCB.TabIndex = 93;
            this.CheckBox_CompareToFirstCB.Text = "Compare to First Scan";
            this.CheckBox_CompareToFirstCB.UseVisualStyleBackColor = true;
            // 
            // ComboBox_DataType
            // 
            this.ComboBox_DataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_DataType.FormattingEnabled = true;
            this.ComboBox_DataType.Items.AddRange(new object[] {
            "Binary",
            "Byte",
            "Int 16",
            "Int 32",
            "Int 64",
            "Single",
            "Double",
            "Text",
            "Array of Bytes",
            "All (Byte to Double)"});
            this.ComboBox_DataType.Location = new System.Drawing.Point(284, 94);
            this.ComboBox_DataType.Name = "ComboBox_DataType";
            this.ComboBox_DataType.Size = new System.Drawing.Size(162, 21);
            this.ComboBox_DataType.TabIndex = 90;
            this.ComboBox_DataType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_DataType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(244, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Data:";
            // 
            // RadioButton_Rounded
            // 
            this.RadioButton_Rounded.AutoSize = true;
            this.RadioButton_Rounded.Location = new System.Drawing.Point(464, 97);
            this.RadioButton_Rounded.Name = "RadioButton_Rounded";
            this.RadioButton_Rounded.Size = new System.Drawing.Size(69, 17);
            this.RadioButton_Rounded.TabIndex = 92;
            this.RadioButton_Rounded.Text = "Rounded";
            this.RadioButton_Rounded.UseVisualStyleBackColor = true;
            // 
            // Label_Compare
            // 
            this.Label_Compare.AutoSize = true;
            this.Label_Compare.Location = new System.Drawing.Point(226, 69);
            this.Label_Compare.Name = "Label_Compare";
            this.Label_Compare.Size = new System.Drawing.Size(52, 13);
            this.Label_Compare.TabIndex = 96;
            this.Label_Compare.Text = "Compare:";
            // 
            // ComboBox_CompareType
            // 
            this.ComboBox_CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CompareType.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_CompareType.FormattingEnabled = true;
            this.ComboBox_CompareType.Items.AddRange(new object[] {
            "=",
            "Ø",
            "±",
            "≠",
            "+",
            "-",
            "+x",
            "-x",
            "<",
            ">",
            "≤",
            "≥",
            "> <",
            "≥ ≤",
            "??"});
            this.ComboBox_CompareType.Location = new System.Drawing.Point(284, 65);
            this.ComboBox_CompareType.Name = "ComboBox_CompareType";
            this.ComboBox_CompareType.Size = new System.Drawing.Size(48, 23);
            this.ComboBox_CompareType.TabIndex = 89;
            this.ComboBox_CompareType.Tag = "";
            this.ComboBox_CompareType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_CompareType_SelectedIndexChanged);
            // 
            // Label_CompareType
            // 
            this.Label_CompareType.AutoSize = true;
            this.Label_CompareType.Location = new System.Drawing.Point(334, 69);
            this.Label_CompareType.Name = "Label_CompareType";
            this.Label_CompareType.Size = new System.Drawing.Size(112, 13);
            this.Label_CompareType.TabIndex = 97;
            this.Label_CompareType.Text = "Greater Than or Equal";
            // 
            // CheckedListBox_Type
            // 
            this.CheckedListBox_Type.FormattingEnabled = true;
            this.CheckedListBox_Type.Items.AddRange(new object[] {
            "Private",
            "Image",
            "Mapped"});
            this.CheckedListBox_Type.Location = new System.Drawing.Point(394, 239);
            this.CheckedListBox_Type.Name = "CheckedListBox_Type";
            this.CheckedListBox_Type.Size = new System.Drawing.Size(170, 34);
            this.CheckedListBox_Type.TabIndex = 105;
            // 
            // CheckedListBox_Protection
            // 
            this.CheckedListBox_Protection.FormattingEnabled = true;
            this.CheckedListBox_Protection.Items.AddRange(new object[] {
            "No Access",
            "Read Only",
            "Read+Write",
            "WriteCopy",
            "Executable",
            "Executable+Read",
            "Executable+Read+Write",
            "Executable+WriteCopy"});
            this.CheckedListBox_Protection.Location = new System.Drawing.Point(218, 239);
            this.CheckedListBox_Protection.Name = "CheckedListBox_Protection";
            this.CheckedListBox_Protection.Size = new System.Drawing.Size(170, 34);
            this.CheckedListBox_Protection.TabIndex = 104;
            // 
            // Label_MemoryType
            // 
            this.Label_MemoryType.AutoSize = true;
            this.Label_MemoryType.Location = new System.Drawing.Point(447, 223);
            this.Label_MemoryType.Name = "Label_MemoryType";
            this.Label_MemoryType.Size = new System.Drawing.Size(71, 13);
            this.Label_MemoryType.TabIndex = 108;
            this.Label_MemoryType.Text = "Memory Type";
            // 
            // Label_MemoryProtection
            // 
            this.Label_MemoryProtection.AutoSize = true;
            this.Label_MemoryProtection.Location = new System.Drawing.Point(258, 223);
            this.Label_MemoryProtection.Name = "Label_MemoryProtection";
            this.Label_MemoryProtection.Size = new System.Drawing.Size(95, 13);
            this.Label_MemoryProtection.TabIndex = 109;
            this.Label_MemoryProtection.Text = "Memory Protection";
            // 
            // RadioButton_LastDigits
            // 
            this.RadioButton_LastDigits.AutoSize = true;
            this.RadioButton_LastDigits.Location = new System.Drawing.Point(406, 184);
            this.RadioButton_LastDigits.Name = "RadioButton_LastDigits";
            this.RadioButton_LastDigits.Size = new System.Drawing.Size(74, 17);
            this.RadioButton_LastDigits.TabIndex = 103;
            this.RadioButton_LastDigits.Text = "Last Digits";
            this.RadioButton_LastDigits.UseVisualStyleBackColor = true;
            // 
            // TextBox_ScanValue
            // 
            this.TextBox_ScanValue.Location = new System.Drawing.Point(304, 30);
            this.TextBox_ScanValue.Name = "TextBox_ScanValue";
            this.TextBox_ScanValue.Size = new System.Drawing.Size(214, 20);
            this.TextBox_ScanValue.TabIndex = 87;
            // 
            // ScanSecondValueTextBox
            // 
            this.ScanSecondValueTextBox.Location = new System.Drawing.Point(414, 30);
            this.ScanSecondValueTextBox.Name = "ScanSecondValueTextBox";
            this.ScanSecondValueTextBox.Size = new System.Drawing.Size(104, 20);
            this.ScanSecondValueTextBox.TabIndex = 88;
            this.ScanSecondValueTextBox.Visible = false;
            // 
            // CheckBox_IsHex
            // 
            this.CheckBox_IsHex.AutoSize = true;
            this.CheckBox_IsHex.Location = new System.Drawing.Point(245, 32);
            this.CheckBox_IsHex.Name = "CheckBox_IsHex";
            this.CheckBox_IsHex.Size = new System.Drawing.Size(56, 17);
            this.CheckBox_IsHex.TabIndex = 94;
            this.CheckBox_IsHex.Text = "Value:";
            this.CheckBox_IsHex.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Allignment
            // 
            this.RadioButton_Allignment.AutoSize = true;
            this.RadioButton_Allignment.Checked = true;
            this.RadioButton_Allignment.Location = new System.Drawing.Point(406, 161);
            this.RadioButton_Allignment.Name = "RadioButton_Allignment";
            this.RadioButton_Allignment.Size = new System.Drawing.Size(71, 17);
            this.RadioButton_Allignment.TabIndex = 102;
            this.RadioButton_Allignment.TabStop = true;
            this.RadioButton_Allignment.Text = "Alignment";
            this.RadioButton_Allignment.UseVisualStyleBackColor = true;
            // 
            // UpdateFoundTimer
            // 
            this.UpdateFoundTimer.Enabled = true;
            this.UpdateFoundTimer.Interval = 513;
            this.UpdateFoundTimer.Tick += new System.EventHandler(this.UpdateFoundTimer_Tick);
            // 
            // WriteTimer
            // 
            this.WriteTimer.Enabled = true;
            this.WriteTimer.Interval = 9;
            this.WriteTimer.Tick += new System.EventHandler(this.WriteTimer_Tick);
            // 
            // RightClickMenu_AddressList
            // 
            this.RightClickMenu_AddressList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToTableToolStripMenuItem,
            this.showItemsAsSignedToolStripMenuItem});
            this.RightClickMenu_AddressList.Name = "AddressListViewRightClickMenu";
            this.RightClickMenu_AddressList.Size = new System.Drawing.Size(189, 48);
            // 
            // addItemToTableToolStripMenuItem
            // 
            this.addItemToTableToolStripMenuItem.Name = "addItemToTableToolStripMenuItem";
            this.addItemToTableToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addItemToTableToolStripMenuItem.Text = "Add Item to Table";
            this.addItemToTableToolStripMenuItem.Click += new System.EventHandler(this.addItemToTableToolStripMenuItem_Click);
            // 
            // showItemsAsSignedToolStripMenuItem
            // 
            this.showItemsAsSignedToolStripMenuItem.Name = "showItemsAsSignedToolStripMenuItem";
            this.showItemsAsSignedToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showItemsAsSignedToolStripMenuItem.Text = "Show Items as Signed";
            this.showItemsAsSignedToolStripMenuItem.Click += new System.EventHandler(this.showItemsAsSignedToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 501);
            this.Controls.Add(this.RadioButton_Truncated);
            this.Controls.Add(this.TextBox_EndAddress);
            this.Controls.Add(this.Label_From);
            this.Controls.Add(this.TextBox_StartAddress);
            this.Controls.Add(this.Label_To);
            this.Controls.Add(this.NUD_OptimizeScan);
            this.Controls.Add(this.CheckBox_OptimizeScan);
            this.Controls.Add(this.CheckBox_CompareToFirstCB);
            this.Controls.Add(this.ComboBox_DataType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RadioButton_Rounded);
            this.Controls.Add(this.Label_Compare);
            this.Controls.Add(this.ComboBox_CompareType);
            this.Controls.Add(this.Label_CompareType);
            this.Controls.Add(this.CheckedListBox_Type);
            this.Controls.Add(this.CheckedListBox_Protection);
            this.Controls.Add(this.Label_MemoryType);
            this.Controls.Add(this.Label_MemoryProtection);
            this.Controls.Add(this.RadioButton_LastDigits);
            this.Controls.Add(this.TextBox_ScanValue);
            this.Controls.Add(this.ScanSecondValueTextBox);
            this.Controls.Add(this.CheckBox_IsHex);
            this.Controls.Add(this.RadioButton_Allignment);
            this.Controls.Add(this.Button_Scan_Abort);
            this.Controls.Add(this.Button_Scan_Next);
            this.Controls.Add(this.Button_Scan_Start);
            this.Controls.Add(this.Button_Scan_New);
            this.Controls.Add(this.Button_SelectProcess);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Button_Table_Clear);
            this.Controls.Add(this.Button_AddSpecific);
            this.Controls.Add(this.Button_AddSelected);
            this.Controls.Add(this.ListView_Address);
            this.Controls.Add(this.ListView_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "SMScan";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_OptimizeScan)).EndInit();
            this.RightClickMenu_AddressList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button Button_Table_Clear;
        private System.Windows.Forms.Button Button_AddSpecific;
        private System.Windows.Forms.Button Button_AddSelected;
        private System.Windows.Forms.ListView ListView_Address;
        private System.Windows.Forms.ColumnHeader _AddressHeader;
        private System.Windows.Forms.ColumnHeader _ValueHeader;
        private System.Windows.Forms.ListView ListView_Table;
        private System.Windows.Forms.ColumnHeader CheckBoxHeader;
        private System.Windows.Forms.ColumnHeader DescriptionHeader;
        private System.Windows.Forms.ColumnHeader AddressHeader;
        private System.Windows.Forms.ColumnHeader TypeHeader;
        private System.Windows.Forms.ColumnHeader ValueHeader;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripLabel ToolStrip_Label_Process;
        private System.Windows.Forms.ToolStripLabel ToolStrip_Label_Credits;
 //       private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
 //       private Microsoft.VisualBasic.PowerPacks.LineShape LineShape_ProgressBar;
        private System.Windows.Forms.Button Button_Scan_Abort;
        private System.Windows.Forms.Button Button_Scan_Next;
        private System.Windows.Forms.Button Button_Scan_Start;
        private System.Windows.Forms.Button Button_Scan_New;
        private System.Windows.Forms.Button Button_SelectProcess;
        private System.Windows.Forms.RadioButton RadioButton_Truncated;
        private System.Windows.Forms.TextBox TextBox_EndAddress;
        private System.Windows.Forms.Label Label_From;
        private System.Windows.Forms.TextBox TextBox_StartAddress;
        private System.Windows.Forms.Label Label_To;
        private System.Windows.Forms.NumericUpDown NUD_OptimizeScan;
        private System.Windows.Forms.CheckBox CheckBox_OptimizeScan;
        private System.Windows.Forms.CheckBox CheckBox_CompareToFirstCB;
        private System.Windows.Forms.ComboBox ComboBox_DataType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RadioButton_Rounded;
        private System.Windows.Forms.Label Label_Compare;
        private System.Windows.Forms.ComboBox ComboBox_CompareType;
        private System.Windows.Forms.Label Label_CompareType;
        private System.Windows.Forms.CheckedListBox CheckedListBox_Type;
        private System.Windows.Forms.CheckedListBox CheckedListBox_Protection;
        private System.Windows.Forms.Label Label_MemoryType;
        private System.Windows.Forms.Label Label_MemoryProtection;
        private System.Windows.Forms.RadioButton RadioButton_LastDigits;
        private System.Windows.Forms.TextBox TextBox_ScanValue;
        private System.Windows.Forms.TextBox ScanSecondValueTextBox;
        private System.Windows.Forms.CheckBox CheckBox_IsHex;
        private System.Windows.Forms.RadioButton RadioButton_Allignment;
        private System.Windows.Forms.Timer UpdateFoundTimer;
        private System.Windows.Forms.Timer WriteTimer;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu_AddressList;
        private System.Windows.Forms.ToolStripMenuItem addItemToTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showItemsAsSignedToolStripMenuItem;
    }
}

