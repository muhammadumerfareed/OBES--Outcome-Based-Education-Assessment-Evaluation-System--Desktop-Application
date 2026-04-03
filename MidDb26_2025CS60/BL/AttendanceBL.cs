using System;
using System.Data;
using MidDb26_2025CS60.DL;

namespace MidDb26_2025CS60.BL
{
    public class AttendanceBL
    {
        ClassAttendanceDL sessionDL = new ClassAttendanceDL();
        StudentAttendanceDL attDL = new StudentAttendanceDL();

        public DataTable GetAllSessions() => sessionDL.GetAll();
        public DataTable GetBySession(int sessionId) => attDL.GetBySession(sessionId);
        public DataTable GetByStudent(int studentId) => attDL.GetByStudent(studentId);

        
        public string SaveAttendance(DateTime date, DataTable studentsWithStatus)
        {
            if (studentsWithStatus == null || studentsWithStatus.Rows.Count == 0)
                return "No students found to mark attendance.";

            int sessionId = sessionDL.Add(date);
            if (sessionId <= 0) return "Failed to create attendance session.";

            foreach (DataRow row in studentsWithStatus.Rows)
            {
                int studentId = Convert.ToInt32(row["Id"]);
                int status = Convert.ToInt32(row["AttendanceStatus"]);
                attDL.Mark(sessionId, studentId, status);
            }

            return "success";
        }

        public string DeleteSession(int id)
        {
            bool ok = sessionDL.Delete(id);
            return ok ? "success" : "Failed to delete session.";
        }
        
        public int GetSessionByDate(DateTime date)
        {
            int sessionId = sessionDL.GetSessionByDate(date);
            return sessionId;
        }
    }
}