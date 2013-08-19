using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;

namespace WMS.AddressAsignment
{
    public partial class FrmListProductsOnAddresses : XtraForm
    {
        public FrmListProductsOnAddresses()
        {
            InitializeComponent();selectAddressesOfProductTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            selectAllProductsOnAddressesTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
        }

        private void FrmListProductsOnAddressesLoad(object sender, EventArgs e)
        {
            selectAllProductsOnAddressesTableAdapter.Fill(wMSDataSet.SelectAllProductsOnAddresses);
            productsGridView.BestFitColumns();

        }

        private void ProductsGridViewFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (productsGridView.FocusedRowHandle >= 0)
            {
                selectAddressesOfProductTableAdapter.Fill(wMSDataSet.SelectAddressesOfProduct,
                                                          Convert.ToInt32(
                                                              productsGridView.GetRowCellValue(
                                                                  productsGridView.FocusedRowHandle, colIdProduct)));
                addressesGridView.BestFitColumns();
            }
        }
    }
}