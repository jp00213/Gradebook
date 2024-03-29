﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Gradebook.Model;

namespace Gradebook.DAL
{
    /// <summary>
    /// Defines the DAL for the Student object
    /// </summary>
    public class StudentDAL
    {
        /// <summary>
        /// Update student password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UpdateStudentPassword(string username, string password)
        {
            string hashedPassword = Hashing.HashPassword(password);

            string updateStatement = "update a  " +
                                     "set a.password = @password  " +
                                     "from Account a  " +
                                     "where a.username = @username  ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@username", username);
                    updateCommand.Parameters.AddWithValue("@password", hashedPassword);

                    int updateCount = updateCommand.ExecuteNonQuery();

                    if (updateCount > 0)
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

        /// <summary>
        /// Update student info
        /// </summary>
        /// <param name="personNew"></param>
        /// <param name="personOld"></param>
        /// <returns></returns>
        public bool UpdateStudent(Person personNew, Person personOld)
        {
            bool result = false;
            int updatePerson = 0;
            int updateStudent = 0;

            string updatePersonStatement = "update p  " +
                                     "set p.firstName = @newFirstName,  " +
                                     "p.lastName = @newLastName,  " +
                                     "p.birthday = @newDob,  " +
                                     "p.phoneNumber =  @newPhone ,  " +
                                     "p.sex = @newSex,  " +
                                     "p.street = @newStreet,  " +
                                     "p.city = @newCity,  " +
                                     "p.state = @newState,  " +
                                     "p.zip = @newZip,  " +
                                     "p.ssn = @newSSN  " +
                                     "from Person p  " +
                                     "where p.recordID = @recordID  " +
                                     "and p.firstName = @oldFirstName  " +
                                     "and p.lastName = @oldLastName  " +
                                     "and p.birthday = @oldDob  " +
                                     "and p.phoneNumber = @oldPhone  " +
                                     "and p.sex = @oldSex  " +
                                     "and p.street = @oldStreet  " +
                                     "and p.city = @oldCity  " +
                                     "and p.state = @oldState  " +
                                     "and p.zip = @oldZip " +
                                     "and (p.ssn = @oldSSN or p.ssn is null) ";

            string updateStudentStatusStatement = "update s  " +
                                                  "set s.activeStatus = @newStatus, " +
                                                  "s.maximumUnitsAllowed = @newMaximumUnitsAllowed " +
                                                  "from Student s  " +
                                                  "where s.recordID = @recordID  " +
                                                  "and (s.maximumUnitsAllowed = @oldMaximumUnitsAllowed or s.maximumUnitsAllowed is null) " +
                                                  "and s.activeStatus = @oldStatus  ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updatePersonStatement, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@newFirstName", personNew.FirstName);
                            updateCommand.Parameters.AddWithValue("@newLastName", personNew.LastName);
                            updateCommand.Parameters.AddWithValue("@newDob", personNew.DateOfBirth);
                            updateCommand.Parameters.AddWithValue("@newPhone", personNew.Phone);
                            updateCommand.Parameters.AddWithValue("@newSex", personNew.Sex);
                            updateCommand.Parameters.AddWithValue("@newStreet", personNew.AddressStreet);
                            updateCommand.Parameters.AddWithValue("@newCity", personNew.City);
                            updateCommand.Parameters.AddWithValue("@newState", personNew.State);
                            updateCommand.Parameters.AddWithValue("@newZip", personNew.Zip);
                            updateCommand.Parameters.AddWithValue("@recordID ", personNew.RecordId);

                            updateCommand.Parameters.AddWithValue("@oldFirstName", personOld.FirstName);
                            updateCommand.Parameters.AddWithValue("@oldLastName", personOld.LastName);
                            updateCommand.Parameters.AddWithValue("@oldDob", personOld.DateOfBirth);
                            updateCommand.Parameters.AddWithValue("@oldPhone", personOld.Phone);
                            updateCommand.Parameters.AddWithValue("@oldSex", personOld.Sex);
                            updateCommand.Parameters.AddWithValue("@oldStreet", personOld.AddressStreet);
                            updateCommand.Parameters.AddWithValue("@oldCity", personOld.City);
                            updateCommand.Parameters.AddWithValue("@oldState", personOld.State);
                            updateCommand.Parameters.AddWithValue("@oldZip", personOld.Zip);

                            updateCommand.Parameters.Add("@newSSN", System.Data.SqlDbType.Char);
                            if (personNew.SSN == "" || personNew.SSN is null)
                            {
                                updateCommand.Parameters["@newSSN"].Value = DBNull.Value;
                            }
                            else
                            {
                                updateCommand.Parameters["@newSSN"].Value = personNew.SSN;
                            }
                            updateCommand.Parameters.Add("@oldSSN", System.Data.SqlDbType.Char);

