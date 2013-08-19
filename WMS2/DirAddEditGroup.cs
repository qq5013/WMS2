using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;
using WMS.DataBaseLayers;

namespace WMS.MainApplication
{
    public partial class DirAddEditGroup : XtraForm
    {
        public int IdGroup { get; private set; }
        public string NameGroup { get; private set; }
        public string DescriptionGroup { get; private set; }
        public int IdWarehouse { get; private set; }
        public int IdZone { get; private set; }
        public bool AddNewRecord { get; private set; }
        public bool CheckManual { get; set; }
        public bool IsForeach = false;

        public DirAddEditGroup(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            RenameLabels();
            CheckManual = true;
        }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int idGroup, string nameGroup, string descriptionGroup, int idWarehouse, int idZone)
        {
            IdGroup = idGroup;
            NameGroup = nameGroup;
            DescriptionGroup = descriptionGroup;
            IdWarehouse = idWarehouse;
            IdZone = idZone;
        }

        private void RenameLabels()
        {
            Text = AddNewRecord ? "Добавление новой зональной группы" : "Изменение зональной группы";
        }


        private void DirAddEditGroupLoad(object sender, EventArgs e)
        {
            if (AddNewRecord)
                catalog_RotationsProductForGroupTableAdapter.Fill(wMSDataSet.Catalog_RotationsProductForGroup, -1);
            else
                catalog_RotationsProductForGroupTableAdapter.Fill(wMSDataSet.Catalog_RotationsProductForGroup, IdGroup);
            
            catalog_WarehousesTableAdapter.Fill(wMSDataSet.Catalog_Warehouses);
            catalog_ZonesTableAdapter.Fill(wMSDataSet.Catalog_Zones);
            
            nameGroupTextEdit.Text = NameGroup;
            descriptionGroupTextEdit.Text = DescriptionGroup;
            if (!AddNewRecord)
            {
                var worker = new DbDirsAddEdit();
                var worker2 = new DbDirsAddEdit.DbDirsDataTables();
                zonesLookUpEdit.Enabled = true;
                streetsCheckedListBoxControl.Enabled = true;
                raftsCheckedListBoxControl.Enabled = true;
                
                warehouseLookUpEdit.EditValue =
                    warehouseLookUpEdit.Properties.GetDataSourceValue(
                        warehouseLookUpEdit.Properties.Columns["ID"],
                        warehouseLookUpEdit.Properties.GetDataSourceRowIndex("ID", IdWarehouse));
                zonesLookUpEdit.EditValue =
                    zonesLookUpEdit.Properties.GetDataSourceValue(
                        zonesLookUpEdit.Properties.Columns["ID"],
                        zonesLookUpEdit.Properties.GetDataSourceRowIndex("ID", IdZone));
                wMSDataSet.ListStreets.Clear();
                wMSDataSet.ListStreets.Merge(worker2.FillTableListsStreets(Convert.ToInt32(warehouseLookUpEdit.EditValue),
                                             Convert.ToInt32(zonesLookUpEdit.EditValue)));

                wMSDataSet.ListRafts.Clear();

                var ds = worker.GetReferenceGroupWithRaftsAndStreets(IdGroup);
                foreach (var id in ds.Tables["Streets"].Select().Select(row => row[0]))
                {
                    streetsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(streetsCheckedListBoxControl, id),
                                                                true);
                }
                /*
                var streetsCheckedItems = (from object checkedItem in streetsCheckedListBoxControl.CheckedIndices
                                           select
                                               Convert.ToInt32(streetsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();
                wMSDataSet.ListRafts.Merge(worker2.FillTableListsRafts(Convert.ToInt32(warehouseLookUpEdit.EditValue),
                                                                      Convert.ToInt32(zonesLookUpEdit.EditValue),
                                                                      GlobalParameters.SplitListToString(
                                                                          streetsCheckedItems)));
                 * */
                foreach (var id in ds.Tables["Rafts"].Select().Select(row => row[0]))
                {
                    raftsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(raftsCheckedListBoxControl, id),
                                                                true);
                }
            }
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

        private void WarehouseLookUpEditEditValueChanged(object sender, EventArgs e)
        {
            if (warehouseLookUpEdit.EditValue == null) return;
            zonesLookUpEdit.Enabled = true;
            catalog_ZonesTableAdapter.Fill(wMSDataSet.Catalog_Zones);
        }

        private void ZonesLookUpEditEditValueChanged(object sender, EventArgs e)
        {
            if (zonesLookUpEdit.EditValue == null) return;
            streetsCheckedListBoxControl.Enabled = true;
            var worker = new DbDirsAddEdit.DbDirsDataTables();
            wMSDataSet.ListStreets.Clear();
            wMSDataSet.ListStreets.Merge(worker.FillTableListsStreets(Convert.ToInt32(warehouseLookUpEdit.EditValue),
                                         Convert.ToInt32(zonesLookUpEdit.EditValue)));
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (nameGroupTextEdit.Text != NameGroup || descriptionGroupTextEdit.Text != DescriptionGroup || Convert.ToInt32(warehouseLookUpEdit.EditValue) != IdWarehouse || Convert.ToInt32(zonesLookUpEdit.EditValue) != IdZone)
            {
                if (XtraMessageBox.Show("Отменить все изменения и выйти?", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    Close();
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
        }

        private void StreetsCheckedListBoxControlItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.State == CheckState.Checked && CheckManual)
            {
                CheckManual = false;
                DataRow[] dr = wMSDataSet.ListStreets.Select("[ID] <> 0");

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
                    DataRow[] dr = wMSDataSet.ListStreets.Select("[ID] <> 0");

                    foreach (DataRow dataRow in dr)
                    {
                        IsForeach = true;
                        var id = dataRow[0];
                        streetsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id), false);
                    }
                    IsForeach = false;
                }
                else
                {
                    CheckManual = true;
                }
            }

            if (IsForeach) return;

            
            var streetsCheckedItems = (from object checkedItem in streetsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(streetsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            wMSDataSet.ListRafts.Clear();

            if (streetsCheckedItems.Count == 1 && streetsCheckedItems[0] == 0)
            {
                wMSDataSet.ListRafts.Clear();
                streetsCheckedListBoxControl.UnCheckAll();
                return;
            }


            if (warehouseLookUpEdit.EditValue != null && zonesLookUpEdit.EditValue != null && streetsCheckedItems.Count != 0)
            {
                var worker = new DbDirsAddEdit.DbDirsDataTables();
                raftsCheckedListBoxControl.Enabled = true;
                wMSDataSet.ListRafts.Clear();

                wMSDataSet.ListRafts.Merge(worker.FillTableListsRafts(Convert.ToInt32(warehouseLookUpEdit.EditValue),
                                                                      Convert.ToInt32(zonesLookUpEdit.EditValue),
                                                                      GlobalParameters.SplitListToString(
                                                                          streetsCheckedItems)));
                //FillRaftTable(warehouseCheckedItems, zonesCheckedItems, streetsCheckedItems);
            }
            else
            {
                wMSDataSet.ListRafts.Clear();
                raftsCheckedListBoxControl.Enabled = false;
            }
        }

        private void RaftsCheckedListBoxControlItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.State == CheckState.Checked && CheckManual)
            {
                CheckManual = false;
                DataRow[] dr = wMSDataSet.ListRafts.Select("[ID] <> 0");

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
                    DataRow[] dr = wMSDataSet.ListRafts.Select("[ID] <> 0");

                    foreach (DataRow dataRow in dr)
                    {
                        IsForeach = true;
                        var id = dataRow[0];
                        raftsCheckedListBoxControl.SetItemChecked(GetIndexFindedItem(sender as CheckedListBoxControl, id), false);
                    }
                    IsForeach = false;
                }
                else
                {
                    CheckManual = true;
                }
            }

            if (IsForeach) return;


            var raftsCheckedItems = (from object checkedItem in raftsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(raftsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            var streetsCheckedItems = (from object checkedItem in streetsCheckedListBoxControl.CheckedIndices
                                     select
                                         Convert.ToInt32(streetsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();

            if (raftsCheckedItems.Count == 1 && raftsCheckedItems[0] == 0)
            {
                streetsCheckedListBoxControl.UnCheckAll();
                return;
            }


            if (warehouseLookUpEdit.EditValue != null && zonesLookUpEdit.EditValue != null && streetsCheckedItems.Count != 0 && raftsCheckedItems.Count != 0)
            {
               
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var raftsCheckedItems = (from object checkedItem in raftsCheckedListBoxControl.CheckedIndices
                                     select
                                         Convert.ToInt32(raftsCheckedListBoxControl.GetItemValue((int)checkedItem)))
               .ToList();

            var streetsCheckedItems = (from object checkedItem in streetsCheckedListBoxControl.CheckedIndices
                                       select
                                           Convert.ToInt32(streetsCheckedListBoxControl.GetItemValue((int)checkedItem)))
                .ToList();
            if (
                nameGroupTextEdit.Text == string.Empty ||
                descriptionGroupTextEdit.Text == string.Empty ||
                warehouseLookUpEdit.EditValue == null ||
                zonesLookUpEdit.EditValue == null ||
                streetsCheckedItems.Count == 0 ||
                raftsCheckedItems.Count == 0
                )
            {
                XtraMessageBox.Show("Не заполнено одно или более обязательных полей!", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AddNewRecord)
            {
                var worker = new DbDirsAddEdit();
                var idNewGroup = worker.AddEditGroup(nameGroupTextEdit.Text, descriptionGroupTextEdit.Text,
                                                  Convert.ToInt32(zonesLookUpEdit.EditValue),
                                                  Convert.ToInt32(warehouseLookUpEdit.EditValue), AddNewRecord);
                worker.AddReferenceGroupWithAddressesInCatalog(idNewGroup,
                    GlobalParameters.SplitListToString(streetsCheckedItems),
                    GlobalParameters.SplitListToString(raftsCheckedItems), AddNewRecord);

                var dr = wMSDataSet.Catalog_RotationsProductForGroup.Select();
                foreach (DataRow dataRow in dr)
                {
                    worker.AddEditGroupRotations(Convert.ToInt32(dataRow["ID"]), idNewGroup,
                                                 Convert.ToDecimal(dataRow["MinQty"]),
                                                 Convert.ToDecimal(dataRow["MaxQty"]));
                }

            }
            else
            {
                var worker = new DbDirsAddEdit();
                worker.AddReferenceGroupWithAddressesInCatalog(
                    worker.AddEditGroup(nameGroupTextEdit.Text, descriptionGroupTextEdit.Text,
                                        Convert.ToInt32(zonesLookUpEdit.EditValue),
                                        Convert.ToInt32(warehouseLookUpEdit.EditValue), AddNewRecord, IdGroup),
                    GlobalParameters.SplitListToString(streetsCheckedItems),
                    GlobalParameters.SplitListToString(raftsCheckedItems), AddNewRecord);

                var dr = wMSDataSet.Catalog_RotationsProductForGroup.Select();
                foreach (DataRow dataRow in dr)
                {
                    worker.AddEditGroupRotations(Convert.ToInt32(dataRow["ID"]), IdGroup,
                                                 Convert.ToDecimal(dataRow["MinQty"]),
                                                 Convert.ToDecimal(dataRow["MaxQty"]));
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}