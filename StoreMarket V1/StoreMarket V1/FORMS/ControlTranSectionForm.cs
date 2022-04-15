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
    public partial class ControlTranSectionForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public ControlTranSectionForm()
        {
            InitializeComponent();
        }
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();
        int Tap = 1;
        int ID = -1;
        bool SW = true;
        //  نمایش اطلاعات شرکت    
        public void PrintDT1(String ADMIN)
        {   // نمایش پیشفرض صفحه اول
            DT1.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowActiveDataCompanyA();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName,item.CompanyManager,item.Phone1,item.Phone2,item.Address,item.Site,item.Details);
                }
            }
            else
            {
                var DB = blc.ShowActiveDataCompanyB();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
        }
        public void PrintAllDataCompany(String ADMIN)
        {   // نماش تمام اطلاعات صفحه اول
            DT1.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllDataCompanyA();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
            else
            {
                var DB = blc.ShowAllDataCompanyB();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
        }
        //  نمایش اطلاعات نماینده ها    
        public void PrintAllDataAgent(String ADMIN)
        {   //  نمایش اطلاعات ادمین
            DT2.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllDataAgentA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
            else
            {
                var DB = blc.ShowAllDataAgentB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
        }
        public void ShowAllActiveDataAgent(String ADMIN)
        {   //  نمایش تمام اطلاعات نماینده که فعال هستند
            DT2.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllActiveDataAgentA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
            else
            {
                var DB = blc.ShowAllActiveDataAgentB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
        }
        public void ShowAllDataAgentcomplete(String ADMIN)
        {   //  نمایش تمام اطلاعات موجود در پایگاه داده
            DT2.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllDataAgentcompleteA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
            else
            {
                var DB = blc.ShowAllDataAgentcompleteB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
        }
        //  نمایش اطلاعات حساب مشترکین    
        public void PrintAllDataAgentBank(String ADMIN)
        {   //تمام اطلاعات موجود در پایگاه داده
            DT3.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllDataAgentBankA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, Status, item.AgentName, item.NameBank, item.OwnerName, item.AccountNumber);
                }
            }
            else
            {
                var DB = blc.ShowAllDataAgentBankB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, Status, item.AgentName, item.NameBank, item.OwnerName, item.AccountNumber);
                }
            }
        }

        public void PrintAllActiveDataAgentBank(String ADMIN)
        {   //تمام اطلاعات موجود در پایگاه داده
            DT3.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllActiveDataAgentBankA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, Status, item.AgentName, item.NameBank, item.OwnerName, item.AccountNumber);
                }
            }
            else
            {
                var DB = blc.ShowAllActiveDataAgentBankB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, Status, item.AgentName, item.NameBank, item.OwnerName, item.AccountNumber);
                }
            }
        }



        private void ControlTranSectionForm_Load(object sender, EventArgs e)
        {
            PrintDT1(ADMINNUMBER.Text);
            PrintAllDataAgent(ADMINNUMBER.Text);
        }

        private void ControlTranSectionForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (SW)
            {   // ذخیره کردن
                try
                {
                    if (ADMINNUMBER.Text == "1")
                    {
                        ACompany company = new ACompany();
                        company.CompanyName = companyname1.Text;
                        company.CompanyManager = managername1.Text;
                        company.Phone1 = Fun.ChangeToEnglishNumber(phoneC1.Text);
                        company.Phone2 = Fun.ChangeToEnglishNumber(phoneC2.Text);
                        company.Address = address1.Text;
                        company.Site = site1.Text;
                        company.isActive = (status1.Text) == "فعال" ? true : false;
                        company.DeleteStatus = false;
                        company.Details = details1.Text;
                        if (!blc.CreatCompanyA(company))
                        {
                            MessageBox.Show("ثبت نام انجام شد");
                        }
                    }
                    else if (ADMINNUMBER.Text == "2")
                    {
                        BCompany company = new BCompany();
                        company.CompanyName = companyname1.Text;
                        company.CompanyManager = managername1.Text;
                        company.Phone1 = Fun.ChangeToEnglishNumber(phoneC1.Text);
                        company.Phone2 = Fun.ChangeToEnglishNumber(phoneC2.Text);
                        company.Address = address1.Text;
                        company.Site = site1.Text;
                        company.isActive = (status1.Text) == "فعال" ? true : false;
                        company.DeleteStatus = false;
                        company.Details = details1.Text;
                        if (!blc.CreatCompanyB(company))
                        {
                            MessageBox.Show("ثبت نام انجام شد");
                        }
                    }
                    Fun.ClearTextBoxes(this.Controls);
                }
                catch
                {
                    MessageBox.Show("اطلاعات درست وارد نشده است");
                }

            }
            else
            {   // ویرایش کردن

                if(ADMINNUMBER.Text == "1")
                {
                    ACompany company = blc.SelectCompanyA(ID);
                    company.CompanyName = companyname1.Text;
                    company.CompanyManager = managername1.Text;
                    company.Phone1 = Fun.ChangeToEnglishNumber(phoneC1.Text);
                    company.Phone2 = Fun.ChangeToEnglishNumber(phoneC2.Text);
                    company.Address = address1.Text;
                    company.Site = site1.Text;
                    company.isActive = (status1.Text) == "فعال" ? true : false;
                    company.DeleteStatus = false;
                    company.Details = details1.Text;

                    if (blc.SaveEditCompanyA(company))
                    {
                        MessageBox.Show("ویرایش انجام شد");
                    }
                }
                else
                {
                    BCompany company = blc.SelectCompanyB(ID);
                    company.CompanyName = companyname1.Text;
                    company.CompanyManager = managername1.Text;
                    company.Phone1 = Fun.ChangeToEnglishNumber(phoneC1.Text);
                    company.Phone2 = Fun.ChangeToEnglishNumber(phoneC2.Text);
                    company.Address = address1.Text;
                    company.Site = site1.Text;
                    company.isActive = (status1.Text) == "فعال" ? true : false;
                    company.DeleteStatus = false;
                    company.Details = details1.Text;
                    if (blc.SaveEditCompanyB(company))
                    {
                        MessageBox.Show("ویرایش انجام شد");
                    }
                }
                SaveBTN1.Text = "ذخیره";
                SW = true;
            }
            Fun.ClearTextBoxes(this.Controls);
            PrintDT1(ADMINNUMBER.Text);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Tap == 0)
            {
                #region Tap1
                DialogResult = MessageBox.Show("آیا میخواهید ویرایش کنید", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    if (ADMINNUMBER.Text == "1")
                    {
                        ACompany company = blc.SelectCompanyA(ID);
                        companyname1.Text = company.CompanyName;
                        managername1.Text = company.CompanyManager;
                        phoneC1.Text = company.Phone1;
                        phoneC2.Text = company.Phone2;
                        address1.Text = company.Address;
                        site1.Text = company.Site;
                        details1.Text = company.Details;
                        status1.Text = (company.isActive) == true ? "فعال" : "غیر فعال";
                    }
                    else
                    {
                        BCompany company = blc.SelectCompanyB(ID);
                        companyname1.Text = company.CompanyName;
                        managername1.Text = company.CompanyManager;
                        phoneC1.Text = company.Phone1;
                        phoneC2.Text = company.Phone2;
                        address1.Text = company.Address;
                        site1.Text = company.Site;
                        details1.Text = company.Details;
                        status1.Text = (company.isActive) == true ? "فعال" : "غیر فعال";
                    }
                    SW = false;
                    SaveBTN1.Text = "بروزرسانی";
                }
                #endregion

            }
            else if(Tap == 1)
            {
                #region Tap2
                if (ADMINNUMBER.Text == "1")
                {
                    AAgent agent = blc.SelectAgentA(ID);
                    NameAgent2.Text = agent.Name;
                    FamilyAgent2.Text = agent.Family;
                    CompanyAgent2.Text = agent.CompanyName;
                    PhoneAgent2.Text = agent.Phone.ToString();
                    Status2.Text = (agent.IsActive) ? "فعال" : "غیر فعال";
                }
                else
                {
                    BAgent agent = blc.SelectAgentB(ID);
                    NameAgent2.Text = agent.Name;
                    FamilyAgent2.Text = agent.Family;
                    CompanyAgent2.Text = agent.CompanyName;
                    PhoneAgent2.Text = agent.Phone.ToString();
                    Status2.Text = (agent.IsActive) ? "فعال" : "غیر فعال";
                }
                #endregion
                AgentSave.Text = "بروزرسانی";
                SW = false;
            }
            else if(Tap == 2)
            {
                #region Tap3

                #endregion
            }

        }

        private void DT1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DT1.CurrentRow.Selected = DT1.CurrentRow.Selected == true ? false : true;
            ID = int.Parse(DT1.CurrentRow.Cells[0].Value.ToString());

        }

        private void DT2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DT2.CurrentRow.Selected = DT2.CurrentRow.Selected == true ? false : true;
            ID = int.Parse(DT2.CurrentRow.Cells[0].Value.ToString());
        }
        
        private void DT3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DT3.CurrentRow.Selected = DT3.CurrentRow.Selected == true ? false : true;
            ID = int.Parse(DT3.CurrentRow.Cells[0].Value.ToString());
        }
        
        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Tap == 0)
            {
                #region Tap1
                ID = int.Parse(DT1.CurrentRow.Cells[0].Value.ToString());
                DialogResult = MessageBox.Show("آيا میخواهید شرکت را حذف کنید", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    blc.DeleteCompany(ADMINNUMBER.Text, ID);
                    MessageBox.Show("شرکت حذف شد");
                }
                PrintDT1(ADMINNUMBER.Text);
                #endregion
            }else if(Tap == 1)
            {
                #region Tap2
                ID = int.Parse(DT2.CurrentRow.Cells[0].Value.ToString());
                DialogResult = MessageBox.Show("آيا میخواهید شرکت را حذف کنید", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    blc.DeleteAgent(ADMINNUMBER.Text, ID);
                    MessageBox.Show("شرکت حذف شد");
                }
                PrintAllDataAgent(ADMINNUMBER.Text);
                #endregion
            }
            else if(Tap == 2)
            {
                #region Tap3
                #endregion
            }
        }

        private void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Tap == 0)
            {
                #region Tap1
                ID = int.Parse(DT1.CurrentRow.Cells[0].Value.ToString());
                DialogResult = MessageBox.Show("آيا میخواهید شرکت را حذف کنید", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    blc.ChangeStatusCompany(ADMINNUMBER.Text, ID);
                }
                PrintDT1(ADMINNUMBER.Text);
                #endregion
            }
            else if(Tap == 1)
            {
                #region Tap2
                ID = int.Parse(DT2.CurrentRow.Cells[0].Value.ToString());
                DialogResult = MessageBox.Show("آيا میخواهید شرکت را حذف کنید", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    blc.ChangeStatusAgent(ADMINNUMBER.Text, ID);
                }
                PrintAllDataAgent(ADMINNUMBER.Text);
                #endregion
            }
            else if(Tap == 2)
            {
                #region Tap3
                #endregion
            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AgentSave_Click(object sender, EventArgs e)
        {
            if (SW)
            {   //  ذخیره اطلاعات
                try
                {
                    if (ADMINNUMBER.Text == "1")
                    {
                        AAgent agent = new AAgent();
                        agent.CompanyName = CompanyAgent2.Text;
                        agent.Name = NameAgent2.Text;
                        agent.Family = FamilyAgent2.Text;
                        agent.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(PhoneAgent2.Text));
                        agent.IsActive = (Status2.Text) == "فعال" ? true : false;
                        if (blc.CreatAgentA(agent))
                        {
                            MessageBox.Show("ثبت شد");
                        }
                    }
                    else
                    {
                        BAgent agent = new BAgent();
                        agent.CompanyName = CompanyAgent2.Text;
                        agent.Name = NameAgent2.Text;
                        agent.Family = FamilyAgent2.Text;
                        agent.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(PhoneAgent2.Text));
                        agent.IsActive = (Status2.Text) == "فعال" ? true : false;

                        if (blc.CreatAgentB(agent))
                        {
                            MessageBox.Show("ثبت شد");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("اطلاعات ورودی اشتباه است");
                }
            }
            else
            {   //  ویرایش اطلاعات
                if (ADMINNUMBER.Text == "1")
                {
                    AAgent agent = blc.SelectAgentA(ID);
                    agent.CompanyName = CompanyAgent2.Text;
                    agent.Name = NameAgent2.Text;
                    agent.Family = FamilyAgent2.Text;
                    agent.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(PhoneAgent2.Text));
                    agent.IsActive = (Status2.Text) == "فعال" ? true : false;
                    if (blc.SaveEditAgentA(agent))
                    {
                        MessageBox.Show("اطلاعات بروزرسانی شد");
                    }

                }
                else
                {
                    BAgent agent = blc.SelectAgentB(ID);
                    agent.CompanyName = CompanyAgent2.Text;
                    agent.Name = NameAgent2.Text;
                    agent.Family = FamilyAgent2.Text;
                    agent.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(PhoneAgent2.Text));
                    agent.IsActive = (Status2.Text) == "فعال" ? true : false;
                    if (blc.SaveEditAgentB(agent))
                    {
                        MessageBox.Show("اطلاعات بروزرسانی شد");
                    }
                }

                SW = true;
                AgentSave.Text = "ذخیره";
            }
            PrintAllDataAgent(ADMINNUMBER.Text);
            Fun.ClearTextBoxes(this.Controls);
        }

        private void tabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            Tap = tabControl1.SelectedTabIndex;
            MessageBox.Show(Tap.ToString());
            if (Tap == 0)
            {
                PrintDT1(ADMINNUMBER.Text);
            }
            else 
            if(Tap == 1)
            {
                PrintAllDataAgent(ADMINNUMBER.Text);

            }else
            if(Tap == 2)
            {

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            PrintAllDataAgent(ADMINNUMBER.Text);
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            ShowAllActiveDataAgent(ADMINNUMBER.Text);
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            ShowAllDataAgentcomplete(ADMINNUMBER.Text);
        }

        private void buttonX19_Click(object sender, EventArgs e)
        {
            PrintAllDataCompany(ADMINNUMBER.Text);
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            PrintDT1(ADMINNUMBER.Text);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (ADMINNUMBER.Text == "1")
            {
                AAgentBankAccount AgentBank = new AAgentBankAccount();
                AgentBank.NameBank = bankName3.Text;
                AgentBank.OwnerName = bankOwner3.Text;
                AgentBank.AgentName = agentName3.Text;
                AgentBank.AccountNumber = AccountNumber3.Text;
                if (blc.CreateAgentBankA(AgentBank))
                {
                    MessageBox.Show("حساب ثبت شد");
                }
            }
            else
            {
                BAgentBankAccount AgentBank = new BAgentBankAccount();
                AgentBank.NameBank = bankName3.Text;
                AgentBank.OwnerName = bankOwner3.Text;
                AgentBank.AgentName = agentName3.Text;
                AgentBank.AccountNumber = AccountNumber3.Text;
                if (blc.CreateAgentBankB(AgentBank))
                {
                    MessageBox.Show("حساب ثبت شد");
                }
            }
            PrintAllDataAgentBank(ADMINNUMBER.Text);
        }

        private void buttonX18_Click(object sender, EventArgs e)
        {
            PrintAllActiveDataAgentBank(ADMINNUMBER.Text);
        }



    }
}
