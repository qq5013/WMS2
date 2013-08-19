using System;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using log4net;
using log4net.Config;


namespace WMS.Globals
{
    
    public enum TypeOfGoods
    {
        SellGood,
        LabGood
    }
    public static class ObjectsForMainApplication
    {
        public static int IdGroupUserLogined { get; set; }
        public static int IdUserLogined { get; set; }
        public static string LoginUserLogined { get; set; }
        public static string FirstNameUserLogined { get; set; }
        public static string LastNameUserLogined { get; set; }
        public static bool IgnoreAddressDelimmeterLastChar { get; set; }
        public static Guid SessionId { get; set; }
        public static string VersionClient { get; set; }
        public static bool AutoDebitRests { get; set; }
    }
    
    public static class ObjectsForAddressAsignmets
    {
        public static int SkuIdFromDirs { get; set; }
        public static string DescriptionGoodFromDirs { get; set; }
        public static BindingSource MSellBindingSource = new BindingSource();
        public static DataTable DSsell { get; set; }
        public static DataTable DSlab { get; set; }
        public static BindingSource MLabBindingSource = new BindingSource();
        public static int LastFocusedSkuId { get; set ; }
        public static int LastFocusedRowHandleId { get; set; }
    }

    public static class ObjectsForPrintAddressLabels
    {
        public static bool Printed { get; set; }
    }
    
