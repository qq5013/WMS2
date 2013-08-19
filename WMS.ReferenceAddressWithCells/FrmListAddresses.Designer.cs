namespace WMS.ReferenceAddressWithCells
{
    partial class FrmListAddresses
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
            this.listAddressGridControl = new DevExpress.XtraGrid.GridControl();
            this.listAddressForProductBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.ReferenceAddressWithCells.WMSDataSet();
            this.listAddressGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listAddressForProductTableAdapter = new WMS.ReferenceAddressWithCells.WMSDataSetTableAdapters.ListAddressForProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listAddressGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAddressForProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAddressGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listAddressGridControl
            // 
            this.listAddressGridControl.DataSource = this.listAddressForProductBindingSource;
            this.listAddressGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAddressGridControl.Location = new System.Drawing.Point(0, 0);
            this.listAddressGridControl.MainView = this.listAddressGridView;
            this.listAddressGridControl.Name = "listAddressGridControl";
            this.listAddressGridControl.Size = new System.Drawing.Size(464, 203);
            this.listAddressGridControl.TabIndex = 0;
            this.listAddressGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listAddressGridView});
            // 
            // listAddressForProductBindingSource
            // 
            this.listAddressForProductBindingSource.DataMember = "ListAddressForProduct";
            this.listAddressForProductBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listAddressGridView
            // 
            this.listAddressGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colADDRESS,
            this.colSeries,
            this.colExpirationDate});
            this.listAddressGridView.GridControl = this.listAddressGridControl;
            this.listAddressGridView.Name = "listAddressGridView";
            this.listAddressGridView.OptionsBehavior.Editable = false;
            this.listAddressGridView.OptionsBehavior.ReadOnly = true;
            this.listAddressGridView.OptionsView.AllowHtmlDrawHeaders = true;
            this.listAddressGridView.OptionsView.ShowColumnHeaders = false;
            this.listAddressGridView.OptionsView.ShowGroupPanel = false;
            this.listAddressGridView.OptionsView.ShowIndicator = false;
            this.listAddressGridView.RowHeight = 40;
            this.listAddressGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListAddressGridViewKeyDown);
            this.listAddressGridView.DoubleClick += new System.EventHandler(this.ListAddressGridViewDoubleClick);
            // 
            // colADDRESS
            // 
            this.colADDRESS.AppearanceCell.Options.UseTextOptions = true;
            this.colADDRESS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colADDRESS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADDRESS.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colADDRESS.FieldName = "ADDRESS";
            this.colADDRESS.Name = "colADDRESS";
            this.colADDRESS.Visible = true;
            this.colADDRESS.VisibleIndex = 0;
            // 
            // colSeries
            // 
            this.colSeries.AppearanceCell.Options.UseTextOptions = true;
            this.colSeries.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeries.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSeries.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 1;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colExpirationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExpirationDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colExpirationDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 2;
            // 
            // listAddressForProductTableAdapter
            // 
            this.listAddressForProductTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 203);
            this.Controls.Add(this.listAddressGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListAddresses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список адресов для товара";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListAddressesFormClosing);
            this.Load += new System.EventHandler(this.FrmListAddressesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.listAddressGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAddressForProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAddressGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl listAddressGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView listAddressGridView;
        private System.Windows.Forms.BindingSource listAddressForProductBindingSource;
        private WMSDataSet wMSDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
        private WMSDataSetTableAdapters.ListAddressForProductTableAdapter listAddressForProductTableAdapter;
    }
}