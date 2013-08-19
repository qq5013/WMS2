namespace WMS.AddressAsignment
{
    partial class FrmListNonAcceptedDocs
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.acceptButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.docsGridControl = new DevExpress.XtraGrid.GridControl();
            this.listDocBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.AddressAsignment.WMSDataSet();
            this.docsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocSumm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rowsDocGridControl = new DevExpress.XtraGrid.GridControl();
            this.listRowsDocBindingSource = new System.Windows.Forms.BindingSource();
            this.rowsDocGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltpr1003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltpr1004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colass1003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listDocTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.ListDocTableAdapter();
            this.listRowsDocTableAdapter = new WMS.AddressAsignment.WMSDataSetTableAdapters.ListRowsDocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsDocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRowsDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsDocGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 558);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(983, 28);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl2.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.acceptButton);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.cancelButton);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(979, 24);
            this.splitContainerControl2.SplitterPosition = 458;
            this.splitContainerControl2.TabIndex = 2;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // acceptButton
            // 
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptButton.Location = new System.Drawing.Point(0, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(458, 24);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Ок [Enter]";
            this.acceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(0, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(516, 24);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отмена [Esc]";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.docsGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.rowsDocGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(983, 558);
            this.splitContainerControl1.SplitterPosition = 460;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // docsGridControl
            // 
            this.docsGridControl.DataSource = this.listDocBindingSource;
            this.docsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docsGridControl.Location = new System.Drawing.Point(0, 0);
            this.docsGridControl.MainView = this.docsGridView;
            this.docsGridControl.Name = "docsGridControl";
            this.docsGridControl.Size = new System.Drawing.Size(460, 558);
            this.docsGridControl.TabIndex = 0;
            this.docsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.docsGridView});
            // 
            // listDocBindingSource
            // 
            this.listDocBindingSource.DataMember = "ListDoc";
            this.listDocBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docsGridView
            // 
            this.docsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocId,
            this.colDocNumber,
            this.colDocDate,
            this.colDocSupplier,
            this.colDocSumm,
            this.colDocWarehouse});
            this.docsGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.docsGridView.GridControl = this.docsGridControl;
            this.docsGridView.Name = "docsGridView";
            this.docsGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.docsGridView.OptionsBehavior.Editable = false;
            this.docsGridView.OptionsBehavior.ReadOnly = true;
            this.docsGridView.OptionsView.AutoCalcPreviewLineCount = true;
            this.docsGridView.OptionsView.ColumnAutoWidth = false;
            this.docsGridView.OptionsView.ShowGroupPanel = false;
            this.docsGridView.OptionsView.ShowIndicator = false;
            this.docsGridView.PaintStyleName = "Skin";
            this.docsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.DocsGridViewFocusedRowChanged);
            // 
            // colDocId
            // 
            this.colDocId.FieldName = "PRI1001";
            this.colDocId.Name = "colDocId";
            // 
            // colDocNumber
            // 
            this.colDocNumber.Caption = "Номер";
            this.colDocNumber.FieldName = "PRI1003";
            this.colDocNumber.Name = "colDocNumber";
            this.colDocNumber.Visible = true;
            this.colDocNumber.VisibleIndex = 0;
            this.colDocNumber.Width = 56;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Дата";
            this.colDocDate.FieldName = "PRI1006";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 1;
            this.colDocDate.Width = 66;
            // 
            // colDocSupplier
            // 
            this.colDocSupplier.Caption = "Поставщик";
            this.colDocSupplier.FieldName = "POS1002";
            this.colDocSupplier.Name = "colDocSupplier";
            this.colDocSupplier.Visible = true;
            this.colDocSupplier.VisibleIndex = 2;
            this.colDocSupplier.Width = 165;
            // 
            // colDocSumm
            // 
            this.colDocSumm.Caption = "Сумма";
            this.colDocSumm.FieldName = "PRI1014";
            this.colDocSumm.Name = "colDocSumm";
            this.colDocSumm.Visible = true;
            this.colDocSumm.VisibleIndex = 3;
            this.colDocSumm.Width = 60;
            // 
            // colDocWarehouse
            // 
            this.colDocWarehouse.Caption = "Склад";
            this.colDocWarehouse.FieldName = "SKL1002";
            this.colDocWarehouse.Name = "colDocWarehouse";
            this.colDocWarehouse.Visible = true;
            this.colDocWarehouse.VisibleIndex = 4;
            this.colDocWarehouse.Width = 99;
            // 
            // rowsDocGridControl
            // 
            this.rowsDocGridControl.DataSource = this.listRowsDocBindingSource;
            this.rowsDocGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowsDocGridControl.Location = new System.Drawing.Point(0, 0);
            this.rowsDocGridControl.MainView = this.rowsDocGridView;
            this.rowsDocGridControl.Name = "rowsDocGridControl";
            this.rowsDocGridControl.Size = new System.Drawing.Size(518, 558);
            this.rowsDocGridControl.TabIndex = 0;
            this.rowsDocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rowsDocGridView});
            // 
            // listRowsDocBindingSource
            // 
            this.listRowsDocBindingSource.DataMember = "ListRowsDoc";
            this.listRowsDocBindingSource.DataSource = this.wMSDataSet;
            // 
            // rowsDocGridView
            // 
            this.rowsDocGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltpr1003,
            this.coltpr1004,
            this.colass1003,
            this.colqty});
            this.rowsDocGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.rowsDocGridView.GridControl = this.rowsDocGridControl;
            this.rowsDocGridView.Name = "rowsDocGridView";
            this.rowsDocGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.rowsDocGridView.OptionsBehavior.Editable = false;
            this.rowsDocGridView.OptionsBehavior.ReadOnly = true;
            this.rowsDocGridView.OptionsView.ColumnAutoWidth = false;
            this.rowsDocGridView.OptionsView.ShowGroupPanel = false;
            this.rowsDocGridView.OptionsView.ShowIndicator = false;
            // 
            // coltpr1003
            // 
            this.coltpr1003.Caption = "№ п/п";
            this.coltpr1003.FieldName = "tpr1003";
            this.coltpr1003.Name = "coltpr1003";
            this.coltpr1003.Visible = true;
            this.coltpr1003.VisibleIndex = 0;
            this.coltpr1003.Width = 42;
            // 
            // coltpr1004
            // 
            this.coltpr1004.Caption = "Артикул";
            this.coltpr1004.FieldName = "tpr1004";
            this.coltpr1004.Name = "coltpr1004";
            this.coltpr1004.Visible = true;
            this.coltpr1004.VisibleIndex = 1;
            this.coltpr1004.Width = 53;
            // 
            // colass1003
            // 
            this.colass1003.Caption = "Товар";
            this.colass1003.FieldName = "ass1003";
            this.colass1003.Name = "colass1003";
            this.colass1003.OptionsColumn.ReadOnly = true;
            this.colass1003.Visible = true;
            this.colass1003.VisibleIndex = 2;
            this.colass1003.Width = 269;
            // 
            // colqty
            // 
            this.colqty.Caption = "Количество";
            this.colqty.FieldName = "qty";
            this.colqty.Name = "colqty";
            this.colqty.OptionsColumn.ReadOnly = true;
            this.colqty.Visible = true;
            this.colqty.VisibleIndex = 3;
            // 
            // listDocTableAdapter
            // 
            this.listDocTableAdapter.ClearBeforeFill = true;
            // 
            // listRowsDocTableAdapter
            // 
            this.listRowsDocTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListNonAcceptedDocs
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(983, 586);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmListNonAcceptedDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список документов";
            this.Load += new System.EventHandler(this.FrmListNonAcceptedDocsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsDocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRowsDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsDocGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SimpleButton acceptButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl docsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView docsGridView;
        private DevExpress.XtraGrid.GridControl rowsDocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView rowsDocGridView;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource listDocBindingSource;
        private WMSDataSetTableAdapters.ListDocTableAdapter listDocTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDocId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDocSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colDocSumm;
        private DevExpress.XtraGrid.Columns.GridColumn colDocWarehouse;
        private System.Windows.Forms.BindingSource listRowsDocBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coltpr1003;
        private DevExpress.XtraGrid.Columns.GridColumn coltpr1004;
        private DevExpress.XtraGrid.Columns.GridColumn colass1003;
        private DevExpress.XtraGrid.Columns.GridColumn colqty;
        private WMSDataSetTableAdapters.ListRowsDocTableAdapter listRowsDocTableAdapter;
    }
}