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
using System.Runtime.InteropServices;
using System.IO;

namespace StoreMarket_V1
{
    public partial class RecoveryForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public RecoveryForm()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        private void RecoveryForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AAdmin adminA = new AAdmin();
                BAdmin adminB = new BAdmin();

                adminA.accessCode = accesscodetxt.Text;
                adminA.Username = usernametxt.Text;
                adminA.Phone = Fun.ChangeToEnglishNumber(phonetxt.Text);

                adminB.accessCode = accesscodetxt.Text;
                adminB.Username = usernametxt.Text;
                adminB.Phone = Fun.ChangeToEnglishNumber(phonetxt.Text);

                String Pass = blc.ResetAdminPassword(adminA, adminB);

                if (Pass != "0")
                {
                    OLDPASS.Text = Pass;
                }
                else
                {
                    OLDPASS.Text = "اطلاعات اشتباه است";
                }
            }
            catch
            {
                OLDPASS.Text = "اطلاعات درست وارد نشده است";
            }
        }

        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
