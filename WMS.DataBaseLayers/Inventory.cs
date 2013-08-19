using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class InventoryAddresses
    {
        public int CreateNewDocInventory()
        {
            var command =
                new SqlCommand(string.Format(@"
                                INSERT INTO DocsInventory
                                (	                                
	                                DocDate,
	                                DocDateExecuted,
	                                DocOwner
                                )
                                VALUES
                                (
	                                GETDATE(),
	                                '18000101',
	                                {0}
                                )
                                SELECT @@IDENTITY",
                                             ObjectsForMainApplication.IdUserLogined),
                               GlobalParameters.WmsGlobalSqlConnection);

            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return Convert.ToInt32(command.ExecuteScalar());

        }

        /*
        public DataTable GetPartInfoOnAddress(string addressStr)
        {
            var command = new SqlCommand(string.Format(@""), GlobalParameters.WmsGlobalSqlConnection);
        }
        */
    }
}
