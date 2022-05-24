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
    public partial class ProductPanelControl : UserControl
    {
        public ProductPanelControl()
        {
            InitializeComponent();
        }
        int TAP = 1;
        int ID = -1;
        bool SW = true;
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();
        #region ShowDataGrideView
        public void ShowAllProductDGV1(String Admin)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowAllProductA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV1.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV1.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            RegisterDate.Text = Fun.CLOCK();
        }
        public void ShowSearchResultDGV1(String Admin, String Word)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowSearchResultA(Word);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV1.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            else
            {
                var DB = blc.ShowSearchResultB(Word);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV1.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            RegisterDate.Text = Fun.CLOCK();
        }
        public void ShowProductOrderbyExpireDateDGV1(String Admin)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowProductOrderbyExpireDateA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV1.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            else
            {
                var DB = blc.ShowProductOrderbyExpireDateB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV1.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            RegisterDate.Text = Fun.CLOCK();
        }
        public void ShowProductOrderbyMojodiDGV1(String Admin)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowProductOrderbyMojodiA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV1.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            else
            {
                var DB = blc.ShowProductOrderbyMojodiB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV1.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            RegisterDate.Text = Fun.CLOCK();
        }
        public void ShowAllAgentNameinComboBox(String ADMIN)
        {
            AgentName.Items.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllAgentA();
                foreach (var item in DB)
                {
                    AgentName.Items.Add(item.FullName);
                }
            }
            else
            {
                var DB = blc.ShowAllAgentB();
                foreach (var item in DB)
                {
                    AgentName.Items.Add(item.FullName);
                }
            }
        }
        public void GetBrandProduct(String Admin)
        {
            BrandProduct.Items.Clear();
            if (Admin == "1")
            {
                var q = from i in blc.GetProductsA() select i.Brand;
                var q1 = q.Distinct();
                foreach (var item in q1)
                {
                    BrandProduct.Items.Add(item);
                }
            }
            else
            {
                var q = from i in blc.GetProductsB() select i.Brand;
                var q1 = q.Distinct();
                foreach (var item in q1)
                {
                    BrandProduct.Items.Add(item);
                }
            }
        }

        //public void ColorFun()
        //{
        //    var rand = new Random();
        //    Color c = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        //    Result.ForeColor = c;
        //}
        #endregion

        private void ProductPanelControl_Load(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllAgentNameinComboBox(ADMINNUMBER.Text);
            GetBrandProduct(ADMINNUMBER.Text);
            ProductName.Focus();
            TAP = 1;
        }

        private void ویرایشمحصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SW = false;

            ProductName.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C3"].Value.ToString();
            TypeProduct.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C5"].Value.ToString();
            BrandProduct.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C4"].Value.ToString();
            AgentName.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C17"].Value.ToString();

            BuyPrice.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C9"].Value.ToString();
            NewBuyPrice.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C10"].Value.ToString();
            SellPrice.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C11"].Value.ToString();
            TotalPrice.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C18"].Value.ToString();

            SellCount.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C6"].Value.ToString();
            BuyCount.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C7"].Value.ToString();
            Mojodi.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C8"].Value.ToString();
            //  CashType

            RegisterDate.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C12"].Value.ToString();
            ProduceDate.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C13"].Value.ToString();
            ExpireDate.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C14"].Value.ToString();

            buttonX1.Text = "بروزرسانی";

            #region Comment
            //MessageBoxForm message = new MessageBoxForm();
            //message.title.Text = "تایید درخواست";
            //message.Subject.Text = "آیا میخواهید اطلاعات را ویرایش کنید؟";
            //message.warning.Visible = true;

            //if (message.Sw)
            //{
            //    if (TAP == 0)
            //    {
                    
            //    }
            //    SW = false;

            //}
            #endregion
        }

        private void حذفمحصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxForm message = new MessageBoxForm();
            message.title.Text = "تایید درخواست";
            message.Subject.Location = new Point(112, 53);
            message.Subject.Text = "آیا میخواهید اطلاعات حذف شود؟؟؟";
            message.error.Visible = true;
            message.ShowDialog();
            if (message.Sw)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    blc.DeleteProductA(ID);
                }
                else
                {
                    blc.DeleteProductB(ID);
                }
                ShowAllProductDGV1(ADMINNUMBER.Text);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            TAP++;
            if (TAP%2==0)
            {
                panelEx1.Visible = true;
            }
            else
            {
                panelEx1.Visible = false;
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            ShowSearchResultDGV1(ADMINNUMBER.Text, Searchtext.Text);

        }

        private void Tools_Click(object sender, EventArgs e)
        {
            TAP++;
            if (TAP % 2 == 0)
            {
                panelEx2.Visible = true;
            }
            else
            {
                panelEx2.Visible = false;
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            // مرتب بر اساس تاریخ انقضاء
            ShowProductOrderbyExpireDateDGV1(ADMINNUMBER.Text);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            // مرتب براساس موجودی
            ShowProductOrderbyMojodiDGV1(ADMINNUMBER.Text);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            #region RegisterCode
            if (ProductName.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام محصول را ذکر کنید";
                ProductName.Focus();
            }
            else if (TypeProduct.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نوع محصول را ذکر کنید";
                TypeProduct.Focus();

            }
            else if (BrandProduct.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "برند محصول را ذکر کنید";
                BrandProduct.Focus();

            }
            else if (AgentName.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام نماینده را ذکر کنید";
                AgentName.Focus();

            }
            else if (BuyPrice.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت خرید را ذکر کنید";
                BuyPrice.Focus();

            }
            else if (NewBuyPrice.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت جدید محصول را ذکر کنید";
                NewBuyPrice.Focus();

            }
            else if (SellPrice.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت فروش محصول را ذکر کنید";
                SellPrice.Focus();

            }
            else if (TotalPrice.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت کل محصول را ذکر کنید";
                TotalPrice.Focus();

            }
            else if (SellCount.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تعداد فروش را ذکر کنید";
                SellCount.Focus();

            }
            else if (BuyCount.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تعداد خرید را ذکر کنید";
                BuyCount.Focus();

            }
            else if (Mojodi.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تعداد موجود را ذکر کنید";
                Mojodi.Focus();

            }
            else if (!RR1.Checked && !RR2.Checked)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نوع پرداخت محصول را ذکر کنید";
                RR1.Focus();

            }
            else if (RegisterDate.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تاریخ خرید محصول را ذکر کنید";
                RegisterDate.Focus();

            }
            else if (ProduceDate.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تاریخ تولید محصول را ذکر کنید";
                ProduceDate.Focus();
            }
            else if (ExpireDate.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تاریخ انقضاء محصول را ذکر کنید";
                ExpireDate.Focus();
            }
            else
            {
                #region SaveNew
                if (SW)
                {   //  ثبت نام محصول
                    if (ADMINNUMBER.Text == "1")
                    {
                        AProduct product = new AProduct();
                        product.Name = ProductName.Text;
                        product.Type = TypeProduct.Text;
                        product.Brand = BrandProduct.Text;
                        product.SellCount = int.Parse(Fun.ChangeToEnglishNumber(SellCount.Text));
                        product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(BuyCount.Text));
                        product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(Mojodi.Text));
                        product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(BuyPrice.Text));
                        product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NewBuyPrice.Text));
                        product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(SellPrice.Text));
                        product.RegisterDate = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                        product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                        product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                        product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                        product.AgentName = AgentName.Text;
                        product.Totalcash = product.newBuyPrice * product.BuyCount;

                        if (blc.CreateProductA(product))
                        {
                            Result.ForeColor = Color.Green;
                            Result.Text = "محصول با موفقیت ثبت شد";

                        }
                        else
                        {
                            Result.ForeColor = Color.Red;
                            Result.Text = "محصول موجود بود و اطلاعات بروزرسانی شد";
                        }
                        Fun.ClearTextBoxes(this.Controls);
                        ShowAllProductDGV1(ADMINNUMBER.Text);
                    }
                    else
                    {
                        BProduct product = new BProduct();
                        product.Name = ProductName.Text;
                        product.Type = TypeProduct.Text;
                        product.Brand = BrandProduct.Text;
                        product.SellCount = int.Parse(Fun.ChangeToEnglishNumber(SellCount.Text));
                        product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(BuyCount.Text));
                        product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(Mojodi.Text));
                        product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(BuyPrice.Text));
                        product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NewBuyPrice.Text));
                        product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(SellPrice.Text));
                        product.RegisterDate = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                        product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                        product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                        product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                        product.AgentName = AgentName.Text;
                        product.Totalcash = product.newBuyPrice * product.BuyCount;

                        if (blc.CreateProductB(product))
                        {
                            Result.ForeColor = Color.Green;
                            Result.Text = "محصول با موفقیت ثبت شد";

                        }
                        else
                        {
                            Result.ForeColor = Color.Red;
                            Result.Text = "محصول موجود بود و اطلاعات بروزرسانی شد";
                        }
                        Fun.ClearTextBoxes(this.Controls);
                        ShowAllProductDGV1(ADMINNUMBER.Text);
                    }
                }
                #endregion
                #region EditCode
                else
                {// ویرایش

                    MessageBoxForm MessageForm = new MessageBoxForm();
                    MessageForm.title.Text = "تایید نوعیت ویرایش اطلاعات";
                    MessageForm.Subject.Text = "ویرایش خود را انتخاب کنید و تایید کنید!";
                    MessageForm.Subject.Location = new Point(114, 48);
                    MessageForm.question.Visible = true;
                    MessageForm.RC1.Visible = true;
                    MessageForm.RC2.Visible = true;
                    MessageForm.ShowDialog();

                    if (MessageForm.Sw)
                    {
                        //  ویرایش اطلاعات کامل در دتابس اجرا ذخیره میشود
                        if (MessageForm.RC2.Checked)
                        {
                            #region EditCode

                            SW = true;

                            if (ADMINNUMBER.Text == "1")
                            {
                                AProduct product = blc.GetProductA(ID);
                                product.Name = ProductName.Text;
                                product.Type = TypeProduct.Text;
                                product.Brand = BrandProduct.Text;
                                product.SellCount = int.Parse(Fun.ChangeToEnglishNumber(SellCount.Text));
                                product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(BuyCount.Text));
                                product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(Mojodi.Text));
                                product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(BuyPrice.Text));
                                product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NewBuyPrice.Text));
                                product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(SellPrice.Text));
                                product.RegisterDate = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                                product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                                product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                                product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                                //product.AgentName = AgentName.Text;
                                product.Totalcash = product.newBuyPrice * product.BuyCount;

                                if (!blc.ExistProductA(product))
                                {
                                    blc.SaveEditProductForControlProductFormA(product, ID);
                                    Result.Text = "ویرایش شد";
                                    buttonX1.Text = "ذخیره";
                                    Fun.ClearTextBoxes(this.Controls);
                                    ShowAllProductDGV1(ADMINNUMBER.Text);
                                    SW = true;
                                }
                                else
                                {
                                    Result.Text = " اطلاعات اشتباه یا تکراری است و ویرایش نشد";
                                }

                            }
                            else
                            {
                                BProduct product = blc.GetProductB(ID);
                                product.Name = ProductName.Text;
                                product.Type = TypeProduct.Text;
                                product.Brand = BrandProduct.Text;
                                product.SellCount = int.Parse(Fun.ChangeToEnglishNumber(SellCount.Text));
                                product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(BuyCount.Text));
                                product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(Mojodi.Text));
                                product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(BuyPrice.Text));
                                product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NewBuyPrice.Text));
                                product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(SellPrice.Text));
                                product.RegisterDate = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                                product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                                product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                                product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                                //product.AgentName = AgentName.Text;
                                product.Totalcash = product.newBuyPrice * product.BuyCount;

                                if (!blc.ExistProductB(product))
                                {
                                    blc.SaveEditProductForControlProductFormB(product, ID);
                                    Result.Text = "ویرایش شد";
                                    buttonX1.Text = "ذخیره";
                                    Fun.ClearTextBoxes(this.Controls);
                                    ShowAllProductDGV1(ADMINNUMBER.Text);
                                    SW = true;
                                }
                                else
                                {
                                    Result.Text = " اطلاعات اشتباه یا تکراری است و ویرایش نشد";
                                }
                            }
                            #endregion
                        }
                        //  ویرایش اطلاعات فقط نوشتاری است و در دتابس اجرا ذخیره میشود
                        else
                        {
                            #region EditCode
                            if (ADMINNUMBER.Text == "1")
                            {
                                AProduct product = blc.GetProductA(ID);
                                product.Name = ProductName.Text;
                                product.Type = TypeProduct.Text;
                                product.Brand = BrandProduct.Text;
                                //product.SellCount = int.Parse(Fun.ChangeToEnglishNumber(SellCount.Text));
                                //product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(BuyCount.Text));
                                //product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(Mojodi.Text));
                                //product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(BuyPrice.Text));
                                //product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NewBuyPrice.Text));
                                //product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(SellPrice.Text));
                                //product.RegisterDate = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                                product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                                product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                                product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                                //product.AgentName = AgentName.Text;
                                //product.Totalcash = product.newBuyPrice * product.BuyCount;

                                if (!blc.ExistProductA(product))
                                {
                                    blc.SaveEditProductForControlProductFormA(product, ID);
                                    Result.Text = "ویرایش شد";
                                    buttonX1.Text = "ذخیره";
                                    Fun.ClearTextBoxes(this.Controls);
                                    ShowAllProductDGV1(ADMINNUMBER.Text);
                                    SW = true;
                                }
                                else
                                {
                                    Result.Text = " اطلاعات اشتباه یا تکراری است و ویرایش نشد";
                                }
                            }
                            else
                            {
                                BProduct product = blc.GetProductB(ID);
                                product.Name = ProductName.Text;
                                product.Type = TypeProduct.Text;
                                product.Brand = BrandProduct.Text;
                                //product.SellCount = int.Parse(Fun.ChangeToEnglishNumber(SellCount.Text));
                                //product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(BuyCount.Text));
                                //product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(Mojodi.Text));
                                //product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(BuyPrice.Text));
                                //product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NewBuyPrice.Text));
                                //product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(SellPrice.Text));
                                //product.RegisterDate = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                                product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                                product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                                product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                                //product.AgentName = AgentName.Text;
                                //product.Totalcash = product.newBuyPrice * product.BuyCount;

                                if (!blc.ExistProductB(product))
                                {
                                    blc.SaveEditProductForControlProductFormB(product, ID);
                                    buttonX1.Text = "ذخیره";
                                    Fun.ClearTextBoxes(this.Controls);
                                    ShowAllProductDGV1(ADMINNUMBER.Text);
                                    SW = true;
                                }
                                else
                                {
                                    Result.Text = " اطلاعات اشتباه یا تکراری است و ویرایش نشد";
                                }
                            }
                            #endregion
                        }
                    }
                }
                #endregion
            }
            #endregion

            ShowAllAgentNameinComboBox(ADMINNUMBER.Text);
        }

        private void BuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());

                DGV1.CurrentRow.Selected = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

    }
}
