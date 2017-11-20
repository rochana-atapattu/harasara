using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace HarasaraSystem.SubInterface.Production
{
    public partial class ProductItems : Form
    {
        DBAccess db = new DBAccess();
        public ProductItems()
        {
            InitializeComponent();
          // fillcombo();
            
        }

        void fillcombo()
        {

            String query = "Select * from inventory";
            string connectionString = "server=localhost;user id=root;database=harasara2";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myR;
            try
            {
                con.Open();
                myR = cmd.ExecuteReader();

                while (myR.Read())
                {
                    string name = myR.GetString("name");
                    cmbItemName.Items.Add(name);
                }
            }
            catch (Exception ex)
            {

            }
        }

        void elsefillcombo(String searchContext)
        {

            String query = "Select * from inventory where name like '%" + searchContext + "%'";
            string connectionString = "server=localhost;user id=root;database=harasara2";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myR;
            try
            {
                con.Open();
                myR = cmd.ExecuteReader();

                while (myR.Read())
                {
                    string name = myR.GetString("name");
                    cmbItemName.Items.Add(name);
                }

            }
            catch (Exception ex)
            {

            }
        }


        String pid { get; set; }
       
        public ProductItems(String ppid)
        {
            this.pid = ppid;
        }

        private void ProductItems_Load(object sender, EventArgs e)
        {
            txtPid.Text = ProductItem.ItemId;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
          
        }

       

       

        private void cmbItemName_TextChanged(object sender, EventArgs e)
        {
            
            if (cmbItemName != null)
            {

               
                DataTable dt = new DataTable();
                string qry = "Select * from inventory where name like '%" + cmbItemName.Text + "%'";
                dt = db.Select(qry);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbItemName.Items.Add(dt.Rows[i]["name"]);
                }
                
            }
            else
            {
                fillcombo();

            }

            ProductService ps = new ProductService();
            ps.SelectProduct(cmbItemName.Text);
            txtItemId.Text = ProductItem.ItemId;

            
        }

        private void cmbItemName_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            ProductItem pi = new ProductItem();
            pi.Qty = txtqty.Text;
            pi.ProductNo = txtPid.Text;
            pi.ItemName = cmbItemName.Text;
            String sql = "INSERT INTO product_items(ProductItemId,ProductNo,ItemName,Qty) VALUES ('"+ProductItem.ItemId+"','"+pi.ProductNo+"','"+pi.ItemName+"','"+pi.Qty+"')";
            db.Insert(sql);
            txtItemId.Text = "";
            txtqty.Text = "";
            cmbItemName.Text = "";
        }

        private void txtPid_TextChanged(object sender, System.EventArgs e)
        {

        }

        }
    }

