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
    public partial class ManageForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public ManageForm()
        {
            InitializeComponent();
        }

        private void StoreManagmentForm_Load(object sender, EventArgs e)
        {
            if (ADMINNAME.Text == "ADMIN1" || ADMINNAME.Text == "ADMIN2")
            {
                button1.Enabled = true;
            }
        }

        private void StoreManagmentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstAdminPanel panel = new FirstAdminPanel();
            if (mainpanel.Controls.Count > 0)
            {
                mainpanel.Controls[0].Dispose();
            }
            mainpanel.Controls.Add(panel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountsPanel panel = new AccountsPanel();
            if (mainpanel.Controls.Count>0)
            {
                mainpanel.Controls[0].Dispose();
            }
            mainpanel.Controls.Add(panel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogReports panel = new LogReports();
            if (mainpanel.Controls.Count > 0)
            {
                mainpanel.Controls[0].Dispose();
            }
            mainpanel.Controls.Add(panel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminBankAccount ABA = new AdminBankAccount();
            ABA.ADMINNAME.Text = ADMINNAME.Text;
            ABA.ADMINNUMBER.Text = ADMINNUMBER.Text;
            ABA.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
