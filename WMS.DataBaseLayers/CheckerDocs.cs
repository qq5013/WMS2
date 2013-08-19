using System;
using System.Data;
using System.Data.SqlClient;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class CheckerDocs
    {
        public DataTable CheckIfChechedDoc(int idDoc)
        {
            var command = new SqlCommand(string.Format("SELECT " +
                                                       "    dofal.Id_Doc," +
                                                       "    dofal.Number_Doc," +
                                                       "    dofal.Hash_Doc," +
                                                       "    dofal.ResultCheck," +
                                                       "    dofal.Date " +
                                                       "FROM   DocsOrderForAssamblyLog dofal " +
                                                       "WHERE  dofal.Id_Doc = {0}", idDoc),
                                         GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            var result = new DataTable("Result");
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(result);

            return result;
        }

        public void SetCheckedDoc(int idDoc, int numberDoc, string hashDoc, bool result)
        {
            var command = new SqlCommand(
                string.Format(@"
                                                    INSERT INTO DocsOrderForAssamblyLog
                                                    (
	                                                    Id_Doc,
                                                        Number_Doc,
	                                                    Hash_Doc,
	                                                    ResultCheck,
	                                                    Date
                                                    )
                                                    VALUES
                                                    (
	                                                    {0},
                                                        {1},
	                                                    '{2}',
	                                                    {3},
	                                                    GETDATE()
                                                    )", idDoc, numberDoc, hashDoc, Convert.ToByte(result)),
                GlobalParameters.WmsGlobalSqlConnection);

            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            command.ExecuteNonQuery();
        }

        public bool CheckMaxCountTrueDocs()
        {
            var command = new SqlCommand(@"
                                            IF (
	                                            SELECT COUNT(*)
	                                            FROM   DocsOrderForAssamblyLog dofal
	                                            WHERE  DATEPART(DD, dofal.Date) = DATEPART(dd, GETDATE()) AND
		                                               dofal.ResultCheck = 1
	                                            ) <=
	                                            (
	                                            SELECT (dbo.GetCountDocsForDayOfWeek() / 100.0) * CAST(pg.[Value] AS BIGINT)
	                                            FROM   Parameters_Glabal pg
	                                            WHERE  pg.Name = 'PercentForCheckDocs'
	                                            )
	                                            SELECT CAST(0 AS BIT) AS [Result]
                                            ELSE
	                                            SELECT CAST(1 AS BIT) AS [Result]",
                                         GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            return Convert.ToBoolean(command.ExecuteScalar());
        }
    }
}
