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

namespace HarasaraSystem.SubInterface.Sales
{
    public partial class SalesOrders : UserControl
    {

        private static SalesOrders _instance;

        public static SalesOrders Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new SalesOrders();
                return _instance;

            }
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
        MySqlCommand cmd;
        MySqlCommand cmd1;
        MySqlCommand cmd2;
        

        
        
        
     
        public SalesOrders()
        {

            InitializeComponent();
            databaseAccess d1 = new databaseAccess();
            d1.AutoCompleteText(textBox5,"select * from customer","customerName");
            
        }
     
            

         
        

        //Dispay th all orders in form
        private void SalesOrders_Load(object sender, EventArgs e)
        {

            string query="select * from slorders";
          
            databaseAccess d1 = new databaseAccess();
            d1.displayData(query, dataGridView1);

            
        }
        //Insert new Customer Details in to database
        public void getCustomerDetails()
        {
            con.Open();

            try {   
            string customer = textBox5.Text;
            string number = textBox7.Text;
            string email = textBox6.Text;
            string address = richTextBox1.Text;

          

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customer (customerName,contactNumber,Address,Email) values('"+customer+"','"+number+"','"+address+"','"+email+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message,"OK");
                con.Close();
            }
            

        }
        //Insert customer provided order details in to the database
        public void getOrderdetails()
        {

        

            double sum = 0;
            int orderID = Convert.ToInt32(label20.Text);

            for (int i = 0; i < dataGridView2.Rows.Count;++i )
            {
                sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value);

            }
            string query="insert into slorders values ('"+orderID+"','"+textBox5.Text+"','"+label22.Text+"','"+sum+"','"+dateTimePicker1.Text+"')";
            databaseAccess d1 = new databaseAccess();
            d1.InsertData(query);
            label24.Text = sum.ToString();
           
 
          
        }

       //Insert and calculate provided Order price
        public void addOrderDetails()
    {
         con.Open();
        double pr = 0;
        string prID=" ";
        try
        {
            
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select productID,Price  from finishedproducts where Category='"+comboBox1.Text+"' AND productName='"+comboBox3.Text+"' ";
            
            MySqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    prID = dr["productID"].ToString();
                    pr = Convert.ToDouble(dr["Price"]);
                   

                }

            }
            dr.Close();
        

            int qu = Convert.ToInt32(textBox1.Text);

            double totalp = (qu*pr);

            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into products values ('"+prID +"','"+comboBox3.Text+"','"+pr+"','"+qu+"','"+totalp+"','"+comboBox1.Text+"','"+label20.Text+"')";
            cmd1.ExecuteNonQuery();
            cmd2 = con.CreateCommand();
           
