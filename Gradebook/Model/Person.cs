using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Returns person's full name.
        /// </summary>
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public string Sex { get; set; }

        public string SSN { get; set; }

        /// <summary>
        /// Person constructor.
        /// </summary>
        public Person()
        {

        }

        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="lastName">record</param>
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
    }
}
