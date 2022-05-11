using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BEE;
namespace StoreMarket_V1
{
    public partial class LogReports : UserControl
    {
        public LogReports()
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
        public void ShowAllDateSearch(String Admin, String Start)
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

        public void ShowAllDateFilter(String Admin, String Start, String End)
        {
            if (Admin == "1")
            {
                var DB = blc.SearchResultLogInformationDateA(Start, End);
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
        private void button1_Click(object sender, EventArgs e)
        {
            String search = ConvertArabicNumberToEnglish.toEnglishNumber(searchtxt.Text);

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

    }
}
