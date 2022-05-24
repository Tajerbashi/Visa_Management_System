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
        int ID = 0, Tap = 1;
        public void ShowAllChecksBankPassed()
        {
            DGV.Rows.Clear();
            int NO = 1;
            String Status;
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowAllChecksBankPassedA();
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
            else
            {
                var DB = blc.ShowAllChecksBankPassedB();
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
        }
        public void ShowAllChecksBankNotPassed()
        {
            DGV.Rows.Clear();
            int NO = 1;
            String Status;
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowAllChecksBankNotPassedA();
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
            else
            {
                var DB = blc.ShowAllChecksBankNotPassedB();
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
        }
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
        public void GetCheckBanksSortSave()
        {
            DGV.Rows.Clear();
            int NO = 1;
            String Status;
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.GetCheckBanksSortSaveA();
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
            else
            {
                var DB = blc.GetCheckBanksSortSaveB();
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
        }
        public void ShowSearchResult(String Word)
        {
            DGV.Rows.Clear();
            int NO = 1;
            String Status;
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowSearchResultForCheckBankA(Word);
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
            else
            {
                var DB = blc.ShowSearchResultForCheckBankB(Word);
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
        }
        public void ShowTodayChecks(String Date)
        {
            DGV.Rows.Clear();
            int NO = 1;
            String Status;
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowTodayChecksA(Date);
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
            else
            {
                var DB = blc.ShowTodayChecksB(Date);
                foreach (var item in DB)
                {
                    Status = (item.Status) ? "پاس شده" : "پاس نشده";
                    DGV.Rows.Add(item.id, NO, item.CustomerName, item.BankName, item.CheckNumber, item.Price, item.SariNumber, item.PassDate, Status, item.Details);
                    NO++;
                }
            }
        }
        public void PassCheckinDGV()
        {
            if (DGV.RowCount>0)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    for (int i = 0; i < DGV.RowCount; i++)
                    {
                        int id = int.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                        blc.PassingTodayChecksA(id);
                    }
                }
                else
                {
                    for (int i = 0; i < DGV.RowCount; i++)
                    {
                        int id = int.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                        blc.PassingTodayChecksB(id);
                    }
                }
            }
            
        }
        public Double CalculatorDGV()
        {
            Double Total = 0;
            if (DGV.RowCount > 0)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    for (int i = 0; i < DGV.RowCount; i++)
                    {
                        Total += int.Parse(DGV.Rows[i].Cells[5].Value.ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < DGV.RowCount; i++)
                    {
                        Total += int.Parse(DGV.Rows[i].Cells[5].Value.ToString());
                    }
                }
            }
            return Total;

        }
        private void CheckBankPanel_Load(object sender, EventArgs e)
        {
            DayDate.Text = Fun.CLOCK();
            ShowTodayChecks(Fun.ChangeToEnglishNumber(Fun.CLOCK()));
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (PassDate.Text.Trim().Length==0)
            {
                ResultLable.Text = "تاریخ چک را وارد کنید";
                PassDate.Focus();
            }
            else if (CheckNumber.Text.Trim().Length == 0)
            {
                ResultLable.Text = "شماره چک را وارد کنید";
                CheckNumber.Focus();
            }
            else if (SariNumber.Text.Trim().Length == 0)
            {
                ResultLable.Text = "شناسه چک را وارد کنید";
                SariNumber.Focus();
            }
            else if (BankName.Text.Trim().Length == 0)
            {
                ResultLable.Text = "نام بانک را وارد کنید";
                BankName.Focus();
            }
            else if (Customer.Text.Trim().Length == 0)
            {
                ResultLable.Text = " نام نماینده را وارد کنید";
                Customer.Focus();
            }
            else if (Price.Text.Trim().Length == 0)
            {
                ResultLable.Text = "مبلغ چک را وارد کنید";
                Price.Focus();
            }
            else if (FactorCode.Text.Trim().Length == 0)
            {
                ResultLable.Text = "کد فاکتور برای چک را وارد کنید";
                FactorCode.Focus();
            }
            else
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
                        checkBank.FactorCode = int.Parse(Fun.ChangeToEnglishNumber(FactorCode.Text));
                        blc.CreateCheckBankA(checkBank);
                        ResultLable.Text = "چک ثبت شد";
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
                        checkBank.FactorCode = int.Parse(Fun.ChangeToEnglishNumber(FactorCode.Text));
                        blc.CreateCheckBankB(checkBank);
                        ResultLable.Text = "چک ثبت شد";
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
                        checkBank.FactorCode = int.Parse(Fun.ChangeToEnglishNumber(FactorCode.Text));
                        blc.UpdateCheckBankA(checkBank, ID);
                        ResultLable.Text = "چک ویرایش شد";
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
                        checkBank.FactorCode = int.Parse(Fun.ChangeToEnglishNumber(FactorCode.Text));
                        blc.UpdateCheckBankB(checkBank, ID);
                        ResultLable.Text = "چک ویرایش شد";
                        SW = true;

                    }
                    buttonX1.Text = "ذخیره";
                }
                Fun.ClearTextBoxes(this.Controls);
                DayDate.Text = Fun.CLOCK();
                ShowAllChecksBankNotPassed();
            }
            
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
            ShowAllChecksBankNotPassed();
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
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ShowSearchResult(Fun.ChangeToEnglishNumber( SearchTxt.Text ));
        }
        private void Reload_Click(object sender, EventArgs e)
        {
            ShowAllChecksBank();
        }
        private void Passed_Click(object sender, EventArgs e)
        {
            ShowAllChecksBankPassed();
        }
        private void NotPassed_Click(object sender, EventArgs e)
        {
            ShowAllChecksBankNotPassed();
        }
        private void SortBySaveTime_Click(object sender, EventArgs e)
        {
            GetCheckBanksSortSave();
        }
        private void ResultLable_Click(object sender, EventArgs e)
        {
            ResultLable.Visible = false;
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            ShowTodayChecks(Fun.ChangeToEnglishNumber( DayDate.Text ));
            PassCheck.Enabled = true;
        }
        private void PassCheck_Click(object sender, EventArgs e)
        {
            PassCheckinDGV();
            PassCheck.Enabled = false;
        }

        private void AllChecks_Click(object sender, EventArgs e)
        {
            ShowAllChecksBank();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            if (Tap%2==0)
            {
                ResultCalculator.Visible = true;
                ResultCalculator.Text = Convert.ToString(CalculatorDGV());
            }
            else
            {
                ResultCalculator.Visible = false;
            }
            Tap++;
        }


        private void ToolsBtn_Click(object sender, EventArgs e)
        {
            if (Tap%2==0)
            {
                PanelTools.Visible = true;
                ResultLable.Visible = true;
            }
            else
            {
                PanelTools.Visible = false;
            }
            Tap++;
        }


    }
}
