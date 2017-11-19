using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Transport
{
    public partial class Main : Form
    {
        public void SalesSub(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }
        public Main()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            vehicle v1 = new vehicle();
            v1.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            report r1 = new report();
            r1.ShowDialog();
            this.Close();
            

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            driver d1 = new driver();
            d1.ShowDialog();
            this.Close();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            route ro1 = new route();
            ro1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            HarasaraSystem.MainMenu mm = new HarasaraSystem.MainMenu();
            this.Hide();
            mm.Show(); 

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            vehicle ve1 = new vehicle();
            ve1.ShowDialog();
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            driver d2 = new driver();
            d2.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            vehicle v1 = new vehicle();
            v1.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SMS v1 = new SMS();
            v1.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {
            HarasaraSystem.MainMenu mm = new HarasaraSystem.MainMenu();
            this.Hide();
            mm.Show();

        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }
    }
}
