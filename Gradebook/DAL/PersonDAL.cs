using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Data.SqlClient;


namespace Gradebook.DAL
{
    /// <summary>
    /// Defines the DAL for the Person object
    /// </summary>
    public class PersonDAL
    {
        /// <summary>
        /// Creates person as a student in the DB
        /// </summary>
        /// <param name="person">person student</param>
        /// <returns></returns>
        public Boolean AddPersonAsStudent(Person person)
        {
            Boolean result = false;
            int record = 0;
            int affectedRecords = 0;
            /*steps
            1. create person in person table, part 1
            2. set new username
            3. create username and insert into account, part 2
            4. create student role and insert into student, part 3
            */

            string insertStatementPerson = "INSERT INTO person " +
                "(lastName, firstName, birthday, street, city, state, zip, phoneNumber, sex, ssn) " +
                "VALUES (@lastName, @firstName, @birthday, @street, @city, @state, @zip, @phoneNumber, @sex, @ssn) ";

            // get the new person record id
            string selectStatementRecordID = "SELECT IDENT_CURRENT('person') FROM person ";
            string insertStatementAccount = "insert into account (username, password) values (@newUsername, @password) ";
            string insertStatementStudent = "insert into student (recordID, activeStatus, username) VALUES (@recordID, @activeStatus, @newUsername) ";
            string selectStatementCount = "SELECT @@ROWCOUNT ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var oldUsername = GetTheLastCreatedUsernameByFirstAndLastName(person.FirstName, person.LastName);
                        string newUsername = CreatePersonUserName.CreateNewPersonUsername(person.FirstName, person.LastName, oldUsername);

                        // part 1
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementPerson, connection))
                        {
                            insertCommand.Transaction = transaction;

                            insertCommand.Parameters.AddWithValue("@lastName", person.LastName);
                            insertCommand.Parameters.AddWithValue("@firstName", person.FirstName);
                            insertCommand.Parameters.AddWithValue("@birthday", person.DateOfBirth);
                            insertCommand.Parameters.AddWithValue("@street", person.AddressStreet);
                            insertCommand.Parameters.AddWithValue("@city", person.City);
                            insertCommand.Parameters.AddWithValue("@state", person.State);
                            insertCommand.Parameters.AddWithValue("@zip", person.Zip);
                            insertCommand.Parameters.AddWithValue("@phoneNumber", person.Phone);
                            insertCommand.Parameters.AddWithValue("@sex", person.Sex);
                            insertCommand.Parameters.Add("@ssn", System.Data.SqlDbType.Char);
                            if (person.SSN == "")
                            {
                                insertCommand.Parameters["@ssn"].Value = DBNull.Value;
                            }
                            else
                            {
                                insertCommand.Parameters["@ssn"].Value = person.SSN;
                            }
                            insertCommand.ExecuteNonQuery();

                            // get the new person record id 
                            SqlCommand selectCommand = new SqlCommand(selectStatementRecordID, connection, transaction);
                            using (selectCommand)
                            {
                                record = Convert.ToInt32(selectCommand.ExecuteScalar());
                            }
                        }

                        // part 2 check existing username and set new username


