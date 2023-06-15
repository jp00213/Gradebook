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

        /// <summary>
        /// Creates a teacherController object
        /// </summary>
        public TeacherController()
        {
            _personDAL = new PersonDAL();
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
    }
}
