namespace Gradebook.UserControls
{
    partial class TeacherGradesUserControl
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
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.selectAssignmentLabel = new System.Windows.Forms.Label();
            this.studentGradesDataGridView = new System.Windows.Forms.DataGridView();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.selectAssignmentComboBox = new System.Windows.Forms.ComboBox();
            this.selectClassErrorLabel = new System.Windows.Forms.Label();
            this.selectAssignmentErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.AutoSize = true;
            this.selectClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectClassLabel.Location = new System.Drawing.Point(248, 66);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(109, 20);
            this.selectClassLabel.TabIndex = 0;
            this.selectClassLabel.Text = "Select Class";
            // 
            // selectAssignmentLabel
            // 
            this.selectAssignmentLabel.AutoSize = true;
            this.selectAssignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAssignmentLabel.Location = new System.Drawing.Point(198, 121);
            this.selectAssignmentLabel.Name = "selectAssignmentLabel";
            this.selectAssignmentLabel.Size = new System.Drawing.Size(159, 20);
            this.selectAssignmentLabel.TabIndex = 1;
            this.selectAssignmentLabel.Text = "Select Assignment";
            // 
            // studentGradesDataGridView
            // 
            this.studentGradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGradesDataGridView.Location = new System.Drawing.Point(93, 214);
            this.studentGradesDataGridView.Name = "studentGradesDataGridView";
            this.studentGradesDataGridView.Size = new System.Drawing.Size(807, 380);
            this.studentGradesDataGridView.TabIndex = 2;
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Location = new System.Drawing.Point(421, 66);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(363, 21);
            this.selectClassComboBox.TabIndex = 3;
            // 
            // selectAssignmentComboBox
            // 
            this.selectAssignmentComboBox.FormattingEnabled = true;
            this.selectAssignmentComboBox.Location = new System.Drawing.Point(421, 123);
            this.selectAssignmentComboBox.Name = "selectAssignmentComboBox";
            this.selectAssignmentComboBox.Size = new System.Drawing.Size(363, 21);
            this.selectAssignmentComboBox.TabIndex = 4;
            // 
            // selectClassErrorLabel
            // 
            this.selectClassErrorLabel.AutoSize = true;
            this.selectClassErrorLabel.Location = new System.Drawing.Point(421, 94);
            this.selectClassErrorLabel.Name = "selectClassErrorLabel";
            this.selectClassErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.selectClassErrorLabel.TabIndex = 5;
            // 
            // selectAssignmentErrorLabel
            // 
            this.selectAssignmentErrorLabel.AutoSize = true;
            this.selectAssignmentErrorLabel.Location = new System.Drawing.Point(421, 151);
            this.selectAssignmentErrorLabel.Name = "selectAssignmentErrorLabel";
            this.selectAssignmentErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.selectAssignmentErrorLabel.TabIndex = 6;
            // 
            // TeacherGradesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectAssignmentErrorLabel);
            this.Controls.Add(this.selectClassErrorLabel);
            this.Controls.Add(this.selectAssignmentComboBox);
            this.Controls.Add(this.selectClassComboBox);
            this.Controls.Add(this.studentGradesDataGridView);
            this.Controls.Add(this.selectAssignmentLabel);
            this.Controls.Add(this.selectClassLabel);
            this.Name = "TeacherGradesUserControl";
            this.Size = new System.Drawing.Size(995, 647);
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectClassLabel;
        private System.Windows.Forms.Label selectAssignmentLabel;
        private System.Windows.Forms.DataGridView studentGradesDataGridView;
        private System.Windows.Forms.ComboBox selectClassComboBox;
        private System.Windows.Forms.ComboBox selectAssignmentComboBox;
        private System.Windows.Forms.Label selectClassErrorLabel;
        private System.Windows.Forms.Label selectAssignmentErrorLabel;
    }
}
