using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class RubricBL
    {
        RubricDL dl = new RubricDL();

        public DataTable GetAll() => dl.GetAll();
        public DataTable GetForDropdown() => dl.GetForDropdown();
        public DataTable GetByClo(int cloId) => dl.GetByClo(cloId);

        public string Add(int id, string details, int cloId)
        {
            if (id <= 0) return "Rubric ID must be a positive number.";
            if (string.IsNullOrWhiteSpace(details)) return "Rubric details are required.";
            if (cloId <= 0) return "Please select a CLO.";

            bool ok = dl.Add(id, details.Trim(), cloId);
            return ok ? "success" : "Failed to add rubric. ID may already exist.";
        }

        public string Update(int id, string details, int cloId)
        {
            if (string.IsNullOrWhiteSpace(details)) return "Rubric details are required.";
            bool ok = dl.Update(id, details.Trim(), cloId);
            return ok ? "success" : "Failed to update rubric.";
        }

        public string Delete(int id)
        {
            bool ok = dl.Delete(id);
            return ok ? "success" : "Cannot delete. Rubric may be used in assessments.";
        }
    }
}