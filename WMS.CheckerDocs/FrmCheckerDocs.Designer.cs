namespace WMS.CheckerDocs
{
    partial class FrmCheckerDocs
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.docNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(19, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Документ № :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(65, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Статус :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(75, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Дата :";
            // 
            // groupControl
            // 
            this.groupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl.AppearanceCaption.Options.UseFont = true;
            this.groupControl.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl.Controls.Add(this.docNumberLabel);
            this.groupControl.Controls.Add(this.labelControl1);
            this.groupControl.Controls.Add(this.dateLabel);
            this.groupControl.Controls.Add(this.statusLabel);
            this.groupControl.Controls.Add(this.labelControl3);
            this.groupControl.Controls.Add(this.labelControl2);
            this.groupControl.Location = new System.Drawing.Point(12, 33);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(300, 136);
            this.groupControl.TabIndex = 0;
            this.groupControl.TabStop = true;
            this.groupControl.Text = "Просканируйте документ";
            // 
            // docNumberLabel
            // 
            this.docNumberLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.docNumberLabel.Location = new System.Drawing.Point(119, 50);
            this.docNumberLabel.Name = "docNumberLabel";
            this.docNumberLabel.Size = new System.Drawing.Size(24, 16);
            this.docNumberLabel.TabIndex = 0;
            this.docNumberLabel.Text = "----";
            // 
            // dateLabel
            // 
            this.dateLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(119, 95);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(24, 16);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "----";
            // 
            // statusLabel
            // 
            this.statusLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(119, 73);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(24, 16);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "----";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 7);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(301, 20);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            this.textEdit1.Leave += new System.EventHandler(this.textEdit1_Leave);
            // 
            // FrmCheckerDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 181);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.groupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmCheckerDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выборочная проверка документов";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCheckerDocsKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.LabelControl docNumberLabel;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraEditors.LabelControl statusLabel;
        private DevExpress.XtraEditors.TextEdit textEdit1;


    }
}
