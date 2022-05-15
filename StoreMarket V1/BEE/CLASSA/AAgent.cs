using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class AAgent : Person
    {
        public int Id { get; set; }
        public String CompanyName { get; set; }
        public ACompany Company { get; set; }
        public List<AAgentBankAccount> aAgentBankAccounts { get; set; } = new List<AAgentBankAccount>();
        public List<ABuyFactor> buyFactors { get; set; } = new List<ABuyFactor>();
        
    }
}
