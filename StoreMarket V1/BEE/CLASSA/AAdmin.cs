using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class AAdmin : Person
    {
        public int id { get; set; }
        public String OwnerName { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public bool AccessControl { get; set; }
        public String accessCode { get; set; }
    }


}
