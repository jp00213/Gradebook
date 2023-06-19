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
        /// Checks for any username and password match (hashed) for administrators
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool IsPasswordCorrectAdministrator(string user, string pass)

        {
            Boolean result = false;

            string selectStatement =
                "SELECT Count(*) " +
                "FROM Account, Administrator " +
                "WHERE Account.Username = @Username AND Password = @Password " +
                "AND Account.Username = Administrator.Username";

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

        /// <summary>
        /// Checks for any username and password match (hashed) for teachers
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool IsPasswordCorrectTeacher(string user, string pass)
        {
            Boolean result = false;

            string selectStatement =
                "SELECT Count(*) " +
                "FROM Account, Teacher " +
                "WHERE Account.Username = @Username AND Password = @Password " +
                "AND Account.Username = Teacher.Username AND ActiveStatus = 1";

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

        /// <summary>
        /// Checks for any username and password match (hashed) for students
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool IsPasswordCorrectStudent(string user, string pass)
        {
            Boolean result = false;

            string selectStatement =
                "SELECT Count(*) " +
                "FROM Account, Student " +
                "WHERE Account.Username = @Username AND Password = @Password " +
                "AND Account.Username = Student.Username AND ActiveStatus = 1";

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
