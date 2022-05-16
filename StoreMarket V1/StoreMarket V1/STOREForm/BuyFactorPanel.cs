using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEE;
using BLL;
namespace StoreMarket_V1
{
    public partial class BuyFactorPanel : UserControl
    {
        public BuyFactorPanel()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        ACompany companyA = new ACompany();
        BCompany companyB = new BCompany();
        AAgent agentA = new AAgent();
        BAgent agentB = new BAgent();
        int No = 1;
        int index = 0;
        public void GetAgentNameForXCompany(String Admin, String CompanyName1)
        {
            AgentName.Items.Clear();
            if (Admin == "1")
            {
                var DB = blc.GetAgentA();
                foreach (var item in DB)
                {
                    if (item.CompanyName == CompanyName1)
                    {
                        AgentName.Items.Add(item.FullName);
                    }
                }
            }
            else
            {
                var DB = blc.GetAgentB();
                foreach (var item in DB)
                {
                    if (item.CompanyName == CompanyName1)
                    {
                        AgentName.Items.Add(item.FullName);
                    }
                }
            }
        }
        public void GetCompanyForXAgent(String Admin, String AgentName1)
        {
            CompanyName.Items.Clear();
            if (Admin == "1")
            {
                var DB = blc.GetAgentA();
                foreach (var item in DB)
                {
                    if (item.FullName == AgentName1)
                    {
                        CompanyName.Items.Add(item.CompanyName);
                    }
                }
            }
            else
            {
                var DB = blc.GetAgentB();
                foreach (var item in DB)
                {
                    if (item.FullName == AgentName1)
                    {
                        CompanyName.Items.Add(item.CompanyName);
                    }
                }
            }
        }

        public void GetAgentName(String Admin)
        {
            AgentName.Items.Clear();
            if (Admin == "1")
            {
                var DB = blc.GetAgentA();
                foreach (var item in DB)
                {
                    AgentName.Items.Add(item.FullName);
                }
            }
            else
            {
                var DB = blc.GetAgentB();
                foreach (var item in DB)
                {
                    AgentName.Items.Add(item.FullName);
                }
            }
        }
        public void GetCompanyName(String Admin)
        {
            CompanyName.Items.Clear();
            if (Admin == "1")
            {
                var DB = blc.GetCompanyA();
                foreach (var item in DB)
                {
                    CompanyName.Items.Add(item.CompanyName);
                }
            }
            else
            {
                var DB = blc.GetCompanyB();
                foreach (var item in DB)
                {
                    CompanyName.Items.Add(item.CompanyName);
                }
            }
        }

        public void GetBrandProduct(String Admin)
        {
            Brand.Items.Clear();
            if (Admin == "1")
            {
                var q = from i in blc.GetProductsA() select i.Brand;
                var q1 = q.Distinct();
                foreach (var item in q1)
                {
                    Brand.Items.Add(item);
                }
            }
            else
            {
                var q = from i in blc.GetProductsB() select i.Brand;
                var q1 = q.Distinct();
                foreach (var item in q1)
                {
                    Brand.Items.Add(item);
                }
            }
        }

        public void GetLastFactorNumber(String Admin)
        {
            if (Admin == "1")
            {
                factorNumber.Text = (blc.GetLastFactorNumberA()).ToString();
            }
            else
            {
                factorNumber.Text = (blc.GetLastFactorNumberB()).ToString();
            }
        }
        public void GetLastFactorCode(String Admin)
        {
            if (Admin == "1")
            {
                FactorCode.Text = (blc.GetLastFactorCodeA()).ToString();
            }
            else
            {
                FactorCode.Text = (blc.GetLastFactorCodeB()).ToString();
            }
        }
        
        private void BuyFactorPanel_Load(object sender, EventArgs e)
        {
            DayDate.Text = Fun.CLOCK();
            GetAgentName(ADMIN.Text);
            GetCompanyName(ADMIN.Text);
            GetLastFactorNumber(ADMIN.Text);
            GetLastFactorCode(ADMIN.Text);
            GetBrandProduct(ADMIN.Text);
        }

        private void AgentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCompanyForXAgent(ADMIN.Text, AgentName.Text);
            if (ADMIN.Text == "1")
            {
                agentA = blc.GetAgentIDA(CompanyName.Text);
            }
            else
            {
                agentB = blc.GetAgentIDB(CompanyName.Text);
            }
        }

