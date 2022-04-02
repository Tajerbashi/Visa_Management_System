using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class ASellFactor
    {
        public int id { get; set; }
        public bool Type { get; set; }
        public bool Model { get; set; }  // sell or buy
        public double Price { get; set; }
        public DateTime DayDate { get; set; }
        public int factorNumber { get; set; }
        public int CustomerID { get; set; }
    }
}
