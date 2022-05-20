using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class BBuyFactor 
    {   //  فاکتور خرید
        public int id { get; set; }
        public int FactorNumber { get; set; }
        public int FactorCode { get; set; }
        public BAgent agent { get; set; }
        public BCompany company { get; set; }
        public String RegisterDate { get; set; }
        public int CashType { get; set; } //  1 Money     2 Banki
        public double TotalPrice { get; set; }
        public BAdmin admin { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public List<BProduct> Products { get; set; } = new List<BProduct>();

    }
}
