using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Transport
{
    public partial class SMS : Form
    {
        public void SalesSub(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }
        public SMS()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                
                dt = db.ReadValue("Select employee_id,fname,mobile_no From employee");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message, "Error");




            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();


                dt = db.ReadValue("Select DriverID,DriverName,ContactNo From driverdetails");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message, "Error");




            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > -1)
            {
                
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //Set parameters
           string username = "asviganegoda@gmail.com";
            string password = "qda5";
            string msgsender = textBox1.Text.ToString();
            string destinationaddr = textBox1.Text.ToString();
            
           string message = bunifuCustomTextbox2.Text.ToString();

            // Create ViaNettSMS object with username and password
            ViaNettSMS s = new ViaNettSMS(username, password);
           //  Declare Result object returned by the SendSMS function
            ViaNettSMS.Result result;
            /*try
            {
                //Send SMS through HTTP API
                result = s.sendSMS(msgsender, destinationaddr, message);
                 //Show Send SMS response
                if (result.Success)
                {
                    Debug.WriteLine("Message successfully sent");
                }
                else
                {
                    Debug.WriteLine("Received error: " + result.ErrorCode + " " + result.ErrorMessage);
                }
            }
            catch (System.Net.WebException ex)
            {
                //Catch error occurred while connecting to server.
                Debug.WriteLine(ex.Message);
            }
             */
        }
            
        private void bunifuThinButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();

        }

        private void SMS_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton6_Click(object sender, EventArgs e)
        {
            HarasaraSystem.MainMenu mm = new HarasaraSystem.MainMenu();
            this.Hide();
            mm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        
    }
}
