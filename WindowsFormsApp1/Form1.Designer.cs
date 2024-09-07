namespace WindowsFormsApp1
{
    partial class Form1
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
            this.addStudent = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.editStudent = new System.Windows.Forms.Button();
            this.showStudent = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(12, 12);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(181, 42);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 60);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(181, 41);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // editStudent
            // 
            this.editStudent.Location = new System.Drawing.Point(12, 107);
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(181, 41);
            this.editStudent.TabIndex = 2;
            this.editStudent.Text = "Edit Student";
            this.editStudent.UseVisualStyleBackColor = true;
            this.editStudent.Click += new System.EventHandler(this.editStudent_Click);
            // 
            // showStudent
            // 
            this.showStudent.Location = new System.Drawing.Point(12, 154);
            this.showStudent.Name = "showStudent";
            this.showStudent.Size = new System.Drawing.Size(180, 42);
            this.showStudent.TabIndex = 3;
            this.showStudent.Text = "Show Student";
            this.showStudent.UseVisualStyleBackColor = true;
            this.showStudent.Click += new System.EventHandler(this.showStudent_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(12, 202);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(180, 41);
            this.deleteStudent.TabIndex = 4;
            this.deleteStudent.Text = "Delete Student";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(207, 260);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.showStudent);
            this.Controls.Add(this.editStudent);
            this.Controls.Add(this.search);
            this.Controls.Add(this.addStudent);
            this.Name = "Form1";
            this.Text = "School";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button editStudent;
        private System.Windows.Forms.Button showStudent;
        private System.Windows.Forms.Button deleteStudent;
    }
}

