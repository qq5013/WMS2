namespace WMS.MainApplication
{
    partial class DirAddEditGroup
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rotationsGridControl = new DevExpress.XtraGrid.GridControl();
            this.catalogRotationsProductForGroupBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.MainApplication.WMSDataSet();
            this.rotationGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRotGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRotGName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRotGMinQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRotGMaxQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.warehouseLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogWarehousesBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.raftsCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.listRaftsBindingSource = new System.Windows.Forms.BindingSource();
            this.streetsCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.listStreetsBindingSource = new System.Windows.Forms.BindingSource();
            this.zonesLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogZonesBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.descriptionGroupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameGroupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.catalog_WarehousesTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_WarehousesTableAdapter();
            this.catalog_ZonesTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_ZonesTableAdapter();
            this.catalogMultiplicityProductsBindingSource = new System.Windows.Forms.BindingSource();
            this._Catalog_MultiplicityProductsTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters._Catalog_MultiplicityProductsTableAdapter();
            this.catalog_RotationsProductForGroupTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_RotationsProductForGroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRotationsProductForGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogWarehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raftsCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRaftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listStreetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogZonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionGroupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameGroupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogMultiplicityProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.cancelButton);
            this.groupControl1.Controls.Add(this.saveButton);
            this.groupControl1.Controls.Add(this.warehouseLookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.raftsCheckedListBoxControl);
            this.groupControl1.Controls.Add(this.streetsCheckedListBoxControl);
            this.groupControl1.Controls.Add(this.zonesLookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.descriptionGroupTextEdit);
            this.groupControl1.Controls.Add(this.nameGroupTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(285, 547);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Работа с группами";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.rotationsGridControl);
            this.groupControl2.Location = new System.Drawing.Point(21, 286);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(230, 205);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Пределы ротации";
            // 
            // rotationsGridControl
            // 
            this.rotationsGridControl.DataSource = this.catalogRotationsProductForGroupBindingSource;
            this.rotationsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationsGridControl.Location = new System.Drawing.Point(2, 22);
            this.rotationsGridControl.MainView = this.rotationGridView;
            this.rotationsGridControl.Name = "rotationsGridControl";
            this.rotationsGridControl.Size = new System.Drawing.Size(226, 181);
            this.rotationsGridControl.TabIndex = 8;
            this.rotationsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rotationGridView});
            // 
            // catalogRotationsProductForGroupBindingSource
            // 
            this.catalogRotationsProductForGroupBindingSource.DataMember = "Catalog_RotationsProductForGroup";
            this.catalogRotationsProductForGroupBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rotationGridView
            // 
            this.rotationGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRotGID,
            this.colRotGName,
            this.colRotGMinQty,
            this.colRotGMaxQty});
            this.rotationGridView.GridControl = this.rotationsGridControl;
            this.rotationGridView.Name = "rotationGridView";
            this.rotationGridView.OptionsView.ColumnAutoWidth = false;
            this.rotationGridView.OptionsView.ShowGroupPanel = false;
            this.rotationGridView.OptionsView.ShowIndicator = false;
            // 
            // colRotGID
            // 
            this.colRotGID.Caption = "Код";
            this.colRotGID.FieldName = "ID";
            this.colRotGID.Name = "colRotGID";
            this.colRotGID.OptionsColumn.AllowEdit = false;
            this.colRotGID.OptionsColumn.ReadOnly = true;
            // 
            // colRotGName
            // 
            this.colRotGName.AppearanceCell.Options.UseTextOptions = true;
            this.colRotGName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRotGName.Caption = "Тип";
            this.colRotGName.FieldName = "Name";
            this.colRotGName.Name = "colRotGName";
            this.colRotGName.OptionsColumn.AllowEdit = false;
            this.colRotGName.OptionsColumn.ReadOnly = true;
            this.colRotGName.Visible = true;
            this.colRotGName.VisibleIndex = 0;
            this.colRotGName.Width = 45;
            // 
            // colRotGMinQty
            // 
            this.colRotGMinQty.Caption = "Мин.";
            this.colRotGMinQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRotGMinQty.FieldName = "MinQty";
            this.colRotGMinQty.Name = "colRotGMinQty";
            this.colRotGMinQty.Visible = true;
            this.colRotGMinQty.VisibleIndex = 1;
            this.colRotGMinQty.Width = 69;
            // 
            // colRotGMaxQty
            // 
            this.colRotGMaxQty.Caption = "Макс.";
            this.colRotGMaxQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRotGMaxQty.FieldName = "MaxQty";
            this.colRotGMaxQty.Name = "colRotGMaxQty";
            this.colRotGMaxQty.Visible = true;
            this.colRotGMaxQty.VisibleIndex = 2;
            this.colRotGMaxQty.Width = 65;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(139, 497);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 28);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(21, 497);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 28);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // warehouseLookUpEdit
            // 
            this.warehouseLookUpEdit.Location = new System.Drawing.Point(123, 88);
            this.warehouseLookUpEdit.Name = "warehouseLookUpEdit";
            this.warehouseLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.warehouseLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Имя склада", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание кслада", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warehouseLookUpEdit.Properties.DataSource = this.catalogWarehousesBindingSource;
            this.warehouseLookUpEdit.Properties.DisplayMember = "Description";
            this.warehouseLookUpEdit.Properties.NullText = "[Выбирите склад]";
            this.warehouseLookUpEdit.Properties.ValueMember = "ID";
            this.warehouseLookUpEdit.Size = new System.Drawing.Size(128, 20);
            this.warehouseLookUpEdit.TabIndex = 2;
            this.warehouseLookUpEdit.EditValueChanged += new System.EventHandler(this.WarehouseLookUpEditEditValueChanged);
            // 
            // catalogWarehousesBindingSource
            // 
            this.catalogWarehousesBindingSource.DataMember = "Catalog_Warehouses";
            this.catalogWarehousesBindingSource.DataSource = this.wMSDataSet;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Привязка к складу";
            // 
            // raftsCheckedListBoxControl
            // 
            this.raftsCheckedListBoxControl.CheckOnClick = true;
            this.raftsCheckedListBoxControl.DataSource = this.listRaftsBindingSource;
            this.raftsCheckedListBoxControl.DisplayMember = "Description";
            this.raftsCheckedListBoxControl.Enabled = false;
            this.raftsCheckedListBoxControl.Location = new System.Drawing.Point(139, 140);
            this.raftsCheckedListBoxControl.Name = "raftsCheckedListBoxControl";
            this.raftsCheckedListBoxControl.Size = new System.Drawing.Size(112, 139);
            this.raftsCheckedListBoxControl.TabIndex = 5;
            this.raftsCheckedListBoxControl.ValueMember = "ID";
            this.raftsCheckedListBoxControl.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.RaftsCheckedListBoxControlItemCheck);
            // 
            // listRaftsBindingSource
            // 
            this.listRaftsBindingSource.DataMember = "ListRafts";
            this.listRaftsBindingSource.DataSource = this.wMSDataSet;
            // 
            // streetsCheckedListBoxControl
            // 
            this.streetsCheckedListBoxControl.CheckOnClick = true;
            this.streetsCheckedListBoxControl.DataSource = this.listStreetsBindingSource;
            this.streetsCheckedListBoxControl.DisplayMember = "Description";
            this.streetsCheckedListBoxControl.Enabled = false;
            this.streetsCheckedListBoxControl.Location = new System.Drawing.Point(21, 140);
            this.streetsCheckedListBoxControl.Name = "streetsCheckedListBoxControl";
            this.streetsCheckedListBoxControl.Size = new System.Drawing.Size(112, 139);
            this.streetsCheckedListBoxControl.TabIndex = 4;
            this.streetsCheckedListBoxControl.ValueMember = "ID";
            this.streetsCheckedListBoxControl.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.StreetsCheckedListBoxControlItemCheck);
            // 
            // listStreetsBindingSource
            // 
            this.listStreetsBindingSource.DataMember = "ListStreets";
            this.listStreetsBindingSource.DataSource = this.wMSDataSet;
            // 
            // zonesLookUpEdit
            // 
            this.zonesLookUpEdit.Enabled = false;
            this.zonesLookUpEdit.Location = new System.Drawing.Point(123, 114);
            this.zonesLookUpEdit.Name = "zonesLookUpEdit";
            this.zonesLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.zonesLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Имя зоны", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание зоны", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.zonesLookUpEdit.Properties.DataSource = this.catalogZonesBindingSource;
            this.zonesLookUpEdit.Properties.DisplayMember = "Name";
            this.zonesLookUpEdit.Properties.NullText = "[Выбирите зону]";
            this.zonesLookUpEdit.Properties.ValueMember = "ID";
            this.zonesLookUpEdit.Size = new System.Drawing.Size(128, 20);
            this.zonesLookUpEdit.TabIndex = 3;
            this.zonesLookUpEdit.EditValueChanged += new System.EventHandler(this.ZonesLookUpEditEditValueChanged);
            // 
            // catalogZonesBindingSource
            // 
            this.catalogZonesBindingSource.DataMember = "Catalog_Zones";
            this.catalogZonesBindingSource.DataSource = this.wMSDataSet;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Привязка к зоне";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Описание группы";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Имя группы";
            // 
            // descriptionGroupTextEdit
            // 
            this.descriptionGroupTextEdit.Location = new System.Drawing.Point(123, 62);
            this.descriptionGroupTextEdit.Name = "descriptionGroupTextEdit";
            this.descriptionGroupTextEdit.Size = new System.Drawing.Size(128, 20);
            this.descriptionGroupTextEdit.TabIndex = 1;
            // 
            // nameGroupTextEdit
            // 
            this.nameGroupTextEdit.Location = new System.Drawing.Point(123, 36);
            this.nameGroupTextEdit.Name = "nameGroupTextEdit";
            this.nameGroupTextEdit.Size = new System.Drawing.Size(128, 20);
            this.nameGroupTextEdit.TabIndex = 0;
            // 
            // catalog_WarehousesTableAdapter
            // 
            this.catalog_WarehousesTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_ZonesTableAdapter
            // 
            this.catalog_ZonesTableAdapter.ClearBeforeFill = true;
            // 
            // catalogMultiplicityProductsBindingSource
            // 
            this.catalogMultiplicityProductsBindingSource.DataMember = " Catalog_MultiplicityProducts";
            this.catalogMultiplicityProductsBindingSource.DataSource = this.wMSDataSet;
            // 
            // _Catalog_MultiplicityProductsTableAdapter
            // 
            this._Catalog_MultiplicityProductsTableAdapter.ClearBeforeFill = true;
            // 
            // catalog_RotationsProductForGroupTableAdapter
            // 
            this.catalog_RotationsProductForGroupTableAdapter.ClearBeforeFill = true;
            // 
            // DirAddEditGroup
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(285, 547);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DirAddEditGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirAddEditGroup";
            this.Load += new System.EventHandler(this.DirAddEditGroupLoad);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rotationsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRotationsProductForGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogWarehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raftsCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRaftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listStreetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogZonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionGroupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameGroupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogMultiplicityProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit warehouseLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckedListBoxControl raftsCheckedListBoxControl;
        private DevExpress.XtraEditors.CheckedListBoxControl streetsCheckedListBoxControl;
        private DevExpress.XtraEditors.LookUpEdit zonesLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit descriptionGroupTextEdit;
        private DevExpress.XtraEditors.TextEdit nameGroupTextEdit;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource catalogWarehousesBindingSource;
        private WMSDataSetTableAdapters.Catalog_WarehousesTableAdapter catalog_WarehousesTableAdapter;
        private System.Windows.Forms.BindingSource catalogZonesBindingSource;
        private WMSDataSetTableAdapters.Catalog_ZonesTableAdapter catalog_ZonesTableAdapter;
        private System.Windows.Forms.BindingSource listStreetsBindingSource;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private System.Windows.Forms.BindingSource catalogMultiplicityProductsBindingSource;
        private WMSDataSetTableAdapters._Catalog_MultiplicityProductsTableAdapter _Catalog_MultiplicityProductsTableAdapter;
        private System.Windows.Forms.BindingSource listRaftsBindingSource;
        private DevExpress.XtraGrid.GridControl rotationsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView rotationGridView;
        private System.Windows.Forms.BindingSource catalogRotationsProductForGroupBindingSource;
        private WMSDataSetTableAdapters.Catalog_RotationsProductForGroupTableAdapter catalog_RotationsProductForGroupTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRotGID;
        private DevExpress.XtraGrid.Columns.GridColumn colRotGName;
        private DevExpress.XtraGrid.Columns.GridColumn colRotGMinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRotGMaxQty;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}