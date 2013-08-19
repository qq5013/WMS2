using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.ReferenceAddressWithCells
{
    public partial class FrmListAddresses : XtraForm
    {
        public int IdProdcut { get; set; }
        public string SelectedAddress { get; set; }
        public FrmListAddresses(int idProdcut)
        {
            InitializeComponent();
            IdProdcut = idProdcut;
            listAddressForProductTableAdapter.Connection = Globals.GlobalParameters.WmsGlobalSqlConnection;
        }

        private void FrmListAddressesLoad(object sender, EventArgs e)
        {
            listAddressForProductTableAdapter.Fill(wMSDataSet.ListAddressForProduct, IdProdcut);
        }

        private void ListAddressGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (listAddressGridView.FocusedRowHandle >= 0)
                {
                    SelectedAddress =
                        listAddressGridView.GetRowCellValue(listAddressGridView.FocusedRowHandle, colADDRESS).ToString();
                    Close();
                }
            }
        }

        private void FrmListAddressesFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedAddress))
            {
                DialogResult = DialogResult.OK;
                FrmReferenceAddressWithCells.FindedAddress = SelectedAddress;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void ListAddressGridViewDoubleClick(object sender, EventArgs e)
        {
            ListAddressGridViewKeyDown(null, new KeyEventArgs(Keys.Enter));
        }
    }
}