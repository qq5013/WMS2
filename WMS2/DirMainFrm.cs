using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using WMS.DataBaseLayers;
using WMS.Globals;

namespace WMS.MainApplication
{
    public partial class DirMainFrm : XtraForm
    {
        public DirMainFrm()
        {
            InitializeComponent();
            mainTabControl.SelectedPageChanged += MainTabControlSelectedPageChanged;
        }

        private void Form1Load(object sender, EventArgs e)
        {
            
            
            
        }

        #region Отработка контекстного меню на гридах
        private void ResponsibleForZoneGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void ZonesGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void WarehouseGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void StreetGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void RaftGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void ShelfSpaceGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void RotationGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void ShelfsGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void UnitsGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void ProductsGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void TypeOfRestsGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        private void GroupsGridViewPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var view = sender as GridView;

            if (view == null) return;
            var hitInfo = view.CalcHitInfo(e.Point);

            if (!hitInfo.InRow) return;
            view.FocusedRowHandle = hitInfo.RowHandle;
            if (view.FocusedRowHandle < 0) return;
            gridContextMenuStrip.Show(view.GridControl, e.Point);
        }
        #endregion
        
        #region Обработка кликов в выпадающем меню
        private void ResZoneBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.ResponsibleForZone);
            ShowTab(DirLinks.ResponsibleForZone);
        }
        private void ZonesBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Zones);
            ShowTab(DirLinks.Zones);
        }
        private void WarehousesBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Warehouse);
            ShowTab(DirLinks.Warehouse);

        }
        private void StreetsBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Street);
            ShowTab(DirLinks.Street);
        }
        private void RaftBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Raft);
            ShowTab(DirLinks.Raft);
        }
        private void ShelfSpacesBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.ShelfSpace);
            ShowTab(DirLinks.ShelfSpace);
        }
        private void ShelfsBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Shelf);
            ShowTab(DirLinks.Shelf);
        }
        private void RotationBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Rotation);
            ShowTab(DirLinks.Rotation);
        }
        private void UnitsBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Unit);
            ShowTab(DirLinks.Unit);
        }
        private void ProductsBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Products);
            ShowTab(DirLinks.Products);
        }
        private void RestsBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Rests);
            ShowTab(DirLinks.Rests);
        }
        private void MultiplicityProductBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.Multiplicity);
            ShowTab(DirLinks.Multiplicity);
        }
        private void GroupProductsBarItemLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FillGrid(DirLinks.GroupProducts);
            ShowTab(DirLinks.GroupProducts);
        }
        #endregion
        
        #region Событя горячих клавиш и кнопок "Добавить, Изменить, Удалить"
        private void AddButtonClick(object sender, EventArgs e)
        {
            if (gridControl.MainView == responsibleForZoneGridView)
                FAddResponsibleForZone();
            if (gridControl.MainView == zonesGridView)
                FAddZone();
            if (gridControl.MainView == warehouseGridView)
                FAddWarehouse();
            if (gridControl.MainView == streetGridView)
                FAddStreet();
            if (gridControl.MainView == raftGridView)
                FAddRaft();
            if (gridControl.MainView == shelfSpaceGridView)
                FAddShelfSpace();
            if (gridControl.MainView == shelfsGridView)
                FAddShelf();
            if (gridControl.MainView == rotationGridView)
                FAddRotation();
            if (gridControl.MainView == unitsGridView)
                FAddUnit();
            if (gridControl.MainView == typeOfRestsGridView)
                FAddRests();
            if (gridControl.MainView == groupsGridView)
                FAddGroup();
        }
        private void EditButtonClick(object sender, EventArgs e)
        {
            if (gridControl.MainView == responsibleForZoneGridView)
                FEditResponsibleForZone();
            if (gridControl.MainView == zonesGridView)
                FEditZone();
            if (gridControl.MainView == warehouseGridView)
                FEditWarehouse();
            if (gridControl.MainView == streetGridView)
                FEditStreet();
            if (gridControl.MainView == raftGridView)
                FEditRaft();
            if (gridControl.MainView == shelfSpaceGridView)
                FEditShelfSpace();
            if (gridControl.MainView == shelfsGridView)
                FEditShelf();
            if (gridControl.MainView == rotationGridView)
                FEditRotation();
            if (gridControl.MainView == unitsGridView)
                FEditUnit();
            if (gridControl.MainView == productsGridView)
                FEditProduct();
            if (gridControl.MainView == typeOfRestsGridView)
                FEditRests();
            if (gridControl.MainView == groupsGridView)
                FEditGroup();
        }
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var worker = new DbDirsAddEdit(); 
            if (gridControl.MainView == warehouseGridView)
                if (warehouseGridView.FocusedRowHandle >= 0)
                {
                    if (XtraMessageBox.Show("Вы действительно хотите удалить склад?", "Внимание!", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                    if (worker.DeleteDirectoriesItem(TypeOfCatalog.Warehouse,
                                                 Convert.ToInt32(
                                                     warehouseGridView.GetRowCellValue(
                                                         warehouseGridView.FocusedRowHandle, colWarehouseID))))
                    {
                        XtraMessageBox.Show("Склад успешно удалён", "Информация", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        catalog_WarehousesTableAdapter.Fill(wMSDataSet.Catalog_Warehouses);
                    }
                    else
                        XtraMessageBox.Show("Склад не возможно удалить!!!\nДанный склад учавствует в адрессации!",
                                            "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            if (gridControl.MainView == streetGridView)
                if (streetGridView.FocusedRowHandle >= 0)
                {
                    if (XtraMessageBox.Show("Вы действительно хотите удалить Улицу?", "Внимание!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                    if (worker.DeleteDirectoriesItem(TypeOfCatalog.Street,
                                                 Convert.ToInt32(
                                                     streetGridView.GetRowCellValue(
                                                         streetGridView.FocusedRowHandle, colStreetID))))
                    {
                        XtraMessageBox.Show("Улица успешно удалёна", "Информация", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        catalog_StreetsTableAdapter.Fill(wMSDataSet.Catalog_Streets);
                    }

                    else
                        XtraMessageBox.Show("Улицу не возможно удалить!!!\nДанная улица учавствует в адрессации!",
                                            "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            if (gridControl.MainView == raftGridView)
                if (raftGridView.FocusedRowHandle >= 0)
                {
                    if (XtraMessageBox.Show("Вы действительно хотите удалить стеллаж?", "Внимание!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                    if (worker.DeleteDirectoriesItem(TypeOfCatalog.Raft,
                                                 Convert.ToInt32(
                                                     raftGridView.GetRowCellValue(
                                                         raftGridView.FocusedRowHandle, colRaftID))))
                    {
                        XtraMessageBox.Show("Стеллаж успешно удалён", "Информация", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        catalog_RaftTableAdapter.Fill(wMSDataSet.Catalog_Raft);
                    }
                    else
                        XtraMessageBox.Show("Стеллаж не возможно удалить!!!\nДанный стеллаж учавствует в адрессации!",
                                            "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            if (gridControl.MainView == shelfsGridView)
                if (shelfsGridView.FocusedRowHandle >= 0)
                {
                    if (XtraMessageBox.Show("Вы действительно хотите удалить полку?", "Внимание!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                    if (worker.DeleteDirectoriesItem(TypeOfCatalog.Shelf,
                                                 Convert.ToInt32(
                                                     shelfsGridView.GetRowCellValue(
                                                         shelfsGridView.FocusedRowHandle, colShelfID))))
                    {
                        XtraMessageBox.Show("Полка успешно удалёна", "Информация", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        catalog_ShelfsTableAdapter.Fill(wMSDataSet.Catalog_Shelfs);
                    }

                    else
                        XtraMessageBox.Show("Полку не возможно удалить!!!\nДанная полка учавствует в адрессации!",
                                            "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            if (gridControl.MainView == shelfSpaceGridView)
                if (shelfSpaceGridView.FocusedRowHandle >= 0)
                {
                    if (XtraMessageBox.Show("Вы действительно хотите удалить место на полке?", "Внимание!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                    if (worker.DeleteDirectoriesItem(TypeOfCatalog.ShelfSpace,
                                                 Convert.ToInt32(
                                                     shelfSpaceGridView.GetRowCellValue(
                                                         shelfSpaceGridView.FocusedRowHandle, colShelSpaceID))))
                    {
                        XtraMessageBox.Show("Место успешно удалёно", "Информация", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        catalog_ShelfSpacesTableAdapter.Fill(wMSDataSet.Catalog_ShelfSpaces);
                    }

                    else
                        XtraMessageBox.Show("Место не возможно удалить!!!\nДанное место учавствует в адрессации!",
                                            "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
        }
        
        private void GridControlKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
                AddButtonClick(null, null);
            if (e.KeyData == Keys.F4)
                EditButtonClick(null, null);
            if (e.KeyData == Keys.F8)
                DeleteButtonClick(null, null);
        }
        private void AddStripMenuItemClick(object sender, EventArgs e)
        {
            AddButtonClick(null, null);
        }
        private void EditStripMenuItemClick(object sender, EventArgs e)
        {
            EditButtonClick(null,null);
        }
        private void DeleteStripMenuItemClick(object sender, EventArgs e)
        {
            DeleteButtonClick(null,null);
        }
        #endregion
        
        #region Методы добавлений новых записей в справочники

        private void FAddResponsibleForZone()
        {
            var dirAddEdit = new DirAddEditResponsibleForZone(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_ResponsibleForTheZoneTableAdapter.Fill(wMSDataSet.Catalog_ResponsibleForTheZone);
        }
        private void FAddZone()
        {
            var dirAddEdit = new DirAddEditZone(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_ZonesTableAdapter.Fill(wMSDataSet.Catalog_Zones);
        }
        private void FAddWarehouse()
        {
            var dirAddEdit = new DirAddEditWarehouse(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_WarehousesTableAdapter.Fill(wMSDataSet.Catalog_Warehouses);
        }
        private void FAddStreet()
        {
            var dirAddEdit = new DirAddEditStreet(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_StreetsTableAdapter.Fill(wMSDataSet.Catalog_Streets);
        }
        private void FAddRaft()
        {
            var dirAddEdit = new DirAddEditItem(TypeOfDir.Raft, true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_RaftTableAdapter.Fill(wMSDataSet.Catalog_Raft);
        }
        private void FAddShelfSpace()
        {
            var dirAddEdit = new DirAddEditItem(TypeOfDir.ShelfSpace, true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_ShelfSpacesTableAdapter.Fill(wMSDataSet.Catalog_ShelfSpaces);
        }
        private void FAddShelf()
        {
            var dirAddEdit = new DirAddEditItem2(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_ShelfsTableAdapter.Fill(wMSDataSet.Catalog_Shelfs);
        }
        private void FAddRotation()
        {
            var dirAddEdit = new DirAddEditRotation(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_RotationsProductTableAdapter.Fill(wMSDataSet.Catalog_RotationsProduct);
        }
        private void FAddUnit()
        {
            var dirAddEdit = new DirAddEditUnit(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_UnitsTableAdapter.Fill(wMSDataSet.Catalog_Units);
        }
        private void FAddRests()
        {
            var dirAddEdit = new DirAddEditRests(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_TypeOfRestsTableAdapter.Fill(wMSDataSet.Catalog_TypeOfRests);
        }
        private void FAddGroup()
        {
            var dirAddEdit = new DirAddEditGroup(true);
            if (dirAddEdit.ShowDialog() != DialogResult.OK) return;
            catalog_GroupTableAdapter.Fill(wMSDataSet.Catalog_Group);
        }
        #endregion
        
        #region Методы изменений записей в справочниках
        private void FEditResponsibleForZone()
        {
            var dirAddEdit = new DirAddEditResponsibleForZone(false);

            var id = Convert.ToInt32(responsibleForZoneGridView.GetRowCellValue(responsibleForZoneGridView.FocusedRowHandle, colResZoneID));
            var name = responsibleForZoneGridView.GetRowCellValue(responsibleForZoneGridView.FocusedRowHandle, colResZoneName).ToString();
            var idZona = Convert.ToInt32(responsibleForZoneGridView.GetRowCellValue(responsibleForZoneGridView.FocusedRowHandle, colResZoneID_Zone));
            
            dirAddEdit.SetData(id, name, idZona);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.ResponsibleForZone);
            }

            responsibleForZoneGridView.FocusedRowHandle = id - 1;
        }
        private void FEditZone()
        {
            var dirAddEdit = new DirAddEditZone(false);

            var id = Convert.ToInt32(zonesGridView.GetRowCellValue(zonesGridView.FocusedRowHandle, colZoneID));
            var name = zonesGridView.GetRowCellValue(zonesGridView.FocusedRowHandle, colZoneName).ToString();
            var description = zonesGridView.GetRowCellValue(zonesGridView.FocusedRowHandle, colZoneDescription).ToString();
            
            dirAddEdit.SetData(id, name, description);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Zones);
            }

            zonesGridView.FocusedRowHandle = id - 1;
        }
        private void FEditWarehouse()
        {
            var dirAddEdit = new DirAddEditWarehouse(false);

            var id = Convert.ToInt32(warehouseGridView.GetRowCellValue(warehouseGridView.FocusedRowHandle, colWarehouseID));
            var name = warehouseGridView.GetRowCellValue(warehouseGridView.FocusedRowHandle, colWarehouseName).ToString();
            var description = warehouseGridView.GetRowCellValue(warehouseGridView.FocusedRowHandle, colWarehouseDescription).ToString();
            var idTypeOfDistribution = Convert.ToInt32(warehouseGridView.GetRowCellValue(warehouseGridView.FocusedRowHandle,
                                                                         colIdTypeOfDistribution));
            dirAddEdit.SetData(id, name, description, idTypeOfDistribution);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Warehouse);
            }

            warehouseGridView.FocusedRowHandle = id - 1;

        }
        private void FEditStreet()
        {
            var dirAddEdit = new DirAddEditStreet(false);

            int id = Convert.ToInt32(streetGridView.GetRowCellValue(streetGridView.FocusedRowHandle, colStreetID));
            string name = streetGridView.GetRowCellValue(streetGridView.FocusedRowHandle, colStreetName).ToString();
            string description = streetGridView.GetRowCellValue(streetGridView.FocusedRowHandle, colStreetDescription).ToString();
            int idZona =
                Convert.ToInt32(streetGridView.GetRowCellValue(streetGridView.FocusedRowHandle, colStreetZoneId));
            dirAddEdit.SetData(id, name, description, idZona);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Street);                
            }

            streetGridView.FocusedRowHandle = id - 1;
        }
        private void FEditRaft()
        {
            var dirAddEdit = new DirAddEditItem(TypeOfDir.Raft, false);

            int id = Convert.ToInt32(raftGridView.GetRowCellValue(raftGridView.FocusedRowHandle, colRaftID));
            string name = raftGridView.GetRowCellValue(raftGridView.FocusedRowHandle, colRaftName).ToString();
            string description = raftGridView.GetRowCellValue(raftGridView.FocusedRowHandle, colRaftDescription).ToString();
            dirAddEdit.SetData(id, name, description);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Raft);
            }

            raftGridView.FocusedRowHandle = id - 1;
        }
        private void FEditShelfSpace()
        {
            var dirAddEdit = new DirAddEditItem(TypeOfDir.ShelfSpace, false);

            int id = Convert.ToInt32(shelfSpaceGridView.GetRowCellValue(shelfSpaceGridView.FocusedRowHandle, colShelSpaceID));
            string name = shelfSpaceGridView.GetRowCellValue(shelfSpaceGridView.FocusedRowHandle, colShelSpaceName).ToString();
            string description = shelfSpaceGridView.GetRowCellValue(shelfSpaceGridView.FocusedRowHandle, colShelSpaceDescription).ToString();
            dirAddEdit.SetData(id, name, description);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.ShelfSpace);
            }

            shelfSpaceGridView.FocusedRowHandle = id - 1;
        }
        private void FEditShelf()
        {
            var dirAddEdit = new DirAddEditItem2(false);

            int id = Convert.ToInt32(shelfsGridView.GetRowCellValue(shelfsGridView.FocusedRowHandle, colShelfID));
            string name = shelfsGridView.GetRowCellValue(shelfsGridView.FocusedRowHandle, colShelfName).ToString();
            string description = shelfsGridView.GetRowCellValue(shelfsGridView.FocusedRowHandle, colShelfDescription).ToString();
            decimal height = Convert.ToDecimal(
                shelfsGridView.GetRowCellValue(shelfsGridView.FocusedRowHandle, colShelfHeight).ToString());
            decimal deph = Convert.ToDecimal(
                shelfsGridView.GetRowCellValue(shelfsGridView.FocusedRowHandle, colShelfDeph).ToString());
            string idTypeOfRotation = shelfsGridView.GetRowCellValue(shelfsGridView.FocusedRowHandle, colShelfID_TypeOfRotation).ToString();

            dirAddEdit.SetData(id, name, description, height, deph, idTypeOfRotation);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Shelf);
            }

            shelfsGridView.FocusedRowHandle = id - 1;
        }
        private void FEditRotation()
        {
            var dirAddEdit = new DirAddEditRotation(false);

            int id = Convert.ToInt32(rotationGridView.GetRowCellValue(rotationGridView.FocusedRowHandle, colRotID));
            string name = rotationGridView.GetRowCellValue(rotationGridView.FocusedRowHandle, colRotName).ToString();
            decimal min = Convert.ToDecimal(
                rotationGridView.GetRowCellValue(rotationGridView.FocusedRowHandle, colRotMinQty).ToString());
            decimal max = Convert.ToDecimal(
                rotationGridView.GetRowCellValue(rotationGridView.FocusedRowHandle, colRotMaxQty).ToString());

            dirAddEdit.SetData(id,name,min,max);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Rotation);
            }

            rotationGridView.FocusedRowHandle = id - 1;
        }
        private void FEditUnit()
        {
            var dirAddEdit = new DirAddEditUnit(false);
            var id = Convert.ToInt32(unitsGridView.GetRowCellValue(unitsGridView.FocusedRowHandle, colUnitID));
            var name = unitsGridView.GetRowCellValue(unitsGridView.FocusedRowHandle, colUnitName).ToString();
            var size = Convert.ToDecimal(
                unitsGridView.GetRowCellValue(unitsGridView.FocusedRowHandle, colSizeOfUnit).ToString());
            var distance = Convert.ToDecimal(
                unitsGridView.GetRowCellValue(unitsGridView.FocusedRowHandle, colDistanceBetweenUnits).ToString());

            dirAddEdit.SetData(id, name, size, distance);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Unit);
            }

            unitsGridView.FocusedRowHandle = id - 1;
        }
        private void FEditProduct()
        {
            var dirAddEdit = new DirAddEditProducts();
            var id = Convert.ToInt32(productsGridView.GetRowCellValue(productsGridView.FocusedRowHandle, colProductID));
            var name = productsGridView.GetRowCellValue(productsGridView.FocusedRowHandle, colProductDescription).ToString();
            var barCode = productsGridView.GetRowCellValue(productsGridView.FocusedRowHandle, colProductBarCode).ToString();
            var demensionX = Convert.ToDecimal(
                productsGridView.GetRowCellValue(productsGridView.FocusedRowHandle, colProductDimensionX).ToString());
            var demensionY = Convert.ToDecimal(
                productsGridView.GetRowCellValue(productsGridView.FocusedRowHandle, colProductDimensionY).ToString());
            var demensionZ = Convert.ToDecimal(
                productsGridView.GetRowCellValue(productsGridView.FocusedRowHandle, colProductDimensionZ).ToString());
            var weight = Convert.ToDecimal(
                productsGridView.GetRowCellValue(productsGridView.FocusedRowHandle, colProductWeight).ToString());
            var multiplicity = Convert.ToInt32(productsGridView.GetRowCellValue(productsGridView.FocusedRowHandle, colProductMultiplicity));

            dirAddEdit.SetData(id, name, barCode, demensionX, demensionY, demensionZ, weight, multiplicity);

            
            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Products);
            }
            
            productsGridView.FocusedRowHandle = id - 1;
        }
        private void FEditRests()
        {
            var dirAddEdit = new DirAddEditRests(false);
            var id = Convert.ToInt32(typeOfRestsGridView.GetRowCellValue(typeOfRestsGridView.FocusedRowHandle, colRetstsID));
            var name = typeOfRestsGridView.GetRowCellValue(typeOfRestsGridView.FocusedRowHandle, colRestsName).ToString();
            
            dirAddEdit.SetData(id, name);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.Rests);
            }

            typeOfRestsGridView.FocusedRowHandle = id - 1;
        }
        private void FEditGroup()
        {
            var dirAddEdit = new DirAddEditGroup(false);
            var idGroup = Convert.ToInt32(groupsGridView.GetRowCellValue(groupsGridView.FocusedRowHandle, colGroupID));
            var idZone = Convert.ToInt32(groupsGridView.GetRowCellValue(groupsGridView.FocusedRowHandle, colGroupZoneID));
            var idWarehouse = Convert.ToInt32(groupsGridView.GetRowCellValue(groupsGridView.FocusedRowHandle, colGroupWarehouseID));
            var nameGroup = groupsGridView.GetRowCellValue(groupsGridView.FocusedRowHandle, colNameGroup).ToString();
            var descriptionGroup = groupsGridView.GetRowCellValue(groupsGridView.FocusedRowHandle, colDescrriptionGroup).ToString();


            dirAddEdit.SetData(idGroup, nameGroup, descriptionGroup, idWarehouse, idZone);

            if (dirAddEdit.ShowDialog() == DialogResult.OK)
            {
                FillGrid(DirLinks.GroupProducts);
            }

            groupsGridView.FocusedRowHandle = idGroup - 1;
        }
        #endregion


        void MainTabControlSelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page != null && e.Page.PageEnabled) ChangeTab(mainTabControl.TabPages.IndexOf(e.Page));
            if (mainTabControl.TabPages.Count == 0)
            {
                addButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                addStripMenuItem.Enabled = false;
                editStripMenuItem.Enabled = false;
                deleteStripMenuItem.Enabled = false;
            }
            else
            {
                if (gridControl.MainView == productsGridView)
                {
                    addButton.Enabled = false;
                    editButton.Enabled = true;
                    deleteButton.Enabled = false;
                    addStripMenuItem.Enabled = false;
                    editStripMenuItem.Enabled = true;
                    deleteStripMenuItem.Enabled = false;
                }
                else
                {
                    addButton.Enabled = true;
                    editButton.Enabled = true;
                    deleteButton.Enabled = true;
                    addStripMenuItem.Enabled = true;
                    editStripMenuItem.Enabled = true;
                    deleteStripMenuItem.Enabled = true;
                }
            }
        }

        private void XtraTabControl1CloseButtonClick(object sender, EventArgs e)
        {
            var arg = e as ClosePageButtonEventArgs;
            if (arg == null) return;
            var xtraTabPage = arg.Page as XtraTabPage;
            if (xtraTabPage != null) xtraTabPage.Enabled = false;
            var myXtraTabPage = arg.Page as MyXtraTabPage;
            if (myXtraTabPage != null) myXtraTabPage.Enabled = false;
            mainTabControl.TabPages.Remove(arg.Page as XtraTabPage);
            mainTabControl.MyPages.Remove(arg.Page as MyXtraTabPage);
        }

        private void ChangeTab(int index)
        {
            FillGrid(mainTabControl.MyPages[index].TypeOfDir);

            mainTabControl.TabPages[index].Controls.Add(
                gridControl);
            gridControl.Visible = true;
            gridControl.Dock = DockStyle.Fill;
        }

        private void FillGrid (DirLinks dirLinks)
        {
            switch (dirLinks)
            {
                case DirLinks.ResponsibleForZone:
                    catalog_ResponsibleForTheZoneTableAdapter.Fill(wMSDataSet.Catalog_ResponsibleForTheZone);
                    gridControl.DataSource = catalogResponsibleForTheZoneBindingSource;
                    gridControl.MainView = responsibleForZoneGridView;
                    responsibleForZoneGridView.BestFitColumns();
                    break;
                case DirLinks.Zones:
                    catalog_ZonesTableAdapter.Fill(wMSDataSet.Catalog_Zones);
                    gridControl.DataSource = catalogZonesBindingSource;
                    gridControl.MainView = zonesGridView;
                    zonesGridView.BestFitColumns();
                    break;
                case DirLinks.Warehouse:
                    catalog_WarehousesTableAdapter.Fill(wMSDataSet.Catalog_Warehouses);
                    gridControl.DataSource = catalogWarehousesBindingSource;
                    gridControl.MainView = warehouseGridView;
                    warehouseGridView.BestFitColumns();
                    break;
                case DirLinks.Street:
                    catalog_StreetsTableAdapter.Fill(wMSDataSet.Catalog_Streets);
                    gridControl.DataSource = catalogStreetsBindingSource;
                    gridControl.MainView = streetGridView;
                    streetGridView.BestFitColumns();
                    break;
                case DirLinks.Raft:
                    catalog_RaftTableAdapter.Fill(wMSDataSet.Catalog_Raft);
                    gridControl.DataSource = catalogRaftBindingSource;
                    gridControl.MainView = raftGridView;
                    raftGridView.BestFitColumns();
                    break;
                case DirLinks.ShelfSpace:
                    catalog_ShelfSpacesTableAdapter.Fill(wMSDataSet.Catalog_ShelfSpaces);
                    gridControl.DataSource = catalogShelfSpacesBindingSource;
                    gridControl.MainView = shelfSpaceGridView;
                    shelfSpaceGridView.BestFitColumns();
                    break;
                case DirLinks.Shelf:
                    catalog_ShelfsTableAdapter.Fill(wMSDataSet.Catalog_Shelfs);
                    gridControl.DataSource = catalogShelfsBindingSource;
                    gridControl.MainView = shelfsGridView;
                    shelfsGridView.BestFitColumns();
                    break;
                case DirLinks.Rotation:
                    catalog_RotationsProductTableAdapter.Fill(wMSDataSet.Catalog_RotationsProduct);
                    gridControl.DataSource = catalogRotationsProductBindingSource;
                    gridControl.MainView = rotationGridView;
                    rotationGridView.BestFitColumns();
                    break;
                case DirLinks.Unit:
                    catalog_UnitsTableAdapter.Fill(wMSDataSet.Catalog_Units);
                    gridControl.DataSource = catalogUnitsBindingSource;
                    gridControl.MainView = unitsGridView;
                    unitsGridView.BestFitColumns();
                    break;
                case DirLinks.Products:
                    catalog_ProductsTableAdapter.Fill(wMSDataSet.Catalog_Products);
                    gridControl.DataSource = catalogProductsBindingSource;
                    gridControl.MainView = productsGridView;
                    //productsGridView.BestFitColumns();
                    break;
                case DirLinks.Rests:
                    catalog_TypeOfRestsTableAdapter.Fill(wMSDataSet.Catalog_TypeOfRests);
                    gridControl.DataSource = catalogTypeOfRestsBindingSource;
                    gridControl.MainView = typeOfRestsGridView;
                    typeOfRestsGridView.BestFitColumns();
                    break;
                case DirLinks.GroupProducts:
                    catalog_GroupTableAdapter.Fill(this.wMSDataSet.Catalog_Group);    
                    gridControl.DataSource = catalogGroupBindingSource;
                    gridControl.MainView = groupsGridView;
                    groupsGridView.BestFitColumns();
                    break;

                
            }
        }

        private void ShowTab(DirLinks dirLinks){
            var existsTab = false;
            switch (dirLinks)
            {
                case DirLinks.ResponsibleForZone:
                    var tabResZone = new MyXtraTabPage
                    {
                        TypeOfDir = DirLinks.ResponsibleForZone,
                        Text = resZoneBarItem.Caption,
                        ShowCloseButton = DefaultBoolean.True
                    };

                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabResZone);
                        mainTabControl.TabPages.Add(tabResZone);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Zones:
                    var tabZone = new MyXtraTabPage
                    {
                        TypeOfDir = DirLinks.Zones,
                        Text = zonesBarItem.Caption,
                        ShowCloseButton = DefaultBoolean.True
                    };

                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabZone);
                        mainTabControl.TabPages.Add(tabZone);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Warehouse:
                    var tabWarehouse = new MyXtraTabPage
                        {
                            TypeOfDir = DirLinks.Warehouse,
                            Text = warehousesBarItem.Caption,
                            ShowCloseButton = DefaultBoolean.True
                        };

                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabWarehouse);
                        mainTabControl.TabPages.Add(tabWarehouse);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Street:
                    var tabStreet = new MyXtraTabPage
                        {
                            TypeOfDir = DirLinks.Street,
                            Text = streetsBarItem.Caption,
                            ShowCloseButton = DefaultBoolean.True
                        };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabStreet);
                        mainTabControl.TabPages.Add(tabStreet);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Raft:
                    var tabRaft = new MyXtraTabPage
                        {
                            TypeOfDir = DirLinks.Raft,
                            Text = raftBarItem.Caption,
                            ShowCloseButton = DefaultBoolean.True
                        };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabRaft);
                        mainTabControl.TabPages.Add(tabRaft);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.ShelfSpace:
                    var tabShelfSpace = new MyXtraTabPage
                        {
                            TypeOfDir = DirLinks.ShelfSpace,
                            Text = shelfSpacesBarItem.Caption,
                            ShowCloseButton = DefaultBoolean.True
                        };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabShelfSpace);
                        mainTabControl.TabPages.Add(tabShelfSpace);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Shelf:
                    var tabShelf = new MyXtraTabPage
                        {
                            TypeOfDir = DirLinks.Shelf,
                            Text = shelfsBarItem.Caption,
                            ShowCloseButton = DefaultBoolean.True
                        };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabShelf);
                        mainTabControl.TabPages.Add(tabShelf);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Rotation:
                    var tabRotation = new MyXtraTabPage
                        {
                            TypeOfDir = DirLinks.Rotation,
                            Text = rotationBarItem.Caption,
                            ShowCloseButton = DefaultBoolean.True
                        };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabRotation);
                        mainTabControl.TabPages.Add(tabRotation);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Unit:
                    var tabUnit = new MyXtraTabPage
                        {
                            TypeOfDir = DirLinks.Unit,
                            Text = unitsBarItem.Caption,
                            ShowCloseButton = DefaultBoolean.True
                        };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabUnit);
                        mainTabControl.TabPages.Add(tabUnit);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Products:
                    var tabProduct = new MyXtraTabPage
                        {
                            TypeOfDir = DirLinks.Products,
                            Text = productsBarItem.Caption,
                            ShowCloseButton = DefaultBoolean.True
                        };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabProduct);
                        mainTabControl.TabPages.Add(tabProduct);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;

                case DirLinks.Rests:
                    var tabRests = new MyXtraTabPage
                    {
                        TypeOfDir = DirLinks.Rests,
                        Text = restsBarItem.Caption,
                        ShowCloseButton = DefaultBoolean.True
                    };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabRests);
                        mainTabControl.TabPages.Add(tabRests);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    break;
                case DirLinks.GroupProducts:
                    var tabGroupProducts = new MyXtraTabPage
                    {
                        TypeOfDir = DirLinks.GroupProducts,
                        Text = groupProductsBarItem.Caption,
                        ShowCloseButton = DefaultBoolean.True
                    };
                    if (mainTabControl.MyPages.Count > 0)
                    {
                        foreach (var page in mainTabControl.MyPages)
                        {
                            if (page.TypeOfDir == dirLinks)
                            {
                                existsTab = true;
                            }
                        }
                    }
                    if (existsTab)
                    {
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        mainTabControl.MyPages.Add(tabGroupProducts);
                        mainTabControl.TabPages.Add(tabGroupProducts);
                        mainTabControl.SelectedTabPageIndex = mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks);
                        mainTabControl.TabPages[mainTabControl.GetIdByDirLinks(mainTabControl, dirLinks)].Controls.Add(
                            gridControl);
                        gridControl.Visible = true;
                        gridControl.Dock = DockStyle.Fill;
                        
                    }
                    break;
                    
               
            }
        }

        


        

        

        

        

        

        

        

        

     

        

        
        

        

        

        

        


        

        
    
        
        

    }
}