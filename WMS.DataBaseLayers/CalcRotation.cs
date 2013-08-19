using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class CalcRotation
    {
        public void StartCalc(string idProducts, string dayRest, string percentMin)
        {
            var command =
                new SqlCommand(
                    string.Format(@"EXEC GetRotationInTable '{0}', '{1}', '{2}'", idProducts, dayRest, percentMin),
                    GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            command.ExecuteNonQuery();
        }

        public void InsertRotation(string idProducts, string max, string min)
        {
            var command =
                new SqlCommand(
                    string.Format(
                        "INSERT INTO QtyProductMinMax \n"
                        + "SELECT {0}, \n"
                        + "       GETDATE(), \n"
                        + "       ROUND({2}, 2, 0), \n"
                        + "       ROUND({1}, 2, 0), \n"
                        + "       CASE  \n"
                        + "            WHEN ( \n"
                        + "                     SELECT COUNT(*) \n"
                        + "                     FROM   Reference_GroupsWithProducts rgwp \n"
                        + "                     WHERE  rgwp.ProductID = {0} \n"
                        + "                 ) > 0 THEN ( \n"
                        + "                     SELECT cgrp.ID_TypeOfRotations \n"
                        + "                     FROM   Reference_GroupsWithProducts rgwp \n"
                        + "                            INNER JOIN Catalog_Groups cg \n"
                        + "                                 ON  cg.ID = rgwp.GroupID \n"
                        + "                            INNER JOIN Catalog_GroupRotationsProduct cgrp \n"
                        + "                                 ON  cgrp.ID_Group = cg.ID \n"
                        + "                     WHERE  {1} BETWEEN cgrp.MinQty AND cgrp.MaxQty AND \n"
                        + "                            rgwp.ProductID = {0} \n"
                        + "                     GROUP BY \n"
                        + "                            cgrp.ID_TypeOfRotations \n"
                        + "                 ) \n"
                        + "            ELSE ( \n"
                        + "                     SELECT ID \n"
                        + "                     FROM   Catalog_RotationsProduct c \n"
                        + "                     WHERE  {1} BETWEEN MinQty AND MaxQty \n"
                        + "                 ) \n"
                        + "       END AS IdTypeOfRotation", idProducts, max, min),
                    GlobalParameters.WmsGlobalSqlConnection) {CommandTimeout = GlobalParameters.CommandTimeout};
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            command.ExecuteNonQuery();
        }

        public DataTable GetRotationInfo(int idProdcut)
        {
            var command = new SqlCommand(string.Format("EXEC GetRotationInfo {0}", idProdcut),
                                         GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            var dt = new DataTable();
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
    }
}
