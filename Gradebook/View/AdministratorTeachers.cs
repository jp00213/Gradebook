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
    public partial class AdministratorTeachers : Form
    {
        public AdministratorTeachers()
        {
            InitializeComponent();
        }

        private void AdministratorTeachers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

    }
}
