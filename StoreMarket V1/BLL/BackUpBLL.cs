using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using BEE;
namespace BLL
{
    public class BackUpBLL
    {
        BackUpDAL dlc = new BackUpDAL();
        public void BackUp(String Path)
        {
            dlc.BackUp(Path);
        }

        public void Restore(String Path)
        {
            dlc.Restore(Path);
        }

    }
}
