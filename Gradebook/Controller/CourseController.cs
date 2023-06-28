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


        public Course GetCourseByName(string name) 
        {
            return this._courseDAL.GetCourseByName(name);
        }

        /// <summary>
        /// Get student course detail by term, year and student ID.
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns></returns>
        public List<Course> GetStudentCourseDetailsByTermAndYearAndStudentID(Course searchItems)
        {
            return this._courseDAL.GetStudentCourseDetailsByTermAndYearAndStudentID(searchItems);


        }

        /// <summary>
        /// Get courses by many combinations of parameters
        /// </summary>
        /// <param name="testCourse"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByMultipleParameters(Course testCourse)
        {
            return this._courseDAL.GetCoursesByMultipleParameters(testCourse);
        }

        /// <summary>
        /// Get student course grade details by studentID & courseID
        /// </summary>
        /// <param name="gradesSearch"></param>
        /// <returns></returns>
        public List<Grades> GetStudentCourseGradeDetailsByStudentIDAndCourseID(Grades gradesSearch)
        {
            return this._courseDAL.GetStudentCourseGradeDetailsByStudentIDAndCourseID(gradesSearch);
        }

        /// <summary>
        /// Delete course
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public bool DeleteCourse(int courseID)
        {
            return this._courseDAL.DeleteCourse(courseID);
        }

        /// <summary>
        /// Get student course weight grade by studentID & courseID
        /// </summary>
        /// <param name="gradesSearch"></param>
        /// <returns></returns>
        public string GetStudentCourseWeightGradeByStudentIDAndCourseID(Grades gradesSearch)
        {
            return this._courseDAL.GetStudentCourseWeightGradeByStudentIDAndCourseID(gradesSearch);
        }

        /// <summary>
        /// Updates a course
        /// </summary>
        /// <param name="updateCourse"></param>
        /// <returns></returns>
        public bool UpdateCourse(Course updateCourse, Course oldCourse)
        {
            return this._courseDAL.UpdateCourse(updateCourse, oldCourse);
        }

        /// <summary>
        /// Gets courses registered to one student ID
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByStudentRegistration(int studentID)
        {
            return this._courseDAL.GetCoursesByStudentRegistration(studentID);
        }

        /// <summary>
        /// Get courses by teacherID & Semester & Year
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns></returns>
        public List<Course> GetCourseByTeacherIDAndSemesterAndYear(Course searchItems)
        {
            return this._courseDAL.GetCourseByTeacherIDAndSemesterAndYear(searchItems);
        }

        /// <summary>
        /// Get roster data by teacherID & Semester & Year & CourseID
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns></returns>
        public List<Course> GetRosterDataByTeacherIDAndSemesterAndYearAndCourseID(Course searchItems)
        {
            return this._courseDAL.GetRosterDataByTeacherIDAndSemesterAndYearAndCourseID(searchItems);
        }

        /// <summary>
        /// Returns a list of courses by semester, year, and studentID
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="year"></param>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByYearSemesterStudentID(string semester, int year, int studentID)
        {
            return this._courseDAL.GetCoursesByYearSemesterStudentID(semester, year, studentID);
        }

        /// <summary>
        /// Deletes registration for course and student
        /// </summary>
        /// <param name="courseID"></param>
        /// <param name="studentid"></param>
        public bool DeleteRegistration(int courseID, int studentid)
        {
            return this._courseDAL.DeleteRegistration(courseID, studentid);
        }
    }
}
