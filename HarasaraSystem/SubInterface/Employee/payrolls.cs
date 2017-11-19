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
    public partial class payrolls : UserControl
    {
        private static payrolls _instance;
        public static payrolls Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new payrolls();

                return _instance;

            }
        }
        public payrolls()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