                            if (personOld.SSN == "" || personOld.SSN is null)
                            {
                                updateCommand.Parameters["@oldSSN"].Value = DBNull.Value;
                            }
                            else
                            {
                                updateCommand.Parameters["@oldSSN"].Value = personOld.SSN;
                            }
                            updatePerson = updateCommand.ExecuteNonQuery();
                        }

                        if (updatePerson > 0)
                        {
                            using (SqlCommand updateStudentCommand = new SqlCommand(updateStudentStatusStatement, connection, transaction))
                            {
                                updateStudentCommand.Parameters.AddWithValue("@recordID", personNew.RecordId);
                                updateStudentCommand.Parameters.AddWithValue("@newStatus", personNew.ActiveStatus);
                                updateStudentCommand.Parameters.AddWithValue("@oldStatus", personOld.ActiveStatus);

                                if (personOld.MaximumUnitsAllowed is null || personOld.MaximumUnitsAllowed.ToString() == "")
                                {
                                    updateStudentCommand.Parameters.AddWithValue("@oldMaximumUnitsAllowed", DBNull.Value);
                                }
                                else
                                {
                                    updateStudentCommand.Parameters.AddWithValue("@oldMaximumUnitsAllowed", personOld.MaximumUnitsAllowed);

                                }

                                updateStudentCommand.Parameters.Add("@newMaximumUnitsAllowed", System.Data.SqlDbType.Int);
                                if (personNew.MaximumUnitsAllowed is null)
                                {
                                    updateStudentCommand.Parameters["@newMaximumUnitsAllowed"].Value = DBNull.Value;
                                }
                                else
                                {
                                    updateStudentCommand.Parameters["@newMaximumUnitsAllowed"].Value = personNew.MaximumUnitsAllowed;
                                }
                                updateStudent = updateStudentCommand.ExecuteNonQuery();

                            }
                        }


