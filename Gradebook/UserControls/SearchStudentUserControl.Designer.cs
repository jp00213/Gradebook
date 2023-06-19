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
            this.currentStudentIDSetLabel = new System.Windows.Forms.Label();
            this.currentStudentIDLabel = new System.Windows.Forms.Label();
            this.searchOptionGroup = new System.Windows.Forms.GroupBox();
            this.searchDobPicker = new System.Windows.Forms.RadioButton();
            this.searchNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchUsernameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchStudentIDRadioButton = new System.Windows.Forms.RadioButton();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.studentListView = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.dob_Datepicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.dobTimePicker = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.searchTitleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.searchOptionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentStudentIDSetLabel);
            this.panel1.Controls.Add(this.currentStudentIDLabel);
            this.panel1.Controls.Add(this.searchOptionGroup);
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
            this.panel1.Size = new System.Drawing.Size(884, 350);
            this.panel1.TabIndex = 0;
            // 
            // currentStudentIDSetLabel
            // 
            this.currentStudentIDSetLabel.AutoSize = true;
            this.currentStudentIDSetLabel.Location = new System.Drawing.Point(529, 37);
            this.currentStudentIDSetLabel.Name = "currentStudentIDSetLabel";
            this.currentStudentIDSetLabel.Size = new System.Drawing.Size(10, 13);
            this.currentStudentIDSetLabel.TabIndex = 18;
            this.currentStudentIDSetLabel.Text = ":";
            // 
            // currentStudentIDLabel
            // 
            this.currentStudentIDLabel.AutoSize = true;
            this.currentStudentIDLabel.Location = new System.Drawing.Point(425, 37);
            this.currentStudentIDLabel.Name = "currentStudentIDLabel";
            this.currentStudentIDLabel.Size = new System.Drawing.Size(95, 13);
            this.currentStudentIDLabel.TabIndex = 17;
            this.currentStudentIDLabel.Text = "Current Student ID";
            // 
            // searchOptionGroup
            // 
            this.searchOptionGroup.Controls.Add(this.searchDobPicker);
            this.searchOptionGroup.Controls.Add(this.searchNameRadioButton);
            this.searchOptionGroup.Controls.Add(this.searchUsernameRadioButton);
            this.searchOptionGroup.Controls.Add(this.searchStudentIDRadioButton);
            this.searchOptionGroup.Location = new System.Drawing.Point(25, 37);
            this.searchOptionGroup.Name = "searchOptionGroup";
            this.searchOptionGroup.Size = new System.Drawing.Size(394, 41);
            this.searchOptionGroup.TabIndex = 16;
            this.searchOptionGroup.TabStop = false;
            this.searchOptionGroup.Text = "Search By:";
            // 
            // searchDobPicker
            // 
            this.searchDobPicker.AutoSize = true;
            this.searchDobPicker.Location = new System.Drawing.Point(312, 15);
            this.searchDobPicker.Name = "searchDobPicker";
            this.searchDobPicker.Size = new System.Drawing.Size(48, 17);
            this.searchDobPicker.TabIndex = 6;
            this.searchDobPicker.TabStop = true;
            this.searchDobPicker.Text = "DOB";
            this.searchDobPicker.UseVisualStyleBackColor = true;
            this.searchDobPicker.CheckedChanged += new System.EventHandler(this.ChangeSearchBox);
            // 
            // searchNameRadioButton
            // 
            this.searchNameRadioButton.AutoSize = true;
            this.searchNameRadioButton.Location = new System.Drawing.Point(234, 15);
            this.searchNameRadioButton.Name = "searchNameRadioButton";
            this.searchNameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.searchNameRadioButton.TabIndex = 5;
            this.searchNameRadioButton.TabStop = true;
            this.searchNameRadioButton.Text = "Name";
            this.searchNameRadioButton.UseVisualStyleBackColor = true;
            this.searchNameRadioButton.CheckedChanged += new System.EventHandler(this.ChangeSearchBox);
            // 
            // searchUsernameRadioButton
            // 
            this.searchUsernameRadioButton.AutoSize = true;
            this.searchUsernameRadioButton.Location = new System.Drawing.Point(133, 15);
            this.searchUsernameRadioButton.Name = "searchUsernameRadioButton";
            this.searchUsernameRadioButton.Size = new System.Drawing.Size(73, 17);
            this.searchUsernameRadioButton.TabIndex = 4;
            this.searchUsernameRadioButton.TabStop = true;
            this.searchUsernameRadioButton.Text = "Username";
            this.searchUsernameRadioButton.UseVisualStyleBackColor = true;
            this.searchUsernameRadioButton.CheckedChanged += new System.EventHandler(this.ChangeSearchBox);
            // 
            // searchStudentIDRadioButton
            // 
            this.searchStudentIDRadioButton.AutoSize = true;
            this.searchStudentIDRadioButton.Location = new System.Drawing.Point(28, 15);
            this.searchStudentIDRadioButton.Name = "searchStudentIDRadioButton";
            this.searchStudentIDRadioButton.Size = new System.Drawing.Size(83, 17);
            this.searchStudentIDRadioButton.TabIndex = 3;
            this.searchStudentIDRadioButton.TabStop = true;
            this.searchStudentIDRadioButton.Text = "Student ID#";
            this.searchStudentIDRadioButton.UseVisualStyleBackColor = true;
            this.searchStudentIDRadioButton.CheckedChanged += new System.EventHandler(this.ChangeSearchBox);
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
            this.studentListView.FullRowSelect = true;
            this.studentListView.HideSelection = false;
            this.studentListView.Location = new System.Drawing.Point(17, 138);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(839, 173);
            this.studentListView.TabIndex = 14;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            this.studentListView.Click += new System.EventHandler(this.studentListView_Click);
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
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(767, 94);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(676, 94);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dob_Datepicker
            // 
            this.dob_Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_Datepicker.Location = new System.Drawing.Point(553, 97);
            this.dob_Datepicker.Name = "dob_Datepicker";
            this.dob_Datepicker.Size = new System.Drawing.Size(107, 20);
            this.dob_Datepicker.TabIndex = 11;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(405, 97);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(237, 97);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(131, 97);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 8;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(25, 97);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 7;
            // 
            // dobTimePicker
            // 
            this.dobTimePicker.AutoSize = true;
            this.dobTimePicker.Location = new System.Drawing.Point(550, 81);
            this.dobTimePicker.Name = "dobTimePicker";
            this.dobTimePicker.Size = new System.Drawing.Size(30, 13);
            this.dobTimePicker.TabIndex = 7;
            this.dobTimePicker.Text = "DOB";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(402, 81);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(234, 81);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(128, 81);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(22, 81);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIDLabel.TabIndex = 3;
            this.studentIDLabel.Text = "Student ID";
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
            // SearchStudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SearchStudentUserControl";
            this.Size = new System.Drawing.Size(960, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.searchOptionGroup.ResumeLayout(false);
            this.searchOptionGroup.PerformLayout();
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
        private System.Windows.Forms.GroupBox searchOptionGroup;
        private System.Windows.Forms.Label currentStudentIDLabel;
        private System.Windows.Forms.RadioButton searchStudentIDRadioButton;
        private System.Windows.Forms.RadioButton searchDobPicker;
        private System.Windows.Forms.RadioButton searchNameRadioButton;
        private System.Windows.Forms.RadioButton searchUsernameRadioButton;
        private System.Windows.Forms.Label currentStudentIDSetLabel;
    }
}
