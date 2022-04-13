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
        int TAP = -1;
        int ID = -1;
        bool SW = false;
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();
        #region Functions
        public void Printdata0(String Number)
        {
            type1.Items.Clear();
            agentname1.Items.Clear();
            DGV1.Rows.Clear();

            #region CodeShow
            if (Number == "1")
            {
                var DB = blc.ShowAllProductA();
                foreach (var item in DB)
                {
                    String status = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, item.Name, item.Type, item.buyPrice, item.sellPrice, status);
                }
                var item1 = blc.ATypes();
                var item2 = blc.AgentA();

                foreach (var i in item1)
                {
                    type1.Items.Add(i.Name);
                }
                foreach (var i in item2)
                {
                    agentname1.Items.Add(i.Name);
                }
            }
            else if (Number == "2")
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    String status = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, item.Name, item.Type, item.buyPrice, item.sellPrice, status);
                }
                var item1 = blc.BTypes();
                var item2 = blc.AgentB();

                foreach (var i in item1)
                {
                    type1.Items.Add(i.Name);
                }
                foreach (var i in item2)
                {
                    agentname1.Items.Add(i.Name);
                }
            }
            #endregion
        }
        public void printdatatap1(String Number)
        {
            typetxt2.Items.Clear();
            agenttxtname2.Items.Clear();
            DGV2.Rows.Clear();

            if (Number == "1")
            {
                var item = blc.ShowAllProductA();
                foreach (var i in item)
                {
                    String cash = (i.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(i.id, i.ManyP, i.Name, i.Type, i.buyPrice, i.newBuyPrice, i.sellPrice, i.RegisterDate, i.EndDate, cash, i.AgentName);
                }
                var item1 = blc.ATypes();
                var item2 = blc.AgentA();

                foreach (var i in item1)
                {
                    typetxt2.Items.Add(i.Name);
                }
                foreach (var i in item2)
                {
                    agenttxtname2.Items.Add(i.Name);
                }
            }
            else
            {
                var item = blc.ShowAllProductB();
                foreach (var i in item)
                {
                    String cash = (i.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(i.id, i.ManyP, i.Name, i.Type, i.buyPrice, i.newBuyPrice, i.sellPrice, i.RegisterDate, i.EndDate, cash, i.AgentName);
                }
                var item1 = blc.BTypes();
                var item2 = blc.AgentB();

                foreach (var i in item1)
                {
                    typetxt2.Items.Add(i.Name);
                }
                foreach (var i in item2)
                {
                    agenttxtname2.Items.Add(i.Name);
                }

            }
        }
        public void PRCO(int tap)
        {
            switch (tap)
            {
                case 0:
                    {

                        Printdata0(ADMINNUMBER.Text);

                        break;
                    }
                case 1:
                    {

                        printdatatap1(ADMINNUMBER.Text);


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
        #endregion
        private void dateExpir1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.digitonly(e);
        }
        private void dateNow1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.digitonly(e);
        }
        private void ProductControlForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            Printdata0(ADMINNUMBER.Text);
            dateNow1.Text = ConvertArabicNumberToEnglish.toEnglishNumber(dateNow1.Text);
            dateExpir1.Text = ConvertArabicNumberToEnglish.toEnglishNumber(dateExpir1.Text);
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    AProduct product = new AProduct();
                    product.Name = name1.Text;
                    product.Type = type1.Text;
                    product.buyPrice = int.Parse(Fun.GetEnglishNumber(buy1.Text));
                    product.sellPrice = int.Parse(Fun.GetEnglishNumber(sellbuy1.Text));
                    product.ManyP = int.Parse(Fun.GetEnglishNumber(tehdad1.Text));
                    product.RegisterDate = dateNow1.Text;
                    product.EndDate = dateExpir1.Text;
                    product.AgentName = agentname1.Text;
                    //1 is cash Money
                    //  2 is bank Money
                    product.CashType = R1.Checked && !R2.Checked ? 1 : 2;
                    blc.CreateProductA(product);
                }
                else if (ADMINNUMBER.Text == "2")
                {
                    BProduct product = new BProduct();
                    product.Name = name1.Text;
                    product.Type = type1.Text;
                    product.buyPrice = int.Parse(Fun.GetEnglishNumber(buy1.Text));
                    product.sellPrice = int.Parse(Fun.GetEnglishNumber(sellbuy1.Text));
                    product.ManyP = int.Parse(Fun.GetEnglishNumber(tehdad1.Text));
                    product.RegisterDate = dateNow1.Text;
                    product.EndDate = dateExpir1.Text;
                    product.AgentName = agentname1.Text;
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
            Printdata0(ADMINNUMBER.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buy1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.digitonly(e);
        }
        private void ProductControlForm_Load_1(object sender, EventArgs e)
        {
            PRCO(0);

            #region Code
            //SqlConnection conn = new SqlConnection("DataSource=.;Initial Catalog=StoreMarketDB;Integrated Security=True");
            //string query = "SELECT Name FROM [ATypeProducts]";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //conn.Open();
            //cmd.ExecuteScalar();
            //conn.Close();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    type1.Items.Add(dt.Rows[i]["Name"]);
            //}
            #endregion
        }
        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());

                DGV1.CurrentRow.Selected = true;
            }
        }
        private void ControlTAB_Selected(object sender, TabControlEventArgs e)
        {
            //MessageBox.Show(e.TabPageIndex.ToString());
            TAP = e.TabPageIndex;
            switch (TAP)
            {
                case 0:
                    {
                        PRCO(TAP);
                        break;
                    }
                case 1:
                    {
                        PRCO(TAP);
                        break;
                    }
                case 2:
                    {
                        PRCO(TAP);

                        break;
                    }
                case 3:
                    {
                        PRCO(TAP);

                        break;
                    }
                case 4:
                    {
                        PRCO(TAP);

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
        }
        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    nametxt2.Text = i.Name;
                    typetxt2.Text = i.Type;
                    tehdadtxt2.Text = Convert.ToString(i.ManyP);
                    R12.Checked = true;
                    buytxt2.Text = Convert.ToString(i.buyPrice);
                    buyn2.Text = Convert.ToString(i.newBuyPrice);
                    selltxt2.Text = Convert.ToString(i.sellPrice);
                    agenttxtname2.Text = i.AgentName;
                    datenow2.Text = i.RegisterDate;
                    dateexpire2.Text = i.EndDate;
                }
            }
        }
        private void savebtn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    AProduct product = blc.ProductEditA(ID);
                    product.Name = nametxt2.Text;
                    product.Type = typetxt2.Text;
                    product.buyPrice = int.Parse(Fun.GetEnglishNumber(buytxt2.Text));
                    product.newBuyPrice = int.Parse(Fun.GetEnglishNumber(buyn2.Text));
                    product.sellPrice = int.Parse(Fun.GetEnglishNumber(selltxt2.Text));
                    product.ManyP = int.Parse(Fun.GetEnglishNumber(tehdadtxt2.Text));
                    product.RegisterDate = datenow2.Text;
                    product.EndDate = dateexpire2.Text;
                    product.AgentName = agenttxtname2.Text;
                    product.CashType = (R22.Checked) ? 2 : 1;
                    blc.SAVEDB();
                }
                else
                {
                    BProduct product = blc.ProductEditB(ID);
                    product.Name = nametxt2.Text;
                    product.Type = typetxt2.Text;
                    product.buyPrice = int.Parse(Fun.GetEnglishNumber(buytxt2.Text));
                    product.newBuyPrice = int.Parse(Fun.GetEnglishNumber(buyn2.Text));
                    product.sellPrice = int.Parse(Fun.GetEnglishNumber(selltxt2.Text));
                    product.ManyP = int.Parse(Fun.GetEnglishNumber(tehdadtxt2.Text));
                    product.RegisterDate = datenow2.Text;
                    product.EndDate = dateexpire2.Text;
                    product.AgentName = agenttxtname2.Text;
                    product.CashType = (R22.Checked) ? 2 : 1;
                    blc.SAVEDB();
                }
                Fun.ClearTextBoxes(this.Controls);
            }
            catch
            {
                MessageBox.Show("اطلاعات درست نمی باشد", "خطا");
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
    }
}
