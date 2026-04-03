using System.Data;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class RubricDL
    {
        // get all rubrics with clo name
        public DataTable GetAll()
        {
            string query = @"SELECT r.Id, r.Details, r.CloId, c.Name AS CloName 
                             FROM rubric r JOIN clo c ON r.CloId = c.Id";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool Add(int id, string details, int cloId)
        {
            string query = $"INSERT INTO rubric (Id, Details, CloId) VALUES ({id}, '{details}', {cloId})";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Update(int id, string details, int cloId)
        {
            string query = $"UPDATE rubric SET Details='{details}', CloId={cloId} WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM rubric WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        // dropdown for assessment component form
        public DataTable GetForDropdown()
        {
            string query = "SELECT Id, Details FROM rubric";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // get rubrics filtered by clo
        public DataTable GetByClo(int cloId)
        {
            string query = $"SELECT Id, Details FROM rubric WHERE CloId={cloId}";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
