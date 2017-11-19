using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    public partial class ProductionSub : Form
    {
        public ProductionSub(string pt)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(HarasaraSystem.SubInterface.Production.OrdersUC.Instance))
            {
                panel3.Controls.Add(HarasaraSystem.SubInterface.Production.OrdersUC.Instance);
                HarasaraSystem.SubInterface.Production.OrdersUC.Instance.Dock = DockStyle.Fill;
                HarasaraSystem.SubInterface.Production.OrdersUC.Instance.BringToFront();
            }
            else
            {
                HarasaraSystem.SubInterface.Production.OrdersUC.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(HarasaraSystem.SubInterface.Production.OrderProcessingUC.Instance))
            {
                panel3.Controls.Add(HarasaraSystem.SubInterface.Production.OrderProcessingUC.Instance);
                HarasaraSystem.SubInterface.Production.OrderProcessingUC.Instance.Dock = DockStyle.Fill;
                HarasaraSystem.SubInterface.Production.OrderProcessingUC.Instance.BringToFront();
            }
            else
            {
                HarasaraSystem.SubInterface.Production.OrderProcessingUC.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
        }
    }
}
