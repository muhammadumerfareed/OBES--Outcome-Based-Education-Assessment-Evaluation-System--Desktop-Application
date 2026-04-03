using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class RubricLevelBL
    {
        RubricLevelDL dl = new RubricLevelDL();

        public DataTable GetAll() => dl.GetAll();
        public DataTable GetByRubric(int rubricId) => dl.GetByRubric(rubricId);
        public int GetMaxLevel(int rubricId) => dl.GetMaxLevel(rubricId);

        public string Add(int rubricId, string details, int level)
        {
            if (rubricId <= 0) return "Please select a rubric.";
            if (string.IsNullOrWhiteSpace(details)) return "Details are required.";
            if (level < 1 || level > 4) return "Level must be between 1 and 4.";

            bool ok = dl.Add(rubricId, details.Trim(), level);
            return ok ? "success" : "Failed to add rubric level.";
        }

        public string Update(int id, string details, int level)
        {
            if (string.IsNullOrWhiteSpace(details)) return "Details are required.";
            if (level < 1 || level > 4) return "Level must be between 1 and 4.";

            bool ok = dl.Update(id, details.Trim(), level);
            return ok ? "success" : "Failed to update rubric level.";
        }

        public string Delete(int id)
        {
            bool ok = dl.Delete(id);
            return ok ? "success" : "Cannot delete. Level may be used in student results.";
        }
    }
}
