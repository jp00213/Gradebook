using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        /// <summary>
        /// Returns a list of assignments based on course ID
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public List<Assignment> GetAssignmentsByCourseID(int courseID)
        {
            List<Assignment> assignments = new List<Assignment>();
            Assignment addAssignment = new Assignment();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM assignment " +
                "WHERE courseID = @courseID ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@courseID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@courseID"].Value = courseID;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addAssignment = new Assignment
                        {
                            AssignmentID = (int)(reader)["assignmentID"],
                            CourseID = (int)(reader)["courseID"],
                            Description = (string)(reader)["description"],
                            Weight = (Decimal)(reader)["weight"],
                        };
                        assignments.Add(addAssignment);
                    }
                }
            }
            return assignments;
        }

        /// <summary>
        /// Returns an assigment based on the description
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public Assignment GetAssignmentByDescription(string description)
        {
            Assignment assignment = new Assignment();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM assignment " +
                "WHERE description = @description ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@description"].Value = description;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        assignment = new Assignment
                        {
                            AssignmentID = (int)(reader)["assignmentID"],
                            CourseID = (int)(reader)["courseID"],
                            Description = (string)(reader)["description"],
                            Weight = (Decimal)(reader)["weight"],
                        };
                    }
                }
            }
            return assignment;
        }

        /// <summary>
        /// Returns t/f based on if the update of that assignment info was successful
        /// </summary>
        /// <param name="assignment"></param>
        /// <returns></returns>
        public bool UpdateAssignment(Assignment assignment)
        {
            SqlConnection connection = GradebookDBConnection.GetConnection();
            string updateStatement =
                "UPDATE assignment " +
                "SET description = @description, weight = @weight " +
                "WHERE assignmentID = @assignmentID " +
                "AND courseID = @courseID ";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@assignmentID", System.Data.SqlDbType.Int);
            updateCommand.Parameters["@assignmentID"].Value = assignment.AssignmentID;

            updateCommand.Parameters.Add("@courseID", System.Data.SqlDbType.Int);
            updateCommand.Parameters["@courseID"].Value = assignment.CourseID;

            updateCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
            updateCommand.Parameters["@description"].Value = assignment.Description;

            updateCommand.Parameters.Add("@weight", System.Data.SqlDbType.Decimal);
            updateCommand.Parameters["@weight"].Value = assignment.Weight;

            using (updateCommand)
            {
                connection.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
