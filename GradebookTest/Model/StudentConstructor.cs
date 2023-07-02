using Gradebook.Model;


namespace GradebookTest.Model
{
    public class StudentConstructor
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreateStudent()
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
    }
}
