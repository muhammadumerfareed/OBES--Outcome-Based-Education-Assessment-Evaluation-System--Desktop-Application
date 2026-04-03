using System;
using System.Data;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class AssessmentDL
    {
        public DataTable GetAll()
        {
            string query = "SELECT Id, Title, TotalMarks, TotalWeightage, DateCreated FROM assessment";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool Add(string title, int totalMarks, int totalWeightage)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $@"INSERT INTO assessment (Title, TotalMarks, TotalWeightage, DateCreated) 
                              VALUES ('{title}', {totalMarks}, {totalWeightage}, '{now}')";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Update(int id, string title, int totalMarks, int totalWeightage)
        {
            string query = $@"UPDATE assessment SET Title='{title}', 
                              TotalMarks={totalMarks}, TotalWeightage={totalWeightage} 
                              WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM assessment WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public DataTable GetForDropdown()
        {
            string query = "SELECT Id, Title FROM assessment";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
