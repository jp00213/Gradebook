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

        public AssignmentController()
        {
            _assignmentDAL = new AssignmentDAL();
        }

        public Boolean AddNewAssignment(Assignment assignment)
        {
            return this._assignmentDAL.AddNewAssignment(assignment);
        }

        public List<Assignment> GetAssignmentsByCourseID(int courseID)
        {
            return this._assignmentDAL.GetAssignmentsByCourseID(courseID);
        }
    }
}
