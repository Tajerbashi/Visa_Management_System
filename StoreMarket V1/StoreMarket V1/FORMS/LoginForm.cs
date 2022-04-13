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
using System.Data.SqlClient;
using BEE;
using BLL;

namespace StoreMarket_V1
{
    public partial class LoginForm : Form
    {

        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }
        Functions Fun = new Functions();
        DBCLASS dbc = new DBCLASS();
        BLLCode bllc = new BLLCode();

        #region CODE
        //public bool SelectStatusInfoA(AAdmin aAdmin)
        //{
        //    foreach (var item in dbc.aAdmins)
        //    {
        //        if (item.Name == aAdmin.Name && item.Family == aAdmin.Family && item.Phone == aAdmin.Phone)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public bool SelectStatusInfoB(BAdmin bAdmin)
        //{
        //    DBCLASS dbc = new DBCLASS();
        //    foreach (var item in dbc.bAdmins)
        //    {
        //        if (item.Name == bAdmin.Name && item.Family == bAdmin.Family && item.Phone == bAdmin.Phone)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public bool RegisterAdminA(AAdmin aAdmin)
        //{
        //    if (!SelectStatusInfoA(aAdmin))
        //    {
        //        dbc.aAdmins.Add(new AAdmin
        //        {
        //            OwnerName = aAdmin.OwnerName,
        //            Name = aAdmin.Name,
        //            Family = aAdmin.Family,
        //            Phone = aAdmin.Phone,
        //            Email = aAdmin.Email,
        //            Address = aAdmin.Address,
        //            IsActive = aAdmin.IsActive,
        //            accessCode = aAdmin.accessCode,
        //            Username = aAdmin.Username,
        //            Password = aAdmin.Password,
        //            DeleteStatus = aAdmin.DeleteStatus
        //        });
        //        dbc.SaveChanges();
        //        return true;
        //    }

        //    return false;
        //}
        //public bool RegisterAdminB(BAdmin bAdmin)
        //{
        //    if (!SelectStatusInfoB(bAdmin))
        //    {
        //        dbc.bAdmins.Add(new BAdmin
        //        {
        //            OwnerName = bAdmin.OwnerName,
        //            Name = bAdmin.Name,
        //            Family = bAdmin.Family,
        //            Phone = bAdmin.Phone,
        //            Email = bAdmin.Email,
        //            Address = bAdmin.Address,
        //            IsActive = bAdmin.IsActive,
        //            accessCode = bAdmin.accessCode,
        //            Username = bAdmin.Username,
        //            Password = bAdmin.Password,
        //            DeleteStatus = bAdmin.DeleteStatus
        //        });
        //        dbc.SaveChanges();
        //        return true;
        //    }

        //    return false;
        //}
        //public int CheckAdminInfo(String ADMINNAME, String ADMINNUMBER)
        //{
        //    String Owner = ADMINNAME;
        //    DBCLASS dbc = new DBCLASS();
        //    foreach (var item in dbc.Owner)
        //    {
        //        if (item.access == Owner && item.Status && ADMINNUMBER == "1")
        //        {
        //            return 1;
        //        }
        //        else if (item.access == Owner && item.Status && ADMINNUMBER == "2")
        //        {
        //            return 2;
        //        }
        //    }
        //    return 0;
        //}
        //public bool register(OWNER owner)
        //{
        //    foreach (var item in dbc.Owner)
        //    {
        //        if (owner.access == item.access)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public void FirstLoginAdminB()
        //{
        //    DBCLASS dbc = new DBCLASS();
        //    OWNER owner = new OWNER();
        //    if (!register(new OWNER
        //    {
        //        access = "ADMIN2",
        //        password = "ADMIN2"

        //    }))
        //    {
        //        owner.access = "ADMIN2";
        //        owner.password = "ADMIN2";
        //        owner.Status = true;
        //        dbc.Owner.Add(owner);
        //        dbc.SaveChanges();
        //        //MessageBox.Show("ادمین دوم موجود نبود و جدید ثبت شد");
        //    }
        //}
        //public bool CheckAdminA(String Access, String User, String Pass)
        //{
        //    DBCLASS dbc = new DBCLASS();

        //    foreach (var item in dbc.Owner)
        //    {
        //        if (Access == "ADMIN1" && item.access == User && item.password == Pass && item.Status == true)
        //        {
        //            return true;
        //        }
        //    }

        //    foreach (var item in dbc.aAdmins)
        //    {
        //        if (item.accessCode == Access && item.Username == User && item.Password == Pass)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public bool CheckAdminB(String Access, String User, String Pass)
        //{
        //    DBCLASS dbc = new DBCLASS();

        //    foreach (var item in dbc.Owner)
        //    {
        //        if (Access == "ADMIN2" && item.access == User && item.password == Pass && item.Status == true)
        //        {
        //            return true;
        //        }
        //    }

        //    foreach (var item in dbc.bAdmins)
        //    {
        //        if (item.accessCode == Access && item.Username == User && item.Password == Pass)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public void FirstLoginAdminA()
        //{
        //    DBCLASS dbc = new DBCLASS();
        //    OWNER owner = new OWNER();
        //    if (!register(new OWNER
        //    {
        //        access = "ADMIN1",
        //        password = "ADMIN1"
        //    }))
        //    {
        //        owner.access = "ADMIN1";
        //        owner.password = "ADMIN1";
        //        owner.Status = true;
        //        dbc.Owner.Add(owner);
        //        dbc.SaveChanges();
        //        //MessageBox.Show("ادمین اول موجود نبود و جدید ثبت شد");
        //    }
        //}
        #endregion

        #region ClickButton
        private void button2_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            OWNER owner = new OWNER();
            owner.access = accessTXT.Text;
            owner.password = passTXT.Text;
            #region OWNERCODE
            if (bllc.CheckAccessOwner(owner,UserTXT.Text) && owner.access=="ADMIN1" )
            {
                MF.ADMINNAME.Text = UserTXT.Text;
                MF.ADMINNUMBER.Text = "1";
                this.Hide();
                MF.Show();
            }else if (bllc.CheckAccessOwner(owner,UserTXT.Text) && owner.access == "ADMIN2" )
            {
                MF.ADMINNAME.Text = UserTXT.Text;
                MF.ADMINNUMBER.Text = "2";
                this.Hide();
                MF.Show();
            }
            #endregion
            // ADMIN CODE
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new RecoveryForm()).ShowDialog();
        }
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {   //  MouseDown
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {   // Close
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {   //  Minimize
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Function()
        public void ADMIN1()
        {
            OWNER owner1 = new OWNER();
            owner1.access = "ADMIN1";
            owner1.password = "ADMIN1";
            owner1.Status = true;
            bllc.CheckOwnerEXISTA(owner1);

        }
        public void ADMIN2()
        {
            OWNER owner2 = new OWNER();
            owner2.access = "ADMIN1";
            owner2.password = "ADMIN1";
            owner2.Status = true;
            bllc.CheckOwnerEXISTA(owner2);
        }
        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {           //  Loading Form
            ADMIN1();
            ADMIN2();
        }

      
    }
}
