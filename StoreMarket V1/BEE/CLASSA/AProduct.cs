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
        public int sellCount { get; set; } = 0;
        public String Name { get; set; }
        public String Type { get; set; }
        public int buyPrice { get; set; }
        public int newBuyPrice { get; set; }
        public int sellPrice { get; set; }
        public int ManyP { get; set; }
        public String RegisterDate { get; set; }
        public String EndDate { get; set; }
        public int CashType { get; set; }
        public String AgentName { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public AAgent aAgent { get; set; }
        public ABuyFactor aBuyFactor { get; set; }
        public ASellFactor aSellFactor { get; set; }
    }
}
