using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class AProduct
    {
        public int id { get; set; }
        public int SellCount { get; set; } = 0; // شمارنده فروش
        public int BuyCount { get; set; } = 0; // شمارنده خرید
        public int Mojodi { get; set; } = 0; // شمارنده موجودی
        public String Name { get; set; }
        public String Type { get; set; }
        public String Brand { get; set; }
        public double buyPrice { get; set; }
        public double newBuyPrice { get; set; }
        public double sellPrice { get; set; }
        public String RegisterDate { get; set; }
        public String ProduceDate { get; set; }
        public String ExpireDate { get; set; }
        public String Details { get; set; }
        public int CashType { get; set; }
        public String Picture { get; set; }
        public String AgentName { get; set; }
        public double Totalcash { get; set; } = 0;

        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public ABuyFactor aBuyFactor { get; set; }
        public ASellFactor aSellFactor { get; set; }
    }
}
