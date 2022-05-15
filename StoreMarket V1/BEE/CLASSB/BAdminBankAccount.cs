using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class BAdminBankAccount
    {
        public int id { get; set; }
        public String NameBank { get; set; }
        public String AccountNumber { get; set; }
        public String OwnerName { get; set; }
        public Int64 phonenumber { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public BAdmin bAdmin { get; set; }
        public List<BCheckBank> bCheckBank { get; set; } = new List<BCheckBank>();
    }
}
