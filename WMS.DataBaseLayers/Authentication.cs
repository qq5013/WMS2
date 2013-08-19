using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class Authentication
    {
        public int ExistLogin(string login, string password)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"
                                IF EXISTS (SELECT * FROM dbo.Users WHERE [Login] = '{0}' AND [Password] = '{1}')
	                                SELECT ID FROM dbo.Users WHERE [Login] = '{0}' AND [Password] = '{1}'
                                ELSE
	                                SELECT -1 AS ID", login,
                                  Encription.CalculateMd5Hash(password)),
                    GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof (Authentication)).ErrorFormat(
                    "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                    exception.StackTrace);
                throw;
            }

        }

        public int ExistGroupForUser(int idUser)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"
                                IF EXISTS (SELECT * FROM RelationUserGroupUsers WHERE ID_User = {0})
	                                SELECT TOP 1 ID_GroupUser FROM RelationUserGroupUsers WHERE ID_User = {0}
                                ELSE
	                                SELECT -1 AS ID_GroupUser
                                ", idUser),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof (Authentication)).ErrorFormat(
                    "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                    exception.StackTrace);
                throw;
            }
            
        }

        public void SaveUserGlobalInformation(int userId)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"SELECT [Login], FirstName, LastName FROM dbo.Users WHERE ID  = '{0}'", userId),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var dt = new DataTable("UserInfo");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                ObjectsForMainApplication.LoginUserLogined = dt.Rows[0]["Login"].ToString();
                ObjectsForMainApplication.FirstNameUserLogined = dt.Rows[0]["FirstName"].ToString();
                ObjectsForMainApplication.LastNameUserLogined = dt.Rows[0]["LastName"].ToString();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof (Authentication)).ErrorFormat(
                    "Source: [{0}], Message: [{1}], StackTrace: [{2}]", exception.Source, exception.Message,
                    exception.StackTrace);
                throw;
            }
            
        }

    }
}
