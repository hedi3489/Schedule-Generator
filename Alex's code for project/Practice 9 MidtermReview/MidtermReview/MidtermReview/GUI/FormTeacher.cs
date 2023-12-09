using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidtermReview.GUI;
using MidtermReview.BLL;

namespace MidtermReview.GUI
{
    public partial class FormTeacher : Form
    {
        //private Teacher aTeacher = new Teacher();
        private Teacher aTeacher;
        private List<Teacher> listTeacher = new List<Teacher>(); 
        public FormTeacher()
        {
            InitializeComponent();
            this.Text = "Teacher Information Form";
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            //Teacher aTeacher = new Teacher();
            //aTeacher.TeacherId = 1122;
            //aTeacher.FirstName = "lala";
            //aTeacher.LastName = "jojo";

            //MessageBox.Show("Teacher ID : " + aTeacher.TeacherId + "\nFirst Name : " + aTeacher.FirstName + "\nLast Name : " + aTeacher.LastName,"Message");
            //Course aCourse = new Course();
            //aCourse.CourseNumber = "420-P25-AS";
            //aCourse.CourseTitle = "Introduction to Object Programming";
            //aCourse.TotalHour = 75;
            //MessageBox.Show(aCourse.CourseNumber + "\t" + aCourse.CourseTitle
            //    + "\t" + aCourse.TotalHour,"Course Info");
            //Object anObject = new Teacher();
            //string message = "";

            //anObject = aTeacher.TeacherId;
            //message += anObject + "\t";
            ////MessageBox.Show(anObject.ToString());
            //anObject = aTeacher.FirstName;
            //message += anObject + "\t";
            ////MessageBox.Show(anObject.ToString());
            //anObject = aTeacher.LastName;
            //message += anObject;
            //MessageBox.Show(message);

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            //Teacher aTeacher = new Teacher();
            MessageBox.Show("Teacher ID : " + aTeacher.TeacherId + "\nFirst Name : " + aTeacher.FirstName + "\nLast Name : " + aTeacher.LastName, "Message");

        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            aTeacher = new Teacher(2222, "Thomas", "Moore");
            //Teacher aTeacher = new Teacher();
            //aTeacher.TeacherId = 2222;
            //aTeacher.FirstName = "Thomas";
            //aTeacher.LastName = "Moore";

  

        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            aTeacher = new Teacher(2222, "Thomas", "Moore");
            listTeacher.Add(aTeacher);
            aTeacher = new Teacher(3333, "Thomas", "Green");
            listTeacher.Add(aTeacher);
            aTeacher = new Teacher(4444, "Thomas", "Brown");
            listTeacher.Add(aTeacher);
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listViewTeacher.Items.Clear();
            foreach (Teacher aTeacher in listTeacher)
            {
                ListViewItem item = new ListViewItem(aTeacher.TeacherId.ToString());
                item.SubItems.Add(aTeacher.FirstName);
                item.SubItems.Add(aTeacher.LastName);
                listViewTeacher.Items.Add(item);
            }
            

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Teacher aTeacher = new Teacher();
            int searchId = Convert.ToInt32(textBoxTeacherId.Text);
           aTeacher =  aTeacher.SearchByTeacherId(listTeacher,searchId );
           if (aTeacher != null)
           {
               MessageBox.Show("Teacher ID : " + aTeacher.TeacherId + "\nFirst Name : " + aTeacher.FirstName + "\nLast Name : " + aTeacher.LastName, "Message");


           }
           else
           {
               MessageBox.Show("Not found");
           }

        }

        private void listViewTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTeacherId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
