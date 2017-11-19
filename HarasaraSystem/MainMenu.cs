using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("HR Manager");
            m1.Show();
            this.Hide();
        }

        private void Transport_Click(object sender, EventArgs e)
        {
           /* Login m1 = new Login("Transport");
            m1.Show();
            this.Hide();*/
            Transport.Main ins = new Transport.Main();
            ins.Show();
            this.Hide();
        }

        private void Leave_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Sales Manager");
            m1.Show();
            this.Hide();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            /*Login m1 = new Login("Inventory");
            m1.Show();
            this.Hide();*/
            SubInterface.Inventory.InventorySub ins = new SubInterface.Inventory.InventorySub("");
            ins.Show();
            this.Hide();
        }

        private void Finance_Click(object sender, EventArgs e)
        {
           Login m1 = new Login("Finance");
            m1.Show();
            this.Hide();
            
            
        }

        private void production_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Products");
            m1.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Adminstration");
            m1.Show();
            this.Hide();
        }
       

       

        
        

        
    }
}
