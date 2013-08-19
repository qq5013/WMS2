using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using WMS.Globals;
using System.Xml;
using System.Xml.Serialization;
using log4net.Config;


namespace WMS.MainApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        
        [STAThread]
        static void Main()
        {
            DOMConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;

            GlobalParameters.GetInfoMashine();
            GlobalParameters.CommandTimeout = Properties.Settings.Default.CommandTimeOut;

            

           
            RunWmsMainApplication();
            

            
            GlobalParameters.Log(typeof (Program)).Info(
                string.Format(
                    "Выход из системы пользователем: {0}, с компьютера [{1}], IP адрес клиента {2}, windows пользователь: {3}",
                    ObjectsForMainApplication.LoginUserLogined, GlobalParameters.HostNameClient,
                    GlobalParameters.IpAddressesClient[0], GlobalParameters.WindowsUserName));


        }


        static void RunWmsMainApplication()
        {
            var settings = new XmlDocument();
            settings.Load("Client.xml");
            var listKeys = settings.SelectNodes("//keys");
            if (listKeys != null)
                foreach (var key in from XmlNode listKey in listKeys select listKey.SelectSingleNode("TypeClient"))
                {
                    XtraForm loginForm;
                    if (key != null && key.InnerText == "MobileClient")
                    {
                        loginForm = new MobFrmLogin();
                        if (loginForm.ShowDialog() != DialogResult.OK)
                            Application.Exit();
                        else
                        {
                            Application.Run(new MobMdiMain(ObjectsForMainApplication.IdGroupUserLogined));
                        }
                    }
                    else
                    {
                        loginForm = new FrmLogin();
                        if (loginForm.ShowDialog() != DialogResult.OK)
                            Application.Exit();
                        else
                        {
                            Application.Run(new MdiMain(ObjectsForMainApplication.IdGroupUserLogined));
                            GlobalParameters.ClearSession(ObjectsForMainApplication.SessionId);
                        }
                    }
                }
        }
    }
}