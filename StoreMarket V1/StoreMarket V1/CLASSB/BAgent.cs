using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class BAgent : Person
    {
        public int Id { get; set; }
        public String CompanyName { get; set; }
        public int CompanyID { get; set; }
        public bool DeleteStatus { get; set; }

    }
}
