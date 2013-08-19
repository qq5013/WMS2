using System;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using WMS.AddressAsignment;
using WMS.AddressMigration;
using WMS.Administration;
using WMS.DataBaseLayers;
using WMS.Globals;
using WMS.MenuBuilder;
using WMS.Assembly;
using WMS.CreateAddress;
using WMS.AddressReplenishment;
using WMS.CalcRotation;
using WMS.PrintLabels;
using WMS.CheckAddress;
using WMS.ReferenceAddressWithCells;
using WMS.AddressesInventory;

namespace WMS.MainApplication
{
    public partial class MdiMain : DevExpress.XtraEditors.XtraForm
    {
        internal string MainText;
        internal int IdGroupUser;

        internal Timer SessionTimer = new Timer();
        internal BackgroundWorker BgWorker = new BackgroundWorker();
        internal bool SessionBusy;
        internal bool MessagesExists;
        internal DataTable Messages;

        public MdiMain(int idGroupUser)
        {
            InitializeComponent();
            GlobalParameters.ReadGlobalParameters();
            MainText = Text;
            var q = mainMenu.ItemLinks.Count;
            IdGroupUser = idGroupUser;
            serverStaticItem.Caption = serverStaticItem.Caption +
                                       Globals.GlobalParameters.WmsGlobalSqlConnection.DataSource;
            databaseStaticItem.Caption = databaseStaticItem.Caption +
                                         Globals.GlobalParameters.WmsGlobalSqlConnection.Database;
            userStaticItem.Caption = string.Format("{0}{1} | [{2} {3}]", userStaticItem.Caption,
                                                   ObjectsForMainApplication.LoginUserLogined,
                                                   ObjectsForMainApplication.LastNameUserLogined,
                                                   ObjectsForMainApplication.FirstNameUserLogined);


            versionStaticItem.Caption = versionStaticItem.Caption + GetRunningVersion();

            BgWorker.DoWork += BgWorkerDoWork;

            BgWorker.RunWorkerCompleted += BgWorkerRunWorkerCompleted;

            SessionTimer.Interval = Properties.Settings.Default.IntervalCheckSession*1000;

            SessionTimer.Tick += SessionTimerTick;

            MdiManager.MultiLine = DefaultBoolean.True;

            GlobalParameters.Log(typeof (MdiMain)).Info(
                string.Format(
                    "Вход в систему пользователем: {0}, с компьютера [{1}], IP адрес клиента {2}, windows пользователь: {3}",
                    ObjectsForMainApplication.LoginUserLogined, GlobalParameters.HostNameClient,
                    GlobalParameters.IpAddressesClient[0], GlobalParameters.WindowsUserName));
        }

        private void SessionTimerTick(object sender, EventArgs e)
        {
            BgWorker.RunWorkerAsync();
        }

        private void BgWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SessionTimer.Stop();
            ShowMessages();
            if (SessionBusy)
            {
                var result = GlobalParameters.GetInfoUserWhoBlockedMySession(ObjectsForMainApplication.IdUserLogined);

                foreach (DataRow row in result.Rows)
                {
                    XtraMessageBox.Show(
                        string.Format(
                            "Под вашим пользователем [ {3} | {4} {5} ]\n" +
                            "был совершён вход с другого устройства \n" +
                            "Имя устройства: {0}\n" +
                            "IP адрес устройства: {1}\n" +
                            "Пользователь устройства:{2}\n" +
                            "Дальнейшя работа на этом устройстве не возможна!\n" +
                            "Программа будет закрыта!",
                            row["ClientName"], row["ClientIP"], row["DomainNameUser"],
                            ObjectsForMainApplication.LoginUserLogined, ObjectsForMainApplication.LastNameUserLogined,
                            ObjectsForMainApplication.FirstNameUserLogined),
                        "Внимание! Двойной вход в стистему!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Application.Exit();
            }
            else
                SessionTimer.Start();

        }

        private void ShowMessages()
        {
            if (Messages != null)
            {
                foreach (DataRow row in Messages.Rows)
                {
                    MessageBoxIcon icon;
                    switch (row["IconType"].ToString())
                    {
                        case "None":
                            icon = MessageBoxIcon.None;
                            break;
                        case "Error":
                            icon = MessageBoxIcon.Error;
                            break;
                        case "Question":
                            icon = MessageBoxIcon.Question;
                            break;
                        case "Warning":
                            icon = MessageBoxIcon.Warning;
                            break;
                        case "Information":
                            icon = MessageBoxIcon.Information;
                            break;
                        case "Stop":
                            icon = MessageBoxIcon.Stop;
                            break;
                        default:
                            icon = MessageBoxIcon.None;
                            break;

                    }
                    XtraMessageBox.Show(row["Body"].ToString(), row["Caption"].ToString(), MessageBoxButtons.OK, icon);
                }

                DataBaseLayers.Administration.DeleteReadedMessages(ObjectsForMainApplication.SessionId);
                Messages = null;
            }
        }

        private void BgWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            SessionTimer.Stop();
            SessionBusy =
                !GlobalParameters.CheckMySession(ObjectsForMainApplication.SessionId,
                                                 ObjectsForMainApplication.IdUserLogined);
            Messages = DataBaseLayers.Administration.ReadMessage(ObjectsForMainApplication.SessionId);
        }

