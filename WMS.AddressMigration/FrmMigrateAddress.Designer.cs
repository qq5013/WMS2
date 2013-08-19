namespace WMS.AddressMigration
{
    partial class FrmMigrateAddress
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
            this.migrateQtySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.moveQtyButton = new DevExpress.XtraEditors.SimpleButton();
            this.addressFromLabel = new DevExpress.XtraEditors.LabelControl();
            this.addressToLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.decriptionLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.seriaLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.analisysLabel = new DevExpress.XtraEditors.LabelControl();
            this.expirationDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.partLabel = new DevExpress.XtraEditors.LabelControl();
            this.migarteButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.allowQtyTextEdit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.migrateQtySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowQtyTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // migrateQtySpinEdit
            // 
            this.migrateQtySpinEdit.EditValue = new decimal(new int[] {
            160040020,
            0,
            0,
            131072});
            this.migrateQtySpinEdit.Location = new System.Drawing.Point(235, 82);
            this.migrateQtySpinEdit.Name = "migrateQtySpinEdit";
            this.migrateQtySpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.migrateQtySpinEdit.Properties.Appearance.Options.UseFont = true;
            this.migrateQtySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.migrateQtySpinEdit.Properties.Mask.EditMask = "f";
            this.migrateQtySpinEdit.Size = new System.Drawing.Size(164, 39);
            this.migrateQtySpinEdit.TabIndex = 1;
            this.migrateQtySpinEdit.EditValueChanged += new System.EventHandler(this.MigrateQtySpinEditEditValueChanged);
            this.migrateQtySpinEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.MigrateQtySpinEditEditValueChanging);
            // 
            // moveQtyButton
            // 
            this.moveQtyButton.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.moveQtyButton.Appearance.Options.UseFont = true;
            this.moveQtyButton.Location = new System.Drawing.Point(184, 82);
            this.moveQtyButton.Name = "moveQtyButton";
            this.moveQtyButton.Size = new System.Drawing.Size(47, 39);
            this.moveQtyButton.TabIndex = 2;
            this.moveQtyButton.Text = ">>";
            this.moveQtyButton.Click += new System.EventHandler(this.MoveQtyButtonClick);
            // 
            // addressFromLabel
            // 
            this.addressFromLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.addressFromLabel.Location = new System.Drawing.Point(25, 137);
            this.addressFromLabel.Name = "addressFromLabel";
            this.addressFromLabel.Size = new System.Drawing.Size(147, 17);
            this.addressFromLabel.TabIndex = 3;
            this.addressFromLabel.Text = "D1;S07;R01;P01;L02";
            // 
            // addressToLabel
            // 
            this.addressToLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.addressToLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.addressToLabel.Location = new System.Drawing.Point(235, 137);
            this.addressToLabel.Name = "addressToLabel";
            this.addressToLabel.Size = new System.Drawing.Size(147, 17);
            this.addressToLabel.TabIndex = 4;
            this.addressToLabel.Text = "D1;S07;R01;P01;L02";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(195, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 17);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "->";
            // 
            // decriptionLabel
            // 
            this.decriptionLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.decriptionLabel.Location = new System.Drawing.Point(93, 7);
            this.decriptionLabel.Name = "decriptionLabel";
            this.decriptionLabel.Size = new System.Drawing.Size(240, 16);
            this.decriptionLabel.TabIndex = 6;
            this.decriptionLabel.Text = "Bromhexin draje 8mg N25 (Germania)";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl5.Location = new System.Drawing.Point(33, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Серия:";
            // 
            // seriaLabel
            // 
            this.seriaLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.seriaLabel.Location = new System.Drawing.Point(80, 29);
            this.seriaLabel.Name = "seriaLabel";
            this.seriaLabel.Size = new System.Drawing.Size(40, 16);
            this.seriaLabel.TabIndex = 8;
            this.seriaLabel.Text = "12511";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl7.Location = new System.Drawing.Point(27, 51);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 16);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Анализ:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl8.Location = new System.Drawing.Point(215, 29);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 16);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Срок годности:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl9.Location = new System.Drawing.Point(257, 51);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 16);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Партия:";
            // 
            // analisysLabel
            // 
            this.analisysLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.analisysLabel.Location = new System.Drawing.Point(80, 51);
            this.analisysLabel.Name = "analisysLabel";
            this.analisysLabel.Size = new System.Drawing.Size(32, 16);
            this.analisysLabel.TabIndex = 12;
            this.analisysLabel.Text = "4881";
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.expirationDateLabel.Location = new System.Drawing.Point(310, 29);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(76, 16);
            this.expirationDateLabel.TabIndex = 13;
            this.expirationDateLabel.Text = "2016-05-01";
            // 
            // partLabel
            // 
            this.partLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.partLabel.Location = new System.Drawing.Point(310, 51);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(56, 16);
            this.partLabel.TabIndex = 14;
            this.partLabel.Text = "6511939";
            // 
            // migarteButton
            // 
            this.migarteButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.migarteButton.Appearance.ForeColor = System.Drawing.Color.Green;
            this.migarteButton.Appearance.Options.UseFont = true;
            this.migarteButton.Appearance.Options.UseForeColor = true;
            this.migarteButton.Location = new System.Drawing.Point(27, 174);
            this.migarteButton.Name = "migarteButton";
            this.migarteButton.Size = new System.Drawing.Size(125, 32);
            this.migarteButton.TabIndex = 15;
            this.migarteButton.Text = "Переместить";
            this.migarteButton.Click += new System.EventHandler(this.MigarteButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.Appearance.Options.UseFont = true;
            this.cancelButton.Appearance.Options.UseForeColor = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(257, 174);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 32);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Отменить";
            // 
            // allowQtyTextEdit
            // 
            this.allowQtyTextEdit.EditValue = new decimal(new int[] {
            160410020,
            0,
            0,
            131072});
            this.allowQtyTextEdit.Enabled = false;
            this.allowQtyTextEdit.Location = new System.Drawing.Point(12, 82);
            this.allowQtyTextEdit.Name = "allowQtyTextEdit";
            this.allowQtyTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.allowQtyTextEdit.Properties.Appearance.Options.UseFont = true;
            this.allowQtyTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.allowQtyTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.allowQtyTextEdit.Properties.Mask.EditMask = "f";
            this.allowQtyTextEdit.Size = new System.Drawing.Size(166, 39);
            this.allowQtyTextEdit.TabIndex = 0;
            // 
            // FrmMigrateAddress
            // 
            this.AcceptButton = this.migarteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(425, 221);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.migarteButton);
            this.Controls.Add(this.partLabel);
            this.Controls.Add(this.expirationDateLabel);
            this.Controls.Add(this.analisysLabel);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.seriaLabel);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.decriptionLabel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.addressToLabel);
            this.Controls.Add(this.addressFromLabel);
            this.Controls.Add(this.moveQtyButton);
            this.Controls.Add(this.migrateQtySpinEdit);
            this.Controls.Add(this.allowQtyTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMigrateAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMigrateAddress";
            this.Load += new System.EventHandler(this.FrmMigrateAddressLoad);
            ((System.ComponentModel.ISupportInitialize)(this.migrateQtySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowQtyTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit migrateQtySpinEdit;
        private DevExpress.XtraEditors.SimpleButton moveQtyButton;
        private DevExpress.XtraEditors.LabelControl addressFromLabel;
        private DevExpress.XtraEditors.LabelControl addressToLabel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl decriptionLabel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl seriaLabel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl analisysLabel;
        private DevExpress.XtraEditors.LabelControl expirationDateLabel;
        private DevExpress.XtraEditors.LabelControl partLabel;
        private DevExpress.XtraEditors.SimpleButton migarteButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SpinEdit allowQtyTextEdit;
    }
}