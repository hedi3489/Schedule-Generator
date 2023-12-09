using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReviewForFinal_Exam.Business;

namespace ReviewForFinal_Exam.GUI
{
    public partial class FormCourseAssignment : Form
    {
        public FormCourseAssignment()
        {
            InitializeComponent();
        }

        private void FormCourseAssignment_Load(object sender, EventArgs e)
        {
            Teacher aTeacher = new Teacher();
            List<Teacher> listT = aTeacher.GetTeacherList();
            comboBoxTeacher.Items.Clear();
            foreach (Teacher t in listT)
            {
                //MessageBox.Show(t.TeacherID.ToString());
                comboBoxTeacher.Items.Add(t.TeacherID.ToString() + ',' + t.FirstName + ','
                                          + t.LastName + ',' + t.Email);
            }

            Course aCourse = new Course();
            List<Course> listC = aCourse.GetCourseList();
            foreach (Course c in listC)
            {
                comboBoxCourse.Items.Add(c.CourseCode + ',' + c.CourseTitle + ',' + c.TotalHour);
            }

            buttonAssignCourse.Enabled = false;
            buttonListCoursesAssigned.Enabled = false;

        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            string teacher = comboBoxTeacher.Text.Trim();
            string num = teacher.Substring(0, 5);
            textBoxAssignedNum.Text = num;
            textBoxAssignedNum.ReadOnly = true;

            textBoxAssignedDate.Text = DateTime.Today.ToShortDateString();
            textBoxAssignedDate.ReadOnly = true;
            buttonAssignCourse.Enabled = true;
            buttonListCoursesAssigned.Enabled = true;
        }

        private void buttonAssignCourse_Click(object sender, EventArgs e)
        {
            //Check duplicate here

            //Check the number of courses assigned

            CourseAssignment ca = new CourseAssignment();
            ca.AssignmentNumber = Convert.ToInt32(textBoxAssignedNum.Text);
            ca.AssignedDate = Convert.ToDateTime(textBoxAssignedDate.Text);
            string teacher = comboBoxTeacher.Text.Trim();
            string[] fields = teacher.Split(',');
            ca.Teacher.TeacherID = Convert.ToInt32(fields[0]);
            ca.Teacher.FirstName = fields[1];
            ca.Teacher.LastName = fields[2];
            ca.Teacher.Email = fields[3];

            string course = comboBoxCourse.Text;
            string[] inputs = course.Split(',');
            ca.Course.CourseCode = inputs[0];
            ca.Course.CourseTitle = inputs[1];
            ca.Course.TotalHour = Convert.ToInt32(inputs[2]);
            ca.AssignCourse(ca);
            MessageBox.Show("Course assignment has been saved successfully.","Confirmation");


        }

        private void buttonListCoursesAssigned_Click(object sender, EventArgs e)
        {
            //get TeacherID
            string teacher = comboBoxTeacher.Text.Trim();
            string num = teacher.Substring(0, 5);
            Teacher aTeacher = new Teacher();
            CourseAssignment ca = new CourseAssignment();
            aTeacher.ListCoursesAssigned = ca.GetListCoursesAssigned(Convert.ToInt32(num));
            listViewCoursesAssigned.Items.Clear();

            foreach (CourseAssignment aCA in aTeacher.ListCoursesAssigned)
            {
                ListViewItem item = new ListViewItem(aCA.Course.CourseCode);
                item.SubItems.Add(aCA.Course.CourseTitle);
                item.SubItems.Add(aCA.Course.TotalHour.ToString());
                item.SubItems.Add(aCA.AssignedDate.ToShortDateString());
                listViewCoursesAssigned.Items.Add(item);

            }


        }
    }
}
