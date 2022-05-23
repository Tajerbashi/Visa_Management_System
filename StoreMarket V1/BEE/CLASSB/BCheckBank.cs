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
        public String CustomerName { get; set; }
        public int CodeNumber { get; set; }
        public int SariNumber { get; set; }
        public int CheckSirial { get; set; }
        public double Price { get; set; }
        public String DayDate { get; set; }
        public String PassDate { get; set; }
        public bool DeleteStatus { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public bool Status { get; set; }   //ایا چک پاس شده یا خیر    پاس شده درست نشده نادرست

        public BAdminBankAccount bAdminBankAccount { get; set; }
        public BAgentBankAccount bAgentBankAccount { get; set; }
        public List<BBuyFactor> bBuyFactor { get; set; } = new List<BBuyFactor>();

    }
}
