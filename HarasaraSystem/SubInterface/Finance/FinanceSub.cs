using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Finance
{
    public partial class FinanceSub : Form
    {
        public FinanceSub(string pt)
        {
            InitializeComponent();
            label3.Text = pt;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(ExpenditureManagerUC.Instance))
            {
                panel3.Controls.Add(ExpenditureManagerUC.Instance);
                ExpenditureManagerUC.Instance.Dock = DockStyle.Fill;
                ExpenditureManagerUC.Instance.BringToFront();
            }
            else
            {
                ExpenditureManagerUC.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(AccountsUC.Instance_auc))
            {
                panel3.Controls.Add(AccountsUC.Instance_auc);
                AccountsUC.Instance_auc.Dock = DockStyle.Fill;
                AccountsUC.Instance_auc.BringToFront();
            }
            else
            {
                AccountsUC.Instance_auc.BringToFront();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(EmailUC.eInstance))
            {
                panel3.Controls.Add(EmailUC.eInstance);
                EmailUC.eInstance.Dock = DockStyle.Fill;
                EmailUC.eInstance.BringToFront();
            }
            else
            {
                EmailUC.eInstance.BringToFront();
            }
        }
    }
}
