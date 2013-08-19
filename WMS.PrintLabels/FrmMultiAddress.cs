using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;
namespace WMS.PrintLabels
{
    public partial class FrmMultiAddress : DevExpress.XtraEditors.XtraForm
    {
        public int IdProduct { get; set; }
        public FrmMultiAddress(int idProduct)
        {
            InitializeComponent();
            multiAddressTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            IdProduct = idProduct;
        }

        private void FrmMultiAddressLoad(object sender, EventArgs e)
        {
            multiAddressTableAdapter.Fill(wMSDataSet.MultiAddress, IdProduct);
            gridView1.BestFitColumns();
        }

        private void GridView1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    FrmPrintLabels.AddressFromMultiFrm = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colADDRESS).ToString();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}