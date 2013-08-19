namespace WMS.MainApplication
{
    partial class MobMdiMain
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
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.userStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MainTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.mainXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.modesButton = new DevExpress.XtraEditors.SimpleButton();
            this.docsButton = new DevExpress.XtraEditors.SimpleButton();
            this.directoryesButton = new DevExpress.XtraEditors.SimpleButton();
            this.modesXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkAddressButton = new DevExpress.XtraEditors.SimpleButton();
            this.addressMigrationButton = new DevExpress.XtraEditors.SimpleButton();
            this.addressAssignmentButton = new DevExpress.XtraEditors.SimpleButton();
            this.directoryesTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.dirBackButton = new DevExpress.XtraEditors.SimpleButton();
            this.docsTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.docsBackButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.mainXtraTabPage.SuspendLayout();
            this.modesXtraTabPage.SuspendLayout();
            this.directoryesTabPage.SuspendLayout();
            this.docsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiManager
            // 
            this.MdiManager.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 7F);
            this.MdiManager.AppearancePage.Header.Options.UseFont = true;
            this.MdiManager.MdiParent = this;
            this.MdiManager.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.MdiManagerPageRemoved);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.userStaticItem});
            this.barManager.MainMenu = this.bar3;
            this.barManager.MaxItemId = 1;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.userStaticItem)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // userStaticItem
            // 
            this.userStaticItem.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.userStaticItem.Appearance.Options.UseFont = true;
            this.userStaticItem.Caption = "Пользователь:";
            this.userStaticItem.Id = 0;
            this.userStaticItem.Name = "userStaticItem";
            this.userStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(240, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 320);
            this.barDockControlBottom.Size = new System.Drawing.Size(240, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 298);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(240, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 298);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 22);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedTabPage = this.mainXtraTabPage;
            this.MainTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.MainTabControl.Size = new System.Drawing.Size(240, 298);
            this.MainTabControl.TabIndex = 10;
            this.MainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.mainXtraTabPage,
            this.modesXtraTabPage,
            this.directoryesTabPage,
            this.docsTabPage});
            // 
            // mainXtraTabPage
            // 
            this.mainXtraTabPage.Controls.Add(this.exitButton);
            this.mainXtraTabPage.Controls.Add(this.modesButton);
            this.mainXtraTabPage.Controls.Add(this.docsButton);
            this.mainXtraTabPage.Controls.Add(this.directoryesButton);
            this.mainXtraTabPage.Name = "mainXtraTabPage";
            this.mainXtraTabPage.Size = new System.Drawing.Size(236, 294);
            this.mainXtraTabPage.Text = "Главная";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(10, 256);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(216, 28);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "0 - Выход";
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // modesButton
            // 
            this.modesButton.Location = new System.Drawing.Point(10, 15);
            this.modesButton.Name = "modesButton";
            this.modesButton.Size = new System.Drawing.Size(216, 28);
            this.modesButton.TabIndex = 0;
            this.modesButton.Text = "1 - Режимы";
            this.modesButton.Click += new System.EventHandler(this.ModesButtonClick);
            // 
            // docsButton
            // 
            this.docsButton.Location = new System.Drawing.Point(10, 83);
            this.docsButton.Name = "docsButton";
            this.docsButton.Size = new System.Drawing.Size(216, 28);
            this.docsButton.TabIndex = 2;
            this.docsButton.Text = "3 - Документы";
            this.docsButton.Click += new System.EventHandler(this.DocsButtonClick);
            // 
            // directoryesButton
            // 
            this.directoryesButton.Location = new System.Drawing.Point(10, 49);
            this.directoryesButton.Name = "directoryesButton";
            this.directoryesButton.Size = new System.Drawing.Size(216, 28);
            this.directoryesButton.TabIndex = 1;
            this.directoryesButton.Text = "2 - Справочники";
            this.directoryesButton.Click += new System.EventHandler(this.DirectoryesButtonClick);
            // 
            // modesXtraTabPage
            // 
            this.modesXtraTabPage.Controls.Add(this.backButton);
            this.modesXtraTabPage.Controls.Add(this.checkAddressButton);
            this.modesXtraTabPage.Controls.Add(this.addressMigrationButton);
            this.modesXtraTabPage.Controls.Add(this.addressAssignmentButton);
            this.modesXtraTabPage.Name = "modesXtraTabPage";
            this.modesXtraTabPage.Size = new System.Drawing.Size(236, 294);
            this.modesXtraTabPage.Text = "Режимы";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(10, 256);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(216, 28);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "0 - Назад";
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // checkAddressButton
            // 
            this.checkAddressButton.Location = new System.Drawing.Point(10, 72);
            this.checkAddressButton.Name = "checkAddressButton";
            this.checkAddressButton.Size = new System.Drawing.Size(216, 28);
            this.checkAddressButton.TabIndex = 3;
            this.checkAddressButton.Text = "3 - Проверка адреса";
            // 
            // addressMigrationButton
            // 
            this.addressMigrationButton.Location = new System.Drawing.Point(10, 38);
            this.addressMigrationButton.Name = "addressMigrationButton";
            this.addressMigrationButton.Size = new System.Drawing.Size(216, 28);
            this.addressMigrationButton.TabIndex = 2;
            this.addressMigrationButton.Text = "2 - Перемещение партий по адресам";
            // 
            // addressAssignmentButton
            // 
            this.addressAssignmentButton.Location = new System.Drawing.Point(10, 4);
            this.addressAssignmentButton.Name = "addressAssignmentButton";
            this.addressAssignmentButton.Size = new System.Drawing.Size(216, 28);
            this.addressAssignmentButton.TabIndex = 1;
            this.addressAssignmentButton.Text = "1 - Назначение адресов";
            this.addressAssignmentButton.Click += new System.EventHandler(this.AddressAssignmentButtonClick);
            // 
            // directoryesTabPage
            // 
            this.directoryesTabPage.Controls.Add(this.dirBackButton);
            this.directoryesTabPage.Name = "directoryesTabPage";
            this.directoryesTabPage.Size = new System.Drawing.Size(236, 294);
            this.directoryesTabPage.Text = "Справочники";
            // 
            // dirBackButton
            // 
            this.dirBackButton.Location = new System.Drawing.Point(10, 256);
            this.dirBackButton.Name = "dirBackButton";
            this.dirBackButton.Size = new System.Drawing.Size(216, 28);
            this.dirBackButton.TabIndex = 5;
            this.dirBackButton.Text = "0 - Назад";
            this.dirBackButton.Click += new System.EventHandler(this.DirBackButtonClick);
            // 
            // docsTabPage
            // 
            this.docsTabPage.Controls.Add(this.docsBackButton);
            this.docsTabPage.Name = "docsTabPage";
            this.docsTabPage.Size = new System.Drawing.Size(236, 294);
            this.docsTabPage.Text = "Документы";
            // 
            // docsBackButton
            // 
            this.docsBackButton.Location = new System.Drawing.Point(10, 256);
            this.docsBackButton.Name = "docsBackButton";
            this.docsBackButton.Size = new System.Drawing.Size(216, 28);
            this.docsBackButton.TabIndex = 5;
            this.docsBackButton.Text = "0 - Назад";
            this.docsBackButton.Click += new System.EventHandler(this.DocsBackButtonClick);
            // 
            // MobMdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MobMdiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MobMdiMainLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.mainXtraTabPage.ResumeLayout(false);
            this.modesXtraTabPage.ResumeLayout(false);
            this.directoryesTabPage.ResumeLayout(false);
            this.docsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem userStaticItem;
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
        private DevExpress.XtraEditors.SimpleButton exitButton;

    }
}