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
        public int FactorNumber { get; set; }
        public int FactorCode { get; set; }
        public String RegisterDate { get; set; }
        public double TotalPrice { get; set; }
        public bool CashType { get; set; }  // sell or buy
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public List<BProduct> Products { get; set; } = new List<BProduct>();
        public BCustomer Customer { get; set; }
        public BAdmin admin { get; set; }

    }
}
