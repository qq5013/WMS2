using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Drawing;
using WMS.Globals;
using WMS.DataBaseLayers;

namespace WMS.Assembly
{
    public partial class FrmAssembly : XtraForm
    {
        public delegate int DTDelegate(OnixDataSet.GetListSborDataTable dataTable);
        public static int IdCollectator { get; set; }
        public static string Comment { get; set; }
        public BackgroundWorker FillSborListWorker = new BackgroundWorker();
        public FrmAssembly()
        {
            InitializeComponent();
            getListSborTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            bodyDocTableAdapter.Connection.ConnectionString = GlobalParameters.OnixConnectionString;
            collectatoriTableAdapter.Connection.ConnectionString = GlobalParameters.OnixConnectionString;
            headDocTableAdapter.Connection.ConnectionString = GlobalParameters.OnixConnectionString;
            rutDocTableAdapter.Connection.ConnectionString = GlobalParameters.OnixConnectionString;

            SqlConnection workerConnection = new SqlConnection(GlobalParameters.WmsConnectionString);
            getListSborTableAdapter.Connection = workerConnection;


            FillSborListWorker.DoWork += FillSborListWorkerDoWork;
            FillSborListWorker.RunWorkerCompleted += FillSborListWorkerRunWorkerCompleted;
        }

        void FillSborListWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            marqueeProgressBarControl1.Visible = false;
            topPanel.Enabled = true;
            assemblyGridControl.Enabled = true;
            if (autoRefreshCheckEdit.CheckState != CheckState.Checked) return;
            timer.Stop(); timer.Start();
        }

