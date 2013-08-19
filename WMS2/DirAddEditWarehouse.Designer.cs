namespace WMS.MainApplication
{
    partial class DirAddEditWarehouse
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
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.typeOfDistributionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.wMSDataSet = new WMS.MainApplication.WMSDataSet();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.catalogTypeOfDistributionWarehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalog_TypeOfDistributionWarehousesTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_TypeOfDistributionWarehousesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDistributionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTypeOfDistributionWarehousesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(175, 100);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(22, 100);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.Location = new System.Drawing.Point(126, 38);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(175, 20);
            this.descriptionTextEdit.TabIndex = 9;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(126, 12);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(175, 20);
            this.nameTextEdit.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Описание склада:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Название склада:";
            // 
            // typeOfDistributionLookUpEdit
            // 
            this.typeOfDistributionLookUpEdit.Location = new System.Drawing.Point(126, 64);
            this.typeOfDistributionLookUpEdit.Name = "typeOfDistributionLookUpEdit";
            this.typeOfDistributionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeOfDistributionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Описание", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.typeOfDistributionLookUpEdit.Properties.DataSource = this.catalogTypeOfDistributionWarehousesBindingSource;
            this.typeOfDistributionLookUpEdit.Properties.DisplayMember = "Name";
            this.typeOfDistributionLookUpEdit.Properties.NullText = "[Выбирите тип дистрибуции]";
            this.typeOfDistributionLookUpEdit.Properties.ValueMember = "ID";
            this.typeOfDistributionLookUpEdit.Size = new System.Drawing.Size(175, 20);
            this.typeOfDistributionLookUpEdit.TabIndex = 12;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(59, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Тип склада:";
            // 
            // catalogTypeOfDistributionWarehousesBindingSource
            // 
            this.catalogTypeOfDistributionWarehousesBindingSource.DataMember = "Catalog_TypeOfDistributionWarehouses";
            this.catalogTypeOfDistributionWarehousesBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalog_TypeOfDistributionWarehousesTableAdapter
            // 
            this.catalog_TypeOfDistributionWarehousesTableAdapter.ClearBeforeFill = true;
            // 
            // DirAddEditWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 135);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.typeOfDistributionLookUpEdit);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextEdit);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DirAddEditWarehouse";
            this.Text = "DirAddEditWarehouse";
            this.Load += new System.EventHandler(this.DirAddEditWarehouseLoad);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDistributionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTypeOfDistributionWarehousesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit typeOfDistributionLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource catalogTypeOfDistributionWarehousesBindingSource;
        private WMSDataSetTableAdapters.Catalog_TypeOfDistributionWarehousesTableAdapter catalog_TypeOfDistributionWarehousesTableAdapter;
    }
}