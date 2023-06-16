using Gradebook.DAL;
using Gradebook.Model;
using System;

namespace Gradebook.Controller
{
    /// <summary>
    /// Controller for Course activities
    /// </summary>
    public class CourseController
    {
        private CourseDAL _courseDAL;

        /// <summary>
        /// Constructor for CourseController
        /// </summary>
        public CourseController()
        {
            this._courseDAL = new CourseDAL();
        }

        public Boolean AddNewCourse(Course newCourse)
        {
            return this._courseDAL.AddNewCourse(newCourse);
        }
    }
}
