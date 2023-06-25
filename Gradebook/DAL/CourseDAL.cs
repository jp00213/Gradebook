using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gradebook.DAL
{
    /// <summary>
    /// Defines the DAL for the Course object
    /// </summary>
    public class CourseDAL
    {
        /// <summary>
        /// Adds a new course to database
        /// </summary>
        /// <param name="newCourse"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool AddNewCourse(Course newCourse)
        {
            Boolean result = false;

            string insertStatement = "INSERT INTO course " +
                "(name, prefix, number, section, credithours, semester, year, teacherID) " +
                "VALUES (@name, @prefix, @number, @section, @credithours, @semester, @year, @teacherID)";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@name"].Value = newCourse.Name;

                    insertCommand.Parameters.Add("@prefix", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@prefix"].Value = newCourse.Prefix;

                    insertCommand.Parameters.Add("@number", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@number"].Value = newCourse.Number;

                    insertCommand.Parameters.Add("@section", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@section"].Value = newCourse.Section;

                    insertCommand.Parameters.Add("@credithours", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@credithours"].Value = newCourse.CreditHours;

                    insertCommand.Parameters.Add("@semester", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@semester"].Value = newCourse.Semester;

                    insertCommand.Parameters.Add("@year", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@year"].Value = newCourse.Year;

                    insertCommand.Parameters.Add("@teacherID", System.Data.SqlDbType.Int);
                    if (newCourse.TeacherID == 0)
                    {
                        insertCommand.Parameters["@teacherID"].Value = DBNull.Value;
                    }
                    else
                    {
                        insertCommand.Parameters["@teacherID"].Value = newCourse.TeacherID;
                    }

                    int record = insertCommand.ExecuteNonQuery();
                    result = record > 0;
                }
            }

            return result;
        }

        /// <summary>
        /// Returns all courses in a particular year and semester
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByYearSemester(string semester, int year)
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM course " +
                "WHERE semester = @semester " +
                "AND year = @year ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@semester", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@semester"].Value = semester;

            selectCommand.Parameters.Add("@year", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@year"].Value = year;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Course addCourse = new Course
                        {
                            CourseID = (int)(reader)["courseID"],
                            Name = (string)(reader)["name"],
                            Prefix = (string)(reader)["prefix"],
                            Number = (string)(reader)["number"],
                            Section = (int)(reader)["section"],
                            CreditHours = (int)(reader)["credithours"],
                            Semester = (string)(reader)["semester"],
                            Year = (int)(reader)["year"],
                            TeacherID = (int)(reader)["teacherID"],
                        };
                        courses.Add(addCourse);
                    }
                }
            }
            return courses;
        }

        /// <summary>
        /// Register student for a course
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="courseId"></param>
        /// <exception cref="NotImplementedException"></exception>
        public Boolean RegisterStudent(int studentId, int courseId)
        {
            Boolean result = false;

            string insertStatement = "INSERT INTO studentsincourse " +
                "(courseId, studentID) " +
                "VALUES (@courseID, @studentID)";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.Add("@courseID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@courseID"].Value = courseId;

                    insertCommand.Parameters.Add("@studentID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@studentID"].Value = studentId;

                    int record = insertCommand.ExecuteNonQuery();
                    result = record > 0;
                }
            }
            return result;
        }

        /// <summary>
        /// Returns all courses taught by a particular teacher in a particular year and semester
        /// </summary>
        /// <param name="teacher"></param>
        /// <param name="semester"></param>
        /// <param name="year"></param>
        /// <returns>List of teachers</returns>
        public List<Course> GetCoursesByTeacherIDYearAndSemester(int teacherID, string semester, int year)
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM course " +
                "WHERE teacherID = @teacherID " +
                "AND semester = @semester " +
                "AND year = @year ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@teacherID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@teacherID"].Value = teacherID;

            selectCommand.Parameters.Add("@semester", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@semester"].Value = semester;

            selectCommand.Parameters.Add("@year", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@year"].Value = year;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Course addCourse = new Course
                        {
                            CourseID = (int)(reader)["courseID"],
                            Name = (string)(reader)["name"],
                            Prefix = (string)(reader)["prefix"],
                            Number = (string)(reader)["number"],
                            Section = (int)(reader)["section"],
                            CreditHours = (int)(reader)["credithours"],
                            Semester = (string)(reader)["semester"],
                            Year = (int)(reader)["year"],
                            TeacherID = (int)(reader)["teacherID"],
                        };
                        courses.Add(addCourse);
                    }
                }
            }
            return courses;
        }


        public List<Course> GetCourseList()
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM course ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Course addCourse = new Course
                        {
                            CourseID = (int)(reader)["courseID"],
                            Name = (string)(reader)["name"],
                            Prefix = (string)(reader)["prefix"],
                            Number = (string)(reader)["number"],
                            Section = (int)(reader)["section"],
                            CreditHours = (int)(reader)["credithours"],
                            Semester = (string)(reader)["semester"],
                            Year = (int)(reader)["year"],
                            TeacherID = (int)(reader)["teacherID"],
                        };
                        courses.Add(addCourse);
                    }
                }
            }
            return courses;
        }

        /// <summary>
        /// Get student course details by term, year and student ID
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns>course</returns>
        public List<Course> GetStudentCourseDetailsByTermAndYearAndStudentID(Course searchItems)
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =

                // this query allows early test record with teacher as null
                "select c.courseID, c.name, c.prefix, c.number, c.section, c.credithours, c.semester, c.year, isnull(p.firstName, ' Not Assigned ') as firstName, isnull(p.lastName, ' ') as lastName   " +
                "from  StudentsInCourse s  " +
                "join  course c on s.courseID = c.courseID  " +
                "left join teacher t  on c.teacherID = t.teacherID  " +
                "left join person p on t.recordID = p.recordID  " +
                "where  s.studentID = @studentID  " +
                "and c.semester = @semester  " +
                "and c.year = @year  ";
            /*
            "select  *  " +
            "from course c, StudentsInCourse s , teacher t, person p  " +
            "where c.courseID = s.courseID " +
            "and c.teacherID = t.teacherID  " +
            "and t.recordID = p.recordID  " +
            "and s.studentID = @studentID " +
            "and c.semester = @semester " +
            "and c.year = @year " ;
              */
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
                        Course addCourse = new Course
                        {
                            CourseID = (int)(reader)["courseID"],
                            Name = (string)(reader)["name"],
                            Prefix = (string)(reader)["prefix"],
                            Number = (string)(reader)["number"],
                            Section = (int)(reader)["section"],
                            CreditHours = (int)(reader)["credithours"],
                            Semester = (string)(reader)["semester"],
                            Year = (int)(reader)["year"],
                            TeacherFullName = (string)(reader)["firstName"] + " " + (string)(reader)["lastName"]
                        };
                        courses.Add(addCourse);
                    }
                }
            }
            return courses;
        }

        /// <summary>
        /// Returns all courses in a particular year and semester
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByMultipleParameters(Course testCourse)
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM course WHERE 1=1 ";
            if (!string.IsNullOrEmpty(testCourse.Name)) { selectStatement += "AND name LIKE @name "; }
            if (!string.IsNullOrEmpty(testCourse.Semester)) { selectStatement += "AND semester = @semester "; }
            if (testCourse.Year != 0) { selectStatement += "AND year = @year "; }
            if (!string.IsNullOrEmpty(testCourse.Prefix)) { selectStatement += "AND prefix = @prefix "; }
            if (!string.IsNullOrEmpty(testCourse.Number)) { selectStatement += "AND number = @number "; }
            if (testCourse.TeacherID != 0) { selectStatement += "AND teacherID = @teacherID "; }

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@name"].Value = "%" + testCourse.Name + "%";

            selectCommand.Parameters.Add("@semester", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@semester"].Value = testCourse.Semester;

            selectCommand.Parameters.Add("@year", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@year"].Value = testCourse.Year;

            selectCommand.Parameters.Add("@prefix", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@prefix"].Value = testCourse.Prefix;

            selectCommand.Parameters.Add("@number", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@number"].Value = testCourse.Number;

            selectCommand.Parameters.Add("@teacherID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@teacherID"].Value = testCourse.TeacherID;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Course addCourse = new Course
                        {
                            CourseID = (int)(reader)["courseID"],
                            Name = (string)(reader)["name"],
                            Prefix = (string)(reader)["prefix"],
                            Number = (string)(reader)["number"],
                            Section = (int)(reader)["section"],
                            CreditHours = (int)(reader)["credithours"],
                            Semester = (string)(reader)["semester"],
                            Year = (int)(reader)["year"],
                            TeacherID = (int)(reader)["teacherID"],
                        };
                        courses.Add(addCourse);
                    }
                }
            }
            return courses;
        }

        /// <summary>
        /// Delete course
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool DeleteCourse(int courseID)
        {
            SqlConnection connection = GradebookDBConnection.GetConnection();
            string deleteStatement =
                "DELETE FROM course " +
                "WHERE courseID = @courseID ";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);

            deleteCommand.Parameters.AddWithValue("@courseID", courseID);

            using (deleteCommand)
            {
                connection.Open();
                int rowsAffected = deleteCommand.ExecuteNonQuery();
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
