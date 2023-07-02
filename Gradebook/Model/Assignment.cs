namespace Gradebook.Model
{
    /// <summary>
    /// Assignment model class
    /// </summary>
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public int CourseID { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }

        public Assignment(int assignmentID, int courseID, string description, decimal weight)
        {
           this.AssignmentID = assignmentID;
            this.CourseID = courseID;
            this.Description = description;
            this.Weight = weight;
        }

        /// <summary>
        /// Constructor for assignment
        /// </summary>
        public Assignment() { }

        /// <summary>
        /// Alternate constructor for assignment
        /// </summary>
        /// <param name="courseID"></param>
        /// <param name="description"></param>
        /// <param name="weight"></param>
        public Assignment(int courseID, string description, decimal weight)
        {
            this.CourseID = courseID;
            this.Description = description;
            this.Weight = weight;
        }
    }

    
}
