using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class AAdminBankAccount
    {
        public int id { get; set; }
        public String NameBank { get; set; }
        public String AccountNumber { get; set; }
        public String OwnerName { get; set; }
        public Int64 phonenumber { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public AAdmin aadmin { get; set; }
        public List<ACheckBank> aCheckBank { get; set; } = new List<ACheckBank>();
    }
}
