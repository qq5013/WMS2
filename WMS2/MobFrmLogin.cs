using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;
using WMS.Globals;

namespace WMS.MainApplication
{
    public partial class MobFrmLogin : XtraForm
    {
        public MobFrmLogin()
        {
            InitializeComponent();
            ReadConfigFile();
        }

        private void ReadConfigFile()
        {
            GlobalParameters.LabelPrinterAddress = Properties.Settings.Default.LabelPrinterAddress;
            GlobalParameters.LabelPrinterOutputFile = Properties.Settings.Default.LabelPrinterOutputFile;
            GlobalParameters.LabelPrinterParamType = Properties.Settings.Default.LabelPrinterParamType;
            GlobalParameters.LabelPrinterHeadName = Properties.Settings.Default.LabelPrinterHeadName;
            GlobalParameters.LabelPrinterHeadPhone = Properties.Settings.Default.LabelPrinterHeadPhone;
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {

            if (GlobalParameters.WmsGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateWmsGlobalConnection(Properties.Settings.Default.WmsDbConnectionString);
            if (GlobalParameters.OnixGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateOnixGlobalConnection(Properties.Settings.Default.OnixDbConnectionString);
            if (GlobalParameters.SymphonyGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateSymphonyGlobalConnection(
                    Properties.Settings.Default.SymphonyDbConnectionString);

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
                    worker.SaveUserGlobalInformation(idUser);
                }
                else
                {
                    XtraMessageBox.Show(
                        "Пользователь не принадлежит ни одной группе \nОбратитесь к администратору системы!",
                        "Внимание!", MessageBoxButtons.OK);
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                XtraMessageBox.Show("Не правильный логин или пароль или \nпользователь не активирован!", "Внимание!",
                                    MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
                GlobalParameters.Log(typeof (FrmLogin)).Warn(
                    string.Format(
                        "Попытка ввода неправильного логина или пароля, пользоватем : {0}, с компьютера {1}, IP адрес {2}, попытка входа была произведена с логином: {3} и паролем {4}",
                        GlobalParameters.WindowsUserName, GlobalParameters.HostNameClient,
                        GlobalParameters.IpAddressesClient[0], loginTextEdit.Text, passwordTextEdit.Text));
            }
        }

        private void MobFrmLoginLoad(object sender, EventArgs e)
        {
             if (GlobalParameters.WmsGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateWmsGlobalConnection(Properties.Settings.Default.WmsDbConnectionString);
            if (GlobalParameters.OnixGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateOnixGlobalConnection(Properties.Settings.Default.OnixDbConnectionString);
            if (GlobalParameters.SymphonyGlobalSqlConnection.ConnectionString == "")
                GlobalParameters.CreateSymphonyGlobalConnection(
                    Properties.Settings.Default.SymphonyDbConnectionString);
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}