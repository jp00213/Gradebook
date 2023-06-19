using Gradebook.Controller;
using Gradebook.View;
using System;
using System.Windows.Forms;

namespace Gradebook
{
    /// <summary>
    /// Login Form for application
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly AccountController _accountController;

        /// <summary>
        /// Constructor for the Login Form
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this._accountController = new AccountController();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._accountController.IsPasswordCorrectAdministrator(this.usernameTextBox.Text, this.passwordTextBox.Text))
                {
                    this.Hide();
                    using (Form mainWindow = new AdministratorDashboard(this.usernameTextBox.Text))
                    {
                        DialogResult result = mainWindow.ShowDialog(this);
                    }
                } else if (this._accountController.IsPasswordCorrectTeacher(this.usernameTextBox.Text, this.passwordTextBox.Text))
                {
                    this.Hide();
                    using (Form mainWindow = new TeacherDashboard(this.usernameTextBox.Text))
                    {
                        DialogResult result = mainWindow.ShowDialog(this);
                    }
                }
                else if (this._accountController.IsPasswordCorrectStudent(this.usernameTextBox.Text, this.passwordTextBox.Text))
                {
                    this.Hide();
                    using (Form mainWindow = new StudentDashboard(this.usernameTextBox.Text))
                    {
                        DialogResult result = mainWindow.ShowDialog(this);
                    }
                }
                else { this.errorMessageLabel.Text = "Invalid username/password"; }
            }
            catch (ArgumentOutOfRangeException)
            {
                this.errorMessageLabel.Text = "Username/password can't be blank";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PressEnterToLogin(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                this.loginButton_Click(sender, e);
            }
        }

    }
}
