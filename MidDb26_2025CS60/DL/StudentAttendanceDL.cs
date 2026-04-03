using System.Data;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class StudentAttendanceDL
    {
        // get attendance sheet for one session with student names and status
        public DataTable GetBySession(int attendanceId)
        {
            string query = $@"SELECT sa.StudentId, CONCAT(s.FirstName,' ',s.LastName) AS StudentName,
                              sa.AttendanceStatus, l.Name AS StatusName, ca.AttendanceDate
                              FROM studentattendance sa
                              JOIN student s ON sa.StudentId = s.Id
                              JOIN lookup l ON sa.AttendanceStatus = l.LookupId
                              JOIN classattendance ca ON sa.AttendanceId = ca.Id
                              WHERE sa.AttendanceId={attendanceId}";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // get all attendance records for one student
        public DataTable GetByStudent(int studentId)
        {
            string query = $@"SELECT ca.AttendanceDate, l.Name AS Status
                              FROM studentattendance sa
                              JOIN classattendance ca ON sa.AttendanceId = ca.Id
                              JOIN lookup l ON sa.AttendanceStatus = l.LookupId
                              WHERE sa.StudentId={studentId}
                              ORDER BY ca.AttendanceDate DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // insert or update attendance (handles duplicate case)
        public bool Mark(int attendanceId, int studentId, int status)
        {
            string query = $@"INSERT INTO studentattendance (AttendanceId, StudentId, AttendanceStatus)
                              VALUES ({attendanceId}, {studentId}, {status})
                              ON DUPLICATE KEY UPDATE AttendanceStatus={status}";
            return DatabaseHelper.ExecuteNonQuery(query);
        }
    }
}