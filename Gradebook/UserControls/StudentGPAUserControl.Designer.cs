namespace Gradebook.UserControls
{
    partial class StudentGPAUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fullRecordLabel = new System.Windows.Forms.Label();
            this.cumulativeGPADataLabel = new System.Windows.Forms.Label();
            this.cumulativeGPALabel = new System.Windows.Forms.Label();
            this.completeGradelabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.currentStudentID = new System.Windows.Forms.Label();
            this.currentStudentIDSetLabel = new System.Windows.Forms.Label();
            this.completeGradeListView = new System.Windows.Forms.ListView();
            this.courseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.letterrGadeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pointHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.letterGradeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.completeGradeListView);
            this.panel1.Controls.Add(this.fullRecordLabel);
            this.panel1.Controls.Add(this.cumulativeGPADataLabel);
            this.panel1.Controls.Add(this.cumulativeGPALabel);
            this.panel1.Controls.Add(this.completeGradelabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.currentStudentID);
            this.panel1.Controls.Add(this.currentStudentIDSetLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 618);
            this.panel1.TabIndex = 0;
            // 
            // fullRecordLabel
            // 
            this.fullRecordLabel.AutoSize = true;
            this.fullRecordLabel.Location = new System.Drawing.Point(44, 24);
            this.fullRecordLabel.Name = "fullRecordLabel";
            this.fullRecordLabel.Size = new System.Drawing.Size(10, 13);
            this.fullRecordLabel.TabIndex = 77;
            this.fullRecordLabel.Text = "-";
            // 
            // cumulativeGPADataLabel
            // 
            this.cumulativeGPADataLabel.AutoSize = true;
            this.cumulativeGPADataLabel.Location = new System.Drawing.Point(295, 11);
            this.cumulativeGPADataLabel.Name = "cumulativeGPADataLabel";
            this.cumulativeGPADataLabel.Size = new System.Drawing.Size(10, 13);
            this.cumulativeGPADataLabel.TabIndex = 76;
            this.cumulativeGPADataLabel.Text = "-";
            // 
            // cumulativeGPALabel
            // 
            this.cumulativeGPALabel.AutoSize = true;
            this.cumulativeGPALabel.Location = new System.Drawing.Point(202, 11);
            this.cumulativeGPALabel.Name = "cumulativeGPALabel";
            this.cumulativeGPALabel.Size = new System.Drawing.Size(87, 13);
            this.cumulativeGPALabel.TabIndex = 75;
            this.cumulativeGPALabel.Text = "Cumulative GPA:";
            // 
            // completeGradelabel
            // 
            this.completeGradelabel.AutoSize = true;
            this.completeGradelabel.Location = new System.Drawing.Point(19, 11);
            this.completeGradelabel.Name = "completeGradelabel";
            this.completeGradelabel.Size = new System.Drawing.Size(152, 13);
            this.completeGradelabel.TabIndex = 74;
            this.completeGradelabel.Text = "Complete Summary Information";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(557, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(13, 13);
            this.nameLabel.TabIndex = 71;
            this.nameLabel.Text = "--";
            // 
            // currentStudentID
            // 
            this.currentStudentID.AutoSize = true;
            this.currentStudentID.Location = new System.Drawing.Point(538, 11);
            this.currentStudentID.Name = "currentStudentID";
            this.currentStudentID.Size = new System.Drawing.Size(13, 13);
            this.currentStudentID.TabIndex = 70;
            this.currentStudentID.Text = "0";
            // 
            // currentStudentIDSetLabel
            // 
            this.currentStudentIDSetLabel.AutoSize = true;
            this.currentStudentIDSetLabel.Location = new System.Drawing.Point(471, 11);
            this.currentStudentIDSetLabel.Name = "currentStudentIDSetLabel";
            this.currentStudentIDSetLabel.Size = new System.Drawing.Size(61, 13);
            this.currentStudentIDSetLabel.TabIndex = 69;
            this.currentStudentIDSetLabel.Text = "Student ID:";
            // 
            // completeGradeListView
            // 
            this.completeGradeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseHeader,
            this.nameHeader,
            this.unitHeader,
            this.letterrGadeHeader,
            this.pointHeader,
            this.letterGradeHeader});
            this.completeGradeListView.HideSelection = false;
            this.completeGradeListView.Location = new System.Drawing.Point(14, 49);
            this.completeGradeListView.Name = "completeGradeListView";
            this.completeGradeListView.Size = new System.Drawing.Size(674, 318);
            this.completeGradeListView.TabIndex = 78;
            this.completeGradeListView.UseCompatibleStateImageBehavior = false;
            this.completeGradeListView.View = System.Windows.Forms.View.Details;
            // 
            // courseHeader
            // 
            this.courseHeader.Text = "Course";
            this.courseHeader.Width = 110;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Course Name";
            this.nameHeader.Width = 150;
            // 
            // unitHeader
            // 
            this.unitHeader.Text = "Units";
            this.unitHeader.Width = 70;
            // 
            // letterrGadeHeader
            // 
            this.letterrGadeHeader.Text = "Score";
            this.letterrGadeHeader.Width = 90;
            // 
            // pointHeader
            // 
            this.pointHeader.Text = "Points";
            this.pointHeader.Width = 115;
            // 
            // letterGradeHeader
            // 
            this.letterGradeHeader.Text = "Letter Grade";
            this.letterGradeHeader.Width = 100;
            // 
            // StudentGPAUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StudentGPAUserControl";
            this.Size = new System.Drawing.Size(960, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fullRecordLabel;
        private System.Windows.Forms.Label cumulativeGPADataLabel;
        private System.Windows.Forms.Label cumulativeGPALabel;
        private System.Windows.Forms.Label completeGradelabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label currentStudentID;
        private System.Windows.Forms.Label currentStudentIDSetLabel;
        private System.Windows.Forms.ListView completeGradeListView;
        private System.Windows.Forms.ColumnHeader courseHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader unitHeader;
        private System.Windows.Forms.ColumnHeader letterrGadeHeader;
        private System.Windows.Forms.ColumnHeader pointHeader;
        private System.Windows.Forms.ColumnHeader letterGradeHeader;
    }
}
