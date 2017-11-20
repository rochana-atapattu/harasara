using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    public partial class OrdersUC : UserControl
    {
        private static OrdersUC _instance;

        public static OrdersUC Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new OrdersUC();
                return _instance;

            }
        }
        DBAccess db=new DBAccess();
        DataTable dt = new DataTable();
        prepareOrder pre = new prepareOrder();
        
        public OrdersUC()
        {
            InitializeComponent();
            FillDGV();

        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            FillDGVpen("pending");
        }
        public void FillDGVpen(String status)
        {

            String query = "SELECT `productID`, `productName`, `category` , `orderID`,`Quantity`, `status` FROM `products` where status = '" + status + "'";

            try
            {
                
                dt = db.Select(query);

                dataGridView1.ColumnCount = 6;
                dataGridView1.DataSource = dt;
                dt.Dispose();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            String pid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String qty = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            String oid = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            prepareOrder pr = new prepareOrder();

           
        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {
            String oid = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            String pid = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            
            splitOrder s = new splitOrder(oid,pid);
            Boolean add = s.split();
            if(add)
            {
                MessageBox.Show("The order was added successfully");
            }
            else
            {
                MessageBox.Show("The order was not added");
            }
            
        }
        public void FillDGV()
        {

            String query = "SELECT `productID`, `productName`, `category` , `orderID`,`Quantity`, `status` FROM `products` ";

            try
            {
               
                dt = db.Select(query);


                dataGridView1.DataSource = dt;
                dt.Dispose();
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void OrdersUC_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuThinButton4_Click(object sender, EventArgs e)
        {
            FillDGVpen("completed");
        }

        private void bunifuThinButton5_Click(object sender, EventArgs e)
        {
            FillDGV();
        }
    }
}
