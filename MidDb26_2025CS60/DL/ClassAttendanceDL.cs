using System;
using System.Data;
using MySql.Data.MySqlClient;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class ClassAttendanceDL
    {
        public DataTable GetAll()
        {
            string query = "SELECT Id, AttendanceDate FROM classattendance ORDER BY AttendanceDate DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // add session and return the new id so we can use it for student attendance
        public int Add(DateTime date)
        {
            string query = $"INSERT INTO classattendance (AttendanceDate) VALUES ('{date:yyyy-MM-dd HH:mm:ss}')";
            MySqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT LAST_INSERT_ID()";
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally { conn.Close(); }
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM classattendance WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }
        
        public int GetSessionByDate(DateTime date)
        {
            string query = $"SELECT Id FROM classattendance WHERE DATE(AttendanceDate)='{date:yyyy-MM-dd}' LIMIT 1";
            MySqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return (result == null || result == DBNull.Value) ? -1 : Convert.ToInt32(result);
            }
            finally { conn.Close(); }
        }
    }
}