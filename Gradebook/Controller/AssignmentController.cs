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
    /// The controller that interfaces with the assignment DAL
    /// </summary>
    public class AssignmentController
    {
        private readonly AssignmentDAL _assignmentDAL;

        /// <summary>
        /// The assignment controller constructor
        /// </summary>
        public AssignmentController()
        {
            _assignmentDAL = new AssignmentDAL();
        }

        /// <summary>
        /// Adds a new assignment to the DB
        /// </summary>
        /// <param name="assignment"></param>
        /// <returns></returns>
        public Boolean AddNewAssignment(Assignment assignment)
        {
            return this._assignmentDAL.AddNewAssignment(assignment);
        }

        /// <summary>
        /// Returns a list of assignments by courseID
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public List<Assignment> GetAssignmentsByCourseID(int courseID)
        {
            return this._assignmentDAL.GetAssignmentsByCourseID(courseID);
        }

        /// <summary>
        /// Returns list of assignments by assignment description
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public Assignment GetAssignmentByDescription(string description)
        {
            return this._assignmentDAL.GetAssignmentByDescription(description);
        }

        /// <summary>
        /// Updates assignment
        /// </summary>
        /// <param name="assignment"></param>
        /// <returns></returns>
        public Boolean UpdateAssignment(Assignment assignment)
        {
            return this._assignmentDAL.UpdateAssignment(assignment);
        }
    }
}
