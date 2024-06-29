using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentAttendanceSystem
{
    public partial class LoginForm : Form
    {
        private MySqlConnection con = new MySqlConnection();
        public LoginForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=user_info;userid=root;password=;";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }


        private void LOGIN_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            try
            {

                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM login_tb WHERE UserName='" + user_text.Text + "' AND Password='" + password_text.Text + "' ";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Success");
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("If You are Admin,Please Enter the correct username and password");
                }


            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
