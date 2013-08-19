namespace WMS.MainApplication
{
    partial class MdiMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiMain));
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.mainMenu = new DevExpress.XtraBars.Bar();
            this.barSubModes = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemAddressAssignmentOnNonAcceptedDocs = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddressAsignment = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAddressAssignmentRetur = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddressMigration = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAssembly = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCreateAddress = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemListProductsOnAddresses = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCalcRotation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPrintLabels = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCheckAddressItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonReferenceAddressCellsItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddressesInventoryItem = new DevExpress.XtraBars.BarButtonItem();
            this.barSubSettings = new DevExpress.XtraBars.BarSubItem();
            this.barButtonDirectories = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemAdministration = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemUsers = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemDocs = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemReplenishmentAddress = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemApplyReplenishmentLists = new DevExpress.XtraBars.BarButtonItem();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.serverStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.databaseStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.userStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.versionStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.skinsListItem = new DevExpress.XtraBars.BarListItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MdiManager
            // 
            this.MdiManager.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.MdiManager.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.MdiManager.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.MdiManager.MdiParent = this;
            this.MdiManager.SelectedPageChanged += new System.EventHandler(this.MdiManagerSelectedPageChanged);
            this.MdiManager.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.MdiManagerPageRemoved);
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mainMenu,
            this.statusBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubSettings,
            this.barButtonDirectories,
            this.barSubModes,
            this.barButtonAddressAsignment,
            this.barButtonAddressMigration,
            this.barSubItemAdministration,
            this.barButtonItemUsers,
            this.serverStaticItem,
            this.databaseStaticItem,
            this.userStaticItem,
            this.skinsListItem,
            this.barButtonAssembly,
            this.barButtonCreateAddress,
            this.barSubItemDocs,
            this.barButtonItemReplenishmentAddress,
            this.barButtonItemListProductsOnAddresses,
            this.barButtonItemCalcRotation,
            this.barButtonItemPrintLabels,
            this.versionStaticItem,
            this.barButtonCheckAddressItem,
            this.barButtonItemApplyReplenishmentLists,
            this.barButtonItemAddressAssignmentRetur,
            this.barButtonItemAddressAssignmentOnNonAcceptedDocs,
            this.barButtonReferenceAddressCellsItem,
            this.barButtonAddressesInventoryItem});
            this.barManager.MainMenu = this.mainMenu;
            this.barManager.MaxItemId = 43;
            this.barManager.StatusBar = this.statusBar;
            // 
            // mainMenu
            // 
            this.mainMenu.BarName = "Main menu";
            this.mainMenu.DockCol = 0;
            this.mainMenu.DockRow = 0;
            this.mainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubModes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemAdministration),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemDocs)});
            this.mainMenu.OptionsBar.AllowQuickCustomization = false;
            this.mainMenu.OptionsBar.DisableClose = true;
            this.mainMenu.OptionsBar.DisableCustomization = true;
            this.mainMenu.OptionsBar.DrawDragBorder = false;
            this.mainMenu.OptionsBar.MultiLine = true;
            this.mainMenu.OptionsBar.UseWholeRow = true;
            this.mainMenu.Text = "Main menu";
            // 
            // barSubModes
            // 
            this.barSubModes.Caption = "Режимы";
            this.barSubModes.Id = 2;
            this.barSubModes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAddressAssignmentOnNonAcceptedDocs),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAddressAsignment),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAddressAssignmentRetur),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAddressMigration),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAssembly),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonCreateAddress),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemListProductsOnAddresses),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCalcRotation),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPrintLabels),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonCheckAddressItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonReferenceAddressCellsItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAddressesInventoryItem)});
            this.barSubModes.Name = "barSubModes";
            // 
            // barButtonItemAddressAssignmentOnNonAcceptedDocs
            // 
            this.barButtonItemAddressAssignmentOnNonAcceptedDocs.Caption = "Проверка товаров (назначение адресов без приёмки)";
            this.barButtonItemAddressAssignmentOnNonAcceptedDocs.Id = 40;
            this.barButtonItemAddressAssignmentOnNonAcceptedDocs.Name = "barButtonItemAddressAssignmentOnNonAcceptedDocs";
            this.barButtonItemAddressAssignmentOnNonAcceptedDocs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemAddressAssignmentOnNonAcceptedDocsItemClick);
            // 
            // barButtonAddressAsignment
            // 
            this.barButtonAddressAsignment.Caption = "Назначение адресов";
            this.barButtonAddressAsignment.Id = 21;
            this.barButtonAddressAsignment.Name = "barButtonAddressAsignment";
            this.barButtonAddressAsignment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonAddressAsignmentItemClick);
            // 
            // barButtonItemAddressAssignmentRetur
            // 
            this.barButtonItemAddressAssignmentRetur.Caption = "Назначение адресов (возвраты)";
            this.barButtonItemAddressAssignmentRetur.Id = 39;
            this.barButtonItemAddressAssignmentRetur.Name = "barButtonItemAddressAssignmentRetur";
            this.barButtonItemAddressAssignmentRetur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemAddressAssignmentReturItemClick);
            // 
            // barButtonAddressMigration
            // 
            this.barButtonAddressMigration.Caption = "Перемещение партий по адресам";
            this.barButtonAddressMigration.Id = 22;
            this.barButtonAddressMigration.Name = "barButtonAddressMigration";
            this.barButtonAddressMigration.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonAddressMigrationItemClick);
            // 
            // barButtonAssembly
            // 
            this.barButtonAssembly.Caption = "Сборка";
            this.barButtonAssembly.Id = 25;
            this.barButtonAssembly.Name = "barButtonAssembly";
            this.barButtonAssembly.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonAssemblyItemClick);
            // 
            // barButtonCreateAddress
            // 
            this.barButtonCreateAddress.Caption = "Создание адреса";
            this.barButtonCreateAddress.Id = 26;
            this.barButtonCreateAddress.Name = "barButtonCreateAddress";
            this.barButtonCreateAddress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonCreateAddressItemClick);
            // 
            // barButtonItemListProductsOnAddresses
            // 
            this.barButtonItemListProductsOnAddresses.Caption = "Список товаров на адресах";
            this.barButtonItemListProductsOnAddresses.Id = 30;
            this.barButtonItemListProductsOnAddresses.Name = "barButtonItemListProductsOnAddresses";
            this.barButtonItemListProductsOnAddresses.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemListProductsOnAddressesItemClick);
            // 
            // barButtonItemCalcRotation
            // 
            this.barButtonItemCalcRotation.Caption = "Подсчёт ротации товаров";
            this.barButtonItemCalcRotation.Id = 31;
            this.barButtonItemCalcRotation.Name = "barButtonItemCalcRotation";
            this.barButtonItemCalcRotation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemCalcRotationItemClick);
            // 
            // barButtonItemPrintLabels
            // 
            this.barButtonItemPrintLabels.Caption = "Печать стикеров";
            this.barButtonItemPrintLabels.Id = 34;
            this.barButtonItemPrintLabels.Name = "barButtonItemPrintLabels";
            this.barButtonItemPrintLabels.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemPrintLabelsItemClick);
            // 
            // barButtonCheckAddressItem
            // 
            this.barButtonCheckAddressItem.Caption = "Проверка адреса";
            this.barButtonCheckAddressItem.Id = 37;
            this.barButtonCheckAddressItem.Name = "barButtonCheckAddressItem";
            this.barButtonCheckAddressItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonCheckAddressItemItemClick);
            // 
            // barButtonReferenceAddressCellsItem
            // 
            this.barButtonReferenceAddressCellsItem.Caption = "Стандартизация адресных ячеек";
            this.barButtonReferenceAddressCellsItem.Id = 41;
            this.barButtonReferenceAddressCellsItem.Name = "barButtonReferenceAddressCellsItem";
            this.barButtonReferenceAddressCellsItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonReferenceAddressCellsItemItemClick);
            // 
            // barButtonAddressesInventoryItem
            // 
            this.barButtonAddressesInventoryItem.Caption = "Инвентаризация адресов";
            this.barButtonAddressesInventoryItem.Id = 42;
            this.barButtonAddressesInventoryItem.Name = "barButtonAddressesInventoryItem";
            this.barButtonAddressesInventoryItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonAddressesInventoryItemItemClick);
            // 
            // barSubSettings
            // 
            this.barSubSettings.Caption = "Справочники системы";
            this.barSubSettings.Id = 1;
            this.barSubSettings.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDirectories)});
            this.barSubSettings.Name = "barSubSettings";
            // 
            // barButtonDirectories
            // 
            this.barButtonDirectories.Caption = "Справочники";
            this.barButtonDirectories.Id = 11;
            this.barButtonDirectories.Name = "barButtonDirectories";
            this.barButtonDirectories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonDirectoriesItemClick);
            // 
            // barSubItemAdministration
            // 
            this.barSubItemAdministration.Caption = "Администрирование";
            this.barSubItemAdministration.Id = 3;
            this.barSubItemAdministration.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUsers)});
            this.barSubItemAdministration.Name = "barSubItemAdministration";
            // 
            // barButtonItemUsers
            // 
            this.barButtonItemUsers.Caption = "Пользователи";
            this.barButtonItemUsers.Id = 31;
            this.barButtonItemUsers.Name = "barButtonItemUsers";
            this.barButtonItemUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemUsersItemClick);
            // 
            // barSubItemDocs
            // 
            this.barSubItemDocs.Caption = "Документы";
            this.barSubItemDocs.Id = 28;
            this.barSubItemDocs.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemReplenishmentAddress),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemApplyReplenishmentLists)});
            this.barSubItemDocs.Name = "barSubItemDocs";
            // 
            // barButtonItemReplenishmentAddress
            // 
            this.barButtonItemReplenishmentAddress.Caption = "Пополнение адресов";
            this.barButtonItemReplenishmentAddress.Id = 29;
            this.barButtonItemReplenishmentAddress.Name = "barButtonItemReplenishmentAddress";
            this.barButtonItemReplenishmentAddress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemReplenishmentAddressItemClick);
            // 
            // barButtonItemApplyReplenishmentLists
            // 
            this.barButtonItemApplyReplenishmentLists.Caption = "Приёмка заказов на перемещение";
            this.barButtonItemApplyReplenishmentLists.Id = 38;
            this.barButtonItemApplyReplenishmentLists.Name = "barButtonItemApplyReplenishmentLists";
            this.barButtonItemApplyReplenishmentLists.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemApplyReplenishmentListsItemClick);
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.serverStaticItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.databaseStaticItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.userStaticItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.versionStaticItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinsListItem)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // serverStaticItem
            // 
            this.serverStaticItem.Caption = "Сервер: ";
            this.serverStaticItem.Id = 21;
            this.serverStaticItem.Name = "serverStaticItem";
            this.serverStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // databaseStaticItem
            // 
            this.databaseStaticItem.Caption = "База данных: ";
            this.databaseStaticItem.Id = 22;
            this.databaseStaticItem.Name = "databaseStaticItem";
            this.databaseStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // userStaticItem
            // 
            this.userStaticItem.Caption = "Пользователь: ";
            this.userStaticItem.Id = 23;
            this.userStaticItem.Name = "userStaticItem";
            this.userStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // versionStaticItem
            // 
            this.versionStaticItem.Caption = "Версия: ";
            this.versionStaticItem.Id = 35;
            this.versionStaticItem.Name = "versionStaticItem";
            this.versionStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // skinsListItem
            // 
            this.skinsListItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinsListItem.Caption = "Скин";
            this.skinsListItem.Id = 24;
            this.skinsListItem.Name = "skinsListItem";
            this.skinsListItem.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.SkinsListItemListItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(722, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 439);
            this.barDockControlBottom.Size = new System.Drawing.Size(722, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 417);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(722, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 417);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(280, 176);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 462);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MdiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I.M. \"BECOR\" S.R.L. WMS System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MdiMainLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar mainMenu;
        private DevExpress.XtraBars.BarSubItem barSubSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonDirectories;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarSubItem barSubModes;
        private DevExpress.XtraBars.BarButtonItem barButtonAddressAsignment;
        private DevExpress.XtraBars.BarButtonItem barButtonAddressMigration;
        private DevExpress.XtraBars.BarSubItem barSubItemAdministration;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUsers;
        private DevExpress.XtraBars.BarStaticItem serverStaticItem;
        private DevExpress.XtraBars.BarStaticItem databaseStaticItem;
        private DevExpress.XtraBars.BarStaticItem userStaticItem;
        private DevExpress.XtraBars.BarListItem skinsListItem;
        private DevExpress.XtraBars.BarButtonItem barButtonAssembly;
        private DevExpress.XtraBars.BarButtonItem barButtonCreateAddress;
        private DevExpress.XtraBars.BarSubItem barSubItemDocs;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReplenishmentAddress;
        private DevExpress.XtraBars.BarButtonItem barButtonItemListProductsOnAddresses;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCalcRotation;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrintLabels;
        private DevExpress.XtraBars.BarStaticItem versionStaticItem;
        private DevExpress.XtraBars.BarButtonItem barButtonCheckAddressItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemApplyReplenishmentLists;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddressAssignmentRetur;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddressAssignmentOnNonAcceptedDocs;
        private DevExpress.XtraBars.BarButtonItem barButtonReferenceAddressCellsItem;
        private DevExpress.XtraBars.BarButtonItem barButtonAddressesInventoryItem;
        //private DevExpress.XtraBars.BarSubItem barSubModes2;
    }
}