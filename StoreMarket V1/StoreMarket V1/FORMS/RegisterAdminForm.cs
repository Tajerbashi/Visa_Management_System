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
using BEE;
using BLL;

namespace StoreMarket_V1
{
    public partial class RegisterAdminForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public RegisterAdminForm()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();

        private void RegisterAdminForm_MouseDown(object sender, MouseEventArgs e)
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
        private void checkbtn_Click(object sender, EventArgs e)
        {   //  بررسی
            if (ADMINNUMBER.Text == "1")
            {
                AAdmin admin = new AAdmin();
                admin.Name = Nametxt.Text;
                admin.Family = Familytxt.Text;
                admin.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(Phonetxt.Text));
                admin.Email = Emailtxt.Text;
                admin.Address = Addresstxt.Text;
                if (!blc.ExistAdminA(admin))
                {
                    MessageBox.Show("ادمین جدید است");
                }
            }
            else
            {
                BAdmin admin = new BAdmin();
                admin.Name = Nametxt.Text;
                admin.Family = Familytxt.Text;
                admin.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(Phonetxt.Text));
                admin.Email = Emailtxt.Text;
                admin.Address = Addresstxt.Text;
                if (!blc.ExistAdminB(admin))
                {
                    MessageBox.Show("ادمین جدید است");
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {   // ذخیره ادمین
            Functions Fun = new Functions();
            Phonetxt.Text = ConvertArabicNumberToEnglish.toEnglishNumber(Phonetxt.Text);
            try
            {
                OWNER owner = blc.SelectOwner(ADMINNAME.Text);
                if (owner.Status && ADMINNUMBER.Text == "1")
                {
                    AAdmin admin = new AAdmin();

                    admin.OwnerName = OwnerCodetxt.Text;
                    admin.Name = Nametxt.Text;
                    admin.Family = Familytxt.Text;
                    admin.Phone = Int64.Parse(Phonetxt.Text);
                    admin.Email = Emailtxt.Text;
                    admin.Address = Addresstxt.Text;
                    admin.IsActive = (Statustxt.Text) == "فعال" ? true : false;
                    admin.Username = usernametxt.Text;
                    admin.Password = userpasstxt.Text;
                    admin.accessCode = accessCode.Text;
                    admin.DeleteStatus = false;
                    
                    blc.RegisterAdminA(admin);
                    blc.ChangeOwnerStatus(owner);

                    MessageBox.Show("ثبت نام انجام شد");
                    Fun.ClearTextBoxes(this.Controls);
                }
                else if (owner.Status && ADMINNUMBER.Text == "2")
                {
                    BAdmin admin = new BAdmin();

                    admin.OwnerName = OwnerCodetxt.Text;
                    admin.Name = Nametxt.Text;
                    admin.Family = Familytxt.Text;
                    admin.Phone = Int64.Parse(Phonetxt.Text);
                    admin.Email = Emailtxt.Text;
                    admin.Address = Addresstxt.Text;
                    admin.IsActive = (Statustxt.Text) == "فعال" ? true : false;
                    admin.Username = usernametxt.Text;
                    admin.Password = userpasstxt.Text;
                    admin.accessCode = accessCode.Text;
                    admin.DeleteStatus = false;

                    blc.RegisterAdminB(admin);
                    blc.ChangeOwnerStatus(owner);

                    MessageBox.Show("ثبت نام انجام شد");
                    Fun.ClearTextBoxes(this.Controls);
                }
            }
            catch
            {
                MessageBox.Show("اطلاعات نادرست است");
            }
            OwnerCodetxt.Text = ADMINNAME.Text;
        }
        private void RegisterAdminForm_Load(object sender, EventArgs e)
        {
            OwnerCodetxt.Text = ADMINNAME.Text;
        }
        private void Phonetxt_Leave(object sender, EventArgs e)
        {
            usernametxt.Text = Phonetxt.Text;
        }

    }
}
