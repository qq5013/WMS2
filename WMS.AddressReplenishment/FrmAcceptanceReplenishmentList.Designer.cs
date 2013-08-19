namespace WMS.AddressReplenishment
{
    partial class FrmAcceptanceReplenishmentList
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colInTranzit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.replenishmentListInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.AddressReplenishment.WMSDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateExecuted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_PartRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNeedQtyByRotation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyToMigrate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnalysis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressStringFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyOnAddressFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressIdFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressStringTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressIdTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyOnAddressTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_RowDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.replenishmentListInfoTableAdapter = new WMS.AddressReplenishment.WMSDataSetTableAdapters.ReplenishmentListInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replenishmentListInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colInTranzit
            // 
            this.colInTranzit.Caption = "В транзите";
            this.colInTranzit.FieldName = "InTranzit";
            this.colInTranzit.Name = "colInTranzit";
            this.colInTranzit.OptionsColumn.ReadOnly = true;
            this.colInTranzit.Visible = true;
            this.colInTranzit.VisibleIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.replenishmentListInfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1202, 355);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // replenishmentListInfoBindingSource
            // 
            this.replenishmentListInfoBindingSource.DataMember = "ReplenishmentListInfo";
            this.replenishmentListInfoBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocNumber,
            this.colDocDate,
            this.colDateExecuted,
            this.colId_Product,
            this.colId_PartRow,
            this.colBarcode,
            this.colDescription_Product,
            this.colNeedQtyByRotation,
            this.colQtyToMigrate,
            this.colSeries,
            this.colAnalysis,
            this.colExpirationDate,
            this.colAddressStringFrom,
            this.colQtyOnAddressFrom,
            this.colAddressIdFrom,
            this.colAddressStringTo,
            this.colAddressIdTo,
            this.colQtyOnAddressTo,
            this.colInTranzit,
            this.colID_Doc,
            this.colID_RowDoc});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colInTranzit;
            styleFormatCondition1.Tag = true;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colInTranzit;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Tag = false;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 40;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId_PartRow, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDocNumber
            // 
            this.colDocNumber.FieldName = "DocNumber";
            this.colDocNumber.Name = "colDocNumber";
            // 
            // colDocDate
            // 
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            // 
            // colDateExecuted
            // 
            this.colDateExecuted.FieldName = "DateExecuted";
            this.colDateExecuted.Name = "colDateExecuted";
            // 
            // colId_Product
            // 
            this.colId_Product.Caption = "Артикул";
            this.colId_Product.FieldName = "Id_Product";
            this.colId_Product.Name = "colId_Product";
            this.colId_Product.Visible = true;
            this.colId_Product.VisibleIndex = 4;
            // 
            // colId_PartRow
            // 
            this.colId_PartRow.Caption = "Код партии";
            this.colId_PartRow.FieldName = "Id_PartRow";
            this.colId_PartRow.Name = "colId_PartRow";
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Бар код";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 5;
            // 
            // colDescription_Product
            // 
            this.colDescription_Product.Caption = "Название";
            this.colDescription_Product.FieldName = "Description_Product";
            this.colDescription_Product.Name = "colDescription_Product";
            this.colDescription_Product.Visible = true;
            this.colDescription_Product.VisibleIndex = 6;
            // 
            // colNeedQtyByRotation
            // 
            this.colNeedQtyByRotation.Caption = "Ротация";
            this.colNeedQtyByRotation.FieldName = "NeedQtyByRotation";
            this.colNeedQtyByRotation.Name = "colNeedQtyByRotation";
            this.colNeedQtyByRotation.Visible = true;
            this.colNeedQtyByRotation.VisibleIndex = 8;
            // 
            // colQtyToMigrate
            // 
            this.colQtyToMigrate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQtyToMigrate.AppearanceCell.Options.UseFont = true;
            this.colQtyToMigrate.Caption = "Кол-во для перемещения";
            this.colQtyToMigrate.FieldName = "QtyToMigrate";
            this.colQtyToMigrate.Name = "colQtyToMigrate";
            this.colQtyToMigrate.Visible = true;
            this.colQtyToMigrate.VisibleIndex = 7;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 9;
            // 
            // colAnalysis
            // 
            this.colAnalysis.Caption = "Анализ";
            this.colAnalysis.FieldName = "Analysis";
            this.colAnalysis.Name = "colAnalysis";
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Срок годности";
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 10;
            // 
            // colAddressStringFrom
            // 
            this.colAddressStringFrom.Caption = "С адреса";
            this.colAddressStringFrom.FieldName = "AddressStringFrom";
            this.colAddressStringFrom.Name = "colAddressStringFrom";
            this.colAddressStringFrom.Visible = true;
            this.colAddressStringFrom.VisibleIndex = 0;
            // 
            // colQtyOnAddressFrom
            // 
            this.colQtyOnAddressFrom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQtyOnAddressFrom.AppearanceCell.Options.UseFont = true;
            this.colQtyOnAddressFrom.Caption = "С адреса в количестве";
            this.colQtyOnAddressFrom.FieldName = "QtyOnAddressFrom";
            this.colQtyOnAddressFrom.Name = "colQtyOnAddressFrom";
            this.colQtyOnAddressFrom.Visible = true;
            this.colQtyOnAddressFrom.VisibleIndex = 1;
            // 
            // colAddressIdFrom
            // 
            this.colAddressIdFrom.FieldName = "AddressIdFrom";
            this.colAddressIdFrom.Name = "colAddressIdFrom";
            // 
            // colAddressStringTo
            // 
            this.colAddressStringTo.Caption = "На адрес";
            this.colAddressStringTo.FieldName = "AddressStringTo";
            this.colAddressStringTo.Name = "colAddressStringTo";
            this.colAddressStringTo.OptionsColumn.ReadOnly = true;
            this.colAddressStringTo.Visible = true;
            this.colAddressStringTo.VisibleIndex = 2;
            // 
            // colAddressIdTo
            // 
            this.colAddressIdTo.FieldName = "AddressIdTo";
            this.colAddressIdTo.Name = "colAddressIdTo";
            // 
            // colQtyOnAddressTo
            // 
            this.colQtyOnAddressTo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQtyOnAddressTo.AppearanceCell.Options.UseFont = true;
            this.colQtyOnAddressTo.Caption = "На адрес количество";
            this.colQtyOnAddressTo.FieldName = "QtyOnAddressTo";
            this.colQtyOnAddressTo.Name = "colQtyOnAddressTo";
            this.colQtyOnAddressTo.Visible = true;
            this.colQtyOnAddressTo.VisibleIndex = 3;
            // 
            // colID_Doc
            // 
            this.colID_Doc.FieldName = "ID_Doc";
            this.colID_Doc.Name = "colID_Doc";
            this.colID_Doc.OptionsColumn.ReadOnly = true;
            // 
            // colID_RowDoc
            // 
            this.colID_RowDoc.FieldName = "ID_RowDoc";
            this.colID_RowDoc.Name = "colID_RowDoc";
            this.colID_RowDoc.OptionsColumn.ReadOnly = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1206, 75);
            this.panelControl1.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(178, 39);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 3;
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата документа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер документа";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 75);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1206, 359);
            this.panelControl2.TabIndex = 2;
            // 
            // replenishmentListInfoTableAdapter
            // 
            this.replenishmentListInfoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAcceptanceReplenishmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 434);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAcceptanceReplenishmentList";
            this.Text = "Приёмка заказов на перемещение";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replenishmentListInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource replenishmentListInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateExecuted;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colId_PartRow;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colNeedQtyByRotation;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyToMigrate;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colAnalysis;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressStringFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyOnAddressFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressIdFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressStringTo;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressIdTo;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyOnAddressTo;
        private DevExpress.XtraGrid.Columns.GridColumn colInTranzit;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn colID_RowDoc;
        private WMSDataSetTableAdapters.ReplenishmentListInfoTableAdapter replenishmentListInfoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}