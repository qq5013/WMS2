namespace WMS.AddressReplenishment
{
    partial class FrmManualAddressReplenishment
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
            this.topPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.deleteDocButton = new DevExpress.XtraEditors.SimpleButton();
            this.savePrintDocButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveDocButton = new DevExpress.XtraEditors.SimpleButton();
            this.zoneLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogZonesBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.AddressReplenishment.WMSDataSet();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.openDocButton = new DevExpress.XtraEditors.SimpleButton();
            this.newDocButton = new DevExpress.XtraEditors.SimpleButton();
            this.numDocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.addressReplenishmentGridControl = new DevExpress.XtraGrid.GridControl();
            this.docForManualReplenishmentBindingSource = new System.Windows.Forms.BindingSource();
            this.addressReplenishmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_AddressFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_AddressTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_AdressFromCatalogFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_AdressFromCatalogTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStr_AddressFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStr_AddressTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_PartRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExp_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.findSkuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.catalogZonesTableAdapter = new WMS.AddressReplenishment.WMSDataSetTableAdapters.CatalogZonesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).BeginInit();
            this.topPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogZonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressReplenishmentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docForManualReplenishmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressReplenishmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSkuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanelControl
            // 
            this.topPanelControl.Controls.Add(this.groupControl2);
            this.topPanelControl.Controls.Add(this.groupControl1);
            this.topPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelControl.Location = new System.Drawing.Point(0, 0);
            this.topPanelControl.Name = "topPanelControl";
            this.topPanelControl.Size = new System.Drawing.Size(882, 94);
            this.topPanelControl.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.deleteDocButton);
            this.groupControl2.Controls.Add(this.savePrintDocButton);
            this.groupControl2.Controls.Add(this.saveDocButton);
            this.groupControl2.Controls.Add(this.zoneLookUpEdit);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(179, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(701, 90);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Параметры документа";
            // 
            // deleteDocButton
            // 
            this.deleteDocButton.Location = new System.Drawing.Point(523, 29);
            this.deleteDocButton.Name = "deleteDocButton";
            this.deleteDocButton.Size = new System.Drawing.Size(92, 55);
            this.deleteDocButton.TabIndex = 4;
            this.deleteDocButton.Text = "Удалить \r\nдокумент";
            // 
            // savePrintDocButton
            // 
            this.savePrintDocButton.Location = new System.Drawing.Point(425, 29);
            this.savePrintDocButton.Name = "savePrintDocButton";
            this.savePrintDocButton.Size = new System.Drawing.Size(92, 55);
            this.savePrintDocButton.TabIndex = 3;
            this.savePrintDocButton.Text = "Сохранить \r\nдокумент && \r\nРаспечатать";
            // 
            // saveDocButton
            // 
            this.saveDocButton.Location = new System.Drawing.Point(327, 29);
            this.saveDocButton.Name = "saveDocButton";
            this.saveDocButton.Size = new System.Drawing.Size(92, 55);
            this.saveDocButton.TabIndex = 2;
            this.saveDocButton.Text = "Сохранить \r\nдокумент";
            // 
            // zoneLookUpEdit
            // 
            this.zoneLookUpEdit.Location = new System.Drawing.Point(158, 39);
            this.zoneLookUpEdit.Name = "zoneLookUpEdit";
            this.zoneLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.zoneLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.zoneLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.zoneLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 41, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание зоны", 94, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Зона", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.zoneLookUpEdit.Properties.DataSource = this.catalogZonesBindingSource;
            this.zoneLookUpEdit.Properties.DisplayMember = "Name";
            this.zoneLookUpEdit.Properties.NullText = "[Укажите зону]";
            this.zoneLookUpEdit.Properties.ValueMember = "ID";
            this.zoneLookUpEdit.Size = new System.Drawing.Size(163, 27);
            this.zoneLookUpEdit.TabIndex = 1;
            // 
            // catalogZonesBindingSource
            // 
            this.catalogZonesBindingSource.DataMember = "CatalogZones";
            this.catalogZonesBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Location = new System.Drawing.Point(6, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(146, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Пополняемая зона";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.openDocButton);
            this.groupControl1.Controls.Add(this.newDocButton);
            this.groupControl1.Controls.Add(this.numDocTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(177, 90);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Документ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Номер документа";
            // 
            // openDocButton
            // 
            this.openDocButton.Location = new System.Drawing.Point(10, 53);
            this.openDocButton.Name = "openDocButton";
            this.openDocButton.Size = new System.Drawing.Size(68, 32);
            this.openDocButton.TabIndex = 2;
            this.openDocButton.Text = "Открыть \r\nдокумент";
            // 
            // newDocButton
            // 
            this.newDocButton.Location = new System.Drawing.Point(100, 52);
            this.newDocButton.Name = "newDocButton";
            this.newDocButton.Size = new System.Drawing.Size(68, 32);
            this.newDocButton.TabIndex = 2;
            this.newDocButton.Text = "Новый \r\nдокумент";
            // 
            // numDocTextEdit
            // 
            this.numDocTextEdit.Location = new System.Drawing.Point(100, 26);
            this.numDocTextEdit.Name = "numDocTextEdit";
            this.numDocTextEdit.Size = new System.Drawing.Size(68, 20);
            this.numDocTextEdit.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.addressReplenishmentGridControl);
            this.groupControl3.Controls.Add(this.panelControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 94);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(882, 291);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Тело документа";
            // 
            // addressReplenishmentGridControl
            // 
            this.addressReplenishmentGridControl.DataSource = this.docForManualReplenishmentBindingSource;
            this.addressReplenishmentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressReplenishmentGridControl.Location = new System.Drawing.Point(2, 62);
            this.addressReplenishmentGridControl.MainView = this.addressReplenishmentGridView;
            this.addressReplenishmentGridControl.Name = "addressReplenishmentGridControl";
            this.addressReplenishmentGridControl.Size = new System.Drawing.Size(878, 227);
            this.addressReplenishmentGridControl.TabIndex = 1;
            this.addressReplenishmentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.addressReplenishmentGridView});
            // 
            // docForManualReplenishmentBindingSource
            // 
            this.docForManualReplenishmentBindingSource.DataMember = "DocForManualReplenishment";
            this.docForManualReplenishmentBindingSource.DataSource = this.wMSDataSet;
            // 
            // addressReplenishmentGridView
            // 
            this.addressReplenishmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_AddressFrom,
            this.colID_AddressTo,
            this.colID_AdressFromCatalogFrom,
            this.colID_AdressFromCatalogTo,
            this.colStr_AddressFrom,
            this.colStr_AddressTo,
            this.colID_PartRow,
            this.colID_Product,
            this.colProduct_Description,
            this.colQty,
            this.colSeria,
            this.colExp_Date,
            this.colNumRow});
            this.addressReplenishmentGridView.GridControl = this.addressReplenishmentGridControl;
            this.addressReplenishmentGridView.Name = "addressReplenishmentGridView";
            this.addressReplenishmentGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.addressReplenishmentGridView.OptionsBehavior.Editable = false;
            this.addressReplenishmentGridView.OptionsView.AllowCellMerge = true;
            this.addressReplenishmentGridView.OptionsView.ColumnAutoWidth = false;
            this.addressReplenishmentGridView.OptionsView.ShowFooter = true;
            this.addressReplenishmentGridView.OptionsView.ShowGroupPanel = false;
            this.addressReplenishmentGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNumRow, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID_AddressFrom
            // 
            this.colID_AddressFrom.FieldName = "ID_AddressFrom";
            this.colID_AddressFrom.Name = "colID_AddressFrom";
            // 
            // colID_AddressTo
            // 
            this.colID_AddressTo.FieldName = "ID_AddressTo";
            this.colID_AddressTo.Name = "colID_AddressTo";
            // 
            // colID_AdressFromCatalogFrom
            // 
            this.colID_AdressFromCatalogFrom.FieldName = "ID_AdressFromCatalogFrom";
            this.colID_AdressFromCatalogFrom.Name = "colID_AdressFromCatalogFrom";
            // 
            // colID_AdressFromCatalogTo
            // 
            this.colID_AdressFromCatalogTo.FieldName = "ID_AdressFromCatalogTo";
            this.colID_AdressFromCatalogTo.Name = "colID_AdressFromCatalogTo";
            // 
            // colStr_AddressFrom
            // 
            this.colStr_AddressFrom.Caption = "С адреса";
            this.colStr_AddressFrom.FieldName = "Str_AddressFrom";
            this.colStr_AddressFrom.Name = "colStr_AddressFrom";
            this.colStr_AddressFrom.Visible = true;
            this.colStr_AddressFrom.VisibleIndex = 0;
            // 
            // colStr_AddressTo
            // 
            this.colStr_AddressTo.Caption = "На адрес";
            this.colStr_AddressTo.FieldName = "Str_AddressTo";
            this.colStr_AddressTo.Name = "colStr_AddressTo";
            this.colStr_AddressTo.Visible = true;
            this.colStr_AddressTo.VisibleIndex = 1;
            this.colStr_AddressTo.Width = 90;
            // 
            // colID_PartRow
            // 
            this.colID_PartRow.Caption = "Код партии в системе";
            this.colID_PartRow.FieldName = "ID_PartRow";
            this.colID_PartRow.Name = "colID_PartRow";
            this.colID_PartRow.Visible = true;
            this.colID_PartRow.VisibleIndex = 2;
            this.colID_PartRow.Width = 122;
            // 
            // colID_Product
            // 
            this.colID_Product.Caption = "Артикул";
            this.colID_Product.FieldName = "ID_Product";
            this.colID_Product.Name = "colID_Product";
            this.colID_Product.Visible = true;
            this.colID_Product.VisibleIndex = 3;
            // 
            // colProduct_Description
            // 
            this.colProduct_Description.Caption = "Название";
            this.colProduct_Description.FieldName = "Product_Description";
            this.colProduct_Description.Name = "colProduct_Description";
            this.colProduct_Description.Visible = true;
            this.colProduct_Description.VisibleIndex = 4;
            this.colProduct_Description.Width = 76;
            // 
            // colQty
            // 
            this.colQty.Caption = "Кол-во";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 5;
            // 
            // colSeria
            // 
            this.colSeria.Caption = "Серия";
            this.colSeria.FieldName = "Seria";
            this.colSeria.Name = "colSeria";
            this.colSeria.Visible = true;
            this.colSeria.VisibleIndex = 6;
            // 
            // colExp_Date
            // 
            this.colExp_Date.Caption = "Срок";
            this.colExp_Date.FieldName = "Exp_Date";
            this.colExp_Date.Name = "colExp_Date";
            this.colExp_Date.Visible = true;
            this.colExp_Date.VisibleIndex = 7;
            this.colExp_Date.Width = 67;
            // 
            // colNumRow
            // 
            this.colNumRow.FieldName = "NumRow";
            this.colNumRow.Name = "colNumRow";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.findSkuTextEdit);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 22);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(878, 40);
            this.panelControl1.TabIndex = 0;
            // 
            // findSkuTextEdit
            // 
            this.findSkuTextEdit.EditValue = "D1;S09;R15;P02;L01";
            this.findSkuTextEdit.Location = new System.Drawing.Point(102, 4);
            this.findSkuTextEdit.Name = "findSkuTextEdit";
            this.findSkuTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.findSkuTextEdit.Properties.Appearance.Options.UseFont = true;
            this.findSkuTextEdit.Size = new System.Drawing.Size(196, 31);
            this.findSkuTextEdit.TabIndex = 1;
            this.findSkuTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindSkuTextEditKeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Адрес / Бар код:";
            // 
            // catalogZonesTableAdapter
            // 
            this.catalogZonesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmManualAddressReplenishment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 385);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.topPanelControl);
            this.Name = "FrmManualAddressReplenishment";
            this.Text = "FrmManualAddressReplenishment";
            this.Load += new System.EventHandler(this.FrmManualAddressReplenishmentLoad);
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).EndInit();
            this.topPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogZonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressReplenishmentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docForManualReplenishmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressReplenishmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSkuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl topPanelControl;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton deleteDocButton;
        private DevExpress.XtraEditors.SimpleButton savePrintDocButton;
        private DevExpress.XtraEditors.SimpleButton saveDocButton;
        private DevExpress.XtraEditors.LookUpEdit zoneLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton newDocButton;
        private DevExpress.XtraEditors.TextEdit numDocTextEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl addressReplenishmentGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView addressReplenishmentGridView;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit findSkuTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource catalogZonesBindingSource;
        private WMSDataSetTableAdapters.CatalogZonesTableAdapter catalogZonesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton openDocButton;
        private System.Windows.Forms.BindingSource docForManualReplenishmentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_AddressFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colID_AddressTo;
        private DevExpress.XtraGrid.Columns.GridColumn colID_AdressFromCatalogFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colID_AdressFromCatalogTo;
        private DevExpress.XtraGrid.Columns.GridColumn colStr_AddressFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colStr_AddressTo;
        private DevExpress.XtraGrid.Columns.GridColumn colID_PartRow;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSeria;
        private DevExpress.XtraGrid.Columns.GridColumn colExp_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colNumRow;
    }
}