using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarasaraSystem.SubInterface.Finance
{
    public partial class PettyCashUC_Add : UserControl
    {
        private static PettyCashUC_Add _instance_pca;
        public static PettyCashUC_Add Instance_pca
        {
            get
            {
                if (_instance_pca == null)
                {
                    _instance_pca = new PettyCashUC_Add();
                }
                return _instance_pca;
            }
        }
        public PettyCashUC_Add()
        {
            InitializeComponent();
            EnterLabelValues();
            bunifuCustomTextbox1.Text = "0";
            bunifuCustomTextbox2.Text = "0";
            bunifuCustomTextbox3.Text = "0";
            bunifuCustomTextbox4.Text = "0";
            bunifuCustomTextbox5.Text = "0";
            bunifuCustomTextbox6.Text = "0";
            bunifuCustomTextbox7.Text = "0";
            bunifuCustomTextbox8.Text = "0";
        }
        public void EnterLabelValues()
        {
            //DateTime date = this.dateTimePicker1.Value;
            string query = "SELECT Balance FROM account WHERE accountnumber=123456789112456";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmnd = new MySqlCommand(query, con);
            MySqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmnd.ExecuteReader();
                while (myreader.Read())
                {
                    string bal = myreader.GetString("Balance");
                    label2.Text = bal;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateAccountTable(double income)
        {
            string query = "UPDATE account SET balance='" + income + "' WHERE accountnumber=123456789112456";
            MySqlConnection conc = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmmnd = new MySqlCommand(query, conc);
            MySqlDataReader myreader;
            try
            {
                conc.Open();
                myreader = cmmnd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateProfitLossTable(double income)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                MySqlDataReader myReader;
                if (income > 0)
                {
                    string query = "INSERT INTO profit_loss(date,profit,loss) VALUES('" + this.dateTimePicker1.Text + "','" + income + "',0)";
                    MySqlCommand cmnd = new MySqlCommand(query, con);
                    con.Open();
                    myReader = cmnd.ExecuteReader();
                }
                else
                {
                    string query = "INSERT INTO profit_loss(date,profit,loss) VALUES('" + this.dateTimePicker1.Text + "',0,'" + income + "')";
                    MySqlCommand cmnd = new MySqlCommand(query, con);
                    con.Open();
                    myReader = cmnd.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EnterTextBoxValues()
        {
            string query = "SELECT Sales FROM sales WHERE date='" + this.dateTimePicker1.Text + "'";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmnd = new MySqlCommand(query, con);
            MySqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmnd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString("Sales");
                    bunifuCustomTextbox7.Text = sname;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            EnterTextBoxValues();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuCustomTextbox1.Text))
            {
                MessageBox.Show("Enter Voucher Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox2.Text))
            {
                MessageBox.Show("Enter Voucher Salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox3.Text))
            {
                MessageBox.Show("Enter Utility.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox4.Text))
            {
                MessageBox.Show("Enter Rent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox5.Text))
            {
                MessageBox.Show("Enter Income.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox6.Text))
            {
                MessageBox.Show("Enter Other.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox7.Text))
            {
                MessageBox.Show("Enter Sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox8.Text))
            {
                MessageBox.Show("Enter Capital.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    double bal = Convert.ToDouble(label2.Text);
                    double nbal = (Convert.ToDouble(this.bunifuCustomTextbox5.Text) + Convert.ToDouble(this.bunifuCustomTextbox6.Text) + Convert.ToDouble(this.bunifuCustomTextbox7.Text) + Convert.ToDouble(this.bunifuCustomTextbox8.Text)) - (Convert.ToDouble(this.bunifuCustomTextbox2.Text) + Convert.ToDouble(this.bunifuCustomTextbox3.Text) + Convert.ToDouble(this.bunifuCustomTextbox4.Text));
                    double inc = bal + nbal;
                    string query = "INSERT INTO pettycash(Date,Voucher,Salary,Utility,Rent,Sales,Other,Income,Capital,Balance) Values('" + this.dateTimePicker1.Text + "','" + Convert.ToInt32(this.bunifuCustomTextbox1.Text) + "','" + Convert.ToDouble(this.bunifuCustomTextbox2.Text) + "','" + Convert.ToDouble(this.bunifuCustomTextbox3.Text) + "','" + Convert.ToDouble(this.bunifuCustomTextbox4.Text) + "','" + Convert.ToDouble(this.bunifuCustomTextbox7.Text) + "','" + Convert.ToDouble(this.bunifuCustomTextbox6.Text) + "','" + Convert.ToDouble(this.bunifuCustomTextbox5.Text) + "','" + Convert.ToDouble(this.bunifuCustomTextbox8.Text) + "','" + inc + "')";
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                    MySqlCommand cmnd = new MySqlCommand(query, con);
                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                    UpdateProfitLossTable(nbal);
                    UpdateAccountTable(inc);
                    MessageBox.Show("Saved");

                    label2.Text = inc.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            PettyCashUC_Add.Instance_pca.Visible = false;
            PettyCashUC.Instance_pc.BringToFront();
            PettyCashUC.Instance_pc.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(PettyCashUC_Add_Edit._Instance_pc_add))
            {
                panel1.Controls.Add(PettyCashUC_Add_Edit._Instance_pc_add);
                PettyCashUC_Add_Edit._Instance_pc_add.Dock = DockStyle.Fill;
                PettyCashUC_Add_Edit._Instance_pc_add.BringToFront();
            }
            else
            {
                PettyCashUC_Add_Edit._Instance_pc_add.BringToFront();
                PettyCashUC_Add_Edit._Instance_pc_add.Visible = true;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(PettyCashUC_Add_Summary.Instance_pc_as))
            {
                panel1.Controls.Add(PettyCashUC_Add_Summary.Instance_pc_as);
                PettyCashUC_Add_Summary.Instance_pc_as.Dock = DockStyle.Fill;
                PettyCashUC_Add_Summary.Instance_pc_as.BringToFront();
            }
            else
            {
                PettyCashUC_Add_Summary.Instance_pc_as.BringToFront();
                PettyCashUC_Add_Summary.Instance_pc_as.Visible = true;
            }
        }
    }
}
