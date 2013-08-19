namespace WMS.MainApplication
{
    partial class MobFrmMain
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
            this.MainTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.modesXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkAddressButton = new DevExpress.XtraEditors.SimpleButton();
            this.addressMigrationButton = new DevExpress.XtraEditors.SimpleButton();
            this.addressAssignmentButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.modesButton = new DevExpress.XtraEditors.SimpleButton();
            this.docsButton = new DevExpress.XtraEditors.SimpleButton();
            this.directoryesButton = new DevExpress.XtraEditors.SimpleButton();
            this.directoryesTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.dirBackButton = new DevExpress.XtraEditors.SimpleButton();
            this.docsTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.docsBackButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.modesXtraTabPage.SuspendLayout();
            this.mainXtraTabPage.SuspendLayout();
            this.directoryesTabPage.SuspendLayout();
            this.docsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedTabPage = this.mainXtraTabPage;
            this.MainTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.MainTabControl.Size = new System.Drawing.Size(232, 293);
            this.MainTabControl.TabIndex = 4;
            this.MainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.mainXtraTabPage,
            this.modesXtraTabPage,
            this.directoryesTabPage,
            this.docsTabPage});
            // 
            // modesXtraTabPage
            // 
            this.modesXtraTabPage.Controls.Add(this.backButton);
            this.modesXtraTabPage.Controls.Add(this.checkAddressButton);
            this.modesXtraTabPage.Controls.Add(this.addressMigrationButton);
            this.modesXtraTabPage.Controls.Add(this.addressAssignmentButton);
            this.modesXtraTabPage.Name = "modesXtraTabPage";
            this.modesXtraTabPage.Size = new System.Drawing.Size(226, 287);
            this.modesXtraTabPage.Text = "Режимы";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(9, 252);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(208, 28);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "0 - Назад";
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // checkAddressButton
            // 
            this.checkAddressButton.Location = new System.Drawing.Point(9, 82);
            this.checkAddressButton.Name = "checkAddressButton";
            this.checkAddressButton.Size = new System.Drawing.Size(208, 28);
            this.checkAddressButton.TabIndex = 3;
            this.checkAddressButton.Text = "3 - Проверка адреса";
            // 
            // addressMigrationButton
            // 
            this.addressMigrationButton.Location = new System.Drawing.Point(9, 48);
            this.addressMigrationButton.Name = "addressMigrationButton";
            this.addressMigrationButton.Size = new System.Drawing.Size(208, 28);
            this.addressMigrationButton.TabIndex = 2;
            this.addressMigrationButton.Text = "2 - Перемещение партий по адресам";
            // 
            // addressAssignmentButton
            // 
            this.addressAssignmentButton.Location = new System.Drawing.Point(9, 14);
            this.addressAssignmentButton.Name = "addressAssignmentButton";
            this.addressAssignmentButton.Size = new System.Drawing.Size(208, 28);
            this.addressAssignmentButton.TabIndex = 1;
            this.addressAssignmentButton.Text = "1 - Назначение адресов";
            this.addressAssignmentButton.Click += new System.EventHandler(this.AddressAssignmentButtonClick);
            // 
            // mainXtraTabPage
            // 
            this.mainXtraTabPage.Controls.Add(this.modesButton);
            this.mainXtraTabPage.Controls.Add(this.docsButton);
            this.mainXtraTabPage.Controls.Add(this.directoryesButton);
            this.mainXtraTabPage.Name = "mainXtraTabPage";
            this.mainXtraTabPage.Size = new System.Drawing.Size(226, 287);
            this.mainXtraTabPage.Text = "Главная";
            // 
            // modesButton
            // 
            this.modesButton.Location = new System.Drawing.Point(9, 15);
            this.modesButton.Name = "modesButton";
            this.modesButton.Size = new System.Drawing.Size(208, 28);
            this.modesButton.TabIndex = 0;
            this.modesButton.Text = "1 - Режимы";
            this.modesButton.Click += new System.EventHandler(this.ModesButtonClick);
            // 
            // docsButton
            // 
            this.docsButton.Location = new System.Drawing.Point(9, 83);
            this.docsButton.Name = "docsButton";
            this.docsButton.Size = new System.Drawing.Size(208, 28);
            this.docsButton.TabIndex = 2;
            this.docsButton.Text = "3 - Документы";
            this.docsButton.Click += new System.EventHandler(this.DocsButtonClick);
            // 
            // directoryesButton
            // 
            this.directoryesButton.Location = new System.Drawing.Point(9, 49);
            this.directoryesButton.Name = "directoryesButton";
            this.directoryesButton.Size = new System.Drawing.Size(208, 28);
            this.directoryesButton.TabIndex = 1;
            this.directoryesButton.Text = "2 - Справочники";
            this.directoryesButton.Click += new System.EventHandler(this.DirectoryesButtonClick);
            // 
            // directoryesTabPage
            // 
            this.directoryesTabPage.Controls.Add(this.dirBackButton);
            this.directoryesTabPage.Name = "directoryesTabPage";
            this.directoryesTabPage.Size = new System.Drawing.Size(226, 287);
            this.directoryesTabPage.Text = "Справочники";
            // 
            // dirBackButton
            // 
            this.dirBackButton.Location = new System.Drawing.Point(11, 252);
            this.dirBackButton.Name = "dirBackButton";
            this.dirBackButton.Size = new System.Drawing.Size(208, 28);
            this.dirBackButton.TabIndex = 5;
            this.dirBackButton.Text = "0 - Назад";
            this.dirBackButton.Click += new System.EventHandler(this.DirBackButtonClick);
            // 
            // docsTabPage
            // 
            this.docsTabPage.Controls.Add(this.docsBackButton);
            this.docsTabPage.Name = "docsTabPage";
            this.docsTabPage.Size = new System.Drawing.Size(226, 287);
            this.docsTabPage.Text = "Документы";
            // 
            // docsBackButton
            // 
            this.docsBackButton.Location = new System.Drawing.Point(11, 252);
            this.docsBackButton.Name = "docsBackButton";
            this.docsBackButton.Size = new System.Drawing.Size(208, 28);
            this.docsBackButton.TabIndex = 5;
            this.docsBackButton.Text = "0 - Назад";
            this.docsBackButton.Click += new System.EventHandler(this.DocsBackButtonClick);
            // 
            // MobFrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 293);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MobFrmMain";
            this.Text = "MobFrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.modesXtraTabPage.ResumeLayout(false);
            this.mainXtraTabPage.ResumeLayout(false);
            this.directoryesTabPage.ResumeLayout(false);
            this.docsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl MainTabControl;
        private DevExpress.XtraTab.XtraTabPage mainXtraTabPage;
        private DevExpress.XtraEditors.SimpleButton modesButton;
        private DevExpress.XtraEditors.SimpleButton docsButton;
        private DevExpress.XtraEditors.SimpleButton directoryesButton;
        private DevExpress.XtraTab.XtraTabPage modesXtraTabPage;
        private DevExpress.XtraEditors.SimpleButton backButton;
        private DevExpress.XtraEditors.SimpleButton checkAddressButton;
        private DevExpress.XtraEditors.SimpleButton addressMigrationButton;
        private DevExpress.XtraEditors.SimpleButton addressAssignmentButton;
        private DevExpress.XtraTab.XtraTabPage directoryesTabPage;
        private DevExpress.XtraEditors.SimpleButton dirBackButton;
        private DevExpress.XtraTab.XtraTabPage docsTabPage;
        private DevExpress.XtraEditors.SimpleButton docsBackButton;
    }
}