    public static class Encription
    {
        public static string CalculateMd5Hash(string input)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
            
        }
    }

    public static class EncodeCode128
    {
        
    }
    public class DataForReplenishmentList
    {
        public int IdReplDoc { get; set; }
        public int IdReplDocRow { get; set; }
        public int IdProduct { get; set; }
        public int IdPartRow { get; set; }
        public decimal NeedQtyForMigrate { get; set; }
        public decimal QtyForMigrate { get; set; }
        public int IdAddressCatalogFrom { get; set; }
        public int IdAddressCatalogTo { get; set; }
        public bool ErrorDecode { get; set; }
    }
    public static class DecodeCode128
    {
        public static DataForReplenishmentList Decode(string value)
        {
            try
            {
                var result = new DataForReplenishmentList();
                if (!string.IsNullOrEmpty(value))
                {
                    result.IdReplDoc = Convert.ToInt32(value.Substring(0, 6));
                    value = value.Substring(6, value.Length - 6);
                    result.IdReplDocRow = Convert.ToInt32(value.Substring(0, 6));
                    value = value.Substring(6, value.Length - 6);
                    /*
                    result.IdProduct = Convert.ToInt32(value.Substring(0, 6));
                    value = value.Substring(6, value.Length - 6);
                    result.IdPartRow = Convert.ToInt32(value.Substring(0, 10));
                    value = value.Substring(10, value.Length - 10);
                    result.NeedQtyForMigrate = Convert.ToDecimal(value.Substring(0, 13));
                    value = value.Substring(13, value.Length - 13);
                    result.NeedQtyForMigrate = result.NeedQtyForMigrate + Convert.ToDecimal("0," + value.Substring(0, 6));
                    value = value.Substring(6, value.Length - 6);
                    result.QtyForMigrate = Convert.ToDecimal(value.Substring(0, 13));
                    value = value.Substring(13, value.Length - 13);
                    result.QtyForMigrate = result.QtyForMigrate + Convert.ToDecimal("0," + value.Substring(0, 6));
                    value = value.Substring(6, value.Length - 6);
                    result.IdAddressCatalogFrom = Convert.ToInt32(value.Substring(0, 6));
                    value = value.Substring(6, value.Length - 6);
                    result.IdAddressCatalogTo = Convert.ToInt32(value.Substring(0, 6));
                    value = value.Substring(6, value.Length - 6);
                    */
                    result.ErrorDecode = value != "";
                }
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DecodeCode128)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
    }
    
    
    public class GlobalParameters
    {
        public static SqlConnection WmsGlobalSqlConnection = new SqlConnection();
        public static SqlConnection OnixGlobalSqlConnection = new SqlConnection();
        public static SqlConnection SymphonyGlobalSqlConnection = new SqlConnection();
        public static Bar MainMenuGlobal = new Bar();
        public static int CommandTimeout;
        public static string WmsConnectionString;
        public static string OnixConnectionString;
        public static string SymphonyConnectionString;
        public static string LabelPrinterAddress { get; set; }
        public static string LabelPrinterOutputFile { get; set; }
        public static string LabelPrinterParamType { get; set; }
        public static string LabelPrinterHeadName { get; set; }
        public static string LabelPrinterHeadPhone { get; set; }
        public static IPAddress[] IpAddressesClient { get; set; }
        public static string HostNameClient { get; set; }
        public static string WindowsUserName { get; set; }
        public static bool ReplenishmentListExecuted { get; set; }
        public static string PathForPrintForms { get; set; }


        public static void GetInfoMashine()
        {
            HostNameClient = Dns.GetHostName();

            var ipEntry = Dns.GetHostByName(HostNameClient);
            IpAddressesClient = ipEntry.AddressList;
            WindowsUserName = WindowsIdentity.GetCurrent().Name;
        }

        public static string SplitListToString(List<int> listItems)
        {
            string result = "";
            if (listItems.Count >= 1)
            {
                result = listItems.Aggregate(result, (current, i) => current + i.ToString() + ",");
                result = result.Substring(0, result.Length - 1);
            }
            else
                result = listItems[0].ToString();
            return result;
        }

        public static string SplitStringListToString(List<string> listItems)
        {
            string result = "";
            if (listItems.Count >= 1)
            {
                result = listItems.Aggregate(result, (current, i) => current + i.ToString() + ",");
                result = result.Substring(0, result.Length - 1);
            }
            else
                result = listItems[0].ToString();
            return result;
        }

        public static string SplitIntDataRowToString(DataRow[] dr, string column)
        {
            List<int> listItems = dr.Select(dataRow => Convert.ToInt32(dataRow[column])).ToList();
            string result = "";
            if (listItems.Count >= 1)
            {
                result = listItems.Aggregate(result, (current, i) => current + i.ToString() + ",");
                result = result.Substring(0, result.Length - 1);
            }
            else
                result = listItems[0].ToString();
            return result;
        }

        public static string SplitStringDataRowToString(DataRow[] dr, string column)
        {
            List<string> listItems = dr.Select(dataRow => dataRow[column].ToString()).ToList();
            string result = "";
            if (listItems.Count >= 1)
            {
                result = listItems.Aggregate(result, (current, i) => current + i.ToString() + ",");
                result = result.Substring(0, result.Length - 1);
            }
            else
                result = listItems[0];
            return result;
        }

        public static DataTable GetInfoUserWhoBlockedMySession(int userId)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                SELECT 
                                    us.ID_Session, 
                                    us.ID_User, 
                                    us.ClientName, 
                                    us.ClientIP, 
                                    us.DomainNameUser,
                                    us.SessionLife 
	                            FROM UserSessions us
	                            WHERE us.ID_User = {0}", userId),
                                             WmsGlobalSqlConnection);
                if (WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    WmsGlobalSqlConnection.Open();
                }

                var table = new DataTable("UserSessions");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                return table;
            }
            catch (Exception exception)
            {
                Log(typeof(GlobalParameters)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public static void ClearSession(Guid sessionId)
        {
            try
            {
                var commnad = new SqlCommand(string.Format("DELETE FROM UserSessions WHERE ID_Session = '{0}'", sessionId),
                                         WmsGlobalSqlConnection);
                if (WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    WmsGlobalSqlConnection.Open();
                }
                commnad.ExecuteNonQuery();

                Log(typeof (GlobalParameters)).InfoFormat(
                    "Пользователем {0}, была удалена " +
                    "пользовательская сессия {1}", ObjectsForMainApplication.IdUserLogined, sessionId);
            }
            catch (Exception exception)
            {
                Log(typeof (GlobalParameters)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public static bool CheckMySession(Guid sessionId, int userId)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                IF EXISTS(SELECT * FROM UserSessions us WHERE us.ID_User = {0} AND us.ID_Session = '{1}')
	                                SELECT CAST(1 AS BIT) AS Result
	                                ELSE
		                                SELECT CAST(0 AS BIT) AS Result",
                                                           userId, sessionId), WmsGlobalSqlConnection);
                if (WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    WmsGlobalSqlConnection.Open();
                }

                var result = Convert.ToBoolean(command.ExecuteScalar());

                return result;
            }
            catch (Exception exception)
            {
                Log(typeof (GlobalParameters)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public static bool CheckSessionByUser(int userId)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"
                                IF EXISTS(SELECT * FROM UserSessions us WHERE us.ID_User = {0})
	                                SELECT CAST(1 AS BIT) AS Result
	                                ELSE
		                                SELECT CAST(0 AS BIT) AS Result",
                                                           userId), WmsGlobalSqlConnection);
                if (WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    WmsGlobalSqlConnection.Open();
                }

                var result = Convert.ToBoolean(command.ExecuteScalar());

                return result;
            }
            catch (Exception exception)
            {
                Log(typeof (GlobalParameters)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public static void SetSession(Guid sessionId, int userId, string clientName, string clientIp,string domainNameUser, bool createNewSession)
        {
            try
            {
                if (createNewSession)
                {
                    var commnad = new SqlCommand(
                        string.Format(@"
                                    INSERT INTO UserSessions
	                                    (
		                                    ID_Session,
		                                    ID_User,
		                                    ClientName,
		                                    ClientIP,
                                            DomainNameUser,
		                                    SessionLife,
                                            VersionClient
	                                    )
	                                    VALUES
	                                    (
		                                    '{0}',
		                                    {1},
		                                    '{2}',
		                                    '{3}',
                                            '{4}',
		                                    GETDATE(),
                                            '{5}'
	                                    )", sessionId, userId, clientName,
                                      clientIp, domainNameUser, ObjectsForMainApplication.VersionClient), WmsGlobalSqlConnection);

                    if (WmsGlobalSqlConnection.State == ConnectionState.Closed)
                    {
                        WmsGlobalSqlConnection.Open();
                    }
                    commnad.ExecuteNonQuery();

                    Log(typeof (GlobalParameters)).InfoFormat(
                        "Пользователь {0}, создал новую сессию {1}, " +
                        "c IP адреса {2}", userId, sessionId, clientIp);
                }
                else
                {
                    var commnad = new SqlCommand(
                        string.Format(@"
                                UPDATE UserSessions
	                            SET
                                    ID_Session = '{0}',
		                            SessionLife = GETDATE(),
		                            ClientIP = '{3}',
                                    ClientName = '{2}',
                                    DomainNameUser = '{4}',
                                    VersionClient = '{5}'
	                            WHERE ID_User = {1}
                                ", sessionId, userId, clientName, clientIp, domainNameUser, ObjectsForMainApplication.VersionClient), WmsGlobalSqlConnection);
                    if (WmsGlobalSqlConnection.State == ConnectionState.Closed)
                    {
                        WmsGlobalSqlConnection.Open();
                    }
                    commnad.ExecuteNonQuery();

                    Log(typeof(GlobalParameters)).InfoFormat(
                        "Пользователем {0}, была перехвачена его же сессия {1}, " +
                        "c IP адреса {2}", userId, sessionId, clientIp);
                }
            }
            catch (Exception exception)
            {
                Log(typeof (GlobalParameters)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public static void ReadGlobalParameters()
        {
            try
            {
                var command = new SqlCommand("SELECT * FROM Parameters_Glabal", WmsGlobalSqlConnection) { CommandTimeout = CommandTimeout };
                if (WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    WmsGlobalSqlConnection.Open();
                }

                var dt = new DataTable("Parameters_Glabal");
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                var result = dt.Select("Name = 'IgnoreAddressDelimeterLastChar'");
                if (result.GetLength(0) > 0)
                {
                    ObjectsForMainApplication.IgnoreAddressDelimmeterLastChar = Convert.ToBoolean(result[0]["Value"]);
                }
            }
            catch (Exception exception)
            {
                Log(typeof(GlobalParameters)).Error(
                    string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public static  void CreateWmsGlobalConnection(string wmsConnection)
        {
            WmsConnectionString = wmsConnection;
            WmsGlobalSqlConnection.ConnectionString = wmsConnection;
            WmsGlobalSqlConnection.StateChange += WmsGlobalSqlConnectionStateChange;
        }

        public static void CreateOnixGlobalConnection(string onixConnection)
        {
            OnixConnectionString = onixConnection;
            OnixGlobalSqlConnection.ConnectionString = onixConnection;
            OnixGlobalSqlConnection.StateChange += OnixGlobalSqlConnectionStateChange;
        }

        public static void CreateSymphonyGlobalConnection(string syphonyConnection)
        {
            SymphonyConnectionString = syphonyConnection;
            SymphonyGlobalSqlConnection.ConnectionString = syphonyConnection;
            SymphonyGlobalSqlConnection.StateChange += SymphonyGlobalSqlConnectionStateChange;
        }

        static void SymphonyGlobalSqlConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (SymphonyGlobalSqlConnection.State == ConnectionState.Closed)
            {
                SymphonyGlobalSqlConnection.Open();
            }
        }

        static void OnixGlobalSqlConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (OnixGlobalSqlConnection.State == ConnectionState.Closed)
            {
                OnixGlobalSqlConnection.Open();
            }
        }

        static void WmsGlobalSqlConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                WmsGlobalSqlConnection.Open();
            }
        }

        public static ILog Log (Type type)
        {
            return LogManager.GetLogger(type);   
        }
    }

    public class DbAddressAsignment
    {
        public bool Error { get; set; }
        public Exception ExceptionError { get; set; }

        public DataTable GetInfoRotation(int idProduct)
        {
            var command = new SqlCommand(string.Format(@"
                            SELECT qpmm.QuantityMax AS Qty, crp.Name
                            FROM   QtyProductMinMax qpmm
                                   INNER JOIN (
                                            SELECT qpmm.ID_Product,
                                                   MAX(qpmm.[Data]) AS DATA
                                            FROM   QtyProductMinMax qpmm
                                            GROUP BY
                                                   qpmm.ID_Product
                                        )q
                                        ON  q.ID_Product = qpmm.ID_Product
                                        AND q.[Data] = qpmm.[Data]
                                        INNER JOIN Catalog_RotationsProduct crp ON crp.ID = qpmm.ID_TypeOfRotation
                            WHERE  qpmm.ID_Product = {0}",
                                                       idProduct), GlobalParameters.WmsGlobalSqlConnection);
            if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            var adapter = new SqlDataAdapter(command);
            var dt = new DataTable("Rotation");
            adapter.Fill(dt);
            return dt;
        }

        public bool CheckAddress(int idWarehouse, int idStreet, int idRaft, int idShelf, int idShelfSpace)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"
                                IF EXISTS (
                                            SELECT * 
                                            FROM Catalog_Addresses 
                                            WHERE ID_Warehouses = {0} AND ID_Streets = {1} AND 
                                            ID_Rafts = {2} AND ID_Shelfs = {3} AND ID_ShelfSpaces = {4})

                                    SELECT CAST(1 AS BIT)
                                ELSE 
                                    SELECT CAST(0 AS BIT)
                                ", idWarehouse, idStreet, idRaft, idShelf,
                                  idShelfSpace),
                    GlobalParameters.WmsGlobalSqlConnection) {CommandTimeout = GlobalParameters.CommandTimeout};
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToBoolean(command.ExecuteScalar());
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressAsignment)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int ImportPartFromSystem(int idPartRow, int idProduct, decimal quantity, string series, int analysis, DateTime expirationDate, int idTypeOfRests)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"
                                IF NOT EXISTS (SELECT * FROM PartOfProdutcs WHERE ID_PartRow = {0} and ID_Product = {1} and ID_TypeOfRests = {6})
                                BEGIN                                
                                    INSERT INTO PartOfProdutcs (ID_PartRow,ID_Product,Quantity,Series,Analysis,ExpirationDate,ID_TypeOfRests) 
                                    VALUES ({0},{1},{2},'{3}','{4}','{5}',{6}) 
                                    SELECT @@IDENTITY
                                END
                                ELSE
                                    SELECT TOP 1 ID FROM PartOfProdutcs WHERE ID_PartRow = {0} and ID_Product = {1}
                                
                                
                                ", idPartRow, idProduct,
                                  quantity.ToString().Replace(",", "."), series, analysis,
                                  expirationDate.ToString("yyyyMMdd"), idTypeOfRests),
                    GlobalParameters.WmsGlobalSqlConnection) {CommandTimeout = GlobalParameters.CommandTimeout};
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());

                GlobalParameters.Log(typeof (DbAddressAsignment)).InfoFormat(
                    "Пользователем {0}, в систему была импортирована партия товара со следующими данными: внешний номер партии {1}, код товара {2}, в количестве {3}, серия {4}, анализ {5}, срок годности {6}",
                    ObjectsForMainApplication.LoginUserLogined, idPartRow, idProduct, quantity.ToString().Replace(",", "."), series, analysis,
                    expirationDate.ToString("yyyy-MM-dd"));

                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressAsignment)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int CreateNewAddress(int idAdressFromCatalog,int idPartOfProduct,decimal quantity)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"
                                INSERT INTO Address (ID_AdressFromCatalog,ID_PartOfProduct,Quantity,DatePlace,DateActivity) 
                                VALUES ({0},{1},{2},GETDATE(),GETDATE()) 
                                SELECT @@IDENTITY
                                ", idAdressFromCatalog, idPartOfProduct,
                                  quantity.ToString().Replace(",", ".")),
                    GlobalParameters.WmsGlobalSqlConnection) {CommandTimeout = GlobalParameters.CommandTimeout};
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = string.Format(@"
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
                                    {0},	
                                    {1},
                                    GETDATE(),	
                                    {2},
                                    1
                                  )

                                IF NOT EXISTS (
                                                SELECT *
                                                FROM   CheckedQtyAddress cqa
                                                WHERE  cqa.ID_Address = {0} AND
                                                        cqa.ID_PartOfProduct = {3}
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
                                                {0},
                                                {3},
                                                {2},
                                                GETDATE()
                                                )  

