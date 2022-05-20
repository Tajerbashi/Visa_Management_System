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
    public partial class SellFactor : UserControl
    {
        public SellFactor()
        {
            InitializeComponent();
        }
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();
        AAdmin AdminA = new AAdmin();
        BAdmin AdminB = new BAdmin();
        int ID1 = 0, ID2 = 0, counter1 = 1, counter2 = 1,NO1=0,NO2=1;
        #region Function
        public void GetFactorNumber()
        {
            if (AdminNumber.Text=="1")
            {
                FactorNumber.Text = blc.GetLastSellFactorNumberA().ToString();
            }
            else
            {
                FactorNumber.Text = blc.GetLastSellFactorNumberB().ToString();
            }
        }
        public void GetFactorCode()
        {
            if (AdminNumber.Text == "1")
            {
                FactorCode.Text = blc.GetLastSellFactorCodeA().ToString();
            }
            else
            {
                FactorCode.Text = blc.GetLastSellFactorCodeB().ToString();
            }
        }
        public void GetAdminFullName()
        {
            if (AdminNumber.Text=="1")
            {
                AdminA = blc.GetAdminsA().Where(c => c.Username == AdminName.Text).FirstOrDefault();
                ADMINNAMESHOW.Text = AdminA.FullName;
            }
            else
            {
                AdminB = blc.GetAdminsB().Where(c => c.Username == AdminName.Text).FirstOrDefault();
                ADMINNAMESHOW.Text = AdminB.FullName;
            }
        }
        public void AddProductToDGV2(int ID)
        {
            if (AdminNumber.Text == "1")
            {
                AProduct Product = blc.GetProductA(ID);
                DGV2.Rows.Add(Product.id,counter2,Product.Name,Product.Type,Product.Brand,Product.newBuyPrice,0,000);
            }
            else
            {
                AProduct Product = blc.GetProductA(ID);
                DGV2.Rows.Add(Product.id, counter2, Product.Name, Product.Type, Product.Brand, Product.newBuyPrice, 0, 000);
            }
            NO2 = counter2;
            counter2++;
        }

        #endregion
        private void FactorCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SellFactor_Load(object sender, EventArgs e)
        {
            //  زمان آپلود شدن فرم
            GetAdminFullName();
            GetFactorNumber();
            GetFactorCode();
            DayDate.Text = Fun.CLOCK();
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            DGV1.Rows.Clear();
            var DB = blc.GetProductsA().Where(c => c.Name.Contains(Search.Text)).OrderBy( i => i.ProduceDate);
            int No = 1;
            foreach (var item in DB)
            {
                DGV1.Rows.Add(item.id,No,item.Name,item.Type,item.Brand,item.ProduceDate,item.sellPrice,item.Mojodi);
                No++;
            }
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            if (CustomerName.Text.Trim().Length==0)
            {
                ResultStatus.Text = "نام مشتری را وارد کنید";
                CustomerName.Focus();
            }
            else if (PhoneNumber.Text.Trim().Length == 0)
            {
                ResultStatus.Text = "تلفن مشتری را وارد کنید";
                PhoneNumber.Focus();

            }
            else if (FactorNumber.Text.Trim().Length == 0)
            {
                ResultStatus.Text = "شماره فاکتور را وارد کنید";
                FactorNumber.Focus();

            }
            else if (FactorCode.Text.Trim().Length == 0)
            {
                ResultStatus.Text = "کد فاکتور را وارد کنید";
                FactorCode.Focus();

            }
            else if (DayDate.Text.Trim().Length == 0)
            {
                ResultStatus.Text = "تاریخ را وارد کنید";
                DayDate.Focus();

            }
            else
            {
                ACustomer customer = new ACustomer();
                customer.FullName = CustomerName.Text;
                customer.Phone = Convert.ToInt64(Fun.ChangeToEnglishNumber(PhoneNumber.Text));
                if (blc.CreateCustomerA(customer))
                {
                    //  موجود نیست و ثبت نام میشود
                    MessageBox.Show("جدید بود و ثبت نام شد");
                }
                else
                {
                    //  موجود است و آنرا بگیرد
                    //ACustomer customerN = blc.GetCustomersA().Where(c => c.FullName == CustomerName.Text).FirstOrDefault();
                    MessageBox.Show("موجود بود");
                }
                //groupBox1.Enabled = false;
                //groupBox2.Enabled = true;
            }

        }

        private void CloseFactor_Click(object sender, EventArgs e)
        {
            //groupBox2.Enabled = false;
            //groupBox3.Enabled = true;
        }

        private void OpenFactor_Click(object sender, EventArgs e)
        {
            //groupBox2.Enabled = true;
            //groupBox3.Enabled = false;
        }

        #region CodeMouse
        private void Okay_MouseEnter(object sender, EventArgs e)
        {
            Okay.TextColor = Color.Black;
        }

        private void Okay_MouseLeave(object sender, EventArgs e)
        {
            Okay.TextColor = Color.White;
        }

        private void Searchbtn_MouseEnter(object sender, EventArgs e)
        {
            Searchbtn.TextColor = Color.Black;

        }

        private void Searchbtn_MouseLeave(object sender, EventArgs e)
        {
            Searchbtn.TextColor = Color.White;

        }

        private void Addbtn_MouseEnter(object sender, EventArgs e)
        {
            Addbtn.TextColor = Color.Black;

        }

        private void Addbtn_MouseLeave(object sender, EventArgs e)
        {
            Addbtn.TextColor = Color.White;

        }

        private void Deletebtn_MouseEnter(object sender, EventArgs e)
        {
            Deletebtn.TextColor = Color.Black;

        }

        private void Deletebtn_MouseLeave(object sender, EventArgs e)
        {
            Deletebtn.TextColor = Color.White;

        }

        private void CloseFactor_MouseEnter(object sender, EventArgs e)
        {
            CloseFactor.TextColor = Color.Black;

        }

        private void CloseFactor_MouseLeave(object sender, EventArgs e)
        {
            CloseFactor.TextColor = Color.White;

        }

        private void OpenFactor_MouseEnter(object sender, EventArgs e)
        {
            OpenFactor.TextColor = Color.Black;

        }

        private void OpenFactor_MouseLeave(object sender, EventArgs e)
        {
            OpenFactor.TextColor = Color.White;

        }

        private void AcceptFactor_MouseEnter(object sender, EventArgs e)
        {
            AcceptFactor.TextColor = Color.Black;

        }

        private void AcceptFactor_MouseLeave(object sender, EventArgs e)
        {
            AcceptFactor.TextColor = Color.White;

        }

        private void SaveFactor_MouseEnter(object sender, EventArgs e)
        {
            SaveFactor.TextColor = Color.Black;

        }

        private void SaveFactor_MouseLeave(object sender, EventArgs e)
        {
            SaveFactor.TextColor = Color.White;

        }
        #endregion

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //groupBox1.Enabled = true;
            //groupBox2.Enabled = false;
            //groupBox3.Enabled = false;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            //groupBox3.Enabled = true;
            AddProductToDGV2(ID1);
        }

        private void AddMojodi_Click(object sender, EventArgs e)
        {
            DGV2.Rows[NO2-1].Cells[6].Value = int.Parse(Tehdad.Value.ToString());
            DGV2.Rows[NO2-1].Cells[7].Value = int.Parse(Tehdad.Value.ToString()) * int.Parse(DGV2.Rows[NO2-1].Cells[5].Value.ToString());
        }

        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right || e.Button==MouseButtons.Left)
            {
                DGV1.CurrentRow.Selected = (DGV1.CurrentRow.Selected) ? false : true;
                ID1 = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());
                NO1 = int.Parse(DGV1.CurrentRow.Cells[1].Value.ToString());
            }
        }
        private void DGV2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                DGV2.CurrentRow.Selected = (DGV2.CurrentRow.Selected) ? false : true;
                ID2 = int.Parse(DGV2.CurrentRow.Cells[0].Value.ToString());
                NO2 = int.Parse(DGV2.CurrentRow.Cells[1].Value.ToString());
            }
        }
    }
}
