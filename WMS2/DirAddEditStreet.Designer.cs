namespace WMS.MainApplication
{
    partial class DirAddEditStreet
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
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.zonaLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catalogZonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new WMS.MainApplication.WMSDataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.catalog_ZonesTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_ZonesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogZonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(116, 18);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(141, 20);
            this.nameTextEdit.TabIndex = 0;
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.Location = new System.Drawing.Point(116, 44);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(141, 20);
            this.descriptionTextEdit.TabIndex = 1;
            // 
            // zonaLookUpEdit
            // 
            this.zonaLookUpEdit.Location = new System.Drawing.Point(116, 70);
            this.zonaLookUpEdit.Name = "zonaLookUpEdit";
            this.zonaLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.zonaLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Код", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.zonaLookUpEdit.Properties.DataSource = this.catalogZonesBindingSource;
            this.zonaLookUpEdit.Properties.DisplayMember = "Name";
            this.zonaLookUpEdit.Properties.NullText = "[Укажите зону]";
            this.zonaLookUpEdit.Properties.ValueMember = "ID";
            this.zonaLookUpEdit.Size = new System.Drawing.Size(141, 20);
            this.zonaLookUpEdit.TabIndex = 2;
            // 
            // catalogZonesBindingSource
            // 
            this.catalogZonesBindingSource.DataMember = "Catalog_Zones";
            this.catalogZonesBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Название улицы :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Описание улицы :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(79, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Зона :";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(35, 105);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(182, 105);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // catalog_ZonesTableAdapter
            // 
            this.catalog_ZonesTableAdapter.ClearBeforeFill = true;
            // 
            // DirAddEditStreet
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(289, 140);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.zonaLookUpEdit);
            this.Controls.Add(this.descriptionTextEdit);
            this.Controls.Add(this.nameTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DirAddEditStreet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirAddEditStreet";
            this.Load += new System.EventHandler(this.DirAddEditStreetLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogZonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.LookUpEdit zonaLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource catalogZonesBindingSource;
        private WMSDataSetTableAdapters.Catalog_ZonesTableAdapter catalog_ZonesTableAdapter;
    }
}