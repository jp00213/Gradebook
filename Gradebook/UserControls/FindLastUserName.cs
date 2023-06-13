using Gradebook.DAL;
using System;

using System.Windows.Forms;

namespace Gradebook.UserControls
{
    /// <summary>
    /// Find last username user control
    /// </summary>
    public partial class FindLastUserName : UserControl
    {
        private PersonDAL _personDAL;
        public FindLastUserName()
        {
            InitializeComponent();
            this._personDAL = new PersonDAL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theName = _personDAL.GetTheLastCreatedUsernameByFirstAndLastName(this.textBox1.Text, this.textBox2.Text);
            System.Windows.Forms.MessageBox.Show(theName);
            this.textBox3.Text = theName;

        }
    }
}
