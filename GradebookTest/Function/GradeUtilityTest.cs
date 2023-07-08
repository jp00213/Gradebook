using Gradebook.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookTest.Function
{
    public class GradeUtilityTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void CanonvertIntoAlphabetGrade()
        {
            String value1 = GradeUtility.ConvertIntoAlphabetGrade(98);
            Assert.That(value1, Is.EqualTo("A"));

            String value2 = GradeUtility.ConvertIntoAlphabetGrade(91);
            Assert.That(value2, Is.EqualTo("A"));

            String value3 = GradeUtility.ConvertIntoAlphabetGrade(83);
            Assert.That(value3, Is.EqualTo("B"));

            String value4 = GradeUtility.ConvertIntoAlphabetGrade(80);
            Assert.That(value4, Is.EqualTo("B"));

            String value5 = GradeUtility.ConvertIntoAlphabetGrade(79);
            Assert.That(value5, Is.EqualTo("C"));

            String value6 = GradeUtility.ConvertIntoAlphabetGrade(75);
            Assert.That(value6, Is.EqualTo("C"));

            String value7 = GradeUtility.ConvertIntoAlphabetGrade(70);
            Assert.That(value7, Is.EqualTo("C"));

            String value8 = GradeUtility.ConvertIntoAlphabetGrade(68);
            Assert.That(value8, Is.EqualTo("D"));

            String value9 = GradeUtility.ConvertIntoAlphabetGrade(65);
            Assert.That(value9, Is.EqualTo("D"));

            String value10 = GradeUtility.ConvertIntoAlphabetGrade(50);
            Assert.That(value10, Is.EqualTo("E"));

            String value11 = GradeUtility.ConvertIntoAlphabetGrade(-2);
            Assert.That(value11, Is.EqualTo("U"));

        }
    }
}
