using System.Data.SqlClient;

namespace Gradebook.DAL
{
    /// <summary>
    /// Connection to Gradebook database
    /// </summary>
    public class GradebookDBConnection
    {
        /// <summary>
        /// Connection string for Gradebook database
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\SchoolDatabase.mdf;" +
            "Integrated Security=True";
            //"Data Source=localhost; Initial Catalog= SchoolDatabase;" +
            //"Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