                        // part 3 insert to account(username and password)
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementAccount, connection))
                        {
                            insertCommand.Transaction = transaction;
                            insertCommand.Parameters.AddWithValue("@newUsername", newUsername);
                            insertCommand.Parameters.AddWithValue("@password", "passwordhashed");
                            insertCommand.ExecuteNonQuery();
                        }


                        // part 4 insert to student (auto create student ID, username, record ID, )
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementStudent, connection))
                        {
                            insertCommand.Transaction = transaction;
                            insertCommand.Parameters.AddWithValue("@recordID", record);
                            insertCommand.Parameters.AddWithValue("@newUsername", newUsername);

                            insertCommand.ExecuteNonQuery();

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
                        //System.Windows.Forms.MessageBox.Show("processed");
                        //connection.Close();
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
        /// Creates person as a teacher in the DB
        /// </summary>
        /// <param name="person">person student</param>
        /// <returns></returns>
        public Boolean AddPersonAsTeacher(Person person)
        {
            Boolean result = false;
            int record = 0;
            int affectedRecords = 0;
            /*steps
            1. create person in person table, part 1
            2. set new username
            3. create username and insert into account, part 2
            4. create student role and insert into student, part 3
            */

            string insertStatementPerson = "INSERT INTO person " +
                "(lastName, firstName, birthday, street, city, state, zip, phoneNumber, sex, ssn) " +
                "VALUES (@lastName, @firstName, @birthday, @street, @city, @state, @zip, @phoneNumber, @sex, @ssn) ";

            // get the new person record id
            string selectStatementRecordID = "SELECT IDENT_CURRENT('person') FROM person ";
            string insertStatementAccount = "insert into account (username, password) values (@newUsername, @password) ";
            string insertStatementStudent = "insert into teacher (recordID, activeStatus, username) VALUES (@recordID, 1, @newUsername) ";
            string selectStatementCount = "SELECT @@ROWCOUNT ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var oldUsername = GetTheLastCreatedUsernameByFirstAndLastName(person.FirstName, person.LastName);
                        string newUsername = CreatePersonUserName.CreateNewPersonUsername(person.FirstName, person.LastName, oldUsername);

                        // part 1
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementPerson, connection))
                        {
                            insertCommand.Transaction = transaction;

                            insertCommand.Parameters.AddWithValue("@lastName", person.LastName);
                            insertCommand.Parameters.AddWithValue("@firstName", person.FirstName);
                            insertCommand.Parameters.AddWithValue("@birthday", person.DateOfBirth);
                            insertCommand.Parameters.AddWithValue("@street", person.AddressStreet);
                            insertCommand.Parameters.AddWithValue("@city", person.City);
                            insertCommand.Parameters.AddWithValue("@state", person.State);
                            insertCommand.Parameters.AddWithValue("@zip", person.Zip);
                            insertCommand.Parameters.AddWithValue("@phoneNumber", person.Phone);
                            insertCommand.Parameters.AddWithValue("@sex", person.Sex);
                            insertCommand.Parameters.Add("@ssn", System.Data.SqlDbType.Char);
                            if (person.SSN == "")
                            {
                                insertCommand.Parameters["@ssn"].Value = DBNull.Value;
                            }
                            else
                            {
                                insertCommand.Parameters["@ssn"].Value = person.SSN;
                            }
                            insertCommand.ExecuteNonQuery();

                            // get the new person record id 
                            SqlCommand selectCommand = new SqlCommand(selectStatementRecordID, connection, transaction);
                            using (selectCommand)
                            {
                                record = Convert.ToInt32(selectCommand.ExecuteScalar());
                            }
                        }

                        // part 2 check existing username and set new username


                        // part 3 insert to account(username and password)
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementAccount, connection))
                        {
                            insertCommand.Transaction = transaction;
                            insertCommand.Parameters.AddWithValue("@newUsername", newUsername);
                            insertCommand.Parameters.AddWithValue("@password", "mypassword");
                            insertCommand.ExecuteNonQuery();
                        }


                        // part 4 insert to student (auto create student ID, username, record ID, )
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementStudent, connection))
                        {
                            insertCommand.Transaction = transaction;
                            insertCommand.Parameters.AddWithValue("@recordID", record);
                            insertCommand.Parameters.AddWithValue("@newUsername", newUsername);
                            insertCommand.Parameters.AddWithValue("@activeStatus", person.ActiveStatus);

                            insertCommand.ExecuteNonQuery();


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
                        connection.Close();
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
        /// Get the last created Username by first and last name of student
        /// </summary>
        /// <param name="firstNameIn">first name of student</param>
        /// <param name="lastNameIn">last name of student</param>
        /// <returns>username</returns>
        public string GetTheLastCreatedUsernameByFirstAndLastName(string firstNameIn, string lastNameIn)
        {
            var theUsername = "";
            string selectStatement =

               "select * " +
               "from person p, student s " +
               "where p.recordID = s.recordID " +
               "and p.recordID = (select max(r.recordID) " +
                                 "from person r " +
                                 "where lower(r.firstName) = lower(@firstName) " +
                                 "and lower(r.lastName) = lower(@lastName))  ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@firstName", firstNameIn);
                    selectCommand.Parameters.AddWithValue("@lastName", lastNameIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            {
                                theUsername = reader["username"].ToString();
                            };

                        }
                    }
                }
            }
            return theUsername;
        }

       /// <summary>
       /// Get the last created username informaton
       /// </summary>
       /// <param name="firstNameIn">first name entered</param>
       /// <param name="lastNameIn">last name entered</param>
       /// <returns>student information</returns>
        public string GetTheLastCreatedUsernameInformation(string firstNameIn, string lastNameIn)
        {
            var theUsername = "";
            var theStudentID = "";
            var completeStudentInfo = "";

            string selectStatement =

               "select * " +
               "from person p, student s " +
               "where p.recordID = s.recordID " +
               "and p.recordID = (select max(r.recordID) " +
                                 "from person r " +
                                 "where lower(r.firstName) = lower(@firstName) " +
                                 "and lower(r.lastName) = lower(@lastName))  ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@firstName", firstNameIn);
                    selectCommand.Parameters.AddWithValue("@lastName", lastNameIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            {
                                theUsername = reader["username"].ToString();
                                theStudentID = reader["studentID"].ToString();
                            };

                        }
                    }
                }
            }
            completeStudentInfo = "Student ID = " + theStudentID + "\n" + "Username = " + theUsername + "\n" + "Student name: " + firstNameIn + " " + lastNameIn + " ";

            return completeStudentInfo;
        }
    }
}
