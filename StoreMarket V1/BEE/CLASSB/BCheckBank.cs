using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class BCheckBank
    {
        public int id { get; set; }
        public String CheckSirial { get; set; }
        public String PersionCost { get; set; }
        public int CheckNumber { get; set; }
        public double Price { get; set; }
        public DateTime DayDate { get; set; } 
        public DateTime PassDate { get; set; }
        public bool IsActive { get; set; }
        public bool DeleteStatus { get; set; }
        public bool  Status { get; set; }//ایا چک پاس شده یا خیر    پاس شده درست نشده نادرست
        public BAdminBankAccount bAdminBankAccount { get; set; }
        public BAgentBankAccount bAgentBankAccount { get; set; }
        public List<BBuyFactor> bBuyFactor { get; set; } = new List<BBuyFactor>();

    }
}
