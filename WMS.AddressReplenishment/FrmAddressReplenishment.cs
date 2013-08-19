using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using WMS.Globals;
using WMS.DataBaseLayers;

namespace WMS.AddressReplenishment
{
    public partial class FrmAddressReplenishment : XtraForm
    {
        public bool Executed { get; set; }
        
        public FrmAddressReplenishment()
        {
            InitializeComponent();

            docsOrderForReplenishmentTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            docsRowsOrderForReplenishmentTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
        }

        private void FrmAddressReplenishmentLoad(object sender, System.EventArgs e)
        {
            docsOrderForReplenishmentTableAdapter.Fill(wMSDataSet.DocsOrderForReplenishment);
            orderForReplenishmentGridView.BestFitColumns();

        }

        private void OrderForReplenishmentGridViewFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.PrevFocusedRowHandle >= 0)
            {
                if (orderForReplenishmentGridView.FocusedRowHandle >= 0)
                {
                    docsRowsOrderForReplenishmentTableAdapter.Fill(wMSDataSet.DocsRowsOrderForReplenishment,
                                                           Convert.ToInt64(
                                                               orderForReplenishmentGridView.GetRowCellValue(
                                                                   orderForReplenishmentGridView.
                                                                       FocusedRowHandle, colID)));
                    applyButton.Enabled = !Convert.ToBoolean(orderForReplenishmentGridView.GetRowCellValue(orderForReplenishmentGridView.FocusedRowHandle, colExecuted));
                    rowsOrderForReplenishmentGridView.ExpandAllGroups();
                    rowsOrderForReplenishmentGridView.BestFitColumns();
                }
            }
        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            var worker = new DataBaseLayers.AddressReplenishment();
            
            if (orderForReplenishmentGridView.FocusedRowHandle >= 0)
            {
                var report =
                    new ReplenishmentList(
                        Convert.ToInt32(
                            orderForReplenishmentGridView.GetRowCellValue(
                                orderForReplenishmentGridView.FocusedRowHandle, colID)));
                GlobalParameters.ReplenishmentListExecuted = false;
                report.ShowPreviewDialog();
                
                if (GlobalParameters.ReplenishmentListExecuted)
                {
                    worker.ExecuteReplenishmentList(
                        Convert.ToInt32(
                            orderForReplenishmentGridView.GetRowCellValue(
                                orderForReplenishmentGridView.FocusedRowHandle, colID)));
                    
                    worker.MoveReplenishmentDocInTranzit(
                        Convert.ToInt32(
                            orderForReplenishmentGridView.GetRowCellValue(
                                orderForReplenishmentGridView.FocusedRowHandle, colID)));
                    
                    docsOrderForReplenishmentTableAdapter.Fill(wMSDataSet.DocsOrderForReplenishment);
                    orderForReplenishmentGridView.BestFitColumns();
                }
            }
            
        }

        private void SimpleButton1Click(object sender, EventArgs e)
        {
            if (orderForReplenishmentGridView.FocusedRowHandle >= 0)
            {
                var report =
                    new ReplenishmentList(
                        Convert.ToInt32(
                            orderForReplenishmentGridView.GetRowCellValue(
                                orderForReplenishmentGridView.FocusedRowHandle, colID)));
                report.ShowDesigner();
            }
        }

        private void RunAnalyseButtonClick(object sender, EventArgs e)
        {
            var worker = new DataBaseLayers.AddressReplenishment();
            worker.AnalyseReplenishment();
            docsOrderForReplenishmentTableAdapter.Fill(wMSDataSet.DocsOrderForReplenishment);
            orderForReplenishmentGridView.BestFitColumns();
        }
    }
}