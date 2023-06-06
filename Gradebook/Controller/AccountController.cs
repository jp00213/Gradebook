using Gradebook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.Controller
{
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

        public Boolean IsPasswordCorrect(string user, string pass)
        {
            return this._accountDAL.IsPasswordCorrect(user, pass);
        }
    }
}
