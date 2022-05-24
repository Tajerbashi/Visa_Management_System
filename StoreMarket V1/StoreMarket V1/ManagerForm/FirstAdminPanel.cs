using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEE;
using BLL;
namespace StoreMarket_V1
{
    public partial class FirstAdminPanel : UserControl
    {
        public FirstAdminPanel()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        private void button1_Click(object sender, EventArgs e)
        {   
        }
        private void RegisterAdminForm_Load(object sender, EventArgs e)
        {
            OwnerCodetxt.Text = ADMINNAME.Text;
        }
        private void Phonetxt_Leave(object sender, EventArgs e)
        {
            usernametxt.Text = Phonetxt.Text;
        }

        private void checkbtn_MouseEnter(object sender, EventArgs e)
        {
            checkbtn.ForeColor = Color.Black;
        }

        private void checkbtn_MouseLeave(object sender, EventArgs e)
        {
            checkbtn.ForeColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // ذخیره ادمین
            Functions Fun = new Functions();
            Phonetxt.Text = ConvertArabicNumberToEnglish.toEnglishNumber(Phonetxt.Text);
            try
            {
                OWNER owner = blc.SelectOwner(ADMINNAME.Text);
                if (usernametxt.Text.Trim().Length == 0) { ResultS1.Text = "نام کاربری را وارد کنید"; }
                else
                if (userpasstxt.Text.Trim().Length == 0) { ResultS1.Text = "نام کاربری را وارد کنید"; }
                else
                if (accessCode.Text.Trim().Length == 0) { ResultS1.Text = "نام کاربری را وارد کنید"; }
                else
                {
                    MessageBoxForm message = new MessageBoxForm();
                    message.title.Text = "اطلاعیه";

                    message.Subject.Location = new Point(125, 69);
                    message.Subject.Text = "به یاد داشته باشید\nکد دسترسی نام کاربری رمز کاربری\nبرای ورود به فروشگاه الزامیست!!!";
                    message.warning.Visible = true;
                    message.ShowDialog();

                    if (owner.Status && ADMINNUMBER.Text == "1")
                    {
                        if (message.Sw)
                        {
                            AAdmin admin = new AAdmin();

                            admin.OwnerName = OwnerCodetxt.Text.Trim();
                            admin.FullName = Nametxt.Text.Trim() + " " + Familytxt.Text.Trim();
                            admin.Phone = Fun.ChangeToEnglishNumber(Phonetxt.Text);
                            admin.Email = Emailtxt.Text;
                            admin.Address = Addresstxt.Text;
                            admin.IsActive = true;
                            admin.Username = usernametxt.Text.Trim();
                            admin.Password = userpasstxt.Text.Trim();
                            admin.accessCode = accessCode.Text.Trim();
                            admin.DeleteStatus = false;
                            admin.AccessControl = true;
                            blc.RegisterAdminA(admin);
                            blc.ChangeOwnerStatus(owner);
                            Fun.ClearTextBoxes(this.Controls);
                        }

                    }
                    else if (owner.Status && ADMINNUMBER.Text == "2")
                    {
                        if (message.Sw)
                        {
                            BAdmin admin = new BAdmin();

                            admin.OwnerName = OwnerCodetxt.Text.Trim();
                            admin.FullName = Nametxt.Text.Trim() + " " + Familytxt.Text.Trim();
                            admin.Phone = Fun.ChangeToEnglishNumber(Phonetxt.Text);
                            admin.Email = Emailtxt.Text;
                            admin.Address = Addresstxt.Text;
                            admin.IsActive = true;
                            admin.Username = usernametxt.Text.Trim();
                            admin.Password = userpasstxt.Text.Trim();
                            admin.accessCode = accessCode.Text.Trim();
                            admin.DeleteStatus = false;
                            admin.AccessControl = true;

                            blc.RegisterAdminB(admin);
                            blc.ChangeOwnerStatus(owner);

                            MessageBox.Show("ثبت نام انجام شد");
                            Fun.ClearTextBoxes(this.Controls);
                        }
                        Application.Exit();
                    }

                }


            }
            catch
            {
                ResultS.Text = "اطلاعات نادرست است";
            }
            OwnerCodetxt.Text = ADMINNAME.Text;
            if (ADMINNAME.Text=="ADMIN1" || ADMINNAME.Text=="ADMIN2")
            {
                Application.Exit();
            }
        }

        private void checkbtn_Click_1(object sender, EventArgs e)
        {

            //  بررسی
            if (Nametxt.Text.Trim().Length==0)
            {
                ResultS.Text = "نام را وارد کنید";
                Nametxt.Focus();
            }
            else if (Familytxt.Text.Trim().Length == 0)
            {
                ResultS.Text = "فامیلی را وارد کنید";
                Familytxt.Focus();
            }
            else if (Phonetxt.Text.Trim().Length == 0)
            {
                ResultS.Text = "تلفن را وارد کنید";
                Phonetxt.Focus();
            }
            else if (Emailtxt.Text.Trim().Length == 0)
            {
                ResultS.Text = "ایمیل را وارد کنید";
                Emailtxt.Focus();
            }
            else if (Addresstxt.Text.Trim().Length == 0)
            {
                ResultS.Text = "آدرس را وارد کنید";
                Addresstxt.Focus();
            }
            else
            {
                try
                {
                    if (ADMINNUMBER.Text == "1")
                    {
                        AAdmin admin = new AAdmin();
                        admin.FullName = Nametxt.Text + " " + Familytxt;
                        admin.Phone = Fun.ChangeToEnglishNumber(Phonetxt.Text);
                        admin.Email = Emailtxt.Text;
                        admin.Address = Addresstxt.Text;
                        if (!blc.ExistAdminA(admin))
                        {
                            ResultS.Text = "ادمین جدید است";
                            groupBox2.Enabled = true;
                        }
                    }
                    else
                    {
                        BAdmin admin = new BAdmin();
                        admin.FullName = Nametxt.Text + " " + Familytxt;
                        admin.Phone = Fun.ChangeToEnglishNumber(Phonetxt.Text);
                        admin.Email = Emailtxt.Text;
                        admin.Address = Addresstxt.Text;
                        if (!blc.ExistAdminB(admin))
                        {
                            ResultS.Text = "ادمین جدید است";
                            groupBox2.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("اطلاعاتی وارد نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void FirstAdminPanel_Load(object sender, EventArgs e)
        {
            OwnerCodetxt.Text = ADMINNAME.Text;
        }

        private void checkbtn_MouseEnter_1(object sender, EventArgs e)
        {
            checkbtn.ForeColor = Color.Black;
        }

        private void checkbtn_MouseLeave_1(object sender, EventArgs e)
        {
            checkbtn.ForeColor = Color.White;
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void Phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
