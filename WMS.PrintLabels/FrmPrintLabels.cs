using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;
using WMS.DataBaseLayers;

namespace WMS.PrintLabels
{
 
    public partial class FrmPrintLabels : XtraForm
    {
        public static string AddressFromMultiFrm { get; set; }
        public FrmPrintLabels()
        {
            InitializeComponent();

            catalog_WarehousesTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            catalog_StreetsTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            catalog_RaftTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            catalog_ShelfsTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            catalog_ShelfSpacesTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            addressesForPrintLabelsTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
        }

        private void FrmPrintLabelsLoad(object sender, System.EventArgs e)
        {
            addressesForPrintLabelsTableAdapter.Fill(wMSDataSet.AddressesForPrintLabels);
            catalog_ShelfSpacesTableAdapter.Fill(wMSDataSet.Catalog_ShelfSpaces);
            catalog_ShelfsTableAdapter.Fill(wMSDataSet.Catalog_Shelfs);
            catalog_RaftTableAdapter.Fill(wMSDataSet.Catalog_Raft);
            catalog_StreetsTableAdapter.Fill(wMSDataSet.Catalog_Streets);
            catalog_WarehousesTableAdapter.Fill(wMSDataSet.Catalog_Warehouses);
            addressForPrintGridView.BestFitColumns();

        }

        private void SimpleButton1Click(object sender, System.EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable("Labels");
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Address", typeof(string));
                if (addressForPrintGridView.GroupedColumns.Count == 0)

                    for (int i = 0; i < addressForPrintGridView.DataRowCount; i++)

                        dt.Rows.Add(
                            Convert.ToInt32(addressForPrintGridView.GetRowCellDisplayText(i, colAddressId)),
                            addressForPrintGridView.GetRowCellDisplayText(i, colADDRESS));

                var report = new LabelsForm();
                report.LoadLayout(GlobalParameters.PathForPrintForms + "\\PrintLabelsForm.repx");
                report.FillDataTable(dt);
                report.ShowPreviewDialog();


                if (ObjectsForPrintAddressLabels.Printed)
                {
                    var worker = new PrintAddressLabels();

                    foreach (DataRow row in dt.Rows)
                    {
                        worker.UpdateDataForPrintedAddressess(Convert.ToInt32(row[0]));
                    }
                }

                ObjectsForPrintAddressLabels.Printed = false;
                addressesForPrintLabelsTableAdapter.Fill(wMSDataSet.AddressesForPrintLabels);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
                throw;
            }
            
        }

        private void SimpleButton2Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Labels");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Address", typeof(string));
            if (addressForPrintGridView.GroupedColumns.Count == 0)

                for (int i = 0; i < addressForPrintGridView.DataRowCount; i++)

                    dt.Rows.Add(
                        Convert.ToInt32(addressForPrintGridView.GetRowCellDisplayText(i, colAddressId)),
                        addressForPrintGridView.GetRowCellDisplayText(i, colADDRESS));

            var report = new LabelsForm();
            report.ShowDesigner();
        }

        private void FindSkuWithAddressTextEditKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                

                var worker = new AddressMigration();
                var result = worker.FindSku(findSkuWithAddressTextEdit.Text);
                descriptionSkuLabelControl.Text = worker.GetDescriptionForSku(result.IdSku);

                var worker2 = new PrintAddressLabels();
                string findAddress = worker2.GetAddresForProduct(result.IdSku);
                if (findAddress.Length > 5)
                {
                    if (addressForPrintGridView.ActiveFilterString.Length > 5)
                    {
                        addressForPrintGridView.ActiveFilterString = addressForPrintGridView.ActiveFilterString +
                                                                     string.Format(@"Or  [ADDRESS] = '{0}'", findAddress);
                    }
                    else
                        addressForPrintGridView.ActiveFilterString = addressForPrintGridView.ActiveFilterString +
                                                                     string.Format(@"[ADDRESS] = '{0}'", findAddress);
                }
                else
                {
                    if (findAddress == "null")
                    {
                        var frm = new FrmMultiAddress(result.IdSku);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            if (addressForPrintGridView.ActiveFilterString.Length > 5)
                            {
                                addressForPrintGridView.ActiveFilterString =
                                    addressForPrintGridView.ActiveFilterString +
                                    string.Format(@"Or  [ADDRESS] = '{0}'", AddressFromMultiFrm);
                            }
                            else
                                addressForPrintGridView.ActiveFilterString =
                                    addressForPrintGridView.ActiveFilterString +
                                    string.Format(@"[ADDRESS] = '{0}'", AddressFromMultiFrm);
                        }
                    }
                    else
                    {
                        if (findAddress == "no")
                            XtraMessageBox.Show("Не найден адрес для данного товара", "Внимание!", MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                    }


                }
                findSkuWithAddressTextEdit.Focus();
                findSkuWithAddressTextEdit.Text = "";
                   
            }
        }

        private void CheckEdit1CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.CheckState == CheckState.Checked)
            {
                labelControl1.Visible = true;
                findSkuWithAddressTextEdit.Visible = true;
                descriptionSkuLabelControl.Visible = true;
                addressForPrintGridView.ClearColumnsFilter();
            }
            else
            {
                labelControl1.Visible = false;
                findSkuWithAddressTextEdit.Visible = false;
                descriptionSkuLabelControl.Visible = false;
                addressForPrintGridView.ClearColumnsFilter();
            }
        }
    }
}