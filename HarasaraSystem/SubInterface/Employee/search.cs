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
    public partial class search : UserControl
    {

        private static search _instance;
        public static search Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new search();

                return _instance;

            }
        }
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
