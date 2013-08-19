using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;

namespace WMS.AddressAsignment
{
    public partial class FrmAddAddress : XtraForm
    {
        public int IdWarehouse { get; set ; } 
        public int IdStreet { get; set; }
        public int IdRaft { get; set; }
        public int IdShelf { get; set; }
        public int IdShelfSpace { get; set; }

        public string NameProduct { get; set; }
        public int IdProduct { get; set; }
        public int IdPartRow { get; set; }
        public decimal Quantity { get; set; }
        public string Series { get; set; }
        public int Analysis { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int IdTypeOfRests { get; set; }

        public decimal QuantityRotation { get; set; }
        public string TypeRotation { get; set; }
        

        public bool ErrorAddress { get; set; }
        public bool BusyAddress { get; set; }

        public FrmAddAddress(string nameProduct, int idProduct, int idPartRow, decimal quantity, string series, int analysis, DateTime expirationDate, int idTypeOfRests, decimal qtyRotation, string typeRotation)
        {
            InitializeComponent();

            catalog_RaftTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_ShelfSpacesTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_ShelfsTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_StreetsTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_WarehousesTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            emptyAddressesTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;

            infoAddressLabelControl.Text = "";
            infoWarehouseLabelControl.Text = "";
            infoStreetLabelControl.Text = "";
            infoRaftLabelControl.Text = "";
            infoShelfLabelControl.Text = "";
            infoShelfSpaceLabelControl.Text = "";
            busyAddressLabelControl.Text = "";

            NameProduct = nameProduct;
            IdProduct = idProduct;
            IdPartRow = idPartRow;
            Quantity = Math.Round(quantity,2);
            Series = series;
            Analysis = analysis;
            ExpirationDate = expirationDate;
            IdTypeOfRests = idTypeOfRests;
            QuantityRotation = qtyRotation;
            TypeRotation = typeRotation;
            Text = string.Format("Добвление адреса для товара: [{0}]", NameProduct);

            quantiySpinEdit.Properties.MaxValue = Quantity;

            FillTextEdit();

        }

        private void FillTextEdit()
        {
            productTextEdit.Text = NameProduct;
            partRowTextEdit.Text = IdPartRow.ToString();
            quantityAlowTextEdit.Text = Quantity.ToString();
            seriesTextEdit.Text = Series;
            analysisTextEdit.Text = Analysis.ToString();
            expirationDateTextEdit.Text = ExpirationDate.Date.ToShortDateString();
        }

        private void FrmAddAddressLoad(object sender, EventArgs e)
        {
            
            catalog_ShelfSpacesTableAdapter.Fill(wMSDataSet.Catalog_ShelfSpaces);
            catalog_ShelfsTableAdapter.Fill(wMSDataSet.Catalog_Shelfs);
            catalog_RaftTableAdapter.Fill(wMSDataSet.Catalog_Raft);
            catalog_StreetsTableAdapter.Fill(wMSDataSet.Catalog_Streets);
            catalog_WarehousesTableAdapter.Fill(wMSDataSet.Catalog_Warehouses);
            emptyAddressesTableAdapter.Fill(wMSDataSet.EmptyAddresses, IdProduct, Series, ExpirationDate);
            ErrorAddress = false;

            


            qtyRotLabelControl.Text = Math.Round(QuantityRotation, 2).ToString();
            typeRotLabelControl.Text = TypeRotation;
        }

        private void WarehouseLookUpEditEditValueChanged(object sender, EventArgs e)
        {
            if (warehouseLookUpEdit.EditValue != null)
            {
                IdWarehouse = Convert.ToInt32(warehouseLookUpEdit.EditValue);
                infoWarehouseLabelControl.Text = warehouseLookUpEdit.GetColumnValue("Description").ToString();
                infoWarehouseLabelControl.ForeColor = Color.Black;
                UpdateInfoAddress();
            }
            else
            {
                IdWarehouse = -1;
                infoWarehouseLabelControl.Text = null;
            }
        }

        private void StreetLookUpEditEditValueChanged(object sender, EventArgs e)
        {
            if (streetLookUpEdit.EditValue != null)
            {
                IdStreet = Convert.ToInt32(streetLookUpEdit.EditValue);
                infoStreetLabelControl.Text = streetLookUpEdit.GetColumnValue("Description").ToString();
                infoStreetLabelControl.ForeColor = Color.Black;
                UpdateInfoAddress();
            }
            else
            {
                IdStreet = -1;
                infoStreetLabelControl.Text = null;
            }
        }

        private void RaftLookUpEditEditValueChanged(object sender, EventArgs e)
        {
            if (raftLookUpEdit.EditValue != null)
            {
                IdRaft = Convert.ToInt32(raftLookUpEdit.EditValue);
                infoRaftLabelControl.Text = raftLookUpEdit.GetColumnValue("Description").ToString();
                infoRaftLabelControl.ForeColor = Color.Black;
                UpdateInfoAddress();
            }
            else
            {
                IdRaft = -1;
                infoRaftLabelControl.Text = null;
            }
            
        }

        private void ShelfLookUpEditEditValueChanged(object sender, EventArgs e)
        {
            if (shelfLookUpEdit.EditValue != null)
            {
                IdShelf = Convert.ToInt32(shelfLookUpEdit.EditValue);
                infoShelfLabelControl.Text = shelfLookUpEdit.GetColumnValue("Description").ToString();
                infoShelfLabelControl.ForeColor = Color.Black;
                UpdateInfoAddress();
            }
            else
            {
                IdShelf = -1;
                infoShelfLabelControl.Text = null;
            }
        }

        private void ShelfSpaceLookUpEditEditValueChanged(object sender, EventArgs e)
        {
            if (shelfSpaceLookUpEdit.EditValue != null)
            {
                IdShelfSpace = Convert.ToInt32(shelfSpaceLookUpEdit.EditValue);
                infoShelfSpaceLabelControl.Text = shelfSpaceLookUpEdit.GetColumnValue("Description").ToString();
                infoShelfSpaceLabelControl.ForeColor = Color.Black;
                UpdateInfoAddress();
            }
            else
            {
                IdShelfSpace = -1;
                infoShelfSpaceLabelControl.Text = null;
            }
        }

        private bool CheckAddress()
        {
            var worker = new DbAddressAsignment();
            return worker.CheckAddress(IdWarehouse, IdStreet, IdRaft, IdShelf, IdShelfSpace);
        }

        private void UpdateInfoAddress()
        {
            if (IdWarehouse > 0 && IdStreet > 0 && IdRaft > 0 && IdShelf > 0 && IdShelfSpace > 0)
            {
                if (!CheckAddress())
                {
                    infoAddressLabelControl.Text = SplitAddress();
                    infoAddressLabelControl.ForeColor = Color.Green;
                    busyAddressLabelControl.ForeColor = Color.Green;
                    busyAddressLabelControl.Text = "Адрес свободен";
                    saveAddressButton.Enabled = true;
                    BusyAddress = false;
                }
                else
                {
                    infoAddressLabelControl.Text = SplitAddress();
                    infoAddressLabelControl.ForeColor = Color.Red;
                    busyAddressLabelControl.ForeColor = Color.Red;
                    busyAddressLabelControl.Text = "Адрес уже существует";
                    saveAddressButton.Enabled = false;
                    BusyAddress = true;
                }
            }
            else
            {
                infoAddressLabelControl.Text = "";
                busyAddressLabelControl.ForeColor = Color.Red;
                busyAddressLabelControl.Text = "Неизвестный адрес!!!";
                saveAddressButton.Enabled = false;
                BusyAddress = true;
            }
        }

        private string SplitAddress()
        {
            return warehouseLookUpEdit.Text + ";" + streetLookUpEdit.Text + ";" + raftLookUpEdit.Text + ";" + shelfLookUpEdit.Text + ";" +
                   shelfSpaceLookUpEdit.Text;
        }

        private void GiveAllQuantityButtonClick(object sender, EventArgs e)
        {
            quantiySpinEdit.Text = quantityAlowTextEdit.Text;
        }

        private void TabControlSelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (TabControl.SelectedTabPageIndex == 0)
                saveAddressButton.Text = "Назначить этот адрес";
            if (TabControl.SelectedTabPageIndex == 1)
                saveAddressButton.Text = "Создать и назначить этот адрес";

        }

