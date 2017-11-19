using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace BMS_harasara
{
    public class dbconnect
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=harasara");

        public void openconn()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            else
            {
                MessageBox.Show("Check the Database Connection");
            }
            
        }

        public void closeconn()
        {
            conn.Close();
        }

        //Execute INSERT DELETE UPDATE queries
        public void ExQuery(string inqry)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = inqry;
            openconn();
            cmd.ExecuteNonQuery();
            closeconn();
        }

        //Get Values to DataGridViews
        public DataTable ReadValue(string qry)
        {
            string x = qry;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(x,conn);
            da.Fill(dt);
            return dt;
        }


        /*public String[] GetValues(String inqry,String Key)
        {
            String x =inqry;
            MySqlCommand cmd = new MySqlCommand(x, conn);

            String []arr=new String[10];

            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            int i=0;
            while (reader.Read())
            {
                String outkey=reader.GetString(Key);
                arr[i] = outkey;
                i++;
            }
            return arr;
        }*/

        public int retval(string qry,string coln)
        {
            string y = qry;
            string cn=coln;
            //MySqlDataAdapter da = new MySqlDataAdapter(y, conn);
            //da.Update(Val);
            //return Val;
            //try
            //{
            openconn();

                MySqlCommand cmd1 = new MySqlCommand(y, conn);

                MySqlDataReader usernameRdr = null;

                usernameRdr = cmd1.ExecuteReader();

                //while (usernameRdr.Read())
                //{
                    int username11 = (int)usernameRdr[coln];
                    return username11;
                //}
           // }
            //catch (Exception ex)
            //{
               // MessageBox.Show("Database Error");
               // return 0;
            //}

            //return 0;
        }
    }
}
