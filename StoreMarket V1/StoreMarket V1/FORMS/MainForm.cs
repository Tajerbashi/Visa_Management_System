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
using BEE;
using BLL;
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
        Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString("yyyy/MM/dd");//tarikh feli ro mide
            Time.Text = DateTime.Now.ToString("HH:mm:ss dddd");
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 800;
            timer.Start();
        }
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();
        ALogInformation ALog = new ALogInformation();
        BLogInformation BLog = new BLogInformation();
        private void timer_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm:ss dddd");//zaman ro mide
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
            DialogResult = MessageBox.Show("میخواهید برنامه بسته شود؟", "درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    ALog.Leave = Fun.CLOCK();
                    blc.ALoginfor(ALog);
                }
                else
                {
                    BLog.Leave = Fun.CLOCK();
                    blc.BLoginfor(BLog);
                }
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
                ALog.Enter = Fun.CLOCK();
            }
            else
            {
                BLog.AdminName = ADMINNAME.Text;
                BLog.Enter = Fun.CLOCK();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ProductControlForm PCF = new ProductControlForm();
            PCF.ADMINNAME.Text = ADMINNAME.Text;
            PCF.ADMINNUMBER.Text = ADMINNUMBER.Text;
            PCF.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ControlTranSectionForm CTSF = new ControlTranSectionForm();
            CTSF.ADMINNAME.Text = ADMINNAME.Text;
            CTSF.ADMINNUMBER.Text = ADMINNUMBER.Text;
            CTSF.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
