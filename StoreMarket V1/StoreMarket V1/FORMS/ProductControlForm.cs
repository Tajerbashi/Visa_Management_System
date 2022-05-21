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
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV1.Rows.Add(item.id,i, item.Name, item.Brand, item.Type, item.SellCount,item.BuyCount,item.Mojodi,item.buyPrice,item.newBuyPrice,item.sellPrice, item.Totalcash, item.RegisterDate,item.ProduceDate,item.ExpireDate,FactorCode,Cash,item.AgentName);
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
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
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
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            RegisterDate.Text = Fun.CLOCK();
        }

        public void ShowAllMoneyProductDGV2(String Admin)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowAllMoneyProductA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = "نقدی" ;
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            else
            {
                var DB = blc.ShowAllMoneyProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = "نقدی" ;
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            RegisterDate.Text = Fun.CLOCK();
        }
        public void ShowAllBankiProductDGV2(String Admin)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (Admin == "1")
            {
                var DB = blc.ShowAllBankiProductA();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            else
            {
                var DB = blc.ShowAllBankiProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            RegisterDate.Text = Fun.CLOCK();
        }

        public void ShowAllProductALessN(String Admin,int Number)
        {
            String Cash;
            int i = 0;
            DGV2.Rows.Clear();
            if (Admin=="1")
            {
                var DB = blc.ShowAllProductALessN(Number);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            else
            {
                var DB = blc.ShowAllProductBLessN(Number);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
        }
        public void ShowAllProductAGreatN(String Admin,int Number)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (Admin=="1")
            {
                var DB = blc.ShowAllProductAGreatN(Number);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            else
            {
                var DB = blc.ShowAllProductBGreatN(Number);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
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
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
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
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
            RegisterDate.Text = Fun.CLOCK();
        }

        public void ShowResultDateNowExpireDGV2(String Now,String Expire)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (ADMINNUMBER.Text=="1")
            {
                var DB = blc.ShowResultDateNowExpireA(Now, Expire);
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
                        int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                        DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                    }
                }
            }
            else
            {
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
                        int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                        DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                    }
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
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
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
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
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
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
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
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
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

        private void ProductControlForm_Load_1(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllProductDGV2(ADMINNUMBER.Text);
            ShowAllAgentNameinComboBox(ADMINNUMBER.Text);
            GetBrandProduct(ADMINNUMBER.Text);
            ProductName.Focus();
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
                    ProductName.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C3"].Value.ToString();
                    TypeProduct.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C5"].Value.ToString();
                    BrandProduct.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["C4"].Value.ToString();
                    //AgentName.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells["17"].Value.ToString();
                    
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
            ShowAllMoneyProductDGV2(ADMINNUMBER.Text);
        }
        private void BankiCash_Click(object sender, EventArgs e)
        {
            //  خرید بانکی
            ShowAllBankiProductDGV2(ADMINNUMBER.Text);
        }
        private void Greaterbtn_Click(object sender, EventArgs e)
        {
            // مانده بیشتر از
            try
            {
                int Number = int.Parse(Fun.ChangeToEnglishNumber(GR.Text));
                ShowAllProductAGreatN(ADMINNUMBER.Text, Number);
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
                int Number = int.Parse(Fun.ChangeToEnglishNumber(LS.Text));
                ShowAllProductALessN(ADMINNUMBER.Text,Number);
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
                String Now = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                String Expire = Fun.ChangeToEnglishNumber(date.Text);
                //MessageBox.Show(NN8.Text +" : "+ Now +" : "+ Expire);
                ShowResultDateNowExpireDGV2(Now, Expire);
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
                String Now = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                //MessageBox.Show(NN8.Text +" : "+ Now +" : "+ Expire);

                DateTime NowDate = Convert.ToDateTime(Now);
                //MessageBox.Show(NowDate.ToString("yyyy/MM/dd"));
                NowDate = NowDate.AddMonths(int.Parse(Fun.ChangeToEnglishNumber((Mounth.Text))));
                //MessageBox.Show(NowDate.ToString("yyyy/MM/dd"));
                Now = Fun.ChangeToEnglishNumber(RegisterDate.Text);
                String Expire = NowDate.ToString();
                ShowResultDateNowExpireDGV2(Now, Expire);
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
        
        private void GR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

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

        private void NewBuyPrice_KeyPress(object sender, KeyPressEventArgs e)
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
                        ShowAllProductDGV2(ADMINNUMBER.Text);
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
                        ShowAllProductDGV2(ADMINNUMBER.Text);
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
                                    ShowAllProductDGV2(ADMINNUMBER.Text);
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
                            SW = true;
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
                                    Result.Text = "ویرایش شد";
                                    buttonX1.Text = "ذخیره";
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
                #endregion
            }
            #endregion

        }
    }
}
