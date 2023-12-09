namespace ReviewForFinal_Exam.GUI
{
    partial class FormCourseAssignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAssignedNum = new System.Windows.Forms.TextBox();
            this.textBoxAssignedDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAssignCourse = new System.Windows.Forms.Button();
            this.buttonListCoursesAssigned = new System.Windows.Forms.Button();
            this.listViewCoursesAssigned = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Teacher";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(37, 73);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(237, 21);
            this.comboBoxTeacher.TabIndex = 1;
            this.comboBoxTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(322, 73);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(237, 21);
            this.comboBoxCourse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assignment Number";
            // 
            // textBoxAssignedNum
            // 
            this.textBoxAssignedNum.Location = new System.Drawing.Point(34, 138);
            this.textBoxAssignedNum.Name = "textBoxAssignedNum";
            this.textBoxAssignedNum.Size = new System.Drawing.Size(129, 20);
            this.textBoxAssignedNum.TabIndex = 5;
            // 
            // textBoxAssignedDate
            // 
            this.textBoxAssignedDate.Location = new System.Drawing.Point(322, 137);
            this.textBoxAssignedDate.Name = "textBoxAssignedDate";
            this.textBoxAssignedDate.Size = new System.Drawing.Size(131, 20);
            this.textBoxAssignedDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assigned Date";
            // 
            // buttonAssignCourse
            // 
            this.buttonAssignCourse.Location = new System.Drawing.Point(209, 197);
            this.buttonAssignCourse.Name = "buttonAssignCourse";
            this.buttonAssignCourse.Size = new System.Drawing.Size(132, 31);
            this.buttonAssignCourse.TabIndex = 8;
            this.buttonAssignCourse.Text = "Assign Course";
            this.buttonAssignCourse.UseVisualStyleBackColor = true;
            this.buttonAssignCourse.Click += new System.EventHandler(this.buttonAssignCourse_Click);
            // 
            // buttonListCoursesAssigned
            // 
            this.buttonListCoursesAssigned.Location = new System.Drawing.Point(444, 197);
            this.buttonListCoursesAssigned.Name = "buttonListCoursesAssigned";
            this.buttonListCoursesAssigned.Size = new System.Drawing.Size(147, 31);
            this.buttonListCoursesAssigned.TabIndex = 9;
            this.buttonListCoursesAssigned.Text = "List Courses Assigned";
            this.buttonListCoursesAssigned.UseVisualStyleBackColor = true;
            this.buttonListCoursesAssigned.Click += new System.EventHandler(this.buttonListCoursesAssigned_Click);
            // 
            // listViewCoursesAssigned
            // 
            this.listViewCoursesAssigned.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCoursesAssigned.GridLines = true;
            this.listViewCoursesAssigned.HideSelection = false;
            this.listViewCoursesAssigned.Location = new System.Drawing.Point(73, 271);
            this.listViewCoursesAssigned.Name = "listViewCoursesAssigned";
            this.listViewCoursesAssigned.Size = new System.Drawing.Size(626, 146);
            this.listViewCoursesAssigned.TabIndex = 10;
            this.listViewCoursesAssigned.UseCompatibleStateImageBehavior = false;
            this.listViewCoursesAssigned.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course Code";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Title";
            this.columnHeader2.Width = 305;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Hours";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Assigned Date";
            this.columnHeader4.Width = 243;
            // 
            // FormCourseAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.listViewCoursesAssigned);
            this.Controls.Add(this.buttonListCoursesAssigned);
            this.Controls.Add(this.buttonAssignCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAssignedDate);
            this.Controls.Add(this.textBoxAssignedNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.label1);
            this.Name = "FormCourseAssignment";
            this.Text = "Course Assignment Form";
            this.Load += new System.EventHandler(this.FormCourseAssignment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAssignedNum;
        private System.Windows.Forms.TextBox textBoxAssignedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAssignCourse;
        private System.Windows.Forms.Button buttonListCoursesAssigned;
        private System.Windows.Forms.ListView listViewCoursesAssigned;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}