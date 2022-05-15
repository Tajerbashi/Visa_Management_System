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
using System.Data.SqlClient;
using BEE;
using BLL;
namespace StoreMarket_V1
{
    public partial class ProductControlForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public ProductControlForm()
        {
            InitializeComponent();
        }
        int TAP = 0;
        int ID = -1;
        bool SW = true;
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();

        #region ShowDataGrideView
        public void ShowAllProductDGV1(String Admin)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i =0;
            if (Admin == "1")
            {
                var DB = blc.ShowAllProductA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";

                    DGV1.Rows.Add(item.id,i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate,item.ExpireDate,Cash,item.AgentName,item.SellCount,item.BuyCount,item.Mojodi,item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id,i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate,item.ExpireDate,Cash,item.AgentName,item.SellCount,item.BuyCount,item.Mojodi,item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }
        public void ShowAllProductDGV2(String Admin)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowAllProductA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.ExpireDate,item.AgentName, Cash);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice, item.newBuyPrice, item.sellPrice, item.RegisterDate, item.ExpireDate, item.AgentName, Cash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }

        public void ShowAllMoneyProductDGV1(String Admin)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowAllMoneyProductA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = "نقدی" ;

                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowAllMoneyProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = "نقدی" ;
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }
        public void ShowAllBankiProductDGV1(String Admin)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowAllBankiProductA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";

                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowAllBankiProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }

        public void ShowAllProductALessN(int Number)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            var DB = blc.ShowAllProductALessN(Number);
            foreach (var item in DB)
            {
                i++;
                Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";

                DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
            }
        }
        public void ShowAllProductBLessN(int Number)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            var DB = blc.ShowAllProductBLessN(Number);
            foreach (var item in DB)
            {
                i++;
                Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
            }
        }

        public void ShowAllProductAGreatN(int Number)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            var DB = blc.ShowAllProductAGreatN(Number);
            foreach (var item in DB)
            {
                i++;
                Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";

                DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
            }
        }
        public void ShowAllProductBGreatN(int Number)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            var DB = blc.ShowAllProductBGreatN(Number);
            foreach (var item in DB)
            {
                i++;
                Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
            }
        }

        public void ShowSearchResultDGV1(String Admin,String Word)
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
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowSearchResultB(Word);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }
        public void ShowSearchResultDGV2(String Admin, String Word)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowSearchResultA(Word);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.ExpireDate,item.AgentName, Cash);

                }
            }
            else
            {
                var DB = blc.ShowSearchResultB(Word);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.ExpireDate,item.AgentName, Cash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }

        public void ShowResultDateNowExpireA(String Now,String Expire)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            var DB = blc.ShowResultDateNowExpireA(Now, Expire);
            if (DB == null)
            {
                MessageBox.Show("موردی یافت نشد","اطلاعیه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            
            NN8.Text = Fun.CLOCK();
        }
        public void ShowResultDateNowExpireB(String Now, String Expire)
        {
            String Cash;
            DGV1.Rows.Clear();
            int i = 0;
            var DB = blc.ShowResultDateNowExpireB(Now, Expire);
            if (DB == null)
            {
                MessageBox.Show("موردی یافت نشد", "اطلاعیه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
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

                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowProductOrderbyExpireDateB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }
        public void ShowProductOrderbyExpireDateDGV2(String Admin)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowProductOrderbyExpireDateA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";

                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice, item.newBuyPrice, item.sellPrice, item.RegisterDate, item.ExpireDate, item.AgentName, Cash);
                }
            }
            else
            {
                var DB = blc.ShowProductOrderbyExpireDateB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.ExpireDate,item.AgentName, Cash);
                }
            }
            NN8.Text = Fun.CLOCK();
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

                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowProductOrderbyMojodiB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.ExpireDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }
        public void ShowProductOrderbyMojodiDGV2(String Admin)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowProductOrderbyMojodiA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";

                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice, item.newBuyPrice, item.sellPrice, item.RegisterDate, item.ExpireDate, item.AgentName, Cash);
                }
            }
            else
            {
                var DB = blc.ShowProductOrderbyMojodiB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";

                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice, item.newBuyPrice, item.sellPrice, item.RegisterDate, item.ExpireDate, item.AgentName, Cash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }


        public void ShowAllAgentNameinComboBox(String ADMIN)
        {
            NN7.Items.Clear();
            if (ADMIN == "1")
            {
                var DB = blc.ShowAllAgentA();
                foreach (var item in DB)
                {
                    NN7.Items.Add(item.FullName);
                }
            }
            else
            {
                var DB = blc.ShowAllAgentB();
                foreach (var item in DB)
                {
                    NN7.Items.Add(item.FullName);
                }
            }
        }
        public void ColorFun()
        {
            var rand = new Random();
            Color c = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            Result.ForeColor = c;
        }
        #endregion

        #region CompleteCode
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

        private void ProductControlForm_Load_1(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllProductDGV2(ADMINNUMBER.Text);
            ShowAllAgentNameinComboBox(ADMINNUMBER.Text);
            GetBrandProduct(ADMINNUMBER.Text);
            NN1.Focus();
        }
        private void ProductControlForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("آیا میخواهید اطلاعات را ویرایش کنید؟", "تایید درخواست", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == DialogResult)
            {
                if (TAP == 0)
                {
                    NN1.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["name2"].Value.ToString();
                    NN2.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["type2"].Value.ToString();
                    NN3.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["many1"].Value.ToString();
                    NN4.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["buy2"].Value.ToString();
                    NN5.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["buyn1"].Value.ToString();
                    NN6.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["sell2"].Value.ToString();
                    NN7.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["agentname"].Value.ToString();
                    NN8.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["now"].Value.ToString();
                    ExpireDate.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["expire"].Value.ToString();
                    Savebtn.Text = "بروزرسانی";
                }
                SW = false;

            }

        }
        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("آیا میخواهید اطلاعات حذف شود؟؟؟","تایید درخواست",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            
            if (DialogResult==DialogResult.OK)
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
                ShowAllProductDGV2(ADMINNUMBER.Text);
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            ColorFun();
        }
        
        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        { 
            if (TAP == 0)
            {   //DGV2
                ShowSearchResultDGV2(ADMINNUMBER.Text, Searchtext.Text);
            }
            else
            {   //DGV1
                ShowSearchResultDGV1(ADMINNUMBER.Text, Searchtext.Text);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonX4_Click(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllProductDGV2(ADMINNUMBER.Text);
        }
        private void buttonX11_Click(object sender, EventArgs e)
        {
            // مرتب بر اساس تاریخ انقضاء
            ShowProductOrderbyExpireDateDGV1(ADMINNUMBER.Text);
            ShowProductOrderbyExpireDateDGV2(ADMINNUMBER.Text);
        }
        private void buttonX5_Click(object sender, EventArgs e)
        {
            // مرتب براساس موجودی
            ShowProductOrderbyMojodiDGV1(ADMINNUMBER.Text);
            ShowProductOrderbyMojodiDGV2(ADMINNUMBER.Text);
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            #region RegisterCode
            if (NN1.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام محصول را ذکر کنید";
                NN1.Focus();
            }
            else if (NN2.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نوع محصول را ذکر کنید";
                NN2.Focus();

            }
            else if (NN3.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تعداد خرید محصول را ذکر کنید";
                NN3.Focus();

            }
            else if (NN4.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت محصول را ذکر کنید";
                NN4.Focus();

            }
            else if (NN5.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت فروش محصول را ذکر کنید";
                NN5.Focus();

            }
            else if (NN6.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام نماینده فروش محصول را ذکر کنید";
                NN6.Focus();

            }
            else if (NN7.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام نماینده فروش را ذکر کنید";
                NN7.Focus();

            }
            else if (NN8.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تاریخ انقضاء محصول را ذکر کنید";
                NN8.Focus();

            }
            else if (Brand.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "برند محصول را ذکر کنید";
                Brand.Focus();
            }
            else if (!RR1.Checked && !RR2.Checked)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نوع پرداخت محصول را ذکر کنید";
                RR1.Focus();

            }
            else
            {
                try
                {
                    if (SW)
                    {   //  ثبت نام محصول
                        if (ADMINNUMBER.Text == "1")
                        {
                            AProduct product = new AProduct();
                            product.Name = NN1.Text;
                            product.Type = NN2.Text;
                            product.Brand = Brand.Text;
                            product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.Mojodi = product.BuyCount;
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                            product.AgentName = NN7.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                            product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
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
                            ShowAllProductDGV2(ADMINNUMBER.Text);
                        }
                        else
                        {
                            BProduct product = new BProduct();
                            product.Name = NN1.Text;
                            product.Type = NN2.Text;
                            product.Brand = Brand.Text;
                            product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.Mojodi = product.BuyCount;
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                            product.AgentName = NN7.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                            product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
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
                            ShowAllProductDGV2(ADMINNUMBER.Text);
                        }
                    }
                    else
                    {// ویرایش

                        MessageBoxForm MessageForm = new MessageBoxForm();
                        MessageForm.title.Text = "تایید نوعیت ویرایش اطلاعات";
                        MessageForm.Subject.Text = "ویرایش خود را انتخاب کنید و تایید کنید!";
                        MessageForm.RC1.Visible = true;
                        MessageForm.RC2.Visible = true;
                        MessageForm.ShowDialog();

                        if (MessageForm.Sw)
                        {
                            if (MessageForm.RC2.Checked)
                            {
                                #region EditCode

                                SW = true;

                                if (ADMINNUMBER.Text == "1")
                                {
                                    AProduct product = blc.GetProductA(ID);
                                    product.Name = NN1.Text;
                                    product.Type = NN2.Text;
                                    product.Brand = Brand.Text;
                                    product.BuyCount += int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                                    product.Mojodi += int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                                    product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                                    product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                                    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                                    product.AgentName = NN7.Text;
                                    product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                                    product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                                    product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                                    product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                                    product.Totalcash += product.newBuyPrice * product.BuyCount;

                                    if (!blc.ExistProductA(product))
                                    {
                                        blc.SaveEditProductA(product);
                                        Result.Text = "ویرایش شد";
                                        Savebtn.Text = "ذخیره";
                                        Fun.ClearTextBoxes(this.Controls);
                                        ShowAllProductDGV1(ADMINNUMBER.Text);
                                        ShowAllProductDGV2(ADMINNUMBER.Text);
                                    }
                                    else
                                    {
                                        Result.Text = " اطلاعات اشتباه یا تکراری است و ویرایش نشد";
                                    }

                                }
                                else
                                {
                                    BProduct product = blc.GetProductB(ID);
                                    product.Name = NN1.Text;
                                    product.Type = NN2.Text;
                                    product.Brand = Brand.Text;
                                    product.BuyCount += int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                                    product.Mojodi += int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                                    product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                                    product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                                    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                                    product.AgentName = NN7.Text;
                                    product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                                    product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                                    product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                                    product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                                    product.Totalcash += product.newBuyPrice * product.BuyCount;
                                    if (!blc.ExistProductB(product))
                                    {
                                        blc.SaveEditProductB(product);
                                        Result.Text = "ویرایش شد";
                                        Savebtn.Text = "ذخیره";
                                        Fun.ClearTextBoxes(this.Controls);
                                        ShowAllProductDGV1(ADMINNUMBER.Text);
                                        ShowAllProductDGV2(ADMINNUMBER.Text);
                                    }
                                    else
                                    {
                                        Result.Text = " اطلاعات اشتباه یا تکراری است و ویرایش نشد";
                                    }
                                }
                                #endregion
                            }
                            else
                            {
                                #region EditCode
                                SW = true;
                                if (ADMINNUMBER.Text == "1")
                                {
                                    AProduct product = blc.GetProductA(ID);
                                    product.Name = NN1.Text;
                                    product.Type = NN2.Text;
                                    product.Brand = Brand.Text;
                                    //product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                                    //product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                                    //product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                                    //product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                                    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                                    product.AgentName = NN7.Text;
                                    product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                                    product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                                    product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                                    product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                                    //product.Totalcash = product.newBuyPrice * product.BuyCount;

                                    if (!blc.ExistProductA(product))
                                    {
                                        blc.SaveEditProductA(product);
                                        Result.Text = "ویرایش شد";
                                        Savebtn.Text = "ذخیره";
                                        Fun.ClearTextBoxes(this.Controls);
                                        ShowAllProductDGV1(ADMINNUMBER.Text);
                                        ShowAllProductDGV2(ADMINNUMBER.Text);
                                    }
                                    else
                                    {
                                        Result.Text = " اطلاعات اشتباه یا تکراری است و ویرایش نشد";
                                    }
                                }
                                else
                                {
                                    BProduct product = blc.GetProductB(ID);
                                    product.Name = NN1.Text;
                                    product.Type = NN2.Text;
                                    product.Brand = Brand.Text;
                                    //product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                                    //product.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                                    //product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                                    //product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                                    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                                    product.AgentName = NN7.Text;
                                    product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                                    product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                                    product.ProduceDate = Fun.ChangeToEnglishNumber(ProduceDate.Text);
                                    product.ExpireDate = Fun.ChangeToEnglishNumber(ExpireDate.Text);
                                    //product.Totalcash = product.newBuyPrice * product.BuyCount;
                                    if (!blc.ExistProductB(product))
                                    {
                                        blc.SaveEditProductB(product);
                                        Result.Text = "ویرایش شد";
                                        Savebtn.Text = "ذخیره";
                                        Fun.ClearTextBoxes(this.Controls);
                                        ShowAllProductDGV1(ADMINNUMBER.Text);
                                        ShowAllProductDGV2(ADMINNUMBER.Text);
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
                }
                catch
                {
                    MessageBox.Show("اطلاعات درست نمی باشد", "خطا");
                }
            }
            #endregion

        }

        private void ShowTransection_Click(object sender, EventArgs e)
        {
            try
            {
                ControlTranSectionForm ctf = new ControlTranSectionForm();
                ctf.ADMINNUMBER.Text = ADMINNUMBER.Text;
                ctf.ADMINNAME.Text = ADMINNAME.Text;
                ctf.ShowDialog();
            }
            catch
            {
                MessageBox.Show("عدد مورد نظر را وارد کنید");
            }
        }

        private void MoneyCash_Click(object sender, EventArgs e)
        {
            // خرید نقدی
            ShowAllMoneyProductDGV1(ADMINNUMBER.Text);
        }

        private void BankiCash_Click(object sender, EventArgs e)
        {
            //  خرید بانکی
            ShowAllBankiProductDGV1(ADMINNUMBER.Text);
        }

        private void Greaterbtn_Click(object sender, EventArgs e)
        {
            // مانده بیشتر از
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    int Number = int.Parse(Fun.ChangeToEnglishNumber(GR.Text));
                    ShowAllProductAGreatN(Number);
                }
                else
                {
                    int Number = int.Parse(Fun.ChangeToEnglishNumber(GR.Text));
                    ShowAllProductBGreatN(Number);
                }
            }
            catch
            {
                MessageBox.Show("عدد وارد کنید");
            }
        }

        private void LessBtn_Click(object sender, EventArgs e)
        {
            // مانده کمتر از
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    int Number = int.Parse(Fun.ChangeToEnglishNumber(LS.Text));
                    ShowAllProductALessN(Number);
                }
                else
                {
                    int Number = int.Parse(Fun.ChangeToEnglishNumber(LS.Text));
                    ShowAllProductBLessN(Number);
                }
            }
            catch
            {
                MessageBox.Show("عدد وارد کنید");
            }
        }

        private void Expiredatebtn_Click(object sender, EventArgs e)
        {
            //  تاریخ انقضاء
            try
            {
                String Now = Fun.ChangeToEnglishNumber(NN8.Text);
                String Expire = Fun.ChangeToEnglishNumber(date.Text);
                //MessageBox.Show(NN8.Text +" : "+ Now +" : "+ Expire);

                if (ADMINNUMBER.Text == "1")
                {
                    ShowResultDateNowExpireA(Now, Expire);
                }
                else
                {
                    ShowResultDateNowExpireB(Now, Expire);
                }
            }
            catch
            {
                MessageBox.Show("عدد وارد کنید");
            }
        }

        private void nearExpire_Click(object sender, EventArgs e)
        {
            //  نزدیک انقضاء
            try
            {
                String Now = Fun.ChangeToEnglishNumber(NN8.Text);
                //MessageBox.Show(NN8.Text +" : "+ Now +" : "+ Expire);

                DateTime NowDate = Convert.ToDateTime(Now);
                //MessageBox.Show(NowDate.ToString("yyyy/MM/dd"));
                NowDate = NowDate.AddMonths(int.Parse(Fun.ChangeToEnglishNumber((Mounth.Text))));
                //MessageBox.Show(NowDate.ToString("yyyy/MM/dd"));
                Now = Fun.ChangeToEnglishNumber(NN8.Text);
                String Expire = NowDate.ToString();

                if (ADMINNUMBER.Text == "1")
                {
                    ShowResultDateNowExpireA(Now, Expire);
                }
                else
                {
                    ShowResultDateNowExpireB(Now, Expire);
                }
            }
            catch
            {
                MessageBox.Show("عدد مورد نظر را وارد کنید");
            }
        }

        private void tabControl1_SelectedTabChanged_1(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            TAP = tabControl1.SelectedTabIndex;
            //MessageBox.Show(TAP.ToString());
            switch (TAP)
            {
                case 0:
                    {
                        ShowAllProductDGV2(ADMINNUMBER.Text);
                        ShowAllAgentNameinComboBox(ADMINNUMBER.Text);
                        break;
                    }
                case 1:
                    {
                        ShowAllProductDGV1(ADMINNUMBER.Text);
                        break;
                    }
            }
        }

        private void DGV2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ID = int.Parse(DGV2.CurrentRow.Cells[0].Value.ToString());
                DGV2.CurrentRow.Selected = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
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

        private void NN4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void GR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

    }
}
