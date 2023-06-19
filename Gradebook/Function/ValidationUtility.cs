using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Gradebook.Function
{
    /// <summary>
    /// This function to validate utility.
    /// </summary>
    public static class ValidationUtility
    {
        /// <summary>
        /// check if input has value
        /// </summary>
        /// <param name="stringIn"></param>
        /// <returns>boolean reflecting valid status</returns>
        public static bool IsPresent(string stringIn)
        {
            var theLength = stringIn.Length;

            if (theLength == 0) { return false; }
            else { return true; }
        }

        /// <summary>
        /// check if input has value more than 1 letter
        /// </summary>
        /// <param name="stringIn"></param>
        /// <returns>boolean reflecting valid status </returns>
        public static bool IsMoreThanOneLetters(string stringIn)
        {
            var theLength = stringIn.Length;

            if (theLength < 2) { return false; }
            else { return true; }

        }

        /// <summary>
        /// check if text input is valid datetime
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input date is before or today
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input date is after or today
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input is integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input is decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input is valid phone number, 10 DIGITS
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input is valid zip code
        /// </summary>
        /// <param name="zip"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input is valid SSN
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input is valid gender
        /// </summary>
        /// <param name="sex"></param>
        /// <returns>boolean reflecting valid status</returns>
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

        /// <summary>
        /// check if input is valid status
        /// </summary>
        /// <param name="status"></param>
        /// <returns>boolean reflecting valid status</returns>
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

    }
}
