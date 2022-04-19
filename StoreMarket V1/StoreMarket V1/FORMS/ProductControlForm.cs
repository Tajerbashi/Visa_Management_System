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
                    DGV1.Rows.Add(item.id, item.Name, item.Type, item.buyPrice, item.sellPrice, Cash);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, item.Name, item.Type, item.buyPrice, item.sellPrice, Cash);
                }
            }
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
                    DGV2.Rows.Add(item.id,item.ManyP, item.Name, item.Type, item.buyPrice,item.newBuyPrice, item.sellPrice,item.RegisterDate,item.EndDate,item.AgentName, Cash);
                }
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    Cash = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(item.id, item.ManyP, item.Name, item.Type, item.buyPrice, item.newBuyPrice, item.sellPrice, item.RegisterDate, item.EndDate, item.AgentName, Cash);
                }
            }
        }

        #endregion 

        #region CompleteCode

        private void ProductControlForm_Load_1(object sender, EventArgs e)
        {
            N7.Text = Fun.CLOCK();
            MessageBox.Show(Fun.ChangeToPersionNumber("9302390293"));
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {


                #region EditProductCode
                //if (ADMINNUMBER.Text == "1")
                //{
                //    AProduct product = blc.ProductEditA(ID);
                //    product.Name = nametxt2.Text;
                //    product.Type = typetxt2.Text;
                //    product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(buytxt2.Text));
                //    product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(buyn2.Text));
                //    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(selltxt2.Text));
                //    product.ManyP = int.Parse(Fun.ChangeToEnglishNumber(tehdadtxt2.Text));
                //    product.RegisterDate = datenow2.Text;
                //    product.EndDate = dateexpire2.Text;
                //    product.AgentName = agenttxtname2.Text;
                //    product.CashType = (R22.Checked) ? 2 : 1;
                //    blc.SAVEDB();
                //}
                //else
                //{
                //    BProduct product = blc.ProductEditB(ID);
                //    product.Name = nametxt2.Text;
                //    product.Type = typetxt2.Text;
                //    product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(buytxt2.Text));
                //    product.newBuyPrice = int.Parse(Fun.ChangeToEnglishNumber(buyn2.Text));
                //    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(selltxt2.Text));
                //    product.ManyP = int.Parse(Fun.ChangeToEnglishNumber(tehdadtxt2.Text));
                //    product.RegisterDate = datenow2.Text;
                //    product.EndDate = dateexpire2.Text;
                //    product.AgentName = agenttxtname2.Text;
                //    product.CashType = (R22.Checked) ? 2 : 1;
                //    blc.SAVEDB();
                //}
                #endregion

            var item = blc.ProductA(ID);
            String name = " ";
            foreach (var ii in item)
            {
                name = ii.Name + " : " + ii.Type;
            }
            DialogResult = MessageBox.Show("آیا میخواهید اطلاعات\n" + name + "\nرا ویرایش کنید؟", "خطا", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == DialogResult)
            {
                SW = true;
            }
            if (SW)
            {
                foreach (var i in item)
                {
                    NN1.Text = i.Name;
                    NN2.Text = i.Type;
                    NN3.Text = Convert.ToString(i.ManyP);
                    //RR1.Select = true;
                    NN4.Text = Convert.ToString(i.buyPrice);
                    NN5.Text = Convert.ToString(i.newBuyPrice);
                    NN6.Text = Convert.ToString(i.sellPrice);
                    NN7.Text = i.AgentName;
                    NN8.Text = i.RegisterDate;
                    NN9.Text = i.EndDate;
                }
            }
        }
        
        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ADMINNUMBER.Text == "1")
            {
                blc.DeleteProductA(ID);
            }
            else
            {
                blc.DeleteProductB(ID);
            }
        }

        private void Savebtn_Click_1(object sender, EventArgs e)
        {
            if (N1.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام محصول را ذکر کنید";
            }
            else if (N2.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نوع محصول را ذکر کنید";
            }
            else if (N3.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تعداد خرید محصول را ذکر کنید";
            }
            else if (N4.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت محصول را ذکر کنید";
            }
            else if (N5.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "قیمت فروش محصول را ذکر کنید";
            }
            else if (N6.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "نام نماینده فروش محصول را ذکر کنید";
            }
            else if (N7.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تاریخ خرید محصول را ذکر کنید";
            }
            else if (N8.Text.Trim().Length == 0)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "تاریخ انقضاء محصول را ذکر کنید";
            }
            else if (!R1.Checked && !R2.Checked)
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
                            product.Name = N1.Text;
                            product.Type = N2.Text;
                            product.ManyP = int.Parse(Fun.ChangeToEnglishNumber(N3.Text));
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(N4.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(N5.Text));
                            product.AgentName = N6.Text;
                            product.CashType = (R1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(N7.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(N8.Text);
                            if (blc.CreateProductA(product))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "محصول با موفقیت ثبت شد";
                                Fun.ClearTextBoxes(this.Controls);
                                N6.Text = " ";
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
                            product.Name = N1.Text;
                            product.Type = N2.Text;
                            product.ManyP = int.Parse(Fun.ChangeToEnglishNumber(N3.Text));
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(N4.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(N5.Text));
                            product.AgentName = N6.Text;
                            product.CashType = (R1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(N7.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(N8.Text);
                            if (blc.CreateProductB(product))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "محصول با موفقیت ثبت شد";
                                Fun.ClearTextBoxes(this.Controls);
                                N6.Text = " ";
                            }
                            else
                            {
                                Result.ForeColor = Color.Red;
                                Result.Text = "ثبت محصول ناموفق بود";
                            }
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("اطلاعات درست نمی باشد", "خطا");
                }
            }

            ShowAllProductDGV1(ADMINNUMBER.Text);
        }

        private void tabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            TAP = tabControl1.SelectedTabIndex;
            switch (TAP)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
            }
        }

        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());

                DGV1.CurrentRow.Selected = true;
            }
        }

        private void savebtn2_Click(object sender, EventArgs e)
        {
            N7.Text = ConvertArabicNumberToEnglish.toEnglishNumber(N7.Text);
            N8.Text = ConvertArabicNumberToEnglish.toEnglishNumber(N8.Text);
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    AProduct product = new AProduct();
                    product.Name = N1.Text;
                    product.Type = N2.Text;
                    product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(N4.Text));
                    product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(N5.Text));
                    product.ManyP = int.Parse(Fun.ChangeToEnglishNumber(N3.Text));
                    product.RegisterDate = N7.Text;
                    product.EndDate = N8.Text;
                    product.AgentName = N6.Text;
                    //1 is cash Money
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
                    product.ManyP = int.Parse(Fun.ChangeToEnglishNumber(N3.Text));
                    product.RegisterDate = N7.Text;
                    product.EndDate = N8.Text;
                    product.AgentName = N6.Text;
                    //1 is cash Money
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
        }

        private void DGV2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ID = int.Parse(DGV2.CurrentRow.Cells[0].Value.ToString());

                DGV1.CurrentRow.Selected = true;
            }
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
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
                            product.ManyP = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.AgentName = NN6.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN7.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            if (blc.CreateProductA(product))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "محصول با موفقیت ثبت شد";
                                Fun.ClearTextBoxes(this.Controls);
                                NN6.Text = " ";
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
                            product.ManyP = int.Parse(Fun.ChangeToEnglishNumber(NN3.Text));
                            product.buyPrice = int.Parse(Fun.ChangeToEnglishNumber(NN4.Text));
                            product.sellPrice = int.Parse(Fun.ChangeToEnglishNumber(NN5.Text));
                            product.AgentName = NN6.Text;
                            product.CashType = (RR1.Checked) ? 1 : 2;    //  1:Money 2:Banking
                            product.RegisterDate = Fun.ChangeToEnglishNumber(NN7.Text);
                            product.EndDate = Fun.ChangeToEnglishNumber(NN8.Text);
                            if (blc.CreateProductB(product))
                            {
                                Result.ForeColor = Color.Green;
                                Result.Text = "محصول با موفقیت ثبت شد";
                                Fun.ClearTextBoxes(this.Controls);
                                NN6.Text = " ";
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

                    }

                }
                catch
                {
                    MessageBox.Show("اطلاعات درست نمی باشد", "خطا");
                }
            }

            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllProductDGV2(ADMINNUMBER.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowAllProductDGV1(ADMINNUMBER.Text);
            ShowAllProductDGV2(ADMINNUMBER.Text);
        }
    }
}
