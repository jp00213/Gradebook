using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
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
                    updateCommand.Parameters.AddWithValue("@password", password);

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
            int recordID = personNew.RecordId;
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
                                     "and p.zip = @oldZip  " +
                                     "and p.ssn = @oldSSN  ";

            string updateStudentStatusStatement = "update s  " +
                                                  "set s.activeStatus = @newStatus " +
                                                  "from Student s  " +
                                                  "where s.recordID = @recordID  " +
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
                            updateCommand.Parameters.AddWithValue("@newSSN", personNew.SSN);
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
                            updateCommand.Parameters.AddWithValue("@oldSSN", personOld.SSN);

                            updatePerson = updateCommand.ExecuteNonQuery();
                        }
                        using (SqlCommand updateStudentCommand = new SqlCommand(updateStudentStatusStatement, connection, transaction))
                        {
                            updateStudentCommand.Parameters.AddWithValue("@newStatus", personNew.ActiveStatus);
                            updateStudentCommand.Parameters.AddWithValue("@recordID", personNew.RecordId);
                            updateStudentCommand.Parameters.AddWithValue("@oldStatus", personOld.ActiveStatus);
                            updateStudent = updateStudentCommand.ExecuteNonQuery();

                        }
                        //System.Windows.Forms.MessageBox.Show(updatePerson.ToString() + updateStudent.ToString());

                        if ((updatePerson == 1) && (updateStudent == 1))
                        {
                            result = true;
                            transaction.Commit();

                            //           System.Windows.Forms.MessageBox.Show("update processed");

                        };
                    }
                    catch (SqlException sqlEx)
                    {
                        System.Windows.Forms.MessageBox.Show(sqlEx.Message);
                        transaction.Rollback();
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
                            RecordId = (int)(reader)["recordId"]

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
            Person student = new Person();
            //string theSSN = "";

            SqlConnection connection = GradebookDBConnection.GetConnection();

            string selectStatement =
                "select *  " +
                "from Student s, Person p  " +
                "where s.recordID = p.recordID  " +
                "and (s.studentID = @studentID   " +
                "     or s.username = @userName  " +
                "     or p.firstName =  @firstName  " +
                "     or p.lastName =  @lastName  " +
                "     or p.birthday =  @birthday) ";

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

    }
}
