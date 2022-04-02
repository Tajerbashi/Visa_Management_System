using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class BBuyFactor
    {   //  فاکتور خرید
        public int id { get; set; }
        public bool type { get; set; }  //
        public bool Model { get; set; }  // sell or buy
        public int CheckID { get; set; }
        public DateTime DayDate { get; set; }
        public double Price { get; set; }
        public int FactorNumber { get; set; }
        public bool Status { get; set; }
        public bool DeleteStatus { get; set; }
    }
}
