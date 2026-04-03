using MidDb26_2025CS60.Utilities;
using MySql.Data.MySqlClient;
using System.Data;

namespace MidDb26_2025CS60.DL
{
    public class RubricLevelDL
    {
        public DataTable GetAll()
        {
            string query = "SELECT Id, RubricId, Details, MeasurementLevel FROM rubriclevel";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // get levels for one rubric, sorted by level
        public DataTable GetByRubric(int rubricId)
        {
            string query = $@"SELECT Id, Details, MeasurementLevel 
                              FROM rubriclevel WHERE RubricId={rubricId} 
                              ORDER BY MeasurementLevel";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool Add(int rubricId, string details, int measurementLevel)
        {
            string query = $@"INSERT INTO rubriclevel (RubricId, Details, MeasurementLevel) 
                              VALUES ({rubricId}, '{details}', {measurementLevel})";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Update(int id, string details, int measurementLevel)
        {
            string query = $"UPDATE rubriclevel SET Details='{details}', MeasurementLevel={measurementLevel} WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM rubriclevel WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        // get max level number for a rubric 
        public int GetMaxLevel(int rubricId)
        {
            string query = $"SELECT MAX(MeasurementLevel) FROM rubriclevel WHERE RubricId={rubricId}";
            MySqlConnection conn = DatabaseHelper.GetConnection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return (result == DBNull.Value || result == null) ? 4 : Convert.ToInt32(result);
            }
            finally { conn.Close(); }
        }
    }
}