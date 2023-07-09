using Gradebook.Model;
using System;


namespace GradebookTest.Model
{
    public class GradesConstructor
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void ShouldCreateGradeObject()
        {

            Grades grades = new Grades();
            grades.StudentID = 123;
            grades.CourseID = 555;
            grades.AssignmentID = 5454;
            grades.Description = "Rocket Science 101";
            grades.Weight = "10.55";
            grades.Score = "5";
            grades.WeightGrade = "95.35";
            grades.StudentName = "Peter Pan";
            grades.Grade_1 = "11";
            grades.Grade_2 = "22";
            grades.Grade_3 = "33";
            grades.Grade_4 = "44";
            grades.Grade_5 = "55";
            grades.Grade_6 = "66";
            grades.Grade_7 = "77";
            grades.Grade_8 = "88";
            grades.Grade_9 = "99";
            grades.Grade_10 = "111";
            grades.Grade_11 = "222";
            grades.Grade_12 = "333";
            grades.Grade_13 = "444";
            grades.Grade_14 = "555";
            grades.Grade_15 = "666";
            grades.Semester = "Spring";
            grades.Year = 2055;
            grades.Units = 12;
            grades.Section = 11;
            grades.Prefix_number = "12345678";
            grades.GradePoints = 12;
            grades.GPA = "3.33";
            grades.Column1 = "A";
            grades.Column2 = "B";
            grades.Column3 = "C";
            grades.Column4 = "D";
            grades.Column5 = "E";
            grades.Column6 = "F";

            Assert.That(grades.StudentID, Is.EqualTo(123));
            Assert.That(grades.CourseID, Is.EqualTo(555));
            Assert.That(grades.AssignmentID, Is.EqualTo(5454));
            Assert.That(grades.Description, Is.EqualTo("Rocket Science 101"));
            Assert.That(grades.Weight, Is.EqualTo("10.55"));
            Assert.That(grades.Score, Is.EqualTo("5"));
            Assert.That(grades.WeightGrade, Is.EqualTo("95.35"));
            Assert.That(grades.StudentName, Is.EqualTo("Peter Pan"));
            Assert.That(grades.Grade_1, Is.EqualTo("11"));
            Assert.That(grades.Grade_2, Is.EqualTo("22"));
            Assert.That(grades.Grade_3, Is.EqualTo("33"));
            Assert.That(grades.Grade_4, Is.EqualTo("44"));
            Assert.That(grades.Grade_5, Is.EqualTo("55"));
            Assert.That(grades.Grade_6, Is.EqualTo("66"));
            Assert.That(grades.Grade_7, Is.EqualTo("77"));
            Assert.That(grades.Grade_8, Is.EqualTo("88"));
            Assert.That(grades.Grade_9, Is.EqualTo("99"));
            Assert.That(grades.Grade_10, Is.EqualTo("111"));
            Assert.That(grades.Grade_11, Is.EqualTo("222"));
            Assert.That(grades.Grade_12, Is.EqualTo("333"));
            Assert.That(grades.Grade_13, Is.EqualTo("444"));
            Assert.That(grades.Grade_14, Is.EqualTo("555"));
            Assert.That(grades.Grade_15, Is.EqualTo("666"));

            Assert.That(grades.Semester, Is.EqualTo("Spring"));
            Assert.That(grades.Year, Is.EqualTo(2055));
            Assert.That(grades.Units, Is.EqualTo(12));
            Assert.That(grades.Section, Is.EqualTo(11));
            Assert.That(grades.Prefix_number, Is.EqualTo("12345678"));
            Assert.That(grades.GradePoints, Is.EqualTo(12));
            Assert.That(grades.GPA, Is.EqualTo("3.33"));
            Assert.That(grades.Column1, Is.EqualTo("A"));
            Assert.That(grades.Column2, Is.EqualTo("B"));
            Assert.That(grades.Column3, Is.EqualTo("C"));
            Assert.That(grades.Column4, Is.EqualTo("D"));
            Assert.That(grades.Column5, Is.EqualTo("E"));
            Assert.That(grades.Column6, Is.EqualTo("F"));
        }
    }
}
