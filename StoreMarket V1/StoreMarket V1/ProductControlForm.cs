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
        DBCLASS dbc = new DBCLASS();
        Functions Fun = new Functions();
        #region Function
        public void digitonly(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("کیبورد را عوض کنید", "Alert!");
            }
        }
        private string GetEnglishNumber(string persianNumber)
        {
            string englishNumber = "";
            foreach (char ch in persianNumber)
            {
                englishNumber += char.GetNumericValue(ch);
            }
            return englishNumber;
        }
        public bool SelecttypePA(String atp)
        {
            var q = from i in dbc.atypeProducts select i;
            foreach (var item in q)
            {
                if (item.Name == atp)
                {
                    return true;
                }
            }

            return false;
        }
        public bool SelecttypePB(String atp)
        {
            var q = from i in dbc.btypeProducts select i;
            foreach (var item in q)
            {
                if (item.Name == atp)
                {
                    return true;
                }
            }

            return false;
        }
        public bool savetpA(ATypeProduct atp)
        {
            if (!SelecttypePA(atp.Name))
            {
                dbc.atypeProducts.Add(new ATypeProduct
                {
                    Name = atp.Name
                });
                dbc.SaveChanges();
                return true;
            }
            return false;
        }
        public bool savetpB(BTypeProduct atp)
        {
            if (!SelecttypePB(atp.Name))
            {
                dbc.btypeProducts.Add(new BTypeProduct
                {
                    Name = atp.Name
                });
                dbc.SaveChanges();
                return true;
            }
            return false;
        }
        public bool selectPro(String code, String Name, String type)
        {
            if (code == "1")
            {
                foreach (var item in dbc.aProducts)
                {
                    if (item.Name == Name && item.Type == type)
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (var item in dbc.bProducts)
                {
                    if (item.Name == Name && item.Type == type)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool RegisterProductA(AProduct aProduct)
        {
            if (!selectPro("1", aProduct.Name, aProduct.Type))
            {
                dbc.aProducts.Add(new AProduct
                {
                    Name = aProduct.Name,
                    Type = aProduct.Type,
                    buyPrice = aProduct.buyPrice,
                    newBuyPrice = aProduct.buyPrice,
                    sellPrice = aProduct.sellPrice,
                    ManyP = aProduct.ManyP,
                    RegisterDate = aProduct.RegisterDate,
                    EndDate = aProduct.EndDate,
                    AgentName = aProduct.AgentName,
                    CashType = aProduct.CashType
                });
                dbc.SaveChanges();
                return true;
            }
            return false;
        }
        public bool RegisterProductB(BProduct bProduct)
        {
            if (!selectPro("2", bProduct.Name, bProduct.Type))
            {
                dbc.bProducts.Add(new BProduct
                {
                    Name = bProduct.Name,
                    Type = bProduct.Type,
                    buyPrice = bProduct.buyPrice,
                    newBuyPrice = bProduct.buyPrice,
                    sellPrice = bProduct.sellPrice,
                    ManyP = bProduct.ManyP,
                    RegisterDate = bProduct.RegisterDate,
                    EndDate = bProduct.EndDate,
                    AgentName = bProduct.AgentName,
                    CashType = bProduct.CashType
                });
                dbc.SaveChanges();
                return true;
            }
            return false;
        }
        public void Printdata0(String Number)
        {
            #region CodeShow
            DGV1.Rows.Clear();
            if (Number == "1")
            {
                var DB = from i in dbc.aProducts select i;
                foreach (var item in DB)
                {
                    String status = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, item.Name, item.Type, item.buyPrice, item.sellPrice, status);
                }
                var item1 = from i in dbc.atypeProducts select i;
                var item2 = from i in dbc.aAgents select i;

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
                var DB = from i in dbc.bProducts select i;
                foreach (var item in DB)
                {
                    String status = (item.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV1.Rows.Add(item.id, item.Name, item.Type, item.buyPrice, item.sellPrice, status);
                }
                var item1 = from i in dbc.btypeProducts select i;
                var item2 = from i in dbc.bAgents select i;

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
            if(Number == "1")
            {
                var item = from i in dbc.aProducts select i;
                foreach(var i in item)
                {
                    String cash = (i.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(i.id,i.ManyP,i.Name,i.Type,i.buyPrice,i.newBuyPrice,i.sellPrice,i.RegisterDate,i.EndDate, cash, i.AgentName);
                }
                var item1 = from i in dbc.atypeProducts select i;
                var item2 = from i in dbc.aAgents select i;

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
                var item = from i in dbc.bProducts select i;
                foreach (var i in item)
                {
                    String cash = (i.CashType) == 1 ? "نقدی" : "بانکی";
                    DGV2.Rows.Add(i.id, i.ManyP, i.Name, i.Type, i.buyPrice, i.newBuyPrice, i.sellPrice, i.RegisterDate, i.EndDate, cash, i.AgentName);
                }
                var item1 = from i in dbc.btypeProducts select i;
                var item2 = from i in dbc.bAgents select i;

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
                        type1.Items.Clear();
                        agentname1.Items.Clear();
                        Printdata0(ADMINNUMBER.Text);

                        break;
                    }
                case 1:
                    {
                        type1.Items.Clear();
                        agentname1.Items.Clear();
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
            digitonly(e);
        }
        private void dateNow1_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitonly(e);
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
            try
            {
                if (ADMINNUMBER.Text == "1" && RegisterProductA(new AProduct
                {
                    Name = name1.Text,
                    Type = type1.Text,
                    buyPrice = int.Parse(GetEnglishNumber(buy1.Text)),
                    sellPrice = int.Parse(GetEnglishNumber(sellbuy1.Text)),
                    ManyP = int.Parse(GetEnglishNumber(tehdad1.Text)),
                    RegisterDate = ConvertArabicNumberToEnglish.toEnglishNumber(dateNow1.Text),
                    EndDate = ConvertArabicNumberToEnglish.toEnglishNumber(dateExpir1.Text),
                    AgentName = agentname1.Text,
                    //1 is cash Money
                    //  2 is bank Money
                    CashType = R1.Checked && !R2.Checked ? 1 : 2

                }))
                {
                    savetpA(new ATypeProduct
                    {
                        Name = type1.Text
                    });
                    MessageBox.Show("محصول ثبت شد");
                    Fun.ClearTextBoxes(this.Controls);

                }
                else if (ADMINNUMBER.Text == "2" && RegisterProductB(new BProduct
                {
                    Name = name1.Text,
                    Type = type1.Text,
                    buyPrice = int.Parse(buy1.Text),
                    sellPrice = int.Parse(sellbuy1.Text),
                    ManyP = int.Parse(tehdad1.Text),
                    RegisterDate = ConvertArabicNumberToEnglish.toEnglishNumber(dateNow1.Text),
                    EndDate = ConvertArabicNumberToEnglish.toEnglishNumber(dateExpir1.Text),
                    AgentName = agentname1.Text,
                    //1 is cash Money
                    //  2 is bank Money
                    CashType = R1.Checked && !R2.Checked ? 1 : 2

                }))
                {
                    savetpB(new BTypeProduct
                    {
                        Name = type1.Text
                    });
                    MessageBox.Show("محصول ثبت شد");
                    Fun.ClearTextBoxes(this.Controls);
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
            digitonly(e);
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
            MessageBox.Show(e.TabPageIndex.ToString());
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
    }
}
