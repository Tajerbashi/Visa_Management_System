using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
namespace StoreMarket_V1
{
    public class Functions
    {
        DBCLASS dbc = new DBCLASS();
        public string GetPersianDate(DateTime date)
        {
            System.Globalization.PersianCalendar jc = new System.Globalization.PersianCalendar();
            int hr = int.Parse(jc.GetHour(date).ToString()) > 12 ? int.Parse(jc.GetHour(date).ToString()) - 12 : int.Parse(jc.GetHour(date).ToString());
            return string.Format("{0:0000}/{1:00}/{2:00}  {3:00}:{4:00}:{5:00}  ", jc.GetYear(date), jc.GetMonth(date), jc.GetDayOfMonth(date), hr, jc.GetMinute(date), jc.GetSecond(date));
        }
        public String CLOCK()
        {
            string ToDayShamsiDate = GetPersianDate(DateTime.Now);

            return ToDayShamsiDate;
        }
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
            foreach (var item in dbc.Owner)
            {
                if (owner.access == item.access)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SelectStatusInfoA(AAdmin aAdmin)
        {
            foreach (var item in dbc.aAdmins)
            {
                if (item.Name == aAdmin.Name && item.Family == aAdmin.Family && item.Phone == aAdmin.Phone)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SelectStatusInfoB(BAdmin bAdmin)
        {
            DBCLASS dbc = new DBCLASS();
            foreach (var item in dbc.bAdmins)
            {
                if (item.Name == bAdmin.Name && item.Family == bAdmin.Family && item.Phone == bAdmin.Phone)
                {
                    return true;
                }
            }
            return false;
        }
        public bool RegisterAdminA(AAdmin aAdmin)
        {
            if (!SelectStatusInfoA(aAdmin))
            {
                dbc.aAdmins.Add(new AAdmin
                {
                    OwnerName = aAdmin.OwnerName,
                    Name = aAdmin.Name,
                    Family = aAdmin.Family,
                    Phone = aAdmin.Phone,
                    Email = aAdmin.Email,
                    Address = aAdmin.Address,
                    IsActive = aAdmin.IsActive,
                    accessCode = aAdmin.accessCode,
                    Username = aAdmin.Username,
                    Password = aAdmin.Password,
                    DeleteStatus = aAdmin.DeleteStatus
                });
                dbc.SaveChanges();
                return true;
            }

            return false;
        }
        public bool RegisterAdminB(BAdmin bAdmin)
        {
            if (!SelectStatusInfoB(bAdmin))
            {
                dbc.bAdmins.Add(new BAdmin
                {
                    OwnerName = bAdmin.OwnerName,
                    Name = bAdmin.Name,
                    Family = bAdmin.Family,
                    Phone = bAdmin.Phone,
                    Email = bAdmin.Email,
                    Address = bAdmin.Address,
                    IsActive = bAdmin.IsActive,
                    accessCode = bAdmin.accessCode,
                    Username = bAdmin.Username,
                    Password = bAdmin.Password,
                    DeleteStatus = bAdmin.DeleteStatus
                });
                dbc.SaveChanges();
                return true;
            }

            return false;
        }
        public int CheckAdminInfo(String ADMINNAME,String ADMINNUMBER)
        {
            String Owner = ADMINNAME;
            DBCLASS dbc = new DBCLASS();
            foreach (var item in dbc.Owner)
            {
                if (item.access == Owner && item.Status && ADMINNUMBER == "1")
                {
                    return 1;
                }
                else if (item.access == Owner && item.Status && ADMINNUMBER == "2")
                {
                    return 2;
                }
            }
            return 0;
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
