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

        private void LoginForm_Load(object sender, EventArgs e)
        {           //  Loading Form
            #region Code
            //SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=StoreMarketDB;Integrated Security=True");
            //SqlCommand sqlcom = new SqlCommand();
            //sqlcom.Connection = sqlcon;
            //sqlcom.CommandText = "Create database StoreMarketDB";
            //if(sqlcon.State == ConnectionState.Closed)
            //{
            //    sqlcon.Open();
            //}
            //sqlcom.ExecuteNonQuery();
            #endregion
            Fun.FirstLoginAdminA();
            Fun.FirstLoginAdminB();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            if (Fun.CheckAdminA(accessTXT.Text,UserTXT.Text,passTXT.Text))
            {
                MF.ADMINNAME.Text = UserTXT.Text;
                MF.ADMINNUMBER.Text = "1";
                MF.ShowDialog();
            }else if(Fun.CheckAdminB(accessTXT.Text, UserTXT.Text, passTXT.Text))
            {
                MF.ADMINNUMBER.Text = "2";
                MF.ADMINNAME.Text = UserTXT.Text;
                MF.ShowDialog();
            }
            else
            {
                MessageBox.Show("کد دسترسی باطل شده است");
            }
        }
    }
}
