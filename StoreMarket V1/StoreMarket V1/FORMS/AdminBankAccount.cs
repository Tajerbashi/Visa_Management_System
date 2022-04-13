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
        //DBCLASS dbc = new DBCLASS();
        int ID = -1;
        bool SW = true;
        //public void Printdata(String ID)
        //{
        //    dataGridView1.Rows.Clear();
        //    if(ID == "1")
        //    {
        //        var DB = from i in dbc.aAdminBankAccounts where !i.DeleteStatus select i;
        //        foreach (var item in DB)
        //        {
        //            dataGridView1.Rows.Add(item.id, item.phonenumber, item.NameBank, item.AccountNumber , item.OwnerName);
        //        }
        //    }
        //    else
        //    {
        //        var DB = from i in dbc.bAdminBankAccounts where !i.DeleteStatus select i;
        //        foreach (var item in DB)
        //        {
        //            dataGridView1.Rows.Add(item.id, item.phonenumber, item.NameBank, item.AccountNumber, item.OwnerName);
        //        }
        //    }
        //}
        private void AdminBankAccount_Load(object sender, EventArgs e)
        {
            //Printdata(ADMINNUMBER.Text);
        }

        private void AdminBankAccount_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //public bool select(String ID,String number)
        //{
        //    if(ID == "1")
        //    {
        //        foreach (var item in dbc.aAdminBankAccounts)
        //        {
        //            if (item.AccountNumber == number)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        foreach (var item in dbc.bAdminBankAccounts)
        //        {
        //            if (item.AccountNumber == number)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}
        //public bool AregisgterBankAccount(AAdminBankAccount adminBankAccount)
        //{
        //    if (!select(ADMINNUMBER.Text, adminBankAccount.AccountNumber))
        //    {
        //        dbc.aAdminBankAccounts.Add(new AAdminBankAccount
        //        {
        //            AccountNumber = adminBankAccount.AccountNumber,
        //            NameBank = adminBankAccount.NameBank,
        //            OwnerName = adminBankAccount.OwnerName,
        //            phonenumber = adminBankAccount.phonenumber
        //        });
        //        dbc.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}
        //public bool BregisgterBankAccount(BAdminBankAccount adminBankAccount)
        //{
        //    if (!select(ADMINNUMBER.Text, adminBankAccount.AccountNumber))
        //    {
        //        dbc.bAdminBankAccounts.Add(new BAdminBankAccount
        //        {
        //            AccountNumber = adminBankAccount.AccountNumber,
        //            NameBank = adminBankAccount.NameBank,
        //            OwnerName = adminBankAccount.OwnerName,
        //            phonenumber = adminBankAccount.phonenumber
        //        });
        //        dbc.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (((bankname.Text.Trim()).Length == 0) ||
                ((banknumberaccount.Text.Trim()).Length == 0) ||
                ((owneradminname.Text.Trim()).Length == 0) ||
                ((adminphonebank.Text.Trim()).Length == 0))
            {
                MessageBox.Show("تمامی خانه ها را پر کنید");
            }
            else
            {
                if (SW)
                {
                    if (ADMINNUMBER.Text == "1")
                    {
                        if (AregisgterBankAccount(new AAdminBankAccount
                        {
                            NameBank = bankname.Text,
                            AccountNumber = banknumberaccount.Text,
                            OwnerName = owneradminname.Text,
                            phonenumber = adminphonebank.Text
                        }))
                        {
                            MessageBox.Show("شماره حساب ذخیره شد");
                        }
                        else
                        {
                            MessageBox.Show("شماره حساب موجود است");
                        }
                    }
                    else if (ADMINNUMBER.Text == "2")
                    {
                        if (BregisgterBankAccount(new BAdminBankAccount
                        {
                            NameBank = bankname.Text,
                            AccountNumber = banknumberaccount.Text,
                            OwnerName = owneradminname.Text,
                            phonenumber = adminphonebank.Text
                        }))
                        {
                            MessageBox.Show("شماره حساب ذخیره شد");
                        }
                        else
                        {
                            MessageBox.Show("شماره حساب موجود است");
                        }
                    }

                }
                else
                {
                    if (ADMINNUMBER.Text == "1")
                    {
                        AAdminBankAccount bankAccount = dbc.aAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                        bankAccount.NameBank = bankname.Text;
                        bankAccount.AccountNumber = banknumberaccount.Text;
                        bankAccount.OwnerName = owneradminname.Text;
                        bankAccount.phonenumber = adminphonebank.Text;
                    }
                    else
                    {
                        BAdminBankAccount bankAccount = dbc.bAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                        bankAccount.NameBank = bankname.Text;
                        bankAccount.AccountNumber = banknumberaccount.Text;
                        bankAccount.OwnerName = owneradminname.Text;
                        bankAccount.phonenumber = adminphonebank.Text;
                    }
                    dbc.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت بروز رسانی شد");
                    savebtn.Text = "ذخیره";
                    SW = true;
                }
                Fun.ClearTextBoxes(this.Controls);
                Printdata(ADMINNUMBER.Text);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                dataGridView1.CurrentRow.Selected = true;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("آیا میخواهید اطلاعات حذف شود", "تایید درخواست", MessageBoxButtons.YesNo))
            {
                if (ADMINNUMBER.Text == "1")
                {
                    AAdminBankAccount bankAccount = dbc.aAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                    bankAccount.DeleteStatus = true;
                }
                else
                {
                    BAdminBankAccount bankAccount = dbc.bAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                    bankAccount.DeleteStatus = true;
                }
                dbc.SaveChanges();
            }
            Printdata(ADMINNUMBER.Text);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("آیا میخواهید اطلاعات ویرایش شود", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                SW = false;
                savebtn.Text = "بروزرسانی";
                if (ADMINNUMBER.Text == "1")
                {
                    AAdminBankAccount bankAccount = dbc.aAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                    bankname.Text = bankAccount.NameBank;
                    owneradminname.Text = bankAccount.OwnerName;
                    adminphonebank.Text = bankAccount.phonenumber;
                    banknumberaccount.Text = bankAccount.AccountNumber;
                }
                else
                {
                    BAdminBankAccount bankAccount = dbc.bAdminBankAccounts.Where(c => c.id == ID).FirstOrDefault();
                    bankname.Text = bankAccount.NameBank;
                    owneradminname.Text = bankAccount.OwnerName;
                    adminphonebank.Text = bankAccount.phonenumber;
                    banknumberaccount.Text = bankAccount.AccountNumber;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void adminphonebank_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
