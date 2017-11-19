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
using System.IO;

namespace Transport
{

    public partial class driver : Form
    {
        public void SalesSub(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }
           
        public driver()
        {
            InitializeComponent();
            timer1.Start();
        }

        MySqlConnection connnection = new MySqlConnection("server=localhost;user id=root;database=harasara");
        
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox5_TextChanged(object sender, EventArgs e)
        {
            bunifuCustomTextbox5.MaxLength = 11;
            
        }

        private void bunifuThinButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void driver_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton8_Click(object sender, EventArgs e)
        {

            string len = bunifuCustomTextbox5.Text;

            if (String.IsNullOrEmpty(bunifuCustomTextbox4.Text))
            {
                String error = "Enter Driver Name";
                label2.Text = error.ToString();
                //MessageBox.Show("Enter Driver Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox5.Text))
            {
                String error = "Enter Contact Number";
                label1.Text = error.ToString();
                //MessageBox.Show("Enter Contact Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bunifuCustomTextbox5.Text.Length != 11)
            {
                String error = "Contact No should consists of 11 characaters";
                label1.Text = error.ToString();
                //MessageBox.Show("Enter the correct Contact Number including 94 in the front.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox2.Text))
            {
                String error = "Enter Driver Address";
                label3.Text = error.ToString();
                //MessageBox.Show("Enter Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            else
            {

                try
                {

                    //insert into table
                    String insert = "INSERT INTO driverdetails (DriverName,DOB,Address,ContactNo) VALUES ('" + this.bunifuCustomTextbox4.Text.ToString() + "','" + this.dateTimePicker1.Text.ToString() + "','" + this.bunifuCustomTextbox2.Text + "','" + this.bunifuCustomTextbox5.Text + "')";
                    MySqlCommand command = new MySqlCommand(insert, connnection);
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                    MySqlCommand cmnd = new MySqlCommand(insert, con);
                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                    MessageBox.Show("Inserted Sucessfully");

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");


                }
            }
        }
        

        private void bunifuThinButton5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            String id;
            id = bunifuTextbox1.text;

            dt = db.ReadValue("Select * From driverdetails where '" + id + "' = DriverID");
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > -1)
            {
                bunifuCustomTextbox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bunifuCustomTextbox4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                bunifuCustomTextbox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                bunifuCustomTextbox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                

            }
            
                        
        }

        private void bunifuThinButton7_Click(object sender, EventArgs e)
        {
            bunifuCustomTextbox4.Clear();
            bunifuCustomTextbox2.Clear();
            bunifuCustomTextbox5.Clear();
            bunifuCustomTextbox1.Clear();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void bunifuThinButton6_Click(object sender, EventArgs e)
        {
            
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                try
                {

                    //delete from table
                    String delete = " DELETE FROM driverdetails WHERE DriverID = '" + Convert.ToInt32(this.bunifuCustomTextbox1.Text) + "' ";

                    MySqlCommand command = new MySqlCommand(delete, connnection);

                    MySqlCommand cmnd = new MySqlCommand(delete, con);
                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK);



                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");


                }
            }

        

        private void bunifuThinButton10_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            dt = db.ReadValue("Select * From driverdetails");
            dataGridView1.DataSource = dt;
        }

        private void bunifuCustomTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void bunifuCustomTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton9_Click(object sender, EventArgs e)
        {
            string len = bunifuCustomTextbox5.Text;

            if (String.IsNullOrEmpty(bunifuCustomTextbox4.Text))
            {
                String error = "Enter Driver Name";
                label2.Text = error.ToString();
                //MessageBox.Show("Enter Driver Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox5.Text))
            {
                String error = "Enter Contact Number";
                label1.Text = error.ToString();
                //MessageBox.Show("Enter Contact Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bunifuCustomTextbox5.Text.Length != 11)
            {
                String error = "Contact No should consists of 11 characaters";
                label1.Text = error.ToString();
                //MessageBox.Show("Enter the correct Contact Number including 94 in the front.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox2.Text))
            {
                String error = "Enter Driver Address";
                label3.Text = error.ToString();
                //MessageBox.Show("Enter Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                try
                {
                    //update table

                    String update = "UPDATE driverdetails SET DriverName = '" + this.bunifuCustomTextbox4.Text.ToString() + "', DOB = '" + this.dateTimePicker1.Text.ToString() + "', Address = '" + this.bunifuCustomTextbox2.Text + "', ContactNo ='" + this.bunifuCustomTextbox5.Text + "' WHERE DriverID = '" + this.bunifuCustomTextbox1.Text + "'";
                    MySqlCommand command = new MySqlCommand(update, connnection);

                    MySqlCommand cmnd = new MySqlCommand(update, con);
                    MySqlDataReader myreader;
                    con.Open();
                    myreader = cmnd.ExecuteReader();
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);



                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");


                }
            }
        }
        private void bunifuCustomTextbox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetterOrDigit(ch))
            {
                e.Handled = true;

            }
        }

        private void bunifuThinButton11_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            dt = db.ReadValue("Select * From driverdetails");
            dataGridView1.DataSource = dt;

            bunifuCustomTextbox4.Clear();
            bunifuCustomTextbox2.Clear();
            bunifuCustomTextbox5.Clear();
            bunifuCustomTextbox1.Clear();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void bunifuThinButton3_Click_1(object sender, EventArgs e)
        {
            HarasaraSystem.MainMenu mm = new HarasaraSystem.MainMenu();
            this.Hide();
            mm.Show();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

       /* private void bunifuThinButton1_Click_1(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Ender\Desktop\Viva work\HarasaraSystem\Driverhelp.txt";
            using (StreamReader rdr = new StreamReader(filename))
            {
                String content = rdr.ReadToEnd();
                textBox1.Text = content;
            }
        }*/
    }
}
