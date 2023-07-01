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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectCourseLabel = new System.Windows.Forms.Label();
            this.selectAssignmentLabel = new System.Windows.Forms.Label();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.selectAssignmentComboBox = new System.Windows.Forms.ComboBox();
            this.studentGradesDataGridView = new System.Windows.Forms.DataGridView();
            this.selectClassErrorLabel = new System.Windows.Forms.Label();
            this.selectAssignmentErrorLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGradesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentGradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGradesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentGradesDataGridView.Location = new System.Drawing.Point(73, 198);
            this.studentGradesDataGridView.Name = "studentGradesDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGradesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.instructionsLabel.Location = new System.Drawing.Point(291, 27);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(409, 15);
            this.instructionsLabel.TabIndex = 7;
            this.instructionsLabel.Text = "Select course and Assignment to populate grading table and input grades.";
            // 
            // TeacherGradingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
