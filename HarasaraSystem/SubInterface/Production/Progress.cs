using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    class Progress
    {

        String cutting;
        String painting;
        String drilling;
        String fitting;
        String finish;

        
        
        DataTable dt=new DataTable();
        DBAccess db=new DBAccess();

        public int checkProgress(String pid,String oid,int q)
        {
            String query = "SELECT `cutting`, `painting`, `drilling`, `fitting`, `finish` FROM `splittedorder` WHERE productID= '" + pid + "' AND orderID= '" + oid + "' AND queNo= '" + q + "' ";
            dt = db.Select(query);

            foreach (DataRow row in dt.Rows)
            {
                cutting = row["cutting"].ToString();
                painting = row["painting"].ToString();
                drilling = row["drilling"].ToString();
                fitting = row["fitting"].ToString();
                finish = row["finish"].ToString();
                

            }
            MessageBox.Show(cutting + " " + painting + " " + drilling );
            dt.Dispose();
            if ((cutting.Equals("True")) && (painting.Equals("False")) && (drilling.Equals("False")) && (fitting.Equals("False")) && (finish.Equals("False")))
            {
                return 20;
            }
            else if ((cutting.Equals("True")) && (painting.Equals("True")) && (drilling.Equals("False")) && (fitting.Equals("False")) && (finish.Equals("False")))
            {
                return 40;
            }
            else if ((cutting.Equals("True")) && (painting.Equals("True")) && (drilling.Equals("True")) && (fitting.Equals("False")) && (finish.Equals("False")))
            {
                return 60;
            }
            else if ((cutting.Equals("True")) && (painting.Equals("True")) && (drilling.Equals("True")) && (fitting.Equals("True")) && (finish.Equals("False")))
            {
                return 80;
            }
            else if ((cutting.Equals("True")) && (painting.Equals("True")) && (drilling.Equals("True")) && (fitting.Equals("True")) && (finish.Equals("True")))
            {
                return 100;
            }
            else
            return 1;
        }
    }
}
