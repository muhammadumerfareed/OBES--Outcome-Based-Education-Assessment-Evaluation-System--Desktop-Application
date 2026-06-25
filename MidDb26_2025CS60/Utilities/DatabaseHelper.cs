using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace MidDb26_2025CS60.Utilities
{
    public class DatabaseHelper
    {

        private static string connectionString = "Server=localhost;Port=3306;Database=projectbdb26;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    
   
    public static DataTable ExecuteQuery(string query)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            finally { conn.Close(); }
        }
       
        public static object ExecuteScalar(string query)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
            finally { conn.Close(); }
        }
        public static bool ExecuteNonQuery(string query)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conn.Close(); }
        }
       
        public static bool ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                foreach (var param in parameters) { cmd.Parameters.AddWithValue(param.Key, param.Value); }

                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}

