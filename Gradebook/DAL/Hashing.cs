using System;
using System.Text;

namespace Gradebook.DAL
{
    /// <summary>
    /// Manages hashing passwords
    /// </summary>
    static class Hashing
    {
        /// <summary>
        /// Hashes a given password using SHA512, returns hashed password as a string
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string HashPassword(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }
    }
}
