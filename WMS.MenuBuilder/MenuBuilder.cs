using System;
using System.Data;
using System.Data.SqlClient;
using WMS.Globals;

namespace WMS.MenuBuilder
{
    public class ChangesMenu
    {
        public int IdMenu { get; set; }
        public int IdParentMenu { get; set; }
        public bool State { get; set; }
    }

    public class AppMainMenu
    {
        public bool ShowMenuItem(int idUsergroup, int idParentMenu, int idMenuItem)
        {
            var command = new SqlCommand(string.Format(@"
            IF EXISTS (SELECT *
			FROM dbo.UserPermissions
			WHERE ID_GroupUsers = {0} AND ID_Menu = {1} AND ID_ParentMenu = {2})
            SELECT State
	            FROM dbo.UserPermissions
	            WHERE ID_GroupUsers = {0} AND ID_Menu = {1} AND ID_ParentMenu = {2}
            ELSE SELECT CAST(0 AS BIT) AS State", idUsergroup,
                                                       idMenuItem, idParentMenu),
                                         GlobalParameters.WmsGlobalSqlConnection);

            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            return Convert.ToBoolean(command.ExecuteScalar());
        }

        public void SetStateMenuItem(int idUserGroup, int idParentMenu, int idMenu, bool state)
        {
            var command = new SqlCommand("", GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            if (MenuItemExists(idUserGroup, idParentMenu, idMenu))
            {
                command.CommandText = string.Format(@"
                UPDATE UserPermissions 
                SET State = {0} 
                WHERE
                ID_GroupUsers = {1} AND 
                ID_ParentMenu = {2} AND 
                ID_Menu = {3}", Convert.ToInt16(state), idUserGroup, idParentMenu,idMenu);
                command.ExecuteNonQuery();
            }
            else
            {
                command.CommandText = string.Format(@"
	            INSERT INTO dbo.UserPermissions (ID_GroupUsers,ID_ParentMenu,ID_Menu,State) 
                VALUES ({0}, {1}, {2}, {3})", idUserGroup, idParentMenu, idMenu, Convert.ToInt16(state));
                command.ExecuteNonQuery();
            }
        }
        
        private bool MenuItemExists(int idUserGroup, int idParentMenu, int idMenu)
        {
            var command = new SqlCommand(string.Format(@"
            IF EXISTS (
                        SELECT * 
                        FROM UserPermissions 
                        WHERE 
                            ID_GroupUsers = {0} AND 
                            ID_ParentMenu = {1} AND 
                            ID_Menu = {2})
	            SELECT CAST(1 AS BIT)
            ELSE
	            SELECT CAST(0 AS BIT)", idUserGroup, idParentMenu,idMenu),
                                         GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            return Convert.ToBoolean(command.ExecuteScalar());
        }
    }
}
