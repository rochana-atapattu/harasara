using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarasaraSystem.SubInterface.Production
{
    public class Product
    {
        public String ProductId { set; get; }
        public String ProductName { set; get; }
        public double Price { set; get; }
        public int Estimated { set; get; }
        public String Category { set; get; }
        public String ProductImage { set; get;}
    }
}
