using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class AssessmentComponentBL
    {
        AssessmentComponentDL dl = new AssessmentComponentDL();

        public DataTable GetByAssessment(int assessmentId) => dl.GetByAssessment(assessmentId);
        public DataTable GetForDropdown(int assessmentId) => dl.GetForDropdown(assessmentId);

        public string Add(string name, int rubricId, int totalMarks, int assessmentId)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Component name is required.";
            if (rubricId <= 0) return "Please select a rubric.";
            if (totalMarks <= 0) return "Marks must be greater than 0.";
            if (assessmentId <= 0) return "Please select an assessment first.";

            bool ok = dl.Add(name.Trim(), rubricId, totalMarks, assessmentId);
            return ok ? "success" : "Failed to add component.";
        }

        public string Update(int id, string name, int rubricId, int totalMarks)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Component name is required.";
            if (totalMarks <= 0) return "Marks must be greater than 0.";

            bool ok = dl.Update(id, name.Trim(), rubricId, totalMarks);
            return ok ? "success" : "Failed to update component.";
        }

        public string Delete(int id)
        {
            bool ok = dl.Delete(id);
            return ok ? "success" : "Cannot delete. Component may have student results.";
        }
    }
}