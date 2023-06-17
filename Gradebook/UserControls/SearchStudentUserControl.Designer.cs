namespace Gradebook.UserControls
{
    partial class SearchStudentUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTitleLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dobTimePicker = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dob_Datepicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.studentListView = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.viewOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.editRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editRadioButton);
            this.panel1.Controls.Add(this.viewOnlyRadioButton);
            this.panel1.Controls.Add(this.ErrorMessageLabel);
            this.panel1.Controls.Add(this.studentListView);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.dob_Datepicker);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.studentIDTextBox);
            this.panel1.Controls.Add(this.dobTimePicker);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.studentIDLabel);
            this.panel1.Controls.Add(this.searchTitleLabel);
            this.panel1.Location = new System.Drawing.Point(30, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 269);
            this.panel1.TabIndex = 0;
            // 
            // searchTitleLabel
            // 
            this.searchTitleLabel.AutoSize = true;
            this.searchTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitleLabel.Location = new System.Drawing.Point(14, 4);
            this.searchTitleLabel.Name = "searchTitleLabel";
            this.searchTitleLabel.Size = new System.Drawing.Size(207, 20);
            this.searchTitleLabel.TabIndex = 0;
            this.searchTitleLabel.Text = "Search and Edit Student";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(14, 38);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIDLabel.TabIndex = 3;
            this.studentIDLabel.Text = "Student ID";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(120, 38);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(226, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(394, 38);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // dobTimePicker
            // 
            this.dobTimePicker.AutoSize = true;
            this.dobTimePicker.Location = new System.Drawing.Point(542, 38);
            this.dobTimePicker.Name = "dobTimePicker";
            this.dobTimePicker.Size = new System.Drawing.Size(30, 13);
            this.dobTimePicker.TabIndex = 7;
            this.dobTimePicker.Text = "DOB";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(17, 54);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(123, 54);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(229, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(397, 54);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // dob_Datepicker
            // 
            this.dob_Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_Datepicker.Location = new System.Drawing.Point(545, 54);
            this.dob_Datepicker.Name = "dob_Datepicker";
            this.dob_Datepicker.Size = new System.Drawing.Size(107, 20);
            this.dob_Datepicker.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(668, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(759, 51);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // studentListView
            // 
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.personID,
            this.username,
            this.firstName,
            this.lastName,
            this.dob,
            this.phone,
            this.SSN});
            this.studentListView.HideSelection = false;
            this.studentListView.Location = new System.Drawing.Point(17, 80);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(839, 173);
            this.studentListView.TabIndex = 14;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.Text = "Student ID";
            this.studentID.Width = 87;
            // 
            // personID
            // 
            this.personID.Text = "Person ID";
            this.personID.Width = 65;
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 75;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 125;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 123;
            // 
            // dob
            // 
            this.dob.Text = "DOB";
            this.dob.Width = 78;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 108;
            // 
            // SSN
            // 
            this.SSN.Text = "SSN";
            this.SSN.Width = 106;
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(425, 9);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.ErrorMessageLabel.TabIndex = 15;
            this.ErrorMessageLabel.Text = "--";
            // 
            // viewOnlyRadioButton
            // 
            this.viewOnlyRadioButton.AutoSize = true;
            this.viewOnlyRadioButton.Location = new System.Drawing.Point(251, 4);
            this.viewOnlyRadioButton.Name = "viewOnlyRadioButton";
            this.viewOnlyRadioButton.Size = new System.Drawing.Size(72, 17);
            this.viewOnlyRadioButton.TabIndex = 1;
            this.viewOnlyRadioButton.TabStop = true;
            this.viewOnlyRadioButton.Text = "View Only";
            this.viewOnlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // editRadioButton
            // 
            this.editRadioButton.AutoSize = true;
            this.editRadioButton.Location = new System.Drawing.Point(340, 4);
            this.editRadioButton.Name = "editRadioButton";
            this.editRadioButton.Size = new System.Drawing.Size(79, 17);
            this.editRadioButton.TabIndex = 2;
            this.editRadioButton.TabStop = true;
            this.editRadioButton.Text = "Enable Edit";
            this.editRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchStudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SearchStudentUserControl";
            this.Size = new System.Drawing.Size(960, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label searchTitleLabel;
        private System.Windows.Forms.Label dobTimePicker;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.DateTimePicker dob_Datepicker;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader personID;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader dob;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader SSN;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.RadioButton editRadioButton;
        private System.Windows.Forms.RadioButton viewOnlyRadioButton;
    }
}
