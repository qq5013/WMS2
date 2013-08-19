using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class PrintAddressLabels
    {
        public void UpdateDataForPrintedAddressess(int idAddressInCatalog)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                            IF EXISTS (
                                   SELECT *
                                   FROM   Print_Address_Label_Log pall
                                   WHERE  pall.ID_AddressFromCatalog = {0}
                               )
                                UPDATE Print_Address_Label_Log
                                SET    PrintDate              = GETDATE()
                                WHERE  ID_AddressFromCatalog  = {0}
                            ELSE
                                INSERT INTO Print_Address_Label_Log
                                  (
                                    ID_AddressFromCatalog,
                                    PrintDate
                                  )
                                VALUES
                                  (
                                    {0},
                                    GETDATE()
                                  ) ", idAddressInCatalog),
                                         GlobalParameters.WmsGlobalSqlConnection);

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof (PrintAddressLabels)).InfoFormat(
                    "Пользователем {0}, был распечатан " +
                    "стикер для адреса {1}",
                    ObjectsForMainApplication.IdUserLogined,
                    idAddressInCatalog);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(PrintAddressLabels)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }

        public string GetAddresForProduct(int idProduct)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                    IF (
                           SELECT ISNULL(SUM(q.[ADDRESS]), 0)
                           FROM   (
                                      SELECT COUNT(
                                                 DISTINCT dbo.GetAddressFromCatalogById(a.ID_AdressFromCatalog)
                                             ) AS ADDRESS
                                      FROM   [Address] a
                                             INNER JOIN PartOfProdutcs pop
                                                  ON  pop.ID = a.ID_PartOfProduct
                                      WHERE  a.IsDeleted = 0 AND
                                             pop.ID_Product = {0}
                                      GROUP BY
                                             a.ID_AdressFromCatalog
                                  )q
                       ) <> 1
                    BEGIN
                        IF (
                               SELECT ISNULL(SUM(q.[ADDRESS]), 0)
                               FROM   (
                                          SELECT COUNT(
                                                     DISTINCT dbo.GetAddressFromCatalogById(a.ID_AdressFromCatalog)
                                                 ) AS ADDRESS
                                          FROM   [Address] a
                                                 INNER JOIN PartOfProdutcs pop
                                                      ON  pop.ID = a.ID_PartOfProduct
                                          WHERE  a.IsDeleted = 0 AND
                                                 pop.ID_Product = {0}
                                          GROUP BY
                                                 a.ID_AdressFromCatalog
                                      )q
                           ) = 0
                            SELECT 'no'
                        ELSE
                            SELECT 'null'
                    END
                    ELSE
                        SELECT dbo.GetAddressFromCatalogById(a.ID_AdressFromCatalog) AS ADDRESS
                        FROM   [Address] a
                               INNER JOIN PartOfProdutcs pop
                                    ON  pop.ID = a.ID_PartOfProduct
                        WHERE  a.IsDeleted = 0 AND
                               pop.ID_Product = {0}
                        GROUP BY
                               a.ID_AdressFromCatalog
                        ORDER BY
                               dbo.GetAddressFromCatalogById(a.ID_AdressFromCatalog)

                        ", idProduct),
                                         GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();

                }

                var result = command.ExecuteScalar().ToString();

                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(PrintAddressLabels)).ErrorFormat(
                   "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                   exception.StackTrace);
                throw;
            }
        }
    }
}
