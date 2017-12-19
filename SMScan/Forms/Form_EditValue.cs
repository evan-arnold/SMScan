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
    public partial class Form_EditValue : Form
    {
        #region Variables/Initialization
        public object Value;
        private ScanDataType ScanType;
        private bool failed = false;

        public Form_EditValue(ScanDataType ScanType, object Value)
        {
            InitializeComponent();
            Button_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.ScanType = ScanType;
            this.Value = Value;

            TextBox_Value.Text = Value.ToString();
        }
        #endregion

        #region Events
        private void Button_Accept_Click(object sender, EventArgs e)
        {
            string ValueString = TextBox_Value.Text;

            switch (ScanType)
            {
                case ScanDataType.Binary:
                    if (CheckSyntax.BinaryValue(ValueString))
                        Value = Conversions.Conversions.ToUnsigned(ValueString, ScanType);
                    else
                        failed = true;
                    break;
                case ScanDataType.Byte:
                    //Check syntax
                    if (CheckSyntax.ByteValue(ValueString, CheckBox_IsHex.Checked))
                        if (!CheckBox_IsHex.Checked)
                            //Take unsigned value
                            Value = Conversions.Conversions.ToUnsigned(ValueString, ScanType);
                        else //Take unsigned value after converting it from hex
                            Value = Conversions.Conversions.ToUnsigned(Conversions.Conversions.HexToByte(ValueString).ToString(), ScanType);
                    else //Invalid syntax
                        failed = true;
                    break;
                case ScanDataType.Int16:
                    if (CheckSyntax.Int32Value(ValueString, CheckBox_IsHex.Checked))
                        if (!CheckBox_IsHex.Checked)
                            Value = Conversions.Conversions.ToUnsigned(ValueString, ScanType);
                        else
                            Value = Conversions.Conversions.ToUnsigned(Conversions.Conversions.HexToShort(ValueString).ToString(), ScanType);
                    else
                        failed = true;
                    break;
                case ScanDataType.Int32:
                    if (CheckSyntax.Int32Value(ValueString, CheckBox_IsHex.Checked))
                        if (!CheckBox_IsHex.Checked)
                            Value = Conversions.Conversions.ToUnsigned(ValueString, ScanType);
                        else
                            Value = Conversions.Conversions.ToUnsigned(Conversions.Conversions.HexToInt(ValueString).ToString(), ScanType);
                    else
                        failed = true;
                    break;
                case ScanDataType.Int64:
                    if (CheckSyntax.Int64Value(ValueString, CheckBox_IsHex.Checked))
                        if (!CheckBox_IsHex.Checked)
                            Value = Conversions.Conversions.ToUnsigned(ValueString, ScanType);
                        else
                            Value = Conversions.Conversions.ToUnsigned(Conversions.Conversions.HexToUInt64(ValueString).ToString(), ScanType);
                    else
                        failed = true;
                    break;
                case ScanDataType.Single:
                    if (CheckSyntax.SingleValue(ValueString, CheckBox_IsHex.Checked))
                        if (!CheckBox_IsHex.Checked)
                            Value = Conversions.Conversions.ToUnsigned(ValueString, ScanType);
                        else
                            Value = Conversions.Conversions.ToUnsigned(Conversions.Conversions.HexToSingle(ValueString).ToString(), ScanType);
                    else
                        failed = true;
                    break;
                case ScanDataType.Double:
                    if (CheckSyntax.DoubleValue(ValueString, CheckBox_IsHex.Checked))
                        if (!CheckBox_IsHex.Checked)
                            Value = Conversions.Conversions.ToUnsigned(ValueString, ScanType);
                        else
                            Value = Conversions.Conversions.ToUnsigned(Conversions.Conversions.HexToDouble(ValueString).ToString(), ScanType);
                    else
                        failed = true;
                    break;
                case ScanDataType.Text:
                    //TODO: everything
                    Value = ValueString;
                    break;
            }

            if (failed)
                MessageBox.Show("Invalid value format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_EditValue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (failed)
                e.Cancel = true;
            failed = false;
        }

        #endregion
    }
}
