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
    public partial class Form_AddSpecific : Form
    {
        #region Variables & Initialization
        public ScanDataType ScanType;
        public string Address, Description;
        public int changeType;

        public Form_AddSpecific(bool isChanged, string address, string description, ScanDataType scanType)
        {
            InitializeComponent();
            if (isChanged == true)
            {
                this.Text = "Change Specific Address";
                TextBox_Address.Text = Address;
                TextBox_Description.Text = Description;
                ComboBox_ValueType.SelectedIndex = changeType;
                ScanType = scanType;
                ComboBox_ValueType.SelectedIndex = (int)ScanType;
            }
            else
            {
                this.Text = "Add Specific Address";
            }
        }

        private void Form_AddSpecific_Load(object sender, EventArgs e)
        {
            ComboBox_ValueType.SelectedIndex = (int)ScanDataType.Int32;
        }
        #endregion

        #region Events
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button_Accept_Click(object sender, EventArgs e)
        {
            if (CheckBox_IsHex.Checked == true)
            {
                if (!CheckSyntax.Address(TextBox_Address.Text))
                {
                    MessageBox.Show("Invalid address format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Address = TextBox_Address.Text;
            }
            else
            {
                if (!CheckSyntax.Int32Value(TextBox_Address.Text, false))
                {
                    MessageBox.Show("Invalid address format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Address = Conversions.Conversions.ToHex(TextBox_Address.Text);
            }

            if (TextBox_Description.Text == "")
                Description = "No Description";
            else
                Description = TextBox_Description.Text;

            switch (ComboBox_ValueType.SelectedIndex)
            {
                case 0:
                    ScanType = ScanDataType.Binary;
                    break;
                case 1:
                    ScanType = ScanDataType.Byte;
                    break;
                case 2:
                    ScanType = ScanDataType.Int16;
                    break;
                case 3:
                    ScanType = ScanDataType.Int32;
                    break;
                case 4:
                    ScanType = ScanDataType.Int64;
                    break;
                case 5:
                    ScanType = ScanDataType.Single;
                    break;
                case 6:
                    ScanType = ScanDataType.Double;
                    break;
                case 7:
                    ScanType = ScanDataType.Text;
                    break;
                case 8:
                    ScanType = ScanDataType.AOB;
                    break;
                case 9:
                    ScanType = ScanDataType.All;
                    break;
            }
            this.Close();
        }
        #endregion
    }
}
