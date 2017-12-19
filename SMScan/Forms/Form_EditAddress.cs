using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMScan.MemoryScanner;
using SMScan;

namespace SMScan
{
    public partial class Form_EditAddress : Form
    {
        public UInt64 Address;
        private bool failed = false;

        public Form_EditAddress(string address)
        {
            InitializeComponent();
            Button_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            TextBox_Address.Text = address;
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            string ValueString = TextBox_Address.Text;

            if (!CheckBox_IsHex.Checked)
                if (CheckSyntax.Int32Value(ValueString, CheckBox_IsHex.Checked))
                    Address = Convert.ToUInt64(ValueString);
                else
                {
                    MessageBox.Show("Invalid address format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    failed = true;
                }

            else if (CheckSyntax.Address(ValueString))
                Address = Conversions.Conversions.HexToUInt64(TextBox_Address.Text);
            else
            {
                MessageBox.Show("Invalid address format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failed = true;
            }
        }

        private void Form_EditAddress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (failed)
                e.Cancel = true;
            failed = false;
        }
    }
}
