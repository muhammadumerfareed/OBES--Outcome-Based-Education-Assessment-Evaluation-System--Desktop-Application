using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class CloBL
    {
        CloDL dl = new CloDL();

        public DataTable GetAll() => dl.GetAll();
        public DataTable GetForDropdown() => dl.GetForDropdown();

        public string Add(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "CLO name is required.";
            bool ok = dl.Add(name.Trim());
            return ok ? "success" : "Failed to add CLO.";
        }

        public string Update(int id, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "CLO name is required.";
            bool ok = dl.Update(id, name.Trim());
            return ok ? "success" : "Failed to update CLO.";
        }

        public string Delete(int id)
        {
            bool ok = dl.Delete(id);
            return ok ? "success" : "Cannot delete. CLO may be linked to rubrics.";
        }
    }
}