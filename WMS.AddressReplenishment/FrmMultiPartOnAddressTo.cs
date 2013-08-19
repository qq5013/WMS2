using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using WMS.Globals;


namespace WMS.AddressReplenishment
{
    public partial class FrmMultiPartOnAddressTo : XtraForm
    {
        public FrmMultiPartOnAddressTo(string addressStr, int idZone)
        {
            InitializeComponent();

            addressReplenishment_GetPartsFromAddressToTableAdapter.Connection =
                GlobalParameters.WmsGlobalSqlConnection;
            addressReplenishment_GetPartsFromAddressToTableAdapter.Fill(
                wMSDataSet.AddressReplenishment_GetPartsFromAddressTo, addressStr, idZone);
        }

        private void MultiPartOnAddressToGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;
            var view = sender as GridView;
            if (view == null || view.FocusedRowHandle < 0) return;
            FrmManualAddressReplenishment.IdPartRow = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, colID_PartRow));
            FrmManualAddressReplenishment.Description = view.GetRowCellValue(view.FocusedRowHandle, colDescription).ToString();
            FrmManualAddressReplenishment.Seria = view.GetRowCellValue(view.FocusedRowHandle, colSeries).ToString();
            FrmManualAddressReplenishment.ExpDate = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, colExpirationDate)).ToString("yyyy-MM-dd");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MultiPartOnAddressToGridViewDoubleClick(object sender, EventArgs e)
        {
            var view = sender as GridView;
            if (view == null || view.FocusedRowHandle < 0) return;
            FrmManualAddressReplenishment.IdPartRow = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, colID_PartRow));
            FrmManualAddressReplenishment.Description = view.GetRowCellValue(view.FocusedRowHandle, colDescription).ToString();
            FrmManualAddressReplenishment.Seria = view.GetRowCellValue(view.FocusedRowHandle, colSeries).ToString();
            FrmManualAddressReplenishment.ExpDate = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, colExpirationDate)).ToString("yyyy-MM-dd");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}