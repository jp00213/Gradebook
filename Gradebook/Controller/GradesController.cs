using Gradebook.DAL;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.Controller
{
    /// <summary>
    /// The grades controller
    /// </summary>
    public class GradesController
    {
        private readonly GradeDAL _gradeDAL;

        public GradesController()
        {
            this._gradeDAL = new GradeDAL();
        }

        /// <summary>
        /// Returns list of grade objects (with student name, id, and score) based 
        /// on courseID and assignmentID
        /// </summary>
        /// <param name="courseID"></param>
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public List<Grades> GetAssignmentGrades(int courseID, int assignmentID)
        {
            return this._gradeDAL.GetAssignmentGrades(courseID, assignmentID);
        }

        /// <summary>
        /// Updates a grade for a student in an assignment
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <param name="studentID"></param>
        /// <param name="score"></param>
        /// <param name="oldScore"></param>
        /// <returns></returns>
        public bool UpdateOneGrade(int assignmentID, int studentID, int score, int oldScore)
        {
            return this._gradeDAL.UpdateOneGrade(assignmentID, studentID, score, oldScore);
        }

        public bool AddGrade(int assignmentID, int studentID, int score)
        {
            return this._gradeDAL.AddGrade(assignmentID, studentID, score);
        }

        public List<Grades> GetAllGrades()
        {
            return this._gradeDAL.GetAllGrades();
        }

    }
}
