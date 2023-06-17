using Gradebook.Controller;
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
    public partial class AdministratorRegisterStudent : UserControl
    {
        private readonly CourseController _courseController;

        public AdministratorRegisterStudent()
        {
            InitializeComponent();
            this._courseController = new CourseController();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.courseDataGridView.DataSource = this._courseController.GetCoursesByYearSemester("Spring", 2023);
        }
    }
}
