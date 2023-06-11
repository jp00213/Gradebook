using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradebook.View
{
    public partial class AdministratorCourses : Form
    {
        public AdministratorCourses()
        {
            InitializeComponent();
        }

        private void AdministratorCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

    }
}
