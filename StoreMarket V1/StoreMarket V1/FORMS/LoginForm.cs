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
        BLLCode blc = new BLLCode();

        #region Function()
        public void ADMIN1()
        {
            OWNER owner1 = new OWNER();
            owner1.access = "ADMIN1";
            owner1.password = "ADMIN1";
            owner1.Status = true;
            blc.CreateNewOwner(owner1);
        }
        public void ADMIN2()
        {
            OWNER owner2 = new OWNER();
            owner2.access = "ADMIN2";
            owner2.password = "ADMIN2";
            owner2.Status = true;
            blc.CreateNewOwner(owner2);
        }
        #endregion
        #region ClickButton
        private void button2_Click(object sender, EventArgs e)
        {
            // ADMIN CODE
            MainForm MF = new MainForm();
            OWNER owner = new OWNER();
            owner.access = accessTXT.Text;
            owner.password = passTXT.Text;

            String AccessCode = accessTXT.Text;
            String UserName = UserTXT.Text;
            String Password = passTXT.Text;

            #region OWNERCODE
            if (blc.LoginCodeAdmin(AccessCode, UserName, Password)==1||blc.CheckAccessOwner(owner,owner.access)==1 || blc.PublicKey(accessTXT.Text) == 1)
            {
                MF.ADMINNAME.Text = UserTXT.Text;
                MF.ADMINNUMBER.Text = "1";
                this.Hide();
                MF.Show();
            } 
            else if (blc.LoginCodeAdmin(AccessCode, UserName, Password) == 2 || blc.CheckAccessOwner(owner,owner.access)==2 || blc.PublicKey(accessTXT.Text) == 2)
            {
                MF.ADMINNAME.Text = UserTXT.Text;
                MF.ADMINNUMBER.Text = "2";
                this.Hide();
                MF.Show();
            }
            else
            {
                MessageBox.Show(" نام و رمز کاربری اشتباه است");
            }
            #endregion
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
            Application.Exit();
        }
        private void button4_Click(object sender, EventArgs e)
        {   //  Minimize
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void LoginForm_Load(object sender, EventArgs e)
        {           //  Loading Form
            ADMIN1();
            ADMIN2();
        }
    }
}
