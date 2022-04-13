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
                    blc.DeleteBankAccountA(ID);
                }
                else
                {
                    blc.DeleteBankAccountB(ID);
                }
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
                    AAdminBankAccount bankAccount = blc.adminbankacountA(ID);
                    bankname.Text = bankAccount.NameBank;
                    owneradminname.Text = bankAccount.OwnerName;
                    adminphonebank.Text = bankAccount.phonenumber;
                    banknumberaccount.Text = bankAccount.AccountNumber;
                }
                else
                {
                    BAdminBankAccount bankAccount = blc.adminbankacountB(ID);
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

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (SW)
            {   //  Save New Admin Bank Account
                if (ADMINNUMBER.Text == "1")
                {
                    AAdminBankAccount adminbank = new AAdminBankAccount();
                    adminbank.NameBank = bankname.Text;
                    adminbank.OwnerName = owneradminname.Text;
                    adminbank.AccountNumber = banknumberaccount.Text;
                    adminbank.phonenumber = adminphonebank.Text;
                    if (blc.CreateAdminBankA(adminbank))
                    {
                        MessageBox.Show("اطلاعات تکراری است");
                    }
                }
                else
                {
                    BAdminBankAccount adminbank = new BAdminBankAccount();
                    adminbank.NameBank = bankname.Text;
                    adminbank.OwnerName = owneradminname.Text;
                    adminbank.AccountNumber = banknumberaccount.Text;
                    adminbank.phonenumber = adminphonebank.Text;
                    if (blc.CreateAdminBankB(adminbank))
                    {
                        MessageBox.Show("اطلاعات تکراری است");
                    }
                }
            }
            else
            {   //  EDIT Admin Bank Account
                SW = true;
                if(ADMINNUMBER.Text == "1")
                {
                    AAdminBankAccount adminbank = blc.SelectAdminBankAccountA(ID);
                    adminbank.NameBank = bankname.Text;
                    adminbank.OwnerName = owneradminname.Text;
                    adminbank.phonenumber = adminphonebank.Text;
                    adminbank.AccountNumber = banknumberaccount.Text;
                    blc.ExistAdminBankA(adminbank);
                }
                else
                {
                    BAdminBankAccount adminbank = blc.SelectAdminBankAccountB(ID);
                    adminbank.NameBank = bankname.Text;
                    adminbank.OwnerName = owneradminname.Text;
                    adminbank.phonenumber = adminphonebank.Text;
                    adminbank.AccountNumber = banknumberaccount.Text;
                    blc.ExistAdminBankB(adminbank);
                }
                
            }
            Printdata(ADMINNUMBER.Text);
        }
    }
}
