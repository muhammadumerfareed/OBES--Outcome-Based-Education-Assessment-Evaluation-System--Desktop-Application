using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class StudentBL
    {
        StudentDL dl = new StudentDL();

        public DataTable GetAll()
        {
            return dl.GetAll();
        }

        public DataTable GetForDropdown()
        {
            return dl.GetForDropdown();
        }

        public string Add(string firstName, string lastName, string contact,
                          string email, string regNumber, int status)
        {
            if (string.IsNullOrWhiteSpace(firstName)) return "First name is required.";
            if (string.IsNullOrWhiteSpace(email)) return "Email is required.";
            if (string.IsNullOrWhiteSpace(regNumber)) return "Registration number is required.";

            bool ok = dl.Add(firstName.Trim(), lastName?.Trim(), contact?.Trim(),
                             email.Trim(), regNumber.Trim(), status);
            return ok ? "success" : "Failed to add student. Please try again.";
        }

        public string Update(int id, string firstName, string lastName, string contact,
                             string email, string regNumber, int status)
        {
            if (string.IsNullOrWhiteSpace(firstName)) return "First name is required.";
            if (string.IsNullOrWhiteSpace(email)) return "Email is required.";

            bool ok = dl.Update(id, firstName.Trim(), lastName?.Trim(), contact?.Trim(),
                                email.Trim(), regNumber.Trim(), status);
            return ok ? "success" : "Failed to update student.";
        }

        public string Delete(int id)
        {
            bool ok = dl.Delete(id);
            return ok ? "success" : "Failed to delete. Student may have related records.";
        }
    }
}
