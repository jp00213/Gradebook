using Gradebook.DAL;
using System;

namespace Gradebook.Controller
{
    /// <summary>
    /// The account controller 
    /// </summary>
    public class AccountController
    {
        private readonly AccountDAL _accountDAL;

        /// <summary>
        /// Create a AccountController object.
        /// </summary>
        public AccountController()
        {
            this._accountDAL = new AccountDAL();
        }

        /// <summary>
        /// Verifies if username and password are correct for administrator
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Boolean IsPasswordCorrectAdministrator(string user, string pass)
        {
            return this._accountDAL.IsPasswordCorrectAdministrator(user, pass);
        }

        /// <summary>
        /// Verifies if username and password are correct for teacher
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Boolean IsPasswordCorrectTeacher(string user, string pass)
        {
            return this._accountDAL.IsPasswordCorrectTeacher(user, pass);
        }

        /// <summary>
        /// Verifies if username and password are correct for student
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Boolean IsPasswordCorrectStudent(string user, string pass)
        {
            return this._accountDAL.IsPasswordCorrectStudent(user, pass);
        }
    }
}
