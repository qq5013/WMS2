using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WMS.Globals;

namespace WMS.PrintLabels
{
    public partial class LabelsForm : DevExpress.XtraReports.UI.XtraReport
    {
        public LabelsForm()
        {
            InitializeComponent();
        }

        public void FillDataTable(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                wmsDataSet1.DataForPrint.AddDataForPrintRow(Convert.ToInt32(row[0]), row[1].ToString());
            }
        }

    }
}
