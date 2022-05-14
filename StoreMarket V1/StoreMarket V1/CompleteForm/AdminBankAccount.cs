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
    public partial class AdminBankAccount : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public AdminBankAccount()
        {
            InitializeComponent();
        }
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();
        int ID = -1;
        bool SW = true;
        public void Printdata(String ID)
        {
            dataGridView1.Rows.Clear();
            if (ID == "1")
            {
                var DB = blc.ReadAdminbankA();
                foreach (var item in DB)
                {
                    dataGridView1.Rows.Add(item.id, item.phonenumber, item.NameBank, item.AccountNumber, item.OwnerName);
                }
            }
            else
            {
                var DB = blc.ReadAdminbankB();
                foreach (var item in DB)
                {
                    dataGridView1.Rows.Add(item.id, item.phonenumber, item.NameBank, item.AccountNumber, item.OwnerName);
                }
            }
        }
        private void AdminBankAccount_Load(object sender, EventArgs e)
        {
            Result.Text = "ثبت حساب بانکی";
            Printdata(ADMINNUMBER.Text);
        }

        private void AdminBankAccount_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxForm message = new MessageBoxForm();
            message.title.Text = "تایید درخواست";
            message.Subject.Text = "آیا میخواهید اطلاعات حذف شود؟؟؟";
            message.ShowDialog();
            if (message.Sw)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    blc.DeleteAdminBankAccountA(ID);
                }
                else
                {
                    blc.DeleteAdminBankAccountB(ID);
                }
            }
            Printdata(ADMINNUMBER.Text);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxForm message = new MessageBoxForm();
            message.title.Text = "تایید درخواست";
            message.Subject.Text = "آیا میخواهید اطلاعات ویرایش شود؟؟؟";
            message.ShowDialog();
            if (message.Sw)
            {
                SW = false;
                savebtn.Text = "بروزرسانی";
                if (ADMINNUMBER.Text == "1")
                {
                    AAdminBankAccount bankAccount = blc.adminbankacountA(ID);
                    BankName.Text = bankAccount.NameBank;
                    OwnerName.Text = bankAccount.OwnerName;
                    PhoneNumber.Text = Fun.ChangeToEnglishNumber((bankAccount.phonenumber).ToString());
                    AccountNumber.Text = (Fun.ChangeToEnglishNumber((bankAccount.AccountNumber).ToString())).ToString();
                }
                else
                {
                    BAdminBankAccount bankAccount = blc.adminbankacountB(ID);
                    BankName.Text = bankAccount.NameBank;
                    OwnerName.Text = bankAccount.OwnerName;
                    PhoneNumber.Text = Fun.ChangeToEnglishNumber((bankAccount.phonenumber).ToString());
                    AccountNumber.Text = (Fun.ChangeToEnglishNumber((bankAccount.AccountNumber).ToString())).ToString();
                }
            }

        }
        private void savebtn_Click(object sender, EventArgs e)
        {

            if (BankName.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text= "نام بانک را درج کنید";
                BankName.Focus();
            } 
            else 
            if (OwnerName.Text.Trim().Length == 0) 
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام مالک را درج کنید";
                OwnerName.Focus();
            }
            else if (PhoneNumber.Text.Trim().Length==0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تلفن را درج کنید";
                PhoneNumber.Focus();
            }
            else if (AccountNumber.Text.Trim().Length==0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "شماره حساب را درج کنید";
                AccountNumber.Focus();
            }
            else
            {
                MessageBoxForm message = new MessageBoxForm();
                message.title.Text = "تایید درخواست";
                message.Subject.Text = "از درج اطلاعات مطمیین هستید؟؟؟";
                message.ShowDialog();
                if (message.Sw)
                {
                    if (SW)
                    {   //  Save New Admin Bank Account
                        if (ADMINNUMBER.Text == "1")
                        {
                            AAdminBankAccount adminbank = new AAdminBankAccount();
                            adminbank.NameBank = BankName.Text;
                            adminbank.OwnerName = OwnerName.Text;
                            adminbank.phonenumber = Convert.ToInt64(Fun.ChangeToEnglishNumber(PhoneNumber.Text));
                            adminbank.AccountNumber = Fun.ChangeToEnglishNumber(AccountNumber.Text);
                            if (!blc.CreateAdminBankA(adminbank))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "ثبت نام انجام شد";
                            }
                            else
                            {
                                Result.ForeColor = Color.Red;
                                Result.Text = "عملیات ناموفق بود";
                            }
                        }
                        else
                        {
                            BAdminBankAccount adminbank = new BAdminBankAccount();
                            adminbank.NameBank = BankName.Text;
                            adminbank.OwnerName = OwnerName.Text;
                            adminbank.AccountNumber = Fun.ChangeToEnglishNumber(AccountNumber.Text);
                            adminbank.phonenumber = Convert.ToInt64(Fun.ChangeToEnglishNumber(PhoneNumber.Text));
                            if (!blc.CreateAdminBankB(adminbank))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "ثبت نام انجام شد";
                            }
                            else
                            {
                                Result.ForeColor = Color.Red;
                                Result.Text = "عملیات ناموفق بود";
                            }
                        }
                    }
                    else
                    {   //  EDIT Admin Bank Account
                        if (ADMINNUMBER.Text == "1")
                        {
                            AAdminBankAccount adminbank = blc.SelectAdminBankAccountA(ID);
                            adminbank.NameBank = BankName.Text;
                            adminbank.OwnerName = OwnerName.Text;
                            adminbank.AccountNumber = Fun.ChangeToEnglishNumber(AccountNumber.Text);
                            adminbank.phonenumber = Convert.ToInt64(Fun.ChangeToEnglishNumber(PhoneNumber.Text));
                            blc.ExistAdminBankA(adminbank);

                        }
                        else
                        {
                            BAdminBankAccount adminbank = blc.SelectAdminBankAccountB(ID);
                            adminbank.NameBank = BankName.Text;
                            adminbank.OwnerName = OwnerName.Text;
                            adminbank.AccountNumber = Fun.ChangeToEnglishNumber(AccountNumber.Text);
                            adminbank.phonenumber = Convert.ToInt64(Fun.ChangeToEnglishNumber(PhoneNumber.Text));
                            blc.ExistAdminBankB(adminbank);
                        }
                        SW = true;
                        savebtn.Text = "ذخیره";
                    }

                    Fun.ClearTextBoxes(this.Controls);
                    Printdata(ADMINNUMBER.Text);
                }
            }
        }

        private void ResultTimer_Tick(object sender, EventArgs e)
        {
            Result.ForeColor = Color.Black;
            Result.Text = "ثبت حساب بانکی";
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                dataGridView1.CurrentRow.Selected = (dataGridView1.CurrentRow.Selected) ? false : true;
                ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
