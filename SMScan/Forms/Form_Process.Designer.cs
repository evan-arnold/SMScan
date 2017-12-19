namespace SMScan.Forms
{
    partial class Form_Process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Process));
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.ListView_Process = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Button_Close
            // 
            this.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Location = new System.Drawing.Point(-1, 309);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(307, 23);
            this.Button_Close.TabIndex = 8;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Refresh.Location = new System.Drawing.Point(-1, 287);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(307, 23);
            this.Button_Refresh.TabIndex = 9;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Button_Accept
            // 
            this.Button_Accept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Accept.Location = new System.Drawing.Point(-1, 265);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(307, 23);
            this.Button_Accept.TabIndex = 10;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // ListView_Process
            // 
            this.ListView_Process.AutoArrange = false;
            this.ListView_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView_Process.FullRowSelect = true;
            this.ListView_Process.LabelWrap = false;
            this.ListView_Process.Location = new System.Drawing.Point(0, 0);
            this.ListView_Process.MultiSelect = false;
            this.ListView_Process.Name = "ListView_Process";
            this.ListView_Process.ShowGroups = false;
            this.ListView_Process.Size = new System.Drawing.Size(304, 265);
            this.ListView_Process.TabIndex = 11;
            this.ListView_Process.TileSize = new System.Drawing.Size(16, 16);
            this.ListView_Process.UseCompatibleStateImageBehavior = false;
            this.ListView_Process.View = System.Windows.Forms.View.SmallIcon;
            this.ListView_Process.DoubleClick += new System.EventHandler(this.ListView_Process_DoubleClick);
            // 
            // Form_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 331);
            this.ControlBox = false;
            this.Controls.Add(this.ListView_Process);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.Button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Process";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select Process";
            this.Load += new System.EventHandler(this.Form_Process_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.ListView ListView_Process;
    }
}