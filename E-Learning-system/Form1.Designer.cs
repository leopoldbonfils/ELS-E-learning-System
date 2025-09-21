namespace E_Learning_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCourseID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCourseCode = new TextBox();
            txtCourseName = new TextBox();
            txtSemester = new ComboBox();
            txtCredits = new TextBox();
            txtInstructor = new TextBox();
            txtDescription = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            dataGridViewCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 46);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Course ID:";
            label1.Click += label1_Click;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(30, 87);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(227, 31);
            txtCourseID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 46);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 2;
            label2.Text = "Course Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(688, 46);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 3;
            label3.Text = "Course Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 153);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 4;
            label4.Text = "Semester:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 153);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 5;
            label5.Text = "Credits:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(719, 164);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 6;
            label6.Text = "Instructor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 267);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 7;
            label7.Text = "Description:";
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(321, 87);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(227, 31);
            txtCourseCode.TabIndex = 8;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(646, 87);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(227, 31);
            txtCourseName.TabIndex = 9;
            // 
            // txtSemester
            // 
            txtSemester.FormattingEnabled = true;
            txtSemester.Items.AddRange(new object[] { "Semester one", "Semester two", "Summer Semester" });
            txtSemester.Location = new Point(30, 204);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(227, 33);
            txtSemester.TabIndex = 10;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(331, 206);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(227, 31);
            txtCredits.TabIndex = 11;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(646, 206);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(227, 31);
            txtInstructor.TabIndex = 12;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(30, 318);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(227, 31);
            txtDescription.TabIndex = 13;
            txtDescription.TextChanged += textBox6_TextChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(75, 598);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 598);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(399, 598);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(742, 291);
            btnView.Name = "btnView";
            btnView.Size = new Size(112, 34);
            btnView.TabIndex = 18;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += button4_Click;
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(12, 371);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 62;
            dataGridViewCourses.Size = new Size(891, 209);
            dataGridViewCourses.TabIndex = 19;
            dataGridViewCourses.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(915, 648);
            Controls.Add(dataGridViewCourses);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtDescription);
            Controls.Add(txtInstructor);
            Controls.Add(txtCredits);
            Controls.Add(txtSemester);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseCode);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCourseID);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ELS - E-Learning System - Course Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCourseID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCourseCode;
        private TextBox txtCourseName;
        private ComboBox txtSemester;
        private TextBox txtCredits;
        private TextBox txtInstructor;
        private TextBox txtDescription;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private DataGridView dataGridViewCourses;
    }
}
