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
        public bool IsActive { get; set; }
        public String CompanyName { get; set; }
        public bool DeleteStatus { get; set; }
        public ACompany Company { get; set; }
        public List<AAgentBankAccount> aAgentBankAccounts { get; set; } = new List<AAgentBankAccount>();
        public List<AProduct> aProducts { get; set; } = new List<AProduct>();
    }
}
