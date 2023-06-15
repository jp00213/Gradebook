using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.Model
{
    /// <summary>
    /// The teacher model class
    /// </summary>
    public class Teacher : Person
    {
        public int TeacherID { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// Teacher constructor
        /// </summary>
        public Teacher() { }

        /// <summary>
        /// Overloaded Teacher constructor
        /// </summary>
        /// <param name="teacherID"></param>
        public Teacher(int teacherID)
        {
            TeacherID = teacherID;
        }
    }
}
