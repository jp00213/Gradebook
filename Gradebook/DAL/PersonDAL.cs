using Gradebook.Function;
using Gradebook.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                        var oldUsername = GetTheLastCreatedUsernameByFirstAndLastNameForStudent(person.FirstName, person.LastName);
                        string newUsername = CreatePersonUserName.CreateNewPersonUsernameStudent (person.FirstName, person.LastName, oldUsername);

                        // part 1
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementPerson, connection, transaction))
                        {
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
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementAccount, connection, transaction))
                        {
                            insertCommand.Transaction = transaction;
                            string theSSN = person.SSN.ToString();
                            string theFirstName = person.FirstName;
                            string newPasswordText = theFirstName + theSSN.Substring(theSSN.Length - 4);
                            string passwordhashed = Hashing.HashPassword(newPasswordText);
                            insertCommand.Parameters.AddWithValue("@newUsername", newUsername);
                            insertCommand.Parameters.AddWithValue("@password", passwordhashed);
                            insertCommand.ExecuteNonQuery();
                        }


                        // part 4 insert to student (auto create student ID, username, record ID, )
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementStudent, connection, transaction))
                        {
                            insertCommand.Transaction = transaction;
                            insertCommand.Parameters.AddWithValue("@recordID", record);
                            insertCommand.Parameters.AddWithValue("@newUsername", newUsername);
                            insertCommand.Parameters.AddWithValue("@activeStatus", person.ActiveStatus);

                            insertCommand.ExecuteNonQuery();

                            // check if insert passed
                            SqlCommand selectCommand = new SqlCommand(selectStatementCount, connection, transaction);
                            selectCommand.Transaction = transaction;
                            using (selectCommand)
                            {
                                affectedRecords = Convert.ToInt32(selectCommand.ExecuteScalar());
                            }
                        }

                        result = affectedRecords > 0;

                        transaction.Commit();
                    }
                    catch (SqlException)
                    {
                        transaction.Rollback();
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Creates person as a teacher in the DB
        /// </summary>
        /// <param name="person">person teacher</param>
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
            string insertStatementTeacher = "insert into teacher (recordID, activeStatus, username) VALUES (@recordID, 1, @newUsername) ";
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
                            string passwordhashed = Hashing.HashPassword("mypassword");
                            insertCommand.Parameters.AddWithValue("@newUsername", newUsername);
                            insertCommand.Parameters.AddWithValue("@password", passwordhashed);
                            insertCommand.ExecuteNonQuery();
                        }


                        // part 4 insert to student (auto create student ID, username, record ID, )
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementTeacher, connection))
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
                        // connection.Close();
                    }
                    catch (SqlException)
                    {
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
               "from person p, teacher s " +
               "where p.recordID = s.recordID " +
               "and p.recordID = (select max(r.recordID) " +
                                 "from person r, teacher t " +
                                 "where r.recordID = t.recordID " +
                                 "and lower(r.firstName) = lower(@firstName) " +
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
        public string GetTheLastCreatedUsernameInformationFullName(string firstNameIn, string lastNameIn)
        {
            var theUsername = "";
            var theStudentID = "";
            var completeStudentInfo = "";

            string selectStatement =

               "select * " +
               "from person p, student s " +
               "where p.recordID = s.recordID " +
               "and p.recordID = (select max(r.recordID) " +
                                 "from person r , student s " +
                                 "where r.recordID = s.recordID " +
                                 "and lower(r.firstName) = lower(@firstName) " +
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

        /// <summary>
        /// Get the last created Username by first and last name for Student
        /// </summary>
        /// <param name="firstNameIn">first name</param>
        /// <param name="lastNameIn">last name</param>
        /// <returns>username</returns>
        public string GetTheLastCreatedUsernameByFirstAndLastNameForStudent(string firstNameIn, string lastNameIn)
        {
            var theUsername = "";
            string selectStatement =

                               "select * " +
               "from person p, student s " +
               "where p.recordID = s.recordID " +
               "and p.recordID = (select max(r.recordID) " +
                                 "from person r , student k " +
                                 "where r.recordID = k.recordID   " +
                                 "and  SUBSTRING (k.username,0, PATINDEX('%[0-9]%',k.username)) = concat( 's_', substring(lower(@firstName),1,1), lower(@lastName)) )";

            /*"select * " +
            "from person p, student s " +
            "where p.recordID = s.recordID " +
            "and p.recordID = (select max(r.recordID) " +
                              "from person r , student k " +
                              "where r.recordID = k.recordID " +
                              "and lower(r.firstName) = lower(@firstName) " +
                              "and lower(r.lastName) = lower(@lastName))  ";*/

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
        /// Updates teacher's info in the DB
        /// </summary>
        /// <param name="oldTeacher"></param>
        /// <param name="newTeacher"></param>
        /// <returns></returns>
        public bool UpdatePerson(Teacher oldTeacher, Teacher newTeacher)
        {
            int records = 0;
            string updatePersonStatement = "UPDATE person " +
                "SET lastName = @newLastName, firstName = @newFirstName, " +
                "birthday = @newBirthday, street = @newStreet, city = @newCity, " +
                "state = @newState, zip = @newZip, phoneNumber = @newPhone, sex = @newSex, " +
                "ssn = @newSSN " +
                "WHERE recordID = @oldRecordID AND " +
                "lastName = @oldLastName AND firstName = @oldFirstName AND birthday = @oldBirthday AND " +
                "street = @oldStreet AND city = @oldCity AND state = @oldState AND zip = @oldZip AND " +
                "phoneNumber = @oldPhone AND sex = @oldSex AND (ssn = @oldSSN OR ssn is null) ";
            string updateTeacherStatement = "UPDATE teacher " +
                "SET activeStatus = @newStatus " +
                "WHERE recordID = @oldRecordID " +
                "AND activeStatus = @oldStatus ";

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

                            updateCommand.Parameters.AddWithValue("@oldRecordID", oldTeacher.RecordId);
                            updateCommand.Parameters.AddWithValue("@newLastName", newTeacher.LastName);
                            updateCommand.Parameters.AddWithValue("@newFirstName", newTeacher.FirstName);
                            updateCommand.Parameters.AddWithValue("@newBirthday", newTeacher.DateOfBirth);
                            updateCommand.Parameters.AddWithValue("@newStreet", newTeacher.AddressStreet);
                            updateCommand.Parameters.AddWithValue("@newCity", newTeacher.City);
                            updateCommand.Parameters.AddWithValue("@newState", newTeacher.State);
                            updateCommand.Parameters.AddWithValue("@newZip", newTeacher.Zip);
                            updateCommand.Parameters.AddWithValue("@newPhone", newTeacher.Phone);
                            updateCommand.Parameters.AddWithValue("@newSex", newTeacher.Sex);
                            if (newTeacher.SSN is null)
                            {
                                updateCommand.Parameters.AddWithValue("@newSSN", DBNull.Value);
                            }
                            else
                            {
                                updateCommand.Parameters.AddWithValue("@newSSN", newTeacher.SSN);
                            }
                            updateCommand.Parameters.AddWithValue("@oldLastName", oldTeacher.LastName);
                            updateCommand.Parameters.AddWithValue("@oldFirstName", oldTeacher.FirstName);
                            updateCommand.Parameters.AddWithValue("@oldBirthday", oldTeacher.DateOfBirth);
                            updateCommand.Parameters.AddWithValue("@oldStreet", oldTeacher.AddressStreet);
                            updateCommand.Parameters.AddWithValue("@oldCity", oldTeacher.City);
                            updateCommand.Parameters.AddWithValue("@oldState", oldTeacher.State);
                            updateCommand.Parameters.AddWithValue("@oldZip", oldTeacher.Zip);
                            updateCommand.Parameters.AddWithValue("@oldPhone", oldTeacher.Phone);
                            updateCommand.Parameters.AddWithValue("@oldSex", oldTeacher.Sex);
                            if (oldTeacher.SSN is null)
                            {
                                updateCommand.Parameters.AddWithValue("@oldSSN", DBNull.Value);
                            }
                            else
                            {
                                updateCommand.Parameters.AddWithValue("@oldSSN", oldTeacher.SSN);
                            }

                            records = updateCommand.ExecuteNonQuery();
                            
                            if (records > 0)
                            {
                                records = 0;
                                using (SqlCommand updateCommand2 = new SqlCommand(updateTeacherStatement, connection))
                                {
                                    updateCommand2.Transaction = transaction;

                                    updateCommand2.Parameters.AddWithValue("@oldRecordID", oldTeacher.RecordId);
                                    updateCommand2.Parameters.AddWithValue("@newStatus", newTeacher.ActiveStatus);
                                    updateCommand2.Parameters.AddWithValue("@oldStatus", oldTeacher.ActiveStatus);

                                    records = updateCommand2.ExecuteNonQuery();
                                }
                            }
                            if (records > 0)
                            {
                                transaction.Commit();
                                return true;
                            } else { return false; }
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
