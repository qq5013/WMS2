using DevExpress.Data;

namespace WMS.AddressAsignment
{
    partial class FrmAddAddress
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colForThisProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.existsAddressesTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.emptyAddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new WMS.AddressAsignment.WMSDataSet();
            this.existsAddressesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehousesDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetsDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaftDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfsDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfSpacesDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstringAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createNewAddressTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.findAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.busyAddressLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.infoAddressLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.infoShelfSpaceLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.infoShelfLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.infoRaftLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.infoStreetLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.infoWarehouseLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.shelfSpaceLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogShelfSpacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelfLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogShelfsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raftLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogRaftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streetLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogStreetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogWarehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.topPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.typeRotLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.qtyRotLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.expirationDateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.analysisTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.seriesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.giveAllQuantityButton = new DevExpress.XtraEditors.SimpleButton();
            this.quantityAlowTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.partRowTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.quantiySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bodyPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.emptyAddressesTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.EmptyAddressesTableAdapter();
            this.bottomPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveAddressButton = new DevExpress.XtraEditors.SimpleButton();
            this.catalog_WarehousesTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.Catalog_WarehousesTableAdapter();
            this.catalog_StreetsTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.Catalog_StreetsTableAdapter();
            this.catalog_RaftTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.Catalog_RaftTableAdapter();
            this.catalog_ShelfsTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.Catalog_ShelfsTableAdapter();
            this.catalog_ShelfSpacesTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.Catalog_ShelfSpacesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.existsAddressesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyAddressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existsAddressesGridView)).BeginInit();
            this.createNewAddressTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfSpaceLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfSpacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raftLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRaftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogStreetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogWarehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).BeginInit();
            this.topPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expirationDateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityAlowTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partRowTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).BeginInit();
            this.bodyPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanelControl)).BeginInit();
            this.bottomPanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // colForThisProduct
            // 
            this.colForThisProduct.Caption = "ForThisProduct";
            this.colForThisProduct.FieldName = "ForThisProduct";
            this.colForThisProduct.Name = "colForThisProduct";
            // 
            // TabControl
            // 
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.existsAddressesTabPage;
            this.TabControl.Size = new System.Drawing.Size(608, 397);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.existsAddressesTabPage,
            this.createNewAddressTabPage});
            this.TabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControlSelectedPageChanged);
            // 
            // existsAddressesTabPage
            // 
            this.existsAddressesTabPage.Controls.Add(this.gridControl1);
            this.existsAddressesTabPage.Name = "existsAddressesTabPage";
            this.existsAddressesTabPage.Size = new System.Drawing.Size(602, 371);
            this.existsAddressesTabPage.Text = "Существующие свободные адреса";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.emptyAddressesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.existsAddressesGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(602, 371);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.existsAddressesGridView});
            // 
            // emptyAddressesBindingSource
            // 
            this.emptyAddressesBindingSource.DataMember = "EmptyAddresses";
            this.emptyAddressesBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // existsAddressesGridView
            // 
            this.existsAddressesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colWarehousesDescription,
            this.colStreetsDescription,
            this.colRaftDescription,
            this.colShelfsDescription,
            this.colShelfSpacesDescription,
            this.colstringAddress,
            this.colForThisProduct});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Appearance.Options.UseTextOptions = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colForThisProduct;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = ((long)(1));
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition2.Appearance.BorderColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseBorderColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Appearance.Options.UseTextOptions = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colForThisProduct;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = ((long)(2));
            this.existsAddressesGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.existsAddressesGridView.GridControl = this.gridControl1;
            this.existsAddressesGridView.Name = "existsAddressesGridView";
            this.existsAddressesGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.existsAddressesGridView.OptionsBehavior.Editable = false;
            this.existsAddressesGridView.OptionsView.ColumnAutoWidth = false;
            this.existsAddressesGridView.OptionsView.ShowAutoFilterRow = true;
            this.existsAddressesGridView.OptionsView.ShowFooter = true;
            this.existsAddressesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "Код";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 38;
            // 
            // colWarehousesDescription
            // 
            this.colWarehousesDescription.Caption = "Склад";
            this.colWarehousesDescription.FieldName = "WarehousesDescription";
            this.colWarehousesDescription.Name = "colWarehousesDescription";
            this.colWarehousesDescription.Visible = true;
            this.colWarehousesDescription.VisibleIndex = 1;
            this.colWarehousesDescription.Width = 60;
            // 
            // colStreetsDescription
            // 
            this.colStreetsDescription.Caption = "Улица";
            this.colStreetsDescription.FieldName = "StreetsDescription";
            this.colStreetsDescription.Name = "colStreetsDescription";
            this.colStreetsDescription.Visible = true;
            this.colStreetsDescription.VisibleIndex = 2;
            this.colStreetsDescription.Width = 62;
            // 
            // colRaftDescription
            // 
            this.colRaftDescription.Caption = "Стеллаж";
            this.colRaftDescription.FieldName = "RaftDescription";
            this.colRaftDescription.Name = "colRaftDescription";
            this.colRaftDescription.Visible = true;
            this.colRaftDescription.VisibleIndex = 3;
            this.colRaftDescription.Width = 60;
            // 
            // colShelfsDescription
            // 
            this.colShelfsDescription.Caption = "Полка";
            this.colShelfsDescription.FieldName = "ShelfsDescription";
            this.colShelfsDescription.Name = "colShelfsDescription";
            this.colShelfsDescription.Visible = true;
            this.colShelfsDescription.VisibleIndex = 4;
            this.colShelfsDescription.Width = 53;
            // 
            // colShelfSpacesDescription
            // 
            this.colShelfSpacesDescription.Caption = "Место на полке";
            this.colShelfSpacesDescription.FieldName = "ShelfSpacesDescription";
            this.colShelfSpacesDescription.Name = "colShelfSpacesDescription";
            this.colShelfSpacesDescription.Visible = true;
            this.colShelfSpacesDescription.VisibleIndex = 5;
            this.colShelfSpacesDescription.Width = 100;
            // 
            // colstringAddress
            // 
            this.colstringAddress.Caption = "Адрес";
            this.colstringAddress.FieldName = "stringAddress";
            this.colstringAddress.Name = "colstringAddress";
            this.colstringAddress.OptionsColumn.ReadOnly = true;
            this.colstringAddress.Visible = true;
            this.colstringAddress.VisibleIndex = 6;
            this.colstringAddress.Width = 136;
            // 
            // createNewAddressTabPage
            // 
            this.createNewAddressTabPage.Controls.Add(this.labelControl13);
            this.createNewAddressTabPage.Controls.Add(this.findAddressTextEdit);
            this.createNewAddressTabPage.Controls.Add(this.busyAddressLabelControl);
            this.createNewAddressTabPage.Controls.Add(this.infoAddressLabelControl);
            this.createNewAddressTabPage.Controls.Add(this.infoShelfSpaceLabelControl);
            this.createNewAddressTabPage.Controls.Add(this.infoShelfLabelControl);
            this.createNewAddressTabPage.Controls.Add(this.infoRaftLabelControl);
            this.createNewAddressTabPage.Controls.Add(this.infoStreetLabelControl);
            this.createNewAddressTabPage.Controls.Add(this.infoWarehouseLabelControl);
            this.createNewAddressTabPage.Controls.Add(this.shelfSpaceLookUpEdit);
            this.createNewAddressTabPage.Controls.Add(this.shelfLookUpEdit);
            this.createNewAddressTabPage.Controls.Add(this.raftLookUpEdit);
            this.createNewAddressTabPage.Controls.Add(this.streetLookUpEdit);
            this.createNewAddressTabPage.Controls.Add(this.warehouseLookUpEdit);
            this.createNewAddressTabPage.Controls.Add(this.labelControl5);
            this.createNewAddressTabPage.Controls.Add(this.labelControl4);
            this.createNewAddressTabPage.Controls.Add(this.labelControl3);
            this.createNewAddressTabPage.Controls.Add(this.labelControl2);
            this.createNewAddressTabPage.Controls.Add(this.labelControl1);
            this.createNewAddressTabPage.Name = "createNewAddressTabPage";
            this.createNewAddressTabPage.Size = new System.Drawing.Size(602, 371);
            this.createNewAddressTabPage.Text = "Создание нового адреса";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Location = new System.Drawing.Point(125, 30);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(43, 14);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = "Адрес:";
            // 
            // findAddressTextEdit
            // 
            this.findAddressTextEdit.Location = new System.Drawing.Point(174, 19);
            this.findAddressTextEdit.Name = "findAddressTextEdit";
            this.findAddressTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.findAddressTextEdit.Properties.Appearance.Options.UseFont = true;
            this.findAddressTextEdit.Size = new System.Drawing.Size(200, 31);
            this.findAddressTextEdit.TabIndex = 22;
            this.findAddressTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findAddressTextEdit_KeyDown);
            // 
            // busyAddressLabelControl
            // 
            this.busyAddressLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.busyAddressLabelControl.Appearance.ForeColor = System.Drawing.Color.Green;
            this.busyAddressLabelControl.Location = new System.Drawing.Point(174, 74);
            this.busyAddressLabelControl.Name = "busyAddressLabelControl";
            this.busyAddressLabelControl.Size = new System.Drawing.Size(9, 13);
            this.busyAddressLabelControl.TabIndex = 21;
            this.busyAddressLabelControl.Text = "...";
            // 
            // infoAddressLabelControl
            // 
            this.infoAddressLabelControl.Appearance.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.infoAddressLabelControl.Appearance.ForeColor = System.Drawing.Color.Green;
            this.infoAddressLabelControl.Location = new System.Drawing.Point(112, 304);
            this.infoAddressLabelControl.Name = "infoAddressLabelControl";
            this.infoAddressLabelControl.Size = new System.Drawing.Size(0, 31);
            this.infoAddressLabelControl.TabIndex = 20;
            // 
            // infoShelfSpaceLabelControl
            // 
            this.infoShelfSpaceLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.infoShelfSpaceLabelControl.Location = new System.Drawing.Point(366, 255);
            this.infoShelfSpaceLabelControl.Name = "infoShelfSpaceLabelControl";
            this.infoShelfSpaceLabelControl.Size = new System.Drawing.Size(12, 14);
            this.infoShelfSpaceLabelControl.TabIndex = 19;
            this.infoShelfSpaceLabelControl.Text = "...";
            // 
            // infoShelfLabelControl
            // 
            this.infoShelfLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.infoShelfLabelControl.Location = new System.Drawing.Point(366, 216);
            this.infoShelfLabelControl.Name = "infoShelfLabelControl";
            this.infoShelfLabelControl.Size = new System.Drawing.Size(12, 14);
            this.infoShelfLabelControl.TabIndex = 18;
            this.infoShelfLabelControl.Text = "...";
            // 
            // infoRaftLabelControl
            // 
            this.infoRaftLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.infoRaftLabelControl.Location = new System.Drawing.Point(366, 178);
            this.infoRaftLabelControl.Name = "infoRaftLabelControl";
            this.infoRaftLabelControl.Size = new System.Drawing.Size(12, 14);
            this.infoRaftLabelControl.TabIndex = 17;
            this.infoRaftLabelControl.Text = "...";
            // 
            // infoStreetLabelControl
            // 
            this.infoStreetLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.infoStreetLabelControl.Location = new System.Drawing.Point(366, 142);
            this.infoStreetLabelControl.Name = "infoStreetLabelControl";
            this.infoStreetLabelControl.Size = new System.Drawing.Size(12, 14);
            this.infoStreetLabelControl.TabIndex = 16;
            this.infoStreetLabelControl.Text = "...";
            // 
            // infoWarehouseLabelControl
            // 
            this.infoWarehouseLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.infoWarehouseLabelControl.Location = new System.Drawing.Point(366, 105);
            this.infoWarehouseLabelControl.Name = "infoWarehouseLabelControl";
            this.infoWarehouseLabelControl.Size = new System.Drawing.Size(12, 14);
            this.infoWarehouseLabelControl.TabIndex = 15;
            this.infoWarehouseLabelControl.Text = "...";
            // 
            // shelfSpaceLookUpEdit
            // 
            this.shelfSpaceLookUpEdit.Location = new System.Drawing.Point(174, 253);
            this.shelfSpaceLookUpEdit.Name = "shelfSpaceLookUpEdit";
            this.shelfSpaceLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.shelfSpaceLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shelfSpaceLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.shelfSpaceLookUpEdit.Properties.DataSource = this.catalogShelfSpacesBindingSource;
            this.shelfSpaceLookUpEdit.Properties.DisplayMember = "Name";
            this.shelfSpaceLookUpEdit.Properties.NullText = "[Выбирите место]";
            this.shelfSpaceLookUpEdit.Properties.ValueMember = "ID";
            this.shelfSpaceLookUpEdit.Size = new System.Drawing.Size(176, 20);
            this.shelfSpaceLookUpEdit.TabIndex = 14;
            this.shelfSpaceLookUpEdit.EditValueChanged += new System.EventHandler(this.ShelfSpaceLookUpEditEditValueChanged);
            // 
            // catalogShelfSpacesBindingSource
            // 
            this.catalogShelfSpacesBindingSource.DataMember = "Catalog_ShelfSpaces";
            this.catalogShelfSpacesBindingSource.DataSource = this.wMSDataSet;
            // 
            // shelfLookUpEdit
            // 
            this.shelfLookUpEdit.Location = new System.Drawing.Point(174, 214);
            this.shelfLookUpEdit.Name = "shelfLookUpEdit";
            this.shelfLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.shelfLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)), serializableAppearanceObject1, "", null, null, true)});
            this.shelfLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Height", "Высота", 41, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Deph", "Глубина", 35, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Expr1", "Ротация", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MinQty", "Минимум ротации", 47, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaxQty", "Максимум ротации", 51, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.shelfLookUpEdit.Properties.DataSource = this.catalogShelfsBindingSource;
            this.shelfLookUpEdit.Properties.DisplayMember = "Name";
            this.shelfLookUpEdit.Properties.NullText = "[Выбирите полку]";
            this.shelfLookUpEdit.Properties.ValueMember = "ID";
            this.shelfLookUpEdit.Size = new System.Drawing.Size(176, 20);
            this.shelfLookUpEdit.TabIndex = 13;
            this.shelfLookUpEdit.EditValueChanged += new System.EventHandler(this.ShelfLookUpEditEditValueChanged);
            // 
            // catalogShelfsBindingSource
            // 
            this.catalogShelfsBindingSource.DataMember = "Catalog_Shelfs";
            this.catalogShelfsBindingSource.DataSource = this.wMSDataSet;
            // 
            // raftLookUpEdit
            // 
            this.raftLookUpEdit.Location = new System.Drawing.Point(174, 176);
            this.raftLookUpEdit.Name = "raftLookUpEdit";
            this.raftLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.raftLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.raftLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.raftLookUpEdit.Properties.DataSource = this.catalogRaftBindingSource;
            this.raftLookUpEdit.Properties.DisplayMember = "Name";
            this.raftLookUpEdit.Properties.NullText = "[Выбирите стеллаж]";
            this.raftLookUpEdit.Properties.ValueMember = "ID";
            this.raftLookUpEdit.Size = new System.Drawing.Size(176, 20);
            this.raftLookUpEdit.TabIndex = 12;
            this.raftLookUpEdit.EditValueChanged += new System.EventHandler(this.RaftLookUpEditEditValueChanged);
            // 
            // catalogRaftBindingSource
            // 
            this.catalogRaftBindingSource.DataMember = "Catalog_Raft";
            this.catalogRaftBindingSource.DataSource = this.wMSDataSet;
            // 
            // streetLookUpEdit
            // 
            this.streetLookUpEdit.Location = new System.Drawing.Point(174, 140);
            this.streetLookUpEdit.Name = "streetLookUpEdit";
            this.streetLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.streetLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.streetLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.streetLookUpEdit.Properties.DataSource = this.catalogStreetsBindingSource;
            this.streetLookUpEdit.Properties.DisplayMember = "Name";
            this.streetLookUpEdit.Properties.NullText = "[Выбирите улицу]";
            this.streetLookUpEdit.Properties.ValueMember = "ID";
            this.streetLookUpEdit.Size = new System.Drawing.Size(176, 20);
            this.streetLookUpEdit.TabIndex = 11;
            this.streetLookUpEdit.EditValueChanged += new System.EventHandler(this.StreetLookUpEditEditValueChanged);
            // 
            // catalogStreetsBindingSource
            // 
            this.catalogStreetsBindingSource.DataMember = "Catalog_Streets";
            this.catalogStreetsBindingSource.DataSource = this.wMSDataSet;
            // 
            // warehouseLookUpEdit
            // 
            this.warehouseLookUpEdit.Location = new System.Drawing.Point(174, 103);
            this.warehouseLookUpEdit.Name = "warehouseLookUpEdit";
            this.warehouseLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.warehouseLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warehouseLookUpEdit.Properties.DataSource = this.catalogWarehousesBindingSource;
            this.warehouseLookUpEdit.Properties.DisplayMember = "Name";
            this.warehouseLookUpEdit.Properties.NullText = "[Выбирите склад]";
            this.warehouseLookUpEdit.Properties.ValueMember = "ID";
            this.warehouseLookUpEdit.Size = new System.Drawing.Size(176, 20);
            this.warehouseLookUpEdit.TabIndex = 10;
            this.warehouseLookUpEdit.EditValueChanged += new System.EventHandler(this.WarehouseLookUpEditEditValueChanged);
            // 
            // catalogWarehousesBindingSource
            // 
            this.catalogWarehousesBindingSource.DataMember = "Catalog_Warehouses";
            this.catalogWarehousesBindingSource.DataSource = this.wMSDataSet;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(129, 255);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 14);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Место";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(129, 216);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Полка";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(112, 178);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 14);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Стеллаж";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(129, 142);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 14);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Улица";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(129, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Склад";
            // 
            // topPanelControl
            // 
            this.topPanelControl.Controls.Add(this.typeRotLabelControl);
            this.topPanelControl.Controls.Add(this.qtyRotLabelControl);
            this.topPanelControl.Controls.Add(this.labelControl14);
            this.topPanelControl.Controls.Add(this.labelControl12);
            this.topPanelControl.Controls.Add(this.expirationDateTextEdit);
            this.topPanelControl.Controls.Add(this.analysisTextEdit);
            this.topPanelControl.Controls.Add(this.seriesTextEdit);
            this.topPanelControl.Controls.Add(this.giveAllQuantityButton);
            this.topPanelControl.Controls.Add(this.quantityAlowTextEdit);
            this.topPanelControl.Controls.Add(this.labelControl11);
            this.topPanelControl.Controls.Add(this.partRowTextEdit);
            this.topPanelControl.Controls.Add(this.productTextEdit);
            this.topPanelControl.Controls.Add(this.labelControl10);
            this.topPanelControl.Controls.Add(this.labelControl6);
            this.topPanelControl.Controls.Add(this.labelControl7);
            this.topPanelControl.Controls.Add(this.labelControl9);
            this.topPanelControl.Controls.Add(this.labelControl8);
            this.topPanelControl.Controls.Add(this.quantiySpinEdit);
            this.topPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelControl.Location = new System.Drawing.Point(0, 0);
            this.topPanelControl.Name = "topPanelControl";
            this.topPanelControl.Size = new System.Drawing.Size(612, 126);
            this.topPanelControl.TabIndex = 1;
            // 
            // typeRotLabelControl
            // 
            this.typeRotLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.typeRotLabelControl.Appearance.ForeColor = System.Drawing.Color.Red;
            this.typeRotLabelControl.Location = new System.Drawing.Point(461, 96);
            this.typeRotLabelControl.Name = "typeRotLabelControl";
            this.typeRotLabelControl.Size = new System.Drawing.Size(8, 14);
            this.typeRotLabelControl.TabIndex = 39;
            this.typeRotLabelControl.Text = "B";
            // 
            // qtyRotLabelControl
            // 
            this.qtyRotLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.qtyRotLabelControl.Appearance.ForeColor = System.Drawing.Color.Red;
            this.qtyRotLabelControl.Location = new System.Drawing.Point(380, 96);
            this.qtyRotLabelControl.Name = "qtyRotLabelControl";
            this.qtyRotLabelControl.Size = new System.Drawing.Size(60, 14);
            this.qtyRotLabelControl.TabIndex = 38;
            this.qtyRotLabelControl.Text = "12341,00";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl14.Location = new System.Drawing.Point(269, 96);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(105, 14);
            this.labelControl14.TabIndex = 37;
            this.labelControl14.Text = "Кол-во ротация:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl12.Location = new System.Drawing.Point(172, 89);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(81, 26);
            this.labelControl12.TabIndex = 36;
            this.labelControl12.Text = "Кол-во для \r\nданного адреса";
            // 
            // expirationDateTextEdit
            // 
            this.expirationDateTextEdit.Location = new System.Drawing.Point(380, 69);
            this.expirationDateTextEdit.Name = "expirationDateTextEdit";
            this.expirationDateTextEdit.Properties.ReadOnly = true;
            this.expirationDateTextEdit.Size = new System.Drawing.Size(80, 20);
            this.expirationDateTextEdit.TabIndex = 35;
            // 
            // analysisTextEdit
            // 
            this.analysisTextEdit.Location = new System.Drawing.Point(380, 43);
            this.analysisTextEdit.Name = "analysisTextEdit";
            this.analysisTextEdit.Properties.ReadOnly = true;
            this.analysisTextEdit.Size = new System.Drawing.Size(81, 20);
            this.analysisTextEdit.TabIndex = 34;
            // 
            // seriesTextEdit
            // 
            this.seriesTextEdit.Location = new System.Drawing.Point(380, 17);
            this.seriesTextEdit.Name = "seriesTextEdit";
            this.seriesTextEdit.Properties.ReadOnly = true;
            this.seriesTextEdit.Size = new System.Drawing.Size(81, 20);
            this.seriesTextEdit.TabIndex = 33;
            // 
            // giveAllQuantityButton
            // 
            this.giveAllQuantityButton.Location = new System.Drawing.Point(152, 69);
            this.giveAllQuantityButton.Name = "giveAllQuantityButton";
            this.giveAllQuantityButton.Size = new System.Drawing.Size(20, 20);
            this.giveAllQuantityButton.TabIndex = 1;
            this.giveAllQuantityButton.Text = ">";
            this.giveAllQuantityButton.Click += new System.EventHandler(this.GiveAllQuantityButtonClick);
            // 
            // quantityAlowTextEdit
            // 
            this.quantityAlowTextEdit.Location = new System.Drawing.Point(71, 69);
            this.quantityAlowTextEdit.Name = "quantityAlowTextEdit";
            this.quantityAlowTextEdit.Properties.Mask.EditMask = "f";
            this.quantityAlowTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.quantityAlowTextEdit.Properties.ReadOnly = true;
            this.quantityAlowTextEdit.Size = new System.Drawing.Size(75, 20);
            this.quantityAlowTextEdit.TabIndex = 31;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Location = new System.Drawing.Point(276, 71);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(98, 14);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "Срок годности:";
            // 
            // partRowTextEdit
            // 
            this.partRowTextEdit.Location = new System.Drawing.Point(71, 43);
            this.partRowTextEdit.Name = "partRowTextEdit";
            this.partRowTextEdit.Properties.ReadOnly = true;
            this.partRowTextEdit.Size = new System.Drawing.Size(75, 20);
            this.partRowTextEdit.TabIndex = 29;
            // 
            // productTextEdit
            // 
            this.productTextEdit.Location = new System.Drawing.Point(71, 17);
            this.productTextEdit.Name = "productTextEdit";
            this.productTextEdit.Properties.ReadOnly = true;
            this.productTextEdit.Size = new System.Drawing.Size(181, 20);
            this.productTextEdit.TabIndex = 28;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Location = new System.Drawing.Point(325, 45);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 14);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Анализ:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(24, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 14);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Товар:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(16, 45);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 14);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "Партия:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(333, 19);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 14);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "Серия:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(17, 71);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Кол-во:";
            // 
            // quantiySpinEdit
            // 
            this.quantiySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantiySpinEdit.Location = new System.Drawing.Point(177, 69);
            this.quantiySpinEdit.Name = "quantiySpinEdit";
            this.quantiySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.quantiySpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.quantiySpinEdit.Properties.Mask.EditMask = "f";
            this.quantiySpinEdit.Size = new System.Drawing.Size(75, 20);
            this.quantiySpinEdit.TabIndex = 0;
            this.quantiySpinEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantiySpinEditKeyDown);
            // 
            // bodyPanelControl
            // 
            this.bodyPanelControl.Controls.Add(this.TabControl);
            this.bodyPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanelControl.Location = new System.Drawing.Point(0, 126);
            this.bodyPanelControl.Name = "bodyPanelControl";
            this.bodyPanelControl.Size = new System.Drawing.Size(612, 401);
            this.bodyPanelControl.TabIndex = 2;
            // 
            // emptyAddressesTableAdapter
            // 
            this.emptyAddressesTableAdapter.ClearBeforeFill = true;
            // 
            // bottomPanelControl
            // 
            this.bottomPanelControl.Controls.Add(this.cancelButton);
            this.bottomPanelControl.Controls.Add(this.saveAddressButton);
            this.bottomPanelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanelControl.Location = new System.Drawing.Point(0, 527);
            this.bottomPanelControl.Name = "bottomPanelControl";
            this.bottomPanelControl.Size = new System.Drawing.Size(612, 40);
            this.bottomPanelControl.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(412, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // saveAddressButton
            // 
            this.saveAddressButton.Location = new System.Drawing.Point(16, 9);
            this.saveAddressButton.Name = "saveAddressButton";
            this.saveAddressButton.Size = new System.Drawing.Size(205, 23);
            this.saveAddressButton.TabIndex = 0;
            this.saveAddressButton.Text = "Назначить этот адрес";
            this.saveAddressButton.Click += new System.EventHandler(this.SaveAddressButtonClick);
            // 
            // catalog_WarehousesTableAdapter
            // 
            this.catalog_WarehousesTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_StreetsTableAdapter
            // 
            this.catalog_StreetsTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_RaftTableAdapter
            // 
            this.catalog_RaftTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_ShelfsTableAdapter
            // 
            this.catalog_ShelfsTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_ShelfSpacesTableAdapter
            // 
            this.catalog_ShelfSpacesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 567);
            this.Controls.Add(this.bodyPanelControl);
            this.Controls.Add(this.bottomPanelControl);
            this.Controls.Add(this.topPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmAddAddressLoad);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.existsAddressesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyAddressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existsAddressesGridView)).EndInit();
            this.createNewAddressTabPage.ResumeLayout(false);
            this.createNewAddressTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfSpaceLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfSpacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raftLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRaftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogStreetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogWarehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).EndInit();
            this.topPanelControl.ResumeLayout(false);
            this.topPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expirationDateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityAlowTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partRowTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).EndInit();
            this.bodyPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanelControl)).EndInit();
            this.bottomPanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage existsAddressesTabPage;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView existsAddressesGridView;
        private DevExpress.XtraTab.XtraTabPage createNewAddressTabPage;
        private DevExpress.XtraEditors.PanelControl topPanelControl;
        private DevExpress.XtraEditors.PanelControl bodyPanelControl;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource emptyAddressesBindingSource;
        private WMSDataSetTableAdapters.EmptyAddressesTableAdapter emptyAddressesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehousesDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetsDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRaftDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfsDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfSpacesDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colstringAddress;
        private DevExpress.XtraEditors.PanelControl bottomPanelControl;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveAddressButton;
        private DevExpress.XtraEditors.LookUpEdit shelfSpaceLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit shelfLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit raftLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit streetLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit warehouseLookUpEdit;
        private System.Windows.Forms.BindingSource catalogWarehousesBindingSource;
        private WMSDataSetTableAdapters.Catalog_WarehousesTableAdapter catalog_WarehousesTableAdapter;
        private System.Windows.Forms.BindingSource catalogStreetsBindingSource;
        private WMSDataSetTableAdapters.Catalog_StreetsTableAdapter catalog_StreetsTableAdapter;
        private System.Windows.Forms.BindingSource catalogRaftBindingSource;
        private WMSDataSetTableAdapters.Catalog_RaftTableAdapter catalog_RaftTableAdapter;
        private System.Windows.Forms.BindingSource catalogShelfsBindingSource;
        private WMSDataSetTableAdapters.Catalog_ShelfsTableAdapter catalog_ShelfsTableAdapter;
        private System.Windows.Forms.BindingSource catalogShelfSpacesBindingSource;
        private WMSDataSetTableAdapters.Catalog_ShelfSpacesTableAdapter catalog_ShelfSpacesTableAdapter;
        private DevExpress.XtraEditors.LabelControl infoWarehouseLabelControl;
        private DevExpress.XtraEditors.LabelControl infoShelfSpaceLabelControl;
        private DevExpress.XtraEditors.LabelControl infoShelfLabelControl;
        private DevExpress.XtraEditors.LabelControl infoRaftLabelControl;
        private DevExpress.XtraEditors.LabelControl infoStreetLabelControl;
        private DevExpress.XtraEditors.LabelControl busyAddressLabelControl;
        private DevExpress.XtraEditors.LabelControl infoAddressLabelControl;
        private DevExpress.XtraEditors.TextEdit expirationDateTextEdit;
        private DevExpress.XtraEditors.TextEdit analysisTextEdit;
        private DevExpress.XtraEditors.TextEdit seriesTextEdit;
        private DevExpress.XtraEditors.SimpleButton giveAllQuantityButton;
        private DevExpress.XtraEditors.TextEdit quantityAlowTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit partRowTextEdit;
        private DevExpress.XtraEditors.TextEdit productTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SpinEdit quantiySpinEdit;
        private DevExpress.XtraEditors.TextEdit findAddressTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl typeRotLabelControl;
        private DevExpress.XtraEditors.LabelControl qtyRotLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraGrid.Columns.GridColumn colForThisProduct;
    }
}