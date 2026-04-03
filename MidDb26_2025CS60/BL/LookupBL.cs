using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class LookupBL
    {
        LookupDL dl = new LookupDL();

        public DataTable GetStudentStatuses()
        {
            return dl.GetByCategory("STUDENT_STATUS");
        }

        public DataTable GetAttendanceStatuses()
        {
            return dl.GetByCategory("ATTENDANCE_STATUS");
        }
    }
}