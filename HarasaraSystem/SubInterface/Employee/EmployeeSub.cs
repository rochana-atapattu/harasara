using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Employee

{
    public partial class EmployeeSub : Form
    {
        public EmployeeSub( string pt)
        {
            InitializeComponent();
            label4.Text = pt;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void SalesSub_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(details.Instance))
            {
                panel3.Controls.Add(details.Instance);
                details.Instance.Dock = DockStyle.Fill;
                details.Instance.BringToFront();
            }

            else
                details.Instance.BringToFront(); 
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(attendance.Instance))
            {
                panel3.Controls.Add(attendance.Instance);
                attendance.Instance.Dock = DockStyle.Fill;
                attendance.Instance.BringToFront();
            }

            else
                attendance.Instance.BringToFront(); 
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(leave.Instance))
            {
                panel3.Controls.Add(leave.Instance);
                leave.Instance.Dock = DockStyle.Fill;
                leave.Instance.BringToFront();
            }

            else
                leave.Instance.BringToFront(); 

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(payrolls.Instance))
            {
                panel3.Controls.Add(payrolls.Instance);
                payrolls.Instance.Dock = DockStyle.Fill;
                payrolls.Instance.BringToFront();
            }

            else
                payrolls.Instance.BringToFront(); 

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(notifications.Instance))
            {
                panel3.Controls.Add(notifications.Instance);
                notifications.Instance.Dock = DockStyle.Fill;
                notifications.Instance.BringToFront();
            }

            else
                notifications.Instance.BringToFront(); 


        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(search.Instance))
            {
                panel3.Controls.Add(search.Instance);
                search.Instance.Dock = DockStyle.Fill;
                search.Instance.BringToFront();
            }

            else
                search.Instance.BringToFront(); 

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
