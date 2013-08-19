namespace WMS.MainApplication
{
    partial class FrmUpdate
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
            this.curentCopyFileLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.curentFileProgressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.allFilesProgressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.curentFileProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allFilesProgressBarControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Копирование файла:";
            // 
            // curentCopyFileLabelControl
            // 
            this.curentCopyFileLabelControl.Location = new System.Drawing.Point(125, 13);
            this.curentCopyFileLabelControl.Name = "curentCopyFileLabelControl";
            this.curentCopyFileLabelControl.Size = new System.Drawing.Size(38, 13);
            this.curentCopyFileLabelControl.TabIndex = 1;
            this.curentCopyFileLabelControl.Text = "файл...";
            // 
            // curentFileProgressBarControl
            // 
            this.curentFileProgressBarControl.Location = new System.Drawing.Point(12, 56);
            this.curentFileProgressBarControl.Name = "curentFileProgressBarControl";
            this.curentFileProgressBarControl.Size = new System.Drawing.Size(431, 18);
            this.curentFileProgressBarControl.TabIndex = 2;
            this.curentFileProgressBarControl.EditValueChanged += new System.EventHandler(this.ProgressBarControl1EditValueChanged);
            // 
            // allFilesProgressBarControl
            // 
            this.allFilesProgressBarControl.Location = new System.Drawing.Point(12, 98);
            this.allFilesProgressBarControl.Name = "allFilesProgressBarControl";
            this.allFilesProgressBarControl.Size = new System.Drawing.Size(431, 18);
            this.allFilesProgressBarControl.TabIndex = 3;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 139);
            this.Controls.Add(this.allFilesProgressBarControl);
            this.Controls.Add(this.curentFileProgressBarControl);
            this.Controls.Add(this.curentCopyFileLabelControl);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUpdate";
            this.Text = "Обновление программы";
            this.Load += new System.EventHandler(this.FrmUpdateLoad);
            ((System.ComponentModel.ISupportInitialize)(this.curentFileProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allFilesProgressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl curentCopyFileLabelControl;
        private DevExpress.XtraEditors.ProgressBarControl curentFileProgressBarControl;
        private DevExpress.XtraEditors.ProgressBarControl allFilesProgressBarControl;
    }
}