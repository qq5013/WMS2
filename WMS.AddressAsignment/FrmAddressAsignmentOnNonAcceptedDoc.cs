using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using WMS.Globals;

namespace WMS.AddressAsignment
{
    public partial class FrmAddressAsignmentOnNonAcceptedDoc : XtraForm
    {
        public enum TypeOfScan
        {
            ScanOne,
            ScanQty,
            ManualQty
        }
        public static int IdDoc { get; set; }
        public static TypeOfScan TypeOfWorkScan { get; set; }
        public static TypeOfScan LastTypeOfWorkScan { get; set; }
        public static XtraForm AddAddress = new XtraForm();
        public int IdPartRow { get; set; }

        
        public static void SetIdDoc(int idDoc)
        {
            IdDoc = idDoc;
        }
        public static void SetTypeOfScan(TypeOfScan typeOfScan)
        {
            TypeOfWorkScan = typeOfScan;
        }

        readonly BackgroundWorker _frmAddressAssignmentWorker = new BackgroundWorker();

        public FrmAddressAsignmentOnNonAcceptedDoc()
        {
            InitializeComponent();
            bodyDocTableAdapter.Connection = GlobalParameters.OnixGlobalSqlConnection;
            LastTypeOfWorkScan = TypeOfWorkScan = TypeOfScan.ScanOne;
            ChagetypeOfScan(TypeOfWorkScan);
            rowsDocGridView.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            repositoryItemButtonEdit1.ButtonClick += RepositoryItemButtonEdit1ButtonClick;
            _frmAddressAssignmentWorker.DoWork += FrmAddressAssignmentWorkerDoWork;
            _frmAddressAssignmentWorker.RunWorkerCompleted += FrmAddressAssignmentWorkerRunWorkerCompleted;
            wMSDataSet.BodyDoc.RowChanged += BodyDocRowChanged;
            wMSDataSet.BodyDoc.RowChanging += BodyDoc_RowChanging;
        }

        void BodyDoc_RowChanging(object sender, DataRowChangeEventArgs e)
        {
            
        }

