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
        bool SW = true;
        public void PrintCustomer(String Name)
        {
            DGV1.Rows.Clear();
            if (Name=="1")
            {
                var DB = bll.ShowAllCustomerA();
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id,item.FullName,item.Phone,item.BuyCost);
                }
            }
            else
            {
                var DB = bll.ShowAllCustomerB();
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, item.FullName,item.Phone, item.BuyCost);
                }
            }
        }
        public void PrintSerchResult(String Admin,String Word)
        {
            DGV1.Rows.Clear();
            if (Admin=="1")
            {
                var DB = bll.PrintSerchResultCustomerA(Word);
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id,item.FullName,item.Phone,item.BuyCost);
                }
            }
            else
            {
                var DB = bll.PrintSerchResultCustomerB(Word);
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, item.FullName, item.Phone, item.BuyCost);
                }
            }
        }
        private void SAVEBTN_Click(object sender, EventArgs e)
        {
            if (NAME.Text.Trim().Length==0)
            {
                errorProvider1.SetError(NAME,"نام را وارد کنید");
                NAME.Focus();
            }
            else if (FAMILY.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(FAMILY, "فامیلی را وارد کنید");
                FAMILY.Focus();
            }
            else if (PHONE.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(PHONE, "تلفن را وارد کنید");
                PHONE.Focus();
            }
            else if (NEWBUY.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(NEWBUY, "مبلغ را وارد کنید");
                NEWBUY.Focus();
            }
            else
            {
                if (ADMIN.Text == "1")
                {
                    ACustomer customer = new ACustomer();
                    if (SW)
                    {   //ذخیره
                        customer.FullName = NAME.Text + " "+ FAMILY.Text;
                        customer.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(PHONE.Text));
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
                        customer.FullName = NAME.Text + " " + FAMILY.Text;
                        customer.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(PHONE.Text));
                        customer.BuyCost = Int64.Parse(Fun.ChangeToEnglishNumber(NEWBUY.Text));
                        if (bll.EditCustomerA(customer, ID))
                        {
                            MessageBox.Show("ویرایش شد");
                            PrintCustomer(ADMIN.Text);
                            Fun.ClearTextBoxes(this.Controls);
                            SAVEBTN.Text = "ذخیره";
                            SW = true;
                        }
                        else
                        {
                            MessageBox.Show("ذخیره نشد");
                        }
                    }
                }
                else
                {
                    BCustomer customer = new BCustomer();
                    if (SW)
                    {
                        customer.FullName = NAME.Text + " " + FAMILY.Text;
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
                    else
                    {
                        customer.FullName = NAME.Text + " " + FAMILY.Text;
                        customer.Phone = Int64.Parse(Fun.ChangeToEnglishNumber(PHONE.Text));
                        customer.BuyCost = Int64.Parse(Fun.ChangeToEnglishNumber(NEWBUY.Text));
                        if (bll.EditCustomerB(customer, ID))
                        {
                            MessageBox.Show("ویرایش شد");
                            PrintCustomer(ADMIN.Text);
                            Fun.ClearTextBoxes(this.Controls);
                            SAVEBTN.Text = "ذخیره";
                            SW = true;
                        }
                        else
                        {
                            MessageBox.Show("ذخیره نشد");
                        }
                    }
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
                bll.DeleteCustomerA(ID);
                PrintCustomer(ADMIN.Text);
            }
            else
            {
                bll.DeleteCustomerB(ID);
                PrintCustomer(ADMIN.Text);
            }
        }

        private void EDITBTN_Click(object sender, EventArgs e)
        {
            ID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());
            NAME.Text = DGV1.CurrentRow.Cells[1].Value.ToString();
            FAMILY.Text = DGV1.CurrentRow.Cells[2].Value.ToString();
            PHONE.Text = DGV1.CurrentRow.Cells[3].Value.ToString();
            NEWBUY.Text = DGV1.CurrentRow.Cells[4].Value.ToString();
            SAVEBTN.Text = "بروزرسانی";
            SW = false;
        }

        private void NAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void SEABTN_Click(object sender, EventArgs e)
        {
            PrintSerchResult(ADMIN.Text, Search.Text);
        }

    }
}
