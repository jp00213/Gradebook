using Gradebook.Function;

namespace GradebookTest.Function
{
    public class CreateNewPersonUsernameTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void ShouldThrowsExceptionWhenNameIsNotCompleted()
        {
            var exception1 = Assert.Throws<ArgumentNullException>(() => CreatePersonUserName.CreateNewPersonUsername("peter", "", ""));
            Assert.That(exception1.ParamName, Is.EqualTo("Must enter both first and last name."));

            var exception2 = Assert.Throws<ArgumentNullException>(() => CreatePersonUserName.CreateNewPersonUsername("peter", null, ""));
            Assert.That(exception2.ParamName, Is.EqualTo("Must enter both first and last name."));

            var exception3 = Assert.Throws<ArgumentNullException>(() => CreatePersonUserName.CreateNewPersonUsername("", "pan", ""));
            Assert.That(exception3.ParamName, Is.EqualTo("Must enter both first and last name."));

            var exception4 = Assert.Throws<ArgumentNullException>(() => CreatePersonUserName.CreateNewPersonUsername(null, "pan", ""));
            Assert.That(exception4.ParamName, Is.EqualTo("Must enter both first and last name."));

            var exception5 = Assert.Throws<ArgumentNullException>(() => CreatePersonUserName.CreateNewPersonUsername(null, null, ""));
            Assert.That(exception5.ParamName, Is.EqualTo("Must enter both first and last name."));

            var exception6 = Assert.Throws<ArgumentNullException>(() => CreatePersonUserName.CreateNewPersonUsername(null, null, null));
            Assert.That(exception6.ParamName, Is.EqualTo("Must enter both first and last name."));
        }


        [Test]
        public void ShouldCreateUserNameIfNoOneElseHasSameFirstAndLastName()
        {
            var userName = CreatePersonUserName.CreateNewPersonUsername("peter", "pan", "");
            Assert.That(userName, Is.EqualTo("ppan1"));
        }


        [Test]
        public void ShouldCreateUserNameAdd1IfFoundSamePrefixUsername1()
        {
            var userName = CreatePersonUserName.CreateNewPersonUsername("peter", "pan", "ppan1");
            Assert.That(userName, Is.EqualTo("ppan2"));
        }


        [Test]
        public void ShouldCreateUserNameAdd1IfFoundSamePrefixUsername11()
        {
            var userName = CreatePersonUserName.CreateNewPersonUsername("peter", "pan", "ppan11");
            Assert.That(userName, Is.EqualTo("ppan12"));
        }


        [Test]
        public void ShouldCreateUserNameAdd1IfFoundSamePrefixUsername188()
        {
            var userName = CreatePersonUserName.CreateNewPersonUsername("peter", "pan", "ppan188");
            Assert.That(userName, Is.EqualTo("ppan189"));
        }


        [Test]
        public void ShouldCreateUserNameAdd1IfFoundSamePrefixUsername2345()
        {
            var userName = CreatePersonUserName.CreateNewPersonUsername("peter", "pan", "ppan2345");
            Assert.That(userName, Is.EqualTo("ppan2346"));
        }

        [Test]
        public void ShouldCreateUserNameAdd1IfFoundSamePrefixUsername255()
        {
            var userName = CreatePersonUserName.CreateNewPersonUsername("Mary", "Lee", "mlee255");
            Assert.That(userName, Is.EqualTo("mlee256"));
        }
    }
}
