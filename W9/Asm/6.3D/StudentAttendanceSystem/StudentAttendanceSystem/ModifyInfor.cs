using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class ModifyInfor : Form
    {
        private MySqlConnection con = new MySqlConnection();
        public ModifyInfor()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=user_info;userid=root;password=;";
        }
        
        private void ModifyInfor_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand coman = new MySqlCommand();
                coman.Connection = con;
                string query = "SELECT * FROM registration_tb";
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
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                

                //For database
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ID"].Value.ToString(); //ID
                textBox2.Text = row.Cells["Name"].Value.ToString(); //Name
                textBox4.Text = row.Cells["LastName"].Value.ToString(); //LastName
                textBox3.Text = row.Cells["Email"].Value.ToString(); //Email
                textBox8.Text = row.Cells["DateOfBirth"].Value.ToString(); //Date Of Birth
                textBox6.Text = row.Cells["Class"].Value.ToString(); //Class
                textBox5.Text = row.Cells["PhoneNumber"].Value.ToString(); //Phone Number
                textBox7.Text = row.Cells["Gender"].Value.ToString(); //Gender

                //Image Display
                byte[] bytes = (byte[])dataGridView1.CurrentRow.Cells["Photo"].Value;
                MemoryStream ms = new MemoryStream(bytes);
                pictureBox2.Image = Image.FromStream(ms);
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //Update button
        {
            try
            {
                //Connect Database
                MySqlCommand coman = new MySqlCommand();
                coman.Connection = con;
                coman.CommandText = "UPDATE registration_tb SET Name = '" + textBox2.Text + "', LastName = '" + textBox4.Text + "', Email = '" + textBox3.Text + "', DateOfBirth = '" + textBox8.Text + "', Class = '" + textBox6.Text + "', PhoneNumber = '" + textBox1.Text + "', Gender = '" + textBox5.Text + "', InTime = '" + textBox7.Text + "' WHERE ID=" + textBox1.Text;
                
                con.Open();
                coman.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Save Successfull !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Delete button
        {
            try
            {
                //Connect Database
                MySqlCommand coman = new MySqlCommand();
                coman.Connection = con;
                coman.CommandText = "DELETE FROM registration_tb WHERE ID=" + textBox1.Text;

                con.Open();
                coman.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Delete Successfull !");
                textBox1.Clear(); //ID
                textBox2.Clear(); //Name
                textBox4.Clear(); //Last Name
                textBox3.Clear(); //Email
                textBox8.Clear(); //Date of Birth
                textBox6.Clear(); //Class
                textBox5.Clear(); //Phone Number
                textBox7.Clear(); //Gender
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand coman = new MySqlCommand();
            coman.Connection = con;
            string query = "SELECT * FROM registration_tb";
            coman.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(coman);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            pictureBox2.Image = null; //PictureBox

            con.Close();
        }
    }
}
