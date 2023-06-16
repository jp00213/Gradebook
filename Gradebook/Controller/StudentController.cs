using Gradebook.DAL;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.Controller
{
    public class StudentController
    {
        /// <summary>
        /// The controller class that mediates b/w the StudentDAL and the View.
        /// </summary>
        private readonly PersonDAL _personDAL;

        /// <summary>
        /// Create a StudentController object.
        /// </summary>
        public StudentController()
        {
            _personDAL = new PersonDAL();
        }

        /// <summary>
        /// Adds a person as student.
        /// </summary>
        /// <param name="person">name of person</param>
        /// <returns></returns>
        public Boolean AddPersonAsStudent(Person person)
        {
            return this._personDAL.AddPersonAsStudent(person);

        }

        /// <summary>
        /// Gets the last created Username information
        /// </summary>
        /// <param name="firstNameIn"></param>
        /// <param name="lastNameIn"></param>
        /// <returns></returns>
        public string GetTheLastCreatedUsernameInformation(string firstNameIn, string lastNameIn)
        {
            return this._personDAL.GetTheLastCreatedUsernameInformation(firstNameIn, lastNameIn);
        }
    }
}
