using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class ADayInformationProduct
    {
        public int id { get; set; }
        public int ManyNumber { get; set; }
        public AProduct aProduct { get; set; }
    }
}
