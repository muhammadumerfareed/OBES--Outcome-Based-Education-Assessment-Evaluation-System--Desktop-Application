using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
    public class Rubric
    {
        // attribuutes
        public int Id { get; set; }
        public string Details { get; set; }
        public int CloId { get; set; }          
        // for Ui 
        public string CloName { get; set; }
        // empty constructor for UI
        public Rubric() { }
        // parameterized constructor
        public Rubric(int Id, string Details, int CloId)
        {
            this.Id = Id;
            this.Details = Details;
            this.CloId = CloId;
        }
    }
}

