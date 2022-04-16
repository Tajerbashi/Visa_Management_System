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
        int Tap = 0;
        int ID = -1;
        bool SW = true;
        //  نمایش اطلاعات شرکت    
        public void ShowAllCompany(String ADMIN)
        {   // نمایش پیشفرض صفحه اول
            DT1.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllDataCompanyA();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName,item.CompanyManager,item.Phone1,item.Phone2,item.Address,item.Site,item.Details);
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
        public void ShowAllActiveCompany(String ADMIN)
        {   // نماش تمام اطلاعات صفحه اول
            DT1.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllActiveDataCompanyA();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
            else
            {
                var DB = blc.ShowAllActiveDataCompanyA();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
        }
        public void ShowAllDisActiveCompany(String ADMIN)
        {   // نمایش پیشفرض صفحه اول
            DT1.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllDisActiveDataCompanyA();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
            else
            {
                var DB = blc.ShowAllDisActiveDataCompanyB();
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
        }

        //  نمایش اطلاعات نماینده ها    
        public void ShowAllAgent(String ADMIN)
        {   //  نمایش اطلاعات ادمین
            DT2.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllAgentA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
            else
            {
                var DB = blc.ShowAllAgentB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
        }
        public void ShowAllActiveAgent(String ADMIN)
        {   //  نمایش تمام اطلاعات نماینده که فعال هستند
            DT2.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllActiveAgentA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
            else
            {
                var DB = blc.ShowAllActiveAgentB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
        }
        public void ShowAllDisActiveAgent(String ADMIN)
        {   //  نمایش تمام اطلاعات موجود در پایگاه داده
            DT2.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllDisActiveAgentA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
            else
            {
                var DB = blc.ShowAllDisActiveAgentB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
        }
        
        //  نمایش اطلاعات حساب مشترکین    
        public void ShowAllAgentAccountBank(String ADMIN)
        {   //تمام اطلاعات موجود در پایگاه داده
            DT3.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllDataAgentBankA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, item.AccountNumber, item.OwnerName, item.NameBank, item.AgentName, Status);
                }
            }
            else
            {
                var DB = blc.ShowAllDataAgentBankB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, item.AccountNumber, item.OwnerName, item.NameBank, item.AgentName, Status);
                }
            }
        }
        public void ShowAllActiveAgentAccountBank(String ADMIN)
        {   //تمام اطلاعات که فعال است در پایگاه داده
            DT3.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllActiveDataAgentBankA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, item.AccountNumber, item.OwnerName, item.NameBank, item.AgentName, Status);
                }
            }
            else
            {
                var DB = blc.ShowAllActiveDataAgentBankB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, item.AccountNumber, item.OwnerName, item.NameBank, item.AgentName, Status);
                }
            }
        }
        public void ShowAllDisActiveAgentAccountBank(String ADMIN)
        {
            DT3.Rows.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllActiveDataAgentBankA();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, item.AccountNumber, item.OwnerName, item.NameBank, item.AgentName, Status);
                }
            }
            else
            {
                var DB = blc.ShowAllActiveDataAgentBankB();
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, item.AccountNumber, item.OwnerName, item.NameBank, item.AgentName, Status);
                }
            }
        }
        
        //  نمایش نتایج جستجو
        public void SearchTap0(String Admin,String Word)
        {
            DT1.Rows.Clear();
            if (Admin == "1")
            {
                var DB = blc.SearchResult0A(Word);
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
            else
            {
                var DB = blc.SearchResult0B(Word);
                foreach (var item in DB)
                {
                    String Status = (item.isActive) == true ? "فعال" : "غیر فعال";
                    DT1.Rows.Add(item.id, Status, item.CompanyName, item.CompanyManager, item.Phone1, item.Phone2, item.Address, item.Site, item.Details);
                }
            }
        }
        public void SearchTap1(String Admin,String Word)
        {
            DT2.Rows.Clear();
            if (Admin == "1")
            {
                var DB = blc.SearchResult1A(Word);
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
            else
            {
                var DB = blc.SearchResult1B(Word);
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) ? "فعال" : "غیر فعال";
                    DT2.Rows.Add(item.Id, Status, item.CompanyName, item.Name, item.Family, item.Phone);
                }
            }
        }
        public void SearchTap2(String Admin, String Word)
        {
            DT3.Rows.Clear();
            if (Admin == "1")
            {
                var DB = blc.SearchResult2A(Word);
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, item.AccountNumber, item.OwnerName, item.NameBank, item.AgentName, Status);
                }
            }
            else
            {
                var DB = blc.SearchResult2B(Word);
                foreach (var item in DB)
                {
                    String Status = (item.IsActive) ? "فعال" : "غیر فعال";
                    DT3.Rows.Add(item.id, item.AccountNumber, item.OwnerName, item.NameBank, item.AgentName, Status);
                }
            }
        }


        private void ControlTranSectionForm_Load(object sender, EventArgs e)
        {
            ShowAllActiveCompany(ADMINNUMBER.Text);
            ShowAllAgent(ADMINNUMBER.Text);
            ShowAllAgentAccountBank(ADMINNUMBER.Text);
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
            if (companyname1.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام شرکت را ذکر کنید");
                companyname1.Focus();
            }else if (managername1.Text.Trim().Length==0)
            {
                MessageBox.Show("نام مدیر شرکت را ذکر کنید");
                managername1.Focus();
            }
            else if (phoneC1.Text.Trim().Length == 0 || phoneC2.Text.Trim().Length == 0) 
            {
                MessageBox.Show("شماره تماس را ذکر کنید");
                phoneC1.Focus();
            }
            else if (status1.Text.Trim().Length==0)
            {
                MessageBox.Show("وضعیت را مشخص کنید");
                status1.Focus();
            }
            else
            {
                try
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
                                if (blc.CreatCompanyA(company))
                                {
                                    MessageBox.Show("ثبت نام انجام شد");
                                }
                                else
                                {
                                    MessageBox.Show("ثبت نام ناموفق ");
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
                                if (blc.CreatCompanyB(company))
                                {
                                    MessageBox.Show("ثبت نام انجام شد");
                                }
                                else
                                {
                                    MessageBox.Show("ثبت نام ناموفق ");
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

                        if (ADMINNUMBER.Text == "1")
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
                    ShowAllCompany(ADMINNUMBER.Text);
                }
                catch
                {
                    MessageBox.Show("اطلاعات درست نیست");
                }

            }

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
                DialogResult = MessageBox.Show("آیا میخواهید ویرایش کنید", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
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
                    AgentSave.Text = "بروزرسانی";
                    SW = false;
                }
                #endregion
                
            }
            else if(Tap == 2)
            {
                #region Tap3
                DialogResult = MessageBox.Show("آیا میخواهید ویرایش کنید", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    if (ADMINNUMBER.Text == "1")
                    {
                        AAgentBankAccount agentbank = blc.SelectAgentBankAccountA(ID);
                        bankName3.Text = agentbank.NameBank;
                        bankOwner3.Text = agentbank.OwnerName;
                        agentName3.Text = agentbank.AgentName;
                        AccountNumber3.Text = agentbank.AccountNumber;
                    }
                    else
                    {
                        BAgentBankAccount agentbank = blc.SelectAgentBankAccountB(ID);
                        bankName3.Text = agentbank.NameBank;
                        bankOwner3.Text = agentbank.OwnerName;
                        agentName3.Text = agentbank.AgentName;
                        AccountNumber3.Text = agentbank.AccountNumber;
                    }
                    Save3.Text = "بروزرسانی";
                    SW = false;
                }
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
                #region Tap0
                ID = int.Parse(DT1.CurrentRow.Cells[0].Value.ToString());
                DialogResult = MessageBox.Show("آيا میخواهید شرکت را حذف کنید؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    blc.DeleteCompany(ADMINNUMBER.Text, ID);
                    MessageBox.Show("شرکت حذف شد");
                    ShowAllCompany(ADMINNUMBER.Text);
                }
                #endregion
            }
            else if(Tap == 1)
            {
                #region Tap1
                ID = int.Parse(DT2.CurrentRow.Cells[0].Value.ToString());
                DialogResult = MessageBox.Show("آيا میخواهید نماینده فروش را حذف کنید؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    blc.DeleteAgent(ADMINNUMBER.Text, ID);
                    MessageBox.Show("شرکت حذف شد");
                    ShowAllAgent(ADMINNUMBER.Text);
                }
                #endregion
            }
            else if(Tap == 2)
            {
                #region Tap2
                ID = int.Parse(DT3.CurrentRow.Cells[0].Value.ToString());
                DialogResult = MessageBox.Show("آيا میخواهید حساب مشترک را حذف کنید؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    blc.DeleteBankAccountAgent(ADMINNUMBER.Text, ID);
                    MessageBox.Show("شرکت حذف شد");
                    ShowAllCompany(ADMINNUMBER.Text);
                }
                #endregion
            }
        }

        private void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Tap == 0)
            {
                #region Tap1
                ID = int.Parse(DT1.CurrentRow.Cells[0].Value.ToString());
                blc.ChangeStatusCompany(ADMINNUMBER.Text, ID);
                ShowAllCompany(ADMINNUMBER.Text);
                #endregion
            }
            else if(Tap == 1)
            {
                #region Tap2
                ID = int.Parse(DT2.CurrentRow.Cells[0].Value.ToString());
                blc.ChangeStatusAgent(ADMINNUMBER.Text, ID);
                ShowAllAgent(ADMINNUMBER.Text);
                #endregion
            }
            else if(Tap == 2)
            {
                #region Tap2
                ID = int.Parse(DT3.CurrentRow.Cells[0].Value.ToString());
                blc.ChangeStatusAgentBank(ADMINNUMBER.Text, ID);
                ShowAllAgentAccountBank(ADMINNUMBER.Text);
                #endregion
            }
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
            if (NameAgent2.Text.Trim().Length==0)
            {
                MessageBox.Show("نام را ذکر کنید");
                NameAgent2.Focus();
            }else if (FamilyAgent2.Text.Trim().Length == 0)
            {
                MessageBox.Show("فامیلی را ذکر کنید");
                NameAgent2.Focus();
            }
            else if (PhoneAgent2.Text.Trim().Length == 0)
            {
                MessageBox.Show("تلفن را ذکر کنید");
                NameAgent2.Focus();
            }
            else if (CompanyAgent2.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام شرکت را ذکر کنید");
                NameAgent2.Focus();
            }
            else if (Status2.Text.Trim().Length == 0)
            {
                MessageBox.Show("وضعیت را ذکر کنید");
                NameAgent2.Focus();
            }
            else
            {
                try
                {
                    if (SW)
                    {   //  ذخیره اطلاعات
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
                            else
                            {
                                MessageBox.Show("ثبت نام ناموفق");
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
                            else
                            {
                                MessageBox.Show("ثبت نام ناموفق");
                            }
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
                            else
                            {
                                MessageBox.Show("اطلاعات تکراری وارد شده است");
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
                            else
                            {
                                MessageBox.Show("اطلاعات تکراری وارد شده است");
                            }
                        }

                        SW = true;
                        AgentSave.Text = "ذخیره";
                    }

                    ShowAllAgent(ADMINNUMBER.Text);
                    Fun.ClearTextBoxes(this.Controls);
                }
                catch
                {
                    MessageBox.Show("اطلاعات اشتباه است");
                }

            }
        }

        private void tabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            Tap = tabControl1.SelectedTabIndex;
            //MessageBox.Show(Tap.ToString());
            if (Tap == 0)
            {
                ShowAllCompany(ADMINNUMBER.Text);
            }
            else 
            if(Tap == 1)
            {
                ShowAllAgent(ADMINNUMBER.Text);

            }else
            if(Tap == 2)
            {
                ShowAllCompany(ADMINNUMBER.Text);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (bankName3.Text.Trim().Length==0)
            {
                MessageBox.Show("نام بانک را ذکر کنید");
                bankName3.Focus();
            }else if (bankOwner3.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام بانک را ذکر کنید");
                bankOwner3.Focus();
            }
            else if (agentName3.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام بانک را ذکر کنید");
                agentName3.Focus();
            }
            else if (AccountNumber3.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام بانک را ذکر کنید");
                AccountNumber3.Focus();
            }
            else
            {
                try
                {
                    if (SW)
                    {   // ذخره حساب بانکی مشترکین
                        if (ADMINNUMBER.Text == "1")
                        {
                            AAgentBankAccount AgentBank = new AAgentBankAccount();
                            AgentBank.NameBank = bankName3.Text;
                            AgentBank.OwnerName = bankOwner3.Text;
                            AgentBank.AgentName = agentName3.Text;
                            AgentBank.AccountNumber = Fun.ChangeToEnglishNumber(AccountNumber3.Text);
                            AgentBank.IsActive = true;
                            AgentBank.DeleteStatus = false;
                            if (blc.CreateAgentBankA(AgentBank))
                            {
                                Fun.ClearTextBoxes(this.Controls);
                                MessageBox.Show("حساب ثبت شد");
                            }
                        }
                        else
                        {
                            BAgentBankAccount AgentBank = new BAgentBankAccount();
                            AgentBank.NameBank = bankName3.Text;
                            AgentBank.OwnerName = bankOwner3.Text;
                            AgentBank.AgentName = agentName3.Text;
                            AgentBank.AccountNumber = Fun.ChangeToEnglishNumber(AccountNumber3.Text);
                            AgentBank.IsActive = true;
                            AgentBank.DeleteStatus = false;
                            if (blc.CreateAgentBankB(AgentBank))
                            {
                                Fun.ClearTextBoxes(this.Controls);
                                MessageBox.Show("حساب ثبت شد");
                            }
                        }
                    }
                    else
                    {   //  ویرایش حساب بانکی مشترکین
                        if (ADMINNUMBER.Text == "1")
                        {
                            AAgentBankAccount agentbank = blc.SelectAgentBankAccountA(ID);
                            agentbank.NameBank = bankName3.Text;
                            agentbank.OwnerName = bankOwner3.Text;
                            agentbank.AgentName = agentName3.Text;
                            agentbank.AccountNumber = Fun.ChangeToEnglishNumber(AccountNumber3.Text);
                            agentbank.IsActive = true;
                            if (blc.SaveEditAgentBankA(agentbank))
                            {
                                Fun.ClearTextBoxes(this.Controls);
                                MessageBox.Show("ویرایش شد");
                            }
                        }
                        else
                        {
                            BAgentBankAccount agentbank = blc.SelectAgentBankAccountB(ID);
                            agentbank.NameBank = bankName3.Text;
                            agentbank.OwnerName = bankOwner3.Text;
                            agentbank.AgentName = agentName3.Text;
                            agentbank.AccountNumber = Fun.ChangeToEnglishNumber(AccountNumber3.Text);
                            agentbank.IsActive = true;
                            if (blc.SaveEditAgentBankB(agentbank))
                            {
                                Fun.ClearTextBoxes(this.Controls);
                                MessageBox.Show("ویرایش شد");
                            }
                        }
                        Save3.Text = "ذخیره";
                        SW = true;
                    }
                }
                catch
                {
                    MessageBox.Show("اطلاعات ورودی درست نیست");
                }

                ShowAllAgentAccountBank(ADMINNUMBER.Text);
            }


        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (Tap == 0)
            {
                SearchTap0(ADMINNUMBER.Text, SearchBox.Text);
            } 
            else 
            if (Tap == 1)
            {
                SearchTap1(ADMINNUMBER.Text, SearchBox.Text);
            }
            else
            if(Tap == 2)
            {
                SearchTap2(ADMINNUMBER.Text, SearchBox.Text);
            }
        }

        private void buttonX19_Click_1(object sender, EventArgs e)
        {
            ShowAllDisActiveCompany(ADMINNUMBER.Text);
        }

        private void buttonX7_Click_1(object sender, EventArgs e)
        {
            ShowAllActiveCompany(ADMINNUMBER.Text);
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            ShowAllCompany(ADMINNUMBER.Text);
        }

    }
}
