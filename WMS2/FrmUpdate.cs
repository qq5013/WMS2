using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.MainApplication
{
    public partial class FrmUpdate : DevExpress.XtraEditors.XtraForm
    {
        public List<FileInfo> RunnedFiles { get; set; }
        public List<FileInfo> ListFilesForCopy { get; set; }
        public FrmUpdate(List<FileInfo> runnedFiles, List<FileInfo> listFilesForCopy)
        {
            InitializeComponent();
            RunnedFiles = runnedFiles;
            ListFilesForCopy = listFilesForCopy;
        }

        private void ProgressBarControl1EditValueChanged(object sender, EventArgs e)
        {

        }

        public void UpdateProgramm(List<FileInfo> runnedFiles, List<FileInfo> listFilesForCopy)
        {
            foreach (var fileInfo in listFilesForCopy)
            {
                if (!File.Exists(runnedFiles[0].DirectoryName + "\\" + fileInfo.Name))
                {
                    curentCopyFileLabelControl.Text = string.Format("{0}\\{1}", fileInfo.DirectoryName, fileInfo.Name);
                    File.Copy(string.Format("{0}\\{1}", fileInfo.DirectoryName, fileInfo.Name),
                              string.Format("{0}\\{1}", runnedFiles[0].DirectoryName, fileInfo.Name), true);
                }
                else
                {
                    File.Copy(string.Format("{0}\\{1}", fileInfo.DirectoryName, fileInfo.Name),
                              string.Format("{0}\\" + "_{1}", runnedFiles[0].DirectoryName, fileInfo.Name), true);
                    File.Move(string.Format("{0}\\{1}", runnedFiles[0].DirectoryName, fileInfo.Name),
                              string.Format("{0}\\" + "__{1}", runnedFiles[0].DirectoryName, fileInfo.Name));
                    File.Move(string.Format("{0}\\" + "_{1}", runnedFiles[0].DirectoryName, fileInfo.Name),
                              string.Format("{0}\\{1}", runnedFiles[0].DirectoryName, fileInfo.Name));
                    //File.Delete(runnedFilesInfo[0].DirectoryName + "\\" + "__" + fileInfo.Name);
                }
            }
        }

        private void FrmUpdateLoad(object sender, EventArgs e)
        {
            var worker = new BackgroundWorker();
            worker.DoWork += WorkerDoWork;
            worker.RunWorkerCompleted += WorkerRunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        void WorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }

        void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            UpdateProgramm(RunnedFiles, ListFilesForCopy);
        }
    }
}