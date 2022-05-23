using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEE;
using BLL;
namespace StoreMarket_V1
{
    public partial class InventoryPanel : UserControl
    {
        public InventoryPanel()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        int TAP = 0;
        int ID = -1;
        bool SW = true;

        #region ShowDataIn DGV
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
                    Cash = "نقدی";
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
                    Cash = "نقدی";
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    DGV2.Rows.Add(item.id, i, item.Name, item.Brand, item.Type, item.SellCount, item.BuyCount, item.Mojodi, item.buyPrice, item.newBuyPrice, item.sellPrice, item.Totalcash, item.RegisterDate, item.ProduceDate, item.ExpireDate, FactorCode, Cash, item.AgentName);
                }
            }
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
        }

        public void ShowAllProductALessN(String Admin, int Number)
        {
            String Cash;
            int i = 0;
            DGV2.Rows.Clear();
            if (Admin == "1")
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
        public void ShowAllProductAGreatN(String Admin, int Number)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (Admin == "1")
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
        }

        public void ShowResultDateNowExpireDGV2(String Now, String Expire)
        {
            String Cash;
            DGV2.Rows.Clear();
            int i = 0;
            if (ADMINNUMBER.Text == "1")
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
        }


        #endregion


        private void MoneyCash_Click(object sender, EventArgs e)
        {
            // خرید نقدی
            ShowAllMoneyProductDGV2(ADMINNUMBER.Text);
        }
       
        private void InventoryPanel_Load(object sender, EventArgs e)
        {
            ShowAllProductDGV2(ADMINNUMBER.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowSearchResultDGV2(ADMINNUMBER.Text, Searchtext.Text);
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            ShowAllProductDGV2(ADMINNUMBER.Text);
        }

        private void ExpDbtn_Click(object sender, EventArgs e)
        {
            ShowProductOrderbyExpireDateDGV2(ADMINNUMBER.Text);

        }

        private void Mojodibtn_Click(object sender, EventArgs e)
        {
            ShowProductOrderbyMojodiDGV2(ADMINNUMBER.Text);
        }

        private void GR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void حذفمحصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxForm message = new MessageBoxForm();
            message.title.Text = "تایید درخواست";
            message.Subject.Text = "آیا میخواهید اطلاعات حذف شود؟؟؟";
            message.warning.Visible = true;

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
                ShowAllProductDGV2(ADMINNUMBER.Text);
            }
        }

        private void Greaterbtn_Click_1(object sender, EventArgs e)
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

        private void BankiCash_Click_1(object sender, EventArgs e)
        {
            //  خرید بانکی
            ShowAllBankiProductDGV2(ADMINNUMBER.Text);
        }

        private void LessBtn_Click_1(object sender, EventArgs e)
        {
            // مانده کمتر از
            try
            {
                int Number = int.Parse(Fun.ChangeToEnglishNumber(LS.Text));
                ShowAllProductALessN(ADMINNUMBER.Text, Number);
            }
            catch
            {
                MessageBox.Show("عدد وارد کنید");
            }
        }

        private void Expiredatebtn_Click_1(object sender, EventArgs e)
        {
            //  تاریخ انقضاء
            try
            {
                String Now = Fun.ChangeToEnglishNumber(Fun.CLOCK());
                String Expire = Fun.ChangeToEnglishNumber(date.Text);
                //MessageBox.Show(NN8.Text +" : "+ Now +" : "+ Expire);
                ShowResultDateNowExpireDGV2(Now, Expire);
            }
            catch
            {
                MessageBox.Show("عدد وارد کنید");
            }
        }

        private void nearExpire_Click_1(object sender, EventArgs e)
        {
            //  نزدیک انقضاء
            try
            {
                String Now = Fun.ChangeToEnglishNumber(Fun.CLOCK());
                //MessageBox.Show(NN8.Text +" : "+ Now +" : "+ Expire);

                DateTime NowDate = Convert.ToDateTime(Now);
                //MessageBox.Show(NowDate.ToString("yyyy/MM/dd"));
                NowDate = NowDate.AddMonths(int.Parse(Fun.ChangeToEnglishNumber((Mounth.Text))));
                //MessageBox.Show(NowDate.ToString("yyyy/MM/dd"));
                Now = Fun.ChangeToEnglishNumber(Fun.CLOCK());
                String Expire = NowDate.ToString();
                ShowResultDateNowExpireDGV2(Now, Expire);
            }
            catch
            {
                MessageBox.Show("عدد مورد نظر را وارد کنید");
            }
        }

    }
}
