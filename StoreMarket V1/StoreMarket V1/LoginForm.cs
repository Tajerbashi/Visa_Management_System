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

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
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
            DBCLASS dbc = new DBCLASS();
            OWNER owner = new OWNER();
            MessageBox.Show(owner.Status.ToString() + " : " + owner.access.ToString());
            if(owner.access !=null || owner.Status)
            {
                //foreach (var item in dbc.Owner)
                //{
                    MessageBox.Show(owner.id.ToString());
                    MessageBox.Show(owner.access.ToString());
                    MessageBox.Show(owner.Status.ToString());
                //}
            }else
            {
                MessageBox.Show("حلقه اجرا نشد");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
