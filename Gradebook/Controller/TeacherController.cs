﻿using Gradebook.DAL;
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
        private static CurrentUser _currentUser;

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
        /// Updates teacher in the db
        /// </summary>
        /// <param name="oldTeacher"></param>
        /// <param name="newTeacher"></param>
        /// <returns></returns>
        public bool UpdateTeacher(Teacher oldTeacher, Teacher newTeacher)
        {
            return this._personDAL.UpdateTeacher(oldTeacher, newTeacher);
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

        /// <summary>
        /// Gets the current user's username
        /// </summary>
        /// <returns></returns>
        public static string GetUsername()
        {
            return _currentUser.userName;
        }

        /// <summary>
        /// Sets the current user's username
        /// </summary>
        /// <param name="username"></param>
        public static void SetUsername(string username)
        {
            _currentUser = new CurrentUser(); 
            _currentUser.userName = username;
        }

        /// <summary>
        /// Gets teacher by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Teacher GetTeacherByUsername(string username)
        {
            return this._teacherDAL.GetTeacherByUsername(username);
        }

        /// <summary>
        /// Get all teachers
        /// </summary>
        /// <returns></returns>
        public List<Teacher> GetAllTeachers()
        {
            return this._teacherDAL.GetAllTeachers();
        }

        /// <summary>
        /// Get the last created username for a teacher
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <exception cref="NotImplementedException"></exception>
        public string GetTheLastCreatedUsernameForTeacher(string firstNameIn, string lastNameIn)
        {
            return this._personDAL.GetTheLastCreatedUsernameByFirstAndLastName(firstNameIn, lastNameIn);
        }
    }
}