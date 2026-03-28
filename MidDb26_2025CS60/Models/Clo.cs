using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
    public class Clo
    {
        // attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        // empty cpnstructor for UI
        public Clo() { }
        // parameterized constructor
        public Clo(int Id, string Name, DateTime DateCreated, DateTime DateUpdated)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateUpdated = DateUpdated;
        }
    }
}

