using System.Data.SqlClient;

namespace Gradebook.DAL
{
    public class GradebookDBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                /*"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\SchoolDatabase.mdf;" +
                "Integrated Security=True";*/
                "Data Source=localhost; Initial Catalog= SchoolDatabase;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
