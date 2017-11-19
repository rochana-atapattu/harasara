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
    public partial class OrderProcessingUC : UserControl
    {
        private static OrderProcessingUC _instance;

        public static OrderProcessingUC Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new OrderProcessingUC();
                return _instance;

            }
        }
        public OrderProcessingUC()
        {
            InitializeComponent();
        }

        private int q;
        private String pid;
        Cutting cut;
        Painting paint;
        Drilling drill;
        Fitting fit;
        Finishing fin;

        Progress pro = new Progress();
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        prepareOrder pr = new prepareOrder();
        Manufacturing man;

        private void OrderProcessingUC_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pid= this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            FillDGV(pid);
            
        }
        void fillcombo()
        {
            String query = "SELECT DISTINCT productID FROM splittedOrder";

            
            dt = db.Select(query);

            

            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                comboBox1.Items.Add(dt.Rows[i]["productID"].ToString());
            }
            dt.Clear();
            dt.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            progressBar1.Value = 0;
            String oid = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String ppid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String queNum = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            q = Convert.ToInt32(queNum);

            MessageBox.Show(oid + " " + ppid + " " + queNum);

            int i = pro.checkProgress(ppid,oid,q);
            
            if (i == 20)
            {
                progressBar1.Value = 20;
                label1.Text = "Cutting";
            }
            else if (i == 40)
            {
                progressBar1.Value = 40;
                label1.Text = "Painting";
            }
            else if (i == 60)
            {
                progressBar1.Value = 60;
                label1.Text = "Drilling";
            }
            else if (i == 80)
            {
                progressBar1.Value = 80;
                label1.Text = "Fitting";
            }
            else if (i == 100)
            {
                progressBar1.Value = 100;
                label1.Text = "Finishing";
            }

            
        }
        public void FillDGV(String pid)
        {

            String query = "SELECT `productID`, `orderID`, `queNo` FROM `splittedorder` WHERE productID= '" + pid + "' ";
            

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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                String oid = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                String ppid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                String queNum = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                q = Convert.ToInt32(queNum);
                
                if (checkBox1.Checked)
                {
                    cut = new Cutting(ppid, oid, q);
                    cut.updateProgress();
                }
                if (checkBox2.Checked)
                {
                    paint = new Painting(ppid, oid, q);
                    paint.updateProgress();
                }
                if (checkBox3.Checked)
                {
                    drill = new Drilling(ppid, oid, q);
                    drill.updateProgress();
                }
                if (checkBox4.Checked)
                {
                    fit = new Fitting(ppid, oid, q);
                    fit.updateProgress();
                }
                if (checkBox5.Checked)
                {
                    fin = new Finishing(ppid, oid, q);
                    fin.updateProgress();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pr.checkAvailability();   
        }
    }
}
