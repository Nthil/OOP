using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Lf = new LoginForm();
            Lf.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Lf = new LoginForm();
            Lf.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistrationForm Rf = new StudentRegistrationForm();
            Rf.ShowDialog();
            Rf = null;
            this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentInfoForm sif = new StudentInfoForm();
            sif.ShowDialog();
            sif = null;
            this.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendanceRecordForm atf = new AttendanceRecordForm();
            atf.ShowDialog();
            atf = null;
            this.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            ModifyInfor mif = new ModifyInfor();
            mif.ShowDialog();
            mif = null;
            this.Show();
        }
    }
}
