using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class ACompany
    {
        public int id { get; set; }
        public String CompanyName { get; set; }
        public String CompanyManager { get; set; }
        public String Phone1 { get; set; }
        public String Phone2 { get; set; }
        public String Address { get; set; }
        public String Site { get; set; }
        public String Details { get; set; }
        public bool isActive { get; set; }
        public bool DeleteStatus { get; set; }
        public List<AAgent> aAgents { set; get; } = new List<AAgent>();
    }
}
