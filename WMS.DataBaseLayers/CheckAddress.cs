using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class CheckAddress
    {
        public void CheckQtyAddress(string address, int idPartRow)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                DECLARE @IdAddresInCAtalog BIGINT
                                SELECT @IdAddresInCAtalog = dbo.GetAddressFromCatalogByAddressF('{0}')

                                IF NOT EXISTS (
                                SELECT a.ID, pop.ID
                                FROM [Address] a 
	                                INNER JOIN PartOfProdutcs pop ON a.ID_PartOfProduct = pop.ID
	                                INNER JOIN CheckedQtyAddress cqa ON cqa.ID_Address = a.ID AND cqa.ID_PartOfProduct = pop.ID 
                                WHERE a.ID_AdressFromCatalog = @IdAddresInCAtalog AND pop.ID_PartRow = {1} AND a.IsDeleted = 0
                                GROUP BY a.ID, pop.ID
                                )

                                INSERT INTO CheckedQtyAddress
                                (
	                                ID_Address,
	                                ID_PartOfProduct,
	                                ID_UserCheck, 
	                                DateCheck
                                )
                                SELECT a.ID, pop.ID, {2} ,GETDATE()
                                FROM [Address] a 
	                                INNER JOIN PartOfProdutcs pop ON a.ID_PartOfProduct = pop.ID 
                                WHERE a.ID_AdressFromCatalog = @IdAddresInCAtalog AND pop.ID_PartRow = {1} AND a.IsDeleted = 0
                                GROUP BY a.ID, pop.ID", address, idPartRow, ObjectsForMainApplication.IdUserLogined),
                                         GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof(CheckAddress)).InfoFormat("Пользователем {0} была инвентаризирован адрес {1} с партией товара {2}", ObjectsForMainApplication.IdUserLogined, address, idPartRow);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(CheckAddress)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }

        public void UpdateQtyOnCheckedAddress(string address, int idPartRow, decimal qty, decimal onixQty)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                DECLARE @IdAddresInCAtalog BIGINT
                                SELECT @IdAddresInCAtalog = dbo.GetAddressFromCatalogByAddressF('{0}')

                                IF EXISTS (
                                        SELECT a.ID,
                                                pop.ID
                                        FROM   [Address] a
                                                INNER JOIN PartOfProdutcs pop
                                                    ON  a.ID_PartOfProduct = pop.ID
                                                INNER JOIN CheckedQtyAddress cqa
                                                    ON  cqa.ID_Address = a.ID AND
                                                        cqa.ID_PartOfProduct = pop.ID
                                        WHERE  a.ID_AdressFromCatalog = @IdAddresInCAtalog AND
                                                pop.ID_PartRow = {1} AND a.IsDeleted = 0
                                        GROUP BY
                                                a.ID,
                                                pop.ID
                                    )
                                BEGIN
                                    INSERT INTO HistoryCheckAddress
                                        (
                                        ID_Address,
                                        ID_PartOfProduct,
                                        Old_Qty,
                                        Checked_Qty,
                                        Onix_Qty,
                                        CheckedBy,
                                        DateCheck
                                        )
                                    SELECT a.ID,
                                            a.ID_PartOfProduct,
                                            a.Quantity,
                                            {2},
                                            {4},
                                            {3},
                                            GETDATE()
                                    FROM   [Address] a
                                            INNER JOIN PartOfProdutcs pop
                                                ON  a.ID_PartOfProduct = pop.ID
                                            INNER JOIN CheckedQtyAddress cqa
                                                ON  cqa.ID_Address = a.ID AND
                                                    cqa.ID_PartOfProduct = pop.ID
                                    WHERE  a.ID_AdressFromCatalog = @IdAddresInCAtalog AND
                                            pop.ID_PartRow = {1} AND a.IsDeleted = 0
    
                                    UPDATE a
                                    SET    a.Quantity = {2}
                                    FROM   [Address] a
                                            INNER JOIN PartOfProdutcs pop
                                                ON  a.ID_PartOfProduct = pop.ID
                                            INNER JOIN CheckedQtyAddress cqa
                                                ON  cqa.ID_Address = a.ID AND
                                                    cqa.ID_PartOfProduct = pop.ID
                                    WHERE  a.ID_AdressFromCatalog = @IdAddresInCAtalog AND
                                            pop.ID_PartRow = {1} AND a.IsDeleted = 0
                                END", address, idPartRow, qty, ObjectsForMainApplication.IdUserLogined, onixQty.ToString().Replace(",", ".")), GlobalParameters.WmsGlobalSqlConnection);

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof (CheckAddress)).InfoFormat(
                    "Пользователем {0}, после инвентаризации адреса {1} , " +
                    "с партией товара {2} , " +
                    "было подсчитано реальное кол-во в размере {3} шт." +
                    "вто время как в системе ONIX был остаток в размере {4} шт.",
                    ObjectsForMainApplication.IdUserLogined, address, idPartRow, qty, onixQty);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(CheckAddress)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }

        public string GetStrAddressByIdInCatalog (int idAddressInCatalog)
        {
            try
            {
                var command = new SqlCommand(
                string.Format("SELECT dbo.GetAddressFromCatalogById({0})", idAddressInCatalog),
                GlobalParameters.WmsGlobalSqlConnection);

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                return command.ExecuteScalar().ToString();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(CheckAddress)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }
    }
}
