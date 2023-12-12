using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalprojectgui
{
    public partial class EditAddTeacher : Form
    {
        public EditAddTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EditAddTeacher_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            try
            {
                DashBoardPage form1 = new DashBoardPage();
                form1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TeacherViewSchedule form1 = new TeacherViewSchedule();

            // Show Form1
            form1.Show();

            // Optionally, close Form2
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogInPage form1 = new LogInPage();

            // Show Form1
            form1.Show();

            // Optionally, close Form2
            this.Hide();
        }
    }
}
