using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMarket_V1
{
    public partial class ControlAccount : Form
    {
        public ControlAccount()
        {
            InitializeComponent();
        }
        int ID=-1;
        private void ControlAccount_Load(object sender, EventArgs e)
        {
            #region CodeShow
            DBCLASS dbc = new DBCLASS();
            ADMINNUMBER.Text = "1";
            if (ADMINNUMBER.Text == "1")
            {
                var DB = from i in dbc.aAdmins where i.DeleteStatus == false select i;
                foreach(var item in DB)
                {
                    String status= (item.IsActive) == true ? "فعال" : "غیر فعال" ;
                    dataGridView1.Rows.Add(item.id,status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            else if(ADMINNUMBER.Text == "2")
            {
                var DB = from i in dbc.bAdmins where i.DeleteStatus == false select i;
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            #endregion

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.CurrentRow.Selected=true;
                MessageBox.Show(ID.ToString());
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBCLASS dbc = new DBCLASS();
            String Name="NULL";
            if(ID != 1)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    var q = from i in dbc.aAdmins where i.id == ID select i;
                    foreach (var item in q)
                    {
                        Name = item.Name + " " + item.Family;
                    }

                    if (DialogResult.Yes == MessageBox.Show("اطلاعات " + Name + "  پاک شود ؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        AAdmin aAdmin = dbc.aAdmins.Where(i => i.id == ID).First();
                        aAdmin.DeleteStatus = true;
                        if (aAdmin.DeleteStatus == false)
                        {
                            MessageBox.Show("اطلاعات ادمین اصلی پاک نمیشود");
                        }
                    }
                }
                else if (ADMINNUMBER.Text == "2")
                {
                    var q = from i in dbc.bAdmins where i.id == ID select i;
                    foreach (var item in q)
                    {
                        Name = item.Name + " " + item.Family;
                    }

                    if (DialogResult.Yes == MessageBox.Show("اطلاعات " + Name + "  پاک شود ؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        BAdmin bAdmin = dbc.bAdmins.Where(i => i.id == ID).First();
                        bAdmin.DeleteStatus = true;
                        if (bAdmin.DeleteStatus == false)
                        {
                            MessageBox.Show("اطلاعات ادمین اصلی پاک نمیشود");
                        }
                        
                    }
                }
                dbc.SaveChanges();
            }
            else
            {
                MessageBox.Show("اطلاعات ادمین پاک شد");
            }

        }
    }
}
