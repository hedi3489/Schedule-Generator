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
    public partial class TeacherViewSchedule : Form
    {
        public TeacherViewSchedule()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            DashBoardPage form1 = new DashBoardPage();

            // Show Form1
            form1.Show();

            // Optionally, close Form2
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAddTeacher form1 = new EditAddTeacher();

            // Show Form1
            form1.Show();

            // Optionally, close Form2
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogInPage form1 = new LogInPage();

            // Show Form1
            form1.Show();

            // Optionally, close Form2
            this.Hide();
        }
    }
}
