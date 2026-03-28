using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
        public class ClassAttendance
        {
        // attributes
        public int Id { get; set; }
            public DateTime AttendanceDate { get; set; }
        // empty constructor for UI
        public ClassAttendance() { }
        // parameterized constructor
        public ClassAttendance(int Id, DateTime AttendanceDate)
            {
                this.Id = Id;
                this.AttendanceDate = AttendanceDate;
            }
        }
    }
