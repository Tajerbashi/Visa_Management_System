using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class AAgentBankAccount
    {
        public int id { get; set; }
        public String NameBank { get; set; }
        public String AccountNumber { get; set; }
        public String OwnerName { get; set; }
        public String AgentName { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public AAgent aAgent { get; set; }
        public List<ACheckBank> aCheckBank { get; set; } = new List<ACheckBank>();

    }
}
