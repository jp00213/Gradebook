using Gradebook.DAL;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.Controller
{
    public class TeacherController
    {
        /// <summary>
        /// The controller class that is the go-between for the PersonDAL and the view
        /// </summary>
        /// 
        private readonly PersonDAL _personDAL;
        private readonly TeacherDAL _teacherDAL;

        /// <summary>
        /// Creates a teacherController object
        /// </summary>
        public TeacherController()
        {
            _personDAL = new PersonDAL();
            _teacherDAL = new TeacherDAL();
        }

        /// <summary>
        /// Adds a person as a teacher.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Boolean AddPersonAsTeacher(Person person)
        {
            return this._personDAL.AddPersonAsTeacher(person);
        }

        /// <summary>
        /// Gets all the teachers that match search criteria from db
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dob"></param>
        /// <returns>a list of teachers</returns>
        public List<Teacher> GetTeacherByNameDOB(string firstName, string lastName, DateTime dob)
        {
            return this._teacherDAL.GetTeacherByNameDOB(firstName, lastName, dob);
        }

        /// <summary>
        /// Gets a teacher from the db based on ID
        /// </summary>
        /// <param name="teacherID"></param>
        /// <returns>Teacher with corresponding id</returns>
        public Teacher GetTeacherByID(int teacherID)
        {
            return this._teacherDAL.GetTeacherByID(teacherID);
        }
    }
}
