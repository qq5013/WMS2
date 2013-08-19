namespace WMS.AddressAsignment
{
    partial class FrmChangeTypeEnterData
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
            this.scanOneButton = new DevExpress.XtraEditors.SimpleButton();
            this.scanQtyButton = new DevExpress.XtraEditors.SimpleButton();
            this.enterManualQtyButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // scanOneButton
            // 
            this.scanOneButton.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.scanOneButton.Appearance.Options.UseFont = true;
            this.scanOneButton.Location = new System.Drawing.Point(12, 12);
            this.scanOneButton.Name = "scanOneButton";
            this.scanOneButton.Size = new System.Drawing.Size(365, 47);
            this.scanOneButton.TabIndex = 0;
            this.scanOneButton.Text = "Сканирование + 1";
            this.scanOneButton.Click += new System.EventHandler(this.ScanOneButtonClick);
            // 
            // scanQtyButton
            // 
            this.scanQtyButton.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.scanQtyButton.Appearance.Options.UseFont = true;
            this.scanQtyButton.Location = new System.Drawing.Point(12, 65);
            this.scanQtyButton.Name = "scanQtyButton";
            this.scanQtyButton.Size = new System.Drawing.Size(365, 47);
            this.scanQtyButton.TabIndex = 1;
            this.scanQtyButton.Text = "Сканирование + количество";
            this.scanQtyButton.Click += new System.EventHandler(this.ScanQtyButtonClick);
            // 
            // enterManualQtyButton
            // 
            this.enterManualQtyButton.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.enterManualQtyButton.Appearance.Options.UseFont = true;
            this.enterManualQtyButton.Location = new System.Drawing.Point(12, 118);
            this.enterManualQtyButton.Name = "enterManualQtyButton";
            this.enterManualQtyButton.Size = new System.Drawing.Size(365, 47);
            this.enterManualQtyButton.TabIndex = 2;
            this.enterManualQtyButton.Text = "Ввод количество по справочнику";
            this.enterManualQtyButton.Click += new System.EventHandler(this.EnterManualQtyButtonClick);
            // 
            // FrmChangeTypeEnterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 172);
            this.Controls.Add(this.enterManualQtyButton);
            this.Controls.Add(this.scanQtyButton);
            this.Controls.Add(this.scanOneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmChangeTypeEnterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Укажите режим работы";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton scanOneButton;
        private DevExpress.XtraEditors.SimpleButton scanQtyButton;
        private DevExpress.XtraEditors.SimpleButton enterManualQtyButton;
    }
}