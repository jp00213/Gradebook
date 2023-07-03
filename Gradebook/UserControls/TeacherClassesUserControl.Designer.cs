namespace Gradebook.UserControls
{
    partial class TeacherClassesUserControl
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
            this.currentClassesLabel = new System.Windows.Forms.Label();
            this.pastClassesLabel = new System.Windows.Forms.Label();
            this.futureClassesLabel = new System.Windows.Forms.Label();
            this.currentClassDataGridView = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pastClasseseDataGridView = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefixDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHoursDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futureClassesDataGridView = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefixDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHoursDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.currentClassDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastClasseseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futureClassesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // currentClassesLabel
            // 
            this.currentClassesLabel.AutoSize = true;
            this.currentClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentClassesLabel.Location = new System.Drawing.Point(113, 31);
            this.currentClassesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentClassesLabel.Name = "currentClassesLabel";
            this.currentClassesLabel.Size = new System.Drawing.Size(168, 25);
            this.currentClassesLabel.TabIndex = 0;
            this.currentClassesLabel.Text = "Current Classes";
            // 
            // pastClassesLabel
            // 
            this.pastClassesLabel.AutoSize = true;
            this.pastClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastClassesLabel.Location = new System.Drawing.Point(117, 268);
            this.pastClassesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pastClassesLabel.Name = "pastClassesLabel";
            this.pastClassesLabel.Size = new System.Drawing.Size(139, 25);
            this.pastClassesLabel.TabIndex = 1;
            this.pastClassesLabel.Text = "Past Classes";
            // 
            // futureClassesLabel
            // 
            this.futureClassesLabel.AutoSize = true;
            this.futureClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureClassesLabel.Location = new System.Drawing.Point(117, 507);
            this.futureClassesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.futureClassesLabel.Name = "futureClassesLabel";
            this.futureClassesLabel.Size = new System.Drawing.Size(158, 25);
            this.futureClassesLabel.TabIndex = 4;
            this.futureClassesLabel.Text = "Future Classes";
            // 
            // currentClassDataGridView
            // 
            this.currentClassDataGridView.AllowUserToAddRows = false;
            this.currentClassDataGridView.AllowUserToDeleteRows = false;
            this.currentClassDataGridView.AutoGenerateColumns = false;
            this.currentClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentClassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.prefixDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.creditHoursDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.currentClassDataGridView.DataSource = this.courseBindingSource;
            this.currentClassDataGridView.Location = new System.Drawing.Point(123, 60);
            this.currentClassDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentClassDataGridView.Name = "currentClassDataGridView";
            this.currentClassDataGridView.ReadOnly = true;
            this.currentClassDataGridView.RowHeadersWidth = 51;
            this.currentClassDataGridView.Size = new System.Drawing.Size(1031, 186);
            this.currentClassDataGridView.TabIndex = 5;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prefixDataGridViewTextBoxColumn
            // 
            this.prefixDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prefixDataGridViewTextBoxColumn.DataPropertyName = "Prefix";
            this.prefixDataGridViewTextBoxColumn.HeaderText = "Prefix";
            this.prefixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prefixDataGridViewTextBoxColumn.Name = "prefixDataGridViewTextBoxColumn";
            this.prefixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditHoursDataGridViewTextBoxColumn
            // 
            this.creditHoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creditHoursDataGridViewTextBoxColumn.DataPropertyName = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn.HeaderText = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditHoursDataGridViewTextBoxColumn.Name = "creditHoursDataGridViewTextBoxColumn";
            this.creditHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Semester";
            this.dataGridViewTextBoxColumn1.HeaderText = "Semester";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn2.HeaderText = "Year";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(Gradebook.Model.Course);
            // 
            // pastClasseseDataGridView
            // 
            this.pastClasseseDataGridView.AllowUserToAddRows = false;
            this.pastClasseseDataGridView.AllowUserToDeleteRows = false;
            this.pastClasseseDataGridView.AutoGenerateColumns = false;
            this.pastClasseseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastClasseseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.prefixDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn1,
            this.sectionDataGridViewTextBoxColumn1,
            this.creditHoursDataGridViewTextBoxColumn1,
            this.Semester,
            this.Year});
            this.pastClasseseDataGridView.DataSource = this.courseBindingSource;
            this.pastClasseseDataGridView.Location = new System.Drawing.Point(121, 297);
            this.pastClasseseDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pastClasseseDataGridView.Name = "pastClasseseDataGridView";
            this.pastClasseseDataGridView.ReadOnly = true;
            this.pastClasseseDataGridView.RowHeadersWidth = 51;
            this.pastClasseseDataGridView.Size = new System.Drawing.Size(1031, 186);
            this.pastClasseseDataGridView.TabIndex = 6;
            // 
            // courseIDDataGridViewTextBoxColumn1
            // 
            this.courseIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseIDDataGridViewTextBoxColumn1.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn1.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn1.Name = "courseIDDataGridViewTextBoxColumn1";
            this.courseIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prefixDataGridViewTextBoxColumn1
            // 
            this.prefixDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prefixDataGridViewTextBoxColumn1.DataPropertyName = "Prefix";
            this.prefixDataGridViewTextBoxColumn1.HeaderText = "Prefix";
            this.prefixDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prefixDataGridViewTextBoxColumn1.Name = "prefixDataGridViewTextBoxColumn1";
            this.prefixDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn1.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            this.numberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn1
            // 
            this.sectionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sectionDataGridViewTextBoxColumn1.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn1.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn1.Name = "sectionDataGridViewTextBoxColumn1";
            this.sectionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // creditHoursDataGridViewTextBoxColumn1
            // 
            this.creditHoursDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creditHoursDataGridViewTextBoxColumn1.DataPropertyName = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn1.HeaderText = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.creditHoursDataGridViewTextBoxColumn1.Name = "creditHoursDataGridViewTextBoxColumn1";
            this.creditHoursDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // futureClassesDataGridView
            // 
            this.futureClassesDataGridView.AllowUserToAddRows = false;
            this.futureClassesDataGridView.AllowUserToDeleteRows = false;
            this.futureClassesDataGridView.AutoGenerateColumns = false;
            this.futureClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.futureClassesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.prefixDataGridViewTextBoxColumn2,
            this.numberDataGridViewTextBoxColumn2,
            this.sectionDataGridViewTextBoxColumn2,
            this.creditHoursDataGridViewTextBoxColumn2,
            this.semesterDataGridViewTextBoxColumn2,
            this.yearDataGridViewTextBoxColumn2});
            this.futureClassesDataGridView.DataSource = this.courseBindingSource;
            this.futureClassesDataGridView.Location = new System.Drawing.Point(123, 535);
            this.futureClassesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.futureClassesDataGridView.Name = "futureClassesDataGridView";
            this.futureClassesDataGridView.ReadOnly = true;
            this.futureClassesDataGridView.RowHeadersWidth = 51;
            this.futureClassesDataGridView.Size = new System.Drawing.Size(1031, 186);
            this.futureClassesDataGridView.TabIndex = 7;
            // 
            // courseIDDataGridViewTextBoxColumn2
            // 
            this.courseIDDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseIDDataGridViewTextBoxColumn2.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn2.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn2.Name = "courseIDDataGridViewTextBoxColumn2";
            this.courseIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // prefixDataGridViewTextBoxColumn2
            // 
            this.prefixDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prefixDataGridViewTextBoxColumn2.DataPropertyName = "Prefix";
            this.prefixDataGridViewTextBoxColumn2.HeaderText = "Prefix";
            this.prefixDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.prefixDataGridViewTextBoxColumn2.Name = "prefixDataGridViewTextBoxColumn2";
            this.prefixDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn2
            // 
            this.numberDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberDataGridViewTextBoxColumn2.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn2.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn2.Name = "numberDataGridViewTextBoxColumn2";
            this.numberDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn2
            // 
            this.sectionDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sectionDataGridViewTextBoxColumn2.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn2.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn2.Name = "sectionDataGridViewTextBoxColumn2";
            this.sectionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // creditHoursDataGridViewTextBoxColumn2
            // 
            this.creditHoursDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creditHoursDataGridViewTextBoxColumn2.DataPropertyName = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn2.HeaderText = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.creditHoursDataGridViewTextBoxColumn2.Name = "creditHoursDataGridViewTextBoxColumn2";
            this.creditHoursDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn2
            // 
            this.semesterDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semesterDataGridViewTextBoxColumn2.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn2.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn2.Name = "semesterDataGridViewTextBoxColumn2";
            this.semesterDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn2
            // 
            this.yearDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearDataGridViewTextBoxColumn2.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn2.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn2.Name = "yearDataGridViewTextBoxColumn2";
            this.yearDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TeacherClassesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.futureClassesDataGridView);
            this.Controls.Add(this.pastClasseseDataGridView);
            this.Controls.Add(this.currentClassDataGridView);
            this.Controls.Add(this.futureClassesLabel);
            this.Controls.Add(this.pastClassesLabel);
            this.Controls.Add(this.currentClassesLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherClassesUserControl";
            this.Size = new System.Drawing.Size(1260, 725);
            ((System.ComponentModel.ISupportInitialize)(this.currentClassDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastClasseseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futureClassesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentClassesLabel;
        private System.Windows.Forms.Label pastClassesLabel;
        private System.Windows.Forms.Label futureClassesLabel;
        private System.Windows.Forms.DataGridView currentClassDataGridView;
        private System.Windows.Forms.DataGridView pastClasseseDataGridView;
        private System.Windows.Forms.DataGridView futureClassesDataGridView;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefixDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHoursDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefixDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHoursDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn2;
    }
}
