namespace WMS.AddressReplenishment
{
    partial class FrmAddressReplenishment
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
            this.colExecuted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.runAnalyseButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.applyButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.orderForReplenishmentGridControl = new DevExpress.XtraGrid.GridControl();
            this.docsOrderForReplenishmentBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.AddressReplenishment.WMSDataSet();
            this.orderForReplenishmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDateExecuted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rowsOrderForReplenishmentGridControl = new DevExpress.XtraGrid.GridControl();
            this.docsRowsOrderForReplenishmentBindingSource = new System.Windows.Forms.BindingSource();
            this.rowsOrderForReplenishmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_PartRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNeedQtyByRotation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyToMigrate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnalysis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.docsOrderForReplenishmentTableAdapter = new WMS.AddressReplenishment.WMSDataSetTableAdapters.DocsOrderForReplenishmentTableAdapter();
            this.docsRowsOrderForReplenishmentTableAdapter = new WMS.AddressReplenishment.WMSDataSetTableAdapters.DocsRowsOrderForReplenishmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderForReplenishmentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsOrderForReplenishmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderForReplenishmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsOrderForReplenishmentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsRowsOrderForReplenishmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsOrderForReplenishmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // colExecuted
            // 
            this.colExecuted.Caption = "Исполнен";
            this.colExecuted.FieldName = "Executed";
            this.colExecuted.Name = "colExecuted";
            this.colExecuted.Visible = true;
            this.colExecuted.VisibleIndex = 0;
            this.colExecuted.Width = 58;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.runAnalyseButton);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.applyButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(950, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // runAnalyseButton
            // 
            this.runAnalyseButton.Location = new System.Drawing.Point(107, 12);
            this.runAnalyseButton.Name = "runAnalyseButton";
            this.runAnalyseButton.Size = new System.Drawing.Size(142, 23);
            this.runAnalyseButton.TabIndex = 2;
            this.runAnalyseButton.Text = "Анализировать остатки";
            this.runAnalyseButton.Click += new System.EventHandler(this.RunAnalyseButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(579, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Дизайнер";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(12, 12);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Исполнить";
            this.applyButton.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.splitContainerControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 47);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(950, 503);
            this.panelControl2.TabIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.orderForReplenishmentGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.rowsOrderForReplenishmentGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(946, 499);
            this.splitContainerControl1.SplitterPosition = 272;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // orderForReplenishmentGridControl
            // 
            this.orderForReplenishmentGridControl.DataSource = this.docsOrderForReplenishmentBindingSource;
            this.orderForReplenishmentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderForReplenishmentGridControl.Location = new System.Drawing.Point(0, 0);
            this.orderForReplenishmentGridControl.MainView = this.orderForReplenishmentGridView;
            this.orderForReplenishmentGridControl.Name = "orderForReplenishmentGridControl";
            this.orderForReplenishmentGridControl.Size = new System.Drawing.Size(946, 272);
            this.orderForReplenishmentGridControl.TabIndex = 0;
            this.orderForReplenishmentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.orderForReplenishmentGridView});
            // 
            // docsOrderForReplenishmentBindingSource
            // 
            this.docsOrderForReplenishmentBindingSource.DataMember = "DocsOrderForReplenishment";
            this.docsOrderForReplenishmentBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderForReplenishmentGridView
            // 
            this.orderForReplenishmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDocNumber,
            this.colDocDate,
            this.colDocDateExecuted,
            this.colDocOwner,
            this.colDocType,
            this.colExecuted});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colExecuted;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colExecuted;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = false;
            this.orderForReplenishmentGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.orderForReplenishmentGridView.GridControl = this.orderForReplenishmentGridControl;
            this.orderForReplenishmentGridView.Name = "orderForReplenishmentGridView";
            this.orderForReplenishmentGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.orderForReplenishmentGridView.OptionsBehavior.Editable = false;
            this.orderForReplenishmentGridView.OptionsView.ColumnAutoWidth = false;
            this.orderForReplenishmentGridView.OptionsView.ShowAutoFilterRow = true;
            this.orderForReplenishmentGridView.OptionsView.ShowGroupPanel = false;
            this.orderForReplenishmentGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.OrderForReplenishmentGridViewFocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colDocNumber
            // 
            this.colDocNumber.Caption = "Номер документа";
            this.colDocNumber.FieldName = "DocNumber";
            this.colDocNumber.Name = "colDocNumber";
            this.colDocNumber.Visible = true;
            this.colDocNumber.VisibleIndex = 1;
            this.colDocNumber.Width = 101;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Дата документа";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 2;
            this.colDocDate.Width = 99;
            // 
            // colDocDateExecuted
            // 
            this.colDocDateExecuted.Caption = "Дата исполнения";
            this.colDocDateExecuted.DisplayFormat.FormatString = "G";
            this.colDocDateExecuted.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDocDateExecuted.FieldName = "DateExecuted";
            this.colDocDateExecuted.Name = "colDocDateExecuted";
            this.colDocDateExecuted.Visible = true;
            this.colDocDateExecuted.VisibleIndex = 3;
            this.colDocDateExecuted.Width = 100;
            // 
            // colDocOwner
            // 
            this.colDocOwner.Caption = "Создатель документа";
            this.colDocOwner.FieldName = "DocOwner";
            this.colDocOwner.Name = "colDocOwner";
            this.colDocOwner.Visible = true;
            this.colDocOwner.VisibleIndex = 4;
            this.colDocOwner.Width = 150;
            // 
            // colDocType
            // 
            this.colDocType.Caption = "Тип документа";
            this.colDocType.FieldName = "DocType";
            this.colDocType.Name = "colDocType";
            this.colDocType.Visible = true;
            this.colDocType.VisibleIndex = 5;
            this.colDocType.Width = 374;
            // 
            // rowsOrderForReplenishmentGridControl
            // 
            this.rowsOrderForReplenishmentGridControl.DataSource = this.docsRowsOrderForReplenishmentBindingSource;
            this.rowsOrderForReplenishmentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowsOrderForReplenishmentGridControl.Location = new System.Drawing.Point(0, 0);
            this.rowsOrderForReplenishmentGridControl.MainView = this.rowsOrderForReplenishmentGridView;
            this.rowsOrderForReplenishmentGridControl.Name = "rowsOrderForReplenishmentGridControl";
            this.rowsOrderForReplenishmentGridControl.Size = new System.Drawing.Size(946, 222);
            this.rowsOrderForReplenishmentGridControl.TabIndex = 0;
            this.rowsOrderForReplenishmentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rowsOrderForReplenishmentGridView});
            // 
            // docsRowsOrderForReplenishmentBindingSource
            // 
            this.docsRowsOrderForReplenishmentBindingSource.DataMember = "DocsRowsOrderForReplenishment";
            this.docsRowsOrderForReplenishmentBindingSource.DataSource = this.wMSDataSet;
            // 
            // rowsOrderForReplenishmentGridView
            // 
            this.rowsOrderForReplenishmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDRow,
            this.colId_Doc,
            this.colId_Product,
            this.colId_PartRow,
            this.colBarcode,
            this.colDescription_Product,
            this.colNeedQtyByRotation,
            this.colQtyToMigrate,
            this.colSeries,
            this.colAnalysis,
            this.colExpirationDate,
            this.colAddressFrom,
            this.colAddressTo});
            this.rowsOrderForReplenishmentGridView.GridControl = this.rowsOrderForReplenishmentGridControl;
            this.rowsOrderForReplenishmentGridView.Name = "rowsOrderForReplenishmentGridView";
            this.rowsOrderForReplenishmentGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.rowsOrderForReplenishmentGridView.OptionsBehavior.Editable = false;
            this.rowsOrderForReplenishmentGridView.OptionsView.AllowCellMerge = true;
            this.rowsOrderForReplenishmentGridView.OptionsView.ColumnAutoWidth = false;
            this.rowsOrderForReplenishmentGridView.OptionsView.ShowAutoFilterRow = true;
            this.rowsOrderForReplenishmentGridView.OptionsView.ShowFooter = true;
            this.rowsOrderForReplenishmentGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colIDRow
            // 
            this.colIDRow.FieldName = "ID";
            this.colIDRow.Name = "colIDRow";
            this.colIDRow.OptionsColumn.ReadOnly = true;
            // 
            // colId_Doc
            // 
            this.colId_Doc.FieldName = "Id_Doc";
            this.colId_Doc.Name = "colId_Doc";
            // 
            // colId_Product
            // 
            this.colId_Product.Caption = "Артикул";
            this.colId_Product.FieldName = "Id_Product";
            this.colId_Product.Name = "colId_Product";
            this.colId_Product.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colId_Product.Visible = true;
            this.colId_Product.VisibleIndex = 3;
            this.colId_Product.Width = 69;
            // 
            // colId_PartRow
            // 
            this.colId_PartRow.Caption = "Номер партии в системе";
            this.colId_PartRow.FieldName = "Id_PartRow";
            this.colId_PartRow.Name = "colId_PartRow";
            this.colId_PartRow.Visible = true;
            this.colId_PartRow.VisibleIndex = 2;
            this.colId_PartRow.Width = 154;
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Бар код";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 4;
            this.colBarcode.Width = 94;
            // 
            // colDescription_Product
            // 
            this.colDescription_Product.Caption = "Название товара";
            this.colDescription_Product.FieldName = "Description_Product";
            this.colDescription_Product.Name = "colDescription_Product";
            this.colDescription_Product.Visible = true;
            this.colDescription_Product.VisibleIndex = 5;
            this.colDescription_Product.Width = 200;
            // 
            // colNeedQtyByRotation
            // 
            this.colNeedQtyByRotation.Caption = "Нужное количество согласно расчёту";
            this.colNeedQtyByRotation.FieldName = "NeedQtyByRotation";
            this.colNeedQtyByRotation.Name = "colNeedQtyByRotation";
            this.colNeedQtyByRotation.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colNeedQtyByRotation.Visible = true;
            this.colNeedQtyByRotation.VisibleIndex = 6;
            this.colNeedQtyByRotation.Width = 212;
            // 
            // colQtyToMigrate
            // 
            this.colQtyToMigrate.Caption = "Количество для перемещения";
            this.colQtyToMigrate.FieldName = "QtyToMigrate";
            this.colQtyToMigrate.Name = "colQtyToMigrate";
            this.colQtyToMigrate.Visible = true;
            this.colQtyToMigrate.VisibleIndex = 7;
            this.colQtyToMigrate.Width = 173;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 8;
            // 
            // colAnalysis
            // 
            this.colAnalysis.Caption = "Анализ";
            this.colAnalysis.FieldName = "Analysis";
            this.colAnalysis.Name = "colAnalysis";
            this.colAnalysis.Visible = true;
            this.colAnalysis.VisibleIndex = 9;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Срок годности";
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 10;
            this.colExpirationDate.Width = 94;
            // 
            // colAddressFrom
            // 
            this.colAddressFrom.Caption = "С адреса";
            this.colAddressFrom.FieldName = "AddressFrom";
            this.colAddressFrom.Name = "colAddressFrom";
            this.colAddressFrom.Visible = true;
            this.colAddressFrom.VisibleIndex = 0;
            // 
            // colAddressTo
            // 
            this.colAddressTo.Caption = "На адрес";
            this.colAddressTo.FieldName = "AddressTo";
            this.colAddressTo.Name = "colAddressTo";
            this.colAddressTo.Visible = true;
            this.colAddressTo.VisibleIndex = 1;
            // 
            // docsOrderForReplenishmentTableAdapter
            // 
            this.docsOrderForReplenishmentTableAdapter.ClearBeforeFill = true;
            // 
            // docsRowsOrderForReplenishmentTableAdapter
            // 
            this.docsRowsOrderForReplenishmentTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddressReplenishment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAddressReplenishment";
            this.Text = "Пополнение остатков на адресах";
            this.Load += new System.EventHandler(this.FrmAddressReplenishmentLoad);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderForReplenishmentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsOrderForReplenishmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderForReplenishmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsOrderForReplenishmentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsRowsOrderForReplenishmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsOrderForReplenishmentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl orderForReplenishmentGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView orderForReplenishmentGridView;
        private DevExpress.XtraGrid.GridControl rowsOrderForReplenishmentGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView rowsOrderForReplenishmentGridView;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource docsOrderForReplenishmentBindingSource;
        private WMSDataSetTableAdapters.DocsOrderForReplenishmentTableAdapter docsOrderForReplenishmentTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDocOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colDocType;
        private System.Windows.Forms.BindingSource docsRowsOrderForReplenishmentBindingSource;
        private WMSDataSetTableAdapters.DocsRowsOrderForReplenishmentTableAdapter docsRowsOrderForReplenishmentTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDRow;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colId_PartRow;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colNeedQtyByRotation;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyToMigrate;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colAnalysis;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExecuted;
        private DevExpress.XtraEditors.SimpleButton applyButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDateExecuted;
        private DevExpress.XtraEditors.SimpleButton runAnalyseButton;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressTo;


    }
}
