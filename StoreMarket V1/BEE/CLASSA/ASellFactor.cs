using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class ASellFactor
    {
        public int id { get; set; }
        public bool Type { get; set; }
        public bool Model { get; set; }  // sell or buy
        public double Price { get; set; }
        public DateTime DayDate { get; set; }
        public int factorNumber { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public List<AProduct> aProducts { get; set; } = new List<AProduct>();
        public ACustomer aCustomer { get; set; }
    }
}
