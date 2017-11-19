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
    public partial class PurchasingOrders : UserControl
    {

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
    



        private static PurchasingOrders _instance;

        public static PurchasingOrders Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new PurchasingOrders();
                return _instance;

            }
        }
        public PurchasingOrders()
        {
            InitializeComponent();

            databaseAccess d1 = new databaseAccess();
            d1.AutoCompleteText(textBox1,"select * from supplier","supplierName");
            d1.AutoCompleteText(textBox3,"select * from supplier", "supplierName");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            databaseAccess d1=new databaseAccess();

            string query = "select count(*) from supplier where supplierName='" + textBox1.Text + "'";
            

            if(1==d1.getValue(query))
            {
                string supID = "select SupID from supplier  where supplierName='" + textBox1.Text + "'";
                
                label9.Text = d1.getString(supID);

                string items = "select * from itemsandsupplier where SupID='"+label9.Text+"'";
                d1.ComboBoxLoad("ItemDescription", comboBox1, items);




            }
            else
            {
                label9.Text = null;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "XXXX";
            textBox1.Text = "         ";
            label9.Text = "XXXXXXX";
            label10.Text = "XXXXXX";
            textBox2.Text = "    ";
            comboBox1.Text = "     ";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            databaseAccess d1=new databaseAccess();
            string itemNo = "select ItemNo from itemsandsupplier where ItemDescription='" + comboBox1.Text + "'";

            
            label10.Text = d1.getString(itemNo);
            string query = "select price from inventory where item_id ='" + label10.Text + "'";

            label14.Text = d1.getString(query);

           // string itemPrice="select price from inventory where "
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            validation v1 = new validation();
            v1.validatedigitCharacters(ch, label11);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double tprice = (Convert.ToDouble(label14.Text)) * (Convert.ToInt32(textBox2.Text));
         string query = "insert into ordereditems values ('"+Convert.ToInt32(label8.Text)+"','"+Convert.ToInt32(label10.Text)+"','"+comboBox1.Text+"','"+Convert.ToDouble(label14.Text)+"','"+Convert.ToInt32(textBox2.Text)+"','"+tprice+"','"+label9.Text+"','"+dateTimePicker1.Text+"')";
         databaseAccess d1 = new databaseAccess();
         d1.InsertData(query);
         string query2 = "select * from ordereditems where orderId='" + label8.Text + "' ";


         d1.displayData(query2, dataGridView1);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string query="select max(orderID) from ordereditems";

            databaseAccess d1 = new databaseAccess();

            label8.Text= (d1.getValue(query)+ 1).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
             databaseAccess d1 = new databaseAccess();
            string total = "select sum(TotalPrice) from ordereditems where orderID='" + Convert.ToInt32(label8.Text) + "'";

            double finalPrice = d1.getValue(total);
            string query = "insert into purchaseorders values ('"+Convert.ToInt32(label8.Text)+"','"+label9.Text+"','"+finalPrice+"','"+dateTimePicker1.Text+"')";
           
            d1.InsertData(query);
            CustomMsgBox.Show("Your order is succefully processed", "OK");

            


        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            databaseAccess d1 = new databaseAccess();
            string query = "select count(*) from supplier where supplierName='" + textBox3.Text + "'";

            int count = d1.getValue(query);

            if(count==1)
            {
                string supID = "select SupID from supplier where supplierName='"+textBox3.Text+"'";

                label18.Text = d1.getString(supID);

                string query2 = " select * from purchaseorders where SupplierId='" + label18.Text + "'";

                d1.displayData(query2, dataGridView1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string number="select contactNumber from supplier where SupID='"+label9.Text+"'";
            string add="select Address from supplier where SupID='"+label9.Text+"'";
            string acNum = "select AccountNumber from supplier where SupID='" + label9.Text + "'";
            string FINAL="select Price from purchaseorders where SupplierId='"+label9.Text+"'";

            databaseAccess d1=new databaseAccess();
            string conNum=d1.getString(number);
            string Add=d1.getString(add);
            string acc = d1.getString(acNum);
            string price=d1.getString(FINAL);
            Bill b = new Bill(textBox1.Text,conNum,Add,acc,label8.Text,price,label9.Text,2);
            b.Show();

        }



    }
}
