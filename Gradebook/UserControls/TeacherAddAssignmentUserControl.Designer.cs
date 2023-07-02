namespace Gradebook.UserControls
{
    partial class TeacherAddAssignmentUserControl
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
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.assignmentTypeLabel = new System.Windows.Forms.Label();
            this.assignmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.classAssignmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.classAssignmentsLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.classErrorMessageLabel = new System.Windows.Forms.Label();
            this.weightErrorMessageLabel = new System.Windows.Forms.Label();
            this.assignmentTypeErrorMessageLabel = new System.Windows.Forms.Label();
            this.descriptionErrorMessageLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.currentAssignmentsButton = new System.Windows.Forms.Button();
            this.UpdateGradeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.assignmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classAssignmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.AutoSize = true;
            this.selectClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectClassLabel.Location = new System.Drawing.Point(48, 53);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(114, 20);
            this.selectClassLabel.TabIndex = 0;
            this.selectClassLabel.Text = "Select Class:";
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Location = new System.Drawing.Point(181, 52);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(288, 21);
            this.selectClassComboBox.TabIndex = 1;
            this.selectClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // assignmentTypeLabel
            // 
            this.assignmentTypeLabel.AutoSize = true;
            this.assignmentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentTypeLabel.Location = new System.Drawing.Point(548, 55);
            this.assignmentTypeLabel.Name = "assignmentTypeLabel";
            this.assignmentTypeLabel.Size = new System.Drawing.Size(52, 20);
            this.assignmentTypeLabel.TabIndex = 2;
            this.assignmentTypeLabel.Text = "Type:";
            // 
            // assignmentTypeComboBox
            // 
            this.assignmentTypeComboBox.FormattingEnabled = true;
            this.assignmentTypeComboBox.Location = new System.Drawing.Point(629, 54);
            this.assignmentTypeComboBox.Name = "assignmentTypeComboBox";
            this.assignmentTypeComboBox.Size = new System.Drawing.Size(253, 21);
            this.assignmentTypeComboBox.TabIndex = 2;
            this.assignmentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // classAssignmentsDataGridView
            // 
            this.classAssignmentsDataGridView.AllowUserToAddRows = false;
            this.classAssignmentsDataGridView.AllowUserToDeleteRows = false;
            this.classAssignmentsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classAssignmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.classAssignmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classAssignmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignmentIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.UpdateGradeButton});
            this.classAssignmentsDataGridView.DataSource = this.assignmentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classAssignmentsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.classAssignmentsDataGridView.Location = new System.Drawing.Point(128, 351);
            this.classAssignmentsDataGridView.Name = "classAssignmentsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classAssignmentsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.classAssignmentsDataGridView.Size = new System.Drawing.Size(756, 238);
            this.classAssignmentsDataGridView.TabIndex = 4;
            this.classAssignmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassAssignmentDataGridView_CellContentClick);
            this.classAssignmentsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.classAssignmentsDataGridView_DataError);
            // 
            // classAssignmentsLabel
            // 
            this.classAssignmentsLabel.AutoSize = true;
            this.classAssignmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classAssignmentsLabel.Location = new System.Drawing.Point(124, 318);
            this.classAssignmentsLabel.Name = "classAssignmentsLabel";
            this.classAssignmentsLabel.Size = new System.Drawing.Size(161, 20);
            this.classAssignmentsLabel.TabIndex = 5;
            this.classAssignmentsLabel.Text = "Class Assignments";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(89, 132);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(70, 20);
            this.weightLabel.TabIndex = 6;
            this.weightLabel.Text = "Weight:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(495, 132);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(105, 20);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(633, 131);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(249, 75);
            this.descriptionRichTextBox.TabIndex = 4;
            this.descriptionRichTextBox.Text = "";
            this.descriptionRichTextBox.TextChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(260, 237);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(174, 49);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear Assignment";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(572, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(174, 49);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Assignment";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // classErrorMessageLabel
            // 
            this.classErrorMessageLabel.AutoSize = true;
            this.classErrorMessageLabel.Location = new System.Drawing.Point(178, 76);
            this.classErrorMessageLabel.Name = "classErrorMessageLabel";
            this.classErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.classErrorMessageLabel.TabIndex = 13;
            // 
            // weightErrorMessageLabel
            // 
            this.weightErrorMessageLabel.AutoSize = true;
            this.weightErrorMessageLabel.Location = new System.Drawing.Point(175, 155);
            this.weightErrorMessageLabel.Name = "weightErrorMessageLabel";
            this.weightErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.weightErrorMessageLabel.TabIndex = 14;
            // 
            // assignmentTypeErrorMessageLabel
            // 
            this.assignmentTypeErrorMessageLabel.AutoSize = true;
            this.assignmentTypeErrorMessageLabel.Location = new System.Drawing.Point(629, 79);
            this.assignmentTypeErrorMessageLabel.Name = "assignmentTypeErrorMessageLabel";
            this.assignmentTypeErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.assignmentTypeErrorMessageLabel.TabIndex = 15;
            // 
            // descriptionErrorMessageLabel
            // 
            this.descriptionErrorMessageLabel.AutoSize = true;
            this.descriptionErrorMessageLabel.Location = new System.Drawing.Point(633, 213);
            this.descriptionErrorMessageLabel.Name = "descriptionErrorMessageLabel";
            this.descriptionErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionErrorMessageLabel.TabIndex = 16;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(181, 131);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(288, 20);
            this.weightTextBox.TabIndex = 17;
            this.weightTextBox.TextChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // currentAssignmentsButton
            // 
            this.currentAssignmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAssignmentsButton.Location = new System.Drawing.Point(291, 91);
            this.currentAssignmentsButton.Name = "currentAssignmentsButton";
            this.currentAssignmentsButton.Size = new System.Drawing.Size(178, 34);
            this.currentAssignmentsButton.TabIndex = 18;
            this.currentAssignmentsButton.Text = "See Current Assignments";
            this.currentAssignmentsButton.UseVisualStyleBackColor = true;
            this.currentAssignmentsButton.Click += new System.EventHandler(this.currentAssignmentsButton_Click);
            // 
            // UpdateGradeButton
            // 
            this.UpdateGradeButton.HeaderText = "Update";
            this.UpdateGradeButton.Name = "UpdateGradeButton";
            this.UpdateGradeButton.Text = "Update";
            this.UpdateGradeButton.UseColumnTextForButtonValue = true;
            // 
            // assignmentIDDataGridViewTextBoxColumn
            // 
            this.assignmentIDDataGridViewTextBoxColumn.DataPropertyName = "AssignmentID";
            this.assignmentIDDataGridViewTextBoxColumn.FillWeight = 111.6751F;
            this.assignmentIDDataGridViewTextBoxColumn.HeaderText = "AssignmentID";
            this.assignmentIDDataGridViewTextBoxColumn.Name = "assignmentIDDataGridViewTextBoxColumn";
            this.assignmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.assignmentIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.FillWeight = 96.10829F;
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 96.10829F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.FillWeight = 96.10829F;
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 75;
            // 
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataSource = typeof(Gradebook.Model.Assignment);
            // 
            // TeacherAddAssignmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentAssignmentsButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.descriptionErrorMessageLabel);
            this.Controls.Add(this.assignmentTypeErrorMessageLabel);
            this.Controls.Add(this.weightErrorMessageLabel);
            this.Controls.Add(this.classErrorMessageLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.classAssignmentsLabel);
            this.Controls.Add(this.classAssignmentsDataGridView);
            this.Controls.Add(this.assignmentTypeComboBox);
            this.Controls.Add(this.assignmentTypeLabel);
            this.Controls.Add(this.selectClassComboBox);
            this.Controls.Add(this.selectClassLabel);
            this.Name = "TeacherAddAssignmentUserControl";
            this.Size = new System.Drawing.Size(999, 636);
            ((System.ComponentModel.ISupportInitialize)(this.classAssignmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectClassLabel;
        private System.Windows.Forms.ComboBox selectClassComboBox;
        private System.Windows.Forms.Label assignmentTypeLabel;
        private System.Windows.Forms.ComboBox assignmentTypeComboBox;
        private System.Windows.Forms.DataGridView classAssignmentsDataGridView;
        private System.Windows.Forms.Label classAssignmentsLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label classErrorMessageLabel;
        private System.Windows.Forms.Label weightErrorMessageLabel;
        private System.Windows.Forms.Label assignmentTypeErrorMessageLabel;
        private System.Windows.Forms.Label descriptionErrorMessageLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private System.Windows.Forms.Button currentAssignmentsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateGradeButton;
    }
}
