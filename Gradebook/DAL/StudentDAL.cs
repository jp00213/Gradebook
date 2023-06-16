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
    /// Defines the DAL for the Student object
    /// </summary>
    public class StudentDAL
    {
        /// <summary>
        /// Update a studen in DB
        /// </summary>
        /// <param name="personNew"></param>
        /// <param name="personOld"></param>
        /// <returns></returns>
        public bool UpdateStudent(Person personNew, Person personOld)
        {
            bool result = false;
            int affectedRecords = 0;
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

            string selectStatementCount = "SELECT @@ROWCOUNT ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updatePersonStatement, connection))
                        {
                            updateCommand.Transaction = transaction;

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
                            updateCommand.Parameters.AddWithValue("@recordID ", recordID);
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

                            updateCommand.ExecuteNonQuery();
                        }
                        using (SqlCommand updateStudentCommand = new SqlCommand(updateStudentStatusStatement, connection))
                        {
                            updateStudentCommand.Transaction = transaction;

                            updateStudentCommand.Parameters.AddWithValue("@newStatus", personNew.ActiveStatus);
                            updateStudentCommand.Parameters.AddWithValue("@recordID", recordID);
                            updateStudentCommand.Parameters.AddWithValue("@oldStatus", personOld.ActiveStatus);

                            updateStudentCommand.ExecuteNonQuery();

                            // check if insert passed
                            SqlCommand selectCommand = new SqlCommand(selectStatementCount, connection);
                            selectCommand.Transaction = transaction;
                            using (selectCommand)
                            {
                                affectedRecords = Convert.ToInt32(selectCommand.ExecuteScalar());
                            }
                        }

                        result = affectedRecords > 0;

                        transaction.Commit();
                        //      System.Windows.Forms.MessageBox.Show("processed");
                        //      connection.Close();
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
        /// <param name="id">name</param>
        /// <returns>student</returns>
        public Person GetStudentByID(int id)
        {
            Person student = new Person();

            return student;
        }

        /// <summary>
        /// Get student by name and DOB
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <param name="dob"></param>
        /// <returns>student</returns>
        public List<Person> GetStudentByNameDOB(string firstName, string lastName, DateTime dob)
        {
            List<Person> students = new List<Person>();

            return students;
        }

        /// <summary>
        /// Get studnet by last and first name
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <returns>student</returns>
        public List<Person> GetStudentByLastAndFirstName(string firstName, string lastName)
        {
            List<Person> students = new List<Person>();
            return students;

        }

        /// <summary>
        /// Get sutdent by last name and DOB
        /// </summary>
        /// <param name="lastName">last name</param>
        /// <param name="dob">dob</param>
        /// <returns>student</returns>
        public List<Person> GetStudentByLastAndDOB(string lastName, DateTime dob)
        {
            List<Person> students = new List<Person>();
            return students;

        }

        /// <summary>
        /// Get student by DOB
        /// </summary>
        /// <param name="dobIn">dob</param>
        /// <returns>student</returns>
        public List<Person> GetStudentByDobOnly(DateTime dobIn)
        {
            List<Person> students = new List<Person>();
            return students;
        }
    }
}
