using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class AddressesInventory
    {
        public DataTable GetListZones(string idsWarehouse)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                                SELECT CAST(0 AS BIGINT) AS ID, 'Все' AS [Name]
                                                UNION ALL
                                                SELECT cz.ID, cz.Name
                                                FROM Catalog_Zones cz
	                                                INNER JOIN Catalog_Streets cs ON cs.ID_Zona = cz.ID
	                                                INNER JOIN Catalog_Addresses ca ON ca.ID_Streets = cs.ID
	                                                INNER JOIN Catalog_Warehouses cw ON cw.ID = ca.ID_Warehouses
                                                WHERE cw.ID IN ({0})
                                                GROUP BY cz.ID, cz.Name",
                                                           idsWarehouse), GlobalParameters.WmsGlobalSqlConnection);
                var result = new DataTable("Catalog_Zones");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressesInventory)).Error(
                       string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }    

        public DataTable GetListStreets(string idsWarehouse, string idsZone)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                                SELECT CAST(0 AS BIGINT) AS ID, 'Все' AS [Description]
                                                UNION ALL
                                                SELECT cs.ID, cs.[Description]
                                                FROM Catalog_Streets cs
	                                                INNER JOIN Catalog_Zones cz ON cz.ID = cs.ID_Zona
                                                    INNER JOIN Catalog_Addresses ca ON ca.ID_Streets = cs.ID
                                                    INNER JOIN Catalog_Warehouses cw ON cw.ID = ca.ID_Warehouses
                                                WHERE cz.ID IN ({0}) AND cw.ID IN ({1})
                                                GROUP BY cs.ID, cs.[Description]",
                                                           idsZone, idsWarehouse), GlobalParameters.WmsGlobalSqlConnection);
                var result = new DataTable("Catalog_Streets");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressesInventory)).Error(
                       string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public DataTable GetListRafts(string idWarehouse, string idZones, string idStreets)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                                SELECT CAST(0 AS BIGINT) AS ID, 'Все' AS [Description]
                                                UNION ALL
                                                SELECT cr.ID,
                                                       cr.[Description]
                                                FROM   Catalog_Raft cr
                                                       INNER JOIN Catalog_Addresses ca
                                                            ON  ca.ID_Rafts = cr.ID
                                                       INNER JOIN Catalog_Streets cs
                                                            ON  cs.ID = ca.ID_Streets
                                                       INNER JOIN Catalog_Warehouses cw 
                                                            ON cw.ID = ca.ID_Warehouses
                                                WHERE  cs.ID IN (SELECT cs.ID
                                                                 FROM   Catalog_Streets cs
                                                                        INNER JOIN Catalog_Zones cz
                                                                             ON  cz.ID = cs.ID_Zona
                                                                 WHERE  cz.ID IN ({0}) AND cs.ID IN ({1})) AND cw.ID IN ({2})
                                                GROUP BY
                                                       cr.ID,
                                                       cr.[Description]
                                                ORDER BY
                                                       cr.ID",
                                                           idZones, idStreets, idWarehouse), GlobalParameters.WmsGlobalSqlConnection);
                var result = new DataTable("Catalog_Rafts");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressesInventory)).Error(
                       string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public DataTable GetListShelfs(string idWarehouse, string idZones,string idStreets,string idRafts)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                                SELECT CAST(0 AS BIGINT) AS ID, 'Все' AS [Description]
                                                UNION ALL
                                                SELECT ccs.ID, ccs.[Description]
                                                FROM Catalog_Shelfs ccs	
                                                       INNER JOIN Catalog_Addresses ca ON  ca.ID_Shelfs = ccs.ID
                                                       INNER JOIN Catalog_Raft cr ON cr.ID = ca.ID_Rafts     
                                                       INNER JOIN Catalog_Streets cs ON  cs.ID = ca.ID_Streets
                                                       INNER JOIN Catalog_Warehouses cw ON cw.ID = ca.ID_Warehouses
                                                WHERE  cs.ID IN (SELECT cs.ID
                                                                 FROM   Catalog_Streets cs
                                                                        INNER JOIN Catalog_Zones cz
                                                                             ON  cz.ID = cs.ID_Zona
                                                                 WHERE  cz.ID IN ({0}) AND cs.ID IN ({1}))
                                                                 AND cr.ID IN ({2}) AND cw.ID IN ({3})
                                                GROUP BY
                                                       ccs.ID, ccs.[Description]
                                                ORDER BY
                                                       ccs.ID",
                                                           idZones, idStreets, idRafts, idWarehouse),
                                             GlobalParameters.WmsGlobalSqlConnection);
                var result = new DataTable("Catalog_Shelfs");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressesInventory)).Error(
                       string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public DataTable GetListAddresses(string idWarehouse, string idZones, string idStreets, string idRafts, string idShelfs)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                                SELECT ca.ID, dbo.GetAddressFromCatalogById(ca.ID) AS AddressStr
                                                FROM Catalog_Addresses ca
	                                                INNER JOIN Catalog_Streets cs ON cs.ID = ca.ID_Streets
	                                                INNER JOIN Catalog_Zones cz ON cz.ID = cs.ID_Zona
                                                WHERE 
                                                ca.ID_Warehouses IN ({0}) AND
                                                cz.ID IN ({1}) AND
                                                ca.ID_Streets IN ({2}) AND
                                                ca.ID_Rafts IN ({3}) AND
                                                ca.ID_Shelfs IN ({4})
                                                ORDER BY dbo.GetAddressFromCatalogById(ca.ID)",
                                                           idWarehouse, idZones, idStreets, idRafts, idShelfs),
                                             GlobalParameters.WmsGlobalSqlConnection);
                var result = new DataTable("Catalog_Shelfs");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressesInventory)).Error(
                       string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public DataTable GetInfoClearAddresses (string idAddresses)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"EXEC GetInfoClearAddresse '{0}'",idAddresses),
                                             GlobalParameters.WmsGlobalSqlConnection);
                var result = new DataTable("ListAddresses");
                result.Columns.Add("idAdress", typeof(int));
                result.Columns.Add("ClearAddresses", typeof(int));
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressesInventory)).Error(
                       string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int ClearAddresses(string idAddresses, int userId)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"EXEC ClearAddressInCAtalog '{0}', {1}", idAddresses, userId),
                                             GlobalParameters.WmsGlobalSqlConnection);
                
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressesInventory)).Error(
                       string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public DataTable GetInfoRestAddresses(string idAddresses)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"EXEC GetInfoAddressBusy '{0}'", idAddresses),
                                             GlobalParameters.WmsGlobalSqlConnection);
                var result = new DataTable("ListRestAddresses");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(AddressesInventory)).Error(
                       string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
    }
}
