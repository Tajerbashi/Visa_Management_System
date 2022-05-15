using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class BSellFactor
    {
        public int id { get; set; }
        public bool Type { get; set; }
        public bool Model { get; set; }  // sell or buy
        public double Price { get; set; }
        public String DayDate { get; set; }
        public int factorNumber { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public List<BProduct> bProducts { get; set; } = new List<BProduct>();
        public BCustomer bCustomer { get; set; }
    }
}
