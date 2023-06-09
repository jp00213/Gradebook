﻿namespace Gradebook.View
{
    partial class AdministratorTeachers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminTeacherTabControl = new System.Windows.Forms.TabControl();
            this.addTeacherTabPage = new System.Windows.Forms.TabPage();
            this.addTeacherUserControl1 = new Gradebook.UserControls.AddTeacherUserControl();
            this.updateTeacherTabPage = new System.Windows.Forms.TabPage();
            this.updateTeacherUserControl1 = new Gradebook.UserControls.UpdateTeacherUserControl();
            this.rosterTabPage = new System.Windows.Forms.TabPage();
            this.rosterUserControl1 = new Gradebook.UserControls.RosterUserControl();
            this.courseGradesTabPage = new System.Windows.Forms.TabPage();
            this.backHomeButton = new System.Windows.Forms.Button();
            this.courseGradesUserControl1 = new Gradebook.UserControls.CourseGradesUserControl();
            this.adminTeacherTabControl.SuspendLayout();
            this.addTeacherTabPage.SuspendLayout();
            this.updateTeacherTabPage.SuspendLayout();
            this.rosterTabPage.SuspendLayout();
            this.courseGradesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTeacherTabControl
            // 
            this.adminTeacherTabControl.Controls.Add(this.addTeacherTabPage);
            this.adminTeacherTabControl.Controls.Add(this.updateTeacherTabPage);
            this.adminTeacherTabControl.Controls.Add(this.rosterTabPage);
            this.adminTeacherTabControl.Controls.Add(this.courseGradesTabPage);
            this.adminTeacherTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTeacherTabControl.Location = new System.Drawing.Point(-4, 61);
            this.adminTeacherTabControl.Name = "adminTeacherTabControl";
            this.adminTeacherTabControl.SelectedIndex = 0;
            this.adminTeacherTabControl.Size = new System.Drawing.Size(1108, 659);
            this.adminTeacherTabControl.TabIndex = 0;
            // 
            // addTeacherTabPage
            // 
            this.addTeacherTabPage.Controls.Add(this.addTeacherUserControl1);
            this.addTeacherTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacherTabPage.Location = new System.Drawing.Point(4, 29);
            this.addTeacherTabPage.Name = "addTeacherTabPage";
            this.addTeacherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTeacherTabPage.Size = new System.Drawing.Size(1100, 626);
            this.addTeacherTabPage.TabIndex = 0;
            this.addTeacherTabPage.Text = "Add Teacher";
            this.addTeacherTabPage.UseVisualStyleBackColor = true;
            // 
            // addTeacherUserControl1
            // 
            this.addTeacherUserControl1.Location = new System.Drawing.Point(43, 3);
            this.addTeacherUserControl1.Name = "addTeacherUserControl1";
            this.addTeacherUserControl1.Size = new System.Drawing.Size(878, 521);
            this.addTeacherUserControl1.TabIndex = 0;
            // 
            // updateTeacherTabPage
            // 
            this.updateTeacherTabPage.Controls.Add(this.updateTeacherUserControl1);
            this.updateTeacherTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTeacherTabPage.Location = new System.Drawing.Point(4, 29);
            this.updateTeacherTabPage.Name = "updateTeacherTabPage";
            this.updateTeacherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateTeacherTabPage.Size = new System.Drawing.Size(1100, 626);
            this.updateTeacherTabPage.TabIndex = 2;
            this.updateTeacherTabPage.Text = "Update Teacher";
            this.updateTeacherTabPage.UseVisualStyleBackColor = true;
            // 
            // updateTeacherUserControl1
            // 
            this.updateTeacherUserControl1.Location = new System.Drawing.Point(52, -11);
            this.updateTeacherUserControl1.Name = "updateTeacherUserControl1";
            this.updateTeacherUserControl1.Size = new System.Drawing.Size(1003, 634);
            this.updateTeacherUserControl1.TabIndex = 0;
            // 
            // rosterTabPage
            // 
            this.rosterTabPage.Controls.Add(this.rosterUserControl1);
            this.rosterTabPage.Location = new System.Drawing.Point(4, 29);
            this.rosterTabPage.Name = "rosterTabPage";
            this.rosterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rosterTabPage.Size = new System.Drawing.Size(1100, 626);
            this.rosterTabPage.TabIndex = 3;
            this.rosterTabPage.Text = "Roster";
            this.rosterTabPage.UseVisualStyleBackColor = true;
            // 
            // rosterUserControl1
            // 
            this.rosterUserControl1.Location = new System.Drawing.Point(22, 8);
            this.rosterUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rosterUserControl1.Name = "rosterUserControl1";
            this.rosterUserControl1.Size = new System.Drawing.Size(1067, 579);
            this.rosterUserControl1.TabIndex = 0;
            // 
            // courseGradesTabPage
            // 
            this.courseGradesTabPage.Controls.Add(this.courseGradesUserControl1);
            this.courseGradesTabPage.Location = new System.Drawing.Point(4, 29);
            this.courseGradesTabPage.Name = "courseGradesTabPage";
            this.courseGradesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.courseGradesTabPage.Size = new System.Drawing.Size(1100, 626);
            this.courseGradesTabPage.TabIndex = 4;
            this.courseGradesTabPage.Text = "Course Grades";
            this.courseGradesTabPage.UseVisualStyleBackColor = true;
            // 
            // backHomeButton
            // 
            this.backHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backHomeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backHomeButton.Location = new System.Drawing.Point(22, 13);
            this.backHomeButton.Name = "backHomeButton";
            this.backHomeButton.Size = new System.Drawing.Size(104, 30);
            this.backHomeButton.TabIndex = 1;
            this.backHomeButton.Text = "Home";
            this.backHomeButton.UseVisualStyleBackColor = true;
            this.backHomeButton.Click += new System.EventHandler(this.backHomeButton_Click);
            // 
            // courseGradesUserControl1
            // 
            this.courseGradesUserControl1.Location = new System.Drawing.Point(13, 8);
            this.courseGradesUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseGradesUserControl1.Name = "courseGradesUserControl1";
            this.courseGradesUserControl1.Size = new System.Drawing.Size(1010, 640);
            this.courseGradesUserControl1.TabIndex = 0;
            // 
            // AdministratorTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 713);
            this.Controls.Add(this.backHomeButton);
            this.Controls.Add(this.adminTeacherTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorTeachers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorTeachers_FormClosed);
            this.adminTeacherTabControl.ResumeLayout(false);
            this.addTeacherTabPage.ResumeLayout(false);
            this.updateTeacherTabPage.ResumeLayout(false);
            this.rosterTabPage.ResumeLayout(false);
            this.courseGradesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTeacherTabControl;
        private System.Windows.Forms.TabPage addTeacherTabPage;
        private System.Windows.Forms.TabPage updateTeacherTabPage;
        private System.Windows.Forms.Button backHomeButton;
        private UserControls.AddTeacherUserControl addTeacherUserControl1;
        private UserControls.UpdateTeacherUserControl updateTeacherUserControl1;
        private System.Windows.Forms.TabPage rosterTabPage;
        private UserControls.RosterUserControl rosterUserControl1;
        private System.Windows.Forms.TabPage courseGradesTabPage;
        private UserControls.CourseGradesUserControl courseGradesUserControl1;
    }
}