using Gradebook.Controller;
using Gradebook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradebook.UserControls
{
    public partial class StudentCourseSummaryUserControl : UserControl
    {
        /// <summary>
        /// This class manages usercontrol for viewing student course information
        /// </summary>
        private readonly StudentController _studentController;

        /// <summary>
        /// create constructors
        /// </summary>
        public StudentCourseSummaryUserControl()
        {
            InitializeComponent();
            this._studentController = new StudentController();
        }

        /// <summary>
        /// set username
        /// </summary>
        /// <param name="username"></param>
        public void SetUserName(string username)
        {
            this.SetCurrentStudentID(username);
        }

        /// <summary>
        /// set current student ID
        /// </summary>
        /// <param name="username"></param>
        public void SetCurrentStudentID(string username)
        {
            Person person = new Person();
            person = this._studentController.GetStudentByUsername(username);
            String name = person.FirstName + ' ' + person.LastName;
            int studentID = person.StudentID;
            this.currentStudentID.Text = studentID.ToString();
            this.nameLabel.Text = name.ToString();
        }
    }
}
