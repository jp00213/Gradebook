using System;
using System.Linq;


namespace Gradebook.Function
{
    /// <summary>
    /// This function to auto create username.
    /// </summary>
    public static class CreatePersonUserName
    {
        /* first Peter Pan username = ppan1
           second Peter Pan username = ppan2
           third Peter Pan username = ppan3
        */
        public static string CreateNewPersonUsername(string firstName, string lastName, string existingUsernameWithMaximumSuffixNumber)
        {
            string newUsername = string.Empty;
            string firstNameInitial = string.Empty;
            string newSuffix = "1";


            if ((firstName == null) || (lastName == null) || (firstName == "") || (lastName == ""))
            {
                throw new ArgumentNullException("Must enter both first and last name.", "Missing name");
            }

            firstNameInitial = firstName.Substring(0, 1);


            if (existingUsernameWithMaximumSuffixNumber == null || existingUsernameWithMaximumSuffixNumber == "")
            {
                newUsername = firstNameInitial + lastName + newSuffix;
            }
            else
            {

                string currentMaximumSuffixForThisUsername = new String(existingUsernameWithMaximumSuffixNumber.Where(Char.IsDigit).ToArray());
                int tempNumber = Int32.Parse(currentMaximumSuffixForThisUsername);


                newSuffix = (tempNumber + 1).ToString();
                newUsername = firstNameInitial + lastName + newSuffix;

            }

            return newUsername.ToLower();
        }

        /* first Peter Pan username = S_ppan1
           second Peter Pan username = S_ppan2
           third Peter Pan username = S_ppan3
        */
        public static string CreateNewPersonUsernameStudent(string firstName, string lastName, string existingUsernameWithMaximumSuffixNumber)
        {
            string newUsername = string.Empty;
            string firstNameInitial = string.Empty;
            string newSuffix = "1";


            if ((firstName == null) || (lastName == null) || (firstName == "") || (lastName == ""))
            {
                throw new ArgumentNullException("Must enter both first and last name.", "Missing name");
            }

            firstNameInitial = firstName.Substring(0, 1);


            if (existingUsernameWithMaximumSuffixNumber == null || existingUsernameWithMaximumSuffixNumber == "")
            {
                newUsername = "S_" + firstNameInitial + lastName + newSuffix;
            }
            else
            {

                string currentMaximumSuffixForThisUsername = new String(existingUsernameWithMaximumSuffixNumber.Where(Char.IsDigit).ToArray());
                int tempNumber = Int32.Parse(currentMaximumSuffixForThisUsername);


                newSuffix = (tempNumber + 1).ToString();
                newUsername = "S_" + firstNameInitial + lastName + newSuffix;

            }

            return newUsername.ToLower();
        }


    }
}
