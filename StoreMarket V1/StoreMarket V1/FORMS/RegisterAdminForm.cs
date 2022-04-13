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
        DBCLASS dbc = new DBCLASS();
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
            try
            {
                if ((ADMINNUMBER.Text == "1" && !Fun.SelectStatusInfoA(new AAdmin { Name = Nametxt.Text, Family = Familytxt.Text, Phone = Int64.Parse(Phonetxt.Text) }))
                ||
               (ADMINNUMBER.Text == "2" && !Fun.SelectStatusInfoB(new BAdmin { Name = Nametxt.Text, Family = Familytxt.Text, Phone = Int64.Parse(Phonetxt.Text) })))
                {
                    MessageBox.Show("ادمین جدید است");
                }
                else
                {
                    MessageBox.Show("اطلاعات تکراری است");
                }
            }
            catch
            {
                MessageBox.Show("اطلاعات اشتباه وارد شده است");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   // ذخیره ادمین
            Functions Fun = new Functions();
            Phonetxt.Text = ConvertArabicNumberToEnglish.toEnglishNumber(Phonetxt.Text);
            try
            {
                OWNER owner = dbc.Owner.Where(c => c.access == ADMINNAME.Text).FirstOrDefault();
                if (owner.Status && ADMINNUMBER.Text == "1" && Fun.RegisterAdminA(new AAdmin
                {
                    OwnerName = OwnerCodetxt.Text,
                    Name = Nametxt.Text,
                    Family = Familytxt.Text,
                    Phone = Int64.Parse(Phonetxt.Text),
                    Email = Emailtxt.Text,
                    Address = Addresstxt.Text,
                    IsActive = (Statustxt.Text) == "فعال" ? true : false,
                    Username = usernametxt.Text,
                    Password = userpasstxt.Text,
                    accessCode = accessCode.Text,
                    DeleteStatus = false
                }))
                {
                    MessageBox.Show("ثبت نام انجام شد");
                    Fun.ClearTextBoxes(this.Controls);

                }
                else if (owner.Status && ADMINNUMBER.Text == "2" && Fun.RegisterAdminB(new BAdmin
                {
                    OwnerName = OwnerCodetxt.Text,
                    Name = Nametxt.Text,
                    Family = Familytxt.Text,
                    Phone = Int64.Parse(Phonetxt.Text),
                    Email = Emailtxt.Text,
                    Address = Addresstxt.Text,
                    IsActive = (Statustxt.Text) == "فعال" ? true : false,
                    Username = usernametxt.Text,
                    Password = userpasstxt.Text,
                    accessCode = accessCode.Text,
                    DeleteStatus = false
                }))
                {
                    MessageBox.Show("ثبت نام انجام شد");
                    Fun.ClearTextBoxes(this.Controls);
                }
                if (owner != null)
                {
                    owner.Status = false;
                    dbc.SaveChanges();
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
