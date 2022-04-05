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
using System.Globalization;

namespace StoreMarket_V1
{
    public partial class MainForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        
        public MainForm()
        {
            InitializeComponent();
        }
        DBCLASS dbc = new DBCLASS();
        ALogInformation ALog = new ALogInformation();
        BLogInformation BLog = new BLogInformation();

        public String CLOCK()
        {
            PersianCalendar pc = new PersianCalendar();
            var currentDate = DateTime.Now;
            string persianCurrentDate = pc.GetYear(currentDate) + "/" +
                                        pc.GetMonth(currentDate) + "/" +
                                        pc.GetDayOfMonth(currentDate) + " ( " +
                                        pc.GetHour(DateTime.Now) + " : " +
                                        pc.GetMinute(DateTime.Now) + " )";
            return persianCurrentDate;
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {    //  MouseDown

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("میخواهید برنامه بسته شود؟", "درخواست" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    ALog.Leave = CLOCK();
                    dbc.aLogInformation.Add(ALog);
                }
                else
                {
                    BLog.Leave = CLOCK();
                    dbc.bLogInformation.Add(BLog);
                }
                dbc.SaveChanges();
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AccessCodeForm ACF = new AccessCodeForm();
            ACF.ADMINNUMBER.Text = ADMINNUMBER.Text;
            ACF.ADMINNAME.Text = ADMINNAME.Text;
            ACF.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ADMINNUMBER.Text == "1")
            {
                ALog.AdminName = ADMINNAME.Text;
                ALog.Enter = CLOCK();
            }
            else
            {
                BLog.AdminName = ADMINNAME.Text;
                BLog.Enter = CLOCK();
            }
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            
            dbc.SaveChanges();

        }

        private void button8_Click(object sender, EventArgs e)
        {
        }
    }
}
