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
using HarasaraSystem.SubInterface.Sales;

namespace HarasaraSystem
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara2");
        MySqlCommand cmd;
        public Login(string ptn)
        {
            InitializeComponent();

            position.Text = ptn;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select count(*) from admins where Username='" + textBox1.Text + "'  and  Password='" + textBox2.Text + "' and Position='" + position.Text + "'";
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                int x = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                if (x==1)
                {
                    if (position.Text == "Sales Manager")
                    {
                        SalesSub s1 = new SalesSub(textBox1.Text);
                        s1.Show();
                        this.Hide();
                    }
                    else if (position.Text == "HR Manager")
                    {
                        HarasaraSystem.SubInterface.Employee.EmployeeSub e1 = new HarasaraSystem.SubInterface.Employee.EmployeeSub(textBox1.Text);
                        e1.Show();
                        this.Hide();
                    }
                    else if (position.Text == "Adminstration")
                    {
                        HarasaraSystem.SubInterface.Administration.AdministrationSub a1 = new SubInterface.Administration.AdministrationSub(textBox1.Text);
                        a1.Show();
                        this.Hide();
                    }
                    else if (position.Text == "Finance")
                    {
                        HarasaraSystem.SubInterface.Finance.FinanceSub f1 = new SubInterface.Finance.FinanceSub(textBox1.Text);
                        f1.Show();
                        this.Hide();

                    }
                    else if (position.Text == "Products")
                    {

                        HarasaraSystem.SubInterface.Production.ProductionSub p1 = new SubInterface.Production.ProductionSub(textBox1.Text);
                        p1.Show();
                        this.Hide();

                    }
                    else if (position.Text == "Inventory")
                    {
                        HarasaraSystem.SubInterface.Inventory.InventorySub i1 = new SubInterface.Inventory.InventorySub(textBox1.Text);
                        i1.Show();
                        this.Hide();
                    }

                    else
                    {
                        Transport.Main t1 = new Transport.Main();
                        t1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    label4.Text = "Username or Password is incorrect";
                    label4.ForeColor = Color.Red;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               

            /*HarasaraSystem.SubInterface.Finance.FinanceSub f1 = new SubInterface.Finance.FinanceSub(textBox1.Text);
            f1.Show();
            this.Hide();*/

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MainMenu m1 = new MainMenu();
            m1.Show();
            this.Hide();
        }
    }
}
