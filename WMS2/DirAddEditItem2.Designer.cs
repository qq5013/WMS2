using WMS.MainApplication.WMSDataSetTableAdapters;

namespace WMS.MainApplication
{
    partial class DirAddEditItem2
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
            this.nameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.descriptionLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.heightLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.dephLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.rotationLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.heightTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dephTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.rotationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.wMSDataSet = new WMS.MainApplication.WMSDataSet();
            this.catalogRotationsProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalog_RotationsProductTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_RotationsProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dephTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRotationsProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabelControl
            // 
            this.nameLabelControl.Location = new System.Drawing.Point(37, 23);
            this.nameLabelControl.Name = "nameLabelControl";
            this.nameLabelControl.Size = new System.Drawing.Size(85, 13);
            this.nameLabelControl.TabIndex = 0;
            this.nameLabelControl.Text = "Название полки:";
            // 
            // descriptionLabelControl
            // 
            this.descriptionLabelControl.Location = new System.Drawing.Point(36, 49);
            this.descriptionLabelControl.Name = "descriptionLabelControl";
            this.descriptionLabelControl.Size = new System.Drawing.Size(86, 13);
            this.descriptionLabelControl.TabIndex = 1;
            this.descriptionLabelControl.Text = "Описание полки:";
            // 
            // heightLabelControl
            // 
            this.heightLabelControl.Location = new System.Drawing.Point(26, 75);
            this.heightLabelControl.Name = "heightLabelControl";
            this.heightLabelControl.Size = new System.Drawing.Size(96, 13);
            this.heightLabelControl.TabIndex = 2;
            this.heightLabelControl.Text = "Высота полки (см):";
            // 
            // dephLabelControl
            // 
            this.dephLabelControl.Location = new System.Drawing.Point(21, 101);
            this.dephLabelControl.Name = "dephLabelControl";
            this.dephLabelControl.Size = new System.Drawing.Size(101, 13);
            this.dephLabelControl.TabIndex = 3;
            this.dephLabelControl.Text = "Глубина полки (см):";
            // 
            // rotationLabelControl
            // 
            this.rotationLabelControl.Location = new System.Drawing.Point(55, 127);
            this.rotationLabelControl.Name = "rotationLabelControl";
            this.rotationLabelControl.Size = new System.Drawing.Size(67, 13);
            this.rotationLabelControl.TabIndex = 4;
            this.rotationLabelControl.Text = "Тип ротации:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(128, 20);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(156, 20);
            this.nameTextEdit.TabIndex = 5;
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.Location = new System.Drawing.Point(128, 46);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(156, 20);
            this.descriptionTextEdit.TabIndex = 6;
            // 
            // heightTextEdit
            // 
            this.heightTextEdit.Location = new System.Drawing.Point(128, 72);
            this.heightTextEdit.Name = "heightTextEdit";
            this.heightTextEdit.Properties.Mask.BeepOnError = true;
            this.heightTextEdit.Properties.Mask.EditMask = "f";
            this.heightTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.heightTextEdit.Size = new System.Drawing.Size(123, 20);
            this.heightTextEdit.TabIndex = 7;
            // 
            // dephTextEdit
            // 
            this.dephTextEdit.Location = new System.Drawing.Point(128, 98);
            this.dephTextEdit.Name = "dephTextEdit";
            this.dephTextEdit.Properties.Mask.EditMask = "f";
            this.dephTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.dephTextEdit.Size = new System.Drawing.Size(123, 20);
            this.dephTextEdit.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(21, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(181, 160);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rotationLookUpEdit
            // 
            this.rotationLookUpEdit.Location = new System.Drawing.Point(128, 124);
            this.rotationLookUpEdit.Name = "rotationLookUpEdit";
            this.rotationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rotationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MinQty", "Минимум", 47, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaxQty", "Максимум", 51, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.rotationLookUpEdit.Properties.DataSource = this.catalogRotationsProductBindingSource;
            this.rotationLookUpEdit.Properties.DisplayMember = "Name";
            this.rotationLookUpEdit.Properties.NullText = "[Выбери из списка]";
            this.rotationLookUpEdit.Properties.ValueMember = "ID";
            this.rotationLookUpEdit.Size = new System.Drawing.Size(123, 20);
            this.rotationLookUpEdit.TabIndex = 12;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogRotationsProductBindingSource
            // 
            this.catalogRotationsProductBindingSource.DataMember = "Catalog_RotationsProduct";
            this.catalogRotationsProductBindingSource.DataSource = this.wMSDataSet;
            // 
            // catalog_RotationsProductTableAdapter
            // 
            this.catalog_RotationsProductTableAdapter.ClearBeforeFill = true;
            // 
            // DirAddEditItem2
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(313, 196);
            this.Controls.Add(this.rotationLookUpEdit);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dephTextEdit);
            this.Controls.Add(this.heightTextEdit);
            this.Controls.Add(this.descriptionTextEdit);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.rotationLabelControl);
            this.Controls.Add(this.dephLabelControl);
            this.Controls.Add(this.heightLabelControl);
            this.Controls.Add(this.descriptionLabelControl);
            this.Controls.Add(this.nameLabelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DirAddEditItem2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirAddEditItem2";
            this.Load += new System.EventHandler(this.DirAddEditItem2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dephTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogRotationsProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl nameLabelControl;
        private DevExpress.XtraEditors.LabelControl descriptionLabelControl;
        private DevExpress.XtraEditors.LabelControl heightLabelControl;
        private DevExpress.XtraEditors.LabelControl dephLabelControl;
        private DevExpress.XtraEditors.LabelControl rotationLabelControl;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit heightTextEdit;
        private DevExpress.XtraEditors.TextEdit dephTextEdit;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.LookUpEdit rotationLookUpEdit;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource catalogRotationsProductBindingSource;
        private WMSDataSetTableAdapters.Catalog_RotationsProductTableAdapter catalog_RotationsProductTableAdapter;
    }
}