", result, idAdressFromCatalog, ObjectsForMainApplication.IdUserLogined,idPartOfProduct);
                
                command.ExecuteNonQuery();

                

                GlobalParameters.Log(typeof (DbAddressAsignment)).InfoFormat(
                    "Пользователем {0}, для партии товара {1}, был присвоен адресс из каталога {2}, помещено на адрес {3} штук, код нового адреса {4}",
                    ObjectsForMainApplication.LoginUserLogined, idPartOfProduct, idAdressFromCatalog,
                    quantity.ToString().Replace(",", "."), result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressAsignment)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void DeleteAddress(int idPartRow, string address)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"SELECT dbo.GetAddressFromCatalogByAddressF('{0}')", address),
                    GlobalParameters.WmsGlobalSqlConnection);
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                var idAddress = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = string.Format(@"
                                DELETE
                                FROM [Address]
                                WHERE ID IN (
                                SELECT a.ID 
                                FROM [Address] a
	                                INNER JOIN PartOfProdutcs pop ON pop.ID = a.ID_PartOfProduct 
                                WHERE pop.ID_PartRow = {0} AND a.ID_AdressFromCatalog = {1})",
                                                    idPartRow, idAddress);
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressAsignment)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public int CreateNewAddressInCatalog(int idWarehouses,int idStreets,int idRafts,int idShelfs,int idShelfSpaces)
        {
            try
            {
                var command = new SqlCommand(
                    string.Format(@"
                                INSERT INTO Catalog_Addresses (ID_Warehouses,ID_Streets,ID_Rafts,ID_Shelfs,ID_ShelfSpaces,ID_Unit)
                                VALUES ({0},{1},{2},{3},{4},1) 
                                SELECT @@IDENTITY
                                ", idWarehouses, idStreets, idRafts, idShelfs,
                                  idShelfSpaces),
                    GlobalParameters.WmsGlobalSqlConnection) {CommandTimeout = GlobalParameters.CommandTimeout};
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var result = Convert.ToInt32(command.ExecuteScalar());

                GlobalParameters.Log(typeof (DbAddressAsignment)).InfoFormat(
                    "Пользователем {0}, был создан новый адрес в каталоге,склад {1}, улица {2}, стеллаж {3},полка {4}, место на полке {5}, код нового адреса {6}",
                    ObjectsForMainApplication.LoginUserLogined, idWarehouses, idStreets, idRafts, idShelfs,
                    idShelfSpaces, result);

                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressAsignment)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public DataTable GetTypesOfRests()
        {
            DataTable table = new DataTable("Catalog_TypeOfRests");
            try
            {
                var command = new SqlCommand("SELECT ID, Name FROM Catalog_TypeOfRests ORDER BY ID",
                                             GlobalParameters.WmsGlobalSqlConnection)
                                  {CommandTimeout = GlobalParameters.CommandTimeout};
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                return table;
            }
            catch (Exception ee)
            {
                GlobalParameters.Log(typeof(DbAddressAsignment)).Error(ee.Message);
                NewError(ee);
                throw;
            }
        }
        internal void NewError(Exception er)
        {
            Error = true;
            ExceptionError = er;
        }

        public int CheckMinMaxProduct(int idProduct)
        {
            try
            {
                var command =
                    new SqlCommand(
                        string.Format("SELECT COUNT(*) FROM QtyProductMinMax WHERE ID_Product = {0}", idProduct),
                        GlobalParameters.WmsGlobalSqlConnection) {CommandTimeout = GlobalParameters.CommandTimeout};
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressAsignment)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public void RecaclRotationForProduct(int idProduct)
        {
            try
            {
                var command = new SqlCommand(string.Format(
                "EXEC GetRotationInTable \n"
                + "	@Art = '{0}', \n"
                + "	@DayAnaliz = '30', \n"
                + "	@MinPercentQty = '30'", idProduct), GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressAsignment)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
    }

    public enum TypeOfCatalog
    {
        Warehouse,
        Street,
        Raft,
        Shelf,
        ShelfSpace
    }

    public class FindedIdOfCatalog
    {
        public TypeOfCatalog Catalog { get; set; }
        public int Id { get; set; }
    }

    public class DbAddressCreate
    {

        public int GetIdByAddress(string address)
        {
            try
            {
                var command = new SqlCommand(string.Format(@"SELECT dbo.GetAddressFromCatalogByAddressF('{0}')", address),
                                         GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof (DbAddressCreate)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public DataTable GetUncreatedItemsOfAddress(string address)
        {
            try
            {
                var result = new DataTable("FindedItems");

                var command = new SqlCommand(string.Format(@"SELECT * FROM FindUncreatedAddressItems('{0}')", address),
                                             GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressCreate)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }

        public List<FindedIdOfCatalog> FindedResult(int idAddress)
        {
            try
            {
                var result = new List<FindedIdOfCatalog>();
                var dt = new DataTable("Address");
                var command = new SqlCommand(string.Format(@"
                            SELECT ca.ID_Warehouses, ca.ID_Streets,ca.ID_Rafts,ca.ID_Shelfs,ca.ID_ShelfSpaces 
                            FROM dbo.Catalog_Addresses ca
	                            INNER JOIN dbo.Catalog_Warehouses cw ON cw.ID = ca.ID_Warehouses
	                            INNER JOIN dbo.Catalog_Streets cs ON cs.ID = ca.ID_Streets
	                            INNER JOIN dbo.Catalog_Raft cr ON cr.ID = ca.ID_Rafts
	                            INNER JOIN dbo.Catalog_Shelfs csh ON csh.ID = ca.ID_Shelfs
	                            INNER JOIN dbo.Catalog_ShelfSpaces css ON css.ID = ca.ID_ShelfSpaces
                            WHERE ca.id = {0}
                            ", idAddress),
                                             GlobalParameters.WmsGlobalSqlConnection) { CommandTimeout = GlobalParameters.CommandTimeout };
                if (GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
                {
                    GlobalParameters.WmsGlobalSqlConnection.Open();
                }
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    result.Add(new FindedIdOfCatalog { Catalog = TypeOfCatalog.Warehouse, Id = Convert.ToInt32(row["ID_Warehouses"]) });
                    result.Add(new FindedIdOfCatalog { Catalog = TypeOfCatalog.Street, Id = Convert.ToInt32(row["ID_Streets"]) });
                    result.Add(new FindedIdOfCatalog { Catalog = TypeOfCatalog.Raft, Id = Convert.ToInt32(row["ID_Rafts"]) });
                    result.Add(new FindedIdOfCatalog { Catalog = TypeOfCatalog.Shelf, Id = Convert.ToInt32(row["ID_Shelfs"]) });
                    result.Add(new FindedIdOfCatalog { Catalog = TypeOfCatalog.ShelfSpace, Id = Convert.ToInt32(row["ID_ShelfSpaces"]) });
                }
                return result;
            }
            catch (Exception exception)
            {
                GlobalParameters.Log(typeof(DbAddressCreate)).Error(string.Format("Source: [{0}], Message: [{1}]", exception.Source, exception.Message), exception);
                throw;
            }
        }
    }
}
