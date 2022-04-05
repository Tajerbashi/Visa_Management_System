using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class BProduct
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public int price { get; set; }
        public int ManyP { get; set; }
        public BAgent bAgent { get; set; }
        public BBuyFactor bBuyFactor { get; set; }
        public BSellFactor bSellFactor { get; set; }
        public BDayInformationProduct dayInformationProduct { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
    }
}
