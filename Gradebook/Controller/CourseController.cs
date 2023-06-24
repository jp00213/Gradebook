using Gradebook.DAL;
using Gradebook.Model;
using System;
using System.Collections.Generic;

namespace Gradebook.Controller
{
    /// <summary>
    /// Controller for Course activities
    /// </summary>
    public class CourseController
    {
        private readonly CourseDAL _courseDAL;

        /// <summary>
        /// Constructor for CourseController
        /// </summary>
        public CourseController()
        {
            this._courseDAL = new CourseDAL();
        }

        /// <summary>
        /// Adds new course to database
        /// </summary>
        /// <param name="newCourse"></param>
        /// <returns>True if added successfully</returns>
        public Boolean AddNewCourse(Course newCourse)
        {
            return this._courseDAL.AddNewCourse(newCourse);
        }

        /// <summary>
        /// Returns list of courses by semester and year
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByYearSemester(string semester, int year)
        {
            return this._courseDAL.GetCoursesByYearSemester(semester, year);
        }

        /// <summary>
        /// Register student for a course
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public Boolean RegisterStudent(int studentId, int courseId)
        {
            return this._courseDAL.RegisterStudent(studentId, courseId);
        }

        /// <summary>
        /// Returns a list of courses by teacherID, semester and year
        /// </summary>
        /// <param name="teacherID"></param>
        /// <param name="semester"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByTeacherIDYearAndSemester(int teacherID, string semester, int year)
        {
            return this._courseDAL.GetCoursesByTeacherIDYearAndSemester(teacherID, semester, year);
        }

        public List<Course> GetCourseList()
        {
            return this._courseDAL.GetCourseList();
        }
    }
}
