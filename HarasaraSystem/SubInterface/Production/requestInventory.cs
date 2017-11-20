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
    class requestInventory
    {
        DBAccess db1 = new DBAccess();
        DBAccess db2 = new DBAccess();
        int c;
        int tot;

        DateTime dateValue = new DateTime();
           
        public void request(int iid,int count)
        {
            
            String query = "SELECT * FROM `ordereditems` WHERE `ItemNo` = '" + iid + "'";

            DataTable dt1 = new DataTable();
            
            dt1 = db1.Select(query);

            if (dt1.Rows.Count < 1)
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                db1.Insert("INSERT INTO `ordereditems`(`ItemNo`, `Quantity`, `Date`) VALUES ('" + iid + "' , '" + count + "' , '" + date + "' ) ");
            }
            else
            {
                foreach (DataRow row in dt1.Rows)
                {
                    c = Convert.ToInt32(row["Quantity"].ToString());
                }
                tot = c + count;
                db2.Update("UPDATE `ordereditems` SET `Quantity`= '" + tot + "' WHERE `ItemNo` = '" + iid + "'");
            }
        }
    }
}
