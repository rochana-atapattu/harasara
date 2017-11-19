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
    public partial class notifications : UserControl
    {

        private static notifications _instance;
        public static notifications Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new notifications();

                return _instance;

            }
        }
        public notifications()
        {
            InitializeComponent();
        }
        int counter = 0;
        int len = 0;
        string txt;
        private void notifications_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();

        }

     /*   private void timer1_Tick(object sender,EventArgs e)
        {
           
        }*/

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                label1.Text = "";
            }
            else
            {
                label1.Text = txt.Substring(0, counter);
            }

        }
    }
}
