namespace WMS.AddressAsignment
{
    partial class FrmDirGoods
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getDirSellGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsFromSystemDataSet = new WMS.AddressAsignment.PartsFromSystemDataSet();
            this.goodsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.getDirSellGoodsTableAdapter = new WMS.AddressAsignment.PartsFromSystemDataSetTableAdapters.GetDirSellGoodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDirSellGoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsFromSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1004, 593);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.getDirSellGoodsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.goodsGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1000, 589);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.goodsGridView});
            // 
            // getDirSellGoodsBindingSource
            // 
            this.getDirSellGoodsBindingSource.DataMember = "GetDirSellGoods";
            this.getDirSellGoodsBindingSource.DataSource = this.partsFromSystemDataSet;
            // 
            // partsFromSystemDataSet
            // 
            this.partsFromSystemDataSet.DataSetName = "PartsFromSystemDataSet";
            this.partsFromSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsGridView
            // 
            this.goodsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colBarCode,
            this.colDescription,
            this.colQty,
            this.colNDS});
            this.goodsGridView.GridControl = this.gridControl1;
            this.goodsGridView.Name = "goodsGridView";
            this.goodsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.goodsGridView.OptionsBehavior.Editable = false;
            this.goodsGridView.OptionsView.ColumnAutoWidth = false;
            this.goodsGridView.OptionsView.ShowAutoFilterRow = true;
            this.goodsGridView.OptionsView.ShowGroupPanel = false;
            this.goodsGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.goodsGridView_KeyDown);
            this.goodsGridView.DoubleClick += new System.EventHandler(this.goodsGridView_DoubleClick);
            // 
            // colID
            // 
            this.colID.Caption = "Артикул";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 64;
            // 
            // colBarCode
            // 
            this.colBarCode.Caption = "Бар код";
            this.colBarCode.FieldName = "BarCode";
            this.colBarCode.Name = "colBarCode";
            this.colBarCode.Visible = true;
            this.colBarCode.VisibleIndex = 1;
            this.colBarCode.Width = 96;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Наименование";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 456;
            // 
            // colQty
            // 
            this.colQty.Caption = "Количество в остатке";
            this.colQty.DisplayFormat.FormatString = "f";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.ReadOnly = true;
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 3;
            this.colQty.Width = 132;
            // 
            // colNDS
            // 
            this.colNDS.Caption = "Ставка НДС";
            this.colNDS.FieldName = "NDS";
            this.colNDS.Name = "colNDS";
            this.colNDS.OptionsColumn.ReadOnly = true;
            this.colNDS.Visible = true;
            this.colNDS.VisibleIndex = 4;
            this.colNDS.Width = 86;
            // 
            // getDirSellGoodsTableAdapter
            // 
            this.getDirSellGoodsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDirGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 593);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDirGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDirGoods";
            this.Load += new System.EventHandler(this.FrmDirGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDirSellGoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsFromSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView goodsGridView;
        private PartsFromSystemDataSet partsFromSystemDataSet;
        private System.Windows.Forms.BindingSource getDirSellGoodsBindingSource;
        private PartsFromSystemDataSetTableAdapters.GetDirSellGoodsTableAdapter getDirSellGoodsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colNDS;
    }
}