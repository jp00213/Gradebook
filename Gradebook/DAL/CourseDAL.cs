﻿using Gradebook.Model;
using System;
using System.Collections.Generic;
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
    }
}