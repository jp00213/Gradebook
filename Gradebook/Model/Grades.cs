using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.Model
{
    public class Grades
    {
        /// <summary>
        /// The Person model class
        /// </summary>
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public int AssignmentID { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Score { get; set; }
        public string WeightGrade { get; set; }
    }
}
