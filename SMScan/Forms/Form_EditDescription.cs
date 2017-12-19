using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMScan
{
    public partial class Form_EditDescription : Form
    {
        public string Description;

        public Form_EditDescription(string description)
        {
            InitializeComponent();
            Button_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            TextBox_Description.Text = description;
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            Description = TextBox_Description.Text;
        }
    }
}
