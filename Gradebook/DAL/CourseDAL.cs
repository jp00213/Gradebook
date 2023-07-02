using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        /// <summary>
        /// Returns a list of all courses
        /// </summary>
        /// <returns></returns>
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
        /// Get course from DB based on name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Course GetCourseByName(string name)
       {
            Course course = new Course();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM course " +
                "WHERE name = @name ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@name"].Value = name;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        course = new Course
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
                    }
                }
            }
            return course;
        }

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
        /// Get student course grade details by studentID & courseID
        /// </summary>
        /// <param name="gradesSearch"></param>
        /// <returns>grades</returns>
        public List<Grades> GetStudentCourseGradeDetailsByStudentIDAndCourseID(Grades gradesSearch)
        {
            List<Grades> grades = new List<Grades>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement = "  select studentID, " +
                                     "a.courseID, " +
                                     "a.assignmentID, " +
                                     "a.description, " +
                                     "isnull(weight,0) as weightout, " +
                                     "isnull(score,0) as score, " +
                                     "CONVERT(DECIMAL(10,2), (isnull(score, 0) * (isnull(weight,0)/100) )) as weighted_grade  " +
                                     "from Grades g, Assignment a  " +
                                     "where g.assignmentID = a.assignmentID  " +
                                     "and g.studentID = @studentID  " +
                                     "and a.courseID = @courseID  ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentID", gradesSearch.StudentID);
            selectCommand.Parameters.AddWithValue("@courseID", gradesSearch.CourseID);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Grades grade = new Grades
                        {

                            StudentID = (int)(reader)["studentID"],
                            CourseID = (int)(reader)["courseID"],
                            AssignmentID = (int)(reader)["assignmentID"],
                            Description = (string)(reader)["description"],
                            Weight = (reader)["weightout"].ToString(),
                            Score = (reader)["score"].ToString(),
                            WeightGrade = (reader)["weighted_grade"].ToString()
                        };
                        grades.Add(grade);
                    }
                }
            }
            return grades;
        }

        /// <summary>
        /// Delete course
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get student course weight grade by studentID and courseID
        /// </summary>
        /// <param name="gradesSearch"></param>
        /// <returns></returns>
        public string GetStudentCourseWeightGradeByStudentIDAndCourseID(Grades gradesSearch)
        {
            String grade = "";

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement = "  select  " +
                                     "  sum(CONVERT(DECIMAL(10,2), (isnull(score, 0) * (isnull(weight,0)/100) ))) as weighted_grade  " +
                                     "from Grades g, Assignment a  " +
                                     "where g.assignmentID = a.assignmentID  " +
                                     "and g.studentID = @studentID  " +
                                     "and a.courseID = @courseID  ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentID", gradesSearch.StudentID);
            selectCommand.Parameters.AddWithValue("@courseID", gradesSearch.CourseID);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        {


                            grade = (reader)["weighted_grade"].ToString();
                        };
                    }
                }
            }
            return grade;
        }

        /// <summary>
        /// Updates a course
        /// </summary>
        /// <param name="updateCourse"></param>
        /// <returns></returns>
        public bool UpdateCourse(Course updateCourse, Course oldCourse)
        {
            SqlConnection connection = GradebookDBConnection.GetConnection();
            string insertStatement =
                "UPDATE course " +
                "SET name = @name, prefix = @prefix, number = @number, section = @section, " +
                "creditHours = @credithours, semester = @semester, year = @year, teacherID = @teacherID " +
                "WHERE courseID = @courseID AND " +
                "name = @oldName AND prefix = @oldPrefix AND number = @oldNumber AND section = @oldSection AND " +
                "creditHours = @oldCredithours AND semester = @oldSemester AND year = @oldYear AND teacherID = @oldTeacherID ";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@name"].Value = updateCourse.Name;

            insertCommand.Parameters.Add("@prefix", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@prefix"].Value = updateCourse.Prefix;

            insertCommand.Parameters.Add("@number", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@number"].Value = updateCourse.Number;

            insertCommand.Parameters.Add("@section", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@section"].Value = updateCourse.Section;

            insertCommand.Parameters.Add("@credithours", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@credithours"].Value = updateCourse.CreditHours;

            insertCommand.Parameters.Add("@semester", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@semester"].Value = updateCourse.Semester;

            insertCommand.Parameters.Add("@year", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@year"].Value = updateCourse.Year;

            insertCommand.Parameters.Add("@teacherID", System.Data.SqlDbType.Int);
            if (updateCourse.TeacherID == 0)
            {
                insertCommand.Parameters["@teacherID"].Value = DBNull.Value;
            }
            else
            {
                insertCommand.Parameters["@teacherID"].Value = updateCourse.TeacherID;
            }

            insertCommand.Parameters.Add("@oldName", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@oldName"].Value = oldCourse.Name;

            insertCommand.Parameters.Add("@oldPrefix", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@oldPrefix"].Value = oldCourse.Prefix;

            insertCommand.Parameters.Add("@oldNumber", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@oldNumber"].Value = oldCourse.Number;

            insertCommand.Parameters.Add("@oldSection", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@oldSection"].Value = oldCourse.Section;

            insertCommand.Parameters.Add("@oldCredithours", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@oldCredithours"].Value = oldCourse.CreditHours;

            insertCommand.Parameters.Add("@oldSemester", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@oldSemester"].Value = oldCourse.Semester;

            insertCommand.Parameters.Add("@oldYear", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@oldYear"].Value = oldCourse.Year;

            insertCommand.Parameters.Add("@oldTeacherID", System.Data.SqlDbType.Int);
            if (updateCourse.TeacherID == 0)
            {
                insertCommand.Parameters["@oldTeacherID"].Value = DBNull.Value;
            }
            else
            {
                insertCommand.Parameters["@oldTeacherID"].Value = oldCourse.TeacherID;
            }

            insertCommand.Parameters.Add("@courseID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@courseID"].Value = oldCourse.CourseID;

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
        /// Returns a list of courses by student ID
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByStudentRegistration(int studentID)
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM course c,  studentsincourse s " +
                "WHERE c.courseID = s.courseID  AND s.studentID = @studentID ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@studentID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@studentID"].Value = studentID;

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
        /// Get course by teacherID & Semester & Year
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns></returns>
        public List<Course> GetCourseByTeacherIDAndSemesterAndYear(Course searchItems)
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement = "select * ,  (select count(*)  from StudentsInCourse r where r.courseID = c.courseID) as studentCount  " +
                                     "from course c  " +
                                     "where c.teacherID = @teacherID  " +
                                     "and c.semester = @semester " +
                                     "and c.year = @year   ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@teacherID", searchItems.TeacherID);
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
                            StudentCount = (int)(reader)["studentCount"],
                        };
                        courses.Add(addCourse);
                    }
                }
            }
            return courses;
        }

        /// <summary>
        /// Get roster data by teacherID & Semester & Year & CourseID
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns></returns>
        public List<Course> GetRosterDataByTeacherIDAndSemesterAndYearAndCourseID(Course searchItems)
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement = "select * " +
                                     "from course c, StudentsInCourse i, student s, person p  " +
                                     "where i.courseID = c.courseID  " +
                                     "and i.studentID = s.studentID " +
                                     "and s.recordID = p.recordID  " +
                                     "and c.teacherID = @teacherID " +
                                     "and c.semester = @semester " +
                                     "and c.year = @year " +
                                     "and c.courseID = @courseID ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@teacherID", searchItems.TeacherID);
            selectCommand.Parameters.AddWithValue("@semester", searchItems.Semester);
            selectCommand.Parameters.AddWithValue("@year", searchItems.Year);
            selectCommand.Parameters.AddWithValue("@courseID", searchItems.CourseID);

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
                            StudentID = (int)(reader)["studentID"],
                            StudentFullName = (string)(reader)["firstName"] + " " + (string)(reader)["lastName"]
                        };
                        courses.Add(addCourse);
                    }
                }
            }
            return courses;
        }

        /// <summary>
        /// Returns all courses in a particular year and semester for a particular student ID
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Course> GetCoursesByYearSemesterStudentID(string semester, int year, int studentID)
        {
            List<Course> courses = new List<Course>();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM StudentsInCourse s, Course c " +
                "WHERE s.courseID = c.courseID " +
                "AND s.studentID = @studentID AND semester = @semester " +
                "AND year = @year ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@semester", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@semester"].Value = semester;

            selectCommand.Parameters.Add("@year", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@year"].Value = year;

            selectCommand.Parameters.Add("@studentID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@studentID"].Value = studentID;

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
        /// Deletes registration for a student and course
        /// </summary>
        /// <param name="courseID"></param>
        /// <param name="studentid"></param>
        public bool DeleteRegistration(int courseID, int studentid)
        {
            SqlConnection connection = GradebookDBConnection.GetConnection();
            string deleteStatement =
                "DELETE FROM studentsincourse " +
                "WHERE courseID = @courseID AND studentID = @studentID";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);

            deleteCommand.Parameters.AddWithValue("@courseID", courseID);
            deleteCommand.Parameters.AddWithValue("@studentID", studentid);

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

        /// <summary>
        /// Get class grades by courseID
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns>grade list</returns>
        public List<Grades> GetClassGradesByCourseID(int courseID)
        {
            List<Grades> gradesList = new List<Grades>();
            Grades grade = new Grades();

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("dbo.spGetClassGradesByCourseID", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@courseID", courseID);

                command.Connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grade = new Grades
                        {
                            StudentID = (int)(reader)["studentID"],
                            Grade_1 = (string)(reader)["a1"],
                            Grade_2 = (string)(reader)["a2"],
                            Grade_3 = (string)(reader)["a3"],
                            Grade_4 = (string)(reader)["a4"],
                            Grade_5 = (string)(reader)["a5"],
                            Grade_6 = (string)(reader)["a6"],
                            Grade_7 = (string)(reader)["a7"],
                            Grade_8 = (string)(reader)["a8"],
                            Grade_9 = (string)(reader)["a9"],
                            Grade_10 = (string)(reader)["a10"],
                            Grade_11 = (string)(reader)["a11"],
                            Grade_12 = (string)(reader)["a12"],
                            Grade_13 = (string)(reader)["a13"],
                            Grade_14 = (string)(reader)["a14"],
                            Grade_15 = (string)(reader)["a15"],
                            WeightGrade = (string)(reader)["total"]
                        };
                        gradesList.Add(grade);
                    }
                }
            }
            return gradesList;
        }

    }
}
