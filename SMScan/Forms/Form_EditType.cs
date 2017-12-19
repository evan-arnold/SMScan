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

namespace SMScan
{
    public partial class Form_EditType : Form
    {
        #region Variables & Initialization
        public ScanDataType ScanType;

        public Form_EditType(ScanDataType ScanType)
        {
            InitializeComponent();
            this.ScanType = ScanType;
        }

        private void Form_EditType_Load(object sender, EventArgs e)
        {
            ComboBox_ValueType.SelectedIndex = (int)ScanType;
            Button_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion

        #region Events
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            ScanType = (ScanDataType)ComboBox_ValueType.SelectedIndex;
        }
        #endregion
    }
}
