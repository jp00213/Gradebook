using Gradebook.Model;


namespace GradebookTest.Model
{
    public class SearchItemsConstructor
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void ShouldCreateSearchItems()
        {
            SearchItem searchItem = new SearchItem();
            var DateOfBirth = new DateTime(1999, 1, 15);
            searchItem.idNumber = 1;
            searchItem.LastName = "ABC";
            searchItem.FirstName = "DEF";
            searchItem.DateOfBirth = DateOfBirth;
            searchItem.Username = "mynameispeter";
            searchItem.StudentID = 23456;
            searchItem.Semester = "Spring";
            searchItem.Year = "2015";
            searchItem.CourseID = 232323;

            Assert.That(searchItem.idNumber, Is.EqualTo(1));
            Assert.That(searchItem.LastName, Is.EqualTo("ABC"));
            Assert.That(searchItem.FirstName, Is.EqualTo("DEF"));
            Assert.That(searchItem.DateOfBirth, Is.EqualTo(DateOfBirth));
            Assert.That(searchItem.Username, Is.EqualTo("mynameispeter"));
            Assert.That(searchItem.StudentID, Is.EqualTo(23456));
            Assert.That(searchItem.Semester, Is.EqualTo("Spring"));
            Assert.That(searchItem.Year, Is.EqualTo("2015"));
            Assert.That(searchItem.CourseID, Is.EqualTo(232323));

        }
    }
}
