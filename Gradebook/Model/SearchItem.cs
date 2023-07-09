using System;

namespace Gradebook.Model
{
    /// <summary>
    /// Helper method that assists in student search
    /// </summary>
    public class SearchItem
    {
        public int idNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public int StudentID { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
        public int CourseID { get; set; }

    }
}
