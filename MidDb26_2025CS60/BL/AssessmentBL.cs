using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class AssessmentBL
    {
        AssessmentDL dl = new AssessmentDL();

        public DataTable GetAll() => dl.GetAll();
        public DataTable GetForDropdown() => dl.GetForDropdown();

        public string Add(string title, int totalMarks, int totalWeightage)
        {
            if (string.IsNullOrWhiteSpace(title)) return "Title is required.";
            if (totalMarks <= 0) return "Total marks must be greater than 0.";
            if (totalWeightage <= 0) return "Weightage must be greater than 0.";

            bool ok = dl.Add(title.Trim(), totalMarks, totalWeightage);
            return ok ? "success" : "Failed to add assessment.";
        }

        public string Update(int id, string title, int totalMarks, int totalWeightage)
        {
            if (string.IsNullOrWhiteSpace(title)) return "Title is required.";
            if (totalMarks <= 0) return "Total marks must be greater than 0.";

            bool ok = dl.Update(id, title.Trim(), totalMarks, totalWeightage);
            return ok ? "success" : "Failed to update assessment.";
        }

        public string Delete(int id)
        {
            bool ok = dl.Delete(id);
            return ok ? "success" : "Cannot delete. Assessment may have components linked to it.";
        }
    }
}
