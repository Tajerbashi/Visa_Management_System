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

namespace StoreMarket_V1
{
    public partial class CheckBankPanel : UserControl
    {
        public CheckBankPanel()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        bool SW = true;
        int ID = 0;
        public void ShowAllChecksBank()
        {
            DGV.Rows.Clear();
            int NO = 1;
            String Status;
            if (ADMINNUMBER.Text=="1")
            {
                var DB = blc.GetCheckBanksA();
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id,NO,item.CustomerName,item.BankName,item.CheckNumber,item.Price,item.SariNumber,item.PassDate,Status, item.Details);
                    NO++;
                }
            }
            else
            {
                var DB = blc.GetCheckBanksB();
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
        }
        private void CheckBankPanel_Load(object sender, EventArgs e)
        {
            ShowAllChecksBank();
            DayDate.Text = Fun.CLOCK();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (SW)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    ACheckBank checkBank = new ACheckBank();
                    checkBank.CustomerName = Customer.Text;
                    checkBank.BankName = BankName.Text;
                    checkBank.CheckNumber = Fun.ChangeToEnglishNumber(CheckNumber.Text);
                    checkBank.SariNumber = Fun.ChangeToEnglishNumber(SariNumber.Text);
                    checkBank.DayDate = Fun.ChangeToEnglishNumber(DayDate.Text);
                    checkBank.PassDate = Fun.ChangeToEnglishNumber(PassDate.Text);
                    checkBank.Details = Details.Text;
                    checkBank.Price = Convert.ToDouble(Fun.ChangeToEnglishNumber(Price.Text));
                    blc.CreateCheckBankA(checkBank);
                }
                else
                {
                    BCheckBank checkBank = new BCheckBank();
                    checkBank.CustomerName = Customer.Text;
                    checkBank.BankName = BankName.Text;
                    checkBank.CheckNumber = Fun.ChangeToEnglishNumber(CheckNumber.Text);
                    checkBank.SariNumber = Fun.ChangeToEnglishNumber(SariNumber.Text);
                    checkBank.DayDate = Fun.ChangeToEnglishNumber(DayDate.Text);
                    checkBank.PassDate = Fun.ChangeToEnglishNumber(PassDate.Text);
                    checkBank.Details = Details.Text;
                    checkBank.Price = Convert.ToDouble(Fun.ChangeToEnglishNumber(Price.Text));
                    blc.CreateCheckBankB(checkBank);
                }

            }
            else
            {
                if (ADMINNUMBER.Text == "1")
                {
                    ACheckBank checkBank = blc.GetCheckBankA(ID);
                    checkBank.CustomerName = Customer.Text;
                    checkBank.BankName = BankName.Text;
                    checkBank.CheckNumber = Fun.ChangeToEnglishNumber(CheckNumber.Text);
                    checkBank.SariNumber = Fun.ChangeToEnglishNumber(SariNumber.Text);
                    checkBank.DayDate = Fun.ChangeToEnglishNumber(DayDate.Text);
                    checkBank.PassDate = Fun.ChangeToEnglishNumber(PassDate.Text);
                    checkBank.Details = Details.Text;
                    checkBank.Price = Convert.ToDouble(Fun.ChangeToEnglishNumber(Price.Text));
                    blc.UpdateCheckBankA(checkBank,ID);
                    SW = true;
                }
                else
                {
                    BCheckBank checkBank = blc.GetCheckBankB(ID);
                    checkBank.CustomerName = Customer.Text;
                    checkBank.BankName = BankName.Text;
                    checkBank.CheckNumber = Fun.ChangeToEnglishNumber(CheckNumber.Text);
                    checkBank.SariNumber = Fun.ChangeToEnglishNumber(SariNumber.Text);
                    checkBank.DayDate = Fun.ChangeToEnglishNumber(DayDate.Text);
                    checkBank.PassDate = Fun.ChangeToEnglishNumber(PassDate.Text);
                    checkBank.Details = Details.Text;
                    checkBank.Price = Convert.ToDouble(Fun.ChangeToEnglishNumber(Price.Text));
                    blc.UpdateCheckBankB(checkBank, ID);
                    SW = true;

                }
                buttonX1.Text = "ذخیره";
            }
            Fun.ClearTextBoxes(this.Controls);
            ShowAllChecksBank();
        }

        private void CheckNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button==MouseButtons.Right)
            {
                ID = int.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            }
            if (e.Button==MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void ویرایشچکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SW = false;
            buttonX1.Text = "بروزرسانی";
            Customer.Text = DGV.CurrentRow.Cells[2].Value.ToString();
            BankName.Text = DGV.CurrentRow.Cells[3].Value.ToString();
            CheckNumber.Text = DGV.CurrentRow.Cells[4].Value.ToString();
            Price.Text = DGV.CurrentRow.Cells[5].Value.ToString();
            SariNumber.Text = DGV.CurrentRow.Cells[6].Value.ToString();
            PassDate.Text = DGV.CurrentRow.Cells[7].Value.ToString();
            Details.Text = DGV.CurrentRow.Cells[9].Value.ToString();
        }

        private void حذفچکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ADMINNUMBER.Text=="1")
            {
                blc.DeleteCheckBanksA(ID);
            }
            else
            {
                blc.DeleteCheckBanksB(ID);
            }
            ShowAllChecksBank();
        }

        private void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ADMINNUMBER.Text == "1")
            {
                blc.ChangeStatusCheckBankA(ID);
            }
            else
            {
                blc.ChangeStatusCheckBankB(ID);
            }
            ShowAllChecksBank();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
