using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class Administration
    {
        public void AddNewUserGroup(string name, string description)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"                                	
                                INSERT INTO GroupUsers ([Name], Description) 
                                VALUES ('{0}', '{1}') ", name, description),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
                GlobalParameters.Log(typeof (Administration)).InfoFormat("Добвалена группа {0}, пользователем {1}", name,
                                                                         ObjectsForMainApplication.LoginUserLogined);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }
        public void AddNewUserGroup(string name, string description, List<int> idUsers)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"                                	
                                INSERT INTO GroupUsers ([Name], Description) 
                                VALUES ('{0}', '{1}') 
                                SELECT @@IDENTITY", name, description),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                var idGroup = Convert.ToInt32(command.ExecuteScalar());

                GlobalParameters.Log(typeof (Administration)).InfoFormat("Добвалена группа {0}, пользователем {1}", name,
                                                                         ObjectsForMainApplication.LoginUserLogined);

                if (idUsers.Count > 0)
                {
                    foreach (var idUser in idUsers)
                    {
                        command.CommandText = string.Format(@"                                	
                                INSERT INTO RelationUserGroupUsers (ID_GroupUser,ID_User) 
                                VALUES ({0},{1})", idGroup,
                                                            idUser);
                        if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                        {
                            GlobalParameters.WmsGlobalSqlConnection.Open();
                        }
                        command.ExecuteNonQuery();
                        GlobalParameters.Log(typeof (Administration)).InfoFormat(
                            "В группу {0}, был прикреплён пользователь {1}, пользователем {2}", name, idUser,
                            ObjectsForMainApplication.LoginUserLogined);
                    }
                }

            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }
        public void EditUserGroup(int idGroup, string name, string description, List<int> idUsersForAdd, List<int> idUsersForRemove)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"                                	
                                UPDATE GroupUsers
                                SET [Name] = '{0}', Description = '{1}'
                                WHERE ID = {2}", name, description, idGroup),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof (Administration)).InfoFormat(
                    "У грппы {0}, были сделаны изменения, имя группы '{1}', описание '{2}', пользователем {3}", idGroup,
                    name, description, ObjectsForMainApplication.LoginUserLogined);

                if (idUsersForAdd.Count > 0)
                {
                    foreach (var idUser in idUsersForAdd)
                    {
                        command.CommandText = string.Format(@"
                                IF NOT EXISTS(SELECT * FROM RelationUserGroupUsers WHERE ID_GroupUser = {0} AND ID_User = {1})
                                INSERT INTO RelationUserGroupUsers (ID_GroupUser,ID_User) 
                                VALUES ({0},{1})", idGroup, idUser);
                        if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                        {
                            GlobalParameters.WmsGlobalSqlConnection.Open();
                        }
                        command.ExecuteNonQuery();

                        GlobalParameters.Log(typeof (Administration)).InfoFormat(
                            "К группе {0}, был добавлен пользователь {1}, пользователем {2}", idGroup, idUser,
                            ObjectsForMainApplication.LoginUserLogined);
                    }
                }
                if (idUsersForRemove.Count > 0)
                {
                    foreach (var idUser in idUsersForRemove)
                    {
                        command.CommandText = string.Format(@"                                	
                                DELETE FROM RelationUserGroupUsers 
                                WHERE ID_GroupUser = {0} AND ID_User = {1}", idGroup, idUser);
                        if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                        {
                            GlobalParameters.WmsGlobalSqlConnection.Open();
                        }
                        command.ExecuteNonQuery();

                        GlobalParameters.Log(typeof (Administration)).WarnFormat(
                            "Из группы {0} был удалён пользователь {1}, пользователем {2}", idGroup, idUser,
                            ObjectsForMainApplication.LoginUserLogined);
                    }
                }
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }

        public void AddNewUser(string login, string password, string firstName, string lastName, bool activeUser)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@" 
                                INSERT INTO Users ([Login], Password, FirstName, LastName, Active) 
                                VALUES ( '{0}','{1}', '{2}', '{3}', {4})", login,
                              password, firstName, lastName, Convert.ToInt16(activeUser)),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof (Administration)).InfoFormat(
                    "Был добавлени пользователь {0} | [{1} {2}], пользователем {3}", login, lastName, firstName,
                    ObjectsForMainApplication.LoginUserLogined);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }
        public void AddNewUser(string login, string password, string firstName, string lastName, bool activeUser, int idGroup)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@" 
                                INSERT INTO Users ([Login], Password, FirstName, LastName, Active) 
                                VALUES ( '{0}','{1}', '{2}', '{3}', {4})
                                SELECT @@IDENTITY", login, password, firstName, lastName,
                              Convert.ToInt16(activeUser)),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var idUser = Convert.ToInt32(command.ExecuteScalar());

                if (idGroup > 0)
                {
                    command.CommandText = string.Format(@"                                	
                                INSERT INTO RelationUserGroupUsers (ID_GroupUser,ID_User) 
                                VALUES ({0},{1})", idGroup, idUser);
                    if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                    {
                        GlobalParameters.WmsGlobalSqlConnection.Open();
                    }
                    command.ExecuteNonQuery();

                    GlobalParameters.Log(typeof (Administration)).InfoFormat(
                        "Был добавлени пользователь {0} | [{1} {2}] и добавлен в группу {4}, пользователем {3}", login,
                        lastName, firstName,
                        ObjectsForMainApplication.LoginUserLogined, idGroup);
                }
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }
        public void EditUser(int idUser, string login, string password, string firstName, string lastName, bool activeUser, int idGroupAdd)
        {
            try
            {
                var command = new SqlCommand("", GlobalParameters.WmsGlobalSqlConnection);
                if (password != "")
                {
                    command.CommandText = string.Format(@" 
                                UPDATE Users SET [Login] = '{0}', Password = '{1}', FirstName = '{2}', LastName = '{3}', Active = {4} 
                                WHERE ID = {5}", login, password,
                                                        firstName, lastName, Convert.ToInt16(activeUser), idUser);
                }
                else
                {
                    command.CommandText = string.Format(@" 
                                UPDATE Users SET [Login] = '{0}', FirstName = '{1}', LastName = '{2}', Active = {3} 
                                WHERE ID = {4}", login, firstName,
                                                        lastName, Convert.ToInt16(activeUser), idUser);
                }
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();

                if (password != null)
                {
                    GlobalParameters.Log(typeof (Administration)).InfoFormat(
                        "У пользователя {0}, были изменены следующие параметры а так же пароль, логин '{1}',имя '{2}',фамилия '{3}',признак активности '{4}',пользователем {5}",
                        idUser, login, firstName, lastName, activeUser, ObjectsForMainApplication.LoginUserLogined);

                }
                else
                {
                    GlobalParameters.Log(typeof (Administration)).InfoFormat(
                        "У пользователя {0}, были изменены следующие параметры, логин '{1}',имя '{2}',фамилия '{3}',признак активности '{4}',пользователем {5}",
                        idUser, login, firstName, lastName, activeUser, ObjectsForMainApplication.LoginUserLogined);
                }
                
                if (idGroupAdd > 0)
                {
                    command.CommandText = string.Format(@"          
                                DELETE FROM RelationUserGroupUsers WHERE ID_User = {1}
                                INSERT INTO RelationUserGroupUsers (ID_GroupUser,ID_User) 
                                VALUES ({0},{1})", idGroupAdd, idUser);
                    if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                    {
                        GlobalParameters.WmsGlobalSqlConnection.Open();
                    }
                    command.ExecuteNonQuery();

                    GlobalParameters.Log(typeof (Administration)).InfoFormat(
                        "Пользователь {0}, был добавлен в группу {1}, пользователем {2}", idUser, idGroupAdd,
                        ObjectsForMainApplication.LoginUserLogined);
                }
                else
                {
                    command.CommandText = string.Format(@"          
                                DELETE FROM RelationUserGroupUsers WHERE ID_User = {0}", idUser);
                    if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                    {
                        GlobalParameters.WmsGlobalSqlConnection.Open();
                    }
                    command.ExecuteNonQuery();

                    GlobalParameters.Log(typeof (Administration)).WarnFormat(
                        "Пользователь {0}, был удалён из всех групп, пользователем {1}", idUser,
                        ObjectsForMainApplication.LoginUserLogined);
                }

            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void SendMessage(Guid sessionId, string caption, string body, string iconType)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"
                                            INSERT INTO UserMessagesPerSession
                                            (
	                                            ID_Session,
	                                            Caption,
	                                            Body,
	                                            IconType,
	                                            SendDate
                                            )
                                            VALUES
                                            (
	                                            '{0}',
	                                            '{1}',
	                                            '{2}',
	                                            '{3}',
	                                            GETDATE()
                                            )", sessionId, caption, body, iconType),
                GlobalParameters.WmsGlobalSqlConnection);

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();

                GlobalParameters.Log(typeof (Administration)).InfoFormat(
                    "Пользователем {0}, было отправлено сообщение {1}", ObjectsForMainApplication.LoginUserLogined, body);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public static DataTable ReadMessage(Guid sessionId)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"
                            IF EXISTS (
                                   SELECT Caption,
                                          Body,
                                          IconType
                                   FROM   UserMessagesPerSession
                                   WHERE  ID_Session = '{0}'
                               )
                                SELECT Caption,
                                       Body,
                                       IconType
                                FROM   UserMessagesPerSession
                                WHERE  ID_Session = '{0}'
                                ORDER BY
                                       SendDate ASC
                            ", sessionId),
                GlobalParameters.WmsGlobalSqlConnection);

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                var dt = new DataTable("Messages");
                var adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    return dt;
                }
                return null;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public static  void DeleteReadedMessages(Guid sessionId)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"
                            DELETE                            
                            FROM   UserMessagesPerSession
                            WHERE  ID_Session = '{0}'", sessionId),
                GlobalParameters.WmsGlobalSqlConnection);

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(Administration)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
    }
}
