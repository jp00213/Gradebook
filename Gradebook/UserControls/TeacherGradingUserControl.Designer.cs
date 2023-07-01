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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectCourseLabel = new System.Windows.Forms.Label();
            this.selectAssignmentLabel = new System.Windows.Forms.Label();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.selectAssignmentComboBox = new System.Windows.Forms.ComboBox();
            this.studentGradesDataGridView = new System.Windows.Forms.DataGridView();
            this.selectClassErrorLabel = new System.Windows.Forms.Label();
            this.selectAssignmentErrorLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.populateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesDataGridView)).BeginInit();
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
            // 
            // studentGradesDataGridView
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGradesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentGradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGradesDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.studentGradesDataGridView.Location = new System.Drawing.Point(72, 211);
            this.studentGradesDataGridView.Name = "studentGradesDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGradesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.studentGradesDataGridView.Size = new System.Drawing.Size(894, 395);
            this.studentGradesDataGridView.TabIndex = 4;
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
            this.instructionsLabel.Location = new System.Drawing.Point(303, 27);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(432, 15);
            this.instructionsLabel.TabIndex = 7;
            this.instructionsLabel.Text = "Select course and assignment, then click the populate button to begin grading.";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(426, 158);
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
            this.populateButton.Location = new System.Drawing.Point(632, 157);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(103, 40);
            this.populateButton.TabIndex = 9;
            this.populateButton.Text = "Populate";
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.populateButton_Click);
            // 
            // TeacherGradingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
