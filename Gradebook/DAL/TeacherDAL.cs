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
    /// THe DAL that interacts with the DB for the Teacher objects
    /// </summary>
    public class TeacherDAL
    {
        /// <summary>
        /// Gets all the teachers from the db based on params
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dob"></param>
        /// <returns>A list of teachers based on name and dob</returns>
        public List<Teacher> GetTeacherByNameDOB(string firstName, string lastName, DateTime dob)
        {
            List<Teacher> teachers = new List<Teacher>();
            Teacher teacher = new Teacher();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM Teacher te " +
                "JOIN person pe " +
                "ON te.recordID = pe.recordID " +
                "WHERE pe.firstName like @firstName " +
                "AND pe.lastName like @lastName " +
                "AND pe.birthday = @dob";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@firstName"].Value = firstName + "%";

            selectCommand.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@lastName"].Value = lastName + "%";

            selectCommand.Parameters.Add("@dob", System.Data.SqlDbType.Date);
            selectCommand.Parameters["@dob"].Value = dob;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teacher = new Teacher
                        {
                            RecordId = (int)(reader)["recordID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            AddressStreet = (string)(reader)["addressStreet"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            Phone = (string)(reader)["phoneNumber"],
                            TeacherID = (int)(reader)["teacherID"],
                            Sex = (string)(reader)["sex"],
                            SSN = (string)(reader)["ssn"],
                            Status = (string)(reader)["activeStatus"]
                        };
                        teachers.Add(teacher);
                    }
                }
            }
            return teachers;
        }

        /// <summary>
        /// Gets all teachers
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dob"></param>
        /// <returns>A list of teachers based on name and dob</returns>
        public List<Teacher> GetAllActiveTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            Teacher teacher = new Teacher();

            SqlConnection connection = GradebookDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM Teacher te " +
                "JOIN person pe " +
                "ON te.recordID = pe.recordID " +
                "WHERE activeStatus = 1";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teacher = new Teacher
                        {
                            RecordId = (int)(reader)["recordID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            AddressStreet = (string)(reader)["street"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            Phone = (string)(reader)["phoneNumber"],
                            TeacherID = (int)(reader)["teacherID"],
                            Sex = (string)(reader)["sex"],
                            SSN = (reader)["ssn"] as string
                        };
                        teachers.Add(teacher);
                    }
                }
            }
            return teachers;
        }

    }
}
