using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using WMS.Globals;
using WMS.DataBaseLayers;
using WMS.GlobalsKeys;

namespace WMS.AddressAsignment
{
    public partial class FrmAddressAsignment : XtraForm
    {
        public bool Retur { get; set; }
        public static decimal QtyForAutoAssignment { get; set; }
        

        public FrmAddressAsignment(bool retur)
        {
            InitializeComponent();
            if (retur)
            {
                Text = "Паривязка партий товара к адресам (возвраты)";
                labelControl5.Visible = true;
            }
            Retur = retur;
            repositoryItemButtonEdit3.ButtonClick += RepositoryItemButtonEdit3ButtonClick;

            
        }


        void RepositoryItemButtonEdit3ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (addressAsignmentGridView.GetRowCellValue(
                                                              addressAsignmentGridView.FocusedRowHandle, coladdress).
                                                              ToString() != "")
            {
                if (addressAsignmentGridView.FocusedRowHandle >= 0)
                {
                    if (Convert.ToInt32(
                        addressAsignmentGridView.GetRowCellValue(
                            addressAsignmentGridView.FocusedRowHandle, colallowQty)) != 0)
                    {
                        var frm = new FrmEnterQtyForPartOnAddress(goodDescriptionTextEdit.Text,
                                                                  addressAsignmentGridView.GetRowCellValue(
                                                                      addressAsignmentGridView.FocusedRowHandle,
                                                                      colseria).
                                                                      ToString(),
                                                                  addressAsignmentGridView.GetRowCellValue(
                                                                      addressAsignmentGridView.FocusedRowHandle,
                                                                      colexpirationDate).ToString(),
                                                                  Convert.ToInt32(
                                                                      addressAsignmentGridView.GetRowCellValue(
                                                                          addressAsignmentGridView.FocusedRowHandle,
                                                                          colallowQty)) + Convert.ToInt32(
                                                                              addressAsignmentGridView.GetRowCellValue(
                                                                                  addressAsignmentGridView.
                                                                                      FocusedRowHandle,
                                                                                  colQtyOnAddress)),
                                                                  Convert.ToInt32(
                                                                      addressAsignmentGridView.GetRowCellValue(
                                                                          addressAsignmentGridView.FocusedRowHandle,
                                                                          colpartRowId)),
                                                                  addressAsignmentGridView.GetRowCellValue(
                                                                      addressAsignmentGridView.FocusedRowHandle,
                                                                      coladdress).
                                                                      ToString(), true,
                                                                  Convert.ToDecimal(
                                                                      addressAsignmentGridView.GetRowCellValue(
                                                                          addressAsignmentGridView.FocusedRowHandle,
                                                                          colqtyDepot)));
                        frm.ShowDialog();
                        findSkuButtonEdit.SendKey(new KeyEventArgs(Keys.Enter));


                    }
                    else
                    {
                        if (XtraMessageBox.Show(
                            "Для данной партии укзано всё возвможное количество на адресе(ах)\nВы всё равно желаете пересчитать количество?",
                            "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {



                            var frm = new FrmEnterQtyForPartOnAddress(goodDescriptionTextEdit.Text,
                                                                      addressAsignmentGridView.GetRowCellValue(
                                                                          addressAsignmentGridView.FocusedRowHandle,
                                                                          colseria).
                                                                          ToString(),
                                                                      addressAsignmentGridView.GetRowCellValue(
                                                                          addressAsignmentGridView.FocusedRowHandle,
                                                                          colexpirationDate).ToString(),
                                                                      Convert.ToInt32(
                                                                          addressAsignmentGridView.GetRowCellValue(
                                                                              addressAsignmentGridView.FocusedRowHandle,
                                                                              colallowQty)),
                                                                      Convert.ToInt32(
                                                                          addressAsignmentGridView.GetRowCellValue(
                                                                              addressAsignmentGridView.FocusedRowHandle,
                                                                              colpartRowId)),
                                                                      addressAsignmentGridView.GetRowCellValue(
                                                                          addressAsignmentGridView.FocusedRowHandle,
                                                                          coladdress).
                                                                          ToString(), false,
                                                                      Convert.ToDecimal(
                                                                          addressAsignmentGridView.GetRowCellValue(
                                                                              addressAsignmentGridView.FocusedRowHandle,
                                                                              colqtyDepot)));
                            frm.ShowDialog();
                            findSkuButtonEdit.SendKey(new KeyEventArgs(Keys.Enter));
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Для ввода количества необходмо сначала присвоить адрес!",
                                            "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void FrmAddressAsignmentLoad(object sender, System.EventArgs e)
        {
            //getPartsFromSystemTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            getPartsFromSystemTableAdapter1.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            DataRow[] typeOfRests = new DbAddressAsignment().GetTypesOfRests().Select();

            foreach (var row in typeOfRests)
            {
                //typeRestGoodsComboBoxEdit.Properties.Items.Add(row[1].ToString());
                typeOfRestsRadioGroup.Properties.Items.Add(new RadioGroupItem(null, row[1].ToString(), true));
                //typeRestGoodsComboBoxEdit.Properties.Items.Add(row[1]);
            }
            //typeRestGoodsComboBoxEdit.Properties.Items.Add("kuku1");
            //typeRestGoodsComboBoxEdit.Properties.Items.Add("kuku2");
            //typeRestGoodsComboBoxEdit.SelectedIndex = 0;
            typeOfRestsRadioGroup.SelectedIndex = 0;
            
        }

        private void FindSkuButtonEditButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (typeOfRestsRadioGroup.SelectedIndex >= 0)
            {
                switch (typeOfRestsRadioGroup.SelectedIndex)
                {
                    case 0:
                        var sellFrm = new FrmDirGoods(TypeOfGoods.SellGood) {Owner = this};
                        sellFrm.ShowDialog();
                        if (ObjectsForAddressAsignmets.SkuIdFromDirs > 0)
                        {
                            findSkuButtonEdit.Text =
                                ObjectsForAddressAsignmets.SkuIdFromDirs.ToString(CultureInfo.InvariantCulture);
                            goodDescriptionTextEdit.Text = ObjectsForAddressAsignmets.DescriptionGoodFromDirs;
                            GetPartForSellGood();
                            findSkuButtonEdit.Text = ObjectsForAddressAsignmets.SkuIdFromDirs.ToString();
                            findSkuButtonEdit.Focus();
                            findSkuButtonEdit.SelectAll();
                        }
                        break;
                    case 1:
                        var labFrm = new FrmDirGoods(TypeOfGoods.LabGood) {Owner = this};
                        labFrm.ShowDialog();
                        if (ObjectsForAddressAsignmets.SkuIdFromDirs > 0)
                        {
                            findSkuButtonEdit.Text =
                                ObjectsForAddressAsignmets.SkuIdFromDirs.ToString(CultureInfo.InvariantCulture);
                            goodDescriptionTextEdit.Text = ObjectsForAddressAsignmets.DescriptionGoodFromDirs;
                            GetPartForLabGood();
                            findSkuButtonEdit.Text = ObjectsForAddressAsignmets.SkuIdFromDirs.ToString();
                            findSkuButtonEdit.Focus();
                            findSkuButtonEdit.SelectAll();
                        }
                        break;
                }
                
                
            }
            else
            {
                XtraMessageBox.Show("Укажите тип остатков!", "Внимание !!!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void GetPartForSellGood()
        {
            if (!Retur)
            {
                getPartsFromSystemTableAdapter1.FillSell(partsFromSystemDataSet.GetPartsFromSystem, Convert.ToInt32(findSkuButtonEdit.Text), typeOfRestsRadioGroup.SelectedIndex);    
            }
            else
            {
                getPartsFromSystemTableAdapter1.FillSellRetur(partsFromSystemDataSet.GetPartsFromSystem, Convert.ToInt32(findSkuButtonEdit.Text), typeOfRestsRadioGroup.SelectedIndex);
            }
            addressAsignmentGridView.ExpandAllGroups();
            addressAsignmentGridView.BestFitColumns();
            DataRow[] resultExists = partsFromSystemDataSet.GetPartsFromSystem.Select("addAddress = 1");
            DataRow[] resultNotExists = partsFromSystemDataSet.GetPartsFromSystem.Select("addAddress = 0");
            foreach (var row in resultExists)
            {
                var i = row.Table.Rows.IndexOf(row);
                repositoryItemButtonEdit1.Buttons[0].Caption = "Изменить адрес";
            }
            foreach (var row in resultNotExists)
            {
                var i = row.Table.Rows.IndexOf(row);
                repositoryItemButtonEdit1.Buttons[0].Caption = "Добавить адрес";
            }
        }
        private void GetPartForLabGood()
        {
            getPartsFromSystemTableAdapter1.FillLab(partsFromSystemDataSet.GetPartsFromSystem, Convert.ToInt32(findSkuButtonEdit.Text), typeOfRestsRadioGroup.SelectedIndex);
            addressAsignmentGridView.ExpandAllGroups();
            addressAsignmentGridView.BestFitColumns();
        }

        private void FindSkuButtonEditKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left || e.KeyData == Keys.Right)
            {
                findSkuButtonEdit.Focus();
                findSkuButtonEdit.SelectAll();
            }
            if (e.KeyCode == Keys.Enter)
            {
                addressAsignmentGridView.ActiveFilterString = "";
                SearchGood();
            }
            if (e.KeyCode == Keys.Insert)
            {
                FindSkuButtonEditButtonClick(null, null);
            }
        }
        
        private void SearchGood()
        {
            if (typeOfRestsRadioGroup.SelectedIndex >= 0)
            {
                switch (typeOfRestsRadioGroup.SelectedIndex)
                {
                    case 0:

                        if (ObjectsForAddressAsignmets.DSsell == null)
                        {
                            var sellFrm = new FrmDirGoods(TypeOfGoods.SellGood) { Owner = this };
                        }

                        DataRow[] sellResult = new DataRow[1];
                        if (findSkuButtonEdit.Text.Length <= 5)
                        {
                            sellResult = ObjectsForAddressAsignmets.DSsell.Select("ID = " + findSkuButtonEdit.EditValue);    
                        }
                        else
                        {
                            sellResult = ObjectsForAddressAsignmets.DSsell.Select("BarCode = '" + findSkuButtonEdit.EditValue + "'");    
                        }


                        if (sellResult.Length != 0)
                        {
                            foreach (var row in sellResult)
                            {
                                ObjectsForAddressAsignmets.SkuIdFromDirs = Convert.ToInt32(row["ID"]);
                                ObjectsForAddressAsignmets.LastFocusedSkuId = ObjectsForAddressAsignmets.SkuIdFromDirs;
                                findSkuButtonEdit.Text = row["ID"].ToString();
                                goodDescriptionTextEdit.Text = row["Description"].ToString();
                            }
                            GetPartForSellGood();
                            findSkuButtonEdit.Focus();
                            findSkuButtonEdit.SelectAll();
                        }
                        else
                            XtraMessageBox.Show(" Товар не найден! ", " Внимание !", MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                        findSkuButtonEdit.Text = ObjectsForAddressAsignmets.LastFocusedSkuId.ToString();
                        findSkuButtonEdit.SelectAll();
                        break;
                    case 1:
                        if (ObjectsForAddressAsignmets.DSlab == null)
                        {
                            var labFrm = new FrmDirGoods(TypeOfGoods.LabGood) { Owner = this };
                        }

                        DataRow[] labresult = new DataRow[1];
                        if (findSkuButtonEdit.Text.Length <= 5)
                        {
                            labresult = ObjectsForAddressAsignmets.DSlab.Select("ID = " + findSkuButtonEdit.EditValue);    
                        }
                        else
                        {
                            labresult = ObjectsForAddressAsignmets.DSlab.Select("BarCode = '" + findSkuButtonEdit.EditValue + "'");    
                        }


                        if (labresult.Length != 0)
                        {
                            foreach (var row in labresult)
                            {
                                ObjectsForAddressAsignmets.SkuIdFromDirs = Convert.ToInt32(row["ID"]);
                                ObjectsForAddressAsignmets.LastFocusedSkuId = ObjectsForAddressAsignmets.SkuIdFromDirs;
                                findSkuButtonEdit.Text = row["ID"].ToString();
                                goodDescriptionTextEdit.Text = row["Description"].ToString();
                            }
                            GetPartForLabGood();
                            findSkuButtonEdit.Focus();
                            findSkuButtonEdit.SelectAll();
                        }
                        else
                            XtraMessageBox.Show(" Товар не найден! ", " Внимание !", MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                        findSkuButtonEdit.Text = ObjectsForAddressAsignmets.LastFocusedSkuId.ToString();
                        findSkuButtonEdit.SelectAll();
                        break;
                }


            }
            else
            {
                XtraMessageBox.Show("Укажите тип остатков!", "Внимание !!!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void SimpleButton1Click(object sender, EventArgs e)
        {
            if (addressAsignmentGridView.FocusedRowHandle >= 0)
            {
                var worker = new DbAddressAsignment();

                //if (worker.CheckMinMaxProduct(ObjectsForAddressAsignmets.SkuIdFromDirs) == 0)
                if (worker.CheckMinMaxProduct(Convert.ToInt32(findSkuButtonEdit.Text)) == 0)
                {
                    if (
                        XtraMessageBox.Show("Для данной партии не посчитана ротация \nЖелаете посчитать?", "Внимание.",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        worker.RecaclRotationForProduct(ObjectsForAddressAsignmets.SkuIdFromDirs);
                    }
                }
                decimal qtyRotation;
                string typeRotation;


                //var dt = worker.GetInfoRotation(ObjectsForAddressAsignmets.SkuIdFromDirs);
                var dt = worker.GetInfoRotation(Convert.ToInt32(findSkuButtonEdit.Text));
                
                if(dt.Rows.Count > 0)
                {
                    qtyRotation = Convert.ToDecimal(dt.Rows[0]["Qty"]);
                    typeRotation = dt.Rows[0]["Name"].ToString();
                }
                else
                {
                    qtyRotation = 0;
                    typeRotation = "---";
                }

                var handle = addressAsignmentGridView.FocusedRowHandle;
                if (Convert.ToDecimal(addressAsignmentGridView.GetRowCellValue(handle, colallowQty)) > 0)
                {
                    decimal allowSum = 0;
                    var allRowsForThisPart =
                        partsFromSystemDataSet.GetPartsFromSystem.Select(string.Format("partRowId = {0}",
                                                                                       addressAsignmentGridView.
                                                                                           GetRowCellValue(
                                                                                               addressAsignmentGridView.
                                                                                                   FocusedRowHandle,
                                                                                               colpartRowId)));
                    if (allowBigQtycheckEdit.CheckState == CheckState.Checked)
                    {
                        foreach (var row in allRowsForThisPart)
                        {
                            allowSum = allowSum + Convert.ToDecimal(row["allowQty"]);
                        }
                    }
                    else
                    {
                        allowSum =
                            Convert.ToDecimal(
                                addressAsignmentGridView.GetRowCellValue(addressAsignmentGridView.FocusedRowHandle,
                                                                         colallowQty));
                    }
                    
                    var frm = new FrmAddAddress(goodDescriptionTextEdit.Text,
                                                //ObjectsForAddressAsignmets.SkuIdFromDirs,
                                                Convert.ToInt32(findSkuButtonEdit.Text),
                                                Convert.ToInt32(addressAsignmentGridView.GetRowCellValue(handle,
                                                                                                         colpartRowId)),
                                                allowSum,
                                                addressAsignmentGridView.GetRowCellValue(handle, colseria).
                                                    ToString(),
                                                Convert.ToInt32(addressAsignmentGridView.GetRowCellValue(handle,
                                                                                                         colanalizNumber)),
                                                Convert.ToDateTime(addressAsignmentGridView.GetRowCellValue(
                                                    handle, colexpirationDate)), typeOfRestsRadioGroup.SelectedIndex, qtyRotation, typeRotation)
                                  {Owner = this};
                    frm.ShowDialog();
                    findSkuButtonEdit.Focus();
                    findSkuButtonEdit.SelectAll();
                    if (typeOfRestsRadioGroup.SelectedIndex >= 0)
                    {
                        switch (typeOfRestsRadioGroup.SelectedIndex)
                        {
                            case 0:
                                GetPartForSellGood();
                                break;
                            case 1:
                                GetPartForLabGood();
                                break;

                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Для данной партии нет достаточного количества для присвоения адреса !",
                                        "Внимание !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

                        
        }

        private void DeleteAddressButtonClick(object sender, EventArgs e)
        {
            if (addressAsignmentGridView.FocusedRowHandle >= 0)
            {
                if (XtraMessageBox.Show(string.Format("Вы действительно хотите удаить партию с адреса {0}", addressAsignmentGridView.GetRowCellValue(addressAsignmentGridView.FocusedRowHandle, coladdress)), "Внимание !", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {


                    var worker = new DbAddressAsignment();
                    worker.DeleteAddress(
                        Convert.ToInt32(
                            addressAsignmentGridView.GetRowCellValue(addressAsignmentGridView.FocusedRowHandle,
                                                                     colpartRowId)),
                        addressAsignmentGridView.GetRowCellValue(addressAsignmentGridView.FocusedRowHandle, coladdress).
                            ToString());
                }
                SearchGood();
            }


        }

        private void FindSkuButtonEditClick(object sender, EventArgs e)
        {
            findSkuButtonEdit.SelectAll();
            
        }

        private void CopyAddressToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (addressAsignmentGridView.FocusedRowHandle >= 0)
            {
                if (!string.IsNullOrEmpty(addressAsignmentGridView.GetRowCellValue(addressAsignmentGridView.FocusedRowHandle, coladdress).
                        ToString()))
                {
                    Clipboard.SetText(
                    addressAsignmentGridView.GetRowCellValue(addressAsignmentGridView.FocusedRowHandle, coladdress).
                        ToString());
                }
                
            }
            
        }

        private void FindSkuButtonEditPropertiesSpin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
            findSkuButtonEdit.Focus();
            findSkuButtonEdit.SelectAll();
        }

        private void AddressAsignmentGridViewCustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            
        }

        private void FindAddressTextEditKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                addressAsignmentGridView.ActiveFilterString = "";
                if (findAddressTextEdit.Text != "")
                {
                    var worker = new AddressMigration();
                    var result = worker.GetIdProductByAddress(findAddressTextEdit.Text);
                    if (result > 0)
                    {
                        findSkuButtonEdit.EditValue = result;
                        findSkuButtonEdit.SendKey(new KeyEventArgs(Keys.Enter));

                        var address = findAddressTextEdit.Text;

                        if (address.Substring(address.Length - 1,1) == ";")
                        {
                            address = address.Substring(0, address.Length - 1);
                        }

                        addressAsignmentGridView.ActiveFilterString = string.Format("[address] = '{0}'",
                                                                                    address);
                        findAddressTextEdit.Focus();
                        findAddressTextEdit.Text = "";
                    }
                    else
                    {
                        XtraMessageBox.Show("Введён не извесный адрес", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
                    }
                }
                else
                {
                    XtraMessageBox.Show("Необходимо ввести правильный адрес", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AddressAsignmentGridViewCustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
           
        }

        private void FindAddressButtonClick(object sender, EventArgs e)
        {
            if (addressAsignmentGridView.FocusedRowHandle < 0) return;
            
            if (Convert.ToDecimal(addressAsignmentGridView.GetRowCellValue(addressAsignmentGridView.FocusedRowHandle, colallowQty)) > 0)
            {
                if (!CheckAllParametersOfPRoductForAutoAssignmentAddress(Convert.ToInt32(findSkuButtonEdit.Text))) return;
                var frm = new FrmFindAndAutoAssignmentAddress(Convert.ToInt32(findSkuButtonEdit.Text),
                                                              Convert.ToInt32(
                                                                  addressAsignmentGridView.GetRowCellValue(
                                                                      addressAsignmentGridView.FocusedRowHandle,
                                                                      colallowQty)));
            
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                XtraMessageBox.Show("Для данной партии нет достаточного количества для присвоения адреса !",
                                    "Внимание !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckAllParametersOfPRoductForAutoAssignmentAddress(int idProduct)
        {
            var result = true;
            var worker = new AddressAssignmentAuto();

            if (!worker.CheckIfExistDemensionsProduct(idProduct))
            {
                XtraMessageBox.Show("Для данного товара не посчитаны размеры!\n" +
                                    "Необходимо измерить товар и внести изменения в справочник товаров!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }

            if (!worker.CheckIfExistRotationProduct(idProduct))
            {
                XtraMessageBox.Show("Для данного товара не посчитана ротация!\n" +
                                    "Необходимо посчитать ротацию в зависимости от требования хранения!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }

            if (!worker.CheckIfExistReferenceProductWithGroup(idProduct))
            {
                XtraMessageBox.Show("Для данного товара не оперделена зональная группа!\n" +
                                    "Необходимо привязать товар к одной из созданых групп!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }
    }
}