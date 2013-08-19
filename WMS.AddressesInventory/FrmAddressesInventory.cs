using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.Printing;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraPrinting.Native;
using System.Reflection;
using WMS.Globals;
using WMS.DataBaseLayers;
using System.Reflection;

namespace WMS.AddressesInventory
{
    
    public partial class FrmAddressesInventory : XtraForm
    {
        public DataBaseLayers.AddressesInventory Worker = new DataBaseLayers.AddressesInventory();
        public List<MyListCheckedItems> ZoneChechedItems = new List<MyListCheckedItems>();
        public bool ZonesCheckAllItems { get; set; }
        public bool ZonesUncheckAllItems { get; set; }
        public bool CheckManual { get; set; }
        public bool IsForeach = false;

        public FrmAddressesInventory()
        {
            InitializeComponent();
            catalog_WarehousesTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            catalog_ZonesTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            catalog_StreetsTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            catalog_RaftTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            catalog_ShelfsTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            CheckManual = true;

            

        }

        private void FrmAddressesInventoryLoad(object sender, System.EventArgs e)
        {
            catalog_WarehousesTableAdapter.Fill(wMSDataSet.Catalog_Warehouses);

            //catalog_ZonesTableAdapter.Fill(wMSDataSet.Catalog_Zones);
        }

        private int GetIndexFindedItem(CheckedListBoxControl listBox, object id)
        {
            return listBox.FindItem(0, true, delegate(ListBoxFindItemArgs ee)
                                          {
                                              ee.IsFound =
                                                  Equals(id,
                                                         ee.ItemValue);
                                          });
        }

