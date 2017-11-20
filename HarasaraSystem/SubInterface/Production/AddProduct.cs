using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    public partial class AddProduct : Form
    {

        DBAccess db = new DBAccess();
        
        public AddProduct()
        {
            InitializeComponent();
        }
        

        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            

        }

       

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //if (!panel3.Controls.Contains(HarasaraSystem.SubInterface.Production.ProductItems.Instance))
            //{
            //    HarasaraSystem.SubInterface.Production.ProductItems.Instance.pid = txtPId.Text;
            //    panel3.Controls.Add(HarasaraSystem.SubInterface.Production.ProductItems.Instance);
            //    HarasaraSystem.SubInterface.Production.ProductItems.Instance.Dock = DockStyle.Fill;
            //    HarasaraSystem.SubInterface.Production.ProductItems.Instance.BringToFront();
                
            //}
            //else
            //{
            //    HarasaraSystem.SubInterface.Production.ProductItems.Instance.pid = txtPId.Text;
            //    HarasaraSystem.SubInterface.Production.ProductItems.Instance.BringToFront();
            //}
            ProductItem.ItemId = txtPId.Text;
            ProductItems pi = new ProductItems();
            pi.ShowDialog();
            
          }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            String sql = "INSERT INTO `product` (`ProductId`, `ProductName`, `UnitPrice`, `EstimatedDays`, `ProductCategory`) VALUES ('" + txtPId.Text + "','" + txtPName.Text + "','" + txtUPrice.Text + "','" + txtEDays.Text + "','" + txtPCategory.Text + "')";
            db.Insert(sql);
          //  txtPId.Text = "";
            txtPName.Text = "";
            txtUPrice.Text = "";
            txtEDays.Text = "";
            txtPCategory.Text = "";
            txtPimage.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
