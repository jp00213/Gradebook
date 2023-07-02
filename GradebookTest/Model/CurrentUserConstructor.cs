using Gradebook.Model;


namespace GradebookTest.Model
{
    public class CurrentUserConstructor
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void ShouldCreateCurrentUser()
        {
            CurrentUser user = new CurrentUser();
            user.userName = "MyUserNameIsAdmin";

            Assert.That(user.userName, Is.EqualTo("MyUserNameIsAdmin"));

        }

    }
}

