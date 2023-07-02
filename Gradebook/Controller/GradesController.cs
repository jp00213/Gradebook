using Gradebook.DAL;
using Gradebook.Model;
using System.Collections.Generic;

namespace Gradebook.Controller
{
    /// <summary>
    /// The grades controller
    /// </summary>
    public class GradesController
    {
        private readonly GradeDAL _gradeDAL;

        /// <summary>
        /// Grades Controller constructor
        /// </summary>
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

        /// <summary>
        /// Adds grades to db
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <param name="studentID"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool AddGrade(int assignmentID, int studentID, int score)
        {
            return this._gradeDAL.AddGrade(assignmentID, studentID, score);
        }

        /// <summary>
        /// Returns a list of all grades
        /// </summary>
        /// <returns></returns>
        public List<Grades> GetAllGrades()
        {
            return this._gradeDAL.GetAllGrades();
        }

    }
}
