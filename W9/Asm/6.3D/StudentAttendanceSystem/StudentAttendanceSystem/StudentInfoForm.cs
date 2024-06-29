using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class StudentInfoForm : Form
    {
        private MySqlConnection con = new MySqlConnection();
        int count = 0;
        public StudentInfoForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=user_info;userid=root;password=;";
        }


        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand coman = new MySqlCommand();
                coman.Connection = con;
                string query = "select * from registration_tb ";
                coman.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(coman);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox9.Text = row.Cells["ID"].Value.ToString(); //ID
                textBox2.Text = row.Cells["Name"].Value.ToString(); //Name
                textBox4.Text = row.Cells["LastName"].Value.ToString(); //LastName
                textBox3.Text = row.Cells["Email"].Value.ToString(); //Email
                textBox8.Text = row.Cells["DateOfBirth"].Value.ToString(); //Date Of Birth
                textBox6.Text = row.Cells["Class"].Value.ToString(); //Class
                textBox5.Text = row.Cells["PhoneNumber"].Value.ToString(); //Phone Number
                textBox7.Text = row.Cells["Gender"].Value.ToString(); //Gender
                textBox1.Text = row.Cells["InTime"].Value.ToString(); //In Time


                //Image Display
                byte[] bytes = (byte[])dataGridView1.CurrentRow.Cells["Photo"].Value;
                MemoryStream ms = new MemoryStream(bytes);
                pictureBox2.Image = Image.FromStream(ms);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            MySqlCommand coman = new MySqlCommand();
            coman.Connection = con;
            string query = "select * from registration_tb where ID= '"+ textBox10.Text + "'";
            coman.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(coman);
            DataTable dt = new DataTable();
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            con.Close();

            if (count == 0)
            {
                MessageBox.Show("Record Not Found!!");
            }
        }
    }
}
