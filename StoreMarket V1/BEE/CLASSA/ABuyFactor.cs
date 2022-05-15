using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class ABuyFactor 
    {   //  فاکتور خرید
        public int id { get; set; }
        public int FactorNumber { get; set; }
        public int FactorCode { get; set; }
        public AAgent agent { get; set; }
        public ACompany company { get; set; }
        public String RegisterDate { get; set; }
        public Int16 CashType { get; set; } //  1 Money     2 Banki
        public double TotalPrice { get; set; }
        public AAdmin admin { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public List<AProduct> aProducts { get; set; } = new List<AProduct>();
    }
}
