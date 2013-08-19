using System;
using System.Data;
using System.Data.SqlClient;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class GeneralQuerys
    {
        public string GetLastSkin()
        {
            try
            {
                var command = new SqlCommand("SELECT TOP 1 Value FROM dbo.Parameters_Glabal WHERE NAME = 'LastSkin'",
                                             GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                return command.ExecuteScalar().ToString();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(GeneralQuerys)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }

        public void SetCurentSkin(string skin)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format("UPDATE Parameters_Glabal SET Value = '{0}' WHERE NAME = 'LastSkin'", skin),
                        GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(GeneralQuerys)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }
        
    }
}
