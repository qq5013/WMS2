using System.Data;
using System.Data.SqlClient;
using WMS.Globals;

namespace WMS.Assembly
{
    public partial class SborList : DevExpress.XtraReports.UI.XtraReport
    {
        public int GlobalIdDoc { get; set; }
        public SborList()
        {
            InitializeComponent();
            DataBaseLayers.Assambly.PrintLabels = false;

        }

        public DataTable SetParametersReport(int idDoc, int idCollectator, string comment, bool isNew)
        {
            DataBaseLayers.Assambly.IdDoc = idDoc;
            SqlCommand command = new SqlCommand("", GlobalParameters.WmsGlobalSqlConnection);
            command.CommandText =
                string.Format(
                    isNew ? "EXEC FillAssamblyListNew {0}, {1}, '{2}'" : "EXEC FillAssamblyList {0}, {1}, '{2}'", idDoc,
                    idCollectator, comment);

            onixDataSet1.GetListSbor.Clear();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(onixDataSet1.SborList);
            return onixDataSet1.SborList;//StaticClasses.RandomProvider.NextBoolean();
        }
    }
}
