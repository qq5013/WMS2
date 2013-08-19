namespace WMS.AddressMigration
{
    partial class FrmAddressMigration
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colAddressMIgrationAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeAddressFromThisPart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bodyPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.addressGridControl = new DevExpress.XtraGrid.GridControl();
            this.asignmentAddressForSkuBindingSource = new System.Windows.Forms.BindingSource();
            this.addressMigrationWMSDataSet = new WMS.AddressMigration.AddressMigrationWMSDataSet();
            this.addressGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAddressMIgrationID_PartRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMIgrationQtyOfPart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMIgrationSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMIgrationAnalysis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMIgrationExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMIgrationQtyAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMIgrationDatePlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMigrationIDAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressMIgrationIdPartOfProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.freeAddressGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyAddressesForPartBindingSource = new System.Windows.Forms.BindingSource();
            this.freeAddressGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFreeAddresslID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeAddressWarehousesDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeAddressStreetsDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeAddressRaftDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeAddressShelfsDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeAddressShelfSpacesDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeAddressStringAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.topPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.cleanAddressButton = new DevExpress.XtraEditors.SimpleButton();
            this.moveAllQtyButton = new DevExpress.XtraEditors.SimpleButton();
            this.movePartialQtyButton = new DevExpress.XtraEditors.SimpleButton();
            this.skuDescriptionLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.findSkuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.asignmentAddressForSkuTableAdapter = new WMS.AddressMigration.AddressMigrationWMSDataSetTableAdapters.AsignmentAddressForSkuTableAdapter();
            this.emptyAddressesForPartTableAdapter = new WMS.AddressMigration.AddressMigrationWMSDataSetTableAdapters.EmptyAddressesForPartTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).BeginInit();
            this.bodyPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignmentAddressForSkuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMigrationWMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeAddressGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptyAddressesForPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeAddressGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).BeginInit();
            this.topPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSkuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colAddressMIgrationAddress
            // 
            this.colAddressMIgrationAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressMIgrationAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressMIgrationAddress.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddressMIgrationAddress.Caption = "Адрес";
            this.colAddressMIgrationAddress.FieldName = "Address";
            this.colAddressMIgrationAddress.Name = "colAddressMIgrationAddress";
            this.colAddressMIgrationAddress.OptionsColumn.ReadOnly = true;
            this.colAddressMIgrationAddress.Visible = true;
            this.colAddressMIgrationAddress.VisibleIndex = 5;
            this.colAddressMIgrationAddress.Width = 99;
            // 
            // colFreeAddressFromThisPart
            // 
            this.colFreeAddressFromThisPart.FieldName = "FromThisPart";
            this.colFreeAddressFromThisPart.Name = "colFreeAddressFromThisPart";
            this.colFreeAddressFromThisPart.OptionsColumn.ReadOnly = true;
            // 
            // bodyPanelControl
            // 
            this.bodyPanelControl.Controls.Add(this.splitContainerControl1);
            this.bodyPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanelControl.Location = new System.Drawing.Point(0, 97);
            this.bodyPanelControl.Name = "bodyPanelControl";
            this.bodyPanelControl.Size = new System.Drawing.Size(1140, 451);
            this.bodyPanelControl.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.addressGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.freeAddressGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1136, 447);
            this.splitContainerControl1.SplitterPosition = 611;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // addressGridControl
            // 
            this.addressGridControl.DataSource = this.asignmentAddressForSkuBindingSource;
            this.addressGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressGridControl.Location = new System.Drawing.Point(0, 0);
            this.addressGridControl.MainView = this.addressGridView;
            this.addressGridControl.Name = "addressGridControl";
            this.addressGridControl.Size = new System.Drawing.Size(611, 447);
            this.addressGridControl.TabIndex = 0;
            this.addressGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.addressGridView});
            // 
            // asignmentAddressForSkuBindingSource
            // 
            this.asignmentAddressForSkuBindingSource.DataMember = "AsignmentAddressForSku";
            this.asignmentAddressForSkuBindingSource.DataSource = this.addressMigrationWMSDataSet;
            // 
            // addressMigrationWMSDataSet
            // 
            this.addressMigrationWMSDataSet.DataSetName = "AddressMigrationWMSDataSet";
            this.addressMigrationWMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressGridView
            // 
            this.addressGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.addressGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.addressGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAddressMIgrationID_PartRow,
            this.colAddressMIgrationQtyOfPart,
            this.colAddressMIgrationSeries,
            this.colAddressMIgrationAnalysis,
            this.colAddressMIgrationExpirationDate,
            this.colAddressMIgrationQtyAddress,
            this.colAddressMIgrationDatePlace,
            this.colAddressMIgrationAddress,
            this.colAddressMigrationIDAddress,
            this.colAddressMIgrationIdPartOfProduct});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Aquamarine;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colAddressMIgrationAddress;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[Address] like \'D1%\'";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Khaki;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition2.Appearance.Options.HighPriority = true;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colAddressMIgrationAddress;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[Address] like \'D2%\'";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Coral;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition3.Appearance.Options.HighPriority = true;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Column = this.colAddressMIgrationAddress;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[Address] like \'D3%\'";
            this.addressGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.addressGridView.GridControl = this.addressGridControl;
            this.addressGridView.GroupCount = 1;
            this.addressGridView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.addressGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", this.colAddressMIgrationQtyOfPart, "")});
            this.addressGridView.Name = "addressGridView";
            this.addressGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.addressGridView.OptionsBehavior.Editable = false;
            this.addressGridView.OptionsView.AllowHtmlDrawHeaders = true;
            this.addressGridView.OptionsView.ColumnAutoWidth = false;
            this.addressGridView.OptionsView.ShowAutoFilterRow = true;
            this.addressGridView.OptionsView.ShowFooter = true;
            this.addressGridView.OptionsView.ShowGroupPanel = false;
            this.addressGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAddressMIgrationID_PartRow, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.addressGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.AddressGridViewFocusedRowChanged);
            // 
            // colAddressMIgrationID_PartRow
            // 
            this.colAddressMIgrationID_PartRow.Caption = "Код партии";
            this.colAddressMIgrationID_PartRow.FieldName = "ID_PartRow";
            this.colAddressMIgrationID_PartRow.Name = "colAddressMIgrationID_PartRow";
            // 
            // colAddressMIgrationQtyOfPart
            // 
            this.colAddressMIgrationQtyOfPart.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressMIgrationQtyOfPart.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressMIgrationQtyOfPart.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddressMIgrationQtyOfPart.Caption = "Количество \nпартии";
            this.colAddressMIgrationQtyOfPart.DisplayFormat.FormatString = "f";
            this.colAddressMIgrationQtyOfPart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAddressMIgrationQtyOfPart.FieldName = "QtyOfPart";
            this.colAddressMIgrationQtyOfPart.Name = "colAddressMIgrationQtyOfPart";
            this.colAddressMIgrationQtyOfPart.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colAddressMIgrationQtyOfPart.Visible = true;
            this.colAddressMIgrationQtyOfPart.VisibleIndex = 0;
            this.colAddressMIgrationQtyOfPart.Width = 78;
            // 
            // colAddressMIgrationSeries
            // 
            this.colAddressMIgrationSeries.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressMIgrationSeries.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressMIgrationSeries.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddressMIgrationSeries.Caption = "Серия";
            this.colAddressMIgrationSeries.FieldName = "Series";
            this.colAddressMIgrationSeries.Name = "colAddressMIgrationSeries";
            this.colAddressMIgrationSeries.Visible = true;
            this.colAddressMIgrationSeries.VisibleIndex = 1;
            this.colAddressMIgrationSeries.Width = 63;
            // 
            // colAddressMIgrationAnalysis
            // 
            this.colAddressMIgrationAnalysis.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressMIgrationAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressMIgrationAnalysis.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddressMIgrationAnalysis.Caption = "Анализ";
            this.colAddressMIgrationAnalysis.FieldName = "Analysis";
            this.colAddressMIgrationAnalysis.Name = "colAddressMIgrationAnalysis";
            this.colAddressMIgrationAnalysis.Visible = true;
            this.colAddressMIgrationAnalysis.VisibleIndex = 2;
            this.colAddressMIgrationAnalysis.Width = 62;
            // 
            // colAddressMIgrationExpirationDate
            // 
            this.colAddressMIgrationExpirationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressMIgrationExpirationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressMIgrationExpirationDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddressMIgrationExpirationDate.Caption = "Срок \nгодности";
            this.colAddressMIgrationExpirationDate.FieldName = "ExpirationDate";
            this.colAddressMIgrationExpirationDate.Name = "colAddressMIgrationExpirationDate";
            this.colAddressMIgrationExpirationDate.Visible = true;
            this.colAddressMIgrationExpirationDate.VisibleIndex = 3;
            this.colAddressMIgrationExpirationDate.Width = 66;
            // 
            // colAddressMIgrationQtyAddress
            // 
            this.colAddressMIgrationQtyAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressMIgrationQtyAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressMIgrationQtyAddress.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddressMIgrationQtyAddress.Caption = "Количество \n на адресе";
            this.colAddressMIgrationQtyAddress.DisplayFormat.FormatString = "f";
            this.colAddressMIgrationQtyAddress.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAddressMIgrationQtyAddress.FieldName = "QtyAddress";
            this.colAddressMIgrationQtyAddress.Name = "colAddressMIgrationQtyAddress";
            this.colAddressMIgrationQtyAddress.Visible = true;
            this.colAddressMIgrationQtyAddress.VisibleIndex = 4;
            this.colAddressMIgrationQtyAddress.Width = 77;
            // 
            // colAddressMIgrationDatePlace
            // 
            this.colAddressMIgrationDatePlace.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressMIgrationDatePlace.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressMIgrationDatePlace.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAddressMIgrationDatePlace.Caption = "Дата \nустановки \nадреса";
            this.colAddressMIgrationDatePlace.DisplayFormat.FormatString = "G";
            this.colAddressMIgrationDatePlace.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAddressMIgrationDatePlace.FieldName = "DatePlace";
            this.colAddressMIgrationDatePlace.Name = "colAddressMIgrationDatePlace";
            this.colAddressMIgrationDatePlace.Visible = true;
            this.colAddressMIgrationDatePlace.VisibleIndex = 6;
            this.colAddressMIgrationDatePlace.Width = 79;
            // 
            // colAddressMigrationIDAddress
            // 
            this.colAddressMigrationIDAddress.Caption = "Код адреса";
            this.colAddressMigrationIDAddress.FieldName = "ID_Address";
            this.colAddressMigrationIDAddress.Name = "colAddressMigrationIDAddress";
            // 
            // colAddressMIgrationIdPartOfProduct
            // 
            this.colAddressMIgrationIdPartOfProduct.Caption = "Код партии";
            this.colAddressMIgrationIdPartOfProduct.FieldName = "ID_PartOfProduct";
            this.colAddressMIgrationIdPartOfProduct.Name = "colAddressMIgrationIdPartOfProduct";
            // 
            // freeAddressGridControl
            // 
            this.freeAddressGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.freeAddressGridControl.DataSource = this.emptyAddressesForPartBindingSource;
            this.freeAddressGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeAddressGridControl.Location = new System.Drawing.Point(0, 0);
            this.freeAddressGridControl.MainView = this.freeAddressGridView;
            this.freeAddressGridControl.Name = "freeAddressGridControl";
            this.freeAddressGridControl.Size = new System.Drawing.Size(520, 447);
            this.freeAddressGridControl.TabIndex = 0;
            this.freeAddressGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.freeAddressGridView});
            this.freeAddressGridControl.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuItem1.Text = "Копировать адрес";
            // 
            // emptyAddressesForPartBindingSource
            // 
            this.emptyAddressesForPartBindingSource.DataMember = "EmptyAddressesForPart";
            this.emptyAddressesForPartBindingSource.DataSource = this.addressMigrationWMSDataSet;
            // 
            // freeAddressGridView
            // 
            this.freeAddressGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFreeAddresslID,
            this.colFreeAddressWarehousesDescription,
            this.colFreeAddressStreetsDescription,
            this.colFreeAddressRaftDescription,
            this.colFreeAddressShelfsDescription,
            this.colFreeAddressShelfSpacesDescription,
            this.colFreeAddressStringAddress,
            this.colFreeAddressFromThisPart});
            styleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition4.Appearance.Options.UseBackColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.colFreeAddressFromThisPart;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = 1;
            styleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition5.Appearance.Options.UseBackColor = true;
            styleFormatCondition5.ApplyToRow = true;
            styleFormatCondition5.Column = this.colFreeAddressFromThisPart;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition5.Value1 = 0;
            this.freeAddressGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition4,
            styleFormatCondition5});
            this.freeAddressGridView.GridControl = this.freeAddressGridControl;
            this.freeAddressGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", this.colFreeAddressWarehousesDescription, "")});
            this.freeAddressGridView.Name = "freeAddressGridView";
            this.freeAddressGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.freeAddressGridView.OptionsBehavior.Editable = false;
            this.freeAddressGridView.OptionsView.ColumnAutoWidth = false;
            this.freeAddressGridView.OptionsView.ShowAutoFilterRow = true;
            this.freeAddressGridView.OptionsView.ShowFooter = true;
            this.freeAddressGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colFreeAddresslID
            // 
            this.colFreeAddresslID.FieldName = "ID";
            this.colFreeAddresslID.Name = "colFreeAddresslID";
            this.colFreeAddresslID.OptionsColumn.ReadOnly = true;
            // 
            // colFreeAddressWarehousesDescription
            // 
            this.colFreeAddressWarehousesDescription.Caption = "Склад";
            this.colFreeAddressWarehousesDescription.FieldName = "WarehousesDescription";
            this.colFreeAddressWarehousesDescription.Name = "colFreeAddressWarehousesDescription";
            this.colFreeAddressWarehousesDescription.OptionsColumn.ReadOnly = true;
            this.colFreeAddressWarehousesDescription.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colFreeAddressWarehousesDescription.Visible = true;
            this.colFreeAddressWarehousesDescription.VisibleIndex = 0;
            // 
            // colFreeAddressStreetsDescription
            // 
            this.colFreeAddressStreetsDescription.Caption = "Улица";
            this.colFreeAddressStreetsDescription.FieldName = "StreetsDescription";
            this.colFreeAddressStreetsDescription.Name = "colFreeAddressStreetsDescription";
            this.colFreeAddressStreetsDescription.OptionsColumn.ReadOnly = true;
            this.colFreeAddressStreetsDescription.Visible = true;
            this.colFreeAddressStreetsDescription.VisibleIndex = 1;
            // 
            // colFreeAddressRaftDescription
            // 
            this.colFreeAddressRaftDescription.Caption = "Стелаж";
            this.colFreeAddressRaftDescription.FieldName = "RaftDescription";
            this.colFreeAddressRaftDescription.Name = "colFreeAddressRaftDescription";
            this.colFreeAddressRaftDescription.OptionsColumn.ReadOnly = true;
            this.colFreeAddressRaftDescription.Visible = true;
            this.colFreeAddressRaftDescription.VisibleIndex = 2;
            // 
            // colFreeAddressShelfsDescription
            // 
            this.colFreeAddressShelfsDescription.Caption = "Полка";
            this.colFreeAddressShelfsDescription.FieldName = "ShelfsDescription";
            this.colFreeAddressShelfsDescription.Name = "colFreeAddressShelfsDescription";
            this.colFreeAddressShelfsDescription.OptionsColumn.ReadOnly = true;
            this.colFreeAddressShelfsDescription.Visible = true;
            this.colFreeAddressShelfsDescription.VisibleIndex = 3;
            // 
            // colFreeAddressShelfSpacesDescription
            // 
            this.colFreeAddressShelfSpacesDescription.Caption = "Место ";
            this.colFreeAddressShelfSpacesDescription.FieldName = "ShelfSpacesDescription";
            this.colFreeAddressShelfSpacesDescription.Name = "colFreeAddressShelfSpacesDescription";
            this.colFreeAddressShelfSpacesDescription.OptionsColumn.ReadOnly = true;
            this.colFreeAddressShelfSpacesDescription.Visible = true;
            this.colFreeAddressShelfSpacesDescription.VisibleIndex = 4;
            // 
            // colFreeAddressStringAddress
            // 
            this.colFreeAddressStringAddress.Caption = "Адрес";
            this.colFreeAddressStringAddress.FieldName = "stringAddress";
            this.colFreeAddressStringAddress.Name = "colFreeAddressStringAddress";
            this.colFreeAddressStringAddress.OptionsColumn.ReadOnly = true;
            this.colFreeAddressStringAddress.Visible = true;
            this.colFreeAddressStringAddress.VisibleIndex = 5;
            // 
            // topPanelControl
            // 
            this.topPanelControl.Controls.Add(this.cleanAddressButton);
            this.topPanelControl.Controls.Add(this.moveAllQtyButton);
            this.topPanelControl.Controls.Add(this.movePartialQtyButton);
            this.topPanelControl.Controls.Add(this.skuDescriptionLabelControl);
            this.topPanelControl.Controls.Add(this.labelControl1);
            this.topPanelControl.Controls.Add(this.findSkuTextEdit);
            this.topPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelControl.Location = new System.Drawing.Point(0, 0);
            this.topPanelControl.Name = "topPanelControl";
            this.topPanelControl.Size = new System.Drawing.Size(1140, 97);
            this.topPanelControl.TabIndex = 1;
            // 
            // cleanAddressButton
            // 
            this.cleanAddressButton.Enabled = false;
            this.cleanAddressButton.Location = new System.Drawing.Point(312, 57);
            this.cleanAddressButton.Name = "cleanAddressButton";
            this.cleanAddressButton.Size = new System.Drawing.Size(90, 34);
            this.cleanAddressButton.TabIndex = 5;
            this.cleanAddressButton.Text = "Очистить\r\nадрес";
            this.cleanAddressButton.Click += new System.EventHandler(this.CleanAddressButtonClick);
            // 
            // moveAllQtyButton
            // 
            this.moveAllQtyButton.Enabled = false;
            this.moveAllQtyButton.Location = new System.Drawing.Point(167, 57);
            this.moveAllQtyButton.Name = "moveAllQtyButton";
            this.moveAllQtyButton.Size = new System.Drawing.Size(121, 34);
            this.moveAllQtyButton.TabIndex = 4;
            this.moveAllQtyButton.Text = "Переместить всё\r\nколичество";
            this.moveAllQtyButton.Click += new System.EventHandler(this.MoveAllQtyButtonClick);
            // 
            // movePartialQtyButton
            // 
            this.movePartialQtyButton.Enabled = false;
            this.movePartialQtyButton.Location = new System.Drawing.Point(13, 57);
            this.movePartialQtyButton.Name = "movePartialQtyButton";
            this.movePartialQtyButton.Size = new System.Drawing.Size(128, 34);
            this.movePartialQtyButton.TabIndex = 3;
            this.movePartialQtyButton.Text = "Переместить часть \r\nколичества";
            this.movePartialQtyButton.Click += new System.EventHandler(this.MovePartialQtyButtonClick);
            // 
            // skuDescriptionLabelControl
            // 
            this.skuDescriptionLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.skuDescriptionLabelControl.Location = new System.Drawing.Point(350, 17);
            this.skuDescriptionLabelControl.Name = "skuDescriptionLabelControl";
            this.skuDescriptionLabelControl.Size = new System.Drawing.Size(15, 21);
            this.skuDescriptionLabelControl.TabIndex = 2;
            this.skuDescriptionLabelControl.Text = "...";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Арикул / Бар код / Адрес";
            // 
            // findSkuTextEdit
            // 
            this.findSkuTextEdit.EditValue = "";
            this.findSkuTextEdit.Location = new System.Drawing.Point(147, 12);
            this.findSkuTextEdit.Name = "findSkuTextEdit";
            this.findSkuTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.findSkuTextEdit.Properties.Appearance.Options.UseFont = true;
            this.findSkuTextEdit.Size = new System.Drawing.Size(194, 31);
            this.findSkuTextEdit.TabIndex = 0;
            this.findSkuTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindSkuTextEditKeyDown);
            // 
            // asignmentAddressForSkuTableAdapter
            // 
            this.asignmentAddressForSkuTableAdapter.ClearBeforeFill = true;
            // 
            // emptyAddressesForPartTableAdapter
            // 
            this.emptyAddressesForPartTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddressMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 548);
            this.Controls.Add(this.bodyPanelControl);
            this.Controls.Add(this.topPanelControl);
            this.Name = "FrmAddressMigration";
            this.Text = "Перемещение партий по адресам";
            this.Load += new System.EventHandler(this.FrmAddressMigrationLoad);
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).EndInit();
            this.bodyPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignmentAddressForSkuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMigrationWMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeAddressGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptyAddressesForPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeAddressGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).EndInit();
            this.topPanelControl.ResumeLayout(false);
            this.topPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSkuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl bodyPanelControl;
        private DevExpress.XtraEditors.PanelControl topPanelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit findSkuTextEdit;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl addressGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView addressGridView;
        private DevExpress.XtraGrid.GridControl freeAddressGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView freeAddressGridView;
        private AddressMigrationWMSDataSet addressMigrationWMSDataSet;
        private System.Windows.Forms.BindingSource asignmentAddressForSkuBindingSource;
        private AddressMigrationWMSDataSetTableAdapters.AsignmentAddressForSkuTableAdapter asignmentAddressForSkuTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationID_PartRow;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationQtyOfPart;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationAnalysis;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationQtyAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationDatePlace;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationAddress;
        private System.Windows.Forms.BindingSource emptyAddressesForPartBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeAddresslID;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeAddressWarehousesDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeAddressStreetsDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeAddressRaftDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeAddressShelfsDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeAddressShelfSpacesDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeAddressStringAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeAddressFromThisPart;
        private AddressMigrationWMSDataSetTableAdapters.EmptyAddressesForPartTableAdapter emptyAddressesForPartTableAdapter;
        private DevExpress.XtraEditors.LabelControl skuDescriptionLabelControl;
        private DevExpress.XtraEditors.SimpleButton moveAllQtyButton;
        private DevExpress.XtraEditors.SimpleButton movePartialQtyButton;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMigrationIDAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressMIgrationIdPartOfProduct;
        private DevExpress.XtraEditors.SimpleButton cleanAddressButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;


    }
}
