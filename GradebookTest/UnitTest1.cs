using Gradebook.Model;

namespace GradebookTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreatePersonWhenAllDataFilledA()
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
    }
}