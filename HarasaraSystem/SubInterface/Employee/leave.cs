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
    public partial class leave : UserControl
    {

        private static leave _instance;
        public static leave Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new leave();

                return _instance;

            }
        }
        public leave()
        {
            InitializeComponent();
        }
    }
}
