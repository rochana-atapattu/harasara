using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Employee
{
    public partial class details : UserControl
    {
        private static details _instance;
        public static details Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new details();

                return _instance;

            }
        }
        public details()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void details_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
