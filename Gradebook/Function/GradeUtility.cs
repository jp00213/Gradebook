using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.Function
{
    /// <summary>
    /// This function to validate grade utility.
    /// </summary>
    public class GradeUtility
    {
        /// <summary>
        /// convert into alphabet grade
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static string ConvertIntoAlphabetGrade(Decimal score)
        {
            String grade = "";

            if (score >= 90 & score <= 100) grade = "A";
            else if (score >= 80 & score < 90) grade = "B";
            else if (score >= 70 & score < 80) grade = "C";
            else if (score >= 60 & score < 70) grade = "D";
            else if (score >= 0 & score < 60) grade = "F";
            else grade = "U";  // unclassified



            return grade;
        }
    }
}
