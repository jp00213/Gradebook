using Gradebook.DAL;
using Gradebook.Model;
using System;
using System.Collections.Generic;

namespace Gradebook.Controller
{
    /// <summary>
    /// The teacher controller which interfaces with DAL
    /// </summary>
    public class TeacherController
    { 
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

        /// <summary>
        /// Updates patient in the db
        /// </summary>
        /// <param name="recordID"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="birthday"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phone"></param>
        /// <param name="sex"></param>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public bool UpdateTeacher(int recordID, string lastName, string firstName, DateTime birthday, string street, string city, string state, string zip, string phone, string sex, string ssn)
        {
            return this._personDAL.UpdatePerson(recordID, lastName, firstName, birthday, street, city, state, zip, phone, sex, ssn);
        }
        
        /// <summary>
        /// Return a list of all active teachers
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dob"></param>
        /// <returns> List of active teachers</returns>
        public List<Teacher> GetAllActiveTeachers()
        {
            return this._teacherDAL.GetAllActiveTeachers();

        }

        /// <summary>
        /// Get teacher status by ID
        /// </summary>
        /// <param name="teacherID"></param>
        /// <returns>teacher status</returns>
        public Teacher GetTeacherStatusByID(int teacherID)
        {
            return this._teacherDAL.GetTeacherStatusByID(teacherID);
        }
    }
}