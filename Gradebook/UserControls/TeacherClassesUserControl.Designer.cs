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
            this.futureClassesLabel = new System.Windows.Forms.Label();
            this.currentClassDataGridView = new System.Windows.Forms.DataGridView();
            this.pastClasseseDataGridView = new System.Windows.Forms.DataGridView();
            this.futureClassesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.currentClassDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastClasseseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futureClassesDataGridView)).BeginInit();
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
            this.pastClassesLabel.Location = new System.Drawing.Point(88, 218);
            this.pastClassesLabel.Name = "pastClassesLabel";
            this.pastClassesLabel.Size = new System.Drawing.Size(113, 20);
            this.pastClassesLabel.TabIndex = 1;
            this.pastClassesLabel.Text = "Past Classes";
            // 
            // futureClassesLabel
            // 
            this.futureClassesLabel.AutoSize = true;
            this.futureClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureClassesLabel.Location = new System.Drawing.Point(88, 412);
            this.futureClassesLabel.Name = "futureClassesLabel";
            this.futureClassesLabel.Size = new System.Drawing.Size(130, 20);
            this.futureClassesLabel.TabIndex = 4;
            this.futureClassesLabel.Text = "Future Classes";
            // 
            // currentClassDataGridView
            // 
            this.currentClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentClassDataGridView.Location = new System.Drawing.Point(92, 49);
            this.currentClassDataGridView.Name = "currentClassDataGridView";
            this.currentClassDataGridView.Size = new System.Drawing.Size(773, 151);
            this.currentClassDataGridView.TabIndex = 5;
            // 
            // pastClasseseDataGridView
            // 
            this.pastClasseseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastClasseseDataGridView.Location = new System.Drawing.Point(91, 241);
            this.pastClasseseDataGridView.Name = "pastClasseseDataGridView";
            this.pastClasseseDataGridView.Size = new System.Drawing.Size(773, 151);
            this.pastClasseseDataGridView.TabIndex = 6;
            // 
            // futureClassesDataGridView
            // 
            this.futureClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.futureClassesDataGridView.Location = new System.Drawing.Point(92, 435);
            this.futureClassesDataGridView.Name = "futureClassesDataGridView";
            this.futureClassesDataGridView.Size = new System.Drawing.Size(773, 151);
            this.futureClassesDataGridView.TabIndex = 7;
            // 
            // TeacherClassesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.futureClassesDataGridView);
            this.Controls.Add(this.pastClasseseDataGridView);
            this.Controls.Add(this.currentClassDataGridView);
            this.Controls.Add(this.futureClassesLabel);
            this.Controls.Add(this.pastClassesLabel);
            this.Controls.Add(this.currentClassesLabel);
            this.Name = "TeacherClassesUserControl";
            this.Size = new System.Drawing.Size(945, 589);
            ((System.ComponentModel.ISupportInitialize)(this.currentClassDataGridView)).EndInit();
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
    }
}
