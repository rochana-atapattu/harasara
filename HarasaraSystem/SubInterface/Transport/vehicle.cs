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
    public partial class vehicle : Form
    {
        public void SalesSub(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }
        public vehicle()
        {
            InitializeComponent();
            timer1.Start();
        }

        MySqlConnection connnection = new MySqlConnection("server=localhost;user id=root;database=harasara");

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
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            repair re1 = new repair();
            re1.ShowDialog();
            this.Close();

        }

        private void vehicle_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                String id;
                //String text;
                id = bunifuTextbox1.text;


                dt = db.ReadValue("Select * From vehicles where '" + id + "' = VehicleID");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void bunifuThinButton9_Click(object sender, EventArgs e)
        {

            
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            try
            {

                dt = db.ReadValue("Select * From vehicles");
                dataGridView1.DataSource = dt;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");

            }

        }

        private void bunifuThinButton7_Click(object sender, EventArgs e)
        {
            //clear feilds
            bunifuCustomTextbox1.Clear();
            bunifuCustomTextbox2.Clear();
            bunifuCustomTextbox3.Clear();
            bunifuCustomTextbox4.Clear();
            bunifuCustomTextbox5.Clear();
            bunifuCustomTextbox6.Clear();
            bunifuCustomTextbox7.Clear();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            
        }

        private void bunifuThinButton8_Click(object sender, EventArgs e)
        {
            string len = bunifuCustomTextbox5.Text;

            if (String.IsNullOrEmpty(bunifuCustomTextbox4.Text))
            {
                String error = "Enter Vehicle Number";
                label1.Text = error.ToString();
                //MessageBox.Show("Enter Driver Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox3.Text))
            {
                String error = "Enter Vehicle Type";
                label2.Text = error.ToString();
                //MessageBox.Show("Enter Contact Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (String.IsNullOrEmpty(bunifuCustomTextbox1.Text))
            {
                String error = "Enter Availability";
                label3.Text = error.ToString();
                //MessageBox.Show("Enter Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //Adding vehicle info
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();


                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                String insert = "INSERT INTO vehicles (VehicleNumber,VehicleType,Milage,NoOfRepairs,Availability,Notes) VALUES ('" + this.bunifuCustomTextbox4.Text.ToString() + "','" + this.bunifuCustomTextbox3.Text.ToString() + "','" + Convert.ToInt32(this.bunifuCustomTextbox5.Text.ToString()) + "','" + Convert.ToInt32(this.bunifuCustomTextbox6.Text.ToString()) + "','" + this.bunifuCustomTextbox1.Text.ToString() + "','" + this.bunifuCustomTextbox2.Text.ToString() + "')";
                MySqlCommand command = new MySqlCommand(insert, con);

                MySqlDataReader myreader;
                try
                {

                    con.Open();
                    myreader = command.ExecuteReader();
                    MessageBox.Show("Saved Successfully");

                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");

                }
            }

        }
        private void bunifuThinButton6_Click(object sender, EventArgs e)
        {
           MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                try
                {

                    //delete from table
                    String delete = " DELETE FROM vehicles WHERE VehicleID = '" + Convert.ToInt32(this.bunifuCustomTextbox7.Text) + "' ";

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

        private void bunifuCustomTextbox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch != 8 && ch != 46 )
            {

            e.Handled = true;
            
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > -1)
            {
                bunifuCustomTextbox7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bunifuCustomTextbox4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                bunifuCustomTextbox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                bunifuCustomTextbox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                bunifuCustomTextbox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                bunifuCustomTextbox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                bunifuCustomTextbox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                
                //comboBox1.Text = DataGridView01.Rows[e.RowIndex].Cells[1].Value.ToString();
                //Txt_FirstName.Text = DataGridView01.Rows[e.RowIndex].Cells[2].Value.ToString();
                //mIDDLENAMETextBox.Text = DataGridView01.Rows[e.RowIndex].Cells[3].Value.ToString();
                //sURNAMETextBox.Text = DataGridView01.Rows[e.RowIndex].Cells[4].Value.ToString();
                //cITYTextBox.Text = DataGridView01.Rows[e.RowIndex].Cells[5].Value.ToString();
                //eMAILTextBox.Text = DataGridView01.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void bunifuCustomTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;

            }
        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;

            }
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            bunifuCustomTextbox1.MaxLength = 3;
        }

        private void bunifuCustomTextbox6_TextChanged(object sender, EventArgs e)
        {
            bunifuCustomTextbox6.MaxLength = 3;
            
        }

        private void bunifuCustomTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetterOrDigit(ch))
            {
                e.Handled = true;

            }
        }

        private void bunifuThinButton10_Click(object sender, EventArgs e)
        {
            string len = bunifuCustomTextbox5.Text;

            if (String.IsNullOrEmpty(bunifuCustomTextbox4.Text))
            {
                String error = "Enter Vehicle Number";
                label1.Text = error.ToString();
                //MessageBox.Show("Enter Driver Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox3.Text))
            {
                String error = "Enter Vehicle Type";
                label2.Text = error.ToString();
                //MessageBox.Show("Enter Contact Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (String.IsNullOrEmpty(bunifuCustomTextbox1.Text))
            {
                String error = "Enter Availability";
                label3.Text = error.ToString();
                //MessageBox.Show("Enter Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                try
                {
                    //update table

                    String update = "UPDATE vehicles SET VehicleNumber = '" + this.bunifuCustomTextbox4.Text.ToString() + "' , VehicleType = '" + this.bunifuCustomTextbox3.Text.ToString() + "', Milage = '" + Convert.ToInt32(this.bunifuCustomTextbox5.Text.ToString()) + "', NoOfRepairs = '" + Convert.ToInt32(this.bunifuCustomTextbox6.Text.ToString()) + "', Availability = '" + this.bunifuCustomTextbox2.Text.ToString() + "', Notes = '" + this.bunifuCustomTextbox4.Text.ToString() + "')";
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

        private void bunifuThinButton3_Click(object sender, EventArgs e)
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
