namespace SMScan
{
    partial class Form_EditDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditDescription));
            this.Label_ChangeDescription = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_ChangeDescription
            // 
            this.Label_ChangeDescription.AutoSize = true;
            this.Label_ChangeDescription.Location = new System.Drawing.Point(12, 8);
            this.Label_ChangeDescription.Name = "Label_ChangeDescription";
            this.Label_ChangeDescription.Size = new System.Drawing.Size(103, 13);
            this.Label_ChangeDescription.TabIndex = 7;
            this.Label_ChangeDescription.Text = "Change Description:";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Location = new System.Drawing.Point(-1, 72);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(294, 23);
            this.Button_Cancel.TabIndex = 6;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_Accept
            // 
            this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Accept.Location = new System.Drawing.Point(-1, 50);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(294, 23);
            this.Button_Accept.TabIndex = 5;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Location = new System.Drawing.Point(15, 24);
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(265, 20);
            this.TextBox_Description.TabIndex = 4;
            this.TextBox_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_EditDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 94);
            this.ControlBox = false;
            this.Controls.Add(this.Label_ChangeDescription);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.TextBox_Description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EditDescription";
            this.ShowInTaskbar = false;
            this.Text = "Change Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ChangeDescription;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.TextBox TextBox_Description;
    }
}