        private void SaveAddressButtonClick(object sender, EventArgs e)
        {
            if (quantiySpinEdit.Value == 0)
            {
                XtraMessageBox.Show("Нельзя поместить на адрес нулевое количество!!!", "Внимание!!!", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (TabControl.SelectedTabPage == existsAddressesTabPage)
            {
                if (existsAddressesGridView.FocusedRowHandle >= 0)
                    SaveWithExistAddress();
            }
            else
            {
                if (TabControl.SelectedTabPage == createNewAddressTabPage)
                    SaveWithNewAddress();
            }
            
            /*
            var worker = new DbAddressAsignment();

            if (worker.CheckMinMaxProduct(IdProduct) == 0)
            {
                if (
                    XtraMessageBox.Show("Для данной партии не посчитана ротация \nЖелаете посчитать?", "Внимание.",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    worker.RecaclRotationForProduct(IdProduct);
                }
            }
              */

        }

        private void SaveWithExistAddress()
        {
            int handle = existsAddressesGridView.FocusedRowHandle;
            var worker = new DbAddressAsignment();
            var idNewPartOfProduct = worker.ImportPartFromSystem(IdPartRow, IdProduct, Quantity, Series,
                                                                 Analysis,
                                                                 ExpirationDate, IdTypeOfRests);
            var idAddressInCatalog = Convert.ToInt32(existsAddressesGridView.GetRowCellValue(handle, colID));
            worker.CreateNewAddress(idAddressInCatalog,
                                    idNewPartOfProduct,
                                    Math.Round(Convert.ToDecimal(quantiySpinEdit.Text), 2));
            var checkAddress = new DataBaseLayers.CheckAddress();
            checkAddress.CheckQtyAddress(existsAddressesGridView.GetRowCellValue(handle, colstringAddress).ToString(), IdPartRow);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SaveWithNewAddress()
        {
            if (infoAddressLabelControl.Text == "")
            {
                XtraMessageBox.Show("Необходимо указать адрес", "Внимание!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }

            if (infoAddressLabelControl.Text != "" && infoAddressLabelControl.ForeColor == Color.Red)
            {
                XtraMessageBox.Show("Нельзя использовать данный адрес", "Внимание!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }
            var worker = new DbAddressAsignment();
            var idNewAddressInCatalog =
                worker.CreateNewAddressInCatalog(Convert.ToInt32(warehouseLookUpEdit.EditValue),
                                                 Convert.ToInt32(streetLookUpEdit.EditValue),
                                                 Convert.ToInt32(raftLookUpEdit.EditValue),
                                                 Convert.ToInt32(shelfLookUpEdit.EditValue),
                                                 Convert.ToInt32(shelfSpaceLookUpEdit.EditValue));
            var idNewPartOfProduct = worker.ImportPartFromSystem(IdPartRow, IdProduct, Quantity, Series,
                                                                 Analysis,
                                                                 ExpirationDate, IdTypeOfRests);
            worker.CreateNewAddress(idNewAddressInCatalog, idNewPartOfProduct,
                                    Math.Round(Convert.ToDecimal(quantiySpinEdit.Text), 2));
            
            var checkAddress = new DataBaseLayers.CheckAddress();
            checkAddress.CheckQtyAddress(checkAddress.GetStrAddressByIdInCatalog(idNewAddressInCatalog), IdPartRow);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void QuantiySpinEditKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Control)
            {
                GiveAllQuantityButtonClick(null,null);
            }
        }

        private void findAddressTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                busyAddressLabelControl.Text = "";
                infoAddressLabelControl.Text = "";
                //saveResultLabel.Text = "";
                warehouseLookUpEdit.EditValue = null;
                streetLookUpEdit.EditValue = null;
                raftLookUpEdit.EditValue = null;
                shelfLookUpEdit.EditValue = null;
                shelfSpaceLookUpEdit.EditValue = null;
                ErrorAddress = false;
            }
            
            if (e.KeyData == Keys.Enter)
            {
                var worker = new DbAddressCreate();
                int idAddress = worker.GetIdByAddress(findAddressTextEdit.Text);

                if (idAddress > 0)
                {
                    var findedResult = worker.FindedResult(idAddress);
                    foreach (var findedIdOfCatalog in findedResult)
                    {
                        switch (findedIdOfCatalog.Catalog)
                        {
                            case TypeOfCatalog.Warehouse:
                                warehouseLookUpEdit.EditValue =
                                    warehouseLookUpEdit.Properties.GetDataSourceValue(
                                    warehouseLookUpEdit.Properties.Columns["ID"],
                                    warehouseLookUpEdit.Properties.GetDataSourceRowIndex("ID", findedIdOfCatalog.Id));
                                infoWarehouseLabelControl.ForeColor = Color.Black;
                                break;
                            case TypeOfCatalog.Street:
                                streetLookUpEdit.EditValue =
                                        streetLookUpEdit.Properties.GetDataSourceValue(
                                        streetLookUpEdit.Properties.Columns["ID"],
                                        streetLookUpEdit.Properties.GetDataSourceRowIndex("ID", findedIdOfCatalog.Id));
                                infoStreetLabelControl.ForeColor = Color.Black;
                                break;
                            case TypeOfCatalog.Raft:
                                raftLookUpEdit.EditValue =
                                        raftLookUpEdit.Properties.GetDataSourceValue(
                                        raftLookUpEdit.Properties.Columns["ID"],
                                        raftLookUpEdit.Properties.GetDataSourceRowIndex("ID", findedIdOfCatalog.Id));
                                infoRaftLabelControl.ForeColor = Color.Black;
                                break;
                            case TypeOfCatalog.Shelf:
                                shelfLookUpEdit.EditValue =
                                        shelfLookUpEdit.Properties.GetDataSourceValue(
                                        shelfLookUpEdit.Properties.Columns["ID"],
                                        shelfLookUpEdit.Properties.GetDataSourceRowIndex("ID", findedIdOfCatalog.Id));
                                infoShelfLabelControl.ForeColor = Color.Black;
                                break;
                            case TypeOfCatalog.ShelfSpace:
                                shelfSpaceLookUpEdit.EditValue =
                                        shelfSpaceLookUpEdit.Properties.GetDataSourceValue(
                                        shelfSpaceLookUpEdit.Properties.Columns["ID"],
                                        shelfSpaceLookUpEdit.Properties.GetDataSourceRowIndex("ID", findedIdOfCatalog.Id));
                                infoShelfSpaceLabelControl.ForeColor = Color.Black;
                                break;

                        }
                    }
                }
                else
                {
                    var dt = worker.GetUncreatedItemsOfAddress(findAddressTextEdit.Text);
                    var rowsExists = dt.Select("Type IS NOT NULL");
                    var rowsNotExists = dt.Select("Type IS NULL");

                    if (rowsNotExists.GetLength(0) == 0)
                    {
                        //var typeCatalog = new List<FindedIdOfCatalog>();
                        foreach (DataRow row in rowsExists)
                        {
                            switch (row["Type"].ToString())
                            {
                                case "Warehouse":
                                    warehouseLookUpEdit.EditValue =
                                    warehouseLookUpEdit.Properties.GetDataSourceValue(
                                    warehouseLookUpEdit.Properties.Columns["ID"],
                                    warehouseLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoWarehouseLabelControl.ForeColor = Color.Black;
                                    break;
                                case "Street":
                                    streetLookUpEdit.EditValue =
                                    streetLookUpEdit.Properties.GetDataSourceValue(
                                    streetLookUpEdit.Properties.Columns["ID"],
                                    streetLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoStreetLabelControl.ForeColor = Color.Black;
                                    break;
                                case "Raft":
                                    raftLookUpEdit.EditValue =
                                    raftLookUpEdit.Properties.GetDataSourceValue(
                                    raftLookUpEdit.Properties.Columns["ID"],
                                    raftLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoRaftLabelControl.ForeColor = Color.Black;
                                    break;
                                case "Shelf":
                                    shelfLookUpEdit.EditValue =
                                    shelfLookUpEdit.Properties.GetDataSourceValue(
                                    shelfLookUpEdit.Properties.Columns["ID"],
                                    shelfLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoShelfLabelControl.ForeColor = Color.Black;
                                    break;
                                case "ShelfSpace":
                                    shelfSpaceLookUpEdit.EditValue =
                                    shelfSpaceLookUpEdit.Properties.GetDataSourceValue(
                                    shelfSpaceLookUpEdit.Properties.Columns["ID"],
                                    shelfSpaceLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoShelfSpaceLabelControl.ForeColor = Color.Black;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        warehouseLookUpEdit.EditValue = null;
                        streetLookUpEdit.EditValue = null;
                        raftLookUpEdit.EditValue = null;
                        shelfLookUpEdit.EditValue = null;
                        shelfSpaceLookUpEdit.EditValue = null;
                        //saveResultLabel.Text = "";

                        foreach (DataRow row in rowsExists)
                        {
                            switch (row["Type"].ToString())
                            {
                                case "Warehouse":
                                    warehouseLookUpEdit.EditValue =
                                    warehouseLookUpEdit.Properties.GetDataSourceValue(
                                    warehouseLookUpEdit.Properties.Columns["ID"],
                                    warehouseLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoWarehouseLabelControl.ForeColor = Color.Black;
                                    break;
                                case "Street":
                                    streetLookUpEdit.EditValue =
                                    streetLookUpEdit.Properties.GetDataSourceValue(
                                    streetLookUpEdit.Properties.Columns["ID"],
                                    streetLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoStreetLabelControl.ForeColor = Color.Black;
                                    break;
                                case "Raft":
                                    raftLookUpEdit.EditValue =
                                    raftLookUpEdit.Properties.GetDataSourceValue(
                                    raftLookUpEdit.Properties.Columns["ID"],
                                    raftLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoRaftLabelControl.ForeColor = Color.Black;
                                    break;
                                case "Shelf":
                                    shelfLookUpEdit.EditValue =
                                    shelfLookUpEdit.Properties.GetDataSourceValue(
                                    shelfLookUpEdit.Properties.Columns["ID"],
                                    shelfLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoShelfLabelControl.ForeColor = Color.Black;
                                    break;
                                case "ShelfSpace":
                                    shelfSpaceLookUpEdit.EditValue =
                                    shelfSpaceLookUpEdit.Properties.GetDataSourceValue(
                                    shelfSpaceLookUpEdit.Properties.Columns["ID"],
                                    shelfSpaceLookUpEdit.Properties.GetDataSourceRowIndex("ID", Convert.ToInt32(row["id"])));
                                    infoShelfSpaceLabelControl.ForeColor = Color.Black;
                                    break;
                            }
                        }
                        if (warehouseLookUpEdit.EditValue == null)
                        {
                            infoWarehouseLabelControl.Text = "Не найден идентификатор!";
                            infoWarehouseLabelControl.ForeColor = Color.Red;
                            ErrorAddress = true;
                        }
                        if (streetLookUpEdit.EditValue == null)
                        {
                            infoStreetLabelControl.Text = "Не найден идентификатор!";
                            infoStreetLabelControl.ForeColor = Color.Red;
                            ErrorAddress = true;
                        }
                        if (raftLookUpEdit.EditValue == null)
                        {
                            infoRaftLabelControl.Text = "Не найден идентификатор!";
                            infoRaftLabelControl.ForeColor = Color.Red;
                            ErrorAddress = true;
                        }
                        if (shelfLookUpEdit.EditValue == null)
                        {
                            infoShelfLabelControl.Text = "Не найден идентификатор!";
                            infoShelfLabelControl.ForeColor = Color.Red;
                            ErrorAddress = true;
                        }
                        if (shelfSpaceLookUpEdit.EditValue == null)
                        {
                            infoShelfSpaceLabelControl.Text = "Не найден идентификатор!";
                            infoShelfSpaceLabelControl.ForeColor = Color.Red;
                            ErrorAddress = true;
                        }

                    }
                }
                //findAddressTextEdit.Text = "";
                findAddressTextEdit.ResetText();
                findAddressTextEdit.Focus();
                UpdateInfoAddress();
                /*
                if (!ErrorAddress)
                {
                    if (!BusyAddress)
                    {
                        if (autoSaveCheckEdit.CheckState == CheckState.Checked)
                            SaveButtonClick(null, null);
                        else
                        {
                            if (
                                XtraMessageBox.Show(
                                    string.Format("Желаете сохранить в базе адрес: \n{0}", infoAddressLabelControl.Text),
                                    "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                SaveButtonClick(null, null);
                        }
                    }
                }*/

            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }
    }
}