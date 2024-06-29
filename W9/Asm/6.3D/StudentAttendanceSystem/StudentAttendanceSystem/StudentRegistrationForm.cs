using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class StudentRegistrationForm : Form
    {
        private MySqlConnection con = new MySqlConnection();
        public StudentRegistrationForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=user_info;userid=root;password=;";
        }
        string Gender;
        
        private void button2_Click(object sender, EventArgs e)
        {
            //For QRCode generator
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(label2.Text, QRCoder.QRCodeGenerator.ECCLevel.H); //ID
            var code = new QRCoder.QRCode(MyData);
            pictureBox3.Image = code.GetGraphic(100);
            try
            {

                //For Image
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);

                //Connect Database
                con.Open();
                MySqlCommand coman = new MySqlCommand();
                coman.Connection = con;
                coman.CommandText = "INSERT INTO registration_tb (ID,Name,LastName,Email,DateOfBirth,Class,PhoneNumber,Gender,Photo,InTime) values('" + textBox1.Text + " ', ' " + textBox2.Text + " ',' " + textBox4.Text + " ',' " + textBox3.Text + " ','" + dateTimePicker1.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + Gender + "',@photo, '" + textBox7.Text+ "')";
                coman.Parameters.AddWithValue("@photo", Photo);
                coman.ExecuteNonQuery();
                con.Close();


                //Clear input 
                MessageBox.Show("Data Save Successfull !");
                textBox1.Clear(); //ID
                textBox2.Clear(); //Name
                textBox4.Clear(); //Last Name
                textBox3.Clear(); //Email
                textBox6.Clear(); //Class
                textBox5.Clear(); //Phone Number
                textBox7.Clear(); //Time Attend
                pictureBox2.Image = null; //PictureBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            //For Save folder generate QRCode image
            string initialDIR = @"C:\Users\DELL\Desktop\QRfiles";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image.Save(dialog.FileName);
            }
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // For upload image
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(fd.FileName);
            }
        }

        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToShortDateString();
            label13.Text = DateTime.Now.ToLongTimeString();
        }
        
    }
}