           cmd2.CommandType = CommandType.Text;
           cmd2.CommandText = "select * from products where orderID='"+label20.Text+"' ";
           cmd2.ExecuteNonQuery();
            
            
            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }


            
       //validate digit characters of Contct Nyumber
        
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            validation v1 = new validation();
            v1.validatedigitCharacters(ch, label26);
            
        }
        

       
        //load relevent product values in to combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            comboBox3.Items.Clear();
            
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select productName from finishedproducts where Category ='"+comboBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                comboBox3.Items.Add(dr["productName"].ToString());
            }
            con.Close();

        }
       

        

        

      

        public void filterOrder()
        {
            string vcustomerID ="";
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "select customerID from customer where customerName LIKE '"+cusText.Text + "%' OR contactNumber ='"+numText.Text+"%'";
                MySqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                      vcustomerID = dr["customerID"].ToString();
                       
                    }

                }
                dr.Close();

                cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from slorders where cusID ='"+vcustomerID+ "' ";
                cmd1.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterOrder();
        }

        

        //load to the customer and order details when click on the dataGirdView

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            int  ID = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            int OrID = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

            label17.Text = ID.ToString();
            label7.Text = OrID.ToString();
            string query="select * from customer where customerID='"+ID+"'";
            string query1 = "select * from slorders where orderID='" + OrID + "' ";

            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            MySqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    cusText.Text = dr[1].ToString();
                    numText.Text = dr[2].ToString();
                    emailText.Text = dr[4].ToString();
                    Address.Text = dr[3].ToString();

                }


            }
            dr.Close();

            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = query1;

            MySqlDataReader dr1 = cmd1.ExecuteReader();

            if(dr1.HasRows)
            {
                while(dr1.Read())
                {

                    dateTimePicker2.Text = dr1[4].ToString();
                    label9.Text = dr1[3].ToString();
                }
            }
            dr1.Close();
            con.Close();
        }
        //Cancel Order
        private void button7_Click(object sender, EventArgs e)
        {
           int x=dataGridView1.SelectedCells[0].RowIndex;
            int ID=Convert.ToInt32(label7.Text);
            string query="Delete from slorders where orderID='"+ID+"'";
            string query2 = "Delete from products where orderID='" + ID + "'";
            string query1 = "select * from slorders ";
            //string query1 = "Delete from harasara.products where ";
            databaseAccess d1=new databaseAccess();
            d1.deleteData(query);
            d1.deleteData(query2);
            d1.displayData(query1,dataGridView1);
            
        }

        
        private void emailText_Leave(object sender, EventArgs e)
        {
            if (emailText.Text != null)
            {


                validation v1 = new validation();
                v1.emailValidation(emailText.Text, label30);
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text != null)
            {
                validation v1 = new validation();
                v1.emailValidation(textBox6.Text, label28);

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            string query = "select * from customer where customerName='" + textBox5.Text + "' ";
            databaseAccess d1 = new databaseAccess();
           
            if(label22.Text=="XXXXXX")
            {
                string query1 = "select max(customerID) from customer";
                string query2 = "select max(orderID) from slorders";
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query1;

                MySqlDataReader dr = cmd.ExecuteReader();
                
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        label22.Text =(Convert.ToInt32 (dr[0]) + 1).ToString();
                    }
                }

                dr.Close();

                con.Close();
                con.Open();
                cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = query2;

                 MySqlDataReader dr1 = cmd1.ExecuteReader();

                if(dr1.HasRows)
                {
                    while(dr1.Read())
                    {
                        label20.Text =(Convert.ToInt32(dr1[0]) + 1).ToString();
                    }
                }
                dr1.Close();
                con.Close();

                

            }
            else
            {
                string query2 = "select max(orderID) from slorders";
                con.Open();
                cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = query2;

                MySqlDataReader dr1 = cmd1.ExecuteReader();

                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        label20.Text = (Convert.ToInt32(dr1[0]) + 1).ToString();
                    }
                }
                dr1.Close();
                con.Close();

            }
                
         }

        private void Pay_Click(object sender, EventArgs e)
        {
            
            
            Bill b1 = new Bill(cusText.Text, numText.Text, Address.Text, emailText.Text, label7.Text,label9.Text,label17.Text,1);
            b1.Show();
        }
        //loading table when text on the Customer Text Changed
        private void cusText_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from slorders where cusName LIKE '" + cusText.Text + "%' ";
            databaseAccess d1 = new databaseAccess();
            d1.displayData(query, dataGridView1);

        }

        private void numText_Leave(object sender, EventArgs e)
        {
            validation v1 = new validation();
            v1.contactNumberValidation(numText.Text, label16);
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            validation v1 = new validation();
            v1.contactNumberValidation(textBox7.Text, label26);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            string query = "select * from customer where customerName='" + textBox5.Text + "'";
            //  string query1 = "select max(orderID) from harasara.slorders";


            con.Open();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;



                MySqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        label22.Text = dr["customerID"].ToString();
                        textBox7.Text = dr["contactNumber"].ToString();
                        textBox6.Text = dr["Email"].ToString();
                        richTextBox1.Text = dr["Address"].ToString();
                        //pr = Convert.ToDouble(dr["Price"]); 
                    }
                }


                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            

           
            


        }

        private void numText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char x = e.KeyChar;
            validation v1 = new validation();
            v1.validatedigitCharacters(x, label16);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char x = e.KeyChar;
            validation v1 = new validation();
            v1.validatedigitCharacters(x, label27);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==8)
            {
                label22.Text = "XXXXXX";
                textBox7.Text = null;
                textBox6.Text = null;
                richTextBox1.Text = null;
            }
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            string query="select * from slorders";
            addOrderDetails();
            databaseAccess d1 = new databaseAccess();
            d1.displayData(query, dataGridView1);
           
        }
        //RECORRECT
        private void Order1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select COUNT(*) from customer where customerID='"+label22.Text+"'";

            int recordCount=Convert.ToInt32( cmd.ExecuteScalar());

            if(recordCount==1)
            {
                getOrderdetails();
            }
            else
            {
                getCustomerDetails();
                getOrderdetails();
            }
            con.Close();


        }

        private void Pay1_Click(object sender, EventArgs e)
        {
            if (label20.Text == "XXXXXX")
            {
                CustomMsgBox.Show("Your Order Is Not Successfully Processed", "OK");
            }
            else
            {
               Bill b1 = new Bill(textBox5.Text, textBox7.Text, richTextBox1.Text,textBox6.Text,label20.Text,label24.Text,label22.Text,1);
                b1.Show();
            }
        }

       

       
       
            
            

        

     
    }       


   }

        



        
        
       

       
       
       

        

       

     

        

       

        

       

       

       
    

