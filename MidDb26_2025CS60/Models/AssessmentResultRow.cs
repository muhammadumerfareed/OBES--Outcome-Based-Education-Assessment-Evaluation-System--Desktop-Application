using System;
using System.Collections.Generic;
using System.Text;

namespace MidDb26_2025CS60.Models
{
    public class AssessmentResultRow
    {
        public string StudentName { get; set; }
        public string RegNumber { get; set; }
        public string Component { get; set; }
        public string Rubric { get; set; }
        public int ComponentMarks { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; }
        public double ObtainedMarks { get; set; }
    }
}