        #region События отметок в листбоксах
        private void WarehouseCheckedListBoxControlItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.State == CheckState.Checked && CheckManual)
            {
                CheckManual = false;
                DataRow[] dr = wMSDataSet.Catalog_Warehouses.Select("[ID] <> 0");

                foreach (DataRow dataRow in dr)
                {
                    IsForeach = true;
                    var id = dataRow[0];
                    warehouseCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id),
                                                              true);
                }
                IsForeach = false;
            }
            else
            {

                if (e.Index == 0 && e.State == CheckState.Unchecked && CheckManual)
                {
                    CheckManual = false;
                    DataRow[] dr = wMSDataSet.Catalog_Warehouses.Select("[ID] <> 0");

                    foreach (DataRow dataRow in dr)
                    {
                        IsForeach = true;
                        var id = dataRow[0];
                        warehouseCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id), false);
                    }

                    IsForeach = false;
                    ZonesUncheckAllItems = true;
                    ZonesCheckAllItems = false;
                }
                else
                {
                    CheckManual = true;
                }
            }

            if (IsForeach) return;

            var checkedItems = (from object checkedItem in warehouseCheckedListBoxControl.CheckedIndices
                                         select Convert.ToInt32(warehouseCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();


            wMSDataSet.Catalog_Zones.Clear();

            if (checkedItems.Count == 1 && checkedItems[0] == 0)
            {
                wMSDataSet.Catalog_Zones.Clear();
                warehouseCheckedListBoxControl.UnCheckAll();
                return;
            }
            if (checkedItems.Count != 0)
            {
                FillZoneTable(checkedItems);
            }
        }
        
        private void ZonesCheckedListBoxControlItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {

            if (e.Index == 0 && e.State == CheckState.Checked && CheckManual)
            {
                CheckManual = false;
                DataRow[] dr = wMSDataSet.Catalog_Zones.Select("[ID] <> 0");

                foreach (DataRow dataRow in dr)
                {
                    IsForeach = true;
                    var id = dataRow[0];
                    zonesCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id),
                                                              true);
                }
                IsForeach = false;
            }
            else
            {

                if (e.Index == 0 && e.State == CheckState.Unchecked && CheckManual)
                {
                    CheckManual = false;
                    DataRow[] dr = wMSDataSet.Catalog_Zones.Select("[ID] <> 0");

                    foreach (DataRow dataRow in dr)
                    {
                        IsForeach = true;
                        var id = dataRow[0];
                        zonesCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id), false);
                    }

                    IsForeach = false;
                    ZonesUncheckAllItems = true;
                    ZonesCheckAllItems = false;
                }
                else
                {
                    CheckManual = true;
                }
            }

            if (IsForeach) return;

            var warehouseCheckedItems = (from object checkedItem in warehouseCheckedListBoxControl.CheckedIndices
                                     select Convert.ToInt32(warehouseCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();


            var zonesCheckedItems = (from object checkedItem in zonesCheckedListBoxControl.CheckedIndices
                                     select Convert.ToInt32(zonesCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            

            wMSDataSet.Catalog_Streets.Clear();

            if (zonesCheckedItems.Count == 1 && zonesCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Streets.Clear();
                zonesCheckedListBoxControl.UnCheckAll();
                return;
            }

            if (warehouseCheckedItems.Count == 1 && warehouseCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Zones.Clear();
                warehouseCheckedListBoxControl.UnCheckAll();
                return;
            }

            if (warehouseCheckedItems.Count != 0 && zonesCheckedItems.Count != 0)
            {
                FillStreetTable(warehouseCheckedItems, zonesCheckedItems);
            }
        }
        
        private void StreetsCheckedListBoxControlItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            
            if (e.Index == 0 && e.State == CheckState.Checked && CheckManual)
            {
                CheckManual = false;
                DataRow[] dr = wMSDataSet.Catalog_Streets.Select("[ID] <> 0");

                foreach (DataRow dataRow in dr)
                {
                    IsForeach = true;
                    var id = dataRow[0];
                    streetsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id),
                                                              true);
                }
                IsForeach = false;
            }
            else
            {

                if (e.Index == 0 && e.State == CheckState.Unchecked && CheckManual)
                {
                    CheckManual = false;
                    DataRow[] dr = wMSDataSet.Catalog_Streets.Select("[ID] <> 0");

                    foreach (DataRow dataRow in dr)
                    {
                        IsForeach = true;
                        var id = dataRow[0];
                        streetsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id), false);
                    }
                    IsForeach = false;
                    ZonesUncheckAllItems = true;
                    ZonesCheckAllItems = false;
                }
                else
                {
                    CheckManual = true;
                }
            }

            if (IsForeach) return;

            var warehouseCheckedItems = (from object checkedItem in warehouseCheckedListBoxControl.CheckedIndices
                                     select Convert.ToInt32(warehouseCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var zonesCheckedItems = (from object checkedItem in zonesCheckedListBoxControl.CheckedIndices
                                     select Convert.ToInt32(zonesCheckedListBoxControl.GetItemValue((int) checkedItem)))
                .ToList();

            var streetsCheckedItems = (from object checkedItem in streetsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(streetsCheckedListBoxControl.GetItemValue((int) checkedItem)))
                .ToList();

            wMSDataSet.Catalog_Raft.Clear();

            if (streetsCheckedItems.Count == 1 && streetsCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Raft.Clear();
                streetsCheckedListBoxControl.UnCheckAll();
                return;
            }

            if (zonesCheckedItems.Count == 1 && zonesCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Streets.Clear();
                zonesCheckedListBoxControl.UnCheckAll();
                return;
            }

            if (warehouseCheckedItems.Count == 1 && warehouseCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Zones.Clear();
                warehouseCheckedListBoxControl.UnCheckAll();
                return;
            }
            if (warehouseCheckedItems.Count != 0 && zonesCheckedItems.Count != 0 && streetsCheckedItems.Count != 0)
            {
                FillRaftTable(warehouseCheckedItems, zonesCheckedItems, streetsCheckedItems);
            }
        }
        
        private void RaftsCheckedListBoxControlItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.State == CheckState.Checked && CheckManual)
            {
                CheckManual = false;
                DataRow[] dr = wMSDataSet.Catalog_Raft.Select("[ID] <> 0");

                foreach (DataRow dataRow in dr)
                {
                    IsForeach = true;
                    var id = dataRow[0];
                    raftsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id),
                                                              true);
                }
                IsForeach = false;
            }
            else
            {

                if (e.Index == 0 && e.State == CheckState.Unchecked && CheckManual)
                {
                    CheckManual = false;
                    DataRow[] dr = wMSDataSet.Catalog_Raft.Select("[ID] <> 0");

                    foreach (DataRow dataRow in dr)
                    {
                        IsForeach = true;
                        var id = dataRow[0];
                        raftsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id), false);
                    }
                    IsForeach = false;
                    ZonesUncheckAllItems = true;
                    ZonesCheckAllItems = false;
                }
                else
                {
                    CheckManual = true;
                }
            }

            if (IsForeach) return;


            var warehouseCheckedItems = (from object checkedItem in warehouseCheckedListBoxControl.CheckedIndices
                                     select Convert.ToInt32(warehouseCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var zonesCheckedItems = (from object checkedItem in zonesCheckedListBoxControl.CheckedIndices
                                     select Convert.ToInt32(zonesCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var streetsCheckedItems = (from object checkedItem in streetsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(streetsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var raftsCheckedItems = (from object checkedItem in raftsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(raftsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            wMSDataSet.Catalog_Shelfs.Clear();

            if (raftsCheckedItems.Count == 1 && raftsCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Shelfs.Clear();
                raftsCheckedListBoxControl.UnCheckAll();
                return;
            }

            if (streetsCheckedItems.Count == 1 && streetsCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Raft.Clear();
                streetsCheckedListBoxControl.UnCheckAll();
                return;
            }

            if (zonesCheckedItems.Count == 1 && zonesCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Streets.Clear();
                zonesCheckedListBoxControl.UnCheckAll();
                return;
            }

            if (warehouseCheckedItems.Count == 1 && warehouseCheckedItems[0] == 0)
            {
                wMSDataSet.Catalog_Zones.Clear();
                warehouseCheckedListBoxControl.UnCheckAll();
                return;
            }

            if (warehouseCheckedItems.Count != 0 && zonesCheckedItems.Count != 0 && streetsCheckedItems.Count != 0 && raftsCheckedItems.Count != 0)
            {
                FillShelfTable(warehouseCheckedItems, zonesCheckedItems, streetsCheckedItems, raftsCheckedItems);
            }
        }

        private void ShelfsCheckedListBoxControlItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.State == CheckState.Checked && CheckManual)
            {
                CheckManual = false;
                DataRow[] dr = wMSDataSet.Catalog_Shelfs.Select("[ID] <> 0");

                foreach (DataRow dataRow in dr)
                {
                    IsForeach = true;
                    var id = dataRow[0];
                    shelfsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id),
                                                              true);
                }
                IsForeach = false;
            }
            else
            {

                if (e.Index == 0 && e.State == CheckState.Unchecked && CheckManual)
                {
                    CheckManual = false;
                    DataRow[] dr = wMSDataSet.Catalog_Shelfs.Select("[ID] <> 0");

                    foreach (DataRow dataRow in dr)
                    {
                        IsForeach = true;
                        var id = dataRow[0];
                        shelfsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id), false);
                    }
                    IsForeach = false;
                    ZonesUncheckAllItems = true;
                    ZonesCheckAllItems = false;
                }
                else
                {
                    CheckManual = true;
                }
            }

            if (IsForeach) return;

            var shelftsCheckedItems = (from object checkedItem in shelfsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(shelfsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            getListAddressesButton.Enabled = shelftsCheckedItems.Count > 0;
        }
        #endregion

        #region Методы заполнения листбоксов
        public void FillZoneTable(List<int> idsWarehouse)
        {
            
            if (idsWarehouse.Count == 0) return;
            

            var result = Worker.GetListZones(GlobalParameters.SplitListToString(idsWarehouse));

            if (result != null && result.Rows.Count > 0)
            {
                wMSDataSet.Catalog_Zones.Clear();

                wMSDataSet.Catalog_Zones.Merge(result);
            }
            else
            {
                wMSDataSet.Catalog_Zones.Clear(); ;
            }

        }

        public void FillStreetTable(List<int> idsWarehouse, List<int> idsZone)
        {
            string listIdWarehouses = "";
            string listIdZones = "";

            if (idsWarehouse.Count == 0 || idsZone.Count == 0) return;

            if (idsWarehouse.Count >= 1)
            {
                foreach (int i in idsWarehouse)
                {
                    listIdWarehouses = listIdWarehouses + i.ToString() + ",";
                }
                listIdWarehouses = listIdWarehouses.Substring(0, listIdWarehouses.Length - 1);
            }
            else
            {
                listIdWarehouses = idsWarehouse[0].ToString();
            }

            if (idsZone.Count >= 1)
            {
                foreach (int i in idsZone)
                {
                    listIdZones = listIdZones + i.ToString() + ",";
                }
                listIdZones = listIdZones.Substring(0, listIdZones.Length - 1);
            }
            else
            {
                listIdZones = idsZone[0].ToString();
            }
            

            var result = Worker.GetListStreets(listIdWarehouses, listIdZones);

            if (result != null && result.Rows.Count > 0)
            {
                wMSDataSet.Catalog_Streets.Clear();

                wMSDataSet.Catalog_Streets.Merge(result);
            }
            else
            {
                wMSDataSet.Catalog_Streets.Clear(); ;
            }
            
        }

        public void FillRaftTable(List<int> idsWarehouse, List<int> idsZone, List<int> idsStreet)
        {
            string listIdWarehouses = "";
            string listIdZones = "";
            string listIdStreets = "";

            if (idsWarehouse.Count == 0 || idsZone.Count == 0 || idsStreet.Count == 0) return;

            if (idsWarehouse.Count >= 1)
            {
                foreach (int i in idsWarehouse)
                {
                    listIdWarehouses = listIdWarehouses + i.ToString() + ",";
                }
                listIdWarehouses = listIdWarehouses.Substring(0, listIdWarehouses.Length - 1);
            }
            else
            {
                listIdWarehouses = idsWarehouse[0].ToString();
            }

            if (idsZone.Count >= 1)
            {
                foreach (int i in idsZone)
                {
                    listIdZones = listIdZones + i.ToString() + ",";
                }
                listIdZones = listIdZones.Substring(0, listIdZones.Length - 1);
            }
            else
            {
                listIdZones = idsZone[0].ToString();
            }

            if (idsStreet.Count >= 1)
            {
                foreach (int i in idsStreet)
                {
                    listIdStreets = listIdStreets + i.ToString() + ",";
                }
                listIdStreets = listIdStreets.Substring(0, listIdStreets.Length - 1);
            }
            else
            {
                listIdStreets = idsStreet[0].ToString();
            }


            var result = Worker.GetListRafts(listIdWarehouses, listIdZones, listIdStreets);

            if (result != null && result.Rows.Count > 0)
            {
                wMSDataSet.Catalog_Raft.Clear();

                wMSDataSet.Catalog_Raft.Merge(result);
            }
            else
            {
                wMSDataSet.Catalog_Raft.Clear(); ;
            }

        }

        public void FillShelfTable(List<int> idsWarehouse, List<int> idsZone, List<int> idsStreet, List<int> idsRafts)
        {
            string listIdWarehouses = "";
            string listIdZones = "";
            string listIdStreets = "";
            string listIdRafts = "";

            if (idsWarehouse.Count == 0 || idsZone.Count == 0 || idsStreet.Count == 0 || idsRafts.Count == 0) return;

            if (idsWarehouse.Count >= 1)
            {
                foreach (int i in idsWarehouse)
                {
                    listIdWarehouses = listIdWarehouses + i.ToString() + ",";
                }
                listIdWarehouses = listIdWarehouses.Substring(0, listIdWarehouses.Length - 1);
            }
            else
            {
                listIdWarehouses = idsWarehouse[0].ToString();
            }

            if (idsZone.Count >= 1)
            {
                foreach (int i in idsZone)
                {
                    listIdZones = listIdZones + i.ToString() + ",";
                }
                listIdZones = listIdZones.Substring(0, listIdZones.Length - 1);
            }
            else
            {
                listIdZones = idsZone[0].ToString();
            }

            if (idsStreet.Count >= 1)
            {
                foreach (int i in idsStreet)
                {
                    listIdStreets = listIdStreets + i.ToString() + ",";
                }
                listIdStreets = listIdStreets.Substring(0, listIdStreets.Length - 1);
            }
            else
            {
                listIdStreets = idsStreet[0].ToString();
            }

            if (idsRafts.Count >= 1)
            {
                foreach (int i in idsRafts)
                {
                    listIdRafts = listIdRafts + i.ToString() + ",";
                }
                listIdRafts = listIdRafts.Substring(0, listIdRafts.Length - 1);
            }
            else
            {
                listIdRafts = idsRafts[0].ToString();
            }


            var result = Worker.GetListShelfs(listIdWarehouses, listIdZones, listIdStreets, listIdRafts);

            if (result != null && result.Rows.Count > 0)
            {
                wMSDataSet.Catalog_Shelfs.Clear();

                wMSDataSet.Catalog_Shelfs.Merge(result);
            }
            else
            {
                wMSDataSet.Catalog_Shelfs.Clear(); ;
            }

        }

        public void FillAddressesTable(List<int> idsWarehouse, List<int> idsZone, List<int> idsStreet, List<int> idsRafts, List<int> idsShelfs)
        {
            string listIdWarehouses = "";
            string listIdZones = "";
            string listIdStreets = "";
            string listIdRafts = "";
            string listIdShelfs = "";

            if (idsWarehouse.Count == 0 || idsZone.Count == 0 || idsStreet.Count == 0 || idsRafts.Count == 0 || idsShelfs.Count == 0) return;

            if (idsWarehouse.Count >= 1)
            {
                listIdWarehouses = idsWarehouse.Aggregate(listIdWarehouses, (current, i) => current + i.ToString() + ",");
                listIdWarehouses = listIdWarehouses.Substring(0, listIdWarehouses.Length - 1);
            }
            else
                listIdWarehouses = idsWarehouse[0].ToString();

            if (idsZone.Count >= 1)
            {
                listIdZones = idsZone.Aggregate(listIdZones, (current, i) => current + i.ToString() + ",");
                listIdZones = listIdZones.Substring(0, listIdZones.Length - 1);
            }
            else
                listIdZones = idsZone[0].ToString();

            if (idsStreet.Count >= 1)
            {
                listIdStreets = idsStreet.Aggregate(listIdStreets, (current, i) => current + i.ToString() + ",");
                listIdStreets = listIdStreets.Substring(0, listIdStreets.Length - 1);
            }
            else
                listIdStreets = idsStreet[0].ToString();

            if (idsRafts.Count >= 1)
            {
                listIdRafts = idsRafts.Aggregate(listIdRafts, (current, i) => current + i.ToString() + ",");
                listIdRafts = listIdRafts.Substring(0, listIdRafts.Length - 1);
            }
            else
                listIdRafts = idsRafts[0].ToString();

            if (idsShelfs.Count >= 1)
            {
                listIdShelfs = idsShelfs.Aggregate(listIdShelfs, (current, i) => current + i.ToString() + ",");
                listIdShelfs = listIdShelfs.Substring(0, listIdShelfs.Length - 1);
            }
            else
                listIdShelfs = idsShelfs[0].ToString();


            var result = Worker.GetListAddresses(listIdWarehouses, listIdZones, listIdStreets, listIdRafts, listIdShelfs);

            if (result != null && result.Rows.Count > 0)
            {
                wMSDataSet.ListAddresses.Clear();

                wMSDataSet.ListAddresses.Merge(result);
            }
            else
            {
                wMSDataSet.ListAddresses.Clear(); ;
            }

        }
        #endregion

        private void GetListAddressesButtonClick(object sender, EventArgs e)
        {
            var warehouseCheckedItems = (from object checkedItem in warehouseCheckedListBoxControl.CheckedIndices
                                         select Convert.ToInt32(warehouseCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var zonesCheckedItems = (from object checkedItem in zonesCheckedListBoxControl.CheckedIndices
                                     select Convert.ToInt32(zonesCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var streetsCheckedItems = (from object checkedItem in streetsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(streetsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var raftsCheckedItems = (from object checkedItem in raftsCheckedListBoxControl.CheckedIndices
                                     select
                                         Convert.ToInt32(raftsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var shelftsCheckedItems = (from object checkedItem in shelfsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(shelfsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            if (warehouseCheckedItems.Count != 0 && zonesCheckedItems.Count != 0 && streetsCheckedItems.Count != 0 && raftsCheckedItems.Count != 0 && shelftsCheckedItems.Count != 0)
            {
                warehouseCheckedListBoxControl.Enabled = false;
                zonesCheckedListBoxControl.Enabled = false;
                streetsCheckedListBoxControl.Enabled = false;
                raftsCheckedListBoxControl.Enabled = false;
                shelfsCheckedListBoxControl.Enabled = false;
                getListAddressesButton.Enabled = false;
                createNewListButton.Enabled = true;
                finishScanButton.Enabled = true;
                finishScanButton.Visible = true;
                groupControl2.Visible = true;

                scanAddresTextEdit.Focus();

                FillAddressesTable(warehouseCheckedItems, zonesCheckedItems, streetsCheckedItems, raftsCheckedItems, shelftsCheckedItems);
            }

        }

        private void CreateNewListButtonClick(object sender, EventArgs e)
        {
            warehouseCheckedListBoxControl.Enabled = true;
            zonesCheckedListBoxControl.Enabled = true;
            streetsCheckedListBoxControl.Enabled = true;
            raftsCheckedListBoxControl.Enabled = true;
            shelfsCheckedListBoxControl.Enabled = true;
            getListAddressesButton.Enabled = false;
            createNewListButton.Enabled = false;
            finishScanButton.Enabled = false;
            finishScanButton.Visible = false;
            deleteAddressesButton.Enabled = false;
            deleteAddressesButton.Visible = false;

            shelfsCheckedListBoxControl.UnCheckAll();
            raftsCheckedListBoxControl.UnCheckAll();
            streetsCheckedListBoxControl.UnCheckAll();
            zonesCheckedListBoxControl.UnCheckAll();
            warehouseCheckedListBoxControl.UnCheckAll();
            wMSDataSet.ListAddresses.Clear();
            listAddressesGridControl.Enabled = true;
            scanAddresTextEdit.Enabled = true;
            groupControl2.Visible = false;
        }

        private void FinishScanButtonClick(object sender, EventArgs e)
        {
            finishScanButton.Enabled = false;

            listAddressesGridControl.Enabled = false;
            scanAddresTextEdit.Enabled = false;

            deleteAddressesButton.Enabled = true;
            deleteAddressesButton.Visible = true;
        }

        private void ScanAddresTextEditKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                DataRow[] dr = wMSDataSet.ListAddresses.Select(string.Format("AddressStr = '{0}'", scanAddresTextEdit.Text));
                if (dr.Length != 0)
                {
                    foreach (DataRow dataRow in dr)
                    {
                        wMSDataSet.ListAddresses.RemoveListAddressesRow((WMSDataSet.ListAddressesRow)dataRow);
                    }

                    if (wMSDataSet.ListAddresses.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("По данному списку инвентаризация прошла успешно\nМожно начинать другой список", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CreateNewListButtonClick(null,null);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Такой адрес не найден в текущем списке", "Ошибка!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }

                scanAddresTextEdit.Focus();
                scanAddresTextEdit.SelectAll();
            }
        }

        private void DeleteAddressesButtonClick(object sender, EventArgs e)
        {
            /*
            DataRow[] dr = wMSDataSet.ListAddresses.Select();
            List<int> idAddresses = dr.Select(dataRow => Convert.ToInt32(dataRow["ID"])).ToList();
            string listIdAddresses = "";
            if (idAddresses.Count >= 1)
            {
                listIdAddresses = idAddresses.Aggregate(listIdAddresses, (current, i) => current + i.ToString() + ",");
                listIdAddresses = listIdAddresses.Substring(0, listIdAddresses.Length - 1);
            }
            else
                listIdAddresses = idAddresses[0].ToString();
            */

            var result =
                Worker.GetInfoClearAddresses(GlobalParameters.SplitIntDataRowToString(
                    wMSDataSet.ListAddresses.Select(), "ID"));
            wMSDataSet.ListRestAddresses.Clear();
            if (result.Select("ClearAddresses = 0").Length != result.Rows.Count)
            {
                if (result.Select("ClearAddresses = 1").Length != result.Rows.Count)
                {
                    if (XtraMessageBox.Show(string.Format("" +
                                                          "Из {0} адрес(а-ов) подлежащих удалению\n{1} адрес(а-ов) свободны и будут удалены.\n" +
                                                          "По остальным {2} занятым адрес(а-ам) будет создан отчёт для анализа.\n" +
                                                          "Желаете продолжить?", result.Select().Length,
                                                          result.Select("ClearAddresses = 1").Length,
                                                          result.Select("ClearAddresses = 0").Length),
                                            "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                    {
                        XtraMessageBox.Show(
                            string.Format("Было успешно очищено {0} шт. адрес(а-ов)",
                                          Worker.ClearAddresses(GlobalParameters.SplitIntDataRowToString(result.Select("ClearAddresses = 1"), "idAdress"),
                                                                ObjectsForMainApplication.IdUserLogined)), "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        wMSDataSet.ListRestAddresses.Merge(Worker.GetInfoRestAddresses(GlobalParameters.SplitIntDataRowToString(result.Select("ClearAddresses = 0"), "idAdress")));

                        ShowPrintFormForGrid(restListAddressesGridControl);
                    }
                    else
                    {
                        CreateNewListButtonClick(null,null);
                    }
                }
                else
                {
                    XtraMessageBox.Show(
                            string.Format("Было успешно очищено {0} шт. адрес(а-ов)",
                                          Worker.ClearAddresses(GlobalParameters.SplitIntDataRowToString(result.Select("ClearAddresses = 1"), "idAdress"),
                                                                ObjectsForMainApplication.IdUserLogined)), "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CreateNewListButtonClick(null, null);
                }
            }
            else
            {
                if (XtraMessageBox.Show("Все оставшиеся адреса заняты\nНеобходимо сначала разобраться с адресами\nСоздать отчёт и начать заново?",
                                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    wMSDataSet.ListRestAddresses.Clear();
                    wMSDataSet.ListRestAddresses.Merge(
                        Worker.GetInfoRestAddresses(
                            GlobalParameters.SplitIntDataRowToString(result.Select("ClearAddresses = 0"), "idAdress")));
                    ShowPrintFormForGrid(restListAddressesGridControl);
                    
                    CreateNewListButtonClick(null, null);
                }
                else
                    CreateNewListButtonClick(null, null);
            }
            CreateNewListButtonClick(null,null);
        }

        

        public void ShowPrintFormForGrid(GridControl grid)
        {
            grid.Visible = true;
            var ps = new PrintingSystem();
            var link = new PrintableComponentLink(ps);

            link.Component = grid;

            link.PaperKind = PaperKind.A4;

            link.Margins.Bottom = 10;
            link.Margins.Left = 10;
            link.Margins.Right = 10;
            link.Margins.Top = 10;

            link.Landscape = true;

            link.CreateReportHeaderArea += LinkCreateReportHeaderArea;

            link.CreateDocument();

            link.ShowPreviewDialog();

            grid.Visible = false;
        }

        public void LinkCreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string reportHeader = "Список адресов требующие анализа";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 14, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

    }
    public class MyListCheckedItems
    {
        public int IndexItem { get; set; }
        public CheckState Checked { get; set; }
    }
}
