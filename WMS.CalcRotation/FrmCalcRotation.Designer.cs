namespace WMS.CalcRotation
{
    partial class FrmCalcRotation
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
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageOnceCalc = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsForCalcBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.CalcRotation.WMSDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.minTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.manualRotationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.calcButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.percentMinTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.countDayRotationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogProductsBindingSource = new System.Windows.Forms.BindingSource();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.xtraTabPageMultipleCalc = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateCalLabel = new DevExpress.XtraEditors.LabelControl();
            this.maxQtyLabel = new DevExpress.XtraEditors.LabelControl();
            this.minQtyLabel = new DevExpress.XtraEditors.LabelControl();
            this.typeRotationLabel = new DevExpress.XtraEditors.LabelControl();
            this.descriptionLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.productTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.catalog_ProductsTableAdapter = new WMS.CalcRotation.WMSDataSetTableAdapters.Catalog_ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPageOnceCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsForCalcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualRotationCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentMinTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countDayRotationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.xtraTabPageMultipleCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageOnceCalc;
            this.xtraTabControl.Size = new System.Drawing.Size(950, 550);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageOnceCalc,
            this.xtraTabPageMultipleCalc});
            // 
            // xtraTabPageOnceCalc
            // 
            this.xtraTabPageOnceCalc.Controls.Add(this.groupControl2);
            this.xtraTabPageOnceCalc.Controls.Add(this.groupControl1);
            this.xtraTabPageOnceCalc.Name = "xtraTabPageOnceCalc";
            this.xtraTabPageOnceCalc.Size = new System.Drawing.Size(944, 524);
            this.xtraTabPageOnceCalc.Text = "Посчёт ротации";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 197);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(944, 327);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Товары для подсчёта";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsForCalcBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(940, 303);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControl1KeyDown);
            // 
            // productsForCalcBindingSource
            // 
            this.productsForCalcBindingSource.DataMember = "ProductsForCalc";
            this.productsForCalcBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDescription,
            this.colBarcode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colID
            // 
            this.colID.Caption = "Артикул";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 58;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Название товара";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 265;
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Баркод";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 2;
            this.colBarcode.Width = 97;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.manualRotationCheckEdit);
            this.groupControl1.Controls.Add(this.calcButton);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.percentMinTextEdit);
            this.groupControl1.Controls.Add(this.countDayRotationTextEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(944, 197);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Поиск товара";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.saveButton);
            this.groupControl3.Controls.Add(this.minTextEdit);
            this.groupControl3.Controls.Add(this.maxTextEdit);
            this.groupControl3.Controls.Add(this.labelControl12);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Location = new System.Drawing.Point(407, 59);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(187, 125);
            this.groupControl3.TabIndex = 10;
            this.groupControl3.Text = "Параметры для ручного ввода";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(62, 83);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 34);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // minTextEdit
            // 
            this.minTextEdit.Location = new System.Drawing.Point(105, 54);
            this.minTextEdit.Name = "minTextEdit";
            this.minTextEdit.Properties.Mask.EditMask = "d";
            this.minTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.minTextEdit.Size = new System.Drawing.Size(40, 20);
            this.minTextEdit.TabIndex = 1;
            // 
            // maxTextEdit
            // 
            this.maxTextEdit.Location = new System.Drawing.Point(105, 32);
            this.maxTextEdit.Name = "maxTextEdit";
            this.maxTextEdit.Properties.Mask.EditMask = "d";
            this.maxTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maxTextEdit.Size = new System.Drawing.Size(40, 20);
            this.maxTextEdit.TabIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(51, 57);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 5;
            this.labelControl12.Text = "Минимум:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(46, 35);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(53, 13);
            this.labelControl11.TabIndex = 5;
            this.labelControl11.Text = "Максимум:";
            // 
            // manualRotationCheckEdit
            // 
            this.manualRotationCheckEdit.Location = new System.Drawing.Point(405, 34);
            this.manualRotationCheckEdit.Name = "manualRotationCheckEdit";
            this.manualRotationCheckEdit.Properties.Caption = "Ручной ввод первоначальной ротации";
            this.manualRotationCheckEdit.Size = new System.Drawing.Size(218, 19);
            this.manualRotationCheckEdit.TabIndex = 9;
            this.manualRotationCheckEdit.CheckedChanged += new System.EventHandler(this.ManualRotationCheckEditCheckedChanged);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(21, 148);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(98, 36);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Посчитать \r\nротацию";
            this.calcButton.Click += new System.EventHandler(this.CalcButtonClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(175, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(176, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Процент остатка для пополнения:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Location = new System.Drawing.Point(161, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(8, 24);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "|";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 124);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Кол-во дней запаса:";
            // 
            // percentMinTextEdit
            // 
            this.percentMinTextEdit.EditValue = "40";
            this.percentMinTextEdit.Location = new System.Drawing.Point(357, 123);
            this.percentMinTextEdit.Name = "percentMinTextEdit";
            this.percentMinTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.percentMinTextEdit.Properties.Appearance.Options.UseFont = true;
            this.percentMinTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.percentMinTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.percentMinTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.percentMinTextEdit.Properties.Mask.EditMask = "d";
            this.percentMinTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.percentMinTextEdit.Size = new System.Drawing.Size(29, 21);
            this.percentMinTextEdit.TabIndex = 4;
            // 
            // countDayRotationTextEdit
            // 
            this.countDayRotationTextEdit.EditValue = "20";
            this.countDayRotationTextEdit.Location = new System.Drawing.Point(125, 121);
            this.countDayRotationTextEdit.Name = "countDayRotationTextEdit";
            this.countDayRotationTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.countDayRotationTextEdit.Properties.Appearance.Options.UseFont = true;
            this.countDayRotationTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.countDayRotationTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.countDayRotationTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.countDayRotationTextEdit.Properties.Mask.EditMask = "d";
            this.countDayRotationTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.countDayRotationTextEdit.Size = new System.Drawing.Size(30, 21);
            this.countDayRotationTextEdit.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Location = new System.Drawing.Point(407, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 24);
            this.labelControl1.TabIndex = 2;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(21, 95);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.AutoSearchColumnIndex = 1;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.CaseSensitiveSearch = true;
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 21, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Название", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BarCode", "Бар код", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.catalogProductsBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "Description";
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(365, 20);
            this.lookUpEdit1.TabIndex = 0;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.LookUpEdit1EditValueChanged);
            this.lookUpEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LookUpEdit1KeyDown);
            // 
            // catalogProductsBindingSource
            // 
            this.catalogProductsBindingSource.DataMember = "Catalog_Products";
            this.catalogProductsBindingSource.DataSource = this.wMSDataSet;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(21, 36);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Поиск по бар коду"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Поиск по названию")});
            this.radioGroup1.Size = new System.Drawing.Size(365, 43);
            this.radioGroup1.TabIndex = 1;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // xtraTabPageMultipleCalc
            // 
            this.xtraTabPageMultipleCalc.Controls.Add(this.labelControl10);
            this.xtraTabPageMultipleCalc.Controls.Add(this.labelControl9);
            this.xtraTabPageMultipleCalc.Controls.Add(this.labelControl8);
            this.xtraTabPageMultipleCalc.Controls.Add(this.labelControl7);
            this.xtraTabPageMultipleCalc.Controls.Add(this.dateCalLabel);
            this.xtraTabPageMultipleCalc.Controls.Add(this.maxQtyLabel);
            this.xtraTabPageMultipleCalc.Controls.Add(this.minQtyLabel);
            this.xtraTabPageMultipleCalc.Controls.Add(this.typeRotationLabel);
            this.xtraTabPageMultipleCalc.Controls.Add(this.descriptionLabel);
            this.xtraTabPageMultipleCalc.Controls.Add(this.labelControl6);
            this.xtraTabPageMultipleCalc.Controls.Add(this.labelControl5);
            this.xtraTabPageMultipleCalc.Controls.Add(this.productTextEdit);
            this.xtraTabPageMultipleCalc.Name = "xtraTabPageMultipleCalc";
            this.xtraTabPageMultipleCalc.Size = new System.Drawing.Size(944, 524);
            this.xtraTabPageMultipleCalc.Text = "Проверка ротации";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(27, 158);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(143, 13);
            this.labelControl10.TabIndex = 3;
            this.labelControl10.Text = "Дата последнего подсчёта:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(56, 139);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(114, 13);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "Максимальное кол-во:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(61, 120);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(109, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Минимальное кол-во:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(103, 101);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Тип ротации:";
            // 
            // dateCalLabel
            // 
            this.dateCalLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateCalLabel.Appearance.ForeColor = System.Drawing.Color.MediumBlue;
            this.dateCalLabel.Location = new System.Drawing.Point(176, 158);
            this.dateCalLabel.Name = "dateCalLabel";
            this.dateCalLabel.Size = new System.Drawing.Size(9, 13);
            this.dateCalLabel.TabIndex = 2;
            this.dateCalLabel.Text = "...";
            // 
            // maxQtyLabel
            // 
            this.maxQtyLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.maxQtyLabel.Appearance.ForeColor = System.Drawing.Color.Green;
            this.maxQtyLabel.Location = new System.Drawing.Point(176, 139);
            this.maxQtyLabel.Name = "maxQtyLabel";
            this.maxQtyLabel.Size = new System.Drawing.Size(9, 13);
            this.maxQtyLabel.TabIndex = 2;
            this.maxQtyLabel.Text = "...";
            // 
            // minQtyLabel
            // 
            this.minQtyLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.minQtyLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.minQtyLabel.Location = new System.Drawing.Point(176, 120);
            this.minQtyLabel.Name = "minQtyLabel";
            this.minQtyLabel.Size = new System.Drawing.Size(9, 13);
            this.minQtyLabel.TabIndex = 2;
            this.minQtyLabel.Text = "...";
            // 
            // typeRotationLabel
            // 
            this.typeRotationLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.typeRotationLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.typeRotationLabel.Location = new System.Drawing.Point(176, 101);
            this.typeRotationLabel.Name = "typeRotationLabel";
            this.typeRotationLabel.Size = new System.Drawing.Size(9, 13);
            this.typeRotationLabel.TabIndex = 2;
            this.typeRotationLabel.Text = "...";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionLabel.Location = new System.Drawing.Point(176, 82);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(9, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "...";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(136, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Товар:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(167, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(155, 16);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Артикул / Бар-код / Адрес";
            // 
            // productTextEdit
            // 
            this.productTextEdit.EditValue = "";
            this.productTextEdit.Location = new System.Drawing.Point(147, 38);
            this.productTextEdit.Name = "productTextEdit";
            this.productTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.productTextEdit.Properties.Appearance.Options.UseFont = true;
            this.productTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.productTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.productTextEdit.Size = new System.Drawing.Size(175, 27);
            this.productTextEdit.TabIndex = 0;
            this.productTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductTextEditKeyDown);
            // 
            // catalog_ProductsTableAdapter
            // 
            this.catalog_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCalcRotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "FrmCalcRotation";
            this.Text = "Расчёт ротации товаров";
            this.Load += new System.EventHandler(this.FrmCalcRotation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPageOnceCalc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsForCalcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualRotationCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentMinTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countDayRotationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.xtraTabPageMultipleCalc.ResumeLayout(false);
            this.xtraTabPageMultipleCalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageOnceCalc;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMultipleCalc;
        private WMSDataSet wMSDataSet;
        private WMSDataSetTableAdapters.Catalog_ProductsTableAdapter catalog_ProductsTableAdapter;
        private System.Windows.Forms.BindingSource catalogProductsBindingSource;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton calcButton;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit percentMinTextEdit;
        private DevExpress.XtraEditors.TextEdit countDayRotationTextEdit;
        private System.Windows.Forms.BindingSource productsForCalcBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl dateCalLabel;
        private DevExpress.XtraEditors.LabelControl maxQtyLabel;
        private DevExpress.XtraEditors.LabelControl minQtyLabel;
        private DevExpress.XtraEditors.LabelControl typeRotationLabel;
        private DevExpress.XtraEditors.LabelControl descriptionLabel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit productTextEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit minTextEdit;
        private DevExpress.XtraEditors.TextEdit maxTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckEdit manualRotationCheckEdit;
        private DevExpress.XtraEditors.SimpleButton saveButton;


    }
}
