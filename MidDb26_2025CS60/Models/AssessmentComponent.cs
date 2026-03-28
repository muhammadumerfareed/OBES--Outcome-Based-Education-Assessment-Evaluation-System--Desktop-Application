using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
        public class AssessmentComponent
        {
        // Attributes
        public int Id { get; set; }
            public string Name { get; set; }
            public int RubricId { get; set; }         
            public int TotalMarks { get; set; }
            public DateTime DateCreated { get; set; }
            public DateTime DateUpdated { get; set; }
            public int AssessmentId { get; set; }      // Kefrence to Assessment

        // to VOID EXTRA QUERIES IN UI
        public string RubricDetails { get; set; }
            public string AssessmentTitle { get; set; }
        // Empty constructor for UI
        public AssessmentComponent() { }
        // Parameterized constructor
        public AssessmentComponent(int Id, string Name, int RubricId,
                                       int TotalMarks, DateTime DateCreated,
                                       DateTime DateUpdated, int AssessmentId)
            {
                this.Id = Id;
                this.Name = Name;
                this.RubricId = RubricId;
                this.   TotalMarks = TotalMarks;
                this.DateCreated = DateCreated;
                this.DateUpdated = DateUpdated;
                this.AssessmentId = AssessmentId;
            }
        }
    }
