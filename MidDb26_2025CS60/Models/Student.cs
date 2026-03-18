using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string RegistrationNumber { get; set; }
        public int Status { get; set; }
    }
}
