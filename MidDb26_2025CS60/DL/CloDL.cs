using System;
using System.Data;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class CloDL
    {
        public DataTable GetAll()
        {
            string query = "SELECT Id, Name, DateCreated, DateUpdated FROM clo";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool Add(string name)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"INSERT INTO clo (Name, DateCreated, DateUpdated) VALUES ('{name}', '{now}', '{now}')";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Update(int id, string name)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"UPDATE clo SET Name='{name}', DateUpdated='{now}' WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM clo WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        // for dropdowns in rubric form
        public DataTable GetForDropdown()
        {
            string query = "SELECT Id, Name FROM clo";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}