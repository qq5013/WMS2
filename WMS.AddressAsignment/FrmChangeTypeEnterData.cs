using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace WMS.AddressAsignment
{
    public partial class FrmChangeTypeEnterData : DevExpress.XtraEditors.XtraForm
    {
        public FrmChangeTypeEnterData()
        {
            InitializeComponent();
        }

        private void ScanOneButtonClick(object sender, EventArgs e)
        {
            Close();
            FrmAddressAsignmentOnNonAcceptedDoc.SetTypeOfScan(FrmAddressAsignmentOnNonAcceptedDoc.TypeOfScan.ScanOne);
            DialogResult = DialogResult.OK;
        }

        private void ScanQtyButtonClick(object sender, EventArgs e)
        {
            Close();
            FrmAddressAsignmentOnNonAcceptedDoc.SetTypeOfScan(FrmAddressAsignmentOnNonAcceptedDoc.TypeOfScan.ScanQty);
            DialogResult = DialogResult.OK;
        }

        private void EnterManualQtyButtonClick(object sender, EventArgs e)
        {
            Close();
            FrmAddressAsignmentOnNonAcceptedDoc.SetTypeOfScan(FrmAddressAsignmentOnNonAcceptedDoc.TypeOfScan.ManualQty);
            DialogResult = DialogResult.OK;
        }
    }
}