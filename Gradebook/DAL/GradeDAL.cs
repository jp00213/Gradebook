using Gradebook.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Gradebook.DAL
{
    public class GradeDAL
    {
        /// <summary>
        /// Returns list of grade objects (with student name, id, and score) based 
        /// on courseID and assignmentID
        /// </summary>
        /// <param name="courseID"></param>
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public List<Grades> GetAssignmentGrades(int courseID, int assignmentID)
        {
            List<Grades> gradeList = new List<Grades>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT s.studentID, firstName, lastName, g.score " +
                "FROM person p, student s, studentsincourse sc, grades g, assignment a " +
                "WHERE sc.courseID = @courseID AND a.assignmentID = @assignmentID " +
                "AND p.recordID = s.recordID AND s.studentID = sc.studentID " +
                "AND sc.studentID = g.studentID " +
                "AND g.assignmentID = a.assignmentID ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@courseID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@courseID"].Value = courseID;

            selectCommand.Parameters.Add("@assignmentID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@assignmentID"].Value = assignmentID;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Grades addGrade = new Grades
                        {
                            StudentID = (int)(reader)["studentID"],
                            Score = (string)(reader)["score"],
                            StudentName = (string)(reader)["firstName"] + " " + (string)(reader)["lastName"]
                        };
                        gradeList.Add(addGrade);
                    }
                }
            }
            return gradeList;
        }

        /// <summary>
        /// Updates a grade for a student in an assignment
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        public bool UpdateOneGrade(int assignmentID, int studentID, int score, int oldScore)
        {
            SqlConnection connection = GradebookDBConnection.GetConnection();
            string insertStatement =
                "UPDATE grades " +
                "SET score = @score " +
                "WHERE assignmentID = @assignmentID AND studentID = @studentID " +
                "AND score = @oldScore";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@assignmentID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@assignmentID"].Value = assignmentID;

            insertCommand.Parameters.Add("@studentID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@studentID"].Value = studentID;

            insertCommand.Parameters.Add("@score", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@score"].Value = score;

            insertCommand.Parameters.Add("@oldScore", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@oldScore"].Value = oldScore;

            using (insertCommand)
            {
                connection.Open();
                int rowsAffected = insertCommand.ExecuteNonQuery();
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
