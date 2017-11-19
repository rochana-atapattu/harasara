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
    class ProductService
    {

        public ProductItem SelectProduct(string ItemName)
        {
            ProductItem ProItem = new ProductItem();
            try
            {
                
                string sql = "SELECT item_id FROM inventory";
                if (!string.IsNullOrEmpty(ItemName))
                {
                    sql = sql + " WHERE (name LIKE '" + ItemName + "%')";
                    DBAccess db = new DBAccess();
                    DataTable dt = db.Select(sql);
                    foreach (DataRow row in dt.Rows)
                    {
                        ProductItem.ItemId = row["item_id"].ToString();
                    }
                    
                   
                }

                
            }
            catch (Exception)
            {

                throw;
            }
            return ProItem;
        }
    }
}
