using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
    public class Student
    {
        

        // attributes
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string RegistrationNumber { get; set; }
        public int Status { get; set; } // 5=Active, 6=Inactive
        public string StatusName { get; set; } // to show thw status name without extra query
        public string FullName => FirstName + " " + LastName; // to concanoate the name

        // empty constructor for UI
        public Student() { }

        // Constructor
        public Student(int Id, string FirstName, string LastName,
                       string Contact, string Email,
                       string RegistrationNumber, int Status)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Contact = Contact;
            this.Email = Email;
            this.RegistrationNumber = RegistrationNumber;
            this.Status = Status;
        }
    }
}
