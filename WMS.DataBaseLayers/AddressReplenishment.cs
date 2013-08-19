using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class AddressReplenishment
    {
        public void MoveReplenishmentDocInTranzit(int idDoc)
        {
            try
            {
                var command = new SqlCommand(string.Format(@" INSERT INTO ReplenishmentTranzit
                            (
	                            ID_Doc,
	                            ID_RowDoc,
	                            ID_PartRow,
	                            ID_AddressCatFrom,
	                            ID_AddressCatTo,
	                            QtyTranzit
                            )
                            SELECT drofr.Id_Doc, drofr.ID, drofr.Id_PartRow, dbo.GetAddressFromCatalogByAddressF(drofr.AddressStringFrom),
                                   dbo.GetAddressFromCatalogByAddressF(ISNULL(dbo.GetAddressFromCatalogById(q.ID), 'Адрес не найден!')), drofr.QtyToMigrate 
                            FROM   DocsRowsOrderForReplenishment drofr
                                   LEFT JOIN (
                                            SELECT pop.ID_PartRow,
                                                   ca.ID
                                            FROM   [Address] a
                                                   INNER JOIN PartOfProdutcs pop
                                                        ON  a.ID_PartOfProduct = pop.ID
                                                   INNER JOIN Catalog_Addresses ca
                                                        ON  ca.ID = a.ID_AdressFromCatalog
                                                   INNER JOIN Catalog_Warehouses cw
                                                        ON  cw.ID = ca.ID_Warehouses
                                            WHERE  cw.ID = 21 AND
                                                   a.IsDeleted = 0
                                            GROUP BY
                                                   pop.ID_PartRow,
                                                   ca.ID,
                                                   pop.ExpirationDate
                                        )q
                                        ON  q.ID_PartRow = drofr.Id_PartRow
                            WHERE  Id_Doc = {0}
                            ORDER BY
                                   AddressStringFrom", idDoc), GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof(AddressReplenishment)).InfoFormat(
                    "Позиции из заказа на пополнение {0}, были отправлены в транзит", idDoc);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressReplenishment)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void ExecuteReplenishmentList(int id)
        {
            try
            {

                var command = new SqlCommand(string.Format("UPDATE DocsOrderForReplenishment SET Executed = 1, DateExecuted = GETDATE() WHERE ID = {0}", id),GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                
                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof (AddressReplenishment)).InfoFormat(
                    "Заказ на пополнение {0}, был распечатан и отдан на сборку пользователем {1}", id,
                    ObjectsForMainApplication.LoginUserLogined);
                
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof (AddressReplenishment)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void AnalyseReplenishment()
        {
            try
            {
                var command =
                    new SqlCommand("",GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                
                command.CommandText = string.Format("EXEC CreateNewOrderForReplenishment {0}, 2",
                                                    ObjectsForMainApplication.IdUserLogined);
                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof (AddressReplenishment)).InfoFormat(
                    "Был запущен анализ остатков для пополнения существующих партий, пользователем - {0}",
                    ObjectsForMainApplication.LoginUserLogined);
                
                command.CommandText = string.Format("EXEC CreateNewOrderForReplenishmentIfNeed {0}, 1",
                                                    ObjectsForMainApplication.IdUserLogined);
                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof(AddressReplenishment)).InfoFormat(
                    "Был запущен анализ остатков для пополнения новых партий, пользователем - {0}",
                    ObjectsForMainApplication.LoginUserLogined);
                

            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressReplenishment)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int ManualReplenishmentGetInfoAddressCountRow(string address, int idZone)
        {
            var command =
                new SqlCommand(
                    string.Format("EXEC AddressReplenishment_GetPartsFromAddressTo '{0}', {1}", address, idZone),
                    GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            DataTable dt = new DataTable("Result");
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dt);

            return dt.Rows.Count;
        }

        public DataTable ManualReplenishmentGetInfoAddressDataTable(string address, int idZone)
        {
            var command =
                new SqlCommand(
                    string.Format("EXEC AddressReplenishment_GetPartsFromAddressTo '{0}', {1}", address, idZone),
                    GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            DataTable dt = new DataTable("Result");
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dt);

            return dt;
        }

        public int ManualReplenishmentGetIdProductByAddress(string address)
        {
            var command =
                new SqlCommand(
                    string.Format("SELECT dbo.GetIdProductByAddressF('{0}')", address),
                    GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public decimal ManualReplenishmentGetRestsByAllDepozits(int idProduct)
        {
            var command =
                new SqlCommand(
                    string.Format(@"
                                    SELECT 
                                           SUM(Qty) AS Qty,
                                           Depozit
                                    FROM   dbo.GetRestsFromAllDepozits(0, {0}) 
                                    WHERE DepozitId IN (1)
                                    GROUP BY Depozit
                                    ORDER BY           
                                           Depozit,
                                           Qty DESC", idProduct),
                    GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            var result = Convert.ToDecimal(command.ExecuteScalar());
            return result;
        }

        public decimal ManualReplenishmentGetRestsByAllDepozitsByThisPart(int idPartRow, int idProduct)
        {
            var command =
                new SqlCommand(
                    string.Format(@"
                                    SELECT 
                                           SUM(Qty) AS Qty,
                                           Depozit
                                    FROM   dbo.GetRestsFromAllDepozits({0}, {1}) 
                                    WHERE DepozitId IN (1) AND FromThisPart = 1
                                    GROUP BY Depozit
                                    ORDER BY           
                                           Depozit,
                                           Qty DESC", idPartRow, idProduct),
                    GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            var result = Convert.ToDecimal(command.ExecuteScalar());
            return result;
        }

        public List<string> ListAddressesOnDepozitForReplenishmentForThisPart(int idPartRow, int idProduct)
        {
            var command = new SqlCommand(string.Format(@"
                                SELECT [Address]
                                FROM   dbo.CheckAddress('{0}')
                                WHERE  IsDeleted = 0 AND ID_PartRow = {1} AND [Address] LIKE 'D2%'", idProduct, idPartRow),
                                         GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            var dt = new DataTable("Addresses");
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                var result = new List<string>();
                var row = dt.Select();
                foreach (DataRow dataRow in row)
                {
                    result.Add(dataRow[0].ToString());    
                }
                
                return result;
            }
            return null;
        }
            

        public bool CheckLinkAddressWithPart(string addressStr)
        {
            var command = new SqlCommand(string.Format("SELECT dbo.CheckLinkAddressWithPart('{0}')", addressStr),
                                         GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return Convert.ToBoolean(command.ExecuteScalar());
        }

        public bool CheckAddressIsBusy(string addressStr)
        {
            var command = new SqlCommand(string.Format("SELECT dbo.CheckAddressIsBusy('{0}')", addressStr),
                                         GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return Convert.ToBoolean(command.ExecuteScalar());
        }

        public int CheckAddresForThisZone(string addressStr, int idZone)
        {
            var command =
                new SqlCommand(string.Format("SELECT dbo.CheckAddresForThisZone('{0}', {1})", addressStr, idZone),
                               GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public DataTable GetInfoPartLastOnAddress(string addressStr)
        {
            var command = new SqlCommand(string.Format(@"
                                    SELECT TOP 1 * 
                                    FROM dbo.CheckAddress('{0}')
                                    WHERE IsDeleted = 1 
                                    ORDER BY DateActivity DESC",
                                                       addressStr),GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            var dt = new DataTable("Result");
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }
        public DataTable GetAddressesOnDepozitForReplenishmentForThisProduct(int idProduct)
        {
            var command = new SqlCommand(string.Format(@"
                                SELECT * 
                                FROM dbo.GetListAddressesOnAllDepozitsForProduct({0})
                            ", idProduct),
                                         GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            DataTable dataTable = new DataTable("Addresses");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
