namespace SMScan
{
    partial class Form_EditType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditType));
            this.ComboBox_ValueType = new System.Windows.Forms.ComboBox();
            this.Label_ChangeType = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            "Array of Bytes",
            "All (Byte to Double)"});
            this.ComboBox_ValueType.Location = new System.Drawing.Point(92, 6);
            this.ComboBox_ValueType.Name = "ComboBox_ValueType";
            this.ComboBox_ValueType.Size = new System.Drawing.Size(188, 21);
            this.ComboBox_ValueType.TabIndex = 8;
            // 
            // Label_ChangeType
            // 
            this.Label_ChangeType.AutoSize = true;
            this.Label_ChangeType.Location = new System.Drawing.Point(12, 9);
            this.Label_ChangeType.Name = "Label_ChangeType";
            this.Label_ChangeType.Size = new System.Drawing.Size(74, 13);
            this.Label_ChangeType.TabIndex = 11;
            this.Label_ChangeType.Text = "Change Type:";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Location = new System.Drawing.Point(-1, 57);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(295, 23);
            this.Button_Cancel.TabIndex = 10;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Accept
            // 
            this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Accept.Location = new System.Drawing.Point(-1, 35);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(295, 23);
            this.Button_Accept.TabIndex = 9;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // Form_EditType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 79);
            this.ControlBox = false;
            this.Controls.Add(this.ComboBox_ValueType);
            this.Controls.Add(this.Label_ChangeType);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EditType";
            this.ShowInTaskbar = false;
            this.Text = "Change Type";
            this.Load += new System.EventHandler(this.Form_EditType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_ValueType;
        private System.Windows.Forms.Label Label_ChangeType;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Accept;
    }
}