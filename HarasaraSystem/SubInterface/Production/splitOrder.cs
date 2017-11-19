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
    class splitOrder
    {
        
        
         private String oid;
         private String pid;
         private String status="in progress";
         String q;

         
         public splitOrder(String oid, String pid)
         {
             this.oid = oid;
             this.pid = pid;
         }

        

        
        DBAccess db = new DBAccess();


        public Boolean split()
        {
            if (checkOrder(pid,oid))
            {
                MessageBox.Show("The order is already processing");
                return false;
            }
            else
            {
                String query = "SELECT * FROM products where orderID = '" + oid + "' AND productID = '" + pid + "'";

                DataTable dt = new DataTable();
                dt = db.Select(query);


                foreach (DataRow row in dt.Rows)
                {
                    q = row["Quantity"].ToString();

                }
                int quantity = Convert.ToInt32(q);
                for (int i = 1; i <= quantity; i++)
                {
                    db.Insert("INSERT INTO `splittedorder` (`productID`, `orderID`, `queNo`) VALUES ('" + pid + "', '" + oid + "','" + i + "')");
                }
                db.Update("UPDATE `products` SET `status` = '" + status + "' WHERE `productID` = '" + pid + "' AND `orderID` = '" + oid + "'");

                dt.Dispose();
                return true;
            }
        }
            public Boolean checkOrder(String pid,String oid)
            {
                DataTable dt = new DataTable();
                
                String query = "SELECT * FROM splittedOrder where orderID = '" + oid + "' AND productID = '" + pid + "'";
                dt = db.Select(query);

                if (dt.Rows.Count > 0)
                {

                        dt.Dispose();
                        return true;
                }
                else
                {
                    dt.Dispose();
                    return false;
                }

                

            }
        
    }
}
