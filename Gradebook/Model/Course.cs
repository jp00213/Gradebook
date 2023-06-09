﻿namespace Gradebook.Model
{
    /// <summary>
    /// Course model class
    /// </summary>
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Number { get; set; }
        public int Section { get; set; }
        public int CreditHours { get; set; }
        public string Semester { get; set; }
        public int Year { get; set; }
        public int TeacherID { get; set; }
        public int StudentID { get; set; }
        public string TeacherFullName { get; set; }
        public string StudentFullName { get; set; }
        public int StudentCount { get; set; }
    }
}
