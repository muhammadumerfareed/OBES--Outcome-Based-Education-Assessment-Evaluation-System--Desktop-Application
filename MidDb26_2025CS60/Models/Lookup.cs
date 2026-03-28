using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
    public class Lookup
    {
        // Attributes 
        public int LookupId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        // Default constructor 
        public Lookup() { }

        //  constructor
        public Lookup(int LookupId, string Name, string Category)
        {
            this.LookupId = LookupId;
            this.Name = Name;
            this.Category = Category;
        }
    }

}
