namespace Gradebook.View
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
            this.backHomeButton = new System.Windows.Forms.Button();
            this.adminTeacherTabControl.SuspendLayout();
            this.addTeacherTabPage.SuspendLayout();
            this.updateTeacherTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTeacherTabControl
            // 
            this.adminTeacherTabControl.Controls.Add(this.addTeacherTabPage);
            this.adminTeacherTabControl.Controls.Add(this.updateTeacherTabPage);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTeacherTabControl;
        private System.Windows.Forms.TabPage addTeacherTabPage;
        private System.Windows.Forms.TabPage updateTeacherTabPage;
        private System.Windows.Forms.Button backHomeButton;
        private UserControls.AddTeacherUserControl addTeacherUserControl1;
        private UserControls.UpdateTeacherUserControl updateTeacherUserControl1;
    }
}