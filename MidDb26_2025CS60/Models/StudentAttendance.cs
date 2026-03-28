using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
        public class StudentAttendance
        {
        // attributes
        public int AttendanceId { get; set; }     
            public int StudentId { get; set; }         
            public int AttendanceStatus { get; set; }

        // to avoid extra database queries
        public string StudentName { get; set; }
            public string StatusName { get; set; }
            public DateTime AttendanceDate { get; set; }
        // empty constructor for UI
        public StudentAttendance() { }
        // parameterized constructor
        public StudentAttendance(int AttendanceId, int StudentId, int AttendanceStatus)
            {
                this.AttendanceId = AttendanceId;
                this.StudentId = StudentId;
                this.AttendanceStatus = AttendanceStatus;
            }
        }
    }