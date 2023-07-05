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
        public void CanonvertIntoAalphabetGrade()
        {
            String value1 = GradeUtility.ConvertIntoAalphabetGrade(98.88);
            Assert.That(value1, Is.EqualTo("A"));

            String value2 = GradeUtility.ConvertIntoAalphabetGrade(91);
            Assert.That(value2, Is.EqualTo("A"));

            String value3 = GradeUtility.ConvertIntoAalphabetGrade(83);
            Assert.That(value3, Is.EqualTo("B"));

            String value4 = GradeUtility.ConvertIntoAalphabetGrade(80);
            Assert.That(value4, Is.EqualTo("B"));

            String value5 = GradeUtility.ConvertIntoAalphabetGrade(79.111);
            Assert.That(value5, Is.EqualTo("C"));

            String value6 = GradeUtility.ConvertIntoAalphabetGrade(75);
            Assert.That(value6, Is.EqualTo("C"));

            String value7 = GradeUtility.ConvertIntoAalphabetGrade(70);
            Assert.That(value7, Is.EqualTo("C"));

            String value8 = GradeUtility.ConvertIntoAalphabetGrade(68.33);
            Assert.That(value8, Is.EqualTo("D"));

            String value9 = GradeUtility.ConvertIntoAalphabetGrade(65);
            Assert.That(value9, Is.EqualTo("D"));

            String value10 = GradeUtility.ConvertIntoAalphabetGrade(50.22);
            Assert.That(value10, Is.EqualTo("E"));

            String value11 = GradeUtility.ConvertIntoAalphabetGrade(-2);
            Assert.That(value11, Is.EqualTo("U"));

        }
    }
}
