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
        #region Objects
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        ACompany companyA = new ACompany();
        BCompany companyB = new BCompany();
        AAgent agentA = new AAgent();
        BAgent agentB = new BAgent();
        
        AAdmin AdminA = new AAdmin();
        BAdmin AdminB = new BAdmin();
        #endregion
        int No = 1;
        int index = 0;
        int IDforDelete = 0;
        #region MouseHover
        private void buttonX2_MouseEnter(object sender, EventArgs e)
        {
            buttonX2.FadeEffect = true;
            buttonX2.TextColor = Color.Black;
        }

        private void buttonX2_MouseLeave(object sender, EventArgs e)
        {
            buttonX2.TextColor = Color.White;
        }

        private void Addbtn_MouseEnter(object sender, EventArgs e)
        {
            Addbtn.FadeEffect = true;
            Addbtn.TextColor = Color.Black;
        }

        private void Addbtn_MouseLeave(object sender, EventArgs e)
        {
            Addbtn.TextColor = Color.White;
        }

        private void Deletebtn_MouseEnter(object sender, EventArgs e)
        {
            Deletebtn.FadeEffect = true;
            Deletebtn.TextColor = Color.Black;
        }

        private void Deletebtn_MouseLeave(object sender, EventArgs e)
        {
            Deletebtn.TextColor = Color.White;
        }

        private void Savebtn_MouseEnter(object sender, EventArgs e)
        {
            Savebtn.FadeEffect = true;
            Savebtn.TextColor = Color.Black;
        }

        private void Savebtn_MouseLeave(object sender, EventArgs e)
        {
            Savebtn.TextColor = Color.White;
        }

        private void buttonX3_MouseEnter(object sender, EventArgs e)
        {
            buttonX3.TextColor = Color.Black;
            buttonX3.FadeEffect = true;
        }

        private void buttonX3_MouseLeave(object sender, EventArgs e)
        {
            buttonX3.TextColor = Color.White;
        }

        private void buttonX5_MouseEnter(object sender, EventArgs e)
        {
            buttonX5.FadeEffect = true;
            buttonX5.TextColor = Color.Black;
        }

        private void buttonX5_MouseLeave(object sender, EventArgs e)
        {
            buttonX5.TextColor = Color.White;
        }

        private void buttonX4_MouseEnter(object sender, EventArgs e)
        {
            buttonX4.FadeEffect = true;
            buttonX4.TextColor = Color.Black;
        }

        private void buttonX4_MouseLeave(object sender, EventArgs e)
        {
            buttonX4.TextColor = Color.White;
        }
        #endregion
        #region Functions
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
            if (Admin == "2")
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
                FactorNumber.Text = (blc.GetLastBuyFactorNumberA()).ToString();
            }
            else
            {
                FactorNumber.Text = (blc.GetLastBuyFactorNumberB()).ToString();
            }
        }
        public void GetLastFactorCode(String Admin)
        {
            if (Admin == "1")
            {
                FactorCode.Text = (blc.GetLastBuyFactorCodeA()).ToString();
            }
            else
            {
                FactorCode.Text = (blc.GetLastBuyFactorCodeB()).ToString();
            }
        }
        #endregion

        private void BuyFactorPanel_Load(object sender, EventArgs e)
        {
            DayDate.Text = Fun.CLOCK();
            GetAgentName(AdminNumber.Text);
            GetCompanyName(AdminNumber.Text);
            GetLastFactorNumber(AdminNumber.Text);
            GetLastFactorCode(AdminNumber.Text);
            GetBrandProduct(AdminNumber.Text);
            if (AdminNumber.Text=="1")
            {
                AdminA = blc.GetAdminsA().Where(c => c.Username == AdminName.Text).FirstOrDefault();
            }
            else
            {
                AdminB = blc.GetAdminsB().Where(c => c.Username == AdminName.Text).FirstOrDefault();
            }
        }

        private void AgentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCompanyForXAgent(AdminNumber.Text, AgentName.Text);
            if (AdminNumber.Text == "1")
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
            GetAgentNameForXCompany(AdminNumber.Text, CompanyName.Text);
            if (AdminNumber.Text=="1")
            {
                companyA = blc.GetCompanyIDA(CompanyName.Text);
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
            GetAgentName(AdminNumber.Text);
            GetCompanyName(AdminNumber.Text);
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
                    if (AdminNumber.Text == "1")
                    {
                        #region CodeAddA
                        ACompany company = new ACompany();
                        company.CompanyName = CompanyName.Text.Trim();
                        company.Phone1 = company.Phone2 = company.Address = company.Site = company.Details = company.CompanyManager = "تعریف نشده";

                        AAgent agent = new AAgent();
                        agent.CompanyName = CompanyName.Text.Trim();
                        agent.FullName = AgentName.Text.Trim();
                        agent.Address = "تعریف نشده";
                        agent.Phone = "تعریف نشده";

                        AProduct product = new AProduct();
                        product.BuyCount = int.Parse(Tehdad.Value.ToString());
                        product.Mojodi = product.BuyCount;
                        product.Name = ProductName.Text.Trim();
                        product.Type = ProductType.Text.Trim();
                        product.Brand = Brand.Text.Trim();
                        product.buyPrice = Convert.ToDouble((Fun.ChangeToEnglishNumber(Price.Text)));
                        product.sellPrice = Convert.ToDouble((Fun.ChangeToEnglishNumber(SellPrice.Text)));
                        product.newBuyPrice = Convert.ToDouble((Fun.ChangeToEnglishNumber(Price.Text)));
                        product.CashType = (CashType.Text) == "نقدی" ? 1 : 2;
                        product.Totalcash = (product.BuyCount * product.buyPrice);
                        product.AgentName = AgentName.Text.Trim();
                        product.ProduceDate = Fun.ChangeToEnglishNumber(Produce.ToString("yyyy/MM/dd"));
                        product.RegisterDate = Fun.ChangeToEnglishNumber(DayDate.Text);
                        product.ExpireDate = Fun.ChangeToEnglishNumber(Expire.ToString("yyyy/MM/dd"));

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
                        
                        int IDforProduct = 0;
                        
                        if (blc.CreateProductForBuyFactorA(product))
                        {
                            IDforProduct = product.id;
                        }
                        else
                        {
                            var q = from i in blc.GetProductsA() where i.Name == product.Name && i.Type == product.Type && i.Brand == product.Brand && i.AgentName == product.AgentName select i;
                            foreach (var item in q)
                            {
                                IDforProduct = item.id;
                            }
                        }
                        DGV.Rows.Add(IDforProduct, No, ProductName.Text.Trim(), ProductType.Text.Trim(), CompanyName.Text.Trim(), Tehdad.Value.ToString(), Convert.ToDouble(Price.Text).ToString("#,0"), (Convert.ToDouble(Fun.ChangeToEnglishNumber(Tehdad.Value.ToString())) * Convert.ToDouble(Fun.ChangeToEnglishNumber(Price.Text.ToString()))));
                        ProductName.Text = " ";
                        ProductName.Focus();
                        No++;
                        #endregion
                    }
                    else
                    {
                        #region CodeAddB
                        BCompany company = new BCompany();
                        company.CompanyName = CompanyName.Text.Trim();
                        company.Phone1 = company.Phone2 = company.Address = company.Site = company.Details = company.CompanyManager = "تعریف نشده";

                        BAgent agent = new BAgent();
                        agent.CompanyName = CompanyName.Text.Trim();
                        agent.FullName = AgentName.Text.Trim();
                        agent.Address = "تعریف نشده";
                        agent.Phone = "تعریف نشده";

                        BProduct product = new BProduct();
                        product.BuyCount = int.Parse(Tehdad.Value.ToString());
                        product.Mojodi = product.BuyCount;
                        product.Name = ProductName.Text.Trim();
                        product.Type = ProductType.Text.Trim();
                        product.Brand = Brand.Text.Trim();
                        product.buyPrice = Convert.ToDouble((Fun.ChangeToEnglishNumber(Price.Text)));
                        product.newBuyPrice = Convert.ToDouble((Fun.ChangeToEnglishNumber(Price.Text)));
                        product.sellPrice = Convert.ToDouble((Fun.ChangeToEnglishNumber(SellPrice.Text)));
                        product.CashType = (CashType.Text) == "نقدی" ? 1 : 2;
                        product.Totalcash = (product.BuyCount * product.buyPrice);
                        product.AgentName = AgentName.Text.Trim();
                        product.ProduceDate = Fun.ChangeToEnglishNumber(Produce.ToString("yyyy/MM/dd"));
                        product.RegisterDate = Fun.ChangeToEnglishNumber(DayDate.Text);
                        product.ExpireDate = Fun.ChangeToEnglishNumber(Expire.ToString("yyyy/MM/dd"));

                        if (!blc.CreatCompanyB(company))
                        {
                            agent.Company = blc.GetCompanyB().Where(c => c.CompanyName == company.CompanyName).FirstOrDefault();
                        }
                        else
                        {
                            agent.Company = company;
                        }

                        if (blc.CreatAgentB(agent))
                        {
                            ResultText.Text = "جدید است";
                        }
                        else
                        {
                            ResultText.Text = "جدید نیست";
                        }
                        int IDforProduct = 0;
                        if (blc.CreateProductForBuyFactorB(product))
                        {
                            IDforProduct = product.id;
                        }
                        else
                        {
                            var q = from i in blc.GetProductsB() where i.Name == product.Name && i.Type == product.Type && i.Brand == product.Brand && i.AgentName == product.AgentName select i;
                            foreach (var item in q)
                            {
                                IDforProduct = item.id;
                            }
                        }
                        DGV.Rows.Add(IDforProduct, No, ProductName.Text.Trim(), ProductType.Text.Trim(), CompanyName.Text.Trim(), Tehdad.Value.ToString(), Convert.ToDouble(Price.Text).ToString("#,0"), (Convert.ToDouble(Fun.ChangeToEnglishNumber(Tehdad.Value.ToString())) * Convert.ToDouble(Fun.ChangeToEnglishNumber(Price.Text.ToString()))));
                        ProductName.Text = " ";
                        ProductName.Focus();
                        No++;
                        #endregion
                    }
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
                Fun.ClearTextBoxes(groupBox1.Controls);
                Fun.ClearTextBoxes(groupBox2.Controls);
                
                No = 1;
                if (AdminNumber.Text == "1")
                {
                    FactorCode.Text = blc.GetLastBuyFactorCodeA().ToString();
                    FactorNumber.Text = blc.GetLastBuyFactorNumberA().ToString();

                }
                else
                {
                    FactorCode.Text = blc.GetLastBuyFactorCodeB().ToString();
                    FactorNumber.Text = blc.GetLastBuyFactorNumberB().ToString();
                }
            }
            
        }
        
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            // حذف  اطلاعات
            if (AdminNumber.Text=="1")
            {
                AProduct product = blc.GetProductA(IDforDelete);
                if (Fun.ChangeToEnglishNumber(product.RegisterDate) == Fun.ChangeToEnglishNumber(DayDate.ToString()))
                {
                    // اگر تاریخ ثبت امروز بود حذف کن
                    blc.DeleteProductFromDBA(IDforDelete);
                    MessageBox.Show("حذف شد از دتابس");
                }
                else
                {
                    //  اگر تاریخ ثبت امروز نیست از دتا گرید تغیرات حذف کن
                    // تعداد خرید
                    // قیمت جدید
                    // از مجموعه قیمت کم کن
                    product.BuyCount -= int.Parse(DGV.Rows[index].Cells[5].Value.ToString());
                    product.Mojodi -= int.Parse(DGV.Rows[index].Cells[5].Value.ToString());
                    product.newBuyPrice = product.buyPrice;
                    product.Totalcash -= int.Parse(DGV.Rows[index].Cells[7].Value.ToString());
                    blc.SaveEditForBuyFactorProductA(product);
                    MessageBox.Show("تغییرات از دتابس حذف شد");
                }

            }
            else
            {
                BProduct product = blc.GetProductB(IDforDelete);
                if (Fun.ChangeToEnglishNumber(product.RegisterDate) == Fun.ChangeToEnglishNumber(DayDate.ToString()))
                {
                    // اگر تاریخ ثبت امروز بود حذف کن
                    blc.DeleteProductFromDBB(IDforDelete);
                    MessageBox.Show("حذف شد از دتابس");
                }
                else
                {
                    //  اگر تاریخ ثبت امروز نیست از دتا گرید تغیرات حذف کن
                    // تعداد خرید
                    // قیمت جدید
                    // از مجموعه قیمت کم کن
                    product.BuyCount -= int.Parse(DGV.Rows[index].Cells[5].Value.ToString());
                    product.Mojodi -= int.Parse(DGV.Rows[index].Cells[5].Value.ToString());
                    product.newBuyPrice = product.buyPrice;
                    product.Totalcash -= int.Parse(DGV.Rows[index].Cells[7].Value.ToString());
                    blc.SaveEditForBuyFactorProductB(product);
                    MessageBox.Show("تغییرات از دتابس حذف شد");
                }
            }

            DGV.Rows.RemoveAt(index);
            No = 1;
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                DGV.Rows[i].Cells[1].Value = No;
                No++;
            }
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                index = DGV.CurrentRow.Index;
                if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
                {
                    IDforDelete = int.Parse(DGV.SelectedCells[0].Value.ToString());
                }
            }
            catch
            {

            }
            //MessageBox.Show(index.ToString());
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            int totalfactor = 0;
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                totalfactor += int.Parse(DGV.Rows[i].Cells[7].Value.ToString());
            }
            TotalPriceFactor.Text = (totalfactor).ToString("#,0");
            groupBox1.Enabled = false;
            buttonX5.Enabled = true;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            //  تایید فاکتور و ثبت تمام تغییرات روی محصولات
            // تک تک ردیف ها بر اساس 
            if (AdminNumber.Text=="1")
            {
                #region CodeA
                ABuyFactor factor = new ABuyFactor();
                factor.FactorNumber = int.Parse(FactorNumber.Text);
                factor.FactorCode = int.Parse(FactorCode.Text);
                blc.CreateBuyFactorA(factor);
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    int ID = int.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                    AProduct product = blc.GetProductA(ID);
                    if (product.RegisterDate.Equals(Fun.ChangeToEnglishNumber(DayDate.Text)))
                    {
                        // خرید امروز و تغییرات نهایی درج شود
                        product.buyPrice = product.newBuyPrice = Convert.ToDouble(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[6].Value.ToString()));
                        product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[5].Value.ToString()));
                        product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[5].Value.ToString()));
                        product.Totalcash = Convert.ToDouble(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[7].Value.ToString()));
                        //MessageBox.Show("خرید جدید");
                    }
                    else
                    {
                        // خرید امروز به علاوه موجودیت قبل و ذخیره شود
                        product.buyPrice = product.newBuyPrice;
                        product.newBuyPrice = Convert.ToDouble(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[6].Value.ToString()));
                        product.Mojodi += int.Parse(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[5].Value.ToString()));
                        product.BuyCount += int.Parse(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[5].Value.ToString()));
                        product.Totalcash += Convert.ToDouble(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[7].Value.ToString()));
                        //MessageBox.Show("ویرایش");
                    }
                    product.aBuyFactor = factor;
                    blc.SaveEditForBuyFactorProductA(product);
                }
                #endregion
            }
            else
            {
                #region CodeB
                BBuyFactor factor = new BBuyFactor();
                factor.FactorNumber = int.Parse(FactorNumber.Text);
                factor.FactorCode = int.Parse(FactorCode.Text);
                blc.CreateBuyFactorB(factor);
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    int ID = int.Parse(DGV.Rows[i].Cells[0].Value.ToString());
                    BProduct product = blc.GetProductB(ID);
                    if (product.RegisterDate.Equals(Fun.ChangeToEnglishNumber(DayDate.Text)))
                    {
                        // خرید امروز و تغییرات نهایی درج شود
                        product.buyPrice = product.newBuyPrice = Convert.ToDouble(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[6].Value.ToString()));
                        product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[5].Value.ToString()));
                        product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[5].Value.ToString()));
                        product.Totalcash = Convert.ToDouble(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[7].Value.ToString()));
                        //MessageBox.Show("خرید جدید");
                    }
                    else
                    {
                        // خرید امروز به علاوه موجودیت قبل و ذخیره شود
                        product.buyPrice = product.newBuyPrice;
                        product.newBuyPrice = Convert.ToDouble(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[6].Value.ToString()));
                        product.Mojodi += int.Parse(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[5].Value.ToString()));
                        product.BuyCount += int.Parse(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[5].Value.ToString()));
                        product.Totalcash += Convert.ToDouble(Fun.ChangeToEnglishNumber(DGV.Rows[i].Cells[7].Value.ToString()));
                        //MessageBox.Show("ویرایش");
                    }
                    product.bBuyFactor = factor;
                    blc.SaveEditForBuyFactorProductB(product);
                }
                #endregion
            }

            buttonX4.Enabled = true;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonX5.Enabled = false;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (AdminNumber.Text=="1")
            {
                #region CodeA
                ABuyFactor factor = blc.GetBuyFactorA().Where(c => c.FactorCode.ToString() == Fun.ChangeToEnglishNumber(FactorCode.Text)).FirstOrDefault();
                factor.FactorNumber = int.Parse(Fun.ChangeToEnglishNumber(FactorNumber.Text));
                factor.FactorCode = int.Parse(Fun.ChangeToEnglishNumber(FactorCode.Text));
                factor.agent = blc.GetAgentA().Where(c => c.FullName == AgentName.Text).FirstOrDefault();
                factor.company = blc.GetCompanyA().Where(c => c.CompanyName == CompanyName.Text).FirstOrDefault();
                factor.RegisterDate = Fun.ChangeToEnglishNumber(DayDate.Text);
                factor.CashType = (CashType.Text) == "نقدی" ? 1 : 2;
                factor.TotalPrice = Convert.ToDouble(TotalPriceFactor.Text);
                factor.admin = blc.GetAdminsA().Where(c => c.Username == AdminName.Text).FirstOrDefault();
                String adminname = AdminName.Text;
                DGV.Rows.Clear();
                blc.SaveLastChangesOnBuyFacotrA(factor);
                Fun.ClearTextBoxes(groupBox1.Controls);
                Fun.ClearTextBoxes(groupBox2.Controls);
                buttonX4.Enabled = false;
                DayDate.Text = Fun.CLOCK();
                AdminName.Text = adminname;
                AgentName.Text = " ";
                CompanyName.Text = " ";
                TotalPriceFactor.Text = "۰۰۰,۰۰۰,۰۰۰";
                GetAgentName(AdminNumber.Text);
                GetCompanyName(AdminNumber.Text);
                GetLastFactorNumber(AdminNumber.Text);
                GetLastFactorCode(AdminNumber.Text);
                GetBrandProduct(AdminNumber.Text);
                buttonX5.Enabled = false;
                No = 1;
                #endregion
            }
            else
            {
                #region CodeB
                BBuyFactor factor = blc.GetBuyFactorB().Where(c => c.FactorCode.ToString() == Fun.ChangeToEnglishNumber(FactorCode.Text)).FirstOrDefault();
                factor.FactorNumber = int.Parse(Fun.ChangeToEnglishNumber(FactorNumber.Text));
                factor.FactorCode = int.Parse(Fun.ChangeToEnglishNumber(FactorCode.Text));
                factor.agent = blc.GetAgentB().Where(c => c.FullName == AgentName.Text).FirstOrDefault();
                factor.company = blc.GetCompanyB().Where(c => c.CompanyName == CompanyName.Text).FirstOrDefault();
                factor.RegisterDate = Fun.ChangeToEnglishNumber(DayDate.Text);
                factor.CashType = (CashType.Text) == "نقدی" ? 1 : 2;
                factor.TotalPrice = Convert.ToDouble(TotalPriceFactor.Text);
                factor.admin = blc.GetAdminsB().Where(c => c.Username == AdminName.Text).FirstOrDefault();
                String adminname = AdminName.Text;
                DGV.Rows.Clear();
                blc.SaveLastChangesOnBuyFacotrB(factor);
                Fun.ClearTextBoxes(groupBox1.Controls);
                Fun.ClearTextBoxes(groupBox2.Controls);
                buttonX4.Enabled = false;
                DayDate.Text = Fun.CLOCK();
                AdminName.Text = adminname;
                AgentName.Text = " ";
                CompanyName.Text = " ";
                TotalPriceFactor.Text = "۰۰۰,۰۰۰,۰۰۰";
                GetAgentName(AdminNumber.Text);
                GetCompanyName(AdminNumber.Text);
                GetLastFactorNumber(AdminNumber.Text);
                GetLastFactorCode(AdminNumber.Text);
                GetBrandProduct(AdminNumber.Text);
                buttonX5.Enabled = false;
                No = 1;
                #endregion
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                Price.Text = Int64.Parse(Price.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                Price.Select(Price.Text.Length, 0);
            }
            catch
            {

            }
        }

        private void SellPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                SellPrice.Text = Int64.Parse(SellPrice.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                SellPrice.Select(SellPrice.Text.Length, 0);
            }
            catch
            {

            }
        }
    }
}

