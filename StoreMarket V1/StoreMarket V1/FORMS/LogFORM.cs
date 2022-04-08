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
        DBCLASS dbc = new DBCLASS();
        private void LogFORM_Load(object sender, EventArgs e)
        {
            DBCLASS dbc = new DBCLASS();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = from i in dbc.aLogInformation where i.id > 0 select i;
                foreach(var item in DB)
                {
                    dataGridView1.Rows.Add(item.id, item.AdminName, item.Enter, item.Leave);
                }

            }
            else
            {
                var DB = from i in dbc.bLogInformation where i.id > 0 select i;
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
            if (searchtxt.Text != null)
            {
                if(ADMINNUMBER.Text == "1")
                {
                    var time = from i in dbc.aLogInformation where (searchtxt.Text).Contains(i.Enter) select i;
                    dataGridView1.DataSource = time.ToList();
                }
                else
                {
                    var time = from i in dbc.bLogInformation where (searchtxt.Text).Contains(i.Enter) select i;
                    dataGridView1.DataSource = time.ToList();
                }
            }else if(Startdate.Text != null  && Enddate.Text != null)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    var time = from i in dbc.aLogInformation where (Startdate.Text).Contains(i.Enter) select i;
                    dataGridView1.DataSource = time.ToList();
                }
                else
                {
                    var time = from i in dbc.bLogInformation where (Startdate.Text).Contains(i.Enter) select i;
                    dataGridView1.DataSource = time.ToList();
                }
            }
        }
    }
}
