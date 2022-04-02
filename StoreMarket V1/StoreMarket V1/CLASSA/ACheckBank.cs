using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarket_V1
{
    public class ACheckBank
    {
        public int id { get; set; }
        public int AgentID { get; set; }
        public int CheckNumber { get; set; }
        public String CheckSirial { get; set; }
        public double Price { get; set; }
        public DateTime DayDate { get; set; } 
        public DateTime PassDate { get; set; }
        public int AdminBankID { get; set; }
        public int AgentBankID { get; set; }
        public bool IsActive { get; set; }
        public bool DeleteStatus { get; set; }
        public bool  Status { get; set; }//ایا چک پاس شده یا خیر    پاس شده درست نشده نادرست

    }
}
