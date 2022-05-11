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

                    DGV1.Rows.Add(item.id,i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate,item.EndDate,Cash,item.AgentName,item.SellCount,item.BuyCount,item.Mojodi,item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id,i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate,item.EndDate,Cash,item.AgentName,item.SellCount,item.BuyCount,item.Mojodi,item.Totalcash);
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
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.EndDate,item.AgentName, Cash);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice, item.newBuyPrice, item.sellPrice, item.RegisterDate, item.EndDate, item.AgentName, Cash);
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
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";

                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowAllMoneyProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
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

                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowAllBankiProductB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
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

                DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
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
                DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
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

                DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
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
                DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
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
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowSearchResultB(Word);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
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
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.EndDate,item.AgentName, Cash);

                }
            }
            else
            {
                var DB = blc.ShowSearchResultB(Word);
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id, i, item.Mojodi, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.EndDate,item.AgentName, Cash);
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
                MessageBox.Show("موردی یافت نشد");
            }
            else
            {
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
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
                MessageBox.Show("موردی یافت نشد");
            }
            else
            {
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }

        public void ShowProductOrderbyExpireDate(String Admin)
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

                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            else
            {
                var DB = blc.ShowProductOrderbyExpireDateB();
                foreach (var item in DB)
                {
                    i++;
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, i, item.Name, item.Type, item.newBuyPrice, item.RegisterDate, item.EndDate, Cash, item.AgentName, item.SellCount, item.BuyCount, item.Mojodi, item.Totalcash);
                }
            }
            NN8.Text = Fun.CLOCK();
        }

        public void ColorFun()
        {
            var rand = new Random();
            Color c = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            Result.ForeColor = c;
        }


        #endregion

        #region CompleteCode
        public void AddagentName(String Admin)
        {
            NN7.Items.Clear();
            if (Admin == "1")
            {
                var DD = blc.GetAgentNameA();
                foreach (var item in DD)
                {
                    String name = item.FullName;
                    NN7.Items.Add(name);
                }
            }
            else
            {
                var DD = blc.GetAgentNameB();
                foreach (var item in DD)
                {
                    String name = item.FullName;
                    NN7.Items.Add(name);
                }
            }
        }
        private void ProductControlForm_Load_1(object sender, EventArgs e)
        {
            buttonX4.Enabled = false;
            buttonX5.Enabled = false;
            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllProductDGV2(ADMINNUMBER.Text);
            AddagentName(ADMINNUMBER.Text);
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
                    NN9.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells["expire"].Value.ToString();
                    button8.Text = "بروزرسانی";
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
        private void button8_Click_1(object sender, EventArgs e)
        {
            #region RegisterCode
            if (NN1.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام محصول را ذکر کنید";
            }
            else if (NN2.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نوع محصول را ذکر کنید";
            }
            else if (NN3.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تعداد خرید محصول را ذکر کنید";
            }
            else if (NN4.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت محصول را ذکر کنید";
            }
            else if (NN5.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت فروش محصول را ذکر کنید";
            }
            else if (NN6.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام نماینده فروش محصول را ذکر کنید";
            }
            else if (NN7.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تاریخ خرید محصول را ذکر کنید";
            }
            else if (NN8.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تاریخ انقضاء محصول را ذکر کنید";
            }
            else if (!RR1.Checked && !RR2.Checked)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نوع خرید محصول را ذکر کنید";
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
                            product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.Mojodi = product.BuyCount;
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                            product.AgentName = NN7.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(NN9.Text);
                            product.Totalcash = product.newBuyPrice * product.BuyCount;

                            if (blc.CreateProductA(product))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "محصول با موفقیت ثبت شد";
                                Fun.ClearTextBoxes(this.Controls);
                                ShowAllProductDGV1(ADMINNUMBER.Text);
                                ShowAllProductDGV2(ADMINNUMBER.Text);
                            }
                            else
                            {
                                Result.ForeColor = Color.Red;
                                Result.Text = "ثبت محصول ناموفق بود";
                            }
                        }
                        else
                        {
                            BProduct product = new BProduct();
                            product.Name = NN1.Text;
                            product.Type = NN2.Text;
                            product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.Mojodi = product.BuyCount;
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                            product.AgentName = NN7.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(NN9.Text);
                            product.Totalcash = product.newBuyPrice * product.BuyCount;

                            if (blc.CreateProductB(product))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "محصول با موفقیت ثبت شد";
                                Fun.ClearTextBoxes(this.Controls);
                                ShowAllProductDGV1(ADMINNUMBER.Text);
                                ShowAllProductDGV2(ADMINNUMBER.Text);
                            }
                            else
                            {
                                Result.ForeColor = Color.Red;
                                Result.Text = "ثبت محصول ناموفق بود";
                            }
                        }
                    }
                    else
                    {// ویرایش
                        SW = true;
                        if (ADMINNUMBER.Text == "1")
                        {
                            AProduct product = blc.GetProductA(ID);
                            product.Name = NN1.Text;
                            product.Type = NN2.Text;
                            product.BuyCount += int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.Mojodi += int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                            product.AgentName = NN7.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(NN9.Text);
                            product.Totalcash += product.newBuyPrice * product.BuyCount;

                            if (!blc.ExistProductA(product))
                            {
                                blc.SaveEditProductA(product);
                                Result.Text = "ویرایش شد";
                                Fun.ClearTextBoxes(this.Controls);
                                ShowAllProductDGV1(ADMINNUMBER.Text);
                                ShowAllProductDGV2(ADMINNUMBER.Text);
                                button8.Text = "ذخیره";
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
                            product.BuyCount += int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.Mojodi += int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                            product.AgentName = NN7.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(NN9.Text);
                            product.Totalcash += product.newBuyPrice * product.BuyCount;
                            if (!blc.ExistProductB(product))
                            {
                                blc.SaveEditProductB(product);
                                Result.Text = "ویرایش شد";
                                button8.Text = "ذخیره";
                                Fun.ClearTextBoxes(this.Controls);
                                ShowAllProductDGV1(ADMINNUMBER.Text);
                                ShowAllProductDGV2(ADMINNUMBER.Text);
                            }
                            else
                            {
                                Result.Text = " اطلاعات اشتباه یا تکراری است و ویرایش نشد";
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
        private void button9_Click_1(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllProductDGV2(ADMINNUMBER.Text);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ColorFun();
        }
        private void DGV2_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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
        private void DGV1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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
        private void NN3_KeyPress(object sender, KeyPressEventArgs e)
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
        private void N4_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {

            TAP = tabControl1.SelectedTabIndex;
            //MessageBox.Show(TAP.ToString());
            switch (TAP)
            {
                case 0:
                    {
                        AddagentName(ADMINNUMBER.Text);
                        buttonX4.Enabled = false;
                        buttonX5.Enabled = false;
                        ShowAllProductDGV2(ADMINNUMBER.Text);
                        break;
                    }
                case 1:
                    {
                        buttonX4.Enabled = true;
                        buttonX5.Enabled = true;
                        ShowAllProductDGV1(ADMINNUMBER.Text);
                        break;
                    }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllMoneyProductDGV1(ADMINNUMBER.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ShowAllBankiProductDGV1(ADMINNUMBER.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
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
            } catch
            {
                MessageBox.Show("عدد وارد کنید");
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
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
        private void button5_Click(object sender, EventArgs e)
        {
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
        private void buttonX4_Click(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
        }
        private void button6_Click(object sender, EventArgs e)
        {
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
        private void GR_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void buttonX5_Click(object sender, EventArgs e)
        {
            ShowProductOrderbyExpireDate(ADMINNUMBER.Text);
        }
        private void buttonX10_Click(object sender, EventArgs e)
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
        private void buttonX11_Click(object sender, EventArgs e)
        {
            AddagentName(ADMINNUMBER.Text);
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
    }
}
