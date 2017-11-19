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
    public partial class attendance : UserControl
    {

        private static attendance _instance;
        public static attendance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new attendance();

                return _instance;

            }
        }
        public attendance()
        {
            InitializeComponent();
        }
    }
}
