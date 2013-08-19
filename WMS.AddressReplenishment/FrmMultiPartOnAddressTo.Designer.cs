namespace WMS.AddressReplenishment
{
    partial class FrmMultiPartOnAddressTo
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
            this.multiPartOnAddressToGridControl = new DevExpress.XtraGrid.GridControl();
            this.addressReplenishmentGetPartsFromAddressToBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.AddressReplenishment.WMSDataSet();
            this.multiPartOnAddressToGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_AdressFromCatalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_PartOfProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityAdr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatePlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateActivity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_PartRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnalysis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TypeOfRests = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlacedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressReplenishment_GetPartsFromAddressToTableAdapter = new WMS.AddressReplenishment.WMSDataSetTableAdapters.AddressReplenishment_GetPartsFromAddressToTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.multiPartOnAddressToGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressReplenishmentGetPartsFromAddressToBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiPartOnAddressToGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // multiPartOnAddressToGridControl
            // 
            this.multiPartOnAddressToGridControl.DataSource = this.addressReplenishmentGetPartsFromAddressToBindingSource;
            this.multiPartOnAddressToGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiPartOnAddressToGridControl.Location = new System.Drawing.Point(0, 0);
            this.multiPartOnAddressToGridControl.MainView = this.multiPartOnAddressToGridView;
            this.multiPartOnAddressToGridControl.Name = "multiPartOnAddressToGridControl";
            this.multiPartOnAddressToGridControl.Size = new System.Drawing.Size(502, 184);
            this.multiPartOnAddressToGridControl.TabIndex = 0;
            this.multiPartOnAddressToGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.multiPartOnAddressToGridView});
            // 
            // addressReplenishmentGetPartsFromAddressToBindingSource
            // 
            this.addressReplenishmentGetPartsFromAddressToBindingSource.DataMember = "AddressReplenishment_GetPartsFromAddressTo";
            this.addressReplenishmentGetPartsFromAddressToBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // multiPartOnAddressToGridView
            // 
            this.multiPartOnAddressToGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_AdressFromCatalog,
            this.colAddress,
            this.colID_PartOfProduct,
            this.colQuantityAdr,
            this.colDatePlace,
            this.colDateActivity,
            this.colIsDeleted,
            this.colID_PartRow,
            this.colID_Product,
            this.colQuantityPart,
            this.colSeries,
            this.colAnalysis,
            this.colExpirationDate,
            this.colID_TypeOfRests,
            this.colDescription,
            this.colBarCode,
            this.colPlacedBy});
            this.multiPartOnAddressToGridView.GridControl = this.multiPartOnAddressToGridControl;
            this.multiPartOnAddressToGridView.Name = "multiPartOnAddressToGridView";
            this.multiPartOnAddressToGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.multiPartOnAddressToGridView.OptionsBehavior.Editable = false;
            this.multiPartOnAddressToGridView.OptionsView.ColumnAutoWidth = false;
            this.multiPartOnAddressToGridView.OptionsView.ShowGroupPanel = false;
            this.multiPartOnAddressToGridView.OptionsView.ShowIndicator = false;
            this.multiPartOnAddressToGridView.RowHeight = 40;
            this.multiPartOnAddressToGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MultiPartOnAddressToGridViewKeyDown);
            this.multiPartOnAddressToGridView.DoubleClick += new System.EventHandler(this.MultiPartOnAddressToGridViewDoubleClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colID_AdressFromCatalog
            // 
            this.colID_AdressFromCatalog.FieldName = "ID_AdressFromCatalog";
            this.colID_AdressFromCatalog.Name = "colID_AdressFromCatalog";
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Адрес";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 0;
            this.colAddress.Width = 144;
            // 
            // colID_PartOfProduct
            // 
            this.colID_PartOfProduct.FieldName = "ID_PartOfProduct";
            this.colID_PartOfProduct.Name = "colID_PartOfProduct";
            // 
            // colQuantityAdr
            // 
            this.colQuantityAdr.FieldName = "QuantityAdr";
            this.colQuantityAdr.Name = "colQuantityAdr";
            // 
            // colDatePlace
            // 
            this.colDatePlace.FieldName = "DatePlace";
            this.colDatePlace.Name = "colDatePlace";
            // 
            // colDateActivity
            // 
            this.colDateActivity.FieldName = "DateActivity";
            this.colDateActivity.Name = "colDateActivity";
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            // 
            // colID_PartRow
            // 
            this.colID_PartRow.Caption = "Код партии в системе";
            this.colID_PartRow.FieldName = "ID_PartRow";
            this.colID_PartRow.Name = "colID_PartRow";
            this.colID_PartRow.Visible = true;
            this.colID_PartRow.VisibleIndex = 1;
            this.colID_PartRow.Width = 118;
            // 
            // colID_Product
            // 
            this.colID_Product.FieldName = "ID_Product";
            this.colID_Product.Name = "colID_Product";
            // 
            // colQuantityPart
            // 
            this.colQuantityPart.FieldName = "QuantityPart";
            this.colQuantityPart.Name = "colQuantityPart";
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 2;
            this.colSeries.Width = 105;
            // 
            // colAnalysis
            // 
            this.colAnalysis.FieldName = "Analysis";
            this.colAnalysis.Name = "colAnalysis";
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Срок";
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 3;
            this.colExpirationDate.Width = 128;
            // 
            // colID_TypeOfRests
            // 
            this.colID_TypeOfRests.FieldName = "ID_TypeOfRests";
            this.colID_TypeOfRests.Name = "colID_TypeOfRests";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colBarCode
            // 
            this.colBarCode.FieldName = "BarCode";
            this.colBarCode.Name = "colBarCode";
            // 
            // colPlacedBy
            // 
            this.colPlacedBy.FieldName = "PlacedBy";
            this.colPlacedBy.Name = "colPlacedBy";
            // 
            // addressReplenishment_GetPartsFromAddressToTableAdapter
            // 
            this.addressReplenishment_GetPartsFromAddressToTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMultiPartOnAddressTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 184);
            this.Controls.Add(this.multiPartOnAddressToGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMultiPartOnAddressTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMultiPartOnAddressTo";
            ((System.ComponentModel.ISupportInitialize)(this.multiPartOnAddressToGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressReplenishmentGetPartsFromAddressToBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiPartOnAddressToGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl multiPartOnAddressToGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView multiPartOnAddressToGridView;
        private System.Windows.Forms.BindingSource addressReplenishmentGetPartsFromAddressToBindingSource;
        private WMSDataSet wMSDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_AdressFromCatalog;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colID_PartOfProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityAdr;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePlace;
        private DevExpress.XtraGrid.Columns.GridColumn colDateActivity;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colID_PartRow;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPart;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colAnalysis;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TypeOfRests;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPlacedBy;
        private WMSDataSetTableAdapters.AddressReplenishment_GetPartsFromAddressToTableAdapter addressReplenishment_GetPartsFromAddressToTableAdapter;
    }
}