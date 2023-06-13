﻿using Gradebook.Function;

namespace GradebookTest.Function
{
    public class ValidationUtilityTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void ShouldReturnTrueIfPresentAndFalseNotPresent()
        {
            var testValue1 = ValidationUtility.IsPresent("A");
            Assert.That(testValue1, Is.EqualTo(true));

            var testValue2 = ValidationUtility.IsPresent("ABC");
            Assert.That(testValue2, Is.EqualTo(true));

            var testValue3 = ValidationUtility.IsPresent("");
            Assert.That(testValue3, Is.EqualTo(false));
        }


        [Test]
        public void ShouldReturnTrueIfMoreThan2LettersAndFalseOtherwise()
        {
            var testValue1 = ValidationUtility.IsMoreThanOneLetters("");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsMoreThanOneLetters("A");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsMoreThanOneLetters("ABC");
            Assert.That(testValue3, Is.EqualTo(true));

            var testValue4 = ValidationUtility.IsMoreThanOneLetters("AB");
            Assert.That(testValue4, Is.EqualTo(true));
        }


        // date format (mm/dd/yyyy) or (yyyy/mm/dd)
        [Test]
        public void ShouldReturnTrueIfDateIsValidOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsDateTime("01/01/2023");
            Assert.That(testValue1, Is.EqualTo(true));

            var testValue2 = ValidationUtility.IsDateTime("13/13/2023");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsDateTime("13/1/9999");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsDateTime("1/89/9999");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsDateTime("12/31/1950");
            Assert.That(testValue5, Is.EqualTo(true));

            var testValue6 = ValidationUtility.IsDateTime("1950/31/5");
            Assert.That(testValue6, Is.EqualTo(false));

            var testValue7 = ValidationUtility.IsDateTime("1950/5/15");
            Assert.That(testValue7, Is.EqualTo(true));
        }


        [Test]
        public void ShouldReturnTrueIfDateIsBeforeOrTodayOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsDateBeforeOrToday("01/01/2023");
            Assert.That(testValue1, Is.EqualTo(true));

            var testValue2 = ValidationUtility.IsDateBeforeOrToday("01/12/1999");
            Assert.That(testValue2, Is.EqualTo(true));

            var testValue3 = ValidationUtility.IsDateBeforeOrToday("05/13/2055");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsDateBeforeOrToday("05/13/2030");
            Assert.That(testValue4, Is.EqualTo(false));

            var todayDateString = DateTime.Now.ToString("MM/dd/yyyy");

            var testValue5 = ValidationUtility.IsDateBeforeOrToday(todayDateString);
            Assert.That(testValue5, Is.EqualTo(true));
        }


        [Test]
        public void ShouldReturnTrueIfDateIsAfterOrTodayOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsDateAfterOrToday("01/01/2023");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsDateAfterOrToday("05/21/2017");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsDateAfterOrToday("12/13/2055");
            Assert.That(testValue3, Is.EqualTo(true));

            var todayDateString = DateTime.Now.ToString("MM/dd/yyyy");

            var testValue4 = ValidationUtility.IsDateAfterOrToday(todayDateString);
            Assert.That(testValue4, Is.EqualTo(true));

            var testValue5 = ValidationUtility.IsDateAfterOrToday("08/23/2080");
            Assert.That(testValue5, Is.EqualTo(true));
        }


        [Test]
        public void ShouldReturnTrueIfIntegerOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsInt32("1");
            Assert.That(testValue1, Is.EqualTo(true));

            var testValue2 = ValidationUtility.IsInt32("189");
            Assert.That(testValue2, Is.EqualTo(true));

            var testValue3 = ValidationUtility.IsInt32("");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsInt32("A");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsInt32("1A2B3C");
            Assert.That(testValue5, Is.EqualTo(false));

            var testValue6 = ValidationUtility.IsInt32("0");
            Assert.That(testValue6, Is.EqualTo(true));
        }


        [Test]
        public void ShouldReturnTrueIfDecimalOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsDecimal("1");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsDecimal("1.1.1");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsDecimal("A");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsDecimal("");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsDecimal("1A2B.00");
            Assert.That(testValue5, Is.EqualTo(false));

            var testValue6 = ValidationUtility.IsDecimal("1.00");
            Assert.That(testValue6, Is.EqualTo(true));

            var testValue7 = ValidationUtility.IsDecimal("81.89");
            Assert.That(testValue7, Is.EqualTo(true));

            var testValue8 = ValidationUtility.IsDecimal(".89");
            Assert.That(testValue8, Is.EqualTo(true));

            var testValue9 = ValidationUtility.IsDecimal("1234.8");
            Assert.That(testValue9, Is.EqualTo(true));

            var testValue10 = ValidationUtility.IsDecimal("1234.");
            Assert.That(testValue10, Is.EqualTo(true));
        }


        [Test]
        public void ShouldReturnTrueIfPhoneNumberIsValidOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsPhoneNumber("ABC");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsPhoneNumber("ABCDEFGHIJ");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsPhoneNumber("1");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsPhoneNumber("12345");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsPhoneNumber("12345678");
            Assert.That(testValue5, Is.EqualTo(false));

            var testValue6 = ValidationUtility.IsPhoneNumber("1234567890");
            Assert.That(testValue6, Is.EqualTo(true));

            var testValue7 = ValidationUtility.IsPhoneNumber("123.456.7890");
            Assert.That(testValue7, Is.EqualTo(true));

            var testValue8 = ValidationUtility.IsPhoneNumber("123-456-7890");
            Assert.That(testValue8, Is.EqualTo(true));

            var testValue9 = ValidationUtility.IsPhoneNumber("123-456.7890");
            Assert.That(testValue9, Is.EqualTo(true));

            var testValue10 = ValidationUtility.IsPhoneNumber("123.456-7890");
            Assert.That(testValue10, Is.EqualTo(true));
        }
    }
}