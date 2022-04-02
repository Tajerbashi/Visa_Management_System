using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class BSectionSellFactorProduct
    {
        public int id { get; set; }
        public int FactorId { get; set; }
        public bool Model { get; set; }     //buy false         sell true
        public int ProductID { get; set; }
        public int ProductMany { get; set; }

    }
}
