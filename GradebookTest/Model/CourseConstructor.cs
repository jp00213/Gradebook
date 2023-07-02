using Gradebook.Model;

namespace GradebookTest.Model
{
    public class CourseConstructor
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreateCourse()
        {
            var testCourse = new Course
            {
                Name = "Test Name",
                Prefix = "EDU",
                Number = "1234",
                Section = 23,
                CreditHours = 3,
                Semester = "summer",
                Year = 2023
            };

            Assert.That(testCourse.Name, Is.EqualTo("Test Name"));
            Assert.That(testCourse.Prefix, Is.EqualTo("EDU"));
            Assert.That(testCourse.Number, Is.EqualTo("1234"));
            Assert.That(testCourse.Section, Is.EqualTo(23));
            Assert.That(testCourse.CreditHours, Is.EqualTo(3));
            Assert.That(testCourse.Semester, Is.EqualTo("summer"));
            Assert.That(testCourse.Year, Is.EqualTo(2023));
            Assert.That(testCourse.TeacherID, Is.EqualTo(0));

            testCourse.TeacherID = 29;
            Assert.That(testCourse.TeacherID, Is.EqualTo(29));
        }

        [Test]
        public void ShouldCreateCourseWithStudentInformation()
        {
            var testCourse = new Course
            {
                Name = "Test Name",
                Prefix = "EDU",
                Number = "1234",
                Section = 23,
                CreditHours = 3,
                Semester = "summer",
                Year = 2023,
                StudentID = 123,
                TeacherFullName = "Amy Lee",
                StudentFullName = "John Frank",
                StudentCount = 321
            };

            Assert.That(testCourse.StudentID, Is.EqualTo(123));
            Assert.That(testCourse.TeacherFullName, Is.EqualTo("Amy Lee"));
            Assert.That(testCourse.StudentFullName, Is.EqualTo("John Frank"));
            Assert.That(testCourse.StudentCount, Is.EqualTo(321));



        }

    }
}
