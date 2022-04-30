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
    public partial class Store : Form
    {
        #region Code
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        Timer timer = new Timer();

        public Store()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            date.Text = DateTime.Now.ToString("yyyy/MM/dd");//tarikh feli ro mide
            clock.Text = DateTime.Now.ToString("HH:mm:ss dddd");
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 800;
            timer.Start();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss dddd");//zaman ro mide
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPanel panel = new CustomerPanel();
            if (MainPanel.Controls.Count>0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMIN.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductPanel panel = new ProductPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMIN.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }
    }
}
