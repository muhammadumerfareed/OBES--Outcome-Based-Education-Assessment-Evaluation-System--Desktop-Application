using System;
using MySql.Data.MySqlClient;
namespace MidDb26_2025CS60.Utilities
{
    public class DatabaseHelper
    {
        
        private static string connectionString ="Server=localhost;Port=3306;Database=projectbdb26;Uid=root;Pwd=m55433001@Umer;";
       
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
