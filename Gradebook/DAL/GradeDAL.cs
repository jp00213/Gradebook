using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// Gets course grades summary by studentID
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns>grade list</returns>
        public List<Grades> GetCourseGradesSummaryByStudentID(SearchItem searchItems)
        {
            List<Grades> gradeList = new List<Grades>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement = "select p.firstName, p.lastName, s.studentID,  " +
                                     "c.name, c.semester, c.year, " +
                                     "c.courseID, c.section, c.credithours, c.prefix , c.number, " +
                                     "  cast( isnull((select   sum(CONVERT(DECIMAL(10,2), (isnull(score, 0) * (isnull(weight,0)/100) )))   " +
                                     "from Grades g, Assignment a " +
                                     "where g.assignmentID = a.assignmentID  " +
                                     "and g.studentID = s.studentID  " +
                                     "and a.courseID = c.courseID) , 0) AS VARCHAR(10)) as weighted_grade,  " +
                                     " dbo.ufGetGradePointByScore(isnull((select   sum(CONVERT(DECIMAL(10,2), " +
                                     "(isnull(score, 0) * (isnull(weight,0)/100) )))  " +
                                     "from Grades g, Assignment a " +
                                     "where g.assignmentID = a.assignmentID " +
                                     "and g.studentID = s.studentID " +
                                     "and a.courseID = c.courseID ) , 0)) as gradePoints " +
                                     "from person p, student s, StudentsInCourse sc, Course c " +
                                     "where p.recordID = s.recordID " +
                                     "and  s.studentID  = @studentID " +
                                     "and c.semester = @semester " +
                                     "and c.year = @year " +
                                     "and sc.studentID = s.studentID " +
                                     "and sc.courseID = c.courseID " +
                                     "order by c.year, c.semester, c.name  ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentID", searchItems.StudentID);
            selectCommand.Parameters.AddWithValue("@semester", searchItems.Semester);
            selectCommand.Parameters.AddWithValue("@year", searchItems.Year);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Grades addGrade = new Grades
                        {
                            //   StudentName = (string)(reader)["firstName"] + " " + (string)(reader)["lastName"],
                            StudentID = (int)(reader)["studentID"],
                            Description = (string)(reader)["name"],
                            Semester = (string)(reader)["semester"],
                            Year = (int)(reader)["year"],
                            CourseID = (int)(reader)["courseID"],
                            Section = (int)(reader)["section"],
                            Units = (int)(reader)["credithours"],
                            WeightGrade = (string)(reader)["weighted_grade"],
                            Prefix_number = (string)(reader)["prefix"] + '-' + (string)(reader)["number"],
                            GradePoints = (int)(reader)["gradePoints"]
                        };
                        gradeList.Add(addGrade);
                    }
                }
            }
            return gradeList;
        }

        /// <summary>
        /// Gets semester GPA
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns>grade</returns>
        public Grades GetSemesterGPA(SearchItem searchItems)
        {
            Grades grade = new Grades();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "select  " +
                "Format( " +
                "cast( " +
                "(sum(     cast(  isnull(t.gradePointAverage,0) AS decimal(10,2) )    )  " +
                "/ " +
                "(select sum( cast(isnull(t.credithours,0) AS decimal(10,2) ) ) from " +
                "(select  c.credithours " +
                "from person p, student s, StudentsInCourse sc, Course c " +
                "where p.recordID = s.recordID " +
                "and s.studentID = @studentID " +
                "and sc.studentID = s.studentID " +
                "and sc.courseID = c.courseID " +
                "and c.semester = @semester " +
                "and c.year = @year) t )  " +
                ")   as decimal(5,2)) " +
                ",'N','en-US' ) " +
                "as semesterGPA " +
                "from " +
                "(select  " +
                "(c.credithours * dbo.ufGetGradePointByScore(isnull((select    " +
                "sum(CONVERT(DECIMAL(10,2), (isnull(score, 0) * (isnull(weight,0)/100) )))   " +
                "from Grades g, Assignment a  " +
                "where g.assignmentID = a.assignmentID    and g.studentID = s.studentID and a.courseID = c.courseID ) , 0)))  " +
                "as gradePointAverage " +
                "from person p, student s, StudentsInCourse sc, Course c " +
                "where p.recordID = s.recordID " +
                "and s.studentID = @studentID   " +
                "and sc.studentID = s.studentID   " +
                "and sc.courseID = c.courseID " +
                "and c.semester = @semester    " + //term
                "and c.year = @year) t    "; //year

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentID", searchItems.StudentID);
            selectCommand.Parameters.AddWithValue("@semester", searchItems.Semester);
            selectCommand.Parameters.AddWithValue("@year", searchItems.Year);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grade = new Grades
                        {
                            GPA = (string)(reader)["semesterGPA"],

                        };
                    }
                }
            }
            return grade;
        }

        /// <summary>
        /// Gets cumulate GPA
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns>grade</returns>
        public Grades GetCumulatedGPA(SearchItem searchItems)
        {
            Grades grade = new Grades();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "select  " +
                "Format( " +
                "cast( " +
                "(sum(     cast(t.gradePointAverage AS decimal(10,2) )    )  " +
                "/ " +
                "(select sum( cast(t.credithours AS decimal(10,2) ) ) from " +
                "(select  c.credithours " +
                "from person p, student s, StudentsInCourse sc, Course c " +
                "where p.recordID = s.recordID " +
                "and s.studentID = @studentID " +
                "and sc.studentID = s.studentID " +
                "and sc.courseID = c.courseID ) t ) " +
                ")   as decimal(5,2)) " +
                ",'N','en-US' ) " +
                "as cumulativeGPA " +
                "from " +
                "(select  " +
                "(c.credithours * dbo.ufGetGradePointByScore(isnull((select    " +
                "sum(CONVERT(DECIMAL(10,2), (isnull(score, 0) * (isnull(weight,0)/100) )))   " +
                "from Grades g, Assignment a  " +
                "where g.assignmentID = a.assignmentID    and g.studentID = s.studentID and a.courseID = c.courseID ) , 0)))  " +
                "as gradePointAverage " +
                "from person p, student s, StudentsInCourse sc, Course c " +
                "where p.recordID = s.recordID " +
                "and s.studentID = @studentID   " +
                "and sc.studentID = s.studentID   " +
                "and sc.courseID = c.courseID ) t  ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentID", searchItems.StudentID);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grade = new Grades
                        {
                            GPA = (string)(reader)["cumulativeGPA"],

                        };
                    }
                }
            }
            return grade;
        }

        /// <summary>
        /// Gets complete grade information by studentID
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns>grade list</returns>
        public List<Grades> GetCompleteGradeInformationByStudentID(int studentID)
        {
            List<Grades> gradesList = new List<Grades>();
            Grades grade = new Grades();

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("dbo.spGetAllCoursesAndGrades", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@studentID", studentID);

                command.Connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grade = new Grades
                        {
                            Column1 = (string)(reader)["column1"],
                            Column2 = (string)(reader)["column2"],
                            Column3 = (string)(reader)["column3"],
                            Column4 = (string)(reader)["column4"],
                            Column5 = (string)(reader)["column5"],
                            Column6 = (string)(reader)["column6"]
                        };
                        gradesList.Add(grade);
                    }
                }
            }
            return gradesList;
        }
    }
}
