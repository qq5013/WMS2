namespace WMS.MainApplication
{
    partial class DirAddEditProducts
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
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.barCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.demensionXtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.demensionYtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.demensionZtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.multiplicityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.weightTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.catalogGroupBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.MainApplication.WMSDataSet();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.catalog_GroupTableAdapter = new WMS.MainApplication.WMSDataSetTableAdapters.Catalog_GroupTableAdapter();
            this.groupCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demensionXtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demensionYtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demensionZtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCheckedListBoxControl)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(84, 22);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.ReadOnly = true;
            this.nameTextEdit.Size = new System.Drawing.Size(197, 20);
            this.nameTextEdit.TabIndex = 0;
            this.nameTextEdit.ToolTip = "kuku";
            this.nameTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.nameTextEdit.ToolTipTitle = "Описание";
            // 
            // barCodeTextEdit
            // 
            this.barCodeTextEdit.Enabled = false;
            this.barCodeTextEdit.Location = new System.Drawing.Point(84, 48);
            this.barCodeTextEdit.Name = "barCodeTextEdit";
            this.barCodeTextEdit.Size = new System.Drawing.Size(85, 20);
            this.barCodeTextEdit.TabIndex = 2;
            // 
            // demensionXtextEdit
            // 
            this.demensionXtextEdit.Location = new System.Drawing.Point(84, 74);
            this.demensionXtextEdit.Name = "demensionXtextEdit";
            this.demensionXtextEdit.Properties.Mask.EditMask = "f";
            this.demensionXtextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.demensionXtextEdit.Size = new System.Drawing.Size(85, 20);
            this.demensionXtextEdit.TabIndex = 0;
            // 
            // demensionYtextEdit
            // 
            this.demensionYtextEdit.Location = new System.Drawing.Point(84, 100);
            this.demensionYtextEdit.Name = "demensionYtextEdit";
            this.demensionYtextEdit.Properties.Mask.EditMask = "f";
            this.demensionYtextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.demensionYtextEdit.Size = new System.Drawing.Size(85, 20);
            this.demensionYtextEdit.TabIndex = 3;
            // 
            // demensionZtextEdit
            // 
            this.demensionZtextEdit.Location = new System.Drawing.Point(84, 126);
            this.demensionZtextEdit.Name = "demensionZtextEdit";
            this.demensionZtextEdit.Properties.Mask.EditMask = "f";
            this.demensionZtextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.demensionZtextEdit.Size = new System.Drawing.Size(85, 20);
            this.demensionZtextEdit.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Название:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Бар код:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Ширина X:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Высота Y:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 129);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Глубина Z:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(34, 214);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(187, 214);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // multiplicityTextEdit
            // 
            this.multiplicityTextEdit.Location = new System.Drawing.Point(84, 178);
            this.multiplicityTextEdit.Name = "multiplicityTextEdit";
            this.multiplicityTextEdit.Properties.Mask.EditMask = "d";
            this.multiplicityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.multiplicityTextEdit.Size = new System.Drawing.Size(85, 20);
            this.multiplicityTextEdit.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 181);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Кратность:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(57, 155);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(21, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Вес:";
            // 
            // weightTextEdit
            // 
            this.weightTextEdit.Location = new System.Drawing.Point(84, 152);
            this.weightTextEdit.Name = "weightTextEdit";
            this.weightTextEdit.Properties.Mask.EditMask = "f";
            this.weightTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.weightTextEdit.Size = new System.Drawing.Size(85, 20);
            this.weightTextEdit.TabIndex = 5;
            // 
            // catalogGroupBindingSource
            // 
            this.catalogGroupBindingSource.DataMember = "Catalog_Group";
            this.catalogGroupBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(198, 48);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Зональная группа:";
            // 
            // catalog_GroupTableAdapter
            // 
            this.catalog_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // groupCheckedListBoxControl
            // 
            this.groupCheckedListBoxControl.CheckOnClick = true;
            this.groupCheckedListBoxControl.DataSource = this.catalogGroupBindingSource;
            this.groupCheckedListBoxControl.DisplayMember = "NameGroup";
            this.groupCheckedListBoxControl.Location = new System.Drawing.Point(181, 67);
            this.groupCheckedListBoxControl.Name = "groupCheckedListBoxControl";
            this.groupCheckedListBoxControl.Size = new System.Drawing.Size(125, 131);
            this.groupCheckedListBoxControl.TabIndex = 7;
            this.groupCheckedListBoxControl.ValueMember = "ID";
            // 
            // DirAddEditProducts
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(322, 251);
            this.Controls.Add(this.groupCheckedListBoxControl);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.weightTextEdit);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.multiplicityTextEdit);
            this.Controls.Add(this.demensionZtextEdit);
            this.Controls.Add(this.demensionYtextEdit);
            this.Controls.Add(this.demensionXtextEdit);
            this.Controls.Add(this.barCodeTextEdit);
            this.Controls.Add(this.nameTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DirAddEditProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirAddEditProducts";
            this.Load += new System.EventHandler(this.DirAddEditProductsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demensionXtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demensionYtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demensionZtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCheckedListBoxControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit barCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit demensionXtextEdit;
        private DevExpress.XtraEditors.TextEdit demensionYtextEdit;
        private DevExpress.XtraEditors.TextEdit demensionZtextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.TextEdit multiplicityTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit weightTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource catalogGroupBindingSource;
        private WMSDataSetTableAdapters.Catalog_GroupTableAdapter catalog_GroupTableAdapter;
        private DevExpress.XtraEditors.CheckedListBoxControl groupCheckedListBoxControl;
    }
}