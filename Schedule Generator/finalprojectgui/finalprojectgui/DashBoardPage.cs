using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalprojectgui
{
    public partial class DashBoardPage : Form
    {
        public DashBoardPage()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TeacherViewSchedule form1 = new TeacherViewSchedule();
                form1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAddTeacher form123 = new EditAddTeacher();

            // Show Form1
            form123.Show();

            // Optionally, close Form2
            this.Hide();
        }
    }
}
