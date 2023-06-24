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
    public partial class TeacherAddAssignmentUserControl : UserControl
    {
        public TeacherAddAssignmentUserControl()
        {
            InitializeComponent();
            this.SetUpTypeComboBox();
        }

        private void SetUpTypeComboBox()
        {
            this.assignmentTypeComboBox.Items.Insert(0, "---Select---");
            this.assignmentTypeComboBox.Items.Insert(0, "Quiz");
            this.assignmentTypeComboBox.Items.Insert(0, "Test");
            this.assignmentTypeComboBox.Items.Insert(0, "Individual Project");
            this.assignmentTypeComboBox.Items.Insert(0, "Group Project");
            this.assignmentTypeComboBox.Items.Insert(0, "Discussion Post");
            this.assignmentTypeComboBox.Items.Insert(0, "Paper");
        }
    }
}
