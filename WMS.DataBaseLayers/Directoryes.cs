using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WMS.Globals;

namespace WMS.DataBaseLayers
{
    public class DbDirsAddEdit
    {

        public int AddResponsibleZone(string name, int idZone)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"
                                INSERT INTO Catalog_ResponsibleForTheZone(ID_Zone, Name) VALUES({0},'{1}')
                                SELECT @@IDENTITY", idZone, name),
                    GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());
                GlobalParameters.Log(typeof(DbDirsAddEdit)).InfoFormat(
                    "В справочник ответсвенных за зоны был довавлен элемент '{0}, пользователем - {1}'", name,
                    ObjectsForMainApplication.LoginUserLogined);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void EditResponsibleZone(int id, string name, int idZone)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(
                        @"UPDATE Catalog_ResponsibleForTheZone SET ID_Zone = {0}, Name = '{1}' WHERE ID = {2}", idZone,
                        name, id), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
                GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                    "В справочнике ответсвенных за зоны, был изменён элемент {0}, новые значения: имя ответсвенного за зону - '{1}', id зоны - '{2}', пользователем {3}",
                    id, name, idZone, ObjectsForMainApplication.LoginUserLogined);
            }
            catch (Exception exception )
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int AddZone(string name, string description)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"
                                INSERT INTO Catalog_Zones(Name, [Description]) VALUES ( '{0}', '{1}')
                                SELECT @@IDENTITY", name, description),
                    GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());
                GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                    "В справочник зон был довавлен элемент '{0}, пользователем - {1}'", name,
                    ObjectsForMainApplication.LoginUserLogined);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
        
        public void EditZone(int id, string name, string description)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"UPDATE Catalog_Zones SET Name = '{0}', [Description] = '{1}' WHERE ID = {2}", name,
                                  description, id), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
                GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                    "В справочнике зон, был изменён элемент {0}, новые значения: имя зоны - '{1}', описание зоны - '{2}', пользователем {3}",
                    id, name, description, ObjectsForMainApplication.LoginUserLogined);
            }
            catch (Exception exception )
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int AddWarehouse(string name, string description, int idTypeOfDistribution)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format(
                            @"INSERT INTO Catalog_Warehouses (Name, Description, TypeOfDistribution) VALUES ('{0}', '{1}', {2})",
                            name, description, idTypeOfDistribution), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());
                GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                    "В справочник складов был добавлен елемент {0}, пользователем {1}", name,
                    ObjectsForMainApplication.LoginUserLogined);
                return result;

            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void EditWarehouse(int id, string name, string description, int idTypeOfDistribution)
        {
            try
            {
                var command =
                new SqlCommand(
                    string.Format(
                        @"UPDATE Catalog_Warehouses SET Name = '{0}', Description = '{1}', TypeOfDistribution = {3} WHERE ID = {2}",
                        name, description, id, idTypeOfDistribution),
                    GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
                GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                    "В справочнике складов был изменён элемент {0}, новые значения: имя склада - '{1}', описание склада '{2}',тип дистрибуции склада {3}, пользователем {4} ",
                    id, name, description, idTypeOfDistribution, ObjectsForMainApplication.LoginUserLogined);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int AddStreet(string name, string description, int idZona)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format(
                            @"INSERT INTO Catalog_Streets (Name, Description, ID_Zona) VALUES ('{0}', '{1}', {2})",
                            name, description, idZona), GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());
                GlobalParameters.Log(typeof(DbDirsAddEdit)).InfoFormat(
                    "В справочник улиц был добавлен елемент '{0}', пользователем {1}", name,
                    ObjectsForMainApplication.LoginUserLogined);
                return result;

            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void EditStreet(int id, string name, string description, int idZona)
        {
            try
            {
                var command =
                new SqlCommand(
                    string.Format(
                        @"UPDATE Catalog_Streets SET Name = '{0}', Description = '{1}', ID_Zona = {2} WHERE ID = {3}",
                        name, description, idZona, id),
                    GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
                GlobalParameters.Log(typeof(DbDirsAddEdit)).InfoFormat(
                    "В справочнике улиц был изменён элемент {0}, новые значения: имя улицы - '{1}',описание улицы '{2}',зона склада {3}, пользователем {4} ",
                    id, name, description, idZona, ObjectsForMainApplication.LoginUserLogined);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int AddTypeOfRest(string name)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"
                                INSERT INTO Catalog_TypeOfRests (Name) VALUES ('{0}')
                                SELECT @@IDENTITY", name),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());
                GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                    "В справочник типов остатков был добавлен элемент '{0}', пользователем - {1}", name,
                    ObjectsForMainApplication.LoginUserLogined);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }

        public void EditTypeOfRest(int id, string name)
        {
            try
            {
                var command = new SqlCommand(
                string.Format(@"
                                UPDATE Catalog_TypeOfRests SET Name = '{0}' WHERE ID = {1}",
                              name, id),
                GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
                GlobalParameters.Log(typeof(DbDirsAddEdit)).InfoFormat(
                    "В справочнике типов остатков был изменёно значение у элемента '{0}' на '{1}', пользователем - {2}", id , name,
                    ObjectsForMainApplication.LoginUserLogined);
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }

        public int AddEditGroup(string name, string description, int idZone, int idWarehouse, bool addNewRecord)
        {
            return AddEditGroup(name, description, idZone, idWarehouse, addNewRecord, -1);
        }

        public int AddEditGroup(string name, string description, int idZone, int idWarehouse, bool addNewRecord, int idGroup)
        {
            try
            {
                var strIdGroup = idGroup != -1 ? idGroup.ToString() : "null";
                
                var command =
                    new SqlCommand(string.Format("" +
                                                 "EXEC AddNewGroup " +
                                                 "  @nameGroup = '{0}'," +
                                                 "  @descriptionGroup = '{1}'," +
                                                 "  @idZone = {2}," +
                                                 "  @idWarehouse = {5}," +
                                                 "  @addNewRecord = {3}," +
                                                 "  @idGroup = {4} ", name, description, idZone, Convert.ToInt32(addNewRecord), strIdGroup, idWarehouse),
                                   GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                var result = Convert.ToInt32(command.ExecuteScalar());

                GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                    "В справочнике зональных групп была добавлена новая запись: " +
                    "Код записи - {4}" +
                    "Имя группы - '{0}', Описание группы -  '{1}', Код зоны - {2}, пользователем - {3}",
                    name, description, idZone, ObjectsForMainApplication.LoginUserLogined, result);
                return addNewRecord ? result : idGroup;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void AddEditGroupRotations(int idTypeOfRotations, int idGroup, decimal minQty, decimal maxQty)
        {
            try
            {
                var command =
                    new SqlCommand(string.Format("EXEC AddEditGroupRotationsProduct \n"
                                                 + "	@idTypeOfRotations = {0}, \n"
                                                 + "	@idGroup = {1}, \n"
                                                 + "	@minQty = {2}, \n"
                                                 + "	@maxQty = {3}", idTypeOfRotations, idGroup, minQty.ToString().Replace(',','.'), maxQty.ToString().Replace(',','.')),
                                   GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
        
        public void AddReferenceGroupWithAddressesInCatalog(int idGroup,string idsStreets, string idsRafts, bool addNewRecord)
        {
            try
            {
                var command =
                    new SqlCommand(string.Format("EXEC AddReferenceGroupWithRafts" +
                                                 "  @idGroup = {0}," +
                                                 "  @listIdStreets = '{1}'," +
                                                 "  @listIdRafts = '{2}'," +
                                                 "  @addNewRecord = {3}", idGroup, idsStreets, idsRafts, Convert.ToInt32(addNewRecord)),
                                   GlobalParameters.WmsGlobalSqlConnection);

                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();

            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public DataSet GetReferenceGroupWithRaftsAndStreets(int idGroup)
        {
            try
            {
                var command = new SqlCommand(string.Format("EXEC GetReferenceGroupWithRafts {0}", idGroup),
                                             GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                //command.CommandType = CommandType.StoredProcedure;
                var adapter = new SqlDataAdapter(command);
                var result =  new DataSet();
                adapter.Fill(result);
                result.Tables[0].TableName = "Streets";
                result.Tables[1].TableName = "Rafts";
                
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void DeleteReferenceProductWithGroup(int idProduct)
        {
            try
            {
                var command = new SqlCommand(string.Format("DELETE FROM Reference_GroupsWithProducts WHERE ProductID = {0}", idProduct),
                                             GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void AddReferenceProductWithGroup(int idProduct, int idGroup)
        {
            try
            {
                var command = new SqlCommand(string.Format("EXEC AddEditReferenceProductWithGroups " +
                                                           "@idProduct = {0}, " +
                                                           "@idGroup = {1}", idProduct, idGroup),
                                             GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public List<int> GetReferenceProductWithGroups(int idProduct)
        {
            try
            {
                var command = new SqlCommand(string.Format("EXEC GetReferenceProductWithGroup {0}", idProduct),
                                             GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);

                var result = new List<int>();

                if (dt.Rows.Count > 0)
                {
                    result.AddRange(dt.Select().Select(dataRow => Convert.ToInt32(dataRow[0])));
                }

                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        

        public bool DeleteDirectoriesItem (TypeOfCatalog typeOfCatalog, int idItem)
        {
            try
            {
                bool result = false;
                var commnad = new SqlCommand("", GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                switch (typeOfCatalog)
                {
                    case TypeOfCatalog.Warehouse:
                        commnad.CommandText = string.Format(
                              "IF ( \n"
                            + "       SELECT COUNT(*) \n"
                            + "       FROM   Catalog_Warehouses cw \n"
                            + "              INNER JOIN Catalog_Addresses ca \n"
                            + "                   ON  cw.ID = ca.ID_Warehouses \n"
                            + "       WHERE  cw.ID = {0} \n"
                            + "   ) = 0 \n"
                            + "BEGIN \n"
                            + "    DELETE  \n"
                            + "    FROM   Catalog_Warehouses \n"
                            + "    WHERE  ID = {0} \n"
                            + "     \n"
                            + "    SELECT CAST(1 AS BIT) \n"
                            + "END \n"
                            + "ELSE \n"
                            + "    SELECT CAST(0 AS BIT)", idItem);
                        result = Convert.ToBoolean(commnad.ExecuteScalar());
                        if (result)
                            GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                                "В справочнике складов был удалён элемент с ID '{0}' , пользователем - {1}",
                                idItem, ObjectsForMainApplication.LoginUserLogined);
                        break;

                    case TypeOfCatalog.Street:
                        commnad.CommandText = string.Format(
                            "IF ( \n"
                           + "       SELECT COUNT(*) \n"
                           + "       FROM   Catalog_Streets cs \n"
                           + "              INNER JOIN Catalog_Addresses ca \n"
                           + "                   ON  ca.ID_Streets = cs.ID \n"
                           + "       WHERE  cs.ID = {0} \n"
                           + "   ) = 0 \n"
                           + "BEGIN \n"
                           + "    DELETE  \n"
                           + "    FROM   Catalog_Streets \n"
                           + "    WHERE  ID = {0} \n"
                           + "     \n"
                           + "    SELECT CAST(1 AS BIT) \n"
                           + "END \n"
                           + "ELSE \n"
                           + "    SELECT CAST(0 AS BIT)", idItem);
                        result = Convert.ToBoolean(commnad.ExecuteScalar());
                        if (result)
                            GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                                "В справочнике улиц был удалён элемент с ID '{0}' , пользователем - {1}",
                                idItem, ObjectsForMainApplication.LoginUserLogined);
                        break;

                    case TypeOfCatalog.Raft:
                        commnad.CommandText = string.Format(
                            "IF ( \n"
                           + "SELECT COUNT(*) \n"
                           + "FROM   Catalog_Raft cr \n"
                           + "       INNER JOIN Catalog_Addresses ca \n"
                           + "            ON  ca.ID_Rafts = cr.ID \n"
                           + "WHERE  cr.ID = {0}"
                           + "   ) = 0 \n"
                           + "BEGIN \n"
                           + "    DELETE  \n"
                           + "    FROM   Catalog_Raft \n"
                           + "    WHERE  ID = {0} \n"
                           + "     \n"
                           + "    SELECT CAST(1 AS BIT) \n"
                           + "END \n"
                           + "ELSE \n"
                           + "    SELECT CAST(0 AS BIT)", idItem);
                        result = Convert.ToBoolean(commnad.ExecuteScalar());
                        if (result)
                            GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                                "В справочнике стеллажей был удалён элемент с ID '{0}' , пользователем - {1}",
                                idItem, ObjectsForMainApplication.LoginUserLogined);
                        break;

                    case TypeOfCatalog.Shelf:
                        commnad.CommandText = string.Format(
                            "IF ( \n"
                            + "SELECT COUNT(*) \n"
                            + "FROM   Catalog_Shelfs cs \n"
                            + "       INNER JOIN Catalog_Addresses ca \n"
                            + "            ON  ca.ID_Shelfs = cs.ID \n"
                            + "WHERE  cs.ID = {0} "
                            + "   ) = 0 \n"
                            + "BEGIN \n"
                            + "    DELETE  \n"
                            + "    FROM   Catalog_Shelfs \n"
                            + "    WHERE  ID = {0} \n"
                            + "    SELECT CAST(1 AS BIT) \n"
                            + "END \n"
                            + "ELSE \n"
                            + "    SELECT CAST(0 AS BIT)", idItem);
                        result = Convert.ToBoolean(commnad.ExecuteScalar());
                        if (result)
                            GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                                "В справочнике полок был удалён элемент с ID '{0}' , пользователем - {1}",
                                idItem, ObjectsForMainApplication.LoginUserLogined);
                        break;

                    case TypeOfCatalog.ShelfSpace:
                        commnad.CommandText = string.Format(
                            "IF ( \n"
                            + "SELECT COUNT(*) \n"
                            + "FROM   Catalog_ShelfSpaces css \n"
                            + "       INNER JOIN Catalog_Addresses ca \n"
                            + "            ON  ca.ID_ShelfSpaces = css.ID \n"
                            + "WHERE  css.ID = {0}"
                            + "   ) = 0 \n"
                            + "BEGIN \n"
                            + "    DELETE  \n"
                            + "    FROM   Catalog_ShelfSpaces \n"
                            + "    WHERE  ID = {0} \n"
                            + "     \n"
                            + "    SELECT CAST(1 AS BIT) \n"
                            + "END \n"
                            + "ELSE \n"
                            + "    SELECT CAST(0 AS BIT)", idItem);
                        result = Convert.ToBoolean(commnad.ExecuteScalar());
                        if (result)
                            GlobalParameters.Log(typeof (DbDirsAddEdit)).InfoFormat(
                                "В справочнике мест на полках был удалён элемент с ID '{0}' , пользователем - {1}",
                                idItem, ObjectsForMainApplication.LoginUserLogined);

                        break;
                }
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbDirsAddEdit)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
            
        }

        public class DbDirsDataTables
        {
            public DataTable FillTableListsStreets(int idWarehouse, int idZone)
            {
                var command = new SqlCommand(
                    string.Format("EXEC GetListStreetsForGroup {0}, {1}", idWarehouse, idZone),
                    GlobalParameters.WmsGlobalSqlConnection);

                var result = new DataTable("ListStreets");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;

            }

            public DataTable FillTableListsRafts(int idWarehouse, int idZone, string idsStreets)
            {
                var command = new SqlCommand(
                    string.Format("EXEC GetListRaftsForGroup {0}, {1}, '{2}'", idWarehouse, idZone, idsStreets),
                    GlobalParameters.WmsGlobalSqlConnection);

                var result = new DataTable("ListRafts");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;

            }
        }
    }
}