        private void CompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAgentNameForXCompany(ADMIN.Text, CompanyName.Text);
            if (ADMIN.Text=="1")
            {
                //AgentName.Items.Clear();
                companyA = blc.GetCompanyIDA(CompanyName.Text);
                //var agents = from i in blc.GetAgentA() where i.CompanyName==CompanyName.Text select i;
                //foreach (var item in agents)
                //{
                //    AgentName.Items.Add(item);
                //}
            }
            else
            {
                companyB = blc.GetCompanyIDB(CompanyName.Text);

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            CompanyName.Text = " ";
            AgentName.Text = " ";
            GetAgentName(ADMIN.Text);
            GetCompanyName(ADMIN.Text);
            DayDate.Text = Fun.CLOCK();
        }

        private void factorNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            bool ExistInDGV = false;
            int index = 0;
            DateTime Produce = DateTime.Now.AddMonths(-(int.Parse(TolidDate.Value.ToString())));
            DateTime Expire = DateTime.Now.AddMonths(int.Parse(ExpireDate.Value.ToString()));
            DateTime RegisterDateProduct = DateTime.Now;

            if (AdminName.Text.Trim().Length == 0)
            {
                ResultText.Text = "نام ادمین ذکر شود";
                AdminName.Focus();
            }
            else if (AgentName.Text.Trim().Length == 0)
            {
                ResultText.Text = "نام نماینده شرکت ذکر شود";
                AgentName.Focus();

            }
            else if (FactorCode.Text.Trim().Length == 0)
            {
                ResultText.Text = "کد فاکتور ذکر شود";
                FactorCode.Focus();

            }
            else if (DayDate.Text.Trim().Length == 0)
            {
                ResultText.Text = "تاریخ امروز را درج کنید";
                DayDate.Focus();

            }
            else if (CompanyName.Text.Trim().Length == 0)
            {
                ResultText.Text = "نام شرکت را درج کنید";
                CompanyName.Focus();

            }
            else if (CashType.Text.Trim().Length == 0)
            {
                ResultText.Text = "نوع پرداخت را درج کنید";
                CashType.Focus();

            }
            else if (ProductName.Text.Trim().Length == 0)
            {
                ResultText.Text = "نام محصول را ذکر کنید";
                ProductName.Focus();

            }
            else if (ProductType.Text.Trim().Length == 0)
            {
                ResultText.Text = "نوع محصول را انتخاب کنید";
                ProductType.Focus();

            }
            else if (Price.Text.Trim().Length == 0)
            {
                ResultText.Text = "قیمت محصول را درج کنید";
                Price.Focus();

            }
            else if (Brand.Text.Trim().Length == 0)
            {
                ResultText.Text = "برند محصول را درج کنید";
                Brand.Focus();

            }
            else if (Tehdad.Value.ToString() == "0")
            {
                ResultText.Text = "تعداد خرید محصول را درج کنید";
                Tehdad.Focus();

            }
            else if (TolidDate.Value.ToString() == "0")
            {
                ResultText.Text = "تاریخ تولید را درج کنید";
                TolidDate.Focus();

            }
            else if (ExpireDate.Value.ToString() == "0")
            {
                ResultText.Text = "تاریخ انقضاء را درج کنید";
                ExpireDate.Focus();

            }
            else
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 2)
                        {
                            if (cell.Value.ToString()==ProductName.Text.Trim())
                            {
                                index = cell.RowIndex;
                                if (DGV.Rows[index].Cells[3].Value.ToString()==ProductType.Text.Trim()  && DGV.Rows[index].Cells[4].Value.ToString() == CompanyName.Text.Trim())
                                {
                                    ExistInDGV = true;
                                }
                            }
                        }
                    }
                }
                if (ExistInDGV)
                {
                    // در دتاگرید موجود است واطلاعات ویرایش شود
                    #region EditCode 
                    int ID = int.Parse(DGV.Rows[index].Cells[0].Value.ToString());
                    int TehdadTotal=int.Parse(Tehdad.Value.ToString())+ int.Parse(DGV.Rows[index].Cells[5].Value.ToString());
                    int NewPrice = int.Parse(Fun.ChangeToEnglishNumber(Price.Text));
                    int TotalPrice = TehdadTotal*NewPrice;
                    DGV.Rows[index].Cells[5].Value = TehdadTotal; 
                    DGV.Rows[index].Cells[6].Value = NewPrice; 
                    DGV.Rows[index].Cells[7].Value = TotalPrice;
                    #endregion
                }
                else
                {
                    //  در دتاگرید موجود نیست و ثبت و اضافه کن
                    #region CodeAdd
                    ACompany company = new ACompany();
                    company.CompanyName = CompanyName.Text.Trim();
                    company.Phone1 = company.Phone2 = company.Address = company.Site = company.Details = company.CompanyManager = "تعریف نشده";

                    AAgent agent = new AAgent();
                    agent.CompanyName = CompanyName.Text.Trim();
                    agent.FullName = AgentName.Text.Trim();
                    agent.Address = "تعریف نشده";
                    agent.Phone = 100;

                    AProduct product = new AProduct();
                    product.BuyCount = int.Parse(Tehdad.Value.ToString());
                    product.Mojodi = product.BuyCount;
                    product.Name = ProductName.Text.Trim();
                    product.Type = ProductType.Text.Trim();
                    product.Brand = Brand.Text.Trim();
                    product.buyPrice = product.newBuyPrice = int.Parse((Fun.ChangeToEnglishNumber(Price.Text)).ToString());
                    product.sellPrice = 0;
                    product.CashType = (CashType.Text) == "نقدی" ? 1 : 2;
                    product.Totalcash = (product.BuyCount * product.buyPrice);
                    product.AgentName = AgentName.Text.Trim();
                    product.ProduceDate = Produce.ToString("yyyy/MM/dd");
                    product.RegisterDate = RegisterDateProduct.ToString("yyyy/MM/dd");
                    product.ExpireDate = Expire.ToString("yyyy/MM/dd");


                    if (!blc.CreatCompanyA(company))
                    {
                        agent.Company = blc.GetCompanyA().Where(c => c.CompanyName == company.CompanyName).FirstOrDefault();
                    }
                    else
                    {
                        agent.Company = company;
                    }

                    if (blc.CreatAgentA(agent))
                    {
                        ResultText.Text = "جدید است";
                    }
                    else
                    {
                        ResultText.Text = "جدید نیست";
                    }

                    blc.CreateProductForBuyFactorA(product);
                    DGV.Rows.Add(product.id, No, ProductName.Text.Trim(), ProductType.Text.Trim(), CompanyName.Text.Trim(), Tehdad.Value.ToString(), Price.Text, (int.Parse(Fun.ChangeToEnglishNumber(Tehdad.Value.ToString())) * int.Parse(Fun.ChangeToEnglishNumber(Price.Text.ToString()))));
                    ProductName.Text = " ";
                    ProductName.Focus();
                    No++;
                    #endregion

                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            MessageBoxForm message = new MessageBoxForm();
            message.title.Text = "تایید درخواست";
            message.Subject.Text = "آیا میخواهید فاکتور جدید شود؟؟؟";
            message.question.Visible = true;
            message.ShowDialog();
            if (message.Sw)
            {
                No = 1;
                if (ADMIN.Text == "1")
                {
                    FactorCode.Text = blc.GetLastFactorCodeA().ToString();
                    factorNumber.Text = blc.GetLastFactorNumberA().ToString();
                    CompanyName.Text = " ";
                    AgentName.Text = " ";

                }
                else
                {
                    FactorCode.Text = blc.GetLastFactorCodeB().ToString();
                    factorNumber.Text = blc.GetLastFactorNumberB().ToString();
                    CompanyName.Text = " ";
                    AgentName.Text = " ";
                }
                Fun.ClearTextBoxes(this.Controls);
            }
        }
        
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DGV.Rows.RemoveAt(index);
            No = 1;
            for (int i=0;i<DGV.Rows.Count;i++)
            {
                DGV.Rows[i].Cells[1].Value = No;
                No++;
            }
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = DGV.CurrentRow.Index;
            if ( e.Button==MouseButtons.Right || e.Button == MouseButtons.Left )
            {
                DGV.CurrentRow.Selected = (DGV.CurrentRow.Selected) ? false : true;
            }
            
            //MessageBox.Show(index.ToString());
        }

    }
}

