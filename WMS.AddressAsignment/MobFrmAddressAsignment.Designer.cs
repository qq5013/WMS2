namespace WMS.AddressAsignment
{
    partial class MobFrmAddressAsignment
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
            this.descriptionLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.findSkuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bodyPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getPartsFromSystemBindingSource = new System.Windows.Forms.BindingSource();
            this.partsFromSystemDataSet = new WMS.AddressAsignment.PartsFromSystemDataSet();
            this.addressAsignmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpartRowId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqtyDepot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colallowQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanalizNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateAnaliz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdressExists = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfindAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityOnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepozit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.getPartsFromSystemTableAdapter = new WMS.AddressAsignment.PartsFromSystemDataSetTableAdapters.GetPartsFromSystemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).BeginInit();
            this.topPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSkuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).BeginInit();
            this.bodyPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPartsFromSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsFromSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressAsignmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanelControl
            // 
            this.topPanelControl.Controls.Add(this.descriptionLabelControl);
            this.topPanelControl.Controls.Add(this.labelControl1);
            this.topPanelControl.Controls.Add(this.findSkuTextEdit);
            this.topPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelControl.Location = new System.Drawing.Point(0, 0);
            this.topPanelControl.Name = "topPanelControl";
            this.topPanelControl.Size = new System.Drawing.Size(232, 46);
            this.topPanelControl.TabIndex = 0;
            // 
            // descriptionLabelControl
            // 
            this.descriptionLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.descriptionLabelControl.Location = new System.Drawing.Point(4, 28);
            this.descriptionLabelControl.Name = "descriptionLabelControl";
            this.descriptionLabelControl.Size = new System.Drawing.Size(148, 12);
            this.descriptionLabelControl.TabIndex = 2;
            this.descriptionLabelControl.Text = "Bromhexin 25mg N50 (Germania)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.labelControl1.Location = new System.Drawing.Point(4, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 12);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Арт :";
            // 
            // findSkuTextEdit
            // 
            this.findSkuTextEdit.Location = new System.Drawing.Point(36, 7);
            this.findSkuTextEdit.Name = "findSkuTextEdit";
            this.findSkuTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.findSkuTextEdit.Properties.Appearance.Options.UseFont = true;
            this.findSkuTextEdit.Size = new System.Drawing.Size(100, 18);
            this.findSkuTextEdit.TabIndex = 0;
            this.findSkuTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindSkuTextEditKeyDown);
            // 
            // bodyPanelControl
            // 
            this.bodyPanelControl.Controls.Add(this.gridControl1);
            this.bodyPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanelControl.Location = new System.Drawing.Point(0, 46);
            this.bodyPanelControl.Name = "bodyPanelControl";
            this.bodyPanelControl.Size = new System.Drawing.Size(232, 234);
            this.bodyPanelControl.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.getPartsFromSystemBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.addressAsignmentGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(228, 230);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.addressAsignmentGridView});
            // 
            // getPartsFromSystemBindingSource
            // 
            this.getPartsFromSystemBindingSource.DataMember = "GetPartsFromSystem";
            this.getPartsFromSystemBindingSource.DataSource = this.partsFromSystemDataSet;
            // 
            // partsFromSystemDataSet
            // 
            this.partsFromSystemDataSet.DataSetName = "PartsFromSystemDataSet";
            this.partsFromSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressAsignmentGridView
            // 
            this.addressAsignmentGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.addressAsignmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpartRowId,
            this.colqtyDepot,
            this.colallowQty,
            this.colseria,
            this.colanalizNumber,
            this.coldateAnaliz,
            this.colexpirationDate,
            this.coladdressExists,
            this.coladdress,
            this.coladdAddress,
            this.colfindAddress,
            this.colQuantityOnAddress,
            this.colDepozit});
            this.addressAsignmentGridView.GridControl = this.gridControl1;
            this.addressAsignmentGridView.GroupCount = 1;
            this.addressAsignmentGridView.Name = "addressAsignmentGridView";
            this.addressAsignmentGridView.OptionsBehavior.Editable = false;
            this.addressAsignmentGridView.OptionsView.ColumnAutoWidth = false;
            this.addressAsignmentGridView.OptionsView.ShowGroupPanel = false;
            this.addressAsignmentGridView.OptionsView.ShowIndicator = false;
            this.addressAsignmentGridView.RowHeight = 20;
            this.addressAsignmentGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpartRowId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colpartRowId
            // 
            this.colpartRowId.Caption = "Код партии в системе";
            this.colpartRowId.FieldName = "partRowId";
            this.colpartRowId.Name = "colpartRowId";
            // 
            // colqtyDepot
            // 
            this.colqtyDepot.Caption = "Кол-во";
            this.colqtyDepot.FieldName = "qtyDepot";
            this.colqtyDepot.Name = "colqtyDepot";
            this.colqtyDepot.OptionsColumn.ReadOnly = true;
            this.colqtyDepot.Visible = true;
            this.colqtyDepot.VisibleIndex = 0;
            // 
            // colallowQty
            // 
            this.colallowQty.FieldName = "allowQty";
            this.colallowQty.Name = "colallowQty";
            this.colallowQty.OptionsColumn.ReadOnly = true;
            // 
            // colseria
            // 
            this.colseria.Caption = "Серия";
            this.colseria.FieldName = "seria";
            this.colseria.Name = "colseria";
            this.colseria.Visible = true;
            this.colseria.VisibleIndex = 2;
            // 
            // colanalizNumber
            // 
            this.colanalizNumber.FieldName = "analizNumber";
            this.colanalizNumber.Name = "colanalizNumber";
            // 
            // coldateAnaliz
            // 
            this.coldateAnaliz.FieldName = "dateAnaliz";
            this.coldateAnaliz.Name = "coldateAnaliz";
            // 
            // colexpirationDate
            // 
            this.colexpirationDate.Caption = "Срок";
            this.colexpirationDate.FieldName = "expirationDate";
            this.colexpirationDate.Name = "colexpirationDate";
            this.colexpirationDate.Visible = true;
            this.colexpirationDate.VisibleIndex = 3;
            // 
            // coladdressExists
            // 
            this.coladdressExists.FieldName = "addressExists";
            this.coladdressExists.Name = "coladdressExists";
            this.coladdressExists.OptionsColumn.ReadOnly = true;
            // 
            // coladdress
            // 
            this.coladdress.Caption = "Адрес";
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.OptionsColumn.ReadOnly = true;
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 4;
            // 
            // coladdAddress
            // 
            this.coladdAddress.FieldName = "addAddress";
            this.coladdAddress.Name = "coladdAddress";
            // 
            // colfindAddress
            // 
            this.colfindAddress.FieldName = "findAddress";
            this.colfindAddress.Name = "colfindAddress";
            // 
            // colQuantityOnAddress
            // 
            this.colQuantityOnAddress.FieldName = "QuantityOnAddress";
            this.colQuantityOnAddress.Name = "colQuantityOnAddress";
            this.colQuantityOnAddress.OptionsColumn.ReadOnly = true;
            // 
            // colDepozit
            // 
            this.colDepozit.Caption = "Склад";
            this.colDepozit.FieldName = "Depozit";
            this.colDepozit.Name = "colDepozit";
            this.colDepozit.Visible = true;
            this.colDepozit.VisibleIndex = 1;
            // 
            // getPartsFromSystemTableAdapter
            // 
            this.getPartsFromSystemTableAdapter.ClearBeforeFill = true;
            // 
            // MobFrmAddressAsignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 280);
            this.Controls.Add(this.bodyPanelControl);
            this.Controls.Add(this.topPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MobFrmAddressAsignment";
            this.Text = "Назначение адресов";
            this.Load += new System.EventHandler(this.MobFrmAddressAsignmentLoad);
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).EndInit();
            this.topPanelControl.ResumeLayout(false);
            this.topPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSkuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).EndInit();
            this.bodyPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPartsFromSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsFromSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressAsignmentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl topPanelControl;
        private DevExpress.XtraEditors.LabelControl descriptionLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit findSkuTextEdit;
        private DevExpress.XtraEditors.PanelControl bodyPanelControl;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView addressAsignmentGridView;
        private System.Windows.Forms.BindingSource getPartsFromSystemBindingSource;
        private PartsFromSystemDataSet partsFromSystemDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colpartRowId;
        private DevExpress.XtraGrid.Columns.GridColumn colqtyDepot;
        private DevExpress.XtraGrid.Columns.GridColumn colallowQty;
        private DevExpress.XtraGrid.Columns.GridColumn colseria;
        private DevExpress.XtraGrid.Columns.GridColumn colanalizNumber;
        private DevExpress.XtraGrid.Columns.GridColumn coldateAnaliz;
        private DevExpress.XtraGrid.Columns.GridColumn colexpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn coladdressExists;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn coladdAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colfindAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityOnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDepozit;
        private PartsFromSystemDataSetTableAdapters.GetPartsFromSystemTableAdapter getPartsFromSystemTableAdapter;


    }
}