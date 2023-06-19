using System;

namespace Gradebook.Model
{
    /// <summary>
    /// The Person model class
    /// </summary>
    public class Person
    {
        public int RecordId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressStreet { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public int ActiveStatus { get; set; }

        /// <summary>
        /// Returns person's full name.
        /// </summary>
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public string Sex { get; set; }

        public string SSN { get; set; }

        public string NewPassword { get; set; }

        public string Username { get; set; }

        public int StudentID { get; set; }

        /// <summary>
        /// Person constructor.
        /// </summary>
        public Person()
        {

        }

        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="lastName">last name of person</param>
        /// <param name="firstName">first name of person</param>
        /// <param name="dateofBirth">dob of person</param>
        /// <param name="addressStreet">street address of person</param>
        /// <param name="city">city of person</param>
        /// <param name="state">state of person</param>
        /// <param name="zip">zip code of person</param>
        /// <param name="phone">phone number of person</param>
        /// <param name="sex">sex of person</param>
        /// <param name="ssn">date of birth of person</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Person(string lastName, string firstName, DateTime dateofBirth, string addressStreet, string city, string state, string zip, string phone, string sex, string ssn, int activeStatus)
        {
            _ = lastName ?? throw new ArgumentNullException("Last name cannot be null");
            _ = firstName ?? throw new ArgumentNullException("First name cannot be null");
            _ = addressStreet ?? throw new ArgumentNullException("Street address cannot be null");
            _ = city ?? throw new ArgumentNullException("City cannot be null");
            _ = state ?? throw new ArgumentNullException("State cannot be null");
            _ = zip ?? throw new ArgumentNullException("Zip cannot be null");
            _ = phone ?? throw new ArgumentNullException("Phone number cannot be null");
            _ = sex ?? throw new ArgumentNullException("Gender cannot be null");
            _ = ssn ?? throw new ArgumentNullException("SSN number cannot be null");

            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirth = dateofBirth;
            this.AddressStreet = addressStreet;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.Sex = sex;
            this.SSN = ssn;
            this.ActiveStatus = activeStatus;
        }



        /// <summary>
        /// constructor without active status.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="dateofBirth"></param>
        /// <param name="addressStreet"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phone"></param>
        /// <param name="sex"></param>
        /// <param name="ssn"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Person(string lastName, string firstName, DateTime dateofBirth, string addressStreet, string city, string state, string zip, string phone, string sex, string ssn)
        {
            _ = lastName ?? throw new ArgumentNullException("Last name cannot be null");
            _ = firstName ?? throw new ArgumentNullException("First name cannot be null");
            _ = addressStreet ?? throw new ArgumentNullException("Street address cannot be null");
            _ = city ?? throw new ArgumentNullException("City cannot be null");
            _ = state ?? throw new ArgumentNullException("State cannot be null");
            _ = zip ?? throw new ArgumentNullException("Zip cannot be null");
            _ = phone ?? throw new ArgumentNullException("Phone number cannot be null");
            _ = sex ?? throw new ArgumentNullException("Gender cannot be null");
            _ = ssn ?? throw new ArgumentNullException("SSN number cannot be null");

            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirth = dateofBirth;
            this.AddressStreet = addressStreet;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.Sex = sex;
            this.SSN = ssn;
        }


        /// <summary>
        /// constructor to create student object for edit use
        /// </summary>
        /// <param name="recordID"></param>
        /// <param name="studentID"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="dateofBirth"></param>
        /// <param name="addressStreet"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phone"></param>
        /// <param name="sex"></param>
        /// <param name="ssn"></param>
        /// <param name="activeStatus"></param>
        /// <param name="username"></param>
        public Person(int recordID, int studentID, string lastName, string firstName, DateTime dateofBirth, string addressStreet, string city, string state, string zip, string phone, string sex, string ssn, int activeStatus, string username)
        {
            this.StudentID = studentID;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirth = dateofBirth;
            this.AddressStreet = addressStreet;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.Sex = sex;
            this.SSN = ssn;
            this.ActiveStatus = activeStatus;
            this.Username = username;
            this.RecordId = recordID;
        }


        /// <summary>
        /// constructor to create student object for password use
        /// </summary>
        /// <param name="recordID"></param>
        /// <param name="password"></param>
        public Person(int recordID, string password)
        {
            this.RecordId = recordID;
            this.NewPassword = password;
        }

    }
}