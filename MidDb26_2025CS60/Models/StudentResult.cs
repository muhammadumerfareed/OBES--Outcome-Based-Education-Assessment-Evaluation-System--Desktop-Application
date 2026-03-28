using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
        public class StudentResult
        {
        // attributes
        public int StudentId { get; set; }
            public int AssessmentComponentId { get; set; }
            public int RubricMeasurementId { get; set; }   
            public DateTime EvaluationDate { get; set; }

        // to avoid extra database queries
        public string StudentName { get; set; }
            public string ComponentName { get; set; }
            public int ComponentTotalMarks { get; set; }
            public int ObtainedLevel { get; set; }
            public int MaxLevel { get; set; }

            
            // ObtainedMarks = (ObtainedLevel / MaxLevel) * ComponentMarks
            public double ObtainedMarks =>
                MaxLevel > 0 ? ((double)ObtainedLevel / MaxLevel) * ComponentTotalMarks : 0;
        // empty constructor for UI
        public StudentResult() { }
        // parameterized constructor
        public StudentResult(int StudentId, int AssessmentComponentId,
                                 int RubricMeasurementId, DateTime EvaluationDate)
            {
                this.StudentId = StudentId;
                this.AssessmentComponentId = AssessmentComponentId;
                this.RubricMeasurementId = RubricMeasurementId;
                this.EvaluationDate = EvaluationDate;
            }
        }
    }
