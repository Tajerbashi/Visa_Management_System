using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class BAgent : Person
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public String CompanyName { get; set; }
        public bool DeleteStatus { get; set; }
        public BCompany Company { get; set; }
        public List<BAgentBankAccount> bAgentBankAccounts { get; set; } = new List<BAgentBankAccount>();
        public List<BProduct> bProducts { get; set; } = new List<BProduct>();
    }
}
