namespace Gradebook.UserControls
{
    partial class AddTeacherUserControl
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
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.DOBErrorLabel = new System.Windows.Forms.Label();
            this.stateErrorMessageLabel = new System.Windows.Forms.Label();
            this.cityErrorMessageLabel = new System.Windows.Forms.Label();
            this.addressErrorMessageLabel = new System.Windows.Forms.Label();
            this.firstNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.zipErrorMessageLabel = new System.Windows.Forms.Label();
            this.ssnErrorMessageLabel = new System.Windows.Forms.Label();
            this.sexErrorMessageLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.createStudentTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(777, 263);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(301, 24);
            this.stateComboBox.TabIndex = 47;
            this.stateComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComboboxOrDateTimePicker_MouseDown);
            // 
            // DOBErrorLabel
            // 
            this.DOBErrorLabel.AutoSize = true;
            this.DOBErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBErrorLabel.Location = new System.Drawing.Point(251, 292);
            this.DOBErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DOBErrorLabel.Name = "DOBErrorLabel";
            this.DOBErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.DOBErrorLabel.TabIndex = 51;
            // 
            // stateErrorMessageLabel
            // 
            this.stateErrorMessageLabel.AutoSize = true;
            this.stateErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateErrorMessageLabel.Location = new System.Drawing.Point(777, 293);
            this.stateErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateErrorMessageLabel.Name = "stateErrorMessageLabel";
            this.stateErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.stateErrorMessageLabel.TabIndex = 50;
            // 
            // cityErrorMessageLabel
            // 
            this.cityErrorMessageLabel.AutoSize = true;
            this.cityErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityErrorMessageLabel.Location = new System.Drawing.Point(777, 230);
            this.cityErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityErrorMessageLabel.Name = "cityErrorMessageLabel";
            this.cityErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.cityErrorMessageLabel.TabIndex = 49;
            // 
            // addressErrorMessageLabel
            // 
            this.addressErrorMessageLabel.AutoSize = true;
            this.addressErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorMessageLabel.Location = new System.Drawing.Point(777, 174);
            this.addressErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressErrorMessageLabel.Name = "addressErrorMessageLabel";
            this.addressErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.addressErrorMessageLabel.TabIndex = 48;
            // 
            // firstNameErrorMessageLabel
            // 
            this.firstNameErrorMessageLabel.AutoSize = true;
            this.firstNameErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorMessageLabel.Location = new System.Drawing.Point(251, 161);
            this.firstNameErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameErrorMessageLabel.Name = "firstNameErrorMessageLabel";
            this.firstNameErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.firstNameErrorMessageLabel.TabIndex = 47;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(251, 256);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfBirthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(303, 26);
            this.dateOfBirthDateTimePicker.TabIndex = 41;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2023, 3, 23, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComboboxOrDateTimePicker_MouseDown);
            // 
            // lastNameErrorMessageLabel
            // 
            this.lastNameErrorMessageLabel.AutoSize = true;
            this.lastNameErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorMessageLabel.Location = new System.Drawing.Point(251, 222);
            this.lastNameErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameErrorMessageLabel.Name = "lastNameErrorMessageLabel";
            this.lastNameErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.lastNameErrorMessageLabel.TabIndex = 45;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(777, 324);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(301, 22);
            this.zipTextBox.TabIndex = 48;
            this.zipTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(777, 196);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(301, 22);
            this.cityTextBox.TabIndex = 46;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(777, 135);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 22);
            this.addressTextBox.TabIndex = 45;
            this.addressTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(776, 384);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(303, 22);
            this.phoneTextBox.TabIndex = 49;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(248, 135);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(303, 22);
            this.firstNameTextBox.TabIndex = 39;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(248, 196);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(303, 22);
            this.lastNameTextBox.TabIndex = 40;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(697, 324);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(39, 25);
            this.zipLabel.TabIndex = 38;
            this.zipLabel.Text = "Zip";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(692, 260);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(58, 25);
            this.stateLabel.TabIndex = 37;
            this.stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(692, 198);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(46, 25);
            this.cityLabel.TabIndex = 36;
            this.cityLabel.Text = "City";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(679, 135);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(85, 25);
            this.addressLabel.TabIndex = 35;
            this.addressLabel.Text = "Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(693, 385);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 25);
            this.phoneLabel.TabIndex = 34;
            this.phoneLabel.Text = "Phone";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(107, 258);
            this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(123, 25);
            this.dateOfBirthLabel.TabIndex = 33;
            this.dateOfBirthLabel.Text = "Date Of Birth";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(124, 136);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 32;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(124, 196);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 31;
            this.lastNameLabel.Text = "Last Name";
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNLabel.Location = new System.Drawing.Point(155, 322);
            this.SSNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(54, 25);
            this.SSNLabel.TabIndex = 53;
            this.SSNLabel.Text = "SSN";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(155, 380);
            this.sexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(47, 25);
            this.sexLabel.TabIndex = 54;
            this.sexLabel.Text = "Sex";
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexComboBox.Location = new System.Drawing.Point(249, 379);
            this.sexComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(304, 24);
            this.sexComboBox.TabIndex = 43;
            this.sexComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComboboxOrDateTimePicker_MouseDown);
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(251, 322);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(304, 22);
            this.ssnTextBox.TabIndex = 42;
            this.ssnTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(349, 535);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(179, 46);
            this.clearButton.TabIndex = 51;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacherButton.Location = new System.Drawing.Point(703, 535);
            this.addTeacherButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(179, 47);
            this.addTeacherButton.TabIndex = 50;
            this.addTeacherButton.Text = "Add Teacher";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // zipErrorMessageLabel
            // 
            this.zipErrorMessageLabel.AutoSize = true;
            this.zipErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipErrorMessageLabel.Location = new System.Drawing.Point(777, 352);
            this.zipErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipErrorMessageLabel.Name = "zipErrorMessageLabel";
            this.zipErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.zipErrorMessageLabel.TabIndex = 61;
            // 
            // ssnErrorMessageLabel
            // 
            this.ssnErrorMessageLabel.AutoSize = true;
            this.ssnErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnErrorMessageLabel.Location = new System.Drawing.Point(251, 351);
            this.ssnErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ssnErrorMessageLabel.Name = "ssnErrorMessageLabel";
            this.ssnErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.ssnErrorMessageLabel.TabIndex = 62;
            // 
            // sexErrorMessageLabel
            // 
            this.sexErrorMessageLabel.AutoSize = true;
            this.sexErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexErrorMessageLabel.Location = new System.Drawing.Point(251, 409);
            this.sexErrorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sexErrorMessageLabel.Name = "sexErrorMessageLabel";
            this.sexErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.sexErrorMessageLabel.TabIndex = 63;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.Location = new System.Drawing.Point(777, 412);
            this.phoneErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.phoneErrorLabel.TabIndex = 65;
            // 
            // createStudentTitleLabel
            // 
            this.createStudentTitleLabel.AutoSize = true;
            this.createStudentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStudentTitleLabel.Location = new System.Drawing.Point(465, 45);
            this.createStudentTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createStudentTitleLabel.Name = "createStudentTitleLabel";
            this.createStudentTitleLabel.Size = new System.Drawing.Size(250, 25);
            this.createStudentTitleLabel.TabIndex = 66;
            this.createStudentTitleLabel.Text = "Add Teacher Information";
            // 
            // AddTeacherUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createStudentTitleLabel);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.sexErrorMessageLabel);
            this.Controls.Add(this.ssnErrorMessageLabel);
            this.Controls.Add(this.zipErrorMessageLabel);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.DOBErrorLabel);
            this.Controls.Add(this.stateErrorMessageLabel);
            this.Controls.Add(this.cityErrorMessageLabel);
            this.Controls.Add(this.addressErrorMessageLabel);
            this.Controls.Add(this.firstNameErrorMessageLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.lastNameErrorMessageLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTeacherUserControl";
            this.Size = new System.Drawing.Size(1256, 705);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label DOBErrorLabel;
        private System.Windows.Forms.Label stateErrorMessageLabel;
        private System.Windows.Forms.Label cityErrorMessageLabel;
        private System.Windows.Forms.Label addressErrorMessageLabel;
        private System.Windows.Forms.Label firstNameErrorMessageLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Label lastNameErrorMessageLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Label zipErrorMessageLabel;
        private System.Windows.Forms.Label ssnErrorMessageLabel;
        private System.Windows.Forms.Label sexErrorMessageLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label createStudentTitleLabel;
    }
}
