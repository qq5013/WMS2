using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WMS.Globals;


namespace WMS.DataBaseLayers
{
    public enum FoundSkuBy
    {
        Sku,
        BarCode,
        Address
    }
    public class FoundSku
    {
        public int IdSku { get; set; }
        public FoundSkuBy FoundSkuBy { get; set; }
    }
    public class AddressMigration
    {
        public int GetIdProductByAddress(string address)
        {
            var command = new SqlCommand(string.Format("SELECT dbo.GetIdProductByAddressF('{0}')", address),
                                         GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return Convert.ToInt32(command.ExecuteScalar());
        }
        public FoundSku FindSku(string value)
        {
            try
            {
                FoundSku foundSku = new FoundSku();
                var command = new SqlCommand("", GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                bool isNumber = true;

                foreach (char ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        isNumber = false;
                    }
                }
                if (isNumber)
                {
                    if (value.Length <= 5)
                    {
                        command.CommandText =
                            string.Format(@"
                                    IF EXISTS (SELECT ID FROM dbo.Catalog_Products WHERE ID = {0})
                                        SELECT ID FROM dbo.Catalog_Products WHERE ID = {0}
                                    ELSE
                                        SELECT -1", value);
                        foundSku.FoundSkuBy = FoundSkuBy.Sku;
                    }
                    else
                    {
                        command.CommandText =
                            string.Format(@"
                                    IF EXISTS (SELECT ID FROM dbo.Catalog_Products WHERE BarCode = '{0}')
                                        SELECT ID FROM dbo.Catalog_Products WHERE BarCode = '{0}'
                                    ELSE
                                        SELECT -1", value);
                        foundSku.FoundSkuBy = FoundSkuBy.BarCode;
                    }
                }
                else
                {
                    command.CommandText =
                    string.Format(@"
                                    SELECT ID_PartOfProduct, dbo.GetAddressFromCatalogById(ID_AdressFromCatalog) AddressString
                                    INTO #tmpAddress
                                    FROM dbo.Address
                                    WHERE IsDeleted = 0 

                                    IF EXISTS (
			                                    SELECT ID_Product
			                                    FROM #tmpAddress ta
				                                    INNER JOIN dbo.PartOfProdutcs pp ON pp.ID = ta.ID_PartOfProduct
			                                    WHERE AddressString = '{0}')
	                                    SELECT ID_Product
	                                    FROM #tmpAddress ta
		                                    INNER JOIN dbo.PartOfProdutcs pp ON pp.ID = ta.ID_PartOfProduct
	                                    WHERE AddressString = '{0}'
                                    ELSE
	                                    SELECT - 1
                                    DROP TABLE #tmpAddress", value);
                    foundSku.FoundSkuBy = FoundSkuBy.Address;
                }

                foundSku.IdSku = Convert.ToInt32(command.ExecuteScalar());
                return foundSku;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressMigration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int FindIdAddressFromCatalog (string address)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"SELECT dbo.GetAddressFromCatalogByAddressF('{0}')", address), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());

                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressMigration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public string GetDescriptionForSku (int id)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"
                                SELECT RTRIM(LTRIM(Description)) 
                                FROM Catalog_Products 
                                WHERE ID = {0}", id), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = command.ExecuteScalar();

                if (result != null)
                    return result.ToString();
                return "";
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressMigration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public bool MigrateQtyToAnotherAddress(int idPartOfProduct, int idAddressFrom,int idAddressTo, decimal migrateQnt, decimal allowQnt, bool fromThisPart)
        {
            try
            {
               var command = new SqlCommand(
               string.Format(@"
                            IF EXISTS (SELECT *
			                            FROM dbo.Address a
				                            INNER JOIN dbo.Catalog_Addresses ca ON ca.ID = a.ID_AdressFromCatalog
			                            WHERE ID_PartOfProduct = {0} AND ID_AdressFromCatalog = {1} AND a.Quantity = {2})
                            BEGIN
	                            UPDATE a SET Quantity = Quantity - {3}
	                            FROM dbo.Address a	
	                            WHERE a.ID_PartOfProduct = {0} AND a.ID_AdressFromCatalog = {1} AND a.Quantity = {2}
                                IF ((
                                SELECT SUM(Quantity)
                                FROM dbo.Address a	
	                            WHERE a.ID_PartOfProduct = {0} AND a.ID_AdressFromCatalog = {1}) = 0)
                                    UPDATE dbo.Address SET IsDeleted = 1, DateActivity = GETDATE() WHERE ID_PartOfProduct = {0} AND ID_AdressFromCatalog = {1}                                                                    
	                            SELECT 1
                            END
                            ELSE
	                            SELECT 0
                            ", idPartOfProduct, idAddressFrom, allowQnt.ToString().Replace(",", "."), migrateQnt.ToString().Replace(",", ".")), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = command.ExecuteScalar();

                if (result != null)
                {
                    if (Convert.ToBoolean(result))
                    {
                        if (fromThisPart)
                        {
                            command.CommandText = string.Format(@"
                                        IF EXISTS (
                                               SELECT *
                                               FROM   dbo.Address a
                                                      INNER JOIN dbo.Catalog_Addresses ca
                                                           ON  ca.ID = a.ID_AdressFromCatalog
                                               WHERE  ID_PartOfProduct = {0} AND
                                                      ID_AdressFromCatalog = {1}
                                           )
                                        BEGIN
                                            DECLARE @IdAddressTo    BIGINT,
                                                    @IdAddressFrom  BIGINT
    
                                            IF EXISTS(
                                                   SELECT TOP 1 a.ID
                                                   FROM   [Address] a
                                                   WHERE  a.ID_AdressFromCatalog = {1} AND
                                                          a.ID_PartOfProduct = {0} AND
                                                          a.IsDeleted = 0
                                                   GROUP BY
                                                          a.ID,
                                                          a.DatePlace
                                                   ORDER BY
                                                          a.DatePlace DESC
                                               )
                                            BEGIN
                                                SELECT @IdAddressTo = (
                                                           SELECT TOP 1 a.ID
                                                           FROM   [Address] a
                                                           WHERE  a.ID_AdressFromCatalog = {1} AND
                                                                  a.ID_PartOfProduct = {0} AND
                                                                  a.IsDeleted = 0
                                                           GROUP BY
                                                                  a.ID,
                                                                  a.DatePlace
                                                           ORDER BY
                                                                  a.DatePlace DESC
                                                       )
                                            END
                                            ELSE
                                            BEGIN
                                                SELECT @IdAddressTo = (
                                                           SELECT TOP 1 a.ID
                                                           FROM   [Address] a
                                                           WHERE  a.ID_AdressFromCatalog = {1} AND
                                                                  a.ID_PartOfProduct = {0} AND
                                                                  a.IsDeleted = 1
                                                           GROUP BY
                                                                  a.ID,
                                                                  a.DatePlace
                                                           ORDER BY
                                                                  a.DatePlace DESC
                                                       )
                                            END
    
    
    
                                            UPDATE a
                                            SET    Quantity = Quantity + {2},
                                                   IsDeleted = 0
                                            FROM   dbo.Address a
                                            WHERE  a.ID_PartOfProduct = {0} AND
                                                   a.ID_AdressFromCatalog = {1} AND
                                                   a.ID = @IdAddressTo
    
    
                                            SELECT @IdAddressFrom = (
                                                       SELECT DISTINCT TOP 1 a.ID
                                                       FROM   [Address] a
                                                       WHERE  a.ID_AdressFromCatalog = {3} AND
                                                              a.ID_PartOfProduct = {0}
                                                       GROUP BY
                                                              a.ID
                                                   )
    
    
                                            IF NOT EXISTS (
                                                   SELECT *
                                                   FROM   CheckedQtyAddress cqa
                                                   WHERE  cqa.ID_Address = @IdAddressTo AND
                                                          cqa.ID_PartOfProduct = {0}
                                               )
                                                INSERT INTO CheckedQtyAddress
                                                  (
                                                    ID_Address,
                                                    ID_PartOfProduct,
                                                    ID_UserCheck,
                                                    DateCheck
                                                  )
                                                VALUES
                                                  (
                                                    @IdAddressTo,
                                                    {0},
                                                    {4},
                                                    GETDATE()
                                                  ) 
    
    
                                            INSERT INTO HistoryAddressModify
                                              (
                                                ID_Address,
                                                ID_AddressInCatalog,
                                                DateModify,
                                                ModifyBy,
                                                TypeModify
                                              )
                                            VALUES
                                              (
                                                @IdAddressFrom,
                                                {3},
                                                GETDATE(),
                                                {4},
                                                3
                                              )
    
                                            INSERT INTO HistoryAddressModify
                                              (
                                                ID_Address,
                                                ID_AddressInCatalog,
                                                DateModify,
                                                ModifyBy,
                                                TypeModify
                                              )
                                            VALUES
                                              (
                                                @IdAddressTo,
                                                {1},
                                                GETDATE() + 0.0000116,
                                                {4},
                                                3
                                              )
    
                                            SELECT 1
                                        END
                                        ELSE
                                            SELECT 0", idPartOfProduct, idAddressTo,
                                                            migrateQnt.ToString().Replace(",", "."), idAddressFrom,ObjectsForMainApplication.IdUserLogined);
                            result = command.ExecuteScalar();

                            GlobalParameters.Log(typeof (AddressMigration)).InfoFormat(
                                "Пользователем {0} было перемещено с адреса {1}, {2} штук товара на существующий адресс {3} той же партии",
                                ObjectsForMainApplication.LoginUserLogined, idAddressFrom, migrateQnt.ToString().Replace(",", "."), idAddressTo);
                        }
                        else
                        {
                            command.CommandText = string.Format(@"
                                        DECLARE @IdAddressTo BIGINT
                                        DECLARE @IdAddressFrom BIGINT

                                        IF NOT EXISTS (
                                               SELECT *
                                               FROM   dbo.Address a
                                                      INNER JOIN dbo.Catalog_Addresses ca
                                                           ON  ca.ID = a.ID_AdressFromCatalog
                                               WHERE  ID_PartOfProduct = {1} AND
                                                      ID_AdressFromCatalog = {0}
                                           )
                                        BEGIN
                                            INSERT INTO dbo.Address
                                              (
                                                ID_AdressFromCatalog,
                                                ID_PartOfProduct,
                                                Quantity,
                                                DatePlace,
                                                DateActivity
                                              )
                                            VALUES
                                              (
                                                {0},
                                                {1},
                                                {2},
                                                GETDATE(),
                                                GETDATE()
                                              )
                                            SELECT @IdAddressTo = @@IDENTITY
                                        END
                                        ELSE
                                        BEGIN
                                            IF EXISTS(
                                                   SELECT TOP 1 a.ID
                                                   FROM   [Address] a
                                                   WHERE  a.ID_AdressFromCatalog = {0} AND
                                                          a.ID_PartOfProduct = {1} AND
                                                          a.IsDeleted = 0
                                                   GROUP BY
                                                          a.ID,
                                                          a.DatePlace
                                                   ORDER BY
                                                          a.DatePlace DESC
                                               )
                                            BEGIN
                                                SELECT @IdAddressTo = (
                                                           SELECT TOP 1 a.ID
                                                           FROM   [Address] a
                                                           WHERE  a.ID_AdressFromCatalog = {0} AND
                                                                  a.ID_PartOfProduct = {1} AND
                                                                  a.IsDeleted = 0
                                                           GROUP BY
                                                                  a.ID,
                                                                  a.DatePlace
                                                           ORDER BY
                                                                  a.DatePlace DESC
                                                       )
                                            END
                                            ELSE
                                            BEGIN
                                                SELECT @IdAddressTo = (
                                                           SELECT TOP 1 a.ID
                                                           FROM   [Address] a
                                                           WHERE  a.ID_AdressFromCatalog = {0} AND
                                                                  a.ID_PartOfProduct = {1} AND
                                                                  a.IsDeleted = 1
                                                           GROUP BY
                                                                  a.ID,
                                                                  a.DatePlace
                                                           ORDER BY
                                                                  a.DatePlace DESC
                                                       )
                                            END
    
    
                                            UPDATE a
                                            SET    Quantity   = Quantity + {2},
                                                   IsDeleted  = 0
                                            FROM   dbo.Address a
                                            WHERE  a.ID_PartOfProduct = {1} AND
                                                   a.ID_AdressFromCatalog = {0} AND
                                                   a.ID = @IdAddressTo
                                        END
                            


                                        SELECT @IdAddressFrom = (
                                                   SELECT DISTINCT TOP 1 a.ID
                                                   FROM   [Address] a
                                                   WHERE  a.ID_AdressFromCatalog = {3} AND
                                                          a.ID_PartOfProduct = {1}
                                                   GROUP BY
                                                          a.ID
                                               )
                            
                                        INSERT INTO CheckedQtyAddress
                                          (
                                            ID_Address,
                                            ID_PartOfProduct,
                                            ID_UserCheck,
                                            DateCheck
                                          )
                                        VALUES
                                          (
                                            @IdAddressTo,
                                            {1},
                                            {4},
                                            GETDATE()
                                          ) 
                                
                                        INSERT INTO HistoryAddressModify
                                          (
                                            ID_Address,
                                            ID_AddressInCatalog,
                                            DateModify,
                                            ModifyBy,
                                            TypeModify
                                          )
                                        VALUES
                                          (
                                            @IdAddressFrom,
                                            {3},
                                            GETDATE(),
                                            {4},
                                            3
                                          )

                                        INSERT INTO HistoryAddressModify
                                          (
                                            ID_Address,
                                            ID_AddressInCatalog,
                                            DateModify,
                                            ModifyBy,
                                            TypeModify
                                          )
                                        VALUES
                                          (
                                            @IdAddressTo,
                                            {0},
                                            GETDATE() + 0.0000116,
                                            {4},
                                            3
                                          )
                            ", idAddressTo,
                            idPartOfProduct, migrateQnt.ToString().Replace(",", "."),
                            idAddressFrom, ObjectsForMainApplication.IdUserLogined);
                            result = command.ExecuteScalar();

                            GlobalParameters.Log(typeof(AddressMigration)).InfoFormat(
                                "Пользователем {0} было перемещено с адреса {1}, {2} штук товара на существующий адресс {3} не принадлежавший ни одной партии",
                                ObjectsForMainApplication.LoginUserLogined, idAddressFrom, migrateQnt.ToString().Replace(",", "."), idAddressTo);
                        }

                    }
                    return result != null && Convert.ToBoolean(result);
                }
                return false;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressMigration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void CleanAddress(int idAddress, int idPartRow, DateTime expirationDate)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format(@"
                                    UPDATE [Address]
                                    SET    IsDeleted             = 1,
                                           Quantity = 0,
                                           DateActivity          = GETDATE()
                                    WHERE  ID_AdressFromCatalog  = {0}
                                           AND ID_PartOfProduct IN (SELECT pop.ID
                                                                    FROM   PartOfProdutcs pop
                                                                    WHERE  pop.ID_PartRow = {1}
                                                                           AND pop.ExpirationDate = '{2}')
                                    DECLARE @IdAddress BIGINT
                                    SELECT @IdAddress = (SELECT DISTINCT TOP 1 a.ID
                                        FROM   [Address] a
                                        WHERE  a.ID_AdressFromCatalog = {0} AND
                                               a.ID_PartOfProduct IN ((SELECT pop.ID
                                                                    FROM   PartOfProdutcs pop
                                                                    WHERE  pop.ID_PartRow = {1}
                                                                           AND pop.ExpirationDate = '{2}'))
                                        GROUP BY
                                               a.ID)
                                    INSERT INTO HistoryAddressModify
                                      (
                                        ID_Address,
                                        ID_AddressInCatalog,
                                        DateModify,
                                        ModifyBy,
                                        TypeModify
                                      )
                                    VALUES
                                      (
                                        @IdAddress,	
                                        {0},
                                        GETDATE(),	
                                        {3},
                                        2
                                      )", idAddress, idPartRow,
                                      expirationDate.ToString("yyyyMMdd"), ObjectsForMainApplication.IdUserLogined),
                        GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof (AddressMigration)).WarnFormat("Пользователь {0}, освободил адрес {1}",
                                                                           ObjectsForMainApplication.LoginUserLogined,
                                                                           idAddress);

            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressMigration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void RemovePartFromTranzit(int idDoc, int idDocRow)
        {
            try
            {
                var commnad = new SqlCommand(string.Format(@"
                                EXEC RemovePartsFromTranzit
	                                @IdDoc = {0},
	                                @IdRowDoc = {1}", idDoc,
                                                       idDocRow), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                commnad.ExecuteNonQuery();
                GlobalParameters.Log(typeof(AddressMigration)).WarnFormat("По документу перемещения {0}, был удалён транзит по строчке {1}",
                                                                           idDoc,
                                                                           idDocRow);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressMigration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
    }
}
