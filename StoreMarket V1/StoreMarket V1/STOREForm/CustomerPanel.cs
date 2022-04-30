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
    public partial class CustomerPanel : UserControl
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }
        BLLCode bll = new BLLCode();
        Functions Fun=new Functions();
        int ID = -1;
        public void PrintCustomer(String Name)
        {
            DGV1.Rows.Clear();
            if (Name=="1")
            {
                var DB = bll.ShowAllCustomerA();
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id,item.Name,item.Family,item.Phone,item.BuyCost);
                }
            }
            else
            {
                var DB = bll.ShowAllCustomerB();
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, item.Name, item.Family,item.Phone, item.BuyCost);
                }
            }
        }
        private void SAVEBTN_Click(object sender, EventArgs e)
        {
            if (ADMIN.Text=="1")
            {
                ACustomer customer = new ACustomer();
                customer.Name = NAME.Text;
                customer.Family = FAMILY.Text;
                customer.Phone = Int64.Parse( Fun.ChangeToEnglishNumber(PHONE.Text));
                customer.BuyCost = Int64.Parse(Fun.ChangeToEnglishNumber(NEWBUY.Text));
                if (bll.CreateCustomerA(customer))
                {
                    MessageBox.Show("ذخیره شد");
                    PrintCustomer(ADMIN.Text);
                    Fun.ClearTextBoxes(this.Controls);
                }
                else
                {
                    MessageBox.Show("ذخیره نشد");
                }
            }
            else
            {
                BCustomer customer = new BCustomer();
                customer.Name = NAME.Text;
                customer.Family = FAMILY.Text;
                customer.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(PHONE.Text));
                customer.BuyCost = Int64.Parse(Fun.ChangeToEnglishNumber(NEWBUY.Text));
                if (bll.CreateCustomerB(customer))
                {
                    MessageBox.Show("ذخیره شد");
                    PrintCustomer(ADMIN.Text);
                    Fun.ClearTextBoxes(this.Controls);
                }
                else
                {
                    MessageBox.Show("ذخیره نشد");
                }
            }
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            PrintCustomer(ADMIN.Text);
        }

        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right || e.Button==MouseButtons.Left)
            {
                DGV1.CurrentRow.Selected = (DGV1.CurrentRow.Selected) ? false : true;
                ID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void DELETBTN_Click(object sender, EventArgs e)
        {
            if (ADMIN.Text == "1")
            {

            }
        }
    }
}
