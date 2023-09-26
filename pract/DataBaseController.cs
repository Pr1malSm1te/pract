using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract
{
    internal class DataBaseController
    {
        private static string Login;
        private static string Password;
        private static List<object[]> Log = new List<object[]>();
        static public string SetLogin { set => Login = value; }
        static public string SetPassword { set => Password = value; }
        public static void AddLog(string Login, DateTime dateTime, bool status)
        {
            Log.Add(new object[] { Login, dateTime, status });
        }

        public static object[][] ShowLog()
        {
            return Log.ToArray();
        }

        public static void ClearLogs()
        {
            Log.Clear();
        }
        private static SqlConnection Connect()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection($@"Data Source=plita\mysql ;Initial Catalog = pract2; Integrated Security=true;User ID={Login};Password={Password};");
                sqlConnection.Open();
                return sqlConnection;
            }
            catch
            {
                return null;
            }
        }

        public static bool CanOpen()
        {
            SqlConnection sqlConnection = Connect();
            return sqlConnection != null;

        }

        public static List<string>[] GetTable(string tableName)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM " + tableName, sqlConnection);               
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string>[] dots = new List<string>[reader.VisibleFieldCount];
                    for (int i = 0; i < dots.Length; i++)
                        dots[i] = new List<string>();
                    
                    while (reader.Read())
                    {
                        for (int i = 0; i < dots.Length; i++)
                            dots[i].Add(reader[i].ToString());                        
                    }
                    return dots;
                }
                
            }
        }

        public static int GetLastId(string tableName)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                SqlCommand command = new SqlCommand($"SELECT TOP 1 Code FROM {tableName} ORDER BY Code DESC", sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return int.Parse(reader[0].ToString());
                }   
            }
        }

        public static List<string> GetColumnsNames(string tableName)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM " + tableName, sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                    return Enumerable.Range(0, reader.VisibleFieldCount).Select(reader.GetName).ToList();          
            }
        }
        public static void InsertInGoods(string name)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                int code = GetLastId("Goods") + 1;
                string sql = $"INSERT INTO Goods VALUES ({code}, '{name}');";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateGoods(int code, string name)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                string sql = $"UPDATE Goods SET Name = '{name}' WHERE Code = {code};";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertInModels(string name, int goodCode, int price)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                int code = GetLastId("Models") + 1;
                string sql = $"INSERT INTO Models VALUES ({code}, '{name}', {goodCode}, {price});";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateModels(int code, string name, int goodCode, int price)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                string sql = $"UPDATE Models SET Name = '{name}', GoodsCode = {goodCode}, Price = {price} WHERE Code = {code};";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertInSupply(int modelCode, DateTime date, int count, int employeeCode, bool accepted)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                int code = GetLastId("Supply") + 1;
                string sql = $"INSERT INTO Supply VALUES ({code}, {modelCode}, '{date}', {count}, {employeeCode}, {(accepted ? 1 : 0)});";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateSupply(int code, int modelCode, DateTime date, int count, int employeeCode, bool accepted)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                string sql = $"UPDATE Supply SET ModelCode = {modelCode}, Date = {date}, Count = {count}, EmployeeCode = {employeeCode}, Accepted = {accepted} WHERE Code = {code};";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertInEmployees(string surname, string name, int postCode, string PA)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                int code = GetLastId("Employees") + 1;
                string sql = $"INSERT INTO Employees VALUES ({code}, '{surname}' ,'{name}', {postCode}, {PA});";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateEmployees(int code, string surname, string name, int postCode, string PA)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                string sql = $"UPDATE Employees SET Surname = '{surname}' , Name = '{name}', PostCode = {postCode}, PA = {PA} WHERE Code = {code};";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertInPosts(string name, int salary, int overchargeBonus)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                int code = GetLastId("Posts") + 1;
                string sql = $"INSERT INTO Posts VALUES ({code}, '{name}', {salary}, {overchargeBonus});";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdatePosts(int code, string name, int salary, int overchargeBonus)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                string sql = $"UPDATE Posts SET Name = '{name}', Salary = {salary}, Overcharge_Bonus = {overchargeBonus} WHERE Code = {code};";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }
        public static void DeleteFromTable(int code, string tableName)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                string sql = $"DELETE FROM {tableName} WHERE Code = {code};";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
        }

        public static List<object> GetAllCodes(string tableName)
        {
            using (SqlConnection sqlConnection = Connect())
            {
                string sql = "SELECT Code From " + tableName;
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<object> codes = new List<object>();
                    while (reader.Read())
                        codes.Add(reader.GetInt32(0));                  
                    return codes;
                }
            }
        }
    }
}
