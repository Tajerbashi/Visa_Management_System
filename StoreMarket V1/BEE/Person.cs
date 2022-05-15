using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class Person
    {
        public String FullName { get; set; }
        public Int64 Phone { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public bool IsActive { get; set; } = true;
        public bool DeleteStatus { get; set; } = false;

    }
}
