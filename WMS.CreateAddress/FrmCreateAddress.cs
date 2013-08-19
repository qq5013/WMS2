using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;


namespace WMS.CreateAddress
{
    public partial class FrmCreateAddress : XtraForm
    {
        public int IdWarehouse { get; set; }
        public int IdStreet { get; set; }
        public int IdRaft { get; set; }
        public int IdShelf { get; set; }
        public int IdShelfSpace { get; set; }
        public bool BusyAddres { get; set; }
        public bool ErrorAddress { get; set; }

        public FrmCreateAddress()
        {
            InitializeComponent();

            catalog_RaftTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_ShelfSpacesTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_ShelfsTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_StreetsTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_WarehousesTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            catalog_AddressTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;

            infoAddressLabelControl.Text = "";
            infoWarehouseLabelControl.Text = "";
            infoStreetLabelControl.Text = "";
            infoRaftLabelControl.Text = "";
            infoShelfLabelControl.Text = "";
            infoShelfSpaceLabelControl.Text = "";
            busyAddressLabelControl.Text = "";
        }

        private void FrmCreateAddressLoad(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'wMSDataSet.Catalog_Address' table. You can move, or remove it, as needed.
            catalog_AddressTableAdapter.Fill(wMSDataSet.Catalog_Address);
            catalog_ShelfSpacesTableAdapter.Fill(wMSDataSet.Catalog_ShelfSpaces);
            catalog_ShelfsTableAdapter.Fill(wMSDataSet.Catalog_Shelfs);
            catalog_RaftTableAdapter.Fill(wMSDataSet.Catalog_Raft);
            catalog_StreetsTableAdapter.Fill(wMSDataSet.Catalog_Streets);
            catalog_WarehousesTableAdapter.Fill(wMSDataSet.Catalog_Warehouses);
            ErrorAddress = false;
        }

        private bool CheckAddress()
        {
            var worker = new DbAddressAsignment();
            return worker.CheckAddress(IdWarehouse, IdStreet, IdRaft, IdShelf, IdShelfSpace);
        }

        private string SplitAddress()
        {
            return warehouseLookUpEdit.Text + ";" + streetLookUpEdit.Text + ";" + raftLookUpEdit.Text + ";" + shelfLookUpEdit.Text + ";" +
                   shelfSpaceLookUpEdit.Text;
        }

        private void UpdateInfoAddress()
        {
            saveResultLabel.Text = "";
            if (IdWarehouse > 0 && IdStreet > 0 && IdRaft > 0 && IdShelf > 0 && IdShelfSpace > 0)
            {
                if (!CheckAddress())
                {
                    infoAddressLabelControl.Text = SplitAddress();
                    infoAddressLabelControl.ForeColor = Color.Green;
                    busyAddressLabelControl.ForeColor = Color.Green;
                    busyAddressLabelControl.Text = "Адрес свободен";
                    saveButton.Enabled = true;
                    BusyAddres = false;
                }
                else
                {
                    infoAddressLabelControl.Text = SplitAddress();
                    infoAddressLabelControl.ForeColor = Color.Red;
                    busyAddressLabelControl.ForeColor = Color.Red;
                    busyAddressLabelControl.Text = "Адрес уже существует";
                    saveButton.Enabled = false;
                    BusyAddres = true;
                }
            }
            else
            {
                infoAddressLabelControl.Text = "";
                busyAddressLabelControl.ForeColor = Color.Red;
                busyAddressLabelControl.Text = "Неизвестный адрес!!!";
                saveButton.Enabled = false;
                BusyAddres = true;
            }
        }

        private void WarehouseLookUpEditEditValueChanged(object sender, System.EventArgs e)
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

        private void StreetLookUpEditEditValueChanged(object sender, System.EventArgs e)
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

        private void RaftLookUpEditEditValueChanged(object sender, System.EventArgs e)
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

        private void ShelfLookUpEditEditValueChanged(object sender, System.EventArgs e)
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

        private void ShelfSpaceLookUpEditEditValueChanged(object sender, System.EventArgs e)
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

        private void FindAddressTextEditKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                busyAddressLabelControl.Text = "";
                infoAddressLabelControl.Text = "";
                saveResultLabel.Text = "";
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
                        saveResultLabel.Text = "";
                        
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
                if (!ErrorAddress)
                {
                    if (!BusyAddres)
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
                }

            }
        }

        public void SaveAddressInCatalog(int idWarehouses,int idStreets,int idRafts,int idShelfs,int idShelfSpaces)
        {
            var worker = new DbAddressAsignment();
            worker.CreateNewAddressInCatalog(idWarehouses, idStreets, idRafts, idShelfs, idShelfSpaces);
        }

        private void AutoSaveCheckEditCheckedChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = autoSaveCheckEdit.CheckState != CheckState.Checked;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            UpdateInfoAddress();
            if (!BusyAddres)
            {
                SaveAddressInCatalog(
                            Convert.ToInt32(warehouseLookUpEdit.EditValue),
                            Convert.ToInt32(streetLookUpEdit.EditValue),
                            Convert.ToInt32(raftLookUpEdit.EditValue),
                            Convert.ToInt32(shelfLookUpEdit.EditValue),
                            Convert.ToInt32(shelfSpaceLookUpEdit.EditValue));
                saveResultLabel.Text = "Адрес успешно сохранён в БД";    
            }
            saveButton.Enabled = false;
            catalog_AddressTableAdapter.Fill(wMSDataSet.Catalog_Address);
        }
    }
}