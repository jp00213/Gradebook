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
        /// Verifies if username and password are correct
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Boolean IsPasswordCorrect(string user, string pass)
        {
            return this._accountDAL.IsPasswordCorrect(user, pass);
        }
    }
}
