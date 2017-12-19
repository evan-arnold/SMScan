namespace SMScan
{
    partial class Form_EditAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditAddress));
            this.CheckBox_IsHex = new System.Windows.Forms.CheckBox();
            this.Label_ChangeAddress = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.TextBox_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckBox_IsHex
            // 
            this.CheckBox_IsHex.AutoSize = true;
            this.CheckBox_IsHex.Checked = true;
            this.CheckBox_IsHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_IsHex.Location = new System.Drawing.Point(261, 30);
            this.CheckBox_IsHex.Name = "CheckBox_IsHex";
            this.CheckBox_IsHex.Size = new System.Drawing.Size(45, 17);
            this.CheckBox_IsHex.TabIndex = 9;
            this.CheckBox_IsHex.Text = "Hex";
            this.CheckBox_IsHex.UseVisualStyleBackColor = true;
            // 
            // Label_ChangeAddress
            // 
            this.Label_ChangeAddress.AutoSize = true;
            this.Label_ChangeAddress.Location = new System.Drawing.Point(8, 8);
            this.Label_ChangeAddress.Name = "Label_ChangeAddress";
            this.Label_ChangeAddress.Size = new System.Drawing.Size(88, 13);
            this.Label_ChangeAddress.TabIndex = 12;
            this.Label_ChangeAddress.Text = "Change Address:";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Location = new System.Drawing.Point(-2, 76);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(322, 23);
            this.Button_Cancel.TabIndex = 11;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_Accept
            // 
            this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Accept.Location = new System.Drawing.Point(-2, 54);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(322, 23);
            this.Button_Accept.TabIndex = 10;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.Location = new System.Drawing.Point(11, 28);
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(244, 20);
            this.TextBox_Address.TabIndex = 8;
            this.TextBox_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_EditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 98);
            this.ControlBox = false;
            this.Controls.Add(this.CheckBox_IsHex);
            this.Controls.Add(this.Label_ChangeAddress);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.TextBox_Address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EditAddress";
            this.ShowInTaskbar = false;
            this.Text = "Edit Address";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EditAddress_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_IsHex;
        private System.Windows.Forms.Label Label_ChangeAddress;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.TextBox TextBox_Address;
    }
}