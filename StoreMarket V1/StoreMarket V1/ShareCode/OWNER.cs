using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class OWNER
    {
        public OWNER()
        {
            access = "ADMIN";
            Status = true;
        }
        public int id { get; set; }
        public String access { get; set; } 
        public bool Status { get; set; }
    }
}
