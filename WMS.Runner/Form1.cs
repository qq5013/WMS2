using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WMS.Runner
{
    public class FilesInfo : IEnumerable
    {
        public string File { get; set; }
        public FileInfo FileInfo { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            var files = new List<FilesInfo>();

            

            /*
            if (MessageBox.Show("Zapusk prilojuhi?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var mainProcess = new Process { StartInfo = { FileName = @"D:\\Projects\\WMS\\WMS2\\bin\\Debug\\WMS.exe" } };

                mainProcess.Start();
                mainProcess.WaitForExit();
            }
             * 
             */
        }
    }
}
