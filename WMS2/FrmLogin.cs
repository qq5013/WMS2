using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;

using WMS.DataBaseLayers;
using WMS.Globals;


namespace WMS.MainApplication
{
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            ReadConfigFile();
        }

        private void FrmLoginLoad(object sender, EventArgs e)
        {
            foreach (SkinContainer skin in SkinManager.Default.Skins)
            {
                comboBoxEdit1.Properties.Items.Add(skin.SkinName); 
            }
            if (GlobalParameters.WmsGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateWmsGlobalConnection(Properties.Settings.Default.WmsDbConnectionString);
            if (GlobalParameters.OnixGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateOnixGlobalConnection(Properties.Settings.Default.OnixDbConnectionString);
            if (GlobalParameters.SymphonyGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateSymphonyGlobalConnection(
                    Properties.Settings.Default.SymphonyDbConnectionString);
            var i = comboBoxEdit1.Properties.Items.IndexOf(new GeneralQuerys().GetLastSkin());
            comboBoxEdit1.SelectedItem = comboBoxEdit1.Properties.Items[i];
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if (GlobalParameters.WmsGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateWmsGlobalConnection(Properties.Settings.Default.WmsDbConnectionString);
            if (GlobalParameters.OnixGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateOnixGlobalConnection(Properties.Settings.Default.OnixDbConnectionString);
            if (GlobalParameters.SymphonyGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateSymphonyGlobalConnection(
                    Properties.Settings.Default.SymphonyDbConnectionString);
            int ku = 5;
            int kuk = ku + 10;
            var worker = new Authentication();
            int idUser = worker.ExistLogin(loginTextEdit.Text, passwordTextEdit.Text);
            if (idUser > 0)
            {
                int idGroup = worker.ExistGroupForUser(idUser);
                if (idGroup > 0)
                {
                    DialogResult = DialogResult.OK;
                    ObjectsForMainApplication.IdUserLogined = idUser;
                    ObjectsForMainApplication.IdGroupUserLogined = idGroup;
                    ObjectsForMainApplication.SessionId = Guid.NewGuid();
                    ObjectsForMainApplication.VersionClient = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    ObjectsForMainApplication.AutoDebitRests = Properties.Settings.Default.AutoDebitRests;
                    worker.SaveUserGlobalInformation(idUser);
                    if (GlobalParameters.CheckSessionByUser(idUser))
                    {
                        GlobalParameters.SetSession(ObjectsForMainApplication.SessionId, idUser,
                                                    GlobalParameters.HostNameClient,
                                                    GlobalParameters.IpAddressesClient[0].ToString(),GlobalParameters.WindowsUserName, false);
                    }
                    else
                    {
                        GlobalParameters.SetSession(ObjectsForMainApplication.SessionId, idUser,
                                                    GlobalParameters.HostNameClient,
                                                    GlobalParameters.IpAddressesClient[0].ToString(),GlobalParameters.WindowsUserName, true);
                    }
                    
                }
                else
                {
                    XtraMessageBox.Show("Пользователь не принадлежит ни одной группе \nОбратитесь к администратору системы!", "Внимание!", MessageBoxButtons.OK);   
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                XtraMessageBox.Show("Не правильный логин или пароль или \nпользователь не активирован!", "Внимание!", MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
                GlobalParameters.Log(typeof (FrmLogin)).Warn(
                    string.Format(
                        "Попытка ввода неправильного логина или пароля, пользоватем : {0}, с компьютера {1}, IP адрес {2}, попытка входа была произведена с логином: {3} и паролем {4}",
                        GlobalParameters.WindowsUserName, GlobalParameters.HostNameClient,
                        GlobalParameters.IpAddressesClient[0], loginTextEdit.Text, passwordTextEdit.Text));
            }

        }

        private void ComboBoxEdit1SelectedIndexChanged(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(comboBoxEdit1.SelectedItem.ToString());
            new GeneralQuerys().SetCurentSkin(comboBoxEdit1.SelectedItem.ToString());
        }

        private void ReadConfigFile()
        {
            GlobalParameters.LabelPrinterAddress = Properties.Settings.Default.LabelPrinterAddress;
            GlobalParameters.LabelPrinterOutputFile = Properties.Settings.Default.LabelPrinterOutputFile;
            GlobalParameters.LabelPrinterParamType = Properties.Settings.Default.LabelPrinterParamType;
            GlobalParameters.LabelPrinterHeadName = Properties.Settings.Default.LabelPrinterHeadName;
            GlobalParameters.LabelPrinterHeadPhone = Properties.Settings.Default.LabelPrinterHeadPhone;
            GlobalParameters.PathForPrintForms = Properties.Settings.Default.PathForPrintForms;
        }
    }
}