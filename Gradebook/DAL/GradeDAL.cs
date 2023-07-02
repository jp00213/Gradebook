using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Gradebook.DAL
{
    /// <summary>
    /// Communicates with the grade controller 
    /// </summary>
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
                "SELECT s.studentID, firstName, lastName, g.score, a.weight, a.description " +
                "FROM person p, student s, studentsincourse sc, grades g, assignment a " +
                "WHERE sc.courseID = @courseID AND a.assignmentID = @assignmentID " +
                "AND p.recordID = s.recordID AND s.studentID = sc.studentID " +
                "AND sc.studentID = g.studentID " +
                "AND g.assignmentID = a.assignmentID ";
               // "SELECT sc.courseID, a.weight, a.description, g.score, s.studentID, p.firstName, p.lastName FROM studentsInCourse sc " +
               // "JOIN Assignment a ON sc.courseID = a.courseID " +
               // "JOIN Grades g ON a.assignmentID = g.assignmentID " +
               // "JOIN Student s ON sc.studentID = s.studentID " +
               // "JOIN Person p on s.recordID = p.recordID " +
               // "WHERE sc.courseID = @courseID " +
               // "AND g.assignmentID = @assignmentID ";

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
                            CourseID = courseID,
                            Weight = (reader)["weight"].ToString(),
                            Description = (string)(reader)["description"],
                            Score = (reader)["score"].ToString(),
                            StudentID = (int)(reader)["studentID"],
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

        /// <summary>
        /// Adds a grade to the DB
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <param name="studentID"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public Boolean AddGrade(int assignmentID, int studentID, int score)
        {
            Boolean result = false;

            string insertStatement = "INSERT INTO grades " +
                "(assignmentID, studentID, score) " +
                "VALUES (@assignmentID, @studentID, @score)";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    
                    insertCommand.Parameters.Add("@assignmentID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@assignmentID"].Value = assignmentID;

                    insertCommand.Parameters.Add("@studentID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@studentID"].Value = studentID;

                    insertCommand.Parameters.Add("@score", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@score"].Value = score;
                                        
                    int record = insertCommand.ExecuteNonQuery();
                    result = record > 0;
                }
            }

            return result;
        }

        /// <summary>
        /// Gets all grades
        /// </summary>
        /// <returns></returns>
        public List<Grades> GetAllGrades()
        {
            List<Grades> grades = new List<Grades>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM grades ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Grades addGrades = new Grades
                        {
                            AssignmentID = (int)(reader)["assignmentID"],
                            StudentID = (int)(reader)["studentID"],
                            Score = (reader)["score"] as string,

                        };
                        grades.Add(addGrades);
                    }
                }
            }
            return grades;
        }
    }
}
