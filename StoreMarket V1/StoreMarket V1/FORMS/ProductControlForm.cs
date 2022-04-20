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
            if (Admin == "1")
            {
                var DB = blc.ShowAllProductA();
                foreach (var item in DB)
                {
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, item.Name, item.Type, item.buyPrice, item.sellPrice,item.Mojodi,item.SellCount,item.BuyCount, Cash);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, item.Name, item.Type, item.buyPrice, item.sellPrice,item.Mojodi,item.SellCount,item.BuyCount, Cash);
                }
            }
            N9.Text = Fun.CLOCK();
            NN8.Text = Fun.CLOCK();
        }
        public void ShowAllProductDGV2(String Admin)
        {
            String Cash;
            DGV2.Rows.Clear();
            if (Admin == "1")
            {
                var DB = blc.ShowAllProductA();
                foreach (var item in DB)
                {
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id,item.BuyCount, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.EndDate,item.AgentName, Cash);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id, item.BuyCount, item.Name, item.Type, item.buyPrice, item.newBuyPrice, item.sellPrice, item.RegisterDate, item.EndDate, item.AgentName, Cash);
                }
            }
            N9.Text = Fun.CLOCK();
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
        
        private void ProductControlForm_Load_1(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllProductDGV2(ADMINNUMBER.Text);
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
                }
                else if (TAP == 2)
                {
                    N1.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["name"].Value.ToString();
                    N2.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["type"].Value.ToString();
                    N3.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["Column1"].Value.ToString();
                    N4.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["buy"].Value.ToString();
                    N5.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["sell"].Value.ToString();
                    N6.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["sell2"].Value.ToString();
                    N7.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["sell2"].Value.ToString();
                    N8.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["sell2"].Value.ToString();
                    N9.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["agentname"].Value.ToString();
                    N10.Text = DGV2.Rows[DGV1.CurrentRow.Index].Cells["now"].Value.ToString();
                }

                SW = false;
                button8.Text = "بروزرسانی";

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


        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            #region RegisterCode
            N9.Text = ConvertArabicNumberToEnglish.toEnglishNumber(N9.Text);
            N10.Text = ConvertArabicNumberToEnglish.toEnglishNumber(N10.Text);
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    AProduct product = new AProduct();
                    product.Name = N1.Text;
                    product.Type = N2.Text;
                    product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(N4.Text));
                    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(N5.Text));
                    product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(N3.Text));
                    product.Mojodi = product.BuyCount;
                    product.RegisterDate = N9.Text;
                    product.EndDate = N10.Text;
                    product.AgentName = N6.Text;
                    //  1 is cash Money
                    //  2 is bank Money
                    product.CashType = R1.Checked && !R2.Checked ? 1 : 2;
                    blc.CreateProductA(product);
                }
                else if (ADMINNUMBER.Text == "2")
                {
                    BProduct product = new BProduct();
                    product.Name = N1.Text;
                    product.Type = N2.Text;
                    product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(N4.Text));
                    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(N5.Text));
                    product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(N3.Text));
                    product.Mojodi = product.BuyCount;
                    product.RegisterDate = N9.Text;
                    product.EndDate = N10.Text;
                    product.AgentName = N6.Text;
                    //  1 is cash Money
                    //  2 is bank Money
                    product.CashType = R1.Checked && !R2.Checked ? 1 : 2;
                    blc.CreateProductB(product);
                }
                else
                {
                    MessageBox.Show("از این محصول یکبار در انبار محصولات اضافه شده است\nبرای ذخیره سازی اطلاعات جدید محصول را ویرایش کنید");
                }
            }
            catch
            {
                MessageBox.Show("اطلاعات اشتباه وارد شده است");
            }
            #endregion
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
                            if (blc.CreateProductA(product))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "محصول با موفقیت ثبت شد";
                                Fun.ClearTextBoxes(this.Controls);
                                NN7.Text = " ";
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
                            if (blc.CreateProductB(product))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "محصول با موفقیت ثبت شد";
                                Fun.ClearTextBoxes(this.Controls);
                                NN7.Text = " ";
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
                        button8.Text = "ذخیره";
                        if (ADMINNUMBER.Text == "1")
                        {
                            AProduct product = blc.GetProductA(ID);
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
                            if (!blc.ExistProductA(product))
                            {
                                blc.SaveEditProductA(product);
                                Result.Text = "ویرایش شد";
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
                            product.BuyCount = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.Mojodi = product.BuyCount;
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN6.Text));
                            product.AgentName = NN7.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(NN9.Text);
                            if (!blc.ExistProductB(product))
                            {
                                blc.SaveEditProductB(product);
                                Result.Text = "ویرایش شد";
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
                        ShowAllProductDGV2(ADMINNUMBER.Text);
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        ShowAllProductDGV1(ADMINNUMBER.Text);
                        break;
                    }
            }

        }
    
    }
}
