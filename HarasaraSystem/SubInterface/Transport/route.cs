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
    public partial class route : Form
    {
        public void SalesSub(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }
        public route()
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

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            orderRoute or1 = new orderRoute();
            or1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void route_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton8_Click(object sender, EventArgs e)
        {
            
            //add to route
            if (String.IsNullOrEmpty(bunifuCustomTextbox3.Text))
            {
                String error = "Enter Distance.";
                label3.Text = error.ToString();
                
                //MessageBox.Show("Enter Distance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox4.Text))
            {
                String error = "Enter Route Name.";
                label4.Text = error.ToString();
                //MessageBox.Show("Enter Route Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox2.Text))
            {
                String error = "Enter Route Description";
                label5.Text = error.ToString();

                //MessageBox.Show("Enter Route Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {



                //Adding vehicle info
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                String insert = "INSERT INTO route(RouteName,RouteDistance,RouteDescription) VALUES('" + this.bunifuCustomTextbox4.Text.ToString() + "','" + this.bunifuCustomTextbox3.Text.ToString() + "','" + this.bunifuCustomTextbox2.Text.ToString() + "')";
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
        private void bunifuThinButton4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            String id;
            id = bunifuTextbox1.text;

            dt = db.ReadValue("Select * From route where '" + id + "' = RouteID");
            dataGridView1.DataSource = dt;
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > -1)
            {
                bunifuCustomTextbox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bunifuCustomTextbox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bunifuCustomTextbox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                bunifuCustomTextbox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


            }
        }

        private void bunifuThinButton6_Click(object sender, EventArgs e)
        {
            
            //delete from route
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

            try
            {

                //delete from table
                String delete = " DELETE FROM route WHERE RouteID = '" + Convert.ToInt32(this.bunifuCustomTextbox1.Text) + "' ";

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
            //update route
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

            try
            {
                //update table

                String update = "UPDATE route SET RouteName = '" + this.bunifuCustomTextbox4.Text.ToString() + "' , RouteDistance = '" + this.bunifuCustomTextbox3.Text.ToString() + "', RouteDescription = '" + this.bunifuCustomTextbox2.Text.ToString()+ "')";
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

        private void bunifuThinButton7_Click(object sender, EventArgs e)
        {
            
            //clearing form
            bunifuCustomTextbox1.Clear();
            bunifuCustomTextbox2.Clear();
            bunifuCustomTextbox3.Clear();
            bunifuCustomTextbox4.Clear();
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetterOrDigit(ch))
            {

                e.Handled = true;

            }
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            dt = db.ReadValue("Select * From route");
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton11_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            dt = db.ReadValue("Select * From route");
            dataGridView1.DataSource = dt;

            bunifuCustomTextbox4.Clear();
            bunifuCustomTextbox2.Clear();
            bunifuCustomTextbox3.Clear();
            bunifuCustomTextbox1.Clear();
            label4.Text = "";
            label5.Text = "";
            label3.Text = "";
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
