using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
namespace StoreMarket_V1
{
    public class Functions
    {
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        public bool register(OWNER owner)
        {
            DBCLASS dbc = new DBCLASS();
            foreach (var item in dbc.Owner)
            {
                if (owner.access == item.access)
                {
                    return true;
                }
            }
            return false;
        }

        public void FirstLoginAdminA()
        {
            DBCLASS dbc = new DBCLASS();
            OWNER owner = new OWNER();
            if (!register(new OWNER
            {
                access = "ADMIN1",
                password = "ADMIN1"
            }))
            {
                owner.access = "ADMIN1";
                owner.password = "ADMIN1";
                owner.Status = true;
                dbc.Owner.Add(owner);
                dbc.SaveChanges();
                //MessageBox.Show("ادمین اول موجود نبود و جدید ثبت شد");
            }
        }

        public void FirstLoginAdminB()
        {
            DBCLASS dbc = new DBCLASS();
            OWNER owner = new OWNER();
            if (!register(new OWNER
            {
                access = "ADMIN2",
                password = "ADMIN2"

            }))
            {
                owner.access = "ADMIN2";
                owner.password = "ADMIN2";
                owner.Status = true;
                dbc.Owner.Add(owner);
                dbc.SaveChanges();
                //MessageBox.Show("ادمین دوم موجود نبود و جدید ثبت شد");
            }
        }

        public bool CheckAdminA(String Access,String User, String Pass)
        {
            DBCLASS dbc = new DBCLASS();

            foreach (var item in dbc.Owner)
            {
                if (Access == "ADMIN1"  && item.access == User && item.password == Pass && item.Status == true)
                {
                    return true;
                }
            }

            foreach(var item in dbc.aAdmins)
            {
                if(item.accessCode == Access && item.Username==User && item.Password == Pass)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckAdminB(String Access,String User, String Pass)
        {
            DBCLASS dbc = new DBCLASS();

            foreach (var item in dbc.Owner)
            {
                if (Access == "ADMIN2" && item.access == User && item.password == Pass && item.Status == true)
                {
                    return true;
                }
            }

            foreach (var item in dbc.bAdmins)
            {
                if (item.accessCode == Access && item.Username == User && item.Password == Pass)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
