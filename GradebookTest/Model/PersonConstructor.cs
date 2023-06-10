using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookTest.Model
{
    public class PersonConstructor
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void ShouldCreatePersonWhenAllDataFilled()
        {
            var DateOfBirth = new DateTime(1999, 1, 15);
            var person = new Person("Pan", "Peter", DateOfBirth, "123 Happy St.", "Happy City", "CA", "91000", "2131101111", "M", "123456789");
            Assert.IsNotNull(person);
            Assert.That(person.FirstName, Is.EqualTo("Peter"));
            Assert.That(person.LastName, Is.EqualTo("Pan"));
            Assert.That(person.AddressStreet, Is.EqualTo("123 Happy St."));
            Assert.That(person.City, Is.EqualTo("Happy City"));
            Assert.That(person.State, Is.EqualTo("CA"));
            Assert.That(person.Zip, Is.EqualTo("91000"));
            Assert.That(person.Phone, Is.EqualTo("2131101111"));
            Assert.That(person.Sex, Is.EqualTo("M"));
            Assert.That(person.SSN, Is.EqualTo("123456789"));
            Assert.That(person.DateOfBirth, Is.EqualTo(DateOfBirth));
        }


        [Test]
        public void ShouldCreatePersonWhenAllDataFilled2()
        {
            var DateOfBirth = new DateTime(1999, 1, 15);

            Person person = new Person
            {
                LastName = "Pan",
                FirstName = "Peter",
                DateOfBirth = DateOfBirth,
                AddressStreet = "123 Happy St.",
                City = "Happy City",
                State = "CA",
                Zip = "91000",
                Phone = "2131101111",
                Sex = "M",
                SSN = "123456789"
            };

            Assert.That(person.FirstName, Is.EqualTo("Peter"));
            Assert.That(person.LastName, Is.EqualTo("Pan"));
            Assert.That(person.AddressStreet, Is.EqualTo("123 Happy St."));
            Assert.That(person.City, Is.EqualTo("Happy City"));
            Assert.That(person.State, Is.EqualTo("CA"));
            Assert.That(person.Zip, Is.EqualTo("91000"));
            Assert.That(person.Phone, Is.EqualTo("2131101111"));
            Assert.That(person.Sex, Is.EqualTo("M"));
            Assert.That(person.SSN, Is.EqualTo("123456789"));
            Assert.That(person.DateOfBirth, Is.EqualTo(DateOfBirth));

        }


        [Test]
        public void ShouldNotCreatePersonWhenMissingAnyParameters()
        {

            var DateOfBirth = new DateTime(1999, 1, 15);

            var exception1 = Assert.Throws<ArgumentNullException>(() => new Person(null, "Peter", DateOfBirth, "123 Happy St.", "Happy City", "CA", "91000", "2131101111", "M", "123456789"));
            Assert.That(exception1.ParamName, Is.EqualTo("Last name cannot be null"));

            var exception2 = Assert.Throws<ArgumentNullException>(() => new Person("Pan", null, DateOfBirth, "123 Happy St.", "Happy City", "CA", "91000", "2131101111", "M", "123456789"));
            Assert.That(exception2.ParamName, Is.EqualTo("First name cannot be null"));

            var exception4 = Assert.Throws<ArgumentNullException>(() => new Person("Pan", "Peter", DateOfBirth, null, "Happy City", "CA", "91000", "2131101111", "M", "123456789"));
            Assert.That(exception4.ParamName, Is.EqualTo("Street address cannot be null"));

            var exception5 = Assert.Throws<ArgumentNullException>(() => new Person("Pan", "Peter", DateOfBirth, "123 Happy St.", null, "CA", "91000", "2131101111", "M", "123456789"));
            Assert.That(exception5.ParamName, Is.EqualTo("City cannot be null"));

            var exception6 = Assert.Throws<ArgumentNullException>(() => new Person("Pan", "Peter", DateOfBirth, "123 Happy St.", "Happy City", null, "91000", "2131101111", "M", "123456789"));
            Assert.That(exception6.ParamName, Is.EqualTo("State cannot be null"));

            var exception7 = Assert.Throws<ArgumentNullException>(() => new Person("Pan", "Peter", DateOfBirth, "123 Happy St.", "Happy City", "CA", null, "2131101111", "M", "123456789"));
            Assert.That(exception7.ParamName, Is.EqualTo("Zip cannot be null"));

            var exception8 = Assert.Throws<ArgumentNullException>(() => new Person("Pan", "Peter", DateOfBirth, "123 Happy St.", "Happy City", "CA", "91000", null, "M", "123456789"));
            Assert.That(exception8.ParamName, Is.EqualTo("Phone number cannot be null"));

            var exception9 = Assert.Throws<ArgumentNullException>(() => new Person("Pan", "Peter", DateOfBirth, "123 Happy St.", "Happy City", "CA", "91000", "2131101111", null, "123456789"));
            Assert.That(exception9.ParamName, Is.EqualTo("Gender cannot be null"));

            var exception10 = Assert.Throws<ArgumentNullException>(() => new Person("Pan", "Peter", DateOfBirth, "123 Happy St.", "Happy City", "CA", "91000", "2131101111", "M", null));
            Assert.That(exception10.ParamName, Is.EqualTo("SSN number cannot be null"));


        }


        [Test]
        public void ShouldReturNameInRightFormat()
        {
            var DateOfBirth = new DateTime(1999, 1, 15);

            var person = new Person("Pan", "Peter", DateOfBirth, "123 Happy St.", "Happy City", "CA", "91000", "2131101111", "M", "123456789");

            Assert.That(person.FullName, Is.EqualTo("Peter Pan"));
        }
    }
}
