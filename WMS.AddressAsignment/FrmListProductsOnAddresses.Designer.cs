namespace WMS.AddressAsignment
{
    partial class FrmListProductsOnAddresses
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.productsGridControl = new DevExpress.XtraGrid.GridControl();
            this.selectAllProductsOnAddressesBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.AddressAsignment.WMSDataSet();
            this.productsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyInD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyInD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyInD3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressesGridControl = new DevExpress.XtraGrid.GridControl();
            this.selectAddressesOfProductBindingSource = new System.Windows.Forms.BindingSource();
            this.addressesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectAllProductsOnAddressesTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.SelectAllProductsOnAddressesTableAdapter();
            this.selectAddressesOfProductTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.SelectAddressesOfProductTableAdapter();
            this.colBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllProductsOnAddressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAddressesOfProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.productsGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.addressesGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1064, 529);
            this.splitContainerControl1.SplitterPosition = 761;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // productsGridControl
            // 
            this.productsGridControl.DataSource = this.selectAllProductsOnAddressesBindingSource;
            this.productsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGridControl.Location = new System.Drawing.Point(0, 0);
            this.productsGridControl.MainView = this.productsGridView;
            this.productsGridControl.Name = "productsGridControl";
            this.productsGridControl.Size = new System.Drawing.Size(761, 529);
            this.productsGridControl.TabIndex = 0;
            this.productsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productsGridView});
            // 
            // selectAllProductsOnAddressesBindingSource
            // 
            this.selectAllProductsOnAddressesBindingSource.DataMember = "SelectAllProductsOnAddresses";
            this.selectAllProductsOnAddressesBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsGridView
            // 
            this.productsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduct,
            this.colDescription,
            this.colQtyInD1,
            this.colQtyInD2,
            this.colQtyInD3,
            this.colQuantityMax,
            this.colBarCode});
            this.productsGridView.GridControl = this.productsGridControl;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.productsGridView.OptionsBehavior.Editable = false;
            this.productsGridView.OptionsView.ColumnAutoWidth = false;
            this.productsGridView.OptionsView.ShowAutoFilterRow = true;
            this.productsGridView.OptionsView.ShowFooter = true;
            this.productsGridView.OptionsView.ShowGroupPanel = false;
            this.productsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ProductsGridViewFocusedRowChanged);
            // 
            // colIdProduct
            // 
            this.colIdProduct.Caption = "Код товара";
            this.colIdProduct.FieldName = "IdProduct";
            this.colIdProduct.Name = "colIdProduct";
            this.colIdProduct.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdProduct.Visible = true;
            this.colIdProduct.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Название";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colQtyInD1
            // 
            this.colQtyInD1.Caption = "Кол-во на D1";
            this.colQtyInD1.DisplayFormat.FormatString = "f";
            this.colQtyInD1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyInD1.FieldName = "QtyInD1";
            this.colQtyInD1.Name = "colQtyInD1";
            this.colQtyInD1.OptionsColumn.ReadOnly = true;
            this.colQtyInD1.Visible = true;
            this.colQtyInD1.VisibleIndex = 4;
            // 
            // colQtyInD2
            // 
            this.colQtyInD2.Caption = "Кол-во на D2";
            this.colQtyInD2.DisplayFormat.FormatString = "f";
            this.colQtyInD2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyInD2.FieldName = "QtyInD2";
            this.colQtyInD2.Name = "colQtyInD2";
            this.colQtyInD2.OptionsColumn.ReadOnly = true;
            this.colQtyInD2.Visible = true;
            this.colQtyInD2.VisibleIndex = 5;
            // 
            // colQtyInD3
            // 
            this.colQtyInD3.Caption = "Колво на D3";
            this.colQtyInD3.DisplayFormat.FormatString = "f";
            this.colQtyInD3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQtyInD3.FieldName = "QtyInD3";
            this.colQtyInD3.Name = "colQtyInD3";
            this.colQtyInD3.OptionsColumn.ReadOnly = true;
            this.colQtyInD3.Visible = true;
            this.colQtyInD3.VisibleIndex = 6;
            // 
            // colQuantityMax
            // 
            this.colQuantityMax.Caption = "Нужное кол-во на D1";
            this.colQuantityMax.DisplayFormat.FormatString = "f";
            this.colQuantityMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityMax.FieldName = "QuantityMax";
            this.colQuantityMax.Name = "colQuantityMax";
            this.colQuantityMax.Visible = true;
            this.colQuantityMax.VisibleIndex = 3;
            this.colQuantityMax.Width = 96;
            // 
            // addressesGridControl
            // 
            this.addressesGridControl.DataSource = this.selectAddressesOfProductBindingSource;
            this.addressesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressesGridControl.Location = new System.Drawing.Point(0, 0);
            this.addressesGridControl.MainView = this.addressesGridView;
            this.addressesGridControl.Name = "addressesGridControl";
            this.addressesGridControl.Size = new System.Drawing.Size(298, 529);
            this.addressesGridControl.TabIndex = 0;
            this.addressesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.addressesGridView});
            // 
            // selectAddressesOfProductBindingSource
            // 
            this.selectAddressesOfProductBindingSource.DataMember = "SelectAddressesOfProduct";
            this.selectAddressesOfProductBindingSource.DataSource = this.wMSDataSet;
            // 
            // addressesGridView
            // 
            this.addressesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colADDRESS,
            this.colQuantity});
            this.addressesGridView.GridControl = this.addressesGridControl;
            this.addressesGridView.Name = "addressesGridView";
            this.addressesGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.addressesGridView.OptionsBehavior.Editable = false;
            this.addressesGridView.OptionsView.ColumnAutoWidth = false;
            this.addressesGridView.OptionsView.ShowAutoFilterRow = true;
            this.addressesGridView.OptionsView.ShowFooter = true;
            this.addressesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colADDRESS
            // 
            this.colADDRESS.Caption = "Адрес";
            this.colADDRESS.FieldName = "ADDRESS";
            this.colADDRESS.Name = "colADDRESS";
            this.colADDRESS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colADDRESS.Visible = true;
            this.colADDRESS.VisibleIndex = 0;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Кол-во тоавра на адресе";
            this.colQuantity.DisplayFormat.FormatString = "f";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // selectAllProductsOnAddressesTableAdapter
            // 
            this.selectAllProductsOnAddressesTableAdapter.ClearBeforeFill = true;
            // 
            // selectAddressesOfProductTableAdapter
            // 
            this.selectAddressesOfProductTableAdapter.ClearBeforeFill = true;
            // 
            // colBarCode
            // 
            this.colBarCode.Caption = "Бар код";
            this.colBarCode.FieldName = "BarCode";
            this.colBarCode.Name = "colBarCode";
            this.colBarCode.Visible = true;
            this.colBarCode.VisibleIndex = 1;
            // 
            // FrmListProductsOnAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 529);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmListProductsOnAddresses";
            this.Text = "Список товаров на адресах";
            this.Load += new System.EventHandler(this.FrmListProductsOnAddressesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllProductsOnAddressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAddressesOfProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl productsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView productsGridView;
        private DevExpress.XtraGrid.GridControl addressesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView addressesGridView;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource selectAllProductsOnAddressesBindingSource;
        private WMSDataSetTableAdapters.SelectAllProductsOnAddressesTableAdapter selectAllProductsOnAddressesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyInD1;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyInD2;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyInD3;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityMax;
        private System.Windows.Forms.BindingSource selectAddressesOfProductBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private WMSDataSetTableAdapters.SelectAddressesOfProductTableAdapter selectAddressesOfProductTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCode;
    }
}