        void FillSborListWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            getListSborTableAdapter.Fill(onixDataSet.GetListSbor);
        }
        
        
        private void FrmAssemblyLoad(object sender, System.EventArgs e)
        {
            Text = "Распределение заказов на сборку";
        }


        
        private void RefreshButtonClick(object sender, System.EventArgs e)
        {
            marqueeProgressBarControl1.Visible = true;
            topPanel.Enabled = false;
            assemblyGridControl.Enabled = false;
            FillSborListWorker.RunWorkerAsync();
        }

        private void AutoRefreshCheckEditCheckedChanged(object sender, System.EventArgs e)
        {
            if (autoRefreshCheckEdit.CheckState == CheckState.Checked)
            {
                rangeTimeSpinEdit.Visible = true;
                secondsLabelControl.Visible = true;
                refreshButton.Enabled = false;
                timer.Interval = (int) rangeTimeSpinEdit.Value*1000;
                timer.Start();
            }
            else
            {
                rangeTimeSpinEdit.Visible = false;
                secondsLabelControl.Visible = false;
                refreshButton.Enabled = true;
                timer.Stop();
            }
        }

        private void AcceptAssemblySimpleButtonClick(object sender, System.EventArgs e)
        {
            if (autoRefreshCheckEdit.CheckState == CheckState.Checked)
                timer.Stop();

            if (replayPrintCheckEdit.CheckState == CheckState.Checked)
            {
                PrintOrdersReplay(true);
                replayPrintCheckEdit.CheckState = CheckState.Unchecked;
            }
            else
            {
                PrintOrdersFromGrid(true);
            }
            Assambly.AcceptMessage = false;



            //565425, 3
        }

        public void PrintOrdersFromGrid(bool isNew)
        {
            try
            {
                if (assemblyGridView.FocusedRowHandle >= 0)
                {
                    var frm = new FrmCollectator(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle, colcomm).ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        SborList rep = new SborList();



                        var resultDt = rep.SetParametersReport(Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle, colid_doc)), IdCollectator, Comment, isNew);
                        rep.LoadLayout(GlobalParameters.PathForPrintForms + "\\Sbor.repx");
                        //rep.Watermark.Text = Comment;
                        //rep.Watermark.TextDirection = DirectionMode.ForwardDiagonal;
                        //rep.Watermark.Font = new Font(rep.Watermark.Font.FontFamily, 45, FontStyle.Bold);

                        //rep.Watermark.ForeColor = Color.Black;
                        //rep.Watermark.TextTransparency = 150;

                        rep.ShowPreviewDialog();

                        var worker = new Assambly();
                        if (Assambly.PrintDoc)
                        {
                            int numberDoc;
                            if (resultDt.Rows.Count > 0)
                            {
                                var command = new SqlCommand("", GlobalParameters.WmsGlobalSqlConnection);
                                SqlBulkCopy bulkcopy = new SqlBulkCopy(GlobalParameters.WmsGlobalSqlConnection);
                                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                                {
                                    GlobalParameters.WmsGlobalSqlConnection.Open();
                                }

                                bulkcopy.DestinationTableName = resultDt.TableName;
                                try
                                {
                                    bulkcopy.WriteToServer(resultDt);
                                    var row = resultDt.Select();
                                    numberDoc = Convert.ToInt32(row[0][0]);
                                    command.CommandText =
                                        string.Format("CreateAssamblyDoc	@Id_Doc = {0},	@Doc_Number = {1}",
                                                      Convert.ToInt32(
                                                          assemblyGridView.GetRowCellValue(
                                                              assemblyGridView.FocusedRowHandle,
                                                              colid_doc)), Convert.ToInt32(
                                                          assemblyGridView.GetRowCellValue(
                                                              assemblyGridView.FocusedRowHandle,
                                                              colras1005)));
                                    command.ExecuteNonQuery();
                                    GlobalParameters.Log(typeof (FrmAssembly)).InfoFormat(
                                        "Документ № {0} был записан в БД и подготовлен для списания остатков",
                                        Convert.ToInt32(
                                            assemblyGridView.GetRowCellValue(
                                                assemblyGridView.FocusedRowHandle,
                                                colras1005)));
                                }
                                catch (Exception e)
                                {
                                    XtraMessageBox.Show(e.Message);
                                }    
                            }
                            else
                            {
                                XtraMessageBox.Show(
                                    "При попытке создать документ и списать с него остатки произошла ошибка!!!",
                                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                             
                            if (Assambly.PrintLabels)
                            {
                                PrintLabelsDoc(
                                    Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                                     colid_doc)));
                                Assambly.PrintLabels = false;
                            }

                            worker.AcceptToAssamblyDoc(
                                Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                                 colid_doc)), Comment, IdCollectator,
                                worker.GetIdAutorDoc(
                                    Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                                     colid_doc))));

                            if (!ObjectsForMainApplication.AutoDebitRests)
                            {
                                if (XtraMessageBox.Show("Списать остатки с адресов?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (worker.DebitBalanceOfGoodsAssamblyDoc(
                                        Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                                         colid_doc))))
                                        XtraMessageBox.Show(
                                            "Заказ был отправлен на сборку, но при списании партий с адресов произошла ошибка\nНезамедлительно обратитесь к администратору системы!",
                                            "Внимание ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                if (worker.DebitBalanceOfGoodsAssamblyDoc(
                                        Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                                         colid_doc))))
                                    XtraMessageBox.Show(
                                        "Заказ был отправлен на сборку, но при списании партий с адресов произошла ошибка\nНезамедлительно обратитесь к администратору системы!",
                                        "Внимание ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                            RefreshButtonClick(null, null);
                            Assambly.PrintDoc = false;
                        }
                        else
                        {
                            worker.DeleteUnAsamblyedOrders(
                                Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                                 colid_doc)));
                            GlobalParameters.Log(typeof(FrmAssembly)).WarnFormat(
                                "Документ {0} не был напечатан и был удалён из системы, пользователем {1}",
                                Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                                 colid_doc)),
                                ObjectsForMainApplication.LoginUserLogined);
                        }

                        if (autoRefreshCheckEdit.CheckState == CheckState.Checked)
                            timer.Start();

                    }
                }
                else
                {
                    XtraMessageBox.Show("Необходимо выбрать заказ для сборки!", "Внимание!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Не получилось сгенерировать проверочный баркод, попробуйте ещё раз", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var worker = new Assambly();
                worker.DeleteUnAsamblyedOrders(
                                Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                                 colid_doc)));
                GlobalParameters.Log(typeof(FrmAssembly)).ErrorFormat(
                    "Документ {0} не был напечатан из-за ошибки и был удалён из системы, пользователем {1}",
                    Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                     colid_doc)),
                    ObjectsForMainApplication.LoginUserLogined);
                GlobalParameters.Log(typeof(Assambly)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
            }
            
        }

        public void PrintOrdersReplay(bool isNew)
        {
            var worker = new Assambly();
            int idDoc = worker.GetIdDocFromNumber(Convert.ToInt32(replayPrintNumDocTextEdit.Text));
            try
            {
                
                
                if (idDoc > 0)
                {
                    var frm = new FrmCollectator("");
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        SborList rep = new SborList();

                        rep.SetParametersReport(idDoc, IdCollectator, Comment, isNew);
                        rep.LoadLayout(GlobalParameters.PathForPrintForms + "\\Sbor.repx");
                        //rep.Watermark.Text = Comment;
                        //rep.Watermark.TextDirection = DirectionMode.ForwardDiagonal;
                        //rep.Watermark.Font = new Font(rep.Watermark.Font.FontFamily, 45, FontStyle.Bold);

                        //rep.Watermark.ForeColor = Color.Black;
                        //rep.Watermark.TextTransparency = 150;

                        rep.ShowPreviewDialog();

                        //var worker = new Assambly();
                        if (Assambly.PrintDoc)
                        {
                            GlobalParameters.Log(typeof(FrmAssembly)).InfoFormat(
                                "Повторно был распечатан документ {0}, пользователем {1}", idDoc,
                                ObjectsForMainApplication.LoginUserLogined);
                            if (Assambly.PrintLabels)
                            {
                                PrintLabelsDoc(idDoc);
                                Assambly.PrintLabels = false;
                            }


                            RefreshButtonClick(null, null);
                            Assambly.PrintDoc = false;
                        }
                        else
                        {
                            worker.DeleteUnAsamblyedOrders(idDoc);
                            GlobalParameters.Log(typeof(FrmAssembly)).WarnFormat(
                                "Повторный документ {0} не был напечатан и был удалён из системы, пользователем {1}", idDoc,
                                ObjectsForMainApplication.LoginUserLogined);
                        }

                        if (autoRefreshCheckEdit.CheckState == CheckState.Checked)
                            timer.Start();

                    }
                }
                else
                {
                    XtraMessageBox.Show("Не найден такой номер документа!", "Внимание!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                worker.DeleteUnAsamblyedOrders(idDoc);
                GlobalParameters.Log(typeof(FrmAssembly)).WarnFormat(
                    "Повторный документ {0} не был напечатан из-за ошибки и был удалён из системы , пользователем {1}", idDoc,
                    ObjectsForMainApplication.LoginUserLogined);

                GlobalParameters.Log(typeof(Assambly)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
            }
            
        }
        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, System.EventArgs e)
        {
            SborList rep = new SborList();
            rep.LoadLayout(GlobalParameters.PathForPrintForms + "\\Sbor.repx");
            rep.ShowDesigner();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Interval == rangeTimeSpinEdit.Value * 1000)
            {
                if (!FillSborListWorker.IsBusy)
                RefreshButtonClick(null,null);
            }
        }

        private void rangeTimeSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Interval = (int)rangeTimeSpinEdit.Value*1000;
            timer.Start();
        }

        private void SimpleButton1Click1(object sender, EventArgs e)
        {
            if (replayPrintCheckEdit.CheckState == CheckState.Checked)
            {
                var worker = new Assambly();
                int idDoc = worker.GetIdDocFromNumber(Convert.ToInt32(replayPrintNumDocTextEdit.Text));
                if (idDoc > 0)
                    PrintLabelsDoc(idDoc);
                else
                    XtraMessageBox.Show("Не найден такой номер документа!", "Внимание!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                replayPrintCheckEdit.CheckState = CheckState.Unchecked;
            }
            else
            {
                if (assemblyGridView.FocusedRowHandle >= 0)
                {
                    PrintLabelsDoc(Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle, colid_doc)));
                }
            }
        }
        public void PrintLabelsDoc(int idDoc)
        {
            Assambly ass = new Assambly();
            var resulTable =
                ass.GetDataForLabels(idDoc);

            string path = GlobalParameters.LabelPrinterOutputFile;
            string printer = GlobalParameters.LabelPrinterAddress;
            string param = GlobalParameters.LabelPrinterParamType;
            string head = ass.GetBrandForClient(idDoc);
            string tel = ass.GetTelNumberForClient(idDoc);
            string delimeter = "\r\n";

            string stream = "";
            int countRow = 0;


            foreach (DataRow row in resulTable.Rows)
            {
                row[0] = row[0].ToString().Replace("®", "");
                row[0] = row[0].ToString().Replace("©", "");
                row[0] = row[0].ToString().Replace("™", "");
                stream = stream + param + delimeter + "?" + delimeter + head + delimeter + tel + delimeter;
                while (row[0].ToString().Length > 20)
                {
                    if (countRow < 3)
                    {
                        stream = stream + row[0].ToString().Substring(0, 20) + delimeter;
                        row[0] = row[0].ToString().Substring(20, row[0].ToString().Length - 20);
                        row[0] = row[0].ToString().Trim(' ');
                        countRow++;
                    }
                    else
                    {
                        row[0] = "";
                        countRow = 0;
                    }
                }
                if (countRow < 3)
                {
                    if (row[0].ToString().Length > 0)
                    {
                        if (countRow == 0)
                            stream = stream + row[0] + delimeter + delimeter + delimeter;
                        else
                        {
                            if (countRow == 1)
                                stream = stream + row[0] + delimeter + delimeter;
                            else
                                stream = stream + row[0] + delimeter;
                        }
                    }
                }
                stream = stream + Math.Round(Convert.ToDecimal(row[2]), 2) + delimeter + "P" + Convert.ToInt32(Math.Round(Convert.ToDecimal(row[1]))) + delimeter;
                countRow = 0;
            }
            StreamWriter writer = new StreamWriter(path, false);
            writer.Write(stream);
            writer.Close();
            File.Copy(path, printer);
        }

        private void ReplayPrintCheckEditCheckedChanged(object sender, EventArgs e)
        {
            if (replayPrintCheckEdit.CheckState == CheckState.Checked)
            {
                labelControl1.Visible = true;
                replayPrintNumDocTextEdit.Visible = true;
                replayPrintNumDocTextEdit.Focus();
                replayPrintNumDocTextEdit.SelectAll();
            }
            else
            {
                labelControl1.Visible = false;
                replayPrintNumDocTextEdit.Visible = false;
            }
        }

        private void WithoutAssamblyCheckEditCheckedChanged(object sender, EventArgs e)
        {
            if (withoutAssamblyCheckEdit.CheckState == CheckState.Checked)
            {
                withoutAssamblyButton.Visible = true;
                acceptAssemblySimpleButton.Enabled = false;
                replayPrintCheckEdit.Enabled = false;
                replayPrintNumDocTextEdit.Enabled = false;
                printLabelsButton.Enabled = false;
            }
            else
            {
                withoutAssamblyButton.Visible = false;
                acceptAssemblySimpleButton.Enabled = true;
                replayPrintCheckEdit.Enabled = true;
                replayPrintNumDocTextEdit.Enabled = true;
                printLabelsButton.Enabled = true;
            }
        }

        private void WithoutAssamblyButtonClick(object sender, EventArgs e)
        {
            if (assemblyGridView.FocusedRowHandle >= 0)
            {
                var frm = new FrmCollectator(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle, colcomm).ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var worker = new Assambly();
                   

                        worker.AcceptToAssamblyDoc(
                            Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                             colid_doc)), Comment, IdCollectator,
                            worker.GetIdAutorDoc(
                                Convert.ToInt32(assemblyGridView.GetRowCellValue(assemblyGridView.FocusedRowHandle,
                                                                               colid_doc))));
                    if (autoRefreshCheckEdit.CheckState == CheckState.Checked)
                        timer.Start();

                }
            }
            else
            {
                XtraMessageBox.Show("Необходимо выбрать заказ для сборки!", "Внимание!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (autoRefreshCheckEdit.CheckState == CheckState.Checked)
                timer.Stop();

            if (replayPrintCheckEdit.CheckState == CheckState.Checked)
            {
                PrintOrdersReplay(true);
            }
            else
            {
                PrintOrdersFromGrid(true);
            }
            Assambly.AcceptMessage = false;

        }
    }
}