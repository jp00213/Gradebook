using Gradebook.Model;

namespace GradebookTest.Model
{
    public class AssignmentConstructor
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreateAssignment()
        {
            var testAssignment = new Assignment(32, 3, "This is a test", 10);

            Assert.That(testAssignment.AssignmentID, Is.EqualTo(32));
            Assert.That(testAssignment.CourseID, Is.EqualTo(3));
            Assert.That(testAssignment.Description, Is.EqualTo("This is a test"));
            Assert.That(testAssignment.Weight, Is.EqualTo(10));
        }

        [Test]
        public void ShouldCreateAlternateAssignment()
        {
            var testAssignment = new Assignment
            {
                AssignmentID = 32,
                CourseID = 3,
                Description = "This is a test",
                Weight = 10
            };

            Assert.That(testAssignment.AssignmentID, Is.EqualTo(32));
            Assert.That(testAssignment.CourseID, Is.EqualTo(3));
            Assert.That(testAssignment.Description, Is.EqualTo("This is a test"));
            Assert.That(testAssignment.Weight, Is.EqualTo(10));
        }

        [Test]
        public void ShouldCreatePartiallyFullAssignment()
        {
            var testAssignment = new Assignment(3, "This is a test", 10);

            Assert.That(testAssignment.AssignmentID, Is.EqualTo(0));
            Assert.That(testAssignment.CourseID, Is.EqualTo(3));
            Assert.That(testAssignment.Description, Is.EqualTo("This is a test"));
            Assert.That(testAssignment.Weight, Is.EqualTo(10));
        }
    }
}
