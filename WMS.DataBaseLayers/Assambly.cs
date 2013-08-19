using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class Assambly
    {
        public static bool PrintLabels { get; set; }
        public static bool PrintDoc { get; set; }
        public static bool AcceptMessage { get; set; }
        public static int IdDoc { get; set; }
        
        public string GetBrandForClient(int idDoc)
        {
            var command = new SqlCommand(string.Format(@"
                            SELECT ISNULL(POS1005, '') AS Brand
                            FROM ras1 
	                            INNER JOIN pos1 ON pos1001 = ras1006
                            WHERE ras1001 = {0} AND ras1002 = 12
                            GROUP BY POS1005
                            ", idDoc),
                                         GlobalParameters.OnixGlobalSqlConnection);
            if (GlobalParameters.OnixGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.OnixGlobalSqlConnection.Open();
            }

            return command.ExecuteScalar().ToString();
        }

        public string GetTelNumberForClient(int idDoc)
        {
            var command = new SqlCommand(string.Format(@"
                            IF (
                            SELECT TOP 1 LEN(POS2006)
                            FROM onix..ras1
	                            INNER JOIN onix..pos1 ON pos1001 = ras1006
	                            INNER JOIN onix..pos2 ON pos2001 = pos1001
                            WHERE ras1001 = {0}
                            GROUP BY POS2006
                            ) <= 23
                            SELECT TOP 1 POS2006
                            FROM onix..ras1
	                            INNER JOIN onix..pos1 ON pos1001 = ras1006
	                            INNER JOIN onix..pos2 ON pos2001 = pos1001
                            WHERE ras1001 = {0}
                            GROUP BY POS2006

                            ELSE
                            SELECT TOP 1 SUBSTRING(POS2006, 0, 23)
                            FROM onix..ras1
	                            INNER JOIN onix..pos1 ON pos1001 = ras1006
	                            INNER JOIN onix..pos2 ON pos2001 = pos1001
                            WHERE ras1001 = {0}
                            GROUP BY POS2006
                            ", idDoc),
                                         GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return command.ExecuteScalar().ToString();
        }

        public DataTable GetDataForLabels(int idDoc)
        {
            try
            {
                /*
                var command =
                    new SqlCommand(string.Format(@"
                            SELECT RTRIM(ltrim(ass1003)) AS SkuDesc,CAST(tra1005/ISNULL(Multiplicity, 1) as NUMERIC(19,4)) AS Qty, TRA1014 AS Price
                            FROM onix..ras1
	                            INNER JOIN onix..tra1 ON tra1001 = ras1001
	                            INNER JOIN onix..ass1 ON ass1001 = TRA1004
                                LEFT JOIN wms..Catalog_Products on ID = ASS1001
                            WHERE ras1001 = {0}", idDoc), GlobalParameters.WmsGlobalSqlConnection);*/
                var command =
                    new SqlCommand(string.Format(@" EXEC FillAssamblyListEtiket {0}, 1,'' ", idDoc), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                DataTable dt = new DataTable("Labels");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Assambly)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }

        public void AcceptToAssamblyDoc (int idDoc, string comment, int idCollectator, int idAutorDoc)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                INSERT INTO BRL1(
							BRL1001, BRL1004, BRL1005, BRL1006, BRL1007, BRL1008, BRL1009, BRL1010, BRL1011, BRL1015, BRL1017)
				SELECT     	ras1001, ras1015, ras1006, ras1012, BRL1007, BRL1008, '{1}',   ras1007, {3}, {2}, 2
				FROM       ras1
					inner join CDS1 on CDS1001 = ras1001 
					inner join BRL1 on brl1001 = ras1001 and CDS1002 = brl1002 
				WHERE     ras1001 = {0}

				update CDS1 set CDS1002 = @@identity where CDS1001 = {0}", idDoc, comment, idCollectator, idAutorDoc), GlobalParameters.OnixGlobalSqlConnection);

                if (GlobalParameters.OnixGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.OnixGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
                GlobalParameters.Log(typeof (Assambly)).InfoFormat(
                    "Документ {0} был отправлен в работу, сборщику {1}, пользователем {2}", idDoc, idCollectator,
                    idAutorDoc);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Assambly)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public bool DebitBalanceOfGoodsAssamblyDoc(int idDoc)
        {
            try
            {
                var command = new SqlCommand(string.Format("EXEC DebitBalanceOfGoods {0}, {1}", idDoc, ObjectsForMainApplication.IdUserLogined),
                                             GlobalParameters.WmsGlobalSqlConnection);
                command.CommandTimeout = GlobalParameters.CommandTimeout;
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                var result = Convert.ToBoolean(command.ExecuteScalar());
                if (!result)
                    GlobalParameters.Log(typeof (Assambly)).InfoFormat(
                        "По документу {0} были успешно списаны остатки с адресов", idDoc);
                else
                    GlobalParameters.Log(typeof (Assambly)).WarnFormat(
                        "По документу {0} были списаны остатки с адресов, но по некоторым строчкам произошла ошибка!",
                        idDoc);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Assambly)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void DeleteUnAsamblyedOrders (int idDoc)
        {
            var command = new SqlCommand(string.Format("DELETE FROM DocsOrderForAssambly WHERE Id_Doc = {0}", idDoc),
                                         GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            command.ExecuteNonQuery();
        }

        public int GetIdAutorDoc(int idDoc)
        {
            try
            {
                var command = new SqlCommand(string.Format("select prk1003 from prk1 where prk1002 = {0}", idDoc), GlobalParameters.OnixGlobalSqlConnection);
                if (GlobalParameters.OnixGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.OnixGlobalSqlConnection.Open();
                }
                var result = command.ExecuteScalar();
                if (result != null) return Convert.ToInt32(result);
                return -1;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Assambly)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }

        public int GetIdDocFromNumber(int docNumber)
        {
            try
            {
                var command =
                new SqlCommand(
                    string.Format(@"
                        IF EXISTS(
                               SELECT TOP 1 RAS1001
                               FROM   RAS1
                               WHERE  RAS1005 = {0}
                                      AND RAS1002 = 12
                           )
                            SELECT TOP 1 RAS1001
                            FROM   RAS1
                            WHERE  RAS1005 = {0}
                                   AND RAS1002 = 12
                        ELSE
                            SELECT CAST(-1 AS BIGINT)
                        ", docNumber),
                    GlobalParameters.OnixGlobalSqlConnection);
                if (GlobalParameters.OnixGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.OnixGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Assambly)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
    }
}
