using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class StudentResultBL
    {
        StudentResultDL dl = new StudentResultDL();

        public DataTable GetByStudentAndAssessment(int studentId, int assessmentId)
        {
            return dl.GetByStudentAndAssessment(studentId, assessmentId);
        }

        public DataTable GetByAssessment(int assessmentId)
        {
            return dl.GetByAssessment(assessmentId);
        }

        public DataTable GetByClo(int cloId)
        {
            return dl.GetByClo(cloId);
        }

        public string Save(int studentId, int componentId, int rubricLevelId)
        {
            if (studentId <= 0) return "Please select a student.";
            if (componentId <= 0) return "Please select a component.";
            if (rubricLevelId <= 0) return "Please select a rubric level.";

            bool ok = dl.Save(studentId, componentId, rubricLevelId);
            return ok ? "success" : "Failed to save evaluation.";
        }

        
        public double CalculateMarks(int obtainedLevel, int maxLevel, int componentMarks)
        {
            if (maxLevel == 0) return 0;
            return System.Math.Round((double)obtainedLevel / maxLevel * componentMarks, 2);
        }
    }
}