using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gradebook.Function
{
    /// <summary>
    /// This function to validate utility.
    /// </summary>
    public static class ValidationUtility
    {
        // check if input has value
        public static bool IsPresent(string stringIn)
        {
            var theLength = stringIn.Length;

            if (theLength == 0) { return false; }
            else { return true; }
        }

        // check if input has value more than 1 letter
        public static bool IsMoreThanOneLetters(string stringIn)
        {
            var theLength = stringIn.Length;

            if (theLength < 2) { return false; }
            else { return true; }

        }

        // check if text input is valid datetime
        public static bool IsDateTime(string input)
        {
            DateTime dateTime;
            bool isDateTime = false;

            // Check for empty string
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            isDateTime = DateTime.TryParse(input, out dateTime);

            return isDateTime;
        }

        // check if input date is before or today
        public static bool IsDateBeforeOrToday(string input)
        {
            var parameterDate = DateTime.ParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var todaysDate = DateTime.Today;

            if (parameterDate <= todaysDate)
            {
                return true;
            }
            else { return false; };
        }

        // check if input date is after or today
        public static bool IsDateAfterOrToday(string input)
        {
            DateTime pDate;
            if (!DateTime.TryParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out pDate))
            {
                // option Invalid date
                //option log , show error
                return false;
            }
            return pDate >= DateTime.Today;
        }

        // check if input is integer
        public static bool IsInt32(string input)
        {
            var theValue = IsPresent(input);

            if (theValue == false) { return false; }

            else
            {
                try
                {
                    Convert.ToInt32(input);
                    return true;
                }
                catch (FormatException)
                {

                    return false;
                }
            }
        }

        // check if input is decimal
        public static bool IsDecimal(string input)
        {
            string inputString = input;

            List<char> charsToCheckFor = new List<char>() { '.' };

            int charCount = inputString.Count(x => charsToCheckFor.Contains(x));

            if (charCount != 1)
            {
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDecimal(input);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
        }

        // check if input is valid phone number, 10 DIGITS
        public static bool IsValidPhoneNumber(string input)
        {
            string phoneRegEx = @"^\d{10}$";
            bool validPhoneNumber = true;
            if (!Regex.Match(input, phoneRegEx).Success)
            {
                validPhoneNumber = false;
            }
            return validPhoneNumber;
        }

        // check if input is valid zip code
        public static bool IsValidZipCode(string zip)
        {
            string usZipRegEx = @"^\d{5}(\d{4})?$";

            bool validZipCode = true;
            if ((!Regex.Match(zip, usZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }

        // check if input is valid SSN
        public static bool IsSSNValid(string ssn)
        {
            string ssnRegEx = @"^[0-9]{9}$";
            bool validSSN = true;
            if (ssn.Equals(""))
            {
                validSSN = true;
            }
            else if (!Regex.Match(ssn, ssnRegEx).Success)
            {
                validSSN = false;
            }
            return validSSN;
        }

        // check if input is valid gender
        public static bool IsGenderValid(string sex)
        {
            bool validSex = true;
            if (String.Equals(sex, "M") || String.Equals(sex, "F"))
            {
                validSex = true;
            }
            else
            {
                validSex = false;
            }
            return validSex;
        }

        // check if input is valid status
        public static bool IsStatusValid(string status)
        {
            bool validData = true;
            if (String.Equals(status, "Active") || String.Equals(status, "Disable"))
            {
                validData = true;
            }
            else
            {
                validData = false;
            }
            return validData;
        }

        /// <summary>
        /// Tests if string has more than starting characters and less than ending characters (inclusive)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="testString"></param>
        /// <returns></returns>
        public static bool IsBetweenNumberOfCharacters(int start, int end, string testString)
        {
            bool validData = true;
            if (testString.Length > end || testString.Length < start)
            {
                validData = false;
            } 
            return validData;
        }
    }
}
