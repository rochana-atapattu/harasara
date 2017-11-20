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
    class prepareOrder
    {
        int liid;
        int liid2;
        int count;
        int count2;
        int diff,difff;
        DBAccess db1 = new DBAccess();
        DBAccess db2 = new DBAccess();
        requestInventory req = new requestInventory();
        public void checkAvailability()
        {
            String pid = "123";
            String query = "SELECT * FROM `product_items` WHERE `ProductNo`= '" + pid + "' ";
            String query1 = "SELECT * FROM `inventory` ";
            String name;

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt1 = db1.Select(query);
            dt2 = db2.Select(query1);


            foreach (DataRow row in dt1.Rows)
            {
                liid = Convert.ToInt32(row["ProductItemID"].ToString());
                count = Convert.ToInt32(row["Qty"].ToString());

                foreach (DataRow row2 in dt2.Rows)
                {
                    liid2 = Convert.ToInt32(row2["item_id"].ToString());
                    count2 = Convert.ToInt32(row2["count"].ToString());
                    name = row2["name"].ToString();

                    if(liid2==liid)
                    {
                        difff = count2 - count;
                        if (difff < 0)
                        {
                            diff = Math.Abs(difff);
                            DialogResult dr = MessageBox.Show("Would you like to request inventory to order "+diff+" from" +" "+name,"Check components", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                    {
                                        req.request(liid, diff);
                                        break;
                                    }
                                case DialogResult.No: break;
                            }
                            
                        }
                        else
                        {

                        }
                    }
                    
                }

                
            }
            //String query1 = "SELECT  `count` FROM `inventory` WHERE `item_id`= ";
            //DataTable dt1 = new DataTable();
            //dt1 = db.Select(query1);


            //var rowColl = dt.AsEnumerable();
            //int count = (from r in rowColl
            //             where r.Field<int>("ProductItemId") == 1
            //             where r.Field<int>("ProductNo") == 123
            //             select r.Field<int>("Qty")).First<int>();

            

            
        }
        
        
    }
}
