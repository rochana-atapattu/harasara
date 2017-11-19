using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS_harasara;

namespace Transport
{
    public partial class report : Form
    {
        public void SalesSub(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }
        public report()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {
            HarasaraSystem.MainMenu mm = new HarasaraSystem.MainMenu();
            this.Hide();
            mm.Show();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            


        }

        private void report_Load(object sender, EventArgs e)
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
