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
    public partial class StoreManagmentForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public StoreManagmentForm()
        {
            InitializeComponent();
        }

        private void StoreManagmentForm_Load(object sender, EventArgs e)
        {

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
            RegisterAdminForm RGF = new RegisterAdminForm();
            RGF.ADMINNAME.Text = ADMINNAME.Text;
            RGF.ADMINNUMBER.Text = ADMINNUMBER.Text;
            RGF.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlAccount CA = new ControlAccount();
            CA.ADMINNAME.Text = ADMINNAME.Text;
            CA.ADMINNUMBER.Text = ADMINNUMBER.Text;
            CA.ShowDialog();
        }
    }
}
