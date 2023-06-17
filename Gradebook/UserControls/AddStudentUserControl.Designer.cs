namespace Gradebook.UserControls
{
    partial class AddStudentUserControl
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clearButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.statelabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.streeLabel = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.genderlabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.createStudentTitleLabel = new System.Windows.Forms.Label();
            this.addStudentUserControlPanel = new System.Windows.Forms.Panel();
            this.noteLable2 = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.messageErrorMainLabel = new System.Windows.Forms.Label();
            this.genderErrorMessageLabel = new System.Windows.Forms.Label();
            this.zipErrorMessageLabel = new System.Windows.Forms.Label();
            this.stateErrorMessageLabel = new System.Windows.Forms.Label();
            this.cityErrorMessageLabel = new System.Windows.Forms.Label();
            this.addressErrorMessageLabel = new System.Windows.Forms.Label();
            this.statusErrorMessageLabel = new System.Windows.Forms.Label();
            this.ssnErrorMessageLabel = new System.Windows.Forms.Label();
            this.phoneErrorMessageLabel = new System.Windows.Forms.Label();
            this.dobErrorMessageLabel = new System.Windows.Forms.Label();
            this.firstNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.addStudentUserControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 541);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(130, 351);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            this.clearButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clearButton_KeyPress);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(512, 351);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 12;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(58, 204);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Phone";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(130, 75);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(451, 207);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(22, 13);
            this.zipLabel.TabIndex = 11;
            this.zipLabel.Text = "Zip";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(130, 116);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.Location = new System.Drawing.Point(449, 166);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(32, 13);
            this.statelabel.TabIndex = 10;
            this.statelabel.Text = "State";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(130, 201);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(214, 20);
            this.phoneTextBox.TabIndex = 4;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // streeLabel
            // 
            this.streeLabel.AutoSize = true;
            this.streeLabel.Location = new System.Drawing.Point(449, 75);
            this.streeLabel.Name = "streeLabel";
            this.streeLabel.Size = new System.Drawing.Size(35, 13);
            this.streeLabel.TabIndex = 8;
            this.streeLabel.Text = "Street";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(130, 254);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(214, 20);
            this.ssnTextBox.TabIndex = 5;
            this.ssnTextBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Location = new System.Drawing.Point(449, 254);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(42, 13);
            this.genderlabel.TabIndex = 7;
            this.genderlabel.Text = "Gender";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(512, 75);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(214, 20);
            this.streetTextBox.TabIndex = 7;
            this.streetTextBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(58, 299);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(512, 120);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(214, 20);
            this.cityTextBox.TabIndex = 8;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(58, 251);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(29, 13);
            this.ssnLabel.TabIndex = 5;
            this.ssnLabel.Text = "SSN";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(58, 159);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(66, 13);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "Date of Birth";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(512, 204);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(214, 20);
            this.zipTextBox.TabIndex = 10;
            this.zipTextBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(58, 116);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(54, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "FirstName";
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(130, 159);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 20);
            this.dobPicker.TabIndex = 3;
            this.dobPicker.ValueChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(58, 78);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(449, 123);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(130, 296);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 6;
            this.statusComboBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // lastNameErrorMessageLabel
            // 
            this.lastNameErrorMessageLabel.AutoSize = true;
            this.lastNameErrorMessageLabel.Location = new System.Drawing.Point(127, 59);
            this.lastNameErrorMessageLabel.Name = "lastNameErrorMessageLabel";
            this.lastNameErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.lastNameErrorMessageLabel.TabIndex = 1;
            this.lastNameErrorMessageLabel.Text = "--";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(512, 251);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox.TabIndex = 11;
            this.genderComboBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // createStudentTitleLabel
            // 
            this.createStudentTitleLabel.AutoSize = true;
            this.createStudentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStudentTitleLabel.Location = new System.Drawing.Point(317, 14);
            this.createStudentTitleLabel.Name = "createStudentTitleLabel";
            this.createStudentTitleLabel.Size = new System.Drawing.Size(207, 20);
            this.createStudentTitleLabel.TabIndex = 0;
            this.createStudentTitleLabel.Text = "Add Student Information";
            // 
            // addStudentUserControlPanel
            // 
            this.addStudentUserControlPanel.Controls.Add(this.noteLable2);
            this.addStudentUserControlPanel.Controls.Add(this.noteLabel);
            this.addStudentUserControlPanel.Controls.Add(this.messageErrorMainLabel);
            this.addStudentUserControlPanel.Controls.Add(this.genderErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.zipErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.stateErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.cityErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.addressErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.statusErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.ssnErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.phoneErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.dobErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.firstNameErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.stateComboBox);
            this.addStudentUserControlPanel.Controls.Add(this.createStudentTitleLabel);
            this.addStudentUserControlPanel.Controls.Add(this.genderComboBox);
            this.addStudentUserControlPanel.Controls.Add(this.lastNameErrorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.statusComboBox);
            this.addStudentUserControlPanel.Controls.Add(this.cityLabel);
            this.addStudentUserControlPanel.Controls.Add(this.lastNameLabel);
            this.addStudentUserControlPanel.Controls.Add(this.dobPicker);
            this.addStudentUserControlPanel.Controls.Add(this.firstNameLabel);
            this.addStudentUserControlPanel.Controls.Add(this.zipTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.dobLabel);
            this.addStudentUserControlPanel.Controls.Add(this.ssnLabel);
            this.addStudentUserControlPanel.Controls.Add(this.cityTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.statusLabel);
            this.addStudentUserControlPanel.Controls.Add(this.streetTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.genderlabel);
            this.addStudentUserControlPanel.Controls.Add(this.ssnTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.streeLabel);
            this.addStudentUserControlPanel.Controls.Add(this.phoneTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.statelabel);
            this.addStudentUserControlPanel.Controls.Add(this.firstNameTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.zipLabel);
            this.addStudentUserControlPanel.Controls.Add(this.lastNameTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.phoneLabel);
            this.addStudentUserControlPanel.Controls.Add(this.addStudentButton);
            this.addStudentUserControlPanel.Controls.Add(this.clearButton);
            this.addStudentUserControlPanel.Location = new System.Drawing.Point(3, 3);
            this.addStudentUserControlPanel.Name = "addStudentUserControlPanel";
            this.addStudentUserControlPanel.Size = new System.Drawing.Size(922, 606);
            this.addStudentUserControlPanel.TabIndex = 27;
            // 
            // noteLable2
            // 
            this.noteLable2.AutoSize = true;
            this.noteLable2.Location = new System.Drawing.Point(82, 451);
            this.noteLable2.Name = "noteLable2";
            this.noteLable2.Size = new System.Drawing.Size(261, 13);
            this.noteLable2.TabIndex = 40;
            this.noteLable2.Text = "All notes will be removed before moving to production.";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(82, 425);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(328, 13);
            this.noteLabel.TabIndex = 39;
            this.noteLabel.Text = "* default password is the first name + last 4 digits of SSN (smith5678)";
            // 
            // messageErrorMainLabel
            // 
            this.messageErrorMainLabel.AutoSize = true;
            this.messageErrorMainLabel.Location = new System.Drawing.Point(127, 37);
            this.messageErrorMainLabel.Name = "messageErrorMainLabel";
            this.messageErrorMainLabel.Size = new System.Drawing.Size(13, 13);
            this.messageErrorMainLabel.TabIndex = 38;
            this.messageErrorMainLabel.Text = "--";
            // 
            // genderErrorMessageLabel
            // 
            this.genderErrorMessageLabel.AutoSize = true;
            this.genderErrorMessageLabel.Location = new System.Drawing.Point(509, 238);
            this.genderErrorMessageLabel.Name = "genderErrorMessageLabel";
            this.genderErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.genderErrorMessageLabel.TabIndex = 37;
            this.genderErrorMessageLabel.Text = "--";
            // 
            // zipErrorMessageLabel
            // 
            this.zipErrorMessageLabel.AutoSize = true;
            this.zipErrorMessageLabel.Location = new System.Drawing.Point(509, 188);
            this.zipErrorMessageLabel.Name = "zipErrorMessageLabel";
            this.zipErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.zipErrorMessageLabel.TabIndex = 36;
            this.zipErrorMessageLabel.Text = "--";
            // 
            // stateErrorMessageLabel
            // 
            this.stateErrorMessageLabel.AutoSize = true;
            this.stateErrorMessageLabel.Location = new System.Drawing.Point(509, 146);
            this.stateErrorMessageLabel.Name = "stateErrorMessageLabel";
            this.stateErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.stateErrorMessageLabel.TabIndex = 35;
            this.stateErrorMessageLabel.Text = "--";
            // 
            // cityErrorMessageLabel
            // 
            this.cityErrorMessageLabel.AutoSize = true;
            this.cityErrorMessageLabel.Location = new System.Drawing.Point(509, 104);
            this.cityErrorMessageLabel.Name = "cityErrorMessageLabel";
            this.cityErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.cityErrorMessageLabel.TabIndex = 34;
            this.cityErrorMessageLabel.Text = "--";
            // 
            // addressErrorMessageLabel
            // 
            this.addressErrorMessageLabel.AutoSize = true;
            this.addressErrorMessageLabel.Location = new System.Drawing.Point(509, 59);
            this.addressErrorMessageLabel.Name = "addressErrorMessageLabel";
            this.addressErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.addressErrorMessageLabel.TabIndex = 33;
            this.addressErrorMessageLabel.Text = "--";
            // 
            // statusErrorMessageLabel
            // 
            this.statusErrorMessageLabel.AutoSize = true;
            this.statusErrorMessageLabel.Location = new System.Drawing.Point(127, 277);
            this.statusErrorMessageLabel.Name = "statusErrorMessageLabel";
            this.statusErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.statusErrorMessageLabel.TabIndex = 32;
            this.statusErrorMessageLabel.Text = "--";
            // 
            // ssnErrorMessageLabel
            // 
            this.ssnErrorMessageLabel.AutoSize = true;
            this.ssnErrorMessageLabel.Location = new System.Drawing.Point(127, 238);
            this.ssnErrorMessageLabel.Name = "ssnErrorMessageLabel";
            this.ssnErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.ssnErrorMessageLabel.TabIndex = 31;
            this.ssnErrorMessageLabel.Text = "--";
            // 
            // phoneErrorMessageLabel
            // 
            this.phoneErrorMessageLabel.AutoSize = true;
            this.phoneErrorMessageLabel.Location = new System.Drawing.Point(127, 182);
            this.phoneErrorMessageLabel.Name = "phoneErrorMessageLabel";
            this.phoneErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.phoneErrorMessageLabel.TabIndex = 30;
            this.phoneErrorMessageLabel.Text = "--";
            // 
            // dobErrorMessageLabel
            // 
            this.dobErrorMessageLabel.AutoSize = true;
            this.dobErrorMessageLabel.Location = new System.Drawing.Point(127, 143);
            this.dobErrorMessageLabel.Name = "dobErrorMessageLabel";
            this.dobErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.dobErrorMessageLabel.TabIndex = 29;
            this.dobErrorMessageLabel.Text = "--";
            // 
            // firstNameErrorMessageLabel
            // 
            this.firstNameErrorMessageLabel.AutoSize = true;
            this.firstNameErrorMessageLabel.Location = new System.Drawing.Point(127, 100);
            this.firstNameErrorMessageLabel.Name = "firstNameErrorMessageLabel";
            this.firstNameErrorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.firstNameErrorMessageLabel.TabIndex = 28;
            this.firstNameErrorMessageLabel.Text = "--";
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
            this.stateComboBox.Location = new System.Drawing.Point(512, 162);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 9;
            this.stateComboBox.TextChanged += new System.EventHandler(this.TextBox_changed);
            // 
            // AddStudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addStudentUserControlPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AddStudentUserControl";
            this.Size = new System.Drawing.Size(960, 640);
            this.addStudentUserControlPanel.ResumeLayout(false);
            this.addStudentUserControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label streeLabel;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label lastNameErrorMessageLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label createStudentTitleLabel;
        private System.Windows.Forms.Panel addStudentUserControlPanel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label firstNameErrorMessageLabel;
        private System.Windows.Forms.Label addressErrorMessageLabel;
        private System.Windows.Forms.Label statusErrorMessageLabel;
        private System.Windows.Forms.Label ssnErrorMessageLabel;
        private System.Windows.Forms.Label phoneErrorMessageLabel;
        private System.Windows.Forms.Label dobErrorMessageLabel;
        private System.Windows.Forms.Label genderErrorMessageLabel;
        private System.Windows.Forms.Label zipErrorMessageLabel;
        private System.Windows.Forms.Label stateErrorMessageLabel;
        private System.Windows.Forms.Label cityErrorMessageLabel;
        private System.Windows.Forms.Label messageErrorMainLabel;
        private System.Windows.Forms.Label noteLable2;
        private System.Windows.Forms.Label noteLabel;
    }
}
