using Gradebook.DAL;
using Gradebook.Model;
using System;
using System.Collections.Generic;

namespace Gradebook.Controller
{
    /// <summary>
    /// The student controller which interfaces with DAL
    /// </summary>
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

        /// <summary>
        /// Add person as student
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Boolean AddPersonAsStudent(Person person)
        {
            return this._personDAL.AddPersonAsStudent(person);
        }

        /// <summary>
        /// Get the last created username. Method for usercontrol FindLastUserName. This is a temp function.
        /// </summary>
        /// <param name="firstNameIn"></param>
        /// <param name="lastNameIn"></param>
        /// <returns></returns>
        public string GetTheLastCreatedUsernameInformation(string firstNameIn, string lastNameIn)
        {
            return this._personDAL.GetTheLastCreatedUsernameInformationFullName(firstNameIn, lastNameIn);
        }

        /// <summary>
        /// Update student passoword
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Boolean UpdateStudentPassword(string username, string password)
        {
            return _studentDAL.UpdateStudentPassword(username, password);
        }

        /// <summary>
        /// Update student information
        /// </summary>
        /// <param name="personNew"></param>
        /// <param name="personOld"></param>
        /// <returns></returns>
        public bool UpdateStudent(Person personNew, Person personOld)
        {

            return _studentDAL.UpdateStudent(personNew, personOld);
        }

        /// <summary>
        /// Update student information
        /// </summary>
        /// <param name="personNew"></param>
        /// <param name="personOld"></param>
        /// <returns></returns>
        public bool UpdatePersonStudent(Person personNew, Person personOld)
        {

            return _personDAL.UpdatePersonStudent(personNew, personOld);
        }

        /// <summary>
        /// Get student by ID
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public Person GetStudentByID(int studentID)
        {
            return _studentDAL.GetStudentByID(studentID);
        }

        /// <summary>
        /// Get sutdent by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Person GetStudentByUsername(string username)
        {
            return _studentDAL.GetStudentByUsername(username);

        }

        /// <summary>
        /// Get student by parameters
        /// </summary>
        /// <param name="searchItemIn"></param>
        /// <returns></returns>
        public List<Person> GetStudentByParameters(SearchItem searchItemIn)
        {
            return _studentDAL.GetStudentByParameters(searchItemIn);
        }

        /// <summary>
        /// Get student registered units total
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns></returns>
        public int GetStudentRegisteredUnitsTotal(SearchItem searchItems)
        {
            return _studentDAL.GetStudentRegisterUnitsTotal(searchItems);
        }

        /// <summary>
        /// Get student maximum allowed units
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public int GetStudentMaximumAllowedUnits(int studentID)
        {

            return _studentDAL.GetStudentMaximumAllowedUnit(studentID);

        }

        /// <summary>
        /// Returns a list of students based on course ID
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public List<Person> GetStudentsByCourseID(int courseID)
        {
            return this._studentDAL.GetStudentsByCourseID((int)courseID);
        }

        /// <summary>
        /// Returns a student based on name and course ID
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public Person GetStudentByNameAndCourseID(string firstName, string lastName, int courseID)
        {
            return this._studentDAL.GetStudentByNameAndCourseID(firstName, lastName, courseID);
        }
            
    }
}