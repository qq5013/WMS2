namespace WMS.Inventory
{
    partial class FrmInventory
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ownerLabel = new DevExpress.XtraEditors.LabelControl();
            this.label = new DevExpress.XtraEditors.LabelControl();
            this.newDocButton = new DevExpress.XtraEditors.SimpleButton();
            this.numDocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.numDoclabel = new DevExpress.XtraEditors.LabelControl();
            this.findTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.bodyPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.inventoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.docsRowsInventoryBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.Inventory.WMSDataSet();
            this.inventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyOld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_PartRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.docsRowsInventoryTableAdapter = new WMS.Inventory.WMSDataSetTableAdapters.DocsRowsInventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).BeginInit();
            this.topPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).BeginInit();
            this.bodyPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsRowsInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanelControl
            // 
            this.topPanelControl.Controls.Add(this.labelControl3);
            this.topPanelControl.Controls.Add(this.labelControl4);
            this.topPanelControl.Controls.Add(this.labelControl2);
            this.topPanelControl.Controls.Add(this.labelControl1);
            this.topPanelControl.Controls.Add(this.ownerLabel);
            this.topPanelControl.Controls.Add(this.label);
            this.topPanelControl.Controls.Add(this.newDocButton);
            this.topPanelControl.Controls.Add(this.numDocTextEdit);
            this.topPanelControl.Controls.Add(this.numDoclabel);
            this.topPanelControl.Controls.Add(this.findTextEdit);
            this.topPanelControl.Controls.Add(this.labelControl);
            this.topPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelControl.Location = new System.Drawing.Point(0, 0);
            this.topPanelControl.Name = "topPanelControl";
            this.topPanelControl.Size = new System.Drawing.Size(1029, 126);
            this.topPanelControl.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(194, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Дата исполнения";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(288, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "-----";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(288, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "2013-02-28";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(206, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Дата создания";
            // 
            // ownerLabel
            // 
            this.ownerLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ownerLabel.Location = new System.Drawing.Point(288, 59);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(134, 16);
            this.ownerLabel.TabIndex = 6;
            this.ownerLabel.Text = "[Romanciuc Serghei]";
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(169, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Создатель документа";
            // 
            // newDocButton
            // 
            this.newDocButton.Location = new System.Drawing.Point(403, 12);
            this.newDocButton.Name = "newDocButton";
            this.newDocButton.Size = new System.Drawing.Size(75, 34);
            this.newDocButton.TabIndex = 4;
            this.newDocButton.Text = "Новый \r\nдокумент";
            this.newDocButton.Click += new System.EventHandler(this.NewDocButtonClick);
            // 
            // numDocTextEdit
            // 
            this.numDocTextEdit.Enabled = false;
            this.numDocTextEdit.Location = new System.Drawing.Point(106, 77);
            this.numDocTextEdit.Name = "numDocTextEdit";
            this.numDocTextEdit.Size = new System.Drawing.Size(43, 20);
            this.numDocTextEdit.TabIndex = 3;
            // 
            // numDoclabel
            // 
            this.numDoclabel.Location = new System.Drawing.Point(11, 80);
            this.numDoclabel.Name = "numDoclabel";
            this.numDoclabel.Size = new System.Drawing.Size(89, 13);
            this.numDoclabel.TabIndex = 2;
            this.numDoclabel.Text = "Номер документа";
            // 
            // findTextEdit
            // 
            this.findTextEdit.EditValue = "D1;S09:R01;P01;L01";
            this.findTextEdit.Enabled = false;
            this.findTextEdit.Location = new System.Drawing.Point(183, 15);
            this.findTextEdit.Name = "findTextEdit";
            this.findTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.findTextEdit.Properties.Appearance.Options.UseFont = true;
            this.findTextEdit.Size = new System.Drawing.Size(197, 31);
            this.findTextEdit.TabIndex = 1;
            this.findTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindTextEditKeyDown);
            // 
            // labelControl
            // 
            this.labelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl.Location = new System.Drawing.Point(12, 22);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(159, 16);
            this.labelControl.TabIndex = 0;
            this.labelControl.Text = "Адрес / Артикул / Баркод :";
            // 
            // bodyPanelControl
            // 
            this.bodyPanelControl.Controls.Add(this.inventoryGridControl);
            this.bodyPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanelControl.Location = new System.Drawing.Point(0, 126);
            this.bodyPanelControl.Name = "bodyPanelControl";
            this.bodyPanelControl.Size = new System.Drawing.Size(1029, 384);
            this.bodyPanelControl.TabIndex = 1;
            // 
            // inventoryGridControl
            // 
            this.inventoryGridControl.DataSource = this.docsRowsInventoryBindingSource;
            this.inventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryGridControl.Location = new System.Drawing.Point(2, 2);
            this.inventoryGridControl.MainView = this.inventoryGridView;
            this.inventoryGridControl.Name = "inventoryGridControl";
            this.inventoryGridControl.Size = new System.Drawing.Size(1025, 380);
            this.inventoryGridControl.TabIndex = 0;
            this.inventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inventoryGridView});
            // 
            // docsRowsInventoryBindingSource
            // 
            this.docsRowsInventoryBindingSource.DataMember = "DocsRowsInventory";
            this.docsRowsInventoryBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Product,
            this.colQtyOld,
            this.colQtyNew,
            this.colAddress,
            this.colID_PartRow,
            this.colDescription,
            this.colSeries,
            this.colExpirationDate});
            this.inventoryGridView.GridControl = this.inventoryGridControl;
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.OptionsBehavior.Editable = false;
            this.inventoryGridView.OptionsView.ColumnAutoWidth = false;
            this.inventoryGridView.OptionsView.ShowFooter = true;
            this.inventoryGridView.OptionsView.ShowGroupPanel = false;
            this.inventoryGridView.OptionsView.ShowIndicator = false;
            // 
            // colID_Product
            // 
            this.colID_Product.Caption = "Артикул";
            this.colID_Product.FieldName = "ID_Product";
            this.colID_Product.Name = "colID_Product";
            this.colID_Product.Visible = true;
            this.colID_Product.VisibleIndex = 2;
            // 
            // colQtyOld
            // 
            this.colQtyOld.Caption = "Кол-во";
            this.colQtyOld.FieldName = "QtyOld";
            this.colQtyOld.Name = "colQtyOld";
            this.colQtyOld.Visible = true;
            this.colQtyOld.VisibleIndex = 4;
            this.colQtyOld.Width = 61;
            // 
            // colQtyNew
            // 
            this.colQtyNew.Caption = "Посчитанное кол-во";
            this.colQtyNew.FieldName = "QtyNew";
            this.colQtyNew.Name = "colQtyNew";
            this.colQtyNew.Visible = true;
            this.colQtyNew.VisibleIndex = 5;
            this.colQtyNew.Width = 169;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Адрес";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.ReadOnly = true;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 0;
            this.colAddress.Width = 118;
            // 
            // colID_PartRow
            // 
            this.colID_PartRow.Caption = "Код партии";
            this.colID_PartRow.FieldName = "ID_PartRow";
            this.colID_PartRow.Name = "colID_PartRow";
            this.colID_PartRow.Visible = true;
            this.colID_PartRow.VisibleIndex = 1;
            this.colID_PartRow.Width = 90;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Название";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 98;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 6;
            this.colSeries.Width = 134;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Срок годности";
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 7;
            this.colExpirationDate.Width = 111;
            // 
            // docsRowsInventoryTableAdapter
            // 
            this.docsRowsInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 510);
            this.Controls.Add(this.bodyPanelControl);
            this.Controls.Add(this.topPanelControl);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            this.Load += new System.EventHandler(this.FrmInventoryLoad);
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).EndInit();
            this.topPanelControl.ResumeLayout(false);
            this.topPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).EndInit();
            this.bodyPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsRowsInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl topPanelControl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl ownerLabel;
        private DevExpress.XtraEditors.LabelControl label;
        private DevExpress.XtraEditors.SimpleButton newDocButton;
        private DevExpress.XtraEditors.TextEdit numDocTextEdit;
        private DevExpress.XtraEditors.LabelControl numDoclabel;
        private DevExpress.XtraEditors.TextEdit findTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraEditors.PanelControl bodyPanelControl;
        private DevExpress.XtraGrid.GridControl inventoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView inventoryGridView;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource docsRowsInventoryBindingSource;
        private WMSDataSetTableAdapters.DocsRowsInventoryTableAdapter docsRowsInventoryTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyOld;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyNew;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colID_PartRow;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;


    }
}
