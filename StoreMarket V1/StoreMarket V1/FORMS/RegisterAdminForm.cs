using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace StoreMarket_V1
{
    public partial class RegisterAdminForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public RegisterAdminForm()
        {
            InitializeComponent();
        }
        DBCLASS dbc = new DBCLASS();
        #region FUNCTION
        public bool SelectStatusInfoA(AAdmin aAdmin)
        {
            DBCLASS dbc = new DBCLASS();
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
            //var owner = from i in dbc.Owner where i.access == MF.ADMINNAME.Text select i;
            OWNER owner = dbc.Owner.Where(c => c.access == ADMINNAME.Text).First();
            owner.Status = false;
            if (!SelectStatusInfoA(aAdmin))
            {
                dbc.aAdmins.Add(new AAdmin
                {
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
            //var owner = from i in dbc.Owner where i.access == MF.ADMINNAME.Text select i;
            OWNER owner = dbc.Owner.Where(c => c.access == ADMINNAME.Text).First();
            owner.Status = false;
            if (!SelectStatusInfoB(bAdmin))
            {
                dbc.bAdmins.Add(new BAdmin
                {
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
        #endregion
        private void RegisterAdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int CheckAdminInfo()
        {
            String Owner = ADMINNAME.Text;
            DBCLASS dbc = new DBCLASS();
            foreach (var item in dbc.Owner)
            {
                if (item.access == Owner && item.Status && ADMINNUMBER.Text == "1")
                {
                    return 1;
                }
                else if (item.access == Owner && item.Status && ADMINNUMBER.Text == "2")
                {
                    return 2;
                }
            }
            return 0;
        }
        private void checkbtn_Click(object sender, EventArgs e)
        {   //  بررسی
            MessageBox.Show(ADMINNUMBER.Text.ToString());
            if((ADMINNUMBER.Text == "1" && !SelectStatusInfoA(new AAdmin { Name = Nametxt.Text, Family = Familytxt.Text, Phone = Int64.Parse(Phonetxt.Text) }))
                ||
               (ADMINNUMBER.Text == "2" && !SelectStatusInfoB(new BAdmin { Name = Nametxt.Text, Family = Familytxt.Text, Phone = Int64.Parse(Phonetxt.Text) })))
            {
                MessageBox.Show("ادمین جدید است");
            }
            else
            {
                MessageBox.Show("اطلاعات تکراری است");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   // ذخیره ادمین
            Functions Fun = new Functions();
            if (ADMINNUMBER.Text == "1" && RegisterAdminA(new AAdmin
            {
                Name = Nametxt.Text,
                Family = Familytxt.Text,
                Phone = Int64.Parse(Phonetxt.Text),
                Email = Emailtxt.Text,
                Address = Addresstxt.Text,
                IsActive = (Statustxt.Text) == "فعال" ? true : false,
                Username = usernametxt.Text,
                Password = userpasstxt.Text,
                accessCode = accessCode.Text,
                DeleteStatus = false
            }))
            {
                MessageBox.Show("ثبت نام انجام شد");
                Fun.ClearTextBoxes(this.Controls);

            }else if (ADMINNUMBER.Text == "2" && RegisterAdminB(new BAdmin
            {
                Name = Nametxt.Text,
                Family = Familytxt.Text,
                Phone = Int64.Parse(Phonetxt.Text),
                Email = Emailtxt.Text,
                Address = Addresstxt.Text,
                IsActive = (Statustxt.Text) == "فعال" ? true : false,
                Username = usernametxt.Text,
                Password = userpasstxt.Text,
                accessCode = accessCode.Text,
                DeleteStatus = false
            }))
            {
                MessageBox.Show("ثبت نام انجام شد");
                Fun.ClearTextBoxes(this.Controls);
            }
            else
            {
                MessageBox.Show("اطلاعات نادرست است");
            }
        }

        private void RegisterAdminForm_Load(object sender, EventArgs e)
        {
            OwnerCodetxt.Text = ADMINNAME.Text;
        }
    }
}
