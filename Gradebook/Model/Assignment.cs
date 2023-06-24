namespace Gradebook.Model
{
    /// <summary>
    /// Assignment model class
    /// </summary>
    public class Assignment
    {
        public int assignmentID { get; set; }
        public int courseID { get; set; }
        public string description { get; set; }
        public decimal weight { get; set; }

        public Assignment(int assignmentID, int courseID, string description, decimal weight)
        {
            this.assignmentID = assignmentID;
            this.courseID = courseID;
            this.description = description;
            this.weight = weight;
        }
    }

    
}
