using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class AddressAssignment
    {
        public DataTable GetInfoForNonAcceptedDoc (int idDoc)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                            SELECT PRI1001,
                                                   PRI1003,
                                                   PRI1006,
                                                   RTRIM(LTRIM(POS1002)) AS POS1002,
                                                   PRI1014,
                                                   RTRIM(LTRIM(SKL1002)) AS SKL1002
                                            FROM   pri1
                                                   INNER JOIN pos1
                                                        ON  pos1001 = pri1005
                                                   INNER JOIN skl1
                                                        ON  skl1001 = pri1008
                                            WHERE  pri1.PRI1001 = {0}
                                            GROUP BY
                                                   PRI1001,
                                                   PRI1003,
                                                   PRI1006,
                                                   POS1002,
                                                   PRI1014,
                                                   SKL1002
                                            ORDER BY
                                                   pri1006 DESC,
                                                   pri1003 DESC",
                                                           idDoc), GlobalParameters.OnixGlobalSqlConnection);

                if (GlobalParameters.OnixGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.OnixGlobalSqlConnection.Open();
                }
                var adapter = new SqlDataAdapter(command);

                var result = new DataTable("Doc");

                adapter.Fill(result);

                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressAssignment)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }

        public static string ReturnAddressStrForNewPartNonAcceptedDoc(int idPartrow)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                SELECT dbo.GetAddressFromCatalogById(a.ID_AdressFromCatalog)
                                FROM [Address] a
	                                INNER JOIN PartOfProdutcs pop ON pop.ID = a.ID_PartOfProduct 
                                WHERE pop.ID_PartRow = {0} AND a.IsDeleted = 0",
                                                           idPartrow), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                return command.ExecuteScalar().ToString();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressAssignment)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }
    }

    public class AddressAssignmentAuto
    {
        public bool CheckIfExistRotationProduct(int idProduct)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format("EXEC AutoAssignmentCheckRotationProduct @idProduct = {0}", idProduct),
                        GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                return Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressAssignmentAuto)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }

        public bool CheckIfExistDemensionsProduct(int idProduct)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format("EXEC AutoAssignmentCheckDemensionsProduct @idProduct = {0}", idProduct),
                        GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                return Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressAssignmentAuto)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }

        public bool CheckIfExistReferenceProductWithGroup(int idProduct)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format("EXEC AutoAssignmentCheckRefereneceProductWithGroup @idProduct = {0}", idProduct),
                        GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                return Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressAssignmentAuto)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }


        public DataSet GetInfoCellsAndFindCellsForProduct(int idProduct, int qtyProduct)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format("EXEC ExecCrushShelf_Partial " +
                                      "@idProduct = {0}, " +
                                      "@val = 0, " +
                                      "@prc = 90, " +
                                      "@MaxShelf = 1, " +
                                      "@addPrcVal = 15, " +
                                      "@qty = {1} " +
                                      "" +
                                      "EXEC FindCellsForPartProduct " +
                                      "@idProduct = {0}, " +
                                      "@qtyBox = {1}, " +
                                      "@percentFillCells = 90, " +
                                      "@percentBufferEmptyVolumCells = 15 ", idProduct,qtyProduct),
                        GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                var adapter = new SqlDataAdapter(command);
                var ds = new DataSet();
                adapter.Fill(ds);
                ds.Tables[0].TableName = "NeededTypeAndQtyCells";
                ds.Tables[1].TableName = "FindedAddresses";
                return ds;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressAssignmentAuto)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }
        
    }

}
