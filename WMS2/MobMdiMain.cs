using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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

namespace WMS.MainApplication
{
    public partial class MobMdiMain : DevExpress.XtraEditors.XtraForm
    {
        internal string MainText;
        internal int IdGroupUser;

        internal Timer SessionTimer = new Timer();
        internal BackgroundWorker BgWorker = new BackgroundWorker();
        internal bool SessionBusy;
        internal bool MessagesExists;
        internal DataTable Messages;

        public MobMdiMain(int idGroupUser)
        {
            InitializeComponent();
            IdGroupUser = idGroupUser;

            GlobalParameters.ReadGlobalParameters();

            userStaticItem.Caption = string.Format("{0}{1} | [{2} {3}]", userStaticItem.Caption,
                                                   ObjectsForMainApplication.LoginUserLogined,
                                                   ObjectsForMainApplication.LastNameUserLogined,
                                                   ObjectsForMainApplication.FirstNameUserLogined);

            BgWorker.DoWork += BgWorkerDoWork;

            BgWorker.RunWorkerCompleted += BgWorkerRunWorkerCompleted;

            SessionTimer.Interval = Properties.Settings.Default.IntervalCheckSession * 1000;

            SessionTimer.Tick += SessionTimerTick;
            
        }

        void SessionTimerTick(object sender, EventArgs e)
        {
            BgWorker.RunWorkerAsync();
        }

        void BgWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

        void ShowMessages()
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

        void BgWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            SessionTimer.Stop();
            SessionBusy =
                !GlobalParameters.CheckMySession(ObjectsForMainApplication.SessionId,
                                                 ObjectsForMainApplication.IdUserLogined);
            Messages = DataBaseLayers.Administration.ReadMessage(ObjectsForMainApplication.SessionId);
        }
        

        
        private void MobMdiMainLoad(object sender, EventArgs e)
        {/*
            var frm = new MobFrmMain {MdiParent = this};
            frm.Show();
          */
        }

        private void MdiManagerPageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (MdiManager.MdiParent.ActiveMdiChild == null)
            {
                MainTabControl.BringToFront();
                MainTabControl.Focus();
            }
        }
        

        private void ModesButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = modesXtraTabPage;
        }

        private void DirectoryesButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = directoryesTabPage;
        }

        private void DocsButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = docsTabPage;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = mainXtraTabPage;
        }

        private void DirBackButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = mainXtraTabPage;
        }

        private void DocsBackButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = mainXtraTabPage;
        }

        private void AddressAssignmentButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SendToBack();
            var frm = new MobFrmAddressAsignment {MdiParent = this};
            frm.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}