using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WMS.Globals;

namespace WMS.AddressReplenishment
{
    public partial class ReplenishmentList : DevExpress.XtraReports.UI.XtraReport
    {
        public ReplenishmentList(int idDoc)
        {
            InitializeComponent();
            LoadLayout(GlobalParameters.PathForPrintForms + "\\ReplenishmentList.repx");
            docsOrderForReplenishmentTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            docsRowsOrderForReplenishmentTableAdapter1.Connection = GlobalParameters.WmsGlobalSqlConnection;
            docsOrderForReplenishmentTableAdapter.FillById(wmsDataSet1.DocsOrderForReplenishment, idDoc);
            docsRowsOrderForReplenishmentTableAdapter1.Fill(wmsDataSet1.DocsRowsOrderForReplenishment, idDoc);
        }
    }
}
