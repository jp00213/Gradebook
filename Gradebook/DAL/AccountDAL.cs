using System;
using System.Data.SqlClient;

namespace Gradebook.DAL
{
    /// <summary>
    /// Defines the DAL for the Account object
    /// </summary>
    public class AccountDAL
    {
        /// <summary>
        /// Checks for any username and password match (hashed)
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool IsPasswordCorrect(string user, string pass)
        {
            Boolean result = false;

            string selectStatement =
                "SELECT Count(*) " +
                "FROM Account " +
                "WHERE Username = @Username AND Password = @Password ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Username"].Value = user;
                    selectCommand.Parameters.Add("@Password", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Password"].Value = Hashing.HashPassword(pass);
                    
                    Int32 count = (Int32)selectCommand.ExecuteScalar();
                    if (count > 0) { result = true; }
                }
            }
            return result;
        }
    }
}
