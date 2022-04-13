using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using BEE;
using BLL;
namespace StoreMarket_V1
{
    public partial class LogFORM : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public LogFORM()
        {
            InitializeComponent();
        }
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();

        private void LogFORM_Load(object sender, EventArgs e)
        {
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.aLogInformation();
                foreach (var item in DB)
                {
                    dataGridView1.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }
            }
            else
            {
                var DB = blc.bLogInformation();
                foreach (var item in DB)
                {
                    dataGridView1.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }
            }
        }

        private void LogFORM_MouseDown(object sender, MouseEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchtxt.Text = ConvertArabicNumberToEnglish.toEnglishNumber(searchtxt.Text);
            Startdate.Text = ConvertArabicNumberToEnglish.toEnglishNumber(Startdate.Text);
            Enddate.Text = ConvertArabicNumberToEnglish.toEnglishNumber(Enddate.Text);
            if (searchtxt.Text != null)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    var time = blc.LogSearchEnterA(searchtxt.Text);
                    dataGridView1.DataSource = time.ToList();
                }
                else
                {
                    var time = blc.LogSearchEnterB(searchtxt.Text);
                    dataGridView1.DataSource = time.ToList();
                }
            }
        }

    }
}
