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
        DBAccess db = new DBAccess();
        public void checkAvailability()
        {
            String query = "SELECT * FROM `product_items` WHERE ProductItemID= '" +  "123" + "' ";

            DataTable dt = new DataTable();
            dt = db.Select(query);



            //String query1 = "SELECT  `count` FROM `inventory` WHERE `item_id`= ";
            //DataTable dt1 = new DataTable();
            //dt1 = db.Select(query1);


            var rowColl = dt.AsEnumerable();
            int count = (from r in rowColl
                         where r.Field<int>("ProductItemId") == 1
                         where r.Field<int>("ProductNo") == 123
                         select r.Field<int>("Qty")).First<int>();

            MessageBox.Show(count.ToString());

            //MessageBox.Show("count is " + count);
        }
        
        
    }
}
