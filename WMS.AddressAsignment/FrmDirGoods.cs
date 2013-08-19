using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using WMS.Globals;

namespace WMS.AddressAsignment
{
    public partial class FrmDirGoods : XtraForm
    {
        public FrmDirGoods(TypeOfGoods goods)
        {
            InitializeComponent();

            getDirSellGoodsTableAdapter.Connection.ConnectionString = Globals.GlobalParameters.WmsConnectionString;
            
            switch (goods)
            {
                case TypeOfGoods.SellGood:
                    LoadSellGoods();
                    break;
                case TypeOfGoods.LabGood:
                    LoadLabGoods();
                    break;
            }
        }

        private void FrmDirGoods_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadSellGoods()
        {
            if (ObjectsForAddressAsignmets.MSellBindingSource.DataSource == null)
            {
                
                getDirSellGoodsTableAdapter.FillSell(partsFromSystemDataSet.GetDirSellGoods);
                ObjectsForAddressAsignmets.MSellBindingSource.DataSource = partsFromSystemDataSet;
                ObjectsForAddressAsignmets.DSsell = partsFromSystemDataSet.GetDirSellGoods;
                ObjectsForAddressAsignmets.MSellBindingSource.DataMember = "GetDirSellGoods";
            }
            gridControl1.DataSource = ObjectsForAddressAsignmets.MSellBindingSource;
            goodsGridView.FocusedRowHandle = ObjectsForAddressAsignmets.LastFocusedRowHandleId;
            goodsGridView.TopRowIndex = goodsGridView.FocusedRowHandle;//goodsGridView.MoveBy(1);
        }

        private void LoadLabGoods()
        {
            if (ObjectsForAddressAsignmets.MLabBindingSource.DataSource == null)
            {
                getDirSellGoodsTableAdapter.FillLab(partsFromSystemDataSet.GetDirSellGoods);
                ObjectsForAddressAsignmets.MLabBindingSource.DataSource = partsFromSystemDataSet;
                ObjectsForAddressAsignmets.DSlab = partsFromSystemDataSet.GetDirSellGoods;
                ObjectsForAddressAsignmets.MLabBindingSource.DataMember = "GetDirSellGoods";
            }
            gridControl1.DataSource = ObjectsForAddressAsignmets.MLabBindingSource;
            goodsGridView.FocusedRowHandle = ObjectsForAddressAsignmets.LastFocusedRowHandleId;
            goodsGridView.TopRowIndex = goodsGridView.FocusedRowHandle;//goodsGridView.MoveBy(1);

            
            
        }

        private void goodsGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendDataForSelectedRow();
            }
        }

        private void goodsGridView_DoubleClick(object sender, EventArgs e)
        {
            SendDataForSelectedRow();
        }

        private void SendDataForSelectedRow()
        {
            if (goodsGridView.FocusedRowHandle >= 0)
            {
                ObjectsForAddressAsignmets.SkuIdFromDirs = Convert.ToInt32(goodsGridView.GetRowCellValue(goodsGridView.FocusedRowHandle, colID));
                ObjectsForAddressAsignmets.DescriptionGoodFromDirs =
                    goodsGridView.GetRowCellValue(goodsGridView.FocusedRowHandle, colDescription).ToString();
                ObjectsForAddressAsignmets.LastFocusedRowHandleId = goodsGridView.FocusedRowHandle;
                Close();    
            }
            
        }
    }
}