                        if ((updatePerson == 1) && (updateStudent == 1))
                        {
                            result = true;
                            transaction.Commit();
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Get student by ID
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public Person GetStudentByID(int studentID)
        {
            Person student = new Person();

            SqlConnection connection = GradebookDBConnection.GetConnection();

            string selectStatement = "select * " +
                                     "from Student s, Person p " +
                                     "where s.recordID = p.recordID and s.studentID = @studentID  ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentID", studentID);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        student = new Person
                        {
                            StudentID = (int)(reader)["studentID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            Phone = (string)(reader)["phoneNumber"],
                            Sex = (string)(reader)["sex"],
                            AddressStreet = (string)(reader)["street"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            SSN = reader["ssn"] as string,
                            ActiveStatus = (int)(byte)(reader)["activeStatus"],
                            Username = (string)(reader)["username"],
                            RecordId = (int)(reader)["recordId"],
                            MaximumUnitsAllowed = reader["maximumUnitsAllowed"] == DBNull.Value ? default : (int)reader["maximumUnitsAllowed"]
                        };
                    }
                }
            }
            return student;
        }

        /// <summary>
        /// Get student by parameters
        /// </summary>
        /// <param name="searchItemIn"></param>
        /// <returns></returns>
        public List<Person> GetStudentByParameters(SearchItem searchItemIn)
        {
            List<Person> students = new List<Person>();

            SqlConnection connection = GradebookDBConnection.GetConnection();

            string selectStatement =
                "select *  " +
                "from Student s, Person p  " +
                "where s.recordID = p.recordID  " +
                "and (s.studentID = @studentID   " +
                "     or s.username = @userName  " +
                "     or p.firstName = @firstName  " +
                "     or p.lastName = @lastName  " +
                "     or p.birthday = @birthday) ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentID", searchItemIn.StudentID);
            selectCommand.Parameters.AddWithValue("@userName", searchItemIn.Username);
            selectCommand.Parameters.AddWithValue("@firstName", searchItemIn.FirstName);
            selectCommand.Parameters.AddWithValue("@lastName", searchItemIn.LastName);

            selectCommand.Parameters.Add("@birthday", System.Data.SqlDbType.Date);
            selectCommand.Parameters["@birthday"].Value = searchItemIn.DateOfBirth;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Person student = new Person
                        {
                            StudentID = (int)(reader)["studentID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            Phone = (string)(reader)["phoneNumber"],
                            Sex = (string)(reader)["sex"],
                            AddressStreet = (string)(reader)["street"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            SSN = reader["ssn"] as string,
                            ActiveStatus = (int)(byte)(reader)["activeStatus"],
                            Username = (string)(reader)["username"],
                            RecordId = (int)(reader)["recordId"],
                            MaximumUnitsAllowed = reader["maximumUnitsAllowed"] == DBNull.Value ? default : (int)reader["maximumUnitsAllowed"]
                        };
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        /// <summary>
        /// Get student by username
        /// </summary>
        /// <param name="usernameIn"></param>
        /// <returns></returns>
        public Person GetStudentByUsername(string usernameIn)
        {
            Person student = new Person();

            SqlConnection connection = GradebookDBConnection.GetConnection();

            string selectStatement = "select * " +
                                     "from Student s, Person p " +
                                     "where s.recordID = p.recordID " +
                                     "and s.username = @username  ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@username", usernameIn);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        student = new Person
                        {
                            StudentID = (int)(reader)["studentID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            Phone = (string)(reader)["phoneNumber"],
                            Sex = (string)(reader)["sex"],
                            AddressStreet = (string)(reader)["street"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            SSN = reader["ssn"] as string,
                            ActiveStatus = (int)(byte)(reader)["activeStatus"],
                            Username = (string)(reader)["username"],
                            RecordId = (int)(reader)["recordId"]

                        };
                    }
                }
            }
            return student;
        }

        /// <summary>
        /// Get student registered units total.
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns>unit count result</returns>
        public int GetStudentRegisterUnitsTotal(SearchItem searchItems)
        {
            int countResult = 0;
            SqlConnection connection = GradebookDBConnection.GetConnection();

            string selectStatement = "select isnull(sum(c.credithours),0) as countTotal  " +
                                     "from StudentsInCourse sc, course c  " +
                                     "where sc.courseID = c.courseID  " +
                                     "and sc.studentID = @studentID  " +
                                     "and c.semester = @semester  " +
                                     "and c.year = @year ";

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

                        {
                            countResult = (int)(reader)["countTotal"];


                        };
                    }
                }
            }
            return countResult;
        }

        /// <summary>
        /// Get student maximum allowed unit.
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public int GetStudentMaximumAllowedUnit(int studentID)
        {

            int maxAllowedResult = 0;
            SqlConnection connection = GradebookDBConnection.GetConnection();

            string selectStatement = "select   isnull(s.maximumUnitsAllowed, 18) as maxunits " +
                                     "from student s " +
                                     "where s.studentID = @studentID ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@studentID", studentID);



            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        {
                            maxAllowedResult = (int)(reader)["maxunits"];

                        };
                    }
                }
            }
            return maxAllowedResult;
        }

        /// <summary>
        /// Returns a list of students based on course ID
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public List<Person> GetStudentsByCourseID(int courseID)
        {
            List<Person> students = new List<Person>();
            Person student = new Person();

            SqlConnection connection = GradebookDBConnection.GetConnection();

            string selectStatement =
                "select *  " +
                "from StudentsInCourse sc " +
                "join Student s " +
                "on sc.studentID = s.studentID " +
                "join Person p " +
                "on s.recordID = p.recordID " +
                "where sc.courseID = @courseID ";

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
                        student = new Person
                        {
                            StudentID = (int)(reader)["studentID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            Phone = (string)(reader)["phoneNumber"],
                            Sex = (string)(reader)["sex"],
                            AddressStreet = (string)(reader)["street"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            SSN = reader["ssn"] as string,
                            ActiveStatus = (int)(byte)(reader)["activeStatus"],
                            Username = (string)(reader)["username"],
                            RecordId = (int)(reader)["recordId"]
                        };
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        /// <summary>
        /// Returns a student based on name and courseID
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public Person GetStudentByNameAndCourseID(string firstName, string lastName, int courseID)
        {
            Person student = new Person();

            SqlConnection connection = GradebookDBConnection.GetConnection();

            string selectStatement =
                "select *  " +
                "from StudentsInCourse sc " +
                "join Student s " +
                "on sc.studentID = s.studentID " +
                "join Person p " +
                "on s.recordID = p.recordID " +
                "where sc.courseID = @courseID " +
                "AND p.firstName = @firstName " +
                "AND p.lastName = @lastName";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@firstName"].Value = firstName;

            selectCommand.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@lastName"].Value = lastName;

            selectCommand.Parameters.Add("@courseID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@courseID"].Value = courseID;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        student = new Person
                        {
                            StudentID = (int)(reader)["studentID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            Phone = (string)(reader)["phoneNumber"],
                            Sex = (string)(reader)["sex"],
                            AddressStreet = (string)(reader)["street"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            SSN = reader["ssn"] as string,
                            ActiveStatus = (int)(byte)(reader)["activeStatus"],
                            Username = (string)(reader)["username"],
                            RecordId = (int)(reader)["recordId"]
                        };
                    }
                }
            }
            return student;
        }

    }
}
