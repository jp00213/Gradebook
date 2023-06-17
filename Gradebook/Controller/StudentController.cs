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
        private readonly StudentDAL _studentDAL;

        /// <summary>
        /// Create a StudentController object.
        /// </summary>
        public StudentController()
        {
            _personDAL = new PersonDAL();
            _studentDAL = new StudentDAL();
        }

        public Boolean AddPersonAsStudent(Person person)
        {
            return this._personDAL.AddPersonAsStudent(person);

        }



        // method for usercontrol FindLastUserName,   this is a temp function, not use in production later
        public string GetTheLastCreatedUsernameInformation(string firstNameIn, string lastNameIn)
        {
            return this._personDAL.GetTheLastCreatedUsernameInformationFullName(firstNameIn, lastNameIn);
        }


        public Boolean UpdateStudentPassword(string username, string password)
        {
            string hashedPassword = Hashing.HashPassword(password);
            return _studentDAL.UpdateStudentPassword(username, hashedPassword);
        }


        public Person GetStudentByID(int studentID)
        {
            return _studentDAL.GetStudentByID(studentID);

        }


        public List<Person> GetStudentByParameters(SearchItem searchItemIn)
        {
            return _studentDAL.GetStudentByParameters(searchItemIn);
        }



    }
}