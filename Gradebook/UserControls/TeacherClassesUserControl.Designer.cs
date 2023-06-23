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
            this.currentClassesLabel = new System.Windows.Forms.Label();
            this.pastClassesLabel = new System.Windows.Forms.Label();
            this.currentClassesListView = new System.Windows.Forms.ListView();
            this.pastClassesListView = new System.Windows.Forms.ListView();
            this.futureClassesListview = new System.Windows.Forms.ListView();
            this.futureClassesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentClassesLabel
            // 
            this.currentClassesLabel.AutoSize = true;
            this.currentClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentClassesLabel.Location = new System.Drawing.Point(85, 25);
            this.currentClassesLabel.Name = "currentClassesLabel";
            this.currentClassesLabel.Size = new System.Drawing.Size(137, 20);
            this.currentClassesLabel.TabIndex = 0;
            this.currentClassesLabel.Text = "Current Classes";
            // 
            // pastClassesLabel
            // 
            this.pastClassesLabel.AutoSize = true;
            this.pastClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastClassesLabel.Location = new System.Drawing.Point(88, 203);
            this.pastClassesLabel.Name = "pastClassesLabel";
            this.pastClassesLabel.Size = new System.Drawing.Size(113, 20);
            this.pastClassesLabel.TabIndex = 1;
            this.pastClassesLabel.Text = "Past Classes";
            // 
            // currentClassesListView
            // 
            this.currentClassesListView.HideSelection = false;
            this.currentClassesListView.Location = new System.Drawing.Point(91, 62);
            this.currentClassesListView.Name = "currentClassesListView";
            this.currentClassesListView.Size = new System.Drawing.Size(775, 125);
            this.currentClassesListView.TabIndex = 2;
            this.currentClassesListView.UseCompatibleStateImageBehavior = false;
            // 
            // pastClassesListView
            // 
            this.pastClassesListView.HideSelection = false;
            this.pastClassesListView.Location = new System.Drawing.Point(92, 236);
            this.pastClassesListView.Name = "pastClassesListView";
            this.pastClassesListView.Size = new System.Drawing.Size(774, 137);
            this.pastClassesListView.TabIndex = 3;
            this.pastClassesListView.UseCompatibleStateImageBehavior = false;
            // 
            // futureClassesListview
            // 
            this.futureClassesListview.HideSelection = false;
            this.futureClassesListview.Location = new System.Drawing.Point(91, 428);
            this.futureClassesListview.Name = "futureClassesListview";
            this.futureClassesListview.Size = new System.Drawing.Size(774, 137);
            this.futureClassesListview.TabIndex = 5;
            this.futureClassesListview.UseCompatibleStateImageBehavior = false;
            // 
            // futureClassesLabel
            // 
            this.futureClassesLabel.AutoSize = true;
            this.futureClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureClassesLabel.Location = new System.Drawing.Point(87, 395);
            this.futureClassesLabel.Name = "futureClassesLabel";
            this.futureClassesLabel.Size = new System.Drawing.Size(130, 20);
            this.futureClassesLabel.TabIndex = 4;
            this.futureClassesLabel.Text = "Future Classes";
            // 
            // TeacherClassesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.futureClassesListview);
            this.Controls.Add(this.futureClassesLabel);
            this.Controls.Add(this.pastClassesListView);
            this.Controls.Add(this.currentClassesListView);
            this.Controls.Add(this.pastClassesLabel);
            this.Controls.Add(this.currentClassesLabel);
            this.Name = "TeacherClassesUserControl";
            this.Size = new System.Drawing.Size(945, 589);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentClassesLabel;
        private System.Windows.Forms.Label pastClassesLabel;
        private System.Windows.Forms.ListView currentClassesListView;
        private System.Windows.Forms.ListView pastClassesListView;
        private System.Windows.Forms.ListView futureClassesListview;
        private System.Windows.Forms.Label futureClassesLabel;
    }
}
