using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class ASellFactor
    {
        public int id { get; set; }
        public int FactorNumber { get; set; }
        public int FactorCode { get; set; }
        public String RegisterDate { get; set; }
        public double TotalPrice { get; set; }
        public bool CashType { get; set; }  // true Money   false Banki
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public List<AProduct> Products { get; set; } = new List<AProduct>();
        public ACustomer Customer { get; set; }
        public AAdmin admin { get; set; }
    }
}
