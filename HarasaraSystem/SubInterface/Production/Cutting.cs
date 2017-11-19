using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    class Cutting : Manufacturing
    {
        private String pid;
        private String oid;
        private int queNum;
        Boolean progress=true;
        public Cutting(String pid,String oid,int queNum)
        {
            this.pid = pid;
            this.oid = oid;
            this.queNum = queNum;

        }
        public void updateProgress()
        {
           
            DBAccess db = new DBAccess();

            db.Update("UPDATE `splittedorder` SET `cutting`= '" + 1 + "' WHERE `productID`= '" + pid + "' AND `orderID`= '" + oid + "' AND `queNo`= '" + queNum + "' ");
        }
    }
}
