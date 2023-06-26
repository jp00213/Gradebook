using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.DAL
{
    /// <summary>
    /// The assignment DAL
    /// </summary>
    public class AssignmentDAL
    {
        /// <summary>
        /// Adds a new assignment
        /// </summary>
        /// <param name="assignment"></param>
        /// <returns></returns>
        public bool AddNewAssignment(Assignment assignment)
        {
            Boolean success = false;

            string insertStatement = "INSERT INTO assignment " +
                "(courseID, description, weight) " +
                "VALUES (@courseID, @description, @weight)";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.Add("@courseID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@courseID"].Value = assignment.CourseID;

                    insertCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@description"].Value = assignment.Description;

                    insertCommand.Parameters.Add("@weight", System.Data.SqlDbType.Decimal);
                    insertCommand.Parameters["@weight"].Value = assignment.Weight;

                    int record = insertCommand.ExecuteNonQuery();
                    success = record > 0;
                }
            }

            return success;
        }
    }
}
