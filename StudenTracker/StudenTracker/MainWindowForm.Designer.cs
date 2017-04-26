namespace StudentTracker
{
    partial class StudentTracker
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
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.btn_Tracker = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Location = new System.Drawing.Point(199, 202);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(174, 66);
            this.btn_AddStudent.TabIndex = 0;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // btn_Tracker
            // 
            this.btn_Tracker.Location = new System.Drawing.Point(199, 274);
            this.btn_Tracker.Name = "btn_Tracker";
            this.btn_Tracker.Size = new System.Drawing.Size(174, 62);
            this.btn_Tracker.TabIndex = 1;
            this.btn_Tracker.Text = "Tracker";
            this.btn_Tracker.UseVisualStyleBackColor = true;
            this.btn_Tracker.Click += new System.EventHandler(this.btn_Tracker_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "WELCOME TO MSSA";
            // 
            // StudentTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Tracker);
            this.Controls.Add(this.btn_AddStudent);
            this.Name = "StudentTracker";
            this.Text = "MSSA Student Tracker";
            this.Load += new System.EventHandler(this.StudentTracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Button btn_Tracker;
        private System.Windows.Forms.Label label2;
    }
}

