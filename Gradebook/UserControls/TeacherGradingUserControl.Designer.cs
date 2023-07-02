namespace Gradebook.UserControls
{
    partial class TeacherGradingUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectCourseLabel = new System.Windows.Forms.Label();
            this.selectAssignmentLabel = new System.Windows.Forms.Label();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.selectAssignmentComboBox = new System.Windows.Forms.ComboBox();
            this.studentGradesDataGridView = new System.Windows.Forms.DataGridView();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectClassErrorLabel = new System.Windows.Forms.Label();
            this.selectAssignmentErrorLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.populateButton = new System.Windows.Forms.Button();
            this.selectStudentErrorLabel = new System.Windows.Forms.Label();
            this.selectStudentComboBox = new System.Windows.Forms.ComboBox();
            this.selectStudentLabel = new System.Windows.Forms.Label();
            this.inputGradeLabel = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.gradeErrorMessageLabel = new System.Windows.Forms.Label();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCourseLabel
            // 
            this.selectCourseLabel.AutoSize = true;
            this.selectCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCourseLabel.Location = new System.Drawing.Point(245, 76);
            this.selectCourseLabel.Name = "selectCourseLabel";
            this.selectCourseLabel.Size = new System.Drawing.Size(122, 20);
            this.selectCourseLabel.TabIndex = 0;
            this.selectCourseLabel.Text = "Select Course";
            // 
            // selectAssignmentLabel
            // 
            this.selectAssignmentLabel.AutoSize = true;
            this.selectAssignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAssignmentLabel.Location = new System.Drawing.Point(208, 128);
            this.selectAssignmentLabel.Name = "selectAssignmentLabel";
            this.selectAssignmentLabel.Size = new System.Drawing.Size(159, 20);
            this.selectAssignmentLabel.TabIndex = 1;
            this.selectAssignmentLabel.Text = "Select Assignment";
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Location = new System.Drawing.Point(426, 76);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(309, 21);
            this.selectClassComboBox.TabIndex = 2;
            this.selectClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassSelected);
            this.selectClassComboBox.SelectionChangeCommitted += new System.EventHandler(this.ClassSelected);
            // 
            // selectAssignmentComboBox
            // 
            this.selectAssignmentComboBox.FormattingEnabled = true;
            this.selectAssignmentComboBox.Location = new System.Drawing.Point(426, 127);
            this.selectAssignmentComboBox.Name = "selectAssignmentComboBox";
            this.selectAssignmentComboBox.Size = new System.Drawing.Size(309, 21);
            this.selectAssignmentComboBox.TabIndex = 3;
            this.selectAssignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.selectAssignmentComboBox_SelectedIndexChanged);
            // 
            // studentGradesDataGridView
            // 
            this.studentGradesDataGridView.AllowUserToAddRows = false;
            this.studentGradesDataGridView.AllowUserToDeleteRows = false;
            this.studentGradesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGradesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentGradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGradesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.weightGradeDataGridViewTextBoxColumn,
            this.Add});
            this.studentGradesDataGridView.DataSource = this.gradesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGradesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentGradesDataGridView.Location = new System.Drawing.Point(72, 367);
            this.studentGradesDataGridView.Name = "studentGradesDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGradesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentGradesDataGridView.Size = new System.Drawing.Size(894, 239);
            this.studentGradesDataGridView.TabIndex = 4;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataSource = typeof(Gradebook.Model.Grades);
            // 
            // selectClassErrorLabel
            // 
            this.selectClassErrorLabel.AutoSize = true;
            this.selectClassErrorLabel.Location = new System.Drawing.Point(426, 104);
            this.selectClassErrorLabel.Name = "selectClassErrorLabel";
            this.selectClassErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.selectClassErrorLabel.TabIndex = 5;
            // 
            // selectAssignmentErrorLabel
            // 
            this.selectAssignmentErrorLabel.AutoSize = true;
            this.selectAssignmentErrorLabel.Location = new System.Drawing.Point(426, 155);
            this.selectAssignmentErrorLabel.Name = "selectAssignmentErrorLabel";
            this.selectAssignmentErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.selectAssignmentErrorLabel.TabIndex = 6;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(128, 42);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(742, 15);
            this.instructionsLabel.TabIndex = 7;
            this.instructionsLabel.Text = "Select course, assignment, and student, then input their grade and click save. Sa" +
    "ved grades will populate at the bottom for each student.";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(426, 292);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 39);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear Selections";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // populateButton
            // 
            this.populateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populateButton.Location = new System.Drawing.Point(632, 291);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(103, 40);
            this.populateButton.TabIndex = 9;
            this.populateButton.Text = "Save Grade";
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.populateButton_Click);
            // 
            // selectStudentErrorLabel
            // 
            this.selectStudentErrorLabel.AutoSize = true;
            this.selectStudentErrorLabel.Location = new System.Drawing.Point(426, 210);
            this.selectStudentErrorLabel.Name = "selectStudentErrorLabel";
            this.selectStudentErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.selectStudentErrorLabel.TabIndex = 12;
            // 
            // selectStudentComboBox
            // 
            this.selectStudentComboBox.FormattingEnabled = true;
            this.selectStudentComboBox.Location = new System.Drawing.Point(426, 182);
            this.selectStudentComboBox.Name = "selectStudentComboBox";
            this.selectStudentComboBox.Size = new System.Drawing.Size(309, 21);
            this.selectStudentComboBox.TabIndex = 11;
            this.selectStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selectStudentLabel
            // 
            this.selectStudentLabel.AutoSize = true;
            this.selectStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectStudentLabel.Location = new System.Drawing.Point(238, 183);
            this.selectStudentLabel.Name = "selectStudentLabel";
            this.selectStudentLabel.Size = new System.Drawing.Size(129, 20);
            this.selectStudentLabel.TabIndex = 10;
            this.selectStudentLabel.Text = "Select Student";
            // 
            // inputGradeLabel
            // 
            this.inputGradeLabel.AutoSize = true;
            this.inputGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGradeLabel.Location = new System.Drawing.Point(261, 236);
            this.inputGradeLabel.Name = "inputGradeLabel";
            this.inputGradeLabel.Size = new System.Drawing.Size(106, 20);
            this.inputGradeLabel.TabIndex = 13;
            this.inputGradeLabel.Text = "Input Grade";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(426, 235);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(309, 20);
            this.gradeTextBox.TabIndex = 14;
            // 
            // gradeErrorMessageLabel
            // 
            this.gradeErrorMessageLabel.AutoSize = true;
            this.gradeErrorMessageLabel.Location = new System.Drawing.Point(426, 258);
            this.gradeErrorMessageLabel.Name = "gradeErrorMessageLabel";
            this.gradeErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.gradeErrorMessageLabel.TabIndex = 15;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // weightGradeDataGridViewTextBoxColumn
            // 
            this.weightGradeDataGridViewTextBoxColumn.DataPropertyName = "WeightGrade";
            this.weightGradeDataGridViewTextBoxColumn.HeaderText = "WeightGrade";
            this.weightGradeDataGridViewTextBoxColumn.Name = "weightGradeDataGridViewTextBoxColumn";
            this.weightGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.HeaderText = "Edit";
            this.Add.Name = "Add";
            this.Add.Text = "Update";
            this.Add.UseColumnTextForButtonValue = true;
            // 
            // TeacherGradingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradeErrorMessageLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.inputGradeLabel);
            this.Controls.Add(this.selectStudentErrorLabel);
            this.Controls.Add(this.selectStudentComboBox);
            this.Controls.Add(this.selectStudentLabel);
            this.Controls.Add(this.populateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.selectAssignmentErrorLabel);
            this.Controls.Add(this.selectClassErrorLabel);
            this.Controls.Add(this.studentGradesDataGridView);
            this.Controls.Add(this.selectAssignmentComboBox);
            this.Controls.Add(this.selectClassComboBox);
            this.Controls.Add(this.selectAssignmentLabel);
            this.Controls.Add(this.selectCourseLabel);
            this.Name = "TeacherGradingUserControl";
            this.Size = new System.Drawing.Size(1033, 672);
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectCourseLabel;
        private System.Windows.Forms.Label selectAssignmentLabel;
        private System.Windows.Forms.ComboBox selectClassComboBox;
        private System.Windows.Forms.ComboBox selectAssignmentComboBox;
        private System.Windows.Forms.DataGridView studentGradesDataGridView;
        private System.Windows.Forms.Label selectClassErrorLabel;
        private System.Windows.Forms.Label selectAssignmentErrorLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button populateButton;
        private System.Windows.Forms.Label selectStudentErrorLabel;
        private System.Windows.Forms.ComboBox selectStudentComboBox;
        private System.Windows.Forms.Label selectStudentLabel;
        private System.Windows.Forms.Label inputGradeLabel;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label gradeErrorMessageLabel;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
    }
}
