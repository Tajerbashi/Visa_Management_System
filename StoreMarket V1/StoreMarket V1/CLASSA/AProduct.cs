using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class AProduct
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public int buyPrice { get; set; }
        public int newBuyPrice { get; set; }
        public int sellPrice { get; set; }
        public int ManyP { get; set; }
        public AAgent aAgent { get; set; }
        public ABuyFactor aBuyFactor { get; set; }
        public ASellFactor aSellFactor { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
    }
}
