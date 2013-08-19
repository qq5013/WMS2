using WMS.MainApplication.WMSDataSetTableAdapters;

namespace WMS.MainApplication
{
    partial class DirMainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.catalogProductsBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.MainApplication.WMSDataSet();
            this.productsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDimensionX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDimensionY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDimensionZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductMultiplicity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNameGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_TypeOfRotationsRepositoryItemComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.groupsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupZoneID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrriptionGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrriptionZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupWarehouseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.responsibleForZoneGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colResZoneID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResZoneName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResZoneNameZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResZoneDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResZoneID_Zone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.streetGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStreetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetZoneName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetZoneDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetZoneId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zonesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZoneID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZoneName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZoneDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.warehouseGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWarehouseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeOfDistribution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTypeOfDistribution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeOfRestsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRetstsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeOfUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistanceBetweenUnits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shelfsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShelfID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfHeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfDeph = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfID_TypeOfRotation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rotationGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRotID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRotName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRotMinQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRotMaxQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shelfSpaceGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShelSpaceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelSpaceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelSpaceDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.raftGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRaftID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaftName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaftDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.catalogGroupBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogResponsibleForTheZoneBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogStreetsBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogZonesBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogWarehousesBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogMultiplicityProductsBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogTypeOfRestsBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogUnitsBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogRotationsProductBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogShelfsBindingSource = new System.Windows.Forms.BindingSource();
            this.gridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.addStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalog_WarehousesTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_WarehousesTableAdapter();
            this.catalog_StreetsTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_StreetsTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.directoriesBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.zonesBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.resZoneBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.warehousesBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.streetsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.raftBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.shelfsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.shelfSpacesBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.rotationBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.unitsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.productsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.groupProductsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.restsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.parametersBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.paramsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.multiplicityProductBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.editButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainTabControl = new WMS.MainApplication.MyXtraTabControl();
            this.catalogRaftBindingSource = new System.Windows.Forms.BindingSource();
            this.catalog_RaftTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_RaftTableAdapter();
            this.catalogShelfSpacesBindingSource = new System.Windows.Forms.BindingSource();
            this.catalog_ShelfSpacesTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_ShelfSpacesTableAdapter();
            this.catalog_ShelfsTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_ShelfsTableAdapter();
            this.catalog_RotationsProductTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_RotationsProductTableAdapter();
            this.catalog_UnitsTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_UnitsTableAdapter();
            this.catalog_ProductsTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_ProductsTableAdapter();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar();
            this.catalog_TypeOfRestsTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_TypeOfRestsTableAdapter();
            this._Catalog_MultiplicityProductsTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters._Catalog_MultiplicityProductsTableAdapter();
            this.catalog_ZonesTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_ZonesTableAdapter();
            this.catalog_ResponsibleForTheZoneTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_ResponsibleForTheZoneTableAdapter();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsMainGroup2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsMainGroup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.catalog_GroupTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_GroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_TypeOfRotationsRepositoryItemComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibleForZoneGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfRestsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfSpaceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raftGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogResponsibleForTheZoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogStreetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogZonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogWarehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogMultiplicityProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTypeOfRestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRotationsProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfsBindingSource)).BeginInit();
            this.gridContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRaftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfSpacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardView2
            // 
            this.cardView2.FocusedCardTopFieldIndex = 0;
            this.cardView2.GridControl = this.gridControl;
            this.cardView2.Name = "cardView2";
            this.cardView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridControl
            // 
            this.gridControl.DataMember = null;
            this.gridControl.DataSource = this.catalogProductsBindingSource;
            this.gridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl.Location = new System.Drawing.Point(446, 140);
            this.gridControl.MainView = this.productsGridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.id_TypeOfRotationsRepositoryItemComboBox});
            this.gridControl.Size = new System.Drawing.Size(482, 289);
            this.gridControl.TabIndex = 0;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productsGridView,
            this.groupsGridView,
            this.responsibleForZoneGridView,
            this.streetGridView,
            this.zonesGridView,
            this.warehouseGridView,
            this.typeOfRestsGridView,
            this.unitsGridView,
            this.shelfsGridView,
            this.rotationGridView,
            this.shelfSpaceGridView,
            this.raftGridView,
            this.cardView1,
            this.cardView2});
            this.gridControl.Visible = false;
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControlKeyDown);
            // 
            // catalogProductsBindingSource
            // 
            this.catalogProductsBindingSource.DataMember = "Catalog_Products";
            this.catalogProductsBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsGridView
            // 
            this.productsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.productsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colProductDescription,
            this.colProductBarCode,
            this.colProductDimensionX,
            this.colProductDimensionY,
            this.colProductDimensionZ,
            this.colProductWeight,
            this.colProductMultiplicity,
            this.colProductNameGroup});
            this.productsGridView.GridControl = this.gridControl;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.productsGridView.OptionsBehavior.Editable = false;
            this.productsGridView.OptionsBehavior.ReadOnly = true;
            this.productsGridView.OptionsView.ColumnAutoWidth = false;
            this.productsGridView.OptionsView.ShowAutoFilterRow = true;
            this.productsGridView.OptionsView.ShowFooter = true;
            this.productsGridView.OptionsView.ShowGroupPanel = false;
            this.productsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductDescription, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.productsGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.ProductsGridViewPopupMenuShowing);
            // 
            // colProductID
            // 
            this.colProductID.Caption = "Код";
            this.colProductID.FieldName = "ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            this.colProductID.Width = 42;
            // 
            // colProductDescription
            // 
            this.colProductDescription.Caption = "Название товара";
            this.colProductDescription.FieldName = "Description";
            this.colProductDescription.Name = "colProductDescription";
            this.colProductDescription.Visible = true;
            this.colProductDescription.VisibleIndex = 1;
            this.colProductDescription.Width = 363;
            // 
            // colProductBarCode
            // 
            this.colProductBarCode.Caption = "Бар код";
            this.colProductBarCode.FieldName = "BarCode";
            this.colProductBarCode.Name = "colProductBarCode";
            this.colProductBarCode.Visible = true;
            this.colProductBarCode.VisibleIndex = 2;
            this.colProductBarCode.Width = 86;
            // 
            // colProductDimensionX
            // 
            this.colProductDimensionX.Caption = "Ширина X";
            this.colProductDimensionX.FieldName = "DimensionX";
            this.colProductDimensionX.Name = "colProductDimensionX";
            this.colProductDimensionX.Visible = true;
            this.colProductDimensionX.VisibleIndex = 3;
            this.colProductDimensionX.Width = 64;
            // 
            // colProductDimensionY
            // 
            this.colProductDimensionY.Caption = "Высота Y";
            this.colProductDimensionY.FieldName = "DimensionY";
            this.colProductDimensionY.Name = "colProductDimensionY";
            this.colProductDimensionY.Visible = true;
            this.colProductDimensionY.VisibleIndex = 4;
            this.colProductDimensionY.Width = 58;
            // 
            // colProductDimensionZ
            // 
            this.colProductDimensionZ.Caption = "Глубина Z";
            this.colProductDimensionZ.FieldName = "DimensionZ";
            this.colProductDimensionZ.Name = "colProductDimensionZ";
            this.colProductDimensionZ.Visible = true;
            this.colProductDimensionZ.VisibleIndex = 5;
            this.colProductDimensionZ.Width = 62;
            // 
            // colProductWeight
            // 
            this.colProductWeight.Caption = "Вес";
            this.colProductWeight.FieldName = "Weight";
            this.colProductWeight.Name = "colProductWeight";
            this.colProductWeight.Visible = true;
            this.colProductWeight.VisibleIndex = 6;
            this.colProductWeight.Width = 52;
            // 
            // colProductMultiplicity
            // 
            this.colProductMultiplicity.Caption = "Кратность этикеток";
            this.colProductMultiplicity.FieldName = "Multiplicity";
            this.colProductMultiplicity.Name = "colProductMultiplicity";
            this.colProductMultiplicity.Visible = true;
            this.colProductMultiplicity.VisibleIndex = 7;
            // 
            // colProductNameGroup
            // 
            this.colProductNameGroup.Caption = "Группа";
            this.colProductNameGroup.FieldName = "NameGroup";
            this.colProductNameGroup.Name = "colProductNameGroup";
            this.colProductNameGroup.Visible = true;
            this.colProductNameGroup.VisibleIndex = 8;
            // 
            // id_TypeOfRotationsRepositoryItemComboBox
            // 
            this.id_TypeOfRotationsRepositoryItemComboBox.AutoHeight = false;
            this.id_TypeOfRotationsRepositoryItemComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.id_TypeOfRotationsRepositoryItemComboBox.Name = "id_TypeOfRotationsRepositoryItemComboBox";
            // 
            // groupsGridView
            // 
            this.groupsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupID,
            this.colGroupZoneID,
            this.colNameGroup,
            this.colDescrriptionGroup,
            this.colNameZone,
            this.colDescrriptionZone,
            this.colGroupWarehouseID});
            this.groupsGridView.GridControl = this.gridControl;
            this.groupsGridView.Name = "groupsGridView";
            this.groupsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.groupsGridView.OptionsBehavior.Editable = false;
            this.groupsGridView.OptionsBehavior.ReadOnly = true;
            this.groupsGridView.OptionsView.ColumnAutoWidth = false;
            this.groupsGridView.OptionsView.ShowAutoFilterRow = true;
            this.groupsGridView.OptionsView.ShowFooter = true;
            this.groupsGridView.OptionsView.ShowGroupPanel = false;
            this.groupsGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.GroupsGridViewPopupMenuShowing);
            // 
            // colGroupID
            // 
            this.colGroupID.Caption = "Код группы";
            this.colGroupID.FieldName = "ID";
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.OptionsColumn.ReadOnly = true;
            this.colGroupID.Visible = true;
            this.colGroupID.VisibleIndex = 0;
            // 
            // colGroupZoneID
            // 
            this.colGroupZoneID.Caption = "Код зоны";
            this.colGroupZoneID.FieldName = "Zone_ID";
            this.colGroupZoneID.Name = "colGroupZoneID";
            // 
            // colNameGroup
            // 
            this.colNameGroup.Caption = "Имя группы";
            this.colNameGroup.FieldName = "NameGroup";
            this.colNameGroup.Name = "colNameGroup";
            this.colNameGroup.Visible = true;
            this.colNameGroup.VisibleIndex = 1;
            // 
            // colDescrriptionGroup
            // 
            this.colDescrriptionGroup.Caption = "Описание группы";
            this.colDescrriptionGroup.FieldName = "DescrriptionGroup";
            this.colDescrriptionGroup.Name = "colDescrriptionGroup";
            this.colDescrriptionGroup.Visible = true;
            this.colDescrriptionGroup.VisibleIndex = 2;
            this.colDescrriptionGroup.Width = 108;
            // 
            // colNameZone
            // 
            this.colNameZone.Caption = "Имя зоны";
            this.colNameZone.FieldName = "NameZone";
            this.colNameZone.Name = "colNameZone";
            this.colNameZone.Visible = true;
            this.colNameZone.VisibleIndex = 3;
            // 
            // colDescrriptionZone
            // 
            this.colDescrriptionZone.Caption = "Описание зоны";
            this.colDescrriptionZone.FieldName = "DescrriptionZone";
            this.colDescrriptionZone.Name = "colDescrriptionZone";
            this.colDescrriptionZone.Visible = true;
            this.colDescrriptionZone.VisibleIndex = 4;
            this.colDescrriptionZone.Width = 96;
            // 
            // colGroupWarehouseID
            // 
            this.colGroupWarehouseID.Caption = "Код склада";
            this.colGroupWarehouseID.FieldName = "Warehouse_ID";
            this.colGroupWarehouseID.Name = "colGroupWarehouseID";
            // 
            // responsibleForZoneGridView
            // 
            this.responsibleForZoneGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.responsibleForZoneGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colResZoneID,
            this.colResZoneName,
            this.colResZoneNameZone,
            this.colResZoneDescription,
            this.colResZoneID_Zone});
            this.responsibleForZoneGridView.GridControl = this.gridControl;
            this.responsibleForZoneGridView.Name = "responsibleForZoneGridView";
            this.responsibleForZoneGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.responsibleForZoneGridView.OptionsBehavior.Editable = false;
            this.responsibleForZoneGridView.OptionsBehavior.ReadOnly = true;
            this.responsibleForZoneGridView.OptionsView.ColumnAutoWidth = false;
            this.responsibleForZoneGridView.OptionsView.ShowAutoFilterRow = true;
            this.responsibleForZoneGridView.OptionsView.ShowFooter = true;
            this.responsibleForZoneGridView.OptionsView.ShowGroupPanel = false;
            this.responsibleForZoneGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.ResponsibleForZoneGridViewPopupMenuShowing);
            // 
            // colResZoneID
            // 
            this.colResZoneID.Caption = "Код";
            this.colResZoneID.FieldName = "ID";
            this.colResZoneID.Name = "colResZoneID";
            this.colResZoneID.OptionsColumn.ReadOnly = true;
            this.colResZoneID.Visible = true;
            this.colResZoneID.VisibleIndex = 0;
            this.colResZoneID.Width = 50;
            // 
            // colResZoneName
            // 
            this.colResZoneName.Caption = "Имя ответственного за зону";
            this.colResZoneName.FieldName = "Name";
            this.colResZoneName.Name = "colResZoneName";
            this.colResZoneName.Visible = true;
            this.colResZoneName.VisibleIndex = 1;
            // 
            // colResZoneNameZone
            // 
            this.colResZoneNameZone.Caption = "Назание зоны";
            this.colResZoneNameZone.FieldName = "NameZone";
            this.colResZoneNameZone.Name = "colResZoneNameZone";
            this.colResZoneNameZone.Visible = true;
            this.colResZoneNameZone.VisibleIndex = 2;
            // 
            // colResZoneDescription
            // 
            this.colResZoneDescription.Caption = "Описание зоны";
            this.colResZoneDescription.FieldName = "Description";
            this.colResZoneDescription.Name = "colResZoneDescription";
            this.colResZoneDescription.Visible = true;
            this.colResZoneDescription.VisibleIndex = 3;
            // 
            // colResZoneID_Zone
            // 
            this.colResZoneID_Zone.FieldName = "ID_Zone";
            this.colResZoneID_Zone.Name = "colResZoneID_Zone";
            // 
            // streetGridView
            // 
            this.streetGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.streetGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStreetID,
            this.colStreetName,
            this.colStreetDescription,
            this.colStreetZoneName,
            this.colStreetZoneDescription,
            this.colStreetZoneId});
            this.streetGridView.GridControl = this.gridControl;
            this.streetGridView.Name = "streetGridView";
            this.streetGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.streetGridView.OptionsBehavior.Editable = false;
            this.streetGridView.OptionsBehavior.ReadOnly = true;
            this.streetGridView.OptionsView.ColumnAutoWidth = false;
            this.streetGridView.OptionsView.ShowAutoFilterRow = true;
            this.streetGridView.OptionsView.ShowFooter = true;
            this.streetGridView.OptionsView.ShowGroupPanel = false;
            this.streetGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStreetID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.streetGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.StreetGridViewPopupMenuShowing);
            // 
            // colStreetID
            // 
            this.colStreetID.Caption = "Код";
            this.colStreetID.FieldName = "ID";
            this.colStreetID.Name = "colStreetID";
            this.colStreetID.OptionsColumn.ReadOnly = true;
            this.colStreetID.Visible = true;
            this.colStreetID.VisibleIndex = 0;
            this.colStreetID.Width = 44;
            // 
            // colStreetName
            // 
            this.colStreetName.Caption = "Название улицы";
            this.colStreetName.FieldName = "Name";
            this.colStreetName.Name = "colStreetName";
            this.colStreetName.Visible = true;
            this.colStreetName.VisibleIndex = 1;
            this.colStreetName.Width = 99;
            // 
            // colStreetDescription
            // 
            this.colStreetDescription.Caption = "Описание улицы";
            this.colStreetDescription.FieldName = "Description";
            this.colStreetDescription.Name = "colStreetDescription";
            this.colStreetDescription.Visible = true;
            this.colStreetDescription.VisibleIndex = 2;
            this.colStreetDescription.Width = 108;
            // 
            // colStreetZoneName
            // 
            this.colStreetZoneName.Caption = "Имя зоны";
            this.colStreetZoneName.FieldName = "ZonaName";
            this.colStreetZoneName.Name = "colStreetZoneName";
            this.colStreetZoneName.Visible = true;
            this.colStreetZoneName.VisibleIndex = 3;
            this.colStreetZoneName.Width = 100;
            // 
            // colStreetZoneDescription
            // 
            this.colStreetZoneDescription.Caption = "Описание зоны";
            this.colStreetZoneDescription.FieldName = "ZonaDescription";
            this.colStreetZoneDescription.Name = "colStreetZoneDescription";
            this.colStreetZoneDescription.Visible = true;
            this.colStreetZoneDescription.VisibleIndex = 4;
            this.colStreetZoneDescription.Width = 135;
            // 
            // colStreetZoneId
            // 
            this.colStreetZoneId.Caption = "Код зоны";
            this.colStreetZoneId.FieldName = "ID_Zona";
            this.colStreetZoneId.Name = "colStreetZoneId";
            // 
            // zonesGridView
            // 
            this.zonesGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.zonesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZoneID,
            this.colZoneName,
            this.colZoneDescription});
            this.zonesGridView.GridControl = this.gridControl;
            this.zonesGridView.Name = "zonesGridView";
            this.zonesGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.zonesGridView.OptionsBehavior.Editable = false;
            this.zonesGridView.OptionsBehavior.ReadOnly = true;
            this.zonesGridView.OptionsView.ColumnAutoWidth = false;
            this.zonesGridView.OptionsView.ShowAutoFilterRow = true;
            this.zonesGridView.OptionsView.ShowFooter = true;
            this.zonesGridView.OptionsView.ShowGroupPanel = false;
            this.zonesGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.ZonesGridViewPopupMenuShowing);
            // 
            // colZoneID
            // 
            this.colZoneID.Caption = "Код";
            this.colZoneID.FieldName = "ID";
            this.colZoneID.Name = "colZoneID";
            this.colZoneID.OptionsColumn.ReadOnly = true;
            this.colZoneID.Visible = true;
            this.colZoneID.VisibleIndex = 0;
            this.colZoneID.Width = 38;
            // 
            // colZoneName
            // 
            this.colZoneName.Caption = "Название зоны";
            this.colZoneName.FieldName = "Name";
            this.colZoneName.Name = "colZoneName";
            this.colZoneName.Visible = true;
            this.colZoneName.VisibleIndex = 1;
            this.colZoneName.Width = 94;
            // 
            // colZoneDescription
            // 
            this.colZoneDescription.Caption = "Описание зоны";
            this.colZoneDescription.FieldName = "Description";
            this.colZoneDescription.Name = "colZoneDescription";
            this.colZoneDescription.Visible = true;
            this.colZoneDescription.VisibleIndex = 2;
            this.colZoneDescription.Width = 94;
            // 
            // warehouseGridView
            // 
            this.warehouseGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.warehouseGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWarehouseID,
            this.colWarehouseName,
            this.colWarehouseDescription,
            this.colTypeOfDistribution,
            this.colIdTypeOfDistribution});
            this.warehouseGridView.GridControl = this.gridControl;
            this.warehouseGridView.Name = "warehouseGridView";
            this.warehouseGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.warehouseGridView.OptionsBehavior.Editable = false;
            this.warehouseGridView.OptionsBehavior.ReadOnly = true;
            this.warehouseGridView.OptionsView.ColumnAutoWidth = false;
            this.warehouseGridView.OptionsView.ShowAutoFilterRow = true;
            this.warehouseGridView.OptionsView.ShowFooter = true;
            this.warehouseGridView.OptionsView.ShowGroupPanel = false;
            this.warehouseGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWarehouseID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.warehouseGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.WarehouseGridViewPopupMenuShowing);
            // 
            // colWarehouseID
            // 
            this.colWarehouseID.Caption = "Код";
            this.colWarehouseID.FieldName = "ID";
            this.colWarehouseID.Name = "colWarehouseID";
            this.colWarehouseID.OptionsColumn.ReadOnly = true;
            this.colWarehouseID.Visible = true;
            this.colWarehouseID.VisibleIndex = 0;
            this.colWarehouseID.Width = 52;
            // 
            // colWarehouseName
            // 
            this.colWarehouseName.Caption = "Название склада";
            this.colWarehouseName.FieldName = "Name";
            this.colWarehouseName.Name = "colWarehouseName";
            this.colWarehouseName.Visible = true;
            this.colWarehouseName.VisibleIndex = 1;
            this.colWarehouseName.Width = 99;
            // 
            // colWarehouseDescription
            // 
            this.colWarehouseDescription.Caption = "Описание склада";
            this.colWarehouseDescription.FieldName = "Description";
            this.colWarehouseDescription.Name = "colWarehouseDescription";
            this.colWarehouseDescription.Visible = true;
            this.colWarehouseDescription.VisibleIndex = 2;
            this.colWarehouseDescription.Width = 107;
            // 
            // colTypeOfDistribution
            // 
            this.colTypeOfDistribution.Caption = "Тип дистрибуции склада";
            this.colTypeOfDistribution.FieldName = "NameTypeOfDistribution";
            this.colTypeOfDistribution.Name = "colTypeOfDistribution";
            this.colTypeOfDistribution.Visible = true;
            this.colTypeOfDistribution.VisibleIndex = 3;
            this.colTypeOfDistribution.Width = 349;
            // 
            // colIdTypeOfDistribution
            // 
            this.colIdTypeOfDistribution.Caption = "gridColumn1";
            this.colIdTypeOfDistribution.FieldName = "IdTypeOfDistribution";
            this.colIdTypeOfDistribution.Name = "colIdTypeOfDistribution";
            // 
            // typeOfRestsGridView
            // 
            this.typeOfRestsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.typeOfRestsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRetstsID,
            this.colRestsName});
            this.typeOfRestsGridView.GridControl = this.gridControl;
            this.typeOfRestsGridView.Name = "typeOfRestsGridView";
            this.typeOfRestsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.typeOfRestsGridView.OptionsBehavior.Editable = false;
            this.typeOfRestsGridView.OptionsBehavior.ReadOnly = true;
            this.typeOfRestsGridView.OptionsView.ColumnAutoWidth = false;
            this.typeOfRestsGridView.OptionsView.ShowAutoFilterRow = true;
            this.typeOfRestsGridView.OptionsView.ShowFooter = true;
            this.typeOfRestsGridView.OptionsView.ShowGroupPanel = false;
            this.typeOfRestsGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.TypeOfRestsGridViewPopupMenuShowing);
            // 
            // colRetstsID
            // 
            this.colRetstsID.Caption = "Код";
            this.colRetstsID.FieldName = "ID";
            this.colRetstsID.Name = "colRetstsID";
            this.colRetstsID.OptionsColumn.ReadOnly = true;
            this.colRetstsID.Visible = true;
            this.colRetstsID.VisibleIndex = 0;
            this.colRetstsID.Width = 37;
            // 
            // colRestsName
            // 
            this.colRestsName.Caption = "Описание";
            this.colRestsName.FieldName = "Name";
            this.colRestsName.Name = "colRestsName";
            this.colRestsName.Visible = true;
            this.colRestsName.VisibleIndex = 1;
            this.colRestsName.Width = 387;
            // 
            // unitsGridView
            // 
            this.unitsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.unitsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnitID,
            this.colUnitName,
            this.colSizeOfUnit,
            this.colDistanceBetweenUnits});
            this.unitsGridView.GridControl = this.gridControl;
            this.unitsGridView.Name = "unitsGridView";
            this.unitsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.unitsGridView.OptionsBehavior.Editable = false;
            this.unitsGridView.OptionsBehavior.ReadOnly = true;
            this.unitsGridView.OptionsView.ColumnAutoWidth = false;
            this.unitsGridView.OptionsView.ShowAutoFilterRow = true;
            this.unitsGridView.OptionsView.ShowFooter = true;
            this.unitsGridView.OptionsView.ShowGroupPanel = false;
            this.unitsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUnitID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.unitsGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.UnitsGridViewPopupMenuShowing);
            // 
            // colUnitID
            // 
            this.colUnitID.Caption = "Код";
            this.colUnitID.FieldName = "ID";
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.OptionsColumn.ReadOnly = true;
            this.colUnitID.Visible = true;
            this.colUnitID.VisibleIndex = 0;
            this.colUnitID.Width = 46;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "Название";
            this.colUnitName.FieldName = "Name";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 1;
            this.colUnitName.Width = 79;
            // 
            // colSizeOfUnit
            // 
            this.colSizeOfUnit.Caption = "Ширина деления (см)";
            this.colSizeOfUnit.FieldName = "SizeOfUnit";
            this.colSizeOfUnit.Name = "colSizeOfUnit";
            this.colSizeOfUnit.Visible = true;
            this.colSizeOfUnit.VisibleIndex = 2;
            this.colSizeOfUnit.Width = 116;
            // 
            // colDistanceBetweenUnits
            // 
            this.colDistanceBetweenUnits.Caption = "Растояние между делениями (см)";
            this.colDistanceBetweenUnits.FieldName = "DistanceBetweenUnits";
            this.colDistanceBetweenUnits.Name = "colDistanceBetweenUnits";
            this.colDistanceBetweenUnits.Visible = true;
            this.colDistanceBetweenUnits.VisibleIndex = 3;
            this.colDistanceBetweenUnits.Width = 179;
            // 
            // shelfsGridView
            // 
            this.shelfsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.shelfsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShelfID,
            this.colShelfName,
            this.colShelfDescription,
            this.colShelfHeight,
            this.colShelfDeph,
            this.colShelfID_TypeOfRotation});
            this.shelfsGridView.GridControl = this.gridControl;
            this.shelfsGridView.Name = "shelfsGridView";
            this.shelfsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.shelfsGridView.OptionsBehavior.Editable = false;
            this.shelfsGridView.OptionsBehavior.ReadOnly = true;
            this.shelfsGridView.OptionsView.ColumnAutoWidth = false;
            this.shelfsGridView.OptionsView.ShowAutoFilterRow = true;
            this.shelfsGridView.OptionsView.ShowFooter = true;
            this.shelfsGridView.OptionsView.ShowGroupPanel = false;
            this.shelfsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colShelfID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.shelfsGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.ShelfsGridViewPopupMenuShowing);
            // 
            // colShelfID
            // 
            this.colShelfID.Caption = "Код";
            this.colShelfID.FieldName = "ID";
            this.colShelfID.Name = "colShelfID";
            this.colShelfID.OptionsColumn.ReadOnly = true;
            this.colShelfID.Visible = true;
            this.colShelfID.VisibleIndex = 0;
            this.colShelfID.Width = 48;
            // 
            // colShelfName
            // 
            this.colShelfName.Caption = "Название полки";
            this.colShelfName.FieldName = "Name";
            this.colShelfName.Name = "colShelfName";
            this.colShelfName.Visible = true;
            this.colShelfName.VisibleIndex = 1;
            this.colShelfName.Width = 97;
            // 
            // colShelfDescription
            // 
            this.colShelfDescription.Caption = "Описание полки";
            this.colShelfDescription.FieldName = "Description";
            this.colShelfDescription.Name = "colShelfDescription";
            this.colShelfDescription.Visible = true;
            this.colShelfDescription.VisibleIndex = 2;
            this.colShelfDescription.Width = 96;
            // 
            // colShelfHeight
            // 
            this.colShelfHeight.Caption = "Высота полки (см)";
            this.colShelfHeight.FieldName = "Height";
            this.colShelfHeight.Name = "colShelfHeight";
            this.colShelfHeight.Visible = true;
            this.colShelfHeight.VisibleIndex = 3;
            this.colShelfHeight.Width = 101;
            // 
            // colShelfDeph
            // 
            this.colShelfDeph.Caption = "Глубина полки (см)";
            this.colShelfDeph.FieldName = "Deph";
            this.colShelfDeph.Name = "colShelfDeph";
            this.colShelfDeph.Visible = true;
            this.colShelfDeph.VisibleIndex = 4;
            this.colShelfDeph.Width = 107;
            // 
            // colShelfID_TypeOfRotation
            // 
            this.colShelfID_TypeOfRotation.Caption = "Тип ротации";
            this.colShelfID_TypeOfRotation.FieldName = "TypeOfRotation";
            this.colShelfID_TypeOfRotation.Name = "colShelfID_TypeOfRotation";
            this.colShelfID_TypeOfRotation.Visible = true;
            this.colShelfID_TypeOfRotation.VisibleIndex = 5;
            this.colShelfID_TypeOfRotation.Width = 70;
            // 
            // rotationGridView
            // 
            this.rotationGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.rotationGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRotID,
            this.colRotName,
            this.colRotMinQty,
            this.colRotMaxQty});
            this.rotationGridView.GridControl = this.gridControl;
            this.rotationGridView.Name = "rotationGridView";
            this.rotationGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.rotationGridView.OptionsBehavior.Editable = false;
            this.rotationGridView.OptionsBehavior.ReadOnly = true;
            this.rotationGridView.OptionsView.ColumnAutoWidth = false;
            this.rotationGridView.OptionsView.ShowAutoFilterRow = true;
            this.rotationGridView.OptionsView.ShowFooter = true;
            this.rotationGridView.OptionsView.ShowGroupPanel = false;
            this.rotationGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRotID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.rotationGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.RotationGridViewPopupMenuShowing);
            // 
            // colRotID
            // 
            this.colRotID.Caption = "Код";
            this.colRotID.FieldName = "ID";
            this.colRotID.Name = "colRotID";
            this.colRotID.OptionsColumn.ReadOnly = true;
            this.colRotID.Visible = true;
            this.colRotID.VisibleIndex = 0;
            this.colRotID.Width = 45;
            // 
            // colRotName
            // 
            this.colRotName.Caption = "Название";
            this.colRotName.FieldName = "Name";
            this.colRotName.Name = "colRotName";
            this.colRotName.Visible = true;
            this.colRotName.VisibleIndex = 1;
            this.colRotName.Width = 60;
            // 
            // colRotMinQty
            // 
            this.colRotMinQty.Caption = "Минимальное кол-во";
            this.colRotMinQty.FieldName = "MinQty";
            this.colRotMinQty.Name = "colRotMinQty";
            this.colRotMinQty.Visible = true;
            this.colRotMinQty.VisibleIndex = 2;
            this.colRotMinQty.Width = 114;
            // 
            // colRotMaxQty
            // 
            this.colRotMaxQty.Caption = "Максимальное кол-во";
            this.colRotMaxQty.FieldName = "MaxQty";
            this.colRotMaxQty.Name = "colRotMaxQty";
            this.colRotMaxQty.Visible = true;
            this.colRotMaxQty.VisibleIndex = 3;
            this.colRotMaxQty.Width = 120;
            // 
            // shelfSpaceGridView
            // 
            this.shelfSpaceGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.shelfSpaceGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShelSpaceID,
            this.colShelSpaceName,
            this.colShelSpaceDescription});
            this.shelfSpaceGridView.GridControl = this.gridControl;
            this.shelfSpaceGridView.Name = "shelfSpaceGridView";
            this.shelfSpaceGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.shelfSpaceGridView.OptionsBehavior.Editable = false;
            this.shelfSpaceGridView.OptionsBehavior.ReadOnly = true;
            this.shelfSpaceGridView.OptionsView.ColumnAutoWidth = false;
            this.shelfSpaceGridView.OptionsView.ShowAutoFilterRow = true;
            this.shelfSpaceGridView.OptionsView.ShowFooter = true;
            this.shelfSpaceGridView.OptionsView.ShowGroupPanel = false;
            this.shelfSpaceGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colShelSpaceID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.shelfSpaceGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.ShelfSpaceGridViewPopupMenuShowing);
            // 
            // colShelSpaceID
            // 
            this.colShelSpaceID.Caption = "Код";
            this.colShelSpaceID.FieldName = "ID";
            this.colShelSpaceID.Name = "colShelSpaceID";
            this.colShelSpaceID.OptionsColumn.ReadOnly = true;
            this.colShelSpaceID.Visible = true;
            this.colShelSpaceID.VisibleIndex = 0;
            this.colShelSpaceID.Width = 44;
            // 
            // colShelSpaceName
            // 
            this.colShelSpaceName.Caption = "Название места на полке";
            this.colShelSpaceName.FieldName = "Name";
            this.colShelSpaceName.Name = "colShelSpaceName";
            this.colShelSpaceName.Visible = true;
            this.colShelSpaceName.VisibleIndex = 1;
            this.colShelSpaceName.Width = 147;
            // 
            // colShelSpaceDescription
            // 
            this.colShelSpaceDescription.Caption = "Описание места на полке";
            this.colShelSpaceDescription.FieldName = "Description";
            this.colShelSpaceDescription.Name = "colShelSpaceDescription";
            this.colShelSpaceDescription.Visible = true;
            this.colShelSpaceDescription.VisibleIndex = 2;
            this.colShelSpaceDescription.Width = 139;
            // 
            // raftGridView
            // 
            this.raftGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.raftGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRaftID,
            this.colRaftName,
            this.colRaftDescription});
            this.raftGridView.GridControl = this.gridControl;
            this.raftGridView.Name = "raftGridView";
            this.raftGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.raftGridView.OptionsBehavior.Editable = false;
            this.raftGridView.OptionsBehavior.ReadOnly = true;
            this.raftGridView.OptionsView.ColumnAutoWidth = false;
            this.raftGridView.OptionsView.ShowAutoFilterRow = true;
            this.raftGridView.OptionsView.ShowFooter = true;
            this.raftGridView.OptionsView.ShowGroupPanel = false;
            this.raftGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRaftID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.raftGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.RaftGridViewPopupMenuShowing);
            // 
            // colRaftID
            // 
            this.colRaftID.Caption = "Код";
            this.colRaftID.FieldName = "ID";
            this.colRaftID.Name = "colRaftID";
            this.colRaftID.OptionsColumn.ReadOnly = true;
            this.colRaftID.Visible = true;
            this.colRaftID.VisibleIndex = 0;
            this.colRaftID.Width = 44;
            // 
            // colRaftName
            // 
            this.colRaftName.Caption = "Название стеллажа";
            this.colRaftName.FieldName = "Name";
            this.colRaftName.Name = "colRaftName";
            this.colRaftName.Visible = true;
            this.colRaftName.VisibleIndex = 1;
            this.colRaftName.Width = 108;
            // 
            // colRaftDescription
            // 
            this.colRaftDescription.Caption = "Описание стеллажа";
            this.colRaftDescription.FieldName = "Description";
            this.colRaftDescription.Name = "colRaftDescription";
            this.colRaftDescription.Visible = true;
            this.colRaftDescription.VisibleIndex = 2;
            this.colRaftDescription.Width = 112;
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsBehavior.ReadOnly = true;
            // 
            // catalogGroupBindingSource
            // 
            this.catalogGroupBindingSource.DataMember = "Catalog_Group";
            this.catalogGroupBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogResponsibleForTheZoneBindingSource
            // 
            this.catalogResponsibleForTheZoneBindingSource.DataMember = "Catalog_ResponsibleForTheZone";
            this.catalogResponsibleForTheZoneBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogStreetsBindingSource
            // 
            this.catalogStreetsBindingSource.DataMember = "Catalog_Streets";
            this.catalogStreetsBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogZonesBindingSource
            // 
            this.catalogZonesBindingSource.DataMember = "Catalog_Zones";
            this.catalogZonesBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogWarehousesBindingSource
            // 
            this.catalogWarehousesBindingSource.DataMember = "Catalog_Warehouses";
            this.catalogWarehousesBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogMultiplicityProductsBindingSource
            // 
            this.catalogMultiplicityProductsBindingSource.DataMember = " Catalog_MultiplicityProducts";
            this.catalogMultiplicityProductsBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogTypeOfRestsBindingSource
            // 
            this.catalogTypeOfRestsBindingSource.DataMember = "Catalog_TypeOfRests";
            this.catalogTypeOfRestsBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogUnitsBindingSource
            // 
            this.catalogUnitsBindingSource.DataMember = "Catalog_Units";
            this.catalogUnitsBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogRotationsProductBindingSource
            // 
            this.catalogRotationsProductBindingSource.DataMember = "Catalog_RotationsProduct";
            this.catalogRotationsProductBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogShelfsBindingSource
            // 
            this.catalogShelfsBindingSource.DataMember = "Catalog_Shelfs";
            this.catalogShelfsBindingSource.DataSource = this.wMSDataSet;
            // 
            // gridContextMenuStrip
            // 
            this.gridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripMenuItem,
            this.editStripMenuItem,
            this.deleteStripMenuItem});
            this.gridContextMenuStrip.Name = "gridContextMenuStrip";
            this.gridContextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // addStripMenuItem
            // 
            this.addStripMenuItem.Name = "addStripMenuItem";
            this.addStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addStripMenuItem.Text = "Добавить";
            this.addStripMenuItem.Click += new System.EventHandler(this.AddStripMenuItemClick);
            // 
            // editStripMenuItem
            // 
            this.editStripMenuItem.Name = "editStripMenuItem";
            this.editStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editStripMenuItem.Text = "Изменить";
            this.editStripMenuItem.Click += new System.EventHandler(this.EditStripMenuItemClick);
            // 
            // deleteStripMenuItem
            // 
            this.deleteStripMenuItem.Name = "deleteStripMenuItem";
            this.deleteStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteStripMenuItem.Text = "Удалить";
            this.deleteStripMenuItem.Click += new System.EventHandler(this.DeleteStripMenuItemClick);
            // 
            // catalog_WarehousesTableAdapter
            // 
            this.catalog_WarehousesTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_StreetsTableAdapter
            // 
            this.catalog_StreetsTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1028, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 709);
            this.barDockControlBottom.Size = new System.Drawing.Size(1028, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 709);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1028, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 709);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.mainTabControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1028, 709);
            this.splitContainerControl1.SplitterPosition = 205;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.directoriesBarGroup;
            this.navBarControl1.AllowSelectedLink = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.directoriesBarGroup,
            this.parametersBarGroup});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.warehousesBarItem,
            this.streetsBarItem,
            this.raftBarItem,
            this.shelfSpacesBarItem,
            this.shelfsBarItem,
            this.rotationBarItem,
            this.unitsBarItem,
            this.paramsBarItem,
            this.productsBarItem,
            this.restsBarItem,
            this.multiplicityProductBarItem,
            this.zonesBarItem,
            this.resZoneBarItem,
            this.groupProductsBarItem});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 136;
            this.navBarControl1.Size = new System.Drawing.Size(205, 709);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            // 
            // directoriesBarGroup
            // 
            this.directoriesBarGroup.Caption = "Справочники";
            this.directoriesBarGroup.Expanded = true;
            this.directoriesBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.zonesBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.resZoneBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.warehousesBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.streetsBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.raftBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.shelfsBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.shelfSpacesBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.rotationBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.unitsBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.productsBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.groupProductsBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.restsBarItem)});
            this.directoriesBarGroup.Name = "directoriesBarGroup";
            // 
            // zonesBarItem
            // 
            this.zonesBarItem.Caption = "Зоны";
            this.zonesBarItem.Name = "zonesBarItem";
            this.zonesBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ZonesBarItemLinkClicked);
            // 
            // resZoneBarItem
            // 
            this.resZoneBarItem.Caption = "Ответственные за зоны";
            this.resZoneBarItem.Name = "resZoneBarItem";
            this.resZoneBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ResZoneBarItemLinkClicked);
            // 
            // warehousesBarItem
            // 
            this.warehousesBarItem.Caption = "Склады";
            this.warehousesBarItem.Name = "warehousesBarItem";
            this.warehousesBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.WarehousesBarItemLinkClicked);
            // 
            // streetsBarItem
            // 
            this.streetsBarItem.Caption = "Улицы";
            this.streetsBarItem.Name = "streetsBarItem";
            this.streetsBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.StreetsBarItemLinkClicked);
            // 
            // raftBarItem
            // 
            this.raftBarItem.Caption = "Стеллажи";
            this.raftBarItem.Name = "raftBarItem";
            this.raftBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.RaftBarItemLinkClicked);
            // 
            // shelfsBarItem
            // 
            this.shelfsBarItem.Caption = "Полки";
            this.shelfsBarItem.Name = "shelfsBarItem";
            this.shelfsBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ShelfsBarItemLinkClicked);
            // 
            // shelfSpacesBarItem
            // 
            this.shelfSpacesBarItem.Caption = "Места на полках";
            this.shelfSpacesBarItem.Name = "shelfSpacesBarItem";
            this.shelfSpacesBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ShelfSpacesBarItemLinkClicked);
            // 
            // rotationBarItem
            // 
            this.rotationBarItem.Caption = "Типы ротации";
            this.rotationBarItem.Name = "rotationBarItem";
            this.rotationBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.RotationBarItemLinkClicked);
            // 
            // unitsBarItem
            // 
            this.unitsBarItem.Caption = "Еденицы деления";
            this.unitsBarItem.Name = "unitsBarItem";
            this.unitsBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.UnitsBarItemLinkClicked);
            // 
            // productsBarItem
            // 
            this.productsBarItem.Caption = "Товары";
            this.productsBarItem.Name = "productsBarItem";
            this.productsBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ProductsBarItemLinkClicked);
            // 
            // groupProductsBarItem
            // 
            this.groupProductsBarItem.Caption = "Зональные группы товаров";
            this.groupProductsBarItem.Name = "groupProductsBarItem";
            this.groupProductsBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.GroupProductsBarItemLinkClicked);
            // 
            // restsBarItem
            // 
            this.restsBarItem.Caption = "Типы партий";
            this.restsBarItem.Name = "restsBarItem";
            this.restsBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.RestsBarItemLinkClicked);
            // 
            // parametersBarGroup
            // 
            this.parametersBarGroup.Caption = "Параметры";
            this.parametersBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.paramsBarItem)});
            this.parametersBarGroup.Name = "parametersBarGroup";
            // 
            // paramsBarItem
            // 
            this.paramsBarItem.Caption = "Параметры системы";
            this.paramsBarItem.Name = "paramsBarItem";
            // 
            // multiplicityProductBarItem
            // 
            this.multiplicityProductBarItem.Caption = "Кратность товаров";
            this.multiplicityProductBarItem.Name = "multiplicityProductBarItem";
            this.multiplicityProductBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.MultiplicityProductBarItemLinkClicked);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.deleteButton);
            this.panelControl1.Controls.Add(this.editButton);
            this.panelControl1.Controls.Add(this.addButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 679);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(818, 30);
            this.panelControl1.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "F8 Удалить";
            this.deleteButton.ToolTip = "В данном режиме можно\r\nудалить полностью запись";
            this.deleteButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning;
            this.deleteButton.ToolTipTitle = "Внимание!";
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(87, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "F4 Изменить";
            this.editButton.ToolTip = "В данном режиме можно\r\nизменить свойства записи";
            this.editButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning;
            this.editButton.ToolTipTitle = "Внимание!";
            this.editButton.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "F5 Добавить";
            this.addButton.ToolTip = "В данном режиме можно\r\nдобавить новую запись \r\nв справочник";
            this.addButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.addButton.ToolTipTitle = "Подсказка";
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // mainTabControl
            // 
            this.mainTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Size = new System.Drawing.Size(818, 709);
            this.mainTabControl.TabIndex = 16;
            this.mainTabControl.CloseButtonClick += new System.EventHandler(this.XtraTabControl1CloseButtonClick);
            // 
            // catalogRaftBindingSource
            // 
            this.catalogRaftBindingSource.DataMember = "Catalog_Raft";
            this.catalogRaftBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalog_RaftTableAdapter
            // 
            this.catalog_RaftTableAdapter.ClearBeforeFill = true;
            // 
            // catalogShelfSpacesBindingSource
            // 
            this.catalogShelfSpacesBindingSource.DataMember = "Catalog_ShelfSpaces";
            this.catalogShelfSpacesBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalog_ShelfSpacesTableAdapter
            // 
            this.catalog_ShelfSpacesTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_ShelfsTableAdapter
            // 
            this.catalog_ShelfsTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_RotationsProductTableAdapter
            // 
            this.catalog_RotationsProductTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_UnitsTableAdapter
            // 
            this.catalog_UnitsTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_ProductsTableAdapter
            // 
            this.catalog_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // catalog_TypeOfRestsTableAdapter
            // 
            this.catalog_TypeOfRestsTableAdapter.ClearBeforeFill = true;
            // 
            // _Catalog_MultiplicityProductsTableAdapter
            // 
            this._Catalog_MultiplicityProductsTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_ZonesTableAdapter
            // 
            this.catalog_ZonesTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_ResponsibleForTheZoneTableAdapter
            // 
            this.catalog_ResponsibleForTheZoneTableAdapter.ClearBeforeFill = true;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colParentID1
            // 
            this.colParentID1.FieldName = "ParentID";
            this.colParentID1.Name = "colParentID1";
            this.colParentID1.Visible = true;
            this.colParentID1.VisibleIndex = 1;
            // 
            // colName2
            // 
            this.colName2.FieldName = "Name";
            this.colName2.Name = "colName2";
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 2;
            // 
            // colIsMainGroup2
            // 
            this.colIsMainGroup2.FieldName = "IsMainGroup";
            this.colIsMainGroup2.Name = "colIsMainGroup2";
            this.colIsMainGroup2.Visible = true;
            this.colIsMainGroup2.VisibleIndex = 3;
            // 
            // colName11
            // 
            this.colName11.FieldName = "Name1";
            this.colName11.Name = "colName11";
            this.colName11.Visible = true;
            this.colName11.VisibleIndex = 4;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Location = new System.Drawing.Point(129, 469);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(200, 100);
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(100, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Группы товаров";
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(95, 100);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Субгруппы товаров";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(87, 83);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(400, 200);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID2,
            this.colParentID2,
            this.colName1,
            this.colIsMainGroup1});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            // 
            // colID2
            // 
            this.colID2.FieldName = "ID";
            this.colID2.Name = "colID2";
            this.colID2.OptionsColumn.ReadOnly = true;
            this.colID2.Visible = true;
            this.colID2.VisibleIndex = 0;
            // 
            // colParentID2
            // 
            this.colParentID2.FieldName = "ParentID";
            this.colParentID2.Name = "colParentID2";
            this.colParentID2.Visible = true;
            this.colParentID2.VisibleIndex = 1;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 2;
            // 
            // colIsMainGroup1
            // 
            this.colIsMainGroup1.FieldName = "IsMainGroup";
            this.colIsMainGroup1.Name = "colIsMainGroup1";
            this.colIsMainGroup1.Visible = true;
            this.colIsMainGroup1.VisibleIndex = 3;
            // 
            // catalog_GroupTableAdapter
            // 
            this.catalog_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // DirMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 709);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DirMainFrm";
            this.Text = "Справочники и настройки";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_TypeOfRotationsRepositoryItemComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibleForZoneGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfRestsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfSpaceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raftGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogResponsibleForTheZoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogStreetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogZonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogWarehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogMultiplicityProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTypeOfRestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRotationsProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfsBindingSource)).EndInit();
            this.gridContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRaftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfSpacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView warehouseGridView;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource catalogWarehousesBindingSource;
        private Catalog_WarehousesTableAdapter catalog_WarehousesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseID;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseDescription;
        private System.Windows.Forms.BindingSource catalogStreetsBindingSource;
        private Catalog_StreetsTableAdapter catalog_StreetsTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup directoriesBarGroup;
        private DevExpress.XtraNavBar.NavBarItem warehousesBarItem;
        private DevExpress.XtraNavBar.NavBarItem streetsBarItem;
        private DevExpress.XtraGrid.Views.Grid.GridView streetGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetID;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetName;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetDescription;
        private DevExpress.XtraGrid.Views.Grid.GridView raftGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colRaftID;
        private DevExpress.XtraGrid.Columns.GridColumn colRaftName;
        private DevExpress.XtraGrid.Columns.GridColumn colRaftDescription;
        private DevExpress.XtraNavBar.NavBarItem raftBarItem;
        private System.Windows.Forms.BindingSource catalogRaftBindingSource;
        private Catalog_RaftTableAdapter catalog_RaftTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView shelfSpaceGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colShelSpaceID;
        private DevExpress.XtraGrid.Columns.GridColumn colShelSpaceName;
        private DevExpress.XtraGrid.Columns.GridColumn colShelSpaceDescription;
        private DevExpress.XtraGrid.Views.Grid.GridView shelfsGridView;
        private DevExpress.XtraNavBar.NavBarItem shelfSpacesBarItem;
        private System.Windows.Forms.BindingSource catalogShelfSpacesBindingSource;
        private Catalog_ShelfSpacesTableAdapter catalog_ShelfSpacesTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private System.Windows.Forms.ContextMenuStrip gridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStripMenuItem;
        private System.Windows.Forms.BindingSource catalogShelfsBindingSource;
        private Catalog_ShelfsTableAdapter catalog_ShelfsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfID;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfName;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfHeight;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfDeph;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfID_TypeOfRotation;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox id_TypeOfRotationsRepositoryItemComboBox;
        private DevExpress.XtraNavBar.NavBarItem shelfsBarItem;
        private DevExpress.XtraGrid.Views.Grid.GridView rotationGridView;
        private DevExpress.XtraNavBar.NavBarItem rotationBarItem;
        private System.Windows.Forms.BindingSource catalogRotationsProductBindingSource;
        private Catalog_RotationsProductTableAdapter catalog_RotationsProductTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRotID;
        private DevExpress.XtraGrid.Columns.GridColumn colRotName;
        private DevExpress.XtraGrid.Columns.GridColumn colRotMinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRotMaxQty;
        private DevExpress.XtraGrid.Views.Grid.GridView unitsGridView;
        private System.Windows.Forms.BindingSource catalogUnitsBindingSource;
        private Catalog_UnitsTableAdapter catalog_UnitsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeOfUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colDistanceBetweenUnits;
        private DevExpress.XtraNavBar.NavBarItem unitsBarItem;
        private DevExpress.XtraNavBar.NavBarGroup parametersBarGroup;
        private DevExpress.XtraNavBar.NavBarItem paramsBarItem;
        private MyXtraTabControl mainTabControl;
        private DevExpress.XtraNavBar.NavBarItem productsBarItem;
        private System.Windows.Forms.BindingSource catalogProductsBindingSource;
        private WMSDataSetTableAdapters.Catalog_ProductsTableAdapter catalog_ProductsTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView productsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProductBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDimensionX;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDimensionY;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDimensionZ;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraNavBar.NavBarItem restsBarItem;
        private System.Windows.Forms.BindingSource catalogTypeOfRestsBindingSource;
        private Catalog_TypeOfRestsTableAdapter catalog_TypeOfRestsTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView typeOfRestsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colRetstsID;
        private DevExpress.XtraGrid.Columns.GridColumn colRestsName;
        private DevExpress.XtraNavBar.NavBarItem multiplicityProductBarItem;
        private System.Windows.Forms.BindingSource catalogMultiplicityProductsBindingSource;
        private _Catalog_MultiplicityProductsTableAdapter _Catalog_MultiplicityProductsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colProductMultiplicity;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeOfDistribution;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTypeOfDistribution;
        private System.Windows.Forms.BindingSource catalogZonesBindingSource;
        private Catalog_ZonesTableAdapter catalog_ZonesTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView zonesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colZoneID;
        private DevExpress.XtraGrid.Columns.GridColumn colZoneName;
        private DevExpress.XtraGrid.Columns.GridColumn colZoneDescription;
        private DevExpress.XtraNavBar.NavBarItem zonesBarItem;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetZoneName;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetZoneDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetZoneId;
        private DevExpress.XtraGrid.Views.Grid.GridView responsibleForZoneGridView;
        private System.Windows.Forms.BindingSource catalogResponsibleForTheZoneBindingSource;
        private Catalog_ResponsibleForTheZoneTableAdapter catalog_ResponsibleForTheZoneTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colResZoneID;
        private DevExpress.XtraGrid.Columns.GridColumn colResZoneName;
        private DevExpress.XtraGrid.Columns.GridColumn colResZoneNameZone;
        private DevExpress.XtraGrid.Columns.GridColumn colResZoneDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colResZoneID_Zone;
        private DevExpress.XtraNavBar.NavBarItem resZoneBarItem;
        private DevExpress.XtraGrid.Columns.GridColumn colProductWeight;
        private DevExpress.XtraNavBar.NavBarItem groupProductsBarItem;
        private DevExpress.XtraGrid.Views.Grid.GridView groupsGridView;
        //private System.Windows.Forms.BindingSource catalogGroupProductsBindingSource;
        //private Catalog_GroupProductsTableAdapter catalog_GroupProductsTableAdapter;
        //private Catalog_SubGroupProductsTableAdapter catalog_SubGroupProductsTableAdapter;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colParentID1;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
        private DevExpress.XtraGrid.Columns.GridColumn colIsMainGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colName11;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        //private System.Windows.Forms.BindingSource catalogSubGroupProductsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID2;
        private DevExpress.XtraGrid.Columns.GridColumn colParentID2;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsMainGroup1;
        private System.Windows.Forms.BindingSource catalogGroupBindingSource;
        private Catalog_GroupTableAdapter catalog_GroupTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupZoneID;
        private DevExpress.XtraGrid.Columns.GridColumn colNameGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrriptionGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colNameZone;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrriptionZone;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupWarehouseID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNameGroup;
        //private Catalog_SubGroupProductsTableAdapter catalog_SubGroupProductsTableAdapter;

    }
}
