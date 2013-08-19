namespace WMS.PrintLabels
{
    partial class FrmPrintLabels
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.descriptionSkuLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.findSkuWithAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.catalogShelfSpacesBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.PrintLabels.WMSDataSet();
            this.catalogShelfsBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogRaftBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogStreetsBindingSource = new System.Windows.Forms.BindingSource();
            this.catalogWarehousesBindingSource = new System.Windows.Forms.BindingSource();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.addressForPrintGridControl = new DevExpress.XtraGrid.GridControl();
            this.addressesForPrintLabelsBindingSource = new System.Windows.Forms.BindingSource();
            this.addressForPrintGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRINTED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaftDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShelfSpaceDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.catalog_WarehousesTableAdapter = new WMS.PrintLabels.WMSDataSetTableAdapters.Catalog_WarehousesTableAdapter();
            this.catalog_StreetsTableAdapter = new WMS.PrintLabels.WMSDataSetTableAdapters.Catalog_StreetsTableAdapter();
            this.catalog_RaftTableAdapter = new WMS.PrintLabels.WMSDataSetTableAdapters.Catalog_RaftTableAdapter();
            this.catalog_ShelfsTableAdapter = new WMS.PrintLabels.WMSDataSetTableAdapters.Catalog_ShelfsTableAdapter();
            this.catalog_ShelfSpacesTableAdapter = new WMS.PrintLabels.WMSDataSetTableAdapters.Catalog_ShelfSpacesTableAdapter();
            this.addressesForPrintLabelsTableAdapter = new WMS.PrintLabels.WMSDataSetTableAdapters.AddressesForPrintLabelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findSkuWithAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfSpacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRaftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogStreetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogWarehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressForPrintGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesForPrintLabelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressForPrintGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.descriptionSkuLabelControl);
            this.panelControl1.Controls.Add(this.findSkuWithAddressTextEdit);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(775, 93);
            this.panelControl1.TabIndex = 0;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(12, 61);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Выборочная печать";
            this.checkEdit1.Size = new System.Drawing.Size(135, 19);
            this.checkEdit1.TabIndex = 21;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.CheckEdit1CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(258, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Бар код / Артикул / Адрес";
            this.labelControl1.Visible = false;
            // 
            // descriptionSkuLabelControl
            // 
            this.descriptionSkuLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.descriptionSkuLabelControl.Location = new System.Drawing.Point(407, 31);
            this.descriptionSkuLabelControl.Name = "descriptionSkuLabelControl";
            this.descriptionSkuLabelControl.Size = new System.Drawing.Size(250, 19);
            this.descriptionSkuLabelControl.TabIndex = 19;
            this.descriptionSkuLabelControl.Text = "Bromhexin 25mg N100 (Germania)";
            this.descriptionSkuLabelControl.Visible = false;
            // 
            // findSkuWithAddressTextEdit
            // 
            this.findSkuWithAddressTextEdit.EditValue = "";
            this.findSkuWithAddressTextEdit.Location = new System.Drawing.Point(247, 24);
            this.findSkuWithAddressTextEdit.Name = "findSkuWithAddressTextEdit";
            this.findSkuWithAddressTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.findSkuWithAddressTextEdit.Properties.Appearance.Options.UseFont = true;
            this.findSkuWithAddressTextEdit.Size = new System.Drawing.Size(154, 31);
            this.findSkuWithAddressTextEdit.TabIndex = 18;
            this.findSkuWithAddressTextEdit.Visible = false;
            this.findSkuWithAddressTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindSkuWithAddressTextEditKeyDown);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(137, 11);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(83, 43);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Дизайнер \r\nэтикеток";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 43);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Печатать \r\nвыбранные адреса";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1Click);
            // 
            // catalogShelfSpacesBindingSource
            // 
            this.catalogShelfSpacesBindingSource.DataMember = "Catalog_ShelfSpaces";
            this.catalogShelfSpacesBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogShelfsBindingSource
            // 
            this.catalogShelfsBindingSource.DataMember = "Catalog_Shelfs";
            this.catalogShelfsBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogRaftBindingSource
            // 
            this.catalogRaftBindingSource.DataMember = "Catalog_Raft";
            this.catalogRaftBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogStreetsBindingSource
            // 
            this.catalogStreetsBindingSource.DataMember = "Catalog_Streets";
            this.catalogStreetsBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalogWarehousesBindingSource
            // 
            this.catalogWarehousesBindingSource.DataMember = "Catalog_Warehouses";
            this.catalogWarehousesBindingSource.DataSource = this.wMSDataSet;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.addressForPrintGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 93);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(775, 211);
            this.panelControl2.TabIndex = 1;
            // 
            // addressForPrintGridControl
            // 
            this.addressForPrintGridControl.DataSource = this.addressesForPrintLabelsBindingSource;
            this.addressForPrintGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressForPrintGridControl.Location = new System.Drawing.Point(2, 2);
            this.addressForPrintGridControl.MainView = this.addressForPrintGridView;
            this.addressForPrintGridControl.Name = "addressForPrintGridControl";
            this.addressForPrintGridControl.Size = new System.Drawing.Size(771, 207);
            this.addressForPrintGridControl.TabIndex = 0;
            this.addressForPrintGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.addressForPrintGridView});
            // 
            // addressesForPrintLabelsBindingSource
            // 
            this.addressesForPrintLabelsBindingSource.DataMember = "AddressesForPrintLabels";
            this.addressesForPrintLabelsBindingSource.DataSource = this.wMSDataSet;
            // 
            // addressForPrintGridView
            // 
            this.addressForPrintGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRINTED,
            this.colADDRESS,
            this.colWarehouseDescription,
            this.colStreetDescription,
            this.colRaftDescription,
            this.colShelfDescription,
            this.colShelfSpaceDescription,
            this.colAddressId});
            this.addressForPrintGridView.GridControl = this.addressForPrintGridControl;
            this.addressForPrintGridView.Name = "addressForPrintGridView";
            this.addressForPrintGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.addressForPrintGridView.OptionsBehavior.Editable = false;
            this.addressForPrintGridView.OptionsView.ColumnAutoWidth = false;
            this.addressForPrintGridView.OptionsView.ShowAutoFilterRow = true;
            this.addressForPrintGridView.OptionsView.ShowFooter = true;
            this.addressForPrintGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colPRINTED
            // 
            this.colPRINTED.Caption = "Напечатан";
            this.colPRINTED.FieldName = "PRINTED";
            this.colPRINTED.Name = "colPRINTED";
            this.colPRINTED.OptionsColumn.ReadOnly = true;
            this.colPRINTED.Visible = true;
            this.colPRINTED.VisibleIndex = 0;
            this.colPRINTED.Width = 78;
            // 
            // colADDRESS
            // 
            this.colADDRESS.Caption = "Адрес";
            this.colADDRESS.FieldName = "ADDRESS";
            this.colADDRESS.Name = "colADDRESS";
            this.colADDRESS.OptionsColumn.ReadOnly = true;
            this.colADDRESS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colADDRESS.Visible = true;
            this.colADDRESS.VisibleIndex = 1;
            // 
            // colWarehouseDescription
            // 
            this.colWarehouseDescription.Caption = "Склад";
            this.colWarehouseDescription.FieldName = "Warehouse";
            this.colWarehouseDescription.Name = "colWarehouseDescription";
            this.colWarehouseDescription.Visible = true;
            this.colWarehouseDescription.VisibleIndex = 2;
            // 
            // colStreetDescription
            // 
            this.colStreetDescription.Caption = "Улица";
            this.colStreetDescription.FieldName = "Street";
            this.colStreetDescription.Name = "colStreetDescription";
            this.colStreetDescription.Visible = true;
            this.colStreetDescription.VisibleIndex = 3;
            // 
            // colRaftDescription
            // 
            this.colRaftDescription.Caption = "Стеллаж";
            this.colRaftDescription.FieldName = "Raft";
            this.colRaftDescription.Name = "colRaftDescription";
            this.colRaftDescription.Visible = true;
            this.colRaftDescription.VisibleIndex = 4;
            // 
            // colShelfDescription
            // 
            this.colShelfDescription.Caption = "Полка";
            this.colShelfDescription.FieldName = "Shelf";
            this.colShelfDescription.Name = "colShelfDescription";
            this.colShelfDescription.Visible = true;
            this.colShelfDescription.VisibleIndex = 5;
            // 
            // colShelfSpaceDescription
            // 
            this.colShelfSpaceDescription.Caption = "Место";
            this.colShelfSpaceDescription.FieldName = "ShelfSpace";
            this.colShelfSpaceDescription.Name = "colShelfSpaceDescription";
            this.colShelfSpaceDescription.Visible = true;
            this.colShelfSpaceDescription.VisibleIndex = 6;
            // 
            // colAddressId
            // 
            this.colAddressId.Caption = "gridColumn1";
            this.colAddressId.FieldName = "ID";
            this.colAddressId.Name = "colAddressId";
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
            // addressesForPrintLabelsTableAdapter
            // 
            this.addressesForPrintLabelsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrintLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 304);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPrintLabels";
            this.Text = "Печать этикеток для адресса";
            this.Load += new System.EventHandler(this.FrmPrintLabelsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findSkuWithAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfSpacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogShelfsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRaftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogStreetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogWarehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressForPrintGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesForPrintLabelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressForPrintGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl addressForPrintGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView addressForPrintGridView;
        private WMSDataSet wMSDataSet;
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
        private System.Windows.Forms.BindingSource addressesForPrintLabelsBindingSource;
        private WMSDataSetTableAdapters.AddressesForPrintLabelsTableAdapter addressesForPrintLabelsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPRINTED;
        private DevExpress.XtraGrid.Columns.GridColumn colADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRaftDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfSpaceDescription;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressId;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl descriptionSkuLabelControl;
        private DevExpress.XtraEditors.TextEdit findSkuWithAddressTextEdit;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;


    }
}
