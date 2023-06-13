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
            this.createStudentTitleLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.statelabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streeLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statusTextBox = new System.Windows.Forms.ComboBox();
            this.genderTextBox = new System.Windows.Forms.ComboBox();
            this.addStudentUserControlPanel = new System.Windows.Forms.Panel();
            this.addStudentUserControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createStudentTitleLabel
            // 
            this.createStudentTitleLabel.AutoSize = true;
            this.createStudentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createStudentTitleLabel.Location = new System.Drawing.Point(319, 29);
            this.createStudentTitleLabel.Name = "createStudentTitleLabel";
            this.createStudentTitleLabel.Size = new System.Drawing.Size(184, 20);
            this.createStudentTitleLabel.TabIndex = 0;
            this.createStudentTitleLabel.Text = "Add Student Information";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(127, 70);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(13, 13);
            this.errorMessageLabel.TabIndex = 1;
            this.errorMessageLabel.Text = "--";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(54, 105);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(54, 141);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(54, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "FirstName";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(54, 182);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(66, 13);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "Date of Birth";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(54, 254);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(29, 13);
            this.ssnLabel.TabIndex = 5;
            this.ssnLabel.Text = "SSN";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(54, 302);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status";
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
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(54, 214);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Phone";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(449, 214);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(22, 13);
            this.zipLabel.TabIndex = 11;
            this.zipLabel.Text = "Zip";
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.Location = new System.Drawing.Point(449, 178);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(32, 13);
            this.statelabel.TabIndex = 10;
            this.statelabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(449, 138);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City";
            // 
            // streeLabel
            // 
            this.streeLabel.AutoSize = true;
            this.streeLabel.Location = new System.Drawing.Point(449, 102);
            this.streeLabel.Name = "streeLabel";
            this.streeLabel.Size = new System.Drawing.Size(35, 13);
            this.streeLabel.TabIndex = 8;
            this.streeLabel.Text = "Street";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(209, 351);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(558, 351);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 14;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(130, 102);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.lastNameTextBox.TabIndex = 15;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(130, 138);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(130, 211);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(214, 20);
            this.phoneTextBox.TabIndex = 17;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(130, 254);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(214, 20);
            this.ssnTextBox.TabIndex = 18;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(512, 102);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(214, 20);
            this.streetTextBox.TabIndex = 19;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(512, 135);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(214, 20);
            this.cityTextBox.TabIndex = 20;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(512, 175);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(214, 20);
            this.stateTextBox.TabIndex = 21;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(512, 211);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(214, 20);
            this.zipTextBox.TabIndex = 22;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(130, 175);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 20);
            this.dobPicker.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 541);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusTextBox.FormattingEnabled = true;
            this.statusTextBox.Location = new System.Drawing.Point(130, 299);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(121, 21);
            this.statusTextBox.TabIndex = 25;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderTextBox.FormattingEnabled = true;
            this.genderTextBox.Location = new System.Drawing.Point(512, 254);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(121, 21);
            this.genderTextBox.TabIndex = 26;
            // 
            // addStudentUserControlPanel
            // 
            this.addStudentUserControlPanel.Controls.Add(this.createStudentTitleLabel);
            this.addStudentUserControlPanel.Controls.Add(this.genderTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.errorMessageLabel);
            this.addStudentUserControlPanel.Controls.Add(this.statusTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.cityLabel);
            this.addStudentUserControlPanel.Controls.Add(this.lastNameLabel);
            this.addStudentUserControlPanel.Controls.Add(this.dobPicker);
            this.addStudentUserControlPanel.Controls.Add(this.firstNameLabel);
            this.addStudentUserControlPanel.Controls.Add(this.zipTextBox);
            this.addStudentUserControlPanel.Controls.Add(this.dobLabel);
            this.addStudentUserControlPanel.Controls.Add(this.stateTextBox);
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

        private System.Windows.Forms.Label createStudentTitleLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox statusTextBox;
        private System.Windows.Forms.ComboBox genderTextBox;
        private System.Windows.Forms.Panel addStudentUserControlPanel;
    }
}
