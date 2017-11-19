using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Sales

{
    public partial class SalesSub : Form
    {
        public SalesSub(string user)
        {
            InitializeComponent();
            label4.Text = user;
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

        private void SalesOrders_Click(object sender, EventArgs e)
        {
            if(!panel3.Controls.Contains(HarasaraSystem.SubInterface.Sales.SalesOrders.Instance))
            {
                panel3.Controls.Add(HarasaraSystem.SubInterface.Sales.SalesOrders.Instance);
                HarasaraSystem.SubInterface.Sales.SalesOrders.Instance.Dock = DockStyle.Fill;
                HarasaraSystem.SubInterface.Sales.SalesOrders.Instance.BringToFront();
            }
            else
            {
                HarasaraSystem.SubInterface.Sales.SalesOrders.Instance.BringToFront();
            }
        }

        private void Purchasings_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(HarasaraSystem.SubInterface.Sales.PurchasingOrders.Instance))
            {
                panel3.Controls.Add(HarasaraSystem.SubInterface.Sales.PurchasingOrders.Instance);
                HarasaraSystem.SubInterface.Sales.PurchasingOrders.Instance.Dock = DockStyle.Fill;
                HarasaraSystem.SubInterface.Sales.PurchasingOrders.Instance.BringToFront();
            }
            else
            {
                HarasaraSystem.SubInterface.Sales.PurchasingOrders.Instance.BringToFront();
            }
        }

        private void Payments_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(HarasaraSystem.SubInterface.Sales.payments.Instance))
            {
                panel3.Controls.Add(HarasaraSystem.SubInterface.Sales.payments.Instance);
                HarasaraSystem.SubInterface.Sales.payments.Instance.Dock = DockStyle.Fill;
                HarasaraSystem.SubInterface.Sales.payments.Instance.BringToFront();
            }
            else
            {
                HarasaraSystem.SubInterface.Sales.payments.Instance.BringToFront();
            }

        }

        

        private void People_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(HarasaraSystem.SubInterface.Sales.setting.Instance))
            {
                panel3.Controls.Add(HarasaraSystem.SubInterface.Sales.setting.Instance);
                HarasaraSystem.SubInterface.Sales.setting.Instance.Dock = DockStyle.Fill;
                HarasaraSystem.SubInterface.Sales.setting.Instance.BringToFront();
            }
            else
            {
                HarasaraSystem.SubInterface.Sales.setting.Instance.BringToFront();
            }

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
