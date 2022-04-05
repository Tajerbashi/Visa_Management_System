using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class BAgentBankAccount
    {
        public int id { get; set; }
        public String NameBank { get; set; }
        public String AccountNumber { get; set; }
        public String OwnerName { get; set; }
        public BAgent bAgent { get; set; }
        public List<BCheckBank> bCheckBank { get; set; } = new List<BCheckBank>();

    }
}
