using System.Data;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class StudentResultDL
    {
        // save evaluation , insert or update if already exists
        public bool Save(int studentId, int componentId, int rubricLevelId)
        {
            string now = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $@"INSERT INTO studentresult (StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate)
                              VALUES ({studentId}, {componentId}, {rubricLevelId}, '{now}')
                              ON DUPLICATE KEY UPDATE RubricMeasurementId={rubricLevelId}, EvaluationDate='{now}'";
            return DatabaseHelper.ExecuteNonQuery(query);
        }

        // get results for one student in one assessment with marks calculation
        public DataTable GetByStudentAndAssessment(int studentId, int assessmentId)
        {
            string query = $@"SELECT 
                              CONCAT(s.FirstName,' ',s.LastName) AS StudentName,
                              ac.Name AS Component,
                              ac.TotalMarks AS ComponentMarks,
                              rl.MeasurementLevel AS ObtainedLevel,
                              (SELECT MAX(MeasurementLevel) FROM rubriclevel WHERE RubricId=ac.RubricId) AS MaxLevel,
                              ROUND((rl.MeasurementLevel * 1.0 / 
                                (SELECT MAX(MeasurementLevel) FROM rubriclevel WHERE RubricId=ac.RubricId)) 
                                * ac.TotalMarks, 2) AS ObtainedMarks
                              FROM studentresult sr
                              JOIN student s ON sr.StudentId = s.Id
                              JOIN assessmentcomponent ac ON sr.AssessmentComponentId = ac.Id
                              JOIN rubriclevel rl ON sr.RubricMeasurementId = rl.Id
                              WHERE sr.StudentId={studentId} AND ac.AssessmentId={assessmentId}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // whole class results for one assessment — used in reports
        public DataTable GetByAssessment(int assessmentId)
        {
            string query = $@"SELECT 
                              s.RegistrationNumber,
                              CONCAT(s.FirstName,' ',s.LastName) AS StudentName,
                              ac.Name AS Component,
                              ac.TotalMarks AS ComponentMarks,
                              rl.MeasurementLevel AS ObtainedLevel,
                              (SELECT MAX(MeasurementLevel) FROM rubriclevel WHERE RubricId=ac.RubricId) AS MaxLevel,
                              ROUND((rl.MeasurementLevel * 1.0 / 
                                (SELECT MAX(MeasurementLevel) FROM rubriclevel WHERE RubricId=ac.RubricId)) 
                                * ac.TotalMarks, 2) AS ObtainedMarks
                              FROM studentresult sr
                              JOIN student s ON sr.StudentId = s.Id
                              JOIN assessmentcomponent ac ON sr.AssessmentComponentId = ac.Id
                              JOIN rubriclevel rl ON sr.RubricMeasurementId = rl.Id
                              WHERE ac.AssessmentId={assessmentId}
                              ORDER BY s.RegistrationNumber, ac.Name";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // clo wise result for CLO report
        public DataTable GetByClo(int cloId)
        {
            string query = $@"SELECT 
                              c.Name AS CLO,
                              CONCAT(s.FirstName,' ',s.LastName) AS StudentName,
                              s.RegistrationNumber,
                              ac.Name AS Component,
                              ROUND((rl.MeasurementLevel * 1.0 / 
                                (SELECT MAX(MeasurementLevel) FROM rubriclevel WHERE RubricId=ac.RubricId)) 
                                * ac.TotalMarks, 2) AS ObtainedMarks,
                              ac.TotalMarks AS ComponentMarks
                              FROM studentresult sr
                              JOIN assessmentcomponent ac ON sr.AssessmentComponentId = ac.Id
                              JOIN rubric r ON ac.RubricId = r.Id
                              JOIN clo c ON r.CloId = c.Id
                              JOIN student s ON sr.StudentId = s.Id
                              JOIN rubriclevel rl ON sr.RubricMeasurementId = rl.Id
                              WHERE c.Id={cloId}
                              ORDER BY s.RegistrationNumber";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
