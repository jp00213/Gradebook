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

namespace Gradebook
{
    public partial class LoginForm : Form
    {
        private readonly AccountController _accountController;

        public LoginForm()
        {
            InitializeComponent();
            this._accountController = new AccountController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this._accountController.IsPasswordCorrect("username", "password")) {
                MessageBox.Show("Password correct");
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
