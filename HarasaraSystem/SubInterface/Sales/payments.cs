using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Sales
{
    public partial class payments : UserControl
    {
        private static payments _instance;

        public static payments Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new payments();
                return _instance;
                
            }
        }
        public payments()
        {
            InitializeComponent();

            
        }

      

       

        private void payments_Load(object sender, EventArgs e)
        {

            databaseAccess d1 = new databaseAccess();
            string query1 = "select * from payments";
            string query2 = "select * from customer";
            string query3 = "select * from supplier";
            string query4 = "select * from purchasepayments";
            d1.displayData(query1, dataGridView1);
            d1.displayData(query4, dataGridView2);
            d1.ComboBoxLoad("customerName", comboBox1, query2);
            d1.ComboBoxLoad("supplierName", comboBox4, query3);

            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select contactNumber from customer where customerName='" + comboBox1.Text + "'";
            string query2="select customerID from customer where customerName='"+comboBox1.Text+"'";
            databaseAccess d1 = new databaseAccess();
            textBox5.Text=d1.getString(query);
            string cusID = d1.getString(query2);

            string query3="select * from payments where customerID='"+cusID+"'";
            d1.displayData(query3, dataGridView1);

          

           
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            databaseAccess d1=new databaseAccess();
            
            string query = "select contactNumber from supplier where supplierName='"+comboBox4.Text+"'";
            textBox4.Text = d1.getString(query);
            string query2 = "select SupID  from supplier where supplierName='"+comboBox4.Text+"'";

            string supID = d1.getString(query2);
            string query3 = "select * from  purchasepayments where SupplierID='"+supID+"'";
            d1.displayData(query3, dataGridView2);
        }

        
    }
}
