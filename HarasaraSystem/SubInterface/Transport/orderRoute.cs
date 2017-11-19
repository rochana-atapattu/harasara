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
    public partial class orderRoute : Form
    {
        public void SalesSub(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }
        public orderRoute()
        {
            InitializeComponent();
            timer1.Start();
        }

        MySqlConnection connnection = new MySqlConnection("server=localhost;user id=root;database=harasara");

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            route r1 = new route();
            r1.ShowDialog();
            this.Close();
          
        }

        private void orderRoute_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

           /* try
            {

                connnection.Open();
                String query = "SELECT DriverID FROM driverdetails";
                MySqlCommand command = new MySqlCommand(query, connnection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    bunifuDropdown1.AddItem(reader.GetString("DriverID"));


                }

            }

            catch(Exception ex) 
            
            {

                MessageBox.Show(ex.Message);
            
            
            
            
            }

            */

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
             
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {

            

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            String town1 = bunifuCustomTextbox1.Text;
            String town2 = bunifuCustomTextbox6.Text;
            String town3 = bunifuCustomTextbox3.Text;
            String town4 = bunifuCustomTextbox2.Text;
            //String town5 = bunifuCustomTextbox5.Text;
            //String town6 = bunifuCustomTextbox4.Text;

            StringBuilder add = new StringBuilder("https://www.google.com/maps?q=");

            if (town1 != String.Empty)
            { 
            add.Append(town1 + ",");
            }
            if (town2 != String.Empty)
            {
                add.Append(town2 + ",");

            }
            if (town3 != String.Empty)
            {
                add.Append(town3 + ",");
            }
            if (town4 != String.Empty)
            {
                add.Append(town4 + ",");
            }
            /*if (town5 != String.Empty)
            {
                add.Append(town5 + ",");
            }
            if (town6 != String.Empty)
            {
                add.Append(town6);
            }
            */
            webBrowser1.Navigate(add.ToString());


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

    
    
    }
 }
