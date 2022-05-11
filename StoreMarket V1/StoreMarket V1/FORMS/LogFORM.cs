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
        String S1;
        String S2;
        String S3;
        public void ShowAllDate(String Admin)
        {
            if (Admin == "1")
            {
                var DB = blc.aLogInformation();
                foreach (var item in DB)
                {
                    DT.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }
            }
            else if (Admin == "2")
            {
                var DB = blc.bLogInformation();
                foreach (var item in DB)
                {
                    DT.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }
            }
        }
        public void ShowAllDateSearch(String Admin,String Start)
        {
            if (Admin == "1")
            {
                var DB = blc.LogSearchEnterA(Start);
                foreach (var item in DB)
                {
                    DT.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }
            }
            else if (Admin == "2")
            {
                var DB = blc.LogSearchEnterB(Start);
                foreach (var item in DB)
                {
                    DT.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }
            }
        }

        public void ShowAllDateFilter(String Admin, String Start,String End)
        {
            if (Admin == "1")
            {
                var DB = blc.SearchResultLogInformationDateA(Start,End);
                foreach (var item in DB)
                {
                    DT.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }
            }
            else if (Admin == "2")
            {
                var DB = blc.SearchResultLogInformationDateB(Start, End);
                foreach (var item in DB)
                {
                    DT.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }
            }
        }

        private void LogFORM_Load(object sender, EventArgs e)
        {
            ShowAllDate(ADMINNUMBER.Text);
            S1 = searchtxt.Text;
            S2 = Startdate.Text;
            S3 = Enddate.Text;

        }

        private void LogFORM_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String search= ConvertArabicNumberToEnglish.toEnglishNumber(searchtxt.Text);
            
            DT.Rows.Clear();
            if (searchtxt.Text == S1)
            {
                MessageBox.Show("تاریخ مورد نظر را درج کنید");
                searchtxt.Focus();
            }
            else
            {
                ShowAllDateSearch(ADMINNUMBER.Text, search);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Startdate1 = ConvertArabicNumberToEnglish.toEnglishNumber(Startdate.Text);
            String Enddate1 = ConvertArabicNumberToEnglish.toEnglishNumber(Enddate.Text);
            DT.Rows.Clear();
            if (Startdate.Text == S2)
            {
                MessageBox.Show("تاریخ مورد نظر را درج کنید");
                Startdate.Focus();
            }
            else if (Enddate.Text == S3)
            {
                MessageBox.Show("تاریخ مورد نظر را درج کنید");
                Enddate.Focus();
            }
            else
            {
                ShowAllDateFilter(ADMINNUMBER.Text, Startdate1, Enddate1);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowAllDate(ADMINNUMBER.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
    }
}
