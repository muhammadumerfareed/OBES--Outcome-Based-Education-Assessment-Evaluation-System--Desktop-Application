using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace MidDb26_2025CS60.Models
{
    public class Assessment
    {
        // attributes
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int TotalMarks { get; set; }
        public int TotalWeightage { get; set; }
        // empty constructor for UI
        public Assessment() { }
        // parameterized constructor
        public Assessment(int Id, string Title, DateTime DateCreated,
                          int TotalMarks, int TotalWeightage)
        {
            this.Id = Id;
            this.Title = Title;
            this.DateCreated = DateCreated;
            this.TotalMarks = TotalMarks;
            this.TotalWeightage = TotalWeightage;
        }
    }
}