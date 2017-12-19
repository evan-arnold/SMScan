namespace SMScan
{
    partial class Form_EditValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditValue));
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.CheckBox_IsHex = new System.Windows.Forms.CheckBox();
            this.Label_ChangeValue = new System.Windows.Forms.Label();
            this.TextBox_Value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Location = new System.Drawing.Point(-2, 72);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(325, 23);
            this.Button_Cancel.TabIndex = 4;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Accept
            // 
            this.Button_Accept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Accept.Location = new System.Drawing.Point(-2, 50);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(325, 23);
            this.Button_Accept.TabIndex = 5;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // CheckBox_IsHex
            // 
            this.CheckBox_IsHex.AutoSize = true;
            this.CheckBox_IsHex.Location = new System.Drawing.Point(267, 26);
            this.CheckBox_IsHex.Name = "CheckBox_IsHex";
            this.CheckBox_IsHex.Size = new System.Drawing.Size(45, 17);
            this.CheckBox_IsHex.TabIndex = 9;
            this.CheckBox_IsHex.Text = "Hex";
            this.CheckBox_IsHex.UseVisualStyleBackColor = true;
            // 
            // Label_ChangeValue
            // 
            this.Label_ChangeValue.AutoSize = true;
            this.Label_ChangeValue.Location = new System.Drawing.Point(16, 8);
            this.Label_ChangeValue.Name = "Label_ChangeValue";
            this.Label_ChangeValue.Size = new System.Drawing.Size(77, 13);
            this.Label_ChangeValue.TabIndex = 10;
            this.Label_ChangeValue.Text = "Change Value:";
            // 
            // TextBox_Value
            // 
            this.TextBox_Value.Location = new System.Drawing.Point(19, 24);
            this.TextBox_Value.Name = "TextBox_Value";
            this.TextBox_Value.Size = new System.Drawing.Size(242, 20);
            this.TextBox_Value.TabIndex = 8;
            this.TextBox_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_EditValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 94);
            this.ControlBox = false;
            this.Controls.Add(this.CheckBox_IsHex);
            this.Controls.Add(this.Label_ChangeValue);
            this.Controls.Add(this.TextBox_Value);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.Button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EditValue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit Value";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EditValue_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.CheckBox CheckBox_IsHex;
        private System.Windows.Forms.Label Label_ChangeValue;
        private System.Windows.Forms.TextBox TextBox_Value;
    }
}