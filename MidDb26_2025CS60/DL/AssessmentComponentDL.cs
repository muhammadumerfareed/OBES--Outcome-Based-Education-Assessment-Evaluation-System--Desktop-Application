using System;
using System.Data;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class AssessmentComponentDL
    {
        // get components for one assessment with rubric name
        public DataTable GetByAssessment(int assessmentId)
        {
            string query = $@"SELECT ac.Id, ac.Name, ac.TotalMarks, ac.RubricId, 
                              r.Details AS RubricDetails, ac.AssessmentId
                              FROM assessmentcomponent ac
                              JOIN rubric r ON ac.RubricId = r.Id
                              WHERE ac.AssessmentId={assessmentId}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool Add(string name, int rubricId, int totalMarks, int assessmentId)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $@"INSERT INTO assessmentcomponent 
                              (Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId)
                              VALUES ('{name}', {rubricId}, {totalMarks}, '{now}', '{now}', {assessmentId})";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Update(int id, string name, int rubricId, int totalMarks)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $@"UPDATE assessmentcomponent SET Name='{name}', 
                              RubricId={rubricId}, TotalMarks={totalMarks}, DateUpdated='{now}'
                              WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM assessmentcomponent WHERE Id={id}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        // for dropdown in evaluation form
        public DataTable GetForDropdown(int assessmentId)
        {
            string query = $"SELECT Id, Name FROM assessmentcomponent WHERE AssessmentId={assessmentId}";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}