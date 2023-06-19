namespace Gradebook.UserControls
{
    partial class AddNewCourseUserControl
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.creditHoursLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.creditHoursComboBox = new System.Windows.Forms.ComboBox();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.courseYearPicker = new System.Windows.Forms.DateTimePicker();
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCourseButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.prefixErrorLabel = new System.Windows.Forms.Label();
            this.sectionErrorLabel = new System.Windows.Forms.Label();
            this.semesterErrorLabel = new System.Windows.Forms.Label();
            this.numberErrorLabel = new System.Windows.Forms.Label();
            this.creditErrorLabel = new System.Windows.Forms.Label();
            this.yearErrorLabel = new System.Windows.Forms.Label();
            this.teacherErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(28, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(133, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Course Name";
            // 
            // creditHoursLabel
            // 
            this.creditHoursLabel.AutoSize = true;
            this.creditHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditHoursLabel.Location = new System.Drawing.Point(485, 166);
            this.creditHoursLabel.Name = "creditHoursLabel";
            this.creditHoursLabel.Size = new System.Drawing.Size(121, 25);
            this.creditHoursLabel.TabIndex = 3;
            this.creditHoursLabel.Text = "Credit Hours";
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.Location = new System.Drawing.Point(76, 303);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(85, 25);
            this.teacherLabel.TabIndex = 4;
            this.teacherLabel.Text = "Teacher";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(553, 235);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(53, 25);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterLabel.Location = new System.Drawing.Point(65, 235);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(96, 25);
            this.semesterLabel.TabIndex = 6;
            this.semesterLabel.Text = "Semester";
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionLabel.Location = new System.Drawing.Point(83, 166);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(78, 25);
            this.sectionLabel.TabIndex = 7;
            this.sectionLabel.Text = "Section";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(456, 102);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(150, 25);
            this.numberLabel.TabIndex = 8;
            this.numberLabel.Text = "Course Number";
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixLabel.Location = new System.Drawing.Point(31, 102);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(130, 25);
            this.prefixLabel.TabIndex = 9;
            this.prefixLabel.Text = "Course Prefix";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(179, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(680, 30);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixTextBox.Location = new System.Drawing.Point(179, 102);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(240, 30);
            this.prefixTextBox.TabIndex = 11;
            this.prefixTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(622, 102);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(237, 30);
            this.numberTextBox.TabIndex = 12;
            this.numberTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionTextBox.Location = new System.Drawing.Point(179, 166);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(240, 30);
            this.sectionTextBox.TabIndex = 13;
            this.sectionTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // creditHoursComboBox
            // 
            this.creditHoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditHoursComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditHoursComboBox.FormattingEnabled = true;
            this.creditHoursComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.creditHoursComboBox.Location = new System.Drawing.Point(622, 166);
            this.creditHoursComboBox.Name = "creditHoursComboBox";
            this.creditHoursComboBox.Size = new System.Drawing.Size(237, 33);
            this.creditHoursComboBox.TabIndex = 14;
            this.creditHoursComboBox.SelectedIndexChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.semesterComboBox.Location = new System.Drawing.Point(179, 235);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(240, 33);
            this.semesterComboBox.TabIndex = 15;
            this.semesterComboBox.SelectedIndexChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // courseYearPicker
            // 
            this.courseYearPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseYearPicker.CustomFormat = "yyyy";
            this.courseYearPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.courseYearPicker.Location = new System.Drawing.Point(622, 235);
            this.courseYearPicker.Name = "courseYearPicker";
            this.courseYearPicker.ShowUpDown = true;
            this.courseYearPicker.Size = new System.Drawing.Size(237, 30);
            this.courseYearPicker.TabIndex = 16;
            this.courseYearPicker.ValueChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(179, 303);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(411, 33);
            this.teacherComboBox.TabIndex = 17;
            this.teacherComboBox.SelectedIndexChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Gradebook.Model.Teacher);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Location = new System.Drawing.Point(550, 369);
            this.addCourseButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(179, 50);
            this.addCourseButton.TabIndex = 51;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(291, 369);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(179, 49);
            this.clearButton.TabIndex = 52;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(176, 72);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.nameErrorLabel.TabIndex = 53;
            this.nameErrorLabel.Text = "label1";
            // 
            // prefixErrorLabel
            // 
            this.prefixErrorLabel.AutoSize = true;
            this.prefixErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.prefixErrorLabel.Location = new System.Drawing.Point(176, 135);
            this.prefixErrorLabel.Name = "prefixErrorLabel";
            this.prefixErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.prefixErrorLabel.TabIndex = 54;
            this.prefixErrorLabel.Text = "label2";
            // 
            // sectionErrorLabel
            // 
            this.sectionErrorLabel.AutoSize = true;
            this.sectionErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.sectionErrorLabel.Location = new System.Drawing.Point(176, 199);
            this.sectionErrorLabel.Name = "sectionErrorLabel";
            this.sectionErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.sectionErrorLabel.TabIndex = 55;
            this.sectionErrorLabel.Text = "label3";
            // 
            // semesterErrorLabel
            // 
            this.semesterErrorLabel.AutoSize = true;
            this.semesterErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.semesterErrorLabel.Location = new System.Drawing.Point(176, 271);
            this.semesterErrorLabel.Name = "semesterErrorLabel";
            this.semesterErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.semesterErrorLabel.TabIndex = 56;
            this.semesterErrorLabel.Text = "label4";
            // 
            // numberErrorLabel
            // 
            this.numberErrorLabel.AutoSize = true;
            this.numberErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.numberErrorLabel.Location = new System.Drawing.Point(619, 135);
            this.numberErrorLabel.Name = "numberErrorLabel";
            this.numberErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.numberErrorLabel.TabIndex = 57;
            this.numberErrorLabel.Text = "label5";
            // 
            // creditErrorLabel
            // 
            this.creditErrorLabel.AutoSize = true;
            this.creditErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.creditErrorLabel.Location = new System.Drawing.Point(619, 202);
            this.creditErrorLabel.Name = "creditErrorLabel";
            this.creditErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.creditErrorLabel.TabIndex = 58;
            this.creditErrorLabel.Text = "label6";
            // 
            // yearErrorLabel
            // 
            this.yearErrorLabel.AutoSize = true;
            this.yearErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.yearErrorLabel.Location = new System.Drawing.Point(619, 271);
            this.yearErrorLabel.Name = "yearErrorLabel";
            this.yearErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.yearErrorLabel.TabIndex = 59;
            this.yearErrorLabel.Text = "label7";
            // 
            // teacherErrorLabel
            // 
            this.teacherErrorLabel.AutoSize = true;
            this.teacherErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.teacherErrorLabel.Location = new System.Drawing.Point(176, 339);
            this.teacherErrorLabel.Name = "teacherErrorLabel";
            this.teacherErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.teacherErrorLabel.TabIndex = 60;
            this.teacherErrorLabel.Text = "label1";
            // 
            // AddNewCourseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teacherErrorLabel);
            this.Controls.Add(this.yearErrorLabel);
            this.Controls.Add(this.creditErrorLabel);
            this.Controls.Add(this.numberErrorLabel);
            this.Controls.Add(this.semesterErrorLabel);
            this.Controls.Add(this.sectionErrorLabel);
            this.Controls.Add(this.prefixErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(this.courseYearPicker);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.creditHoursComboBox);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.creditHoursLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "AddNewCourseUserControl";
            this.Size = new System.Drawing.Size(1068, 480);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.ComboBox creditHoursComboBox;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.DateTimePicker courseYearPicker;
        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label prefixErrorLabel;
        private System.Windows.Forms.Label sectionErrorLabel;
        private System.Windows.Forms.Label semesterErrorLabel;
        private System.Windows.Forms.Label numberErrorLabel;
        private System.Windows.Forms.Label creditErrorLabel;
        private System.Windows.Forms.Label yearErrorLabel;
        private System.Windows.Forms.Label teacherErrorLabel;
    }
}