        private Version GetRunningVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            }
        }

        private void BarButtonDirectoriesItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dirMainFrm = new DirMainFrm {MdiParent = this};
            Text = MainText + " | " + dirMainFrm.Text;
            dirMainFrm.Show();
        }

        private void MdiManagerPageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (MdiManager.Pages.Count == 0)
            {
                Text = MainText;
            }
            else
            {
                Text = MainText + " | " + MdiManager.SelectedPage.Text;
            }

        }

        private void MdiManagerSelectedPageChanged(object sender, EventArgs e)
        {
            if (MdiManager.SelectedPage != null) Text = MainText + " | " + MdiManager.SelectedPage.Text;
        }

        private void BarButtonAddressAsignmentItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmAddressAsignment(false) {MdiParent = this};
            frm.Show();

        }

        private void MdiMainLoad(object sender, EventArgs e)
        {
            FillMainMenu();
            
            foreach (SkinContainer skin in SkinManager.Default.Skins)
            {
                skinsListItem.Strings.Add(skin.SkinName);
            }

            SessionTimer.Start();
        }

        public void FillMainMenu()
        {
            var menu = new AppMainMenu();

            GlobalParameters.MainMenuGlobal = mainMenu;

            
            int ownerIdMenu = 0;
            foreach (BarSubItemLink barSubItemLink in mainMenu.ItemLinks)
            {
                if (barSubItemLink.OwnerItem == null)
                    ownerIdMenu = barSubItemLink.ItemId;

                if (!menu.ShowMenuItem(IdGroupUser, ownerIdMenu, barSubItemLink.ItemId))
                    barSubItemLink.Visible = false;
                else
                {
                    foreach (BarButtonItemLink barButtonItemLink in barSubItemLink.VisibleLinks)
                        if (!menu.ShowMenuItem(IdGroupUser, barButtonItemLink.OwnerItem.Id, barButtonItemLink.ItemId))
                            barButtonItemLink.Visible = false;
                }
            }
        }

        private void BarButtonItemUsersItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmAdministration {MdiParent = this};
            frm.Show();
        }

        private void SkinsListItemListItemClick(object sender, ListItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(skinsListItem.Strings[e.Index]);
            new GeneralQuerys().SetCurentSkin(skinsListItem.Strings[e.Index]);
        }

        private void BarButtonAddressMigrationItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmAddressMigration {MdiParent = this};
            frm.Show();
        }

        private void BarButtonAssemblyItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmAssembly{ MdiParent = this};
            frm.Show();
        }

        private void BarButtonCreateAddressItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmCreateAddress {MdiParent = this};
            frm.Show();
        }

        private void BarButtonItemReplenishmentAddressItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmAddressReplenishment {MdiParent = this};
            frm.Show();
        }

        private void BarButtonItemListProductsOnAddressesItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmListProductsOnAddresses {MdiParent = this};
            frm.Show();
        }

        private void BarButtonItemCalcRotationItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmCalcRotation {MdiParent = this};
            frm.Show();
        }

        private void BarButtonItemPrintLabelsItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmPrintLabels {MdiParent = this};
            frm.Show();
        }


        private void BarButtonCheckAddressItemItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmCheckAddress {MdiParent = this};
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void BarButtonItemApplyReplenishmentListsItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmAcceptanceReplenishmentList() { MdiParent = this };
            frm.Show();
        }

        private void BarButtonItemAddressAssignmentReturItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmAddressAsignment(true) {MdiParent = this};
            frm.Show();
        }

        private void BarButtonItemAddressAssignmentOnNonAcceptedDocsItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmAddressAsignmentOnNonAcceptedDoc() {MdiParent = this};
            frm.Show();
        }

        private void BarButtonReferenceAddressCellsItemItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmReferenceAddressWithCells() {MdiParent = this};
            frm.Show();
        }

        private void BarButtonAddressesInventoryItemItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmAddressesInventory() {MdiParent = this};
            frm.Show();
        }

        
        
    }
}