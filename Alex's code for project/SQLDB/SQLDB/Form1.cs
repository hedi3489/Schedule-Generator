using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLDB
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP_ALEX;Initial Catalog=Test;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //disp_data();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO table_test VALUES('"+textBoxName.Text+"','"+textBoxCity.Text+"','"+textBoxCountry.Text+"')";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data();
            MessageBox.Show("Record Inserted Successfully");
        }

        public void disp_data()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM table_test ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewDB.DataSource = dt;
          
            con.Close();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM table_test WHERE name='" + textBoxName.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data();
            MessageBox.Show("Record Deleted Successfully");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE table_test SET name='" + textBoxCity.Text + "' WHERE name='" + textBoxName.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data();
            MessageBox.Show("Record Updated Successfully");
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM table_test WHERE name='" + textBoxName.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewDB.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
