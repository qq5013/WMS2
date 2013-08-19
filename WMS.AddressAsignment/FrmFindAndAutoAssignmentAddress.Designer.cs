namespace WMS.AddressAsignment
{
    partial class FrmFindAndAutoAssignmentAddress
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.productDescriptionLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.moveAllQtyButton = new DevExpress.XtraEditors.SimpleButton();
            this.qtySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.allowQtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.warehouseLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.findedAddressessGridControl = new DevExpress.XtraGrid.GridControl();
            this.findedAddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new WMS.AddressAsignment.WMSDataSet();
            this.findedAddressessGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForThisProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyBoxInCell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.neededTypeCellsGridControl = new DevExpress.XtraGrid.GridControl();
            this.neededTypeAndQtyCellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neededTypeCellsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeCell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeShelf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyCells = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyFullCels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyBoxInFullCells = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyBoxInNonCompleteCells = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowQtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findedAddressessGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedAddressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedAddressessGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neededTypeCellsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neededTypeAndQtyCellsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neededTypeCellsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.productDescriptionLabelControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1030, 94);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Размещяемый товар";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(37, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Товар: ";
            // 
            // productDescriptionLabelControl
            // 
            this.productDescriptionLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.productDescriptionLabelControl.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.productDescriptionLabelControl.Location = new System.Drawing.Point(37, 48);
            this.productDescriptionLabelControl.Name = "productDescriptionLabelControl";
            this.productDescriptionLabelControl.Size = new System.Drawing.Size(418, 19);
            this.productDescriptionLabelControl.TabIndex = 5;
            this.productDescriptionLabelControl.Text = "Biseptol susp. orala 200 mg + 40 mg/5 ml 80 ml N1";
            // 
            // cancelButton
            // 
            this.cancelButton.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cancelButton.Appearance.Options.UseFont = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(128, 212);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 34);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // okButton
            // 
            this.okButton.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.okButton.Appearance.Options.UseFont = true;
            this.okButton.Location = new System.Drawing.Point(12, 212);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(111, 34);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Искать ";
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // moveAllQtyButton
            // 
            this.moveAllQtyButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.moveAllQtyButton.Appearance.Options.UseFont = true;
            this.moveAllQtyButton.Location = new System.Drawing.Point(98, 152);
            this.moveAllQtyButton.Name = "moveAllQtyButton";
            this.moveAllQtyButton.Size = new System.Drawing.Size(50, 31);
            this.moveAllQtyButton.TabIndex = 2;
            this.moveAllQtyButton.Text = "> > >";
            this.moveAllQtyButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.moveAllQtyButton.ToolTipTitle = "Выбрать всё количество";
            // 
            // qtySpinEdit
            // 
            this.qtySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.qtySpinEdit.Location = new System.Drawing.Point(128, 115);
            this.qtySpinEdit.Name = "qtySpinEdit";
            this.qtySpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.qtySpinEdit.Properties.Appearance.Options.UseFont = true;
            this.qtySpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.qtySpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qtySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.qtySpinEdit.Size = new System.Drawing.Size(111, 31);
            this.qtySpinEdit.TabIndex = 1;
            // 
            // allowQtyTextEdit
            // 
            this.allowQtyTextEdit.EditValue = "1000";
            this.allowQtyTextEdit.Enabled = false;
            this.allowQtyTextEdit.Location = new System.Drawing.Point(13, 115);
            this.allowQtyTextEdit.Name = "allowQtyTextEdit";
            this.allowQtyTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.allowQtyTextEdit.Properties.Appearance.Options.UseFont = true;
            this.allowQtyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.allowQtyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.allowQtyTextEdit.Size = new System.Drawing.Size(111, 31);
            this.allowQtyTextEdit.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.AutoSize = true;
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.cancelButton);
            this.groupControl2.Controls.Add(this.okButton);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.warehouseLookUpEdit);
            this.groupControl2.Controls.Add(this.qtySpinEdit);
            this.groupControl2.Controls.Add(this.allowQtyTextEdit);
            this.groupControl2.Controls.Add(this.moveAllQtyButton);
            this.groupControl2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 94);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(251, 525);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Параметры для поиска";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(13, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(231, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Количество коробок для размещения: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(12, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Искать на складе: ";
            // 
            // warehouseLookUpEdit
            // 
            this.warehouseLookUpEdit.Location = new System.Drawing.Point(12, 53);
            this.warehouseLookUpEdit.Name = "warehouseLookUpEdit";
            this.warehouseLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.warehouseLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.warehouseLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseLookUpEdit.Properties.NullText = "[Выбирите склад для поиска]";
            this.warehouseLookUpEdit.Size = new System.Drawing.Size(201, 23);
            this.warehouseLookUpEdit.TabIndex = 6;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.Options.UseTextOptions = true;
            this.groupControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.groupControl3.AutoSize = true;
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl3.Location = new System.Drawing.Point(856, 94);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(174, 525);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Информация о товаре";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl10.Location = new System.Drawing.Point(39, 189);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(8, 16);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "С";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Location = new System.Drawing.Point(20, 167);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(83, 16);
            this.labelControl11.TabIndex = 13;
            this.labelControl11.Text = "Тип ротации: ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl8.Location = new System.Drawing.Point(39, 141);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 16);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "10";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Location = new System.Drawing.Point(20, 119);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(142, 16);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Минимальная ротация: ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(39, 97);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 16);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "35";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(20, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(147, 16);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Максимальная ротация: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelControl5.Location = new System.Drawing.Point(39, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "60 х 31 х 12";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(20, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Размеры (см): ";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl4.AutoSize = true;
            this.groupControl4.Controls.Add(this.findedAddressessGridControl);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(251, 94);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(605, 323);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Найденые варианты адресов";
            // 
            // findedAddressessGridControl
            // 
            this.findedAddressessGridControl.DataSource = this.findedAddressesBindingSource;
            this.findedAddressessGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findedAddressessGridControl.Location = new System.Drawing.Point(2, 22);
            this.findedAddressessGridControl.MainView = this.findedAddressessGridView;
            this.findedAddressessGridControl.Name = "findedAddressessGridControl";
            this.findedAddressessGridControl.Size = new System.Drawing.Size(601, 299);
            this.findedAddressessGridControl.TabIndex = 0;
            this.findedAddressessGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.findedAddressessGridView});
            // 
            // findedAddressesBindingSource
            // 
            this.findedAddressesBindingSource.DataMember = "FindedAddresses";
            this.findedAddressesBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findedAddressessGridView
            // 
            this.findedAddressessGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAddress,
            this.colAddressStr,
            this.colForThisProduct,
            this.colidCell,
            this.colQtyBoxInCell});
            this.findedAddressessGridView.GridControl = this.findedAddressessGridControl;
            this.findedAddressessGridView.Name = "findedAddressessGridView";
            this.findedAddressessGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.findedAddressessGridView.OptionsBehavior.Editable = false;
            this.findedAddressessGridView.OptionsBehavior.ReadOnly = true;
            this.findedAddressessGridView.OptionsView.AllowHtmlDrawHeaders = true;
            this.findedAddressessGridView.OptionsView.ColumnAutoWidth = false;
            this.findedAddressessGridView.OptionsView.ShowFooter = true;
            this.findedAddressessGridView.OptionsView.ShowGroupPanel = false;
            this.findedAddressessGridView.OptionsView.ShowIndicator = false;
            this.findedAddressessGridView.RowHeight = 40;
            // 
            // colIdAddress
            // 
            this.colIdAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colIdAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdAddress.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colIdAddress.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIdAddress.Caption = "Код\nадреса";
            this.colIdAddress.FieldName = "idAddress";
            this.colIdAddress.Name = "colIdAddress";
            this.colIdAddress.Visible = true;
            this.colIdAddress.VisibleIndex = 0;
            this.colIdAddress.Width = 72;
            // 
            // colAddressStr
            // 
            this.colAddressStr.AppearanceCell.Options.UseTextOptions = true;
            this.colAddressStr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressStr.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddressStr.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddressStr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddressStr.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddressStr.Caption = "Адрес";
            this.colAddressStr.FieldName = "strAddress";
            this.colAddressStr.Name = "colAddressStr";
            this.colAddressStr.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colAddressStr.Visible = true;
            this.colAddressStr.VisibleIndex = 1;
            this.colAddressStr.Width = 139;
            // 
            // colForThisProduct
            // 
            this.colForThisProduct.Caption = "Исторический адрес";
            this.colForThisProduct.FieldName = "ForThisProduct";
            this.colForThisProduct.Name = "colForThisProduct";
            this.colForThisProduct.Width = 110;
            // 
            // colidCell
            // 
            this.colidCell.AppearanceCell.Options.UseTextOptions = true;
            this.colidCell.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidCell.AppearanceHeader.Options.UseTextOptions = true;
            this.colidCell.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidCell.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colidCell.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colidCell.Caption = "Тип \n  ячейки";
            this.colidCell.FieldName = "idCell";
            this.colidCell.Name = "colidCell";
            this.colidCell.Visible = true;
            this.colidCell.VisibleIndex = 2;
            this.colidCell.Width = 60;
            // 
            // colQtyBoxInCell
            // 
            this.colQtyBoxInCell.AppearanceCell.Options.UseTextOptions = true;
            this.colQtyBoxInCell.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyBoxInCell.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colQtyBoxInCell.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyBoxInCell.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyBoxInCell.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQtyBoxInCell.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colQtyBoxInCell.Caption = "Кол-во \n  коробок  \n в ячейке";
            this.colQtyBoxInCell.FieldName = "QtyBoxInCell";
            this.colQtyBoxInCell.Name = "colQtyBoxInCell";
            this.colQtyBoxInCell.Visible = true;
            this.colQtyBoxInCell.VisibleIndex = 3;
            this.colQtyBoxInCell.Width = 80;
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl5.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl5.Controls.Add(this.neededTypeCellsGridControl);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl5.Location = new System.Drawing.Point(251, 417);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(605, 202);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "Необходимое количество и тип ячеек";
            // 
            // neededTypeCellsGridControl
            // 
            this.neededTypeCellsGridControl.DataSource = this.neededTypeAndQtyCellsBindingSource;
            this.neededTypeCellsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neededTypeCellsGridControl.Location = new System.Drawing.Point(2, 22);
            this.neededTypeCellsGridControl.MainView = this.neededTypeCellsGridView;
            this.neededTypeCellsGridControl.Name = "neededTypeCellsGridControl";
            this.neededTypeCellsGridControl.Size = new System.Drawing.Size(601, 178);
            this.neededTypeCellsGridControl.TabIndex = 0;
            this.neededTypeCellsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.neededTypeCellsGridView});
            // 
            // neededTypeAndQtyCellsBindingSource
            // 
            this.neededTypeAndQtyCellsBindingSource.DataMember = "NeededTypeAndQtyCells";
            this.neededTypeAndQtyCellsBindingSource.DataSource = this.wMSDataSet;
            // 
            // neededTypeCellsGridView
            // 
            this.neededTypeCellsGridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.neededTypeCellsGridView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.neededTypeCellsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeCell,
            this.colTypeShelf,
            this.colQtyCells,
            this.colQtyFullCels,
            this.colQtyBoxInFullCells,
            this.colQtyBoxInNonCompleteCells});
            this.neededTypeCellsGridView.GridControl = this.neededTypeCellsGridControl;
            this.neededTypeCellsGridView.Name = "neededTypeCellsGridView";
            this.neededTypeCellsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.neededTypeCellsGridView.OptionsBehavior.Editable = false;
            this.neededTypeCellsGridView.OptionsBehavior.ReadOnly = true;
            this.neededTypeCellsGridView.OptionsFilter.AllowColumnMRUFilterList = false;
            this.neededTypeCellsGridView.OptionsFilter.AllowFilterEditor = false;
            this.neededTypeCellsGridView.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.neededTypeCellsGridView.OptionsFilter.AllowMRUFilterList = false;
            this.neededTypeCellsGridView.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.neededTypeCellsGridView.OptionsView.AllowHtmlDrawHeaders = true;
            this.neededTypeCellsGridView.OptionsView.ColumnAutoWidth = false;
            this.neededTypeCellsGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.neededTypeCellsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colTypeCell
            // 
            this.colTypeCell.AppearanceCell.Options.UseTextOptions = true;
            this.colTypeCell.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeCell.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeCell.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeCell.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTypeCell.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTypeCell.Caption = "Тип \n ячейки";
            this.colTypeCell.FieldName = "TypeCell";
            this.colTypeCell.Name = "colTypeCell";
            this.colTypeCell.Visible = true;
            this.colTypeCell.VisibleIndex = 0;
            this.colTypeCell.Width = 54;
            // 
            // colTypeShelf
            // 
            this.colTypeShelf.AppearanceCell.Options.UseTextOptions = true;
            this.colTypeShelf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeShelf.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeShelf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeShelf.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTypeShelf.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTypeShelf.Caption = "Тип \n полки";
            this.colTypeShelf.FieldName = "TypeShelf";
            this.colTypeShelf.Name = "colTypeShelf";
            this.colTypeShelf.Visible = true;
            this.colTypeShelf.VisibleIndex = 1;
            this.colTypeShelf.Width = 58;
            // 
            // colQtyCells
            // 
            this.colQtyCells.AppearanceCell.Options.UseTextOptions = true;
            this.colQtyCells.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyCells.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyCells.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyCells.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQtyCells.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colQtyCells.Caption = "Кол-во \n ячеек";
            this.colQtyCells.FieldName = "QtyCells";
            this.colQtyCells.Name = "colQtyCells";
            this.colQtyCells.Visible = true;
            this.colQtyCells.VisibleIndex = 2;
            this.colQtyCells.Width = 53;
            // 
            // colQtyFullCels
            // 
            this.colQtyFullCels.AppearanceCell.Options.UseTextOptions = true;
            this.colQtyFullCels.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyFullCels.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyFullCels.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyFullCels.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQtyFullCels.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colQtyFullCels.Caption = "Кол-во полных \n ячеек";
            this.colQtyFullCels.FieldName = "QtyFullCels";
            this.colQtyFullCels.Name = "colQtyFullCels";
            this.colQtyFullCels.Visible = true;
            this.colQtyFullCels.VisibleIndex = 3;
            this.colQtyFullCels.Width = 76;
            // 
            // colQtyBoxInFullCells
            // 
            this.colQtyBoxInFullCells.AppearanceCell.Options.UseTextOptions = true;
            this.colQtyBoxInFullCells.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyBoxInFullCells.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyBoxInFullCells.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyBoxInFullCells.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQtyBoxInFullCells.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colQtyBoxInFullCells.Caption = "Кол-во коробок  \n в полных  \n  ячейках";
            this.colQtyBoxInFullCells.FieldName = "QtyBoxInFullCells";
            this.colQtyBoxInFullCells.Name = "colQtyBoxInFullCells";
            this.colQtyBoxInFullCells.Visible = true;
            this.colQtyBoxInFullCells.VisibleIndex = 4;
            this.colQtyBoxInFullCells.Width = 97;
            // 
            // colQtyBoxInNonCompleteCells
            // 
            this.colQtyBoxInNonCompleteCells.AppearanceCell.Options.UseTextOptions = true;
            this.colQtyBoxInNonCompleteCells.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyBoxInNonCompleteCells.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyBoxInNonCompleteCells.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyBoxInNonCompleteCells.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQtyBoxInNonCompleteCells.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colQtyBoxInNonCompleteCells.Caption = "Кол-во коробок \n в не полных \n ячейках";
            this.colQtyBoxInNonCompleteCells.FieldName = "QtyBoxInNotCompleteCells";
            this.colQtyBoxInNonCompleteCells.Name = "colQtyBoxInNonCompleteCells";
            this.colQtyBoxInNonCompleteCells.Visible = true;
            this.colQtyBoxInNonCompleteCells.VisibleIndex = 5;
            this.colQtyBoxInNonCompleteCells.Width = 99;
            // 
            // FrmFindAndAutoAssignmentAddress
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1030, 619);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFindAndAutoAssignmentAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Количество товара";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowQtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.findedAddressessGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedAddressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findedAddressessGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neededTypeCellsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neededTypeAndQtyCellsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neededTypeCellsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl productDescriptionLabelControl;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton moveAllQtyButton;
        private DevExpress.XtraEditors.SpinEdit qtySpinEdit;
        private DevExpress.XtraEditors.TextEdit allowQtyTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit warehouseLookUpEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl findedAddressessGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView findedAddressessGridView;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl neededTypeCellsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView neededTypeCellsGridView;
        private System.Windows.Forms.BindingSource findedAddressesBindingSource;
        private WMSDataSet wMSDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressStr;
        private DevExpress.XtraGrid.Columns.GridColumn colForThisProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colidCell;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyBoxInCell;
        private System.Windows.Forms.BindingSource neededTypeAndQtyCellsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeCell;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeShelf;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyCells;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyFullCels;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyBoxInFullCells;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyBoxInNonCompleteCells;
    }
}