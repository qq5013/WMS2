namespace WMS.MainApplication
{
    partial class DirAddEditUnit
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
            this.sizeOfUnitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.distanceBetweenUnitsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfUnitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBetweenUnitsTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(175, 18);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(153, 20);
            this.nameTextEdit.TabIndex = 0;
            // 
            // sizeOfUnitTextEdit
            // 
            this.sizeOfUnitTextEdit.Location = new System.Drawing.Point(175, 44);
            this.sizeOfUnitTextEdit.Name = "sizeOfUnitTextEdit";
            this.sizeOfUnitTextEdit.Properties.Mask.EditMask = "f";
            this.sizeOfUnitTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.sizeOfUnitTextEdit.Size = new System.Drawing.Size(153, 20);
            this.sizeOfUnitTextEdit.TabIndex = 1;
            // 
            // distanceBetweenUnitsTextEdit
            // 
            this.distanceBetweenUnitsTextEdit.Location = new System.Drawing.Point(175, 70);
            this.distanceBetweenUnitsTextEdit.Name = "distanceBetweenUnitsTextEdit";
            this.distanceBetweenUnitsTextEdit.Properties.Mask.EditMask = "f";
            this.distanceBetweenUnitsTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.distanceBetweenUnitsTextEdit.Size = new System.Drawing.Size(153, 20);
            this.distanceBetweenUnitsTextEdit.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(114, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Название :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Размер одного деления :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(159, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Расстояние между делениями :";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(31, 103);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(225, 103);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DirAddEditUnit
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(365, 138);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.distanceBetweenUnitsTextEdit);
            this.Controls.Add(this.sizeOfUnitTextEdit);
            this.Controls.Add(this.nameTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DirAddEditUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirAddEditUnit";
            this.Load += new System.EventHandler(this.DirAddEditUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfUnitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBetweenUnitsTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit sizeOfUnitTextEdit;
        private DevExpress.XtraEditors.TextEdit distanceBetweenUnitsTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
    }
}