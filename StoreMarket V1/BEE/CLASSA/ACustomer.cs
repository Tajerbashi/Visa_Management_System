using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class ACustomer : Person
    {
        public int id { get; set; }
        public Double BuyCost { get; set; }
        public bool DeleteStatus { get; set; }    // if be true deleted
        public List<ASellFactor> aSellFactor { get; set; } = new List<ASellFactor>();
    }
}
