using Gradebook.Function;

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
            var testValue1 = ValidationUtility.IsValidPhoneNumber("ABC");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsValidPhoneNumber("ABCDEFGHIJ");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsValidPhoneNumber("1");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsValidPhoneNumber("12345");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsValidPhoneNumber("12345678");
            Assert.That(testValue5, Is.EqualTo(false));

            var testValue6 = ValidationUtility.IsValidPhoneNumber("1234567890");
            Assert.That(testValue6, Is.EqualTo(true));

            var testValue7 = ValidationUtility.IsValidPhoneNumber("123.456.7890");
            Assert.That(testValue7, Is.EqualTo(false));

            var testValue8 = ValidationUtility.IsValidPhoneNumber("123-456-7890");
            Assert.That(testValue8, Is.EqualTo(false));

            var testValue9 = ValidationUtility.IsValidPhoneNumber("123-456.7890");
            Assert.That(testValue9, Is.EqualTo(false));

            var testValue10 = ValidationUtility.IsValidPhoneNumber("123.456-7890");
            Assert.That(testValue10, Is.EqualTo(false));
        }


        [Test]
        public void ShouldReturnTrueIfZipIsValidOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsValidZipCode("123");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsValidZipCode("1234");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsValidZipCode("ABC");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsValidZipCode("ABCDE");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsValidZipCode("12345");
            Assert.That(testValue5, Is.EqualTo(true));

            var testValue6 = ValidationUtility.IsValidZipCode("99999");
            Assert.That(testValue6, Is.EqualTo(true));

            var testValue7 = ValidationUtility.IsValidZipCode("50000");
            Assert.That(testValue7, Is.EqualTo(true));

            var testValue8 = ValidationUtility.IsValidZipCode("72378");
            Assert.That(testValue8, Is.EqualTo(true));
        }


        [Test]
        public void ShouldReturnTrueIfSSNIsValidOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsSSNValid("123");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsSSNValid("1234");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsSSNValid("12345678");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsSSNValid("123abcd");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsSSNValid("123456789");
            Assert.That(testValue5, Is.EqualTo(true));

            var testValue6 = ValidationUtility.IsSSNValid("222222222");
            Assert.That(testValue6, Is.EqualTo(true));

            var testValue7 = ValidationUtility.IsSSNValid("333114444");
            Assert.That(testValue7, Is.EqualTo(true));

            var testValue8 = ValidationUtility.IsSSNValid("333224444");
            Assert.That(testValue8, Is.EqualTo(true));
        }


        [Test]
        public void ShouldReturnTrueIfGenderIsValidOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsGenderValid("123");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsGenderValid("A");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsGenderValid("B");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsGenderValid("Cde");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsGenderValid("");
            Assert.That(testValue5, Is.EqualTo(false));

            var testValue6 = ValidationUtility.IsGenderValid("M");
            Assert.That(testValue6, Is.EqualTo(true));

            var testValue7 = ValidationUtility.IsGenderValid("F");
            Assert.That(testValue7, Is.EqualTo(true));
        }


        [Test]
        public void ShouldReturnTrueIfStatusIsValidOtherwiseFalse()
        {
            var testValue1 = ValidationUtility.IsStatusValid("123");
            Assert.That(testValue1, Is.EqualTo(false));

            var testValue2 = ValidationUtility.IsStatusValid("A");
            Assert.That(testValue2, Is.EqualTo(false));

            var testValue3 = ValidationUtility.IsStatusValid("B");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsStatusValid("Cde");
            Assert.That(testValue4, Is.EqualTo(false));

            var testValue5 = ValidationUtility.IsStatusValid("");
            Assert.That(testValue5, Is.EqualTo(false));

            var testValue6 = ValidationUtility.IsStatusValid("Active");
            Assert.That(testValue6, Is.EqualTo(true));

            var testValue7 = ValidationUtility.IsStatusValid("Disable");
            Assert.That(testValue7, Is.EqualTo(true));
        }

        [Test]
        public void ShouldReturnTrueIfBetweenNumberOfCharacters()
        {
            var testValue1 = ValidationUtility.IsBetweenNumberOfCharacters(2, 5, "abc");
            Assert.That(testValue1, Is.EqualTo(true));

            var testValue2 = ValidationUtility.IsBetweenNumberOfCharacters(2, 5, "abcde");
            Assert.That(testValue2, Is.EqualTo(true));

            var testValue3 = ValidationUtility.IsBetweenNumberOfCharacters(2, 5, "a");
            Assert.That(testValue3, Is.EqualTo(false));

            var testValue4 = ValidationUtility.IsBetweenNumberOfCharacters(1, 5, "a");
            Assert.That(testValue4, Is.EqualTo(true));
        }

    }
}
