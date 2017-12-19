namespace SMScan
{
    partial class Form_AddSpecific
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddSpecific));
            this.CheckBox_IsHex = new System.Windows.Forms.CheckBox();
            this.ComboBox_ValueType = new System.Windows.Forms.ComboBox();
            this.CheckBox_Pointer = new System.Windows.Forms.CheckBox();
            this.TextBox_Address = new System.Windows.Forms.TextBox();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Label_Description = new System.Windows.Forms.Label();
            this.Label_Address = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBox_IsHex
            // 
            this.CheckBox_IsHex.AutoSize = true;
            this.CheckBox_IsHex.Checked = true;
            this.CheckBox_IsHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_IsHex.Location = new System.Drawing.Point(247, 8);
            this.CheckBox_IsHex.Name = "CheckBox_IsHex";
            this.CheckBox_IsHex.Size = new System.Drawing.Size(45, 17);
            this.CheckBox_IsHex.TabIndex = 65;
            this.CheckBox_IsHex.Text = "Hex";
            this.CheckBox_IsHex.UseVisualStyleBackColor = true;
            // 
            // ComboBox_ValueType
            // 
            this.ComboBox_ValueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ValueType.FormattingEnabled = true;
            this.ComboBox_ValueType.Items.AddRange(new object[] {
            "Binary",
            "Byte",
            "Int 16",
            "Int 32",
            "Int 64",
            "Single",
            "Double",
            "Text",
            "Array of bytes"});
            this.ComboBox_ValueType.Location = new System.Drawing.Point(52, 54);
            this.ComboBox_ValueType.Name = "ComboBox_ValueType";
            this.ComboBox_ValueType.Size = new System.Drawing.Size(122, 21);
            this.ComboBox_ValueType.TabIndex = 58;
            // 
            // CheckBox_Pointer
            // 
            this.CheckBox_Pointer.AutoSize = true;
            this.CheckBox_Pointer.Location = new System.Drawing.Point(180, 56);
            this.CheckBox_Pointer.Name = "CheckBox_Pointer";
            this.CheckBox_Pointer.Size = new System.Drawing.Size(114, 17);
            this.CheckBox_Pointer.TabIndex = 60;
            this.CheckBox_Pointer.Text = "Pointer (Not Done)";
            this.CheckBox_Pointer.UseVisualStyleBackColor = true;
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.Location = new System.Drawing.Point(66, 5);
            this.TextBox_Address.MaxLength = 8;
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(175, 20);
            this.TextBox_Address.TabIndex = 56;
            this.TextBox_Address.Text = "0100579C";
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Location = new System.Drawing.Point(81, 28);
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(198, 20);
            this.TextBox_Description.TabIndex = 57;
            this.TextBox_Description.Text = "No Description";
            // 
            // Label_Type
            // 
            this.Label_Type.AutoSize = true;
            this.Label_Type.Location = new System.Drawing.Point(12, 57);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(34, 13);
            this.Label_Type.TabIndex = 62;
            this.Label_Type.Text = "Type:";
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.Location = new System.Drawing.Point(12, 31);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(63, 13);
            this.Label_Description.TabIndex = 61;
            this.Label_Description.Text = "Description:";
            // 
            // Label_Address
            // 
            this.Label_Address.AutoSize = true;
            this.Label_Address.Location = new System.Drawing.Point(12, 8);
            this.Label_Address.Name = "Label_Address";
            this.Label_Address.Size = new System.Drawing.Size(48, 13);
            this.Label_Address.TabIndex = 59;
            this.Label_Address.Text = "Address:";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Location = new System.Drawing.Point(-1, 102);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(293, 23);
            this.Button_Cancel.TabIndex = 64;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Accept
            // 
            this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Accept.Location = new System.Drawing.Point(-1, 80);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(293, 23);
            this.Button_Accept.TabIndex = 63;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // Form_AddSpecific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 124);
            this.ControlBox = false;
            this.Controls.Add(this.CheckBox_IsHex);
            this.Controls.Add(this.ComboBox_ValueType);
            this.Controls.Add(this.CheckBox_Pointer);
            this.Controls.Add(this.TextBox_Address);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.Label_Type);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.Label_Address);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AddSpecific";
            this.ShowInTaskbar = false;
            this.Text = "Add Specific Address";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_AddSpecific_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_IsHex;
        private System.Windows.Forms.ComboBox ComboBox_ValueType;
        private System.Windows.Forms.CheckBox CheckBox_Pointer;
        private System.Windows.Forms.TextBox TextBox_Address;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.Label Label_Address;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Accept;
    }
}