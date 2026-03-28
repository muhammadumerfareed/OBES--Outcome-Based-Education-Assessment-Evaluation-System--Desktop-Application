using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace MidDb26_2025CS60.Models
{
    namespace YourProjectName.Models
    {
        public class RubricLevel
        {
            // attributes
            public int Id { get; set; }
            public int RubricId { get; set; }         
            public string Details { get; set; }
            public int MeasurementLevel { get; set; } // 1=Unsatisfactory, 2=Fair, 3=Good, 4=Exceptional
            // empty constructor for UI
            public RubricLevel() { }
            // parameterized constructor
            public RubricLevel(int Id, int RubricId, string Details, int MeasurementLevel)
            {
                this.Id = Id;
                this.RubricId = RubricId;
                this.Details = Details;
                this.MeasurementLevel = MeasurementLevel;
            }
        }
    }
}