        void BodyDocRowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Change)
            {
                if (TypeOfWorkScan == TypeOfScan.ManualQty)
                {
                    if (Convert.ToDecimal(e.Row["QtyFact"]) <= Convert.ToDecimal(e.Row["tpr1005"]))
                    {
                        //e.Row.AcceptChanges();
                        if (autoAddressAssignmentCheckEdit.CheckState == CheckState.Checked)
                        {
                            if (CompareQty(rowsDocGridView.FocusedRowHandle))
                            {
                                waitControl.Visible = true;
                                IdPartRow = Convert.ToInt32(e.Row["tpr2003"]);
                                _frmAddressAssignmentWorker.RunWorkerAsync(e.Row["tpr2003"]);
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Указано количество больше документального", "Внимание!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                        e.Row.RejectChanges();
                        
                    }
                }
            }
        }

        void FrmAddressAssignmentWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            waitControl.Visible = false;
            if (AddAddress != null)
                if (AddAddress.ShowDialog() == DialogResult.OK)
                {
                    wMSDataSet.BodyDoc.Select(string.Format("[tpr2003] = {0}", IdPartRow))[0]["AddressStr"] =
                        DataBaseLayers.AddressAssignment.ReturnAddressStrForNewPartNonAcceptedDoc(IdPartRow);
                    rowsDocGridView.BestFitColumns();
                }
            
        }
        void FrmAddressAssignmentWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            CreateFrmAddressAssignment(Convert.ToInt32(e.Argument));
        }

        private bool CompareQty(int rowHandle)
        {
            return Convert.ToDecimal(rowsDocGridView.GetRowCellValue(rowHandle, colQtyDoc))
                   == Convert.ToDecimal(rowsDocGridView.GetRowCellValue(rowHandle, colQtyFact));
        }

        void RepositoryItemButtonEdit1ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (rowsDocGridView.FocusedRowHandle < 0) return;
            if (CompareQty(rowsDocGridView.FocusedRowHandle))
            {
                waitControl.Visible = true;
                IdPartRow =
                    Convert.ToInt32(rowsDocGridView.GetRowCellValue(rowsDocGridView.FocusedRowHandle, colIdPartRow));
                _frmAddressAssignmentWorker.RunWorkerAsync(rowsDocGridView.GetRowCellValue(rowsDocGridView.FocusedRowHandle,colIdPartRow));
            }
        }


        private void DocNumberButtonEditButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frm = new FrmListNonAcceptedDocs();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (IdDoc != 0)
                {
                    bodyDocTableAdapter.Fill(wMSDataSet.BodyDoc, IdDoc);
                    rowsDocGridView.BestFitColumns();
                    barCodeTextEdit.Focus();
                    var worker = new DataBaseLayers.AddressAssignment();
                    var resTable = worker.GetInfoForNonAcceptedDoc(IdDoc);
                    var rows = resTable.Select();
                    if (rows.Length > 0)
                    {
                        docNumberButtonEdit.Text = rows[0]["PRI1003"].ToString();
                        dateDocTextEdit.Text = rows[0]["PRI1006"].ToString();
                        supplierTextEdit.Text = rows[0]["POS1002"].ToString();
                        warehouseTextEdit.Text = rows[0]["SKL1002"].ToString();

                        docNumberButtonEdit.Properties.ReadOnly = true;
                        dateDocTextEdit.Enabled = false;
                        supplierTextEdit.Enabled = false;
                        warehouseTextEdit.Enabled = false;
                    }
                }
            }
        }

        private void ChangeModeCheckButtonClick(object sender, EventArgs e)
        {
            var frm = new FrmChangeTypeEnterData();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (LastTypeOfWorkScan != TypeOfWorkScan)
                {
                    LastTypeOfWorkScan = TypeOfWorkScan;
                    ChagetypeOfScan(TypeOfWorkScan);
                }
            }
        }

        private void ChagetypeOfScan(TypeOfScan typeOfScan)
        {
            switch (typeOfScan)
            {
                case TypeOfScan.ScanOne:
                    Text = "Сканирование + 1";
                    colQtyFact.OptionsColumn.AllowEdit = false;
                    colQtyFact.OptionsColumn.ReadOnly = true;
                    colQtyFact.OptionsColumn.AllowFocus = false;
                    rowsDocGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
                    quantityTextEdit.Enabled = true;
                    quantityTextEdit.Text = "";
                    barCodeTextEdit.Enabled = true;
                    barCodeTextEdit.Focus();
                    barCodeTextEdit.Text = "";

                    break;
                case TypeOfScan.ScanQty:
                    Text = "Сканирование + количество";
                    colQtyFact.OptionsColumn.AllowEdit = false;
                    colQtyFact.OptionsColumn.ReadOnly = true;
                    colQtyFact.OptionsColumn.AllowFocus = false;
                    rowsDocGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
                    quantityTextEdit.Enabled = true;
                    quantityTextEdit.Text = "";
                    barCodeTextEdit.Enabled = true;
                    barCodeTextEdit.Focus();
                    barCodeTextEdit.Text = "";
                    break;
                case TypeOfScan.ManualQty:
                    Text = "Ручной ввод количества";
                    colQtyFact.OptionsColumn.AllowEdit = true;
                    colQtyFact.OptionsColumn.ReadOnly = false;
                    colQtyFact.OptionsColumn.AllowFocus = true;
                    rowsDocGridView.OptionsSelection.EnableAppearanceFocusedRow = true;
                    rowsDocGridView.Focus();
                    rowsDocGridView.SelectCell(rowsDocGridView.FocusedRowHandle, colQtyFact);
                    quantityTextEdit.Enabled = false;
                    barCodeTextEdit.Enabled = false;
                    break;
            }
        }


        private void FrmAddressAsignmentOnNonAcceptedDocFormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmAddressAsignmentOnNonAcceptedDocKeyDown(object sender, KeyEventArgs e)
        {
            CheckHotKeys(e);
        }

        private void MainGridControlKeyDown(object sender, KeyEventArgs e)
        {
            CheckHotKeys(e);
        }

        private void RowsDocGridViewKeyDown(object sender, KeyEventArgs e)
        {
            //CheckHotKeys(e);
        }

        private void QuantityTextEditKeyDown(object sender, KeyEventArgs e)
        {
            CheckHotKeys(e);
            if (e.KeyData == Keys.Enter)
            {
                if (quantityTextEdit.Text != "")
                {
                    switch (TypeOfWorkScan)
                    {
                        case TypeOfScan.ScanQty:
                            var rowsQty =
                                wMSDataSet.BodyDoc.Select(string.Format(@"ass3002 = '{0}'", barCodeTextEdit.Text));
                            foreach (DataRow row in rowsQty)
                                if (Convert.ToDecimal(row["QtyFact"]) +
                                                 Convert.ToDecimal(quantityTextEdit.Text) <= Convert.ToDecimal(row["tpr1005"]))
                                {
                                    row["QtyFact"] = Convert.ToDecimal(row["QtyFact"]) +
                                                 Convert.ToDecimal(quantityTextEdit.Text);
                                    if (autoAddressAssignmentCheckEdit.CheckState == CheckState.Checked)
                                    {
                                        if (CompareQty(GetHandleForRow()))
                                        {
                                            waitControl.Visible = true;
                                            IdPartRow = Convert.ToInt32(row["tpr2003"]);
                                            _frmAddressAssignmentWorker.RunWorkerAsync(row["tpr2003"]);
                                        }
                                    }
                                }
                                else
                                    XtraMessageBox.Show("Указано количество больше документального", "Внимание!",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                
                            break;
                    }
                    quantityTextEdit.Text = "";
                    barCodeTextEdit.Text = "";
                    barCodeTextEdit.Focus();
                }
            }
        }

        private int GetHandleForRow()
        {
            DataRow row = wMSDataSet.BodyDoc.Select(string.Format("[ass3002] = '{0}'", barCodeTextEdit.Text))[0];
            if (row != null)
                return rowsDocGridView.GetRowHandle(
                    wMSDataSet.BodyDoc.Rows.IndexOf(row));
            return -1;
        }

        private void BarCodeTextEditKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var existsBarCode = wMSDataSet.BodyDoc.Select(string.Format(@"ass3002 = '{0}'", barCodeTextEdit.Text));
                if (existsBarCode.Length != 0)
                {
                    rowsDocGridView.FocusedRowHandle = GetHandleForRow();
                    rowsDocGridView.OptionsSelection.EnableAppearanceFocusedRow = true;
                    rowsDocGridView.SelectRow(rowsDocGridView.FocusedRowHandle);
                    rowsDocGridView.OptionsSelection.EnableAppearanceHideSelection = false;
                    switch (TypeOfWorkScan)
                    {
                        case TypeOfScan.ScanOne:
                            var rowsOne =
                                wMSDataSet.BodyDoc.Select(string.Format(@"ass3002 = '{0}'", barCodeTextEdit.Text));
                            foreach (DataRow row in rowsOne)
                                if (Convert.ToDecimal(row["QtyFact"]) < Convert.ToDecimal(row["tpr1005"]))
                                {
                                    row["QtyFact"] = Convert.ToDecimal(row["QtyFact"]) + 1;
                                    if (autoAddressAssignmentCheckEdit.CheckState == CheckState.Checked)
                                    {
                                        if (CompareQty(GetHandleForRow()))
                                        {
                                            waitControl.Visible = true;
                                            IdPartRow = Convert.ToInt32(row["tpr2003"]);
                                            _frmAddressAssignmentWorker.RunWorkerAsync(row["tpr2003"]);
                                        }
                                    }
                                }
                                else
                                    XtraMessageBox.Show("Указано максимальное количество", "Внимание!",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            barCodeTextEdit.Text = "";
                            barCodeTextEdit.Focus();
                            break;
                        case TypeOfScan.ScanQty:
                            quantityTextEdit.Text = "1";
                            quantityTextEdit.Focus();
                            quantityTextEdit.SelectAll();
                            break;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Не верный бар код", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quantityTextEdit.Text = "";
                    barCodeTextEdit.Text = "";
                    barCodeTextEdit.Focus();
                }
            }
            else
            {
                CheckHotKeys(e);
            }

        }

        private void DocNumberButtonEditKeyDown(object sender, KeyEventArgs e)
        {
            CheckHotKeys(e);
        }

        private void CheckHotKeys(KeyEventArgs keys)
        {
            if (keys.KeyData == Keys.F7)
            {
                ChangeModeCheckButtonClick(null, null);
            }
            if (keys.KeyData == Keys.F5)
            {
                CollapseButtonClick(null, null);
            } 
            if (keys.KeyData == Keys.F6)
            {
                ExpandButtonClick(null, null);
            }
            if (keys.KeyData == Keys.F9)
            {
                NewCheckButtonClick(null,null);
            }
        }

        private void CollapseButtonClick(object sender, EventArgs e)
        {

            rowsDocGridView.ActiveFilterString = "[QtyFact] <> [tpr1005]";
        }

        private void ExpandButtonClick(object sender, EventArgs e)
        {
            rowsDocGridView.ActiveFilterString = "";
        }

        private void NewCheckButtonClick(object sender, EventArgs e)
        {
            docNumberButtonEdit.Text = "";
            dateDocTextEdit.Text = "";
            supplierTextEdit.Text = "";
            warehouseTextEdit.Text = "";
            barCodeTextEdit.Enabled = true;
            barCodeTextEdit.Text = "";
            quantityTextEdit.Enabled = true;
            quantityTextEdit.Text = "";
            wMSDataSet.BodyDoc.Clear();
        }

        private void CreateFrmAddressAssignment(int idPartRow)
        {
            var worker = new DbAddressAsignment();

            var idProduct =
                Convert.ToInt32(wMSDataSet.BodyDoc.Select(string.Format("[tpr2003] = {0}", idPartRow))[0]["tpr1004"]);

            if (worker.CheckMinMaxProduct(idProduct) == 0)
            {
                if (
                    XtraMessageBox.Show("Для данной партии не посчитана ротация \nЖелаете посчитать?", "Внимание.",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    worker.RecaclRotationForProduct(idProduct);
                }
            }
            decimal qtyRotation;
            string typeRotation;

            var dt = worker.GetInfoRotation(idProduct);

            if (dt.Rows.Count > 0)
            {
                qtyRotation = Convert.ToDecimal(dt.Rows[0]["Qty"]);
                typeRotation = dt.Rows[0]["Name"].ToString();
            }
            else
            {
                qtyRotation = 0;
                typeRotation = "---";
            }


            decimal allowSum;

            DataRow resRow = wMSDataSet.BodyDoc.Select(string.Format("[tpr2003] = {0}", idPartRow))[0];

            if (resRow == null) return;
            
            allowSum = Convert.ToDecimal(resRow["tpr1005"]);


            var frm = new FrmAddAddress(resRow["ass1003"].ToString(),
                                        idProduct,
                                        idPartRow,
                                        allowSum,
                                        resRow["tpr3002"].ToString(),
                                        Convert.ToInt32(resRow["tpr3003"]),
                                        Convert.ToDateTime(resRow["tpr1007"]), 0, qtyRotation, typeRotation);
                
            AddAddress = frm;
        }

        private void AutoAddressAssignmentCheckEditCheckStateChanged(object sender, EventArgs e)
        {
            
            //waitControl.Visible = autoAddressAssignmentCheckEdit.CheckState == CheckState.Checked;
        }
    }
}