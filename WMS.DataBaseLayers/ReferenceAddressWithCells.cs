using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class ReferenceAddressWithCells
    {
        public DataTable GetListAddressForProduct(int idProduct)
        {
            var command = new SqlCommand(string.Format(@"
                                            SELECT galfp.[ADDRESS],
                                                   galfp.Series,
                                                   galfp.ExpirationDate
                                            FROM   dbo.GetAddressListForProduct({0}) galfp",
                                                       idProduct), GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            var dt = new DataTable("Result");
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }

        public string GetTypeRotaton(int idProduct)
        {
            var command = new SqlCommand(string.Format(@"
                                            SELECT crp.Name
                                            FROM Catalog_RotationsProduct crp 
                                            WHERE crp.ID = dbo.GetTypeOfRotationProduct({0})",
                                                       idProduct), GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return command.ExecuteScalar().ToString();
        }

        public string GetDescriptionProduct(int idProduct)
        {
            var command = new SqlCommand(string.Format(@"
                                            SELECT cp.[Description]
                                            FROM Catalog_Products cp
                                            WHERE cp.ID = {0}",idProduct),
                                         GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return command.ExecuteScalar().ToString();
        }

        public string GetMaxQtyByRotation(int idProduct)
        {
            var command = new SqlCommand(string.Format(@"SELECT dbo.GetMaxRotationProduct({0})", idProduct), GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return command.ExecuteScalar().ToString();
        }

        public string GetTypeCellForAddress(string addressStr)
        {
            var command = new SqlCommand(string.Format(@"SELECT dbo.GetTypeCellForAddress('{0}')", addressStr), GlobalParameters.WmsGlobalSqlConnection);

            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return command.ExecuteScalar().ToString();
        }

        public string GetUpdateDateCellForAddress(string addressStr)
        {
            var command = new SqlCommand(string.Format(@"SELECT dbo.GetUpdateDateCellForAddress('{0}')", addressStr), GlobalParameters.WmsGlobalSqlConnection);

            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return command.ExecuteScalar().ToString();
        }

        public void InsertUpdateReferenceAddressAndCells(string addressStr, int cellNumber)
        {
            var command = new SqlCommand(
                string.Format(@"
                                        DECLARE @idAddress BIGINT; SET @idAddress = dbo.GetAddressFromCatalogByAddressF('{0}')
                                        IF NOT EXISTS(
	                                        SELECT *
	                                        FROM   Reference_CatalogAddress_CatalogCells rcacc
	                                        WHERE  rcacc.ID_AddressFromCatalog = @idAddress
                                        )
                                        INSERT INTO Reference_CatalogAddress_CatalogCells
                                        (
	                                        ID_AddressFromCatalog,
	                                        ID_Cell,
                                            UpdateDate
                                        )
                                        VALUES
                                        (
	                                        @idAddress,
	                                        {1},
                                            GETDATE()
                                        )
                                        ELSE
	                                        UPDATE Reference_CatalogAddress_CatalogCells
	                                        SET		
		                                        ID_Cell = {1},
                                                UpdateDate = GETDATE()
	                                        WHERE ID_AddressFromCatalog = @idAddress",
                              addressStr, cellNumber), GlobalParameters.WmsGlobalSqlConnection);

            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            command.ExecuteNonQuery();
        }
    }
}
