namespace Gradebook.View
{
    partial class AdministratorDashboard
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
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.studentsButton = new System.Windows.Forms.Button();
            this.teachersButton = new System.Windows.Forms.Button();
            this.coursesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutLinkLabel.Location = new System.Drawing.Point(655, 19);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(72, 25);
            this.logoutLinkLabel.TabIndex = 0;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.AutoSize = true;
            this.welcomeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.welcomeUserLabel.Location = new System.Drawing.Point(387, 19);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(234, 25);
            this.welcomeUserLabel.TabIndex = 1;
            this.welcomeUserLabel.Text = "Welcome Unknown User!";
            // 
            // studentsButton
            // 
            this.studentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.studentsButton.Location = new System.Drawing.Point(295, 101);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(170, 67);
            this.studentsButton.TabIndex = 2;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // teachersButton
            // 
            this.teachersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.teachersButton.Location = new System.Drawing.Point(295, 212);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(170, 67);
            this.teachersButton.TabIndex = 3;
            this.teachersButton.Text = "Teachers";
            this.teachersButton.UseVisualStyleBackColor = true;
            this.teachersButton.Click += new System.EventHandler(this.teachersButton_Click);
            // 
            // coursesButton
            // 
            this.coursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.coursesButton.Location = new System.Drawing.Point(295, 323);
            this.coursesButton.Name = "coursesButton";
            this.coursesButton.Size = new System.Drawing.Size(170, 67);
            this.coursesButton.TabIndex = 4;
            this.coursesButton.Text = "Courses";
            this.coursesButton.UseVisualStyleBackColor = true;
            this.coursesButton.Click += new System.EventHandler(this.coursesButton_Click);
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 481);
            this.Controls.Add(this.coursesButton);
            this.Controls.Add(this.teachersButton);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.welcomeUserLabel);
            this.Controls.Add(this.logoutLinkLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorDashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Label welcomeUserLabel;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button teachersButton;
        private System.Windows.Forms.Button coursesButton;
    }
}