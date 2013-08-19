using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;
using WMS.DataBaseLayers;

namespace WMS.CheckerDocs
{
    public partial class FrmCheckerDocs : XtraForm
    {
        public string InputString { get; set; }

        public FrmCheckerDocs()
        {
            InitializeComponent();
        }

        private void FrmCheckerDocsKeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyData != Keys.Enter)
            {
                InputString = InputString + e.KeyData;
            }
            else
            {
                PharseInputString();
            }
            */
        }

        public void PharseInputString()
        {
            InputString = textEdit1.Text;
            int startI = -1;
            int endI = -1;
            int startN = -1;
            int endN = -1;
            int idDoc;
            int numberDoc;
            string hashDoc;

            for (int i = 0; i < InputString.Length - 1; i++)
            {
                if (startI == -1 || endI == -1)
                {
                    if (InputString.Substring(i, 1) == "I" || InputString.Substring(i, 1) == "i")
                    {
                        if (startI == -1)
                        {
                            startI = i;
                        }
                        else
                        {
                            endI = i;
                        }

                    }
                }
                if (startN == -1 || endN == -1)
                {
                    if (InputString.Substring(i, 1) == "N" || InputString.Substring(i, 1) == "n")
                    {
                        if (startN == -1)
                        {
                            startN = i;
                        }
                        else
                        {
                            endN = i;
                        }
                    }
                }
            }

            if (startI != -1 || endI != -1 || startN != -1 || endN != -1)
            {

                idDoc = Convert.ToInt32(InputString.Substring(startI + 1, endI - startI - 1));
                numberDoc = Convert.ToInt32(InputString.Substring(startN + 1, endN - startN - 1));
                hashDoc = InputString.Substring(endN + 1, InputString.Length - endN - 1);

                var worker = new DataBaseLayers.CheckerDocs();

                if (GlobalParameters.WmsGlobalSqlConnection.ConnectionString == "")
                    GlobalParameters.CreateWmsGlobalConnection(MainApplication.Properties.Settings.Default.WmsDbConnectionString);
                if (GlobalParameters.OnixGlobalSqlConnection.ConnectionString == "")
                    GlobalParameters.CreateOnixGlobalConnection(MainApplication.Properties.Settings.Default.OnixDbConnectionString);
                if (GlobalParameters.SymphonyGlobalSqlConnection.ConnectionString == "")
                    GlobalParameters.CreateSymphonyGlobalConnection(
                        MainApplication.Properties.Settings.Default.SymphonyDbConnectionString);

                var resDB = worker.CheckIfChechedDoc(idDoc);

                if (resDB.Rows.Count != 0)
                {
                    if (Convert.ToBoolean(resDB.Rows[0]["ResultCheck"]))
                    {
                        groupControl.Text = "Нужна проверка!";
                        groupControl.AppearanceCaption.ForeColor = Color.Red;
                    }
                    else
                    {
                        groupControl.Text = "Проверка не нужна";
                        groupControl.AppearanceCaption.ForeColor = Color.Green;
                    }

                    statusLabel.Text = "Повторное сканирование";
                    statusLabel.ForeColor = Color.Red;

                    docNumberLabel.Text = resDB.Rows[0]["Number_Doc"].ToString();
                    dateLabel.Text = Convert.ToDateTime(resDB.Rows[0]["Date"]).ToString("yyyy-MM-dd HH:MM:ss");
                }
                else
                {
                    bool resultCheck = false;
                    if (!worker.CheckMaxCountTrueDocs())
                    {
                        resultCheck = StaticClasses.RandomProvider.NextBoolean();    
                    }
                    

                    if (resultCheck)
                    {
                        groupControl.Text = "Нужна проверка!";
                        groupControl.AppearanceCaption.ForeColor = Color.Red;
                    }
                    else
                    {
                        groupControl.Text = "Проверка не нужна";
                        groupControl.AppearanceCaption.ForeColor = Color.Green;
                    }

                    worker.SetCheckedDoc(idDoc, numberDoc, hashDoc, resultCheck);
                    docNumberLabel.Text = numberDoc.ToString();
                    statusLabel.Text = "ОК";
                    statusLabel.ForeColor = Color.Green;
                    dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");
                }
            }
            else
            {
                groupControl.Text = "Неверный документ!";
                groupControl.AppearanceCaption.ForeColor = Color.Red;
                statusLabel.Text = "----";
                statusLabel.ForeColor = Color.Black;
                docNumberLabel.Text = "----";
                dateLabel.Text = "----";
            }

        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PharseInputString();
                textEdit1.Text = "";
                textEdit1.Focus();
            }
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {

        }
    }
}
