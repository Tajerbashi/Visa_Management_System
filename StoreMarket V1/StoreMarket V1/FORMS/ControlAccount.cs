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

namespace StoreMarket_V1
{
    public partial class ControlAccount : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public ControlAccount()
        {
            InitializeComponent();
        }
        DBCLASS dbc = new DBCLASS();
        Functions Fun = new Functions();
        int ID =-1;
        bool SW = true; // ذخیره
        public void Printdata(String Number)
        {
            #region CodeShow
            DBCLASS dbc = new DBCLASS();
            dataGridView1.Rows.Clear();
            if (Number == "1")
            {
                var DB = from i in dbc.aAdmins where i.DeleteStatus == false select i;
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            else if (Number == "2")
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

        private void ControlAccount_Load(object sender, EventArgs e)
        {
            ADMINNUMBER.Text = "1";
            Printdata(ADMINNUMBER.Text);
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
                //MessageBox.Show(ID.ToString());
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = "Null";
            bool sws = false;
            if (ADMINNUMBER.Text == "1")
            {
                var q = from i in dbc.aAdmins where i.id == ID select i;
                foreach(var item in q)
                {
                    name = item.Name + " " + item.Family;
                }
                DialogResult = MessageBox.Show("آیا میخواهید اطلاعات\n " + name + " \nرا ویرایش کنید؟", "تایید درخواست", MessageBoxButtons.YesNo);
                if (DialogResult.Yes== DialogResult)
                {
                    sws = true;
                }
            }
            else
            {
                var q = from i in dbc.bAdmins where i.id == ID select i;
                foreach (var item in q)
                {
                    name = item.Name + " " + item.Family;
                }
                DialogResult = MessageBox.Show("آیا میخواهید اطلاعات\n " + name + " \nرا ویرایش کنید؟", "تایید درخواست", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == DialogResult)
                {
                    sws = true;
                }
            }
            if (sws)
            {
                nametxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                familytxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                phonetxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                emailtxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                addresstxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                username.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                userpass.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                accesscode.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                SW = false; //  ویرایش
                Savebtn.Text = "بروزرسانی";
            }
        }

        private void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ADMINNUMBER.Text=="1")
            {
                var item = from i in dbc.aAdmins where i.id == ID select i;
                foreach (var i in item)
                {
                    if (i.IsActive)
                    {
                        i.IsActive = false;
                    }
                    else
                    {
                        i.IsActive = true;
                    }
                }
            }
            else
            {
                var item = from i in dbc.bAdmins where i.id == ID select i;
                foreach (var i in item)
                {
                    if (i.IsActive)
                    {
                        i.IsActive = false;
                    }
                    else
                    {
                        i.IsActive = true;
                    }
                }
            }
            dbc.SaveChanges();
            Printdata(ADMINNUMBER.Text);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                        AAdmin aAdmin = dbc.aAdmins.Where(i => i.id == ID).FirstOrDefault();
                        aAdmin.DeleteStatus = true;
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
                MessageBox.Show("اطلاعات ادمین حذف نمیشود","خطا",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void ControlAccount_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            #region CodeTajer
            if (searchtxt.Text == "KAMRANTAJERBASHI1")
            {
                var DB = from i in dbc.aAdmins where i.id>0 select i;
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            else if (searchtxt.Text == "KAMRANTAJERBASHI2")
            {
                var DB = from i in dbc.bAdmins where i.id > 0 select i;
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            #endregion

            if (ADMINNUMBER.Text == "1")
            {
                var DB = from i in dbc.aAdmins where ((i.Name).Contains(searchtxt.Text) || (i.Family).Contains(searchtxt.Text)) && i.DeleteStatus == false select i;
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            else
            {
                var DB = from i in dbc.bAdmins where ((i.Name).Contains(searchtxt.Text) || (i.Family).Contains(searchtxt.Text)) && i.DeleteStatus == false select i;
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SW)
                {   // ذخیره
                    if (ADMINNUMBER.Text == "1")
                    {
                        Fun.RegisterAdminA(new AAdmin
                        {
                            Name = nametxt.Text,
                            Family = familytxt.Text,
                            Phone = Int64.Parse(phonetxt.Text),
                            Email = emailtxt.Text,
                            Address = addresstxt.Text,
                            Username = username.Text,
                            Password = userpass.Text,
                            accessCode = accesscode.Text,
                            DeleteStatus = false,
                            IsActive = true,
                            OwnerName = ADMINNAME.Text
                        });
                    }
                    else
                    {
                        Fun.RegisterAdminB(new BAdmin
                        {
                            Name = nametxt.Text,
                            Family = familytxt.Text,
                            Phone = Int64.Parse(phonetxt.Text),
                            Email = emailtxt.Text,
                            Address = addresstxt.Text,
                            Username = username.Text,
                            Password = userpass.Text,
                            accessCode = accesscode.Text,
                            DeleteStatus = false,
                            IsActive = true,
                            OwnerName = ADMINNAME.Text
                        });
                        Fun.ClearTextBoxes(this.Controls);
                    }
                }
                else
                {   // ویرایش
                    if (ADMINNUMBER.Text == "1")
                    {
                        AAdmin admin = dbc.aAdmins.Where(c => c.id == ID).FirstOrDefault();
                        admin.Name = nametxt.Text;
                        admin.Family = familytxt.Text;
                        admin.Phone = Int64.Parse(phonetxt.Text);
                        admin.Email = emailtxt.Text;
                        admin.Address = addresstxt.Text;
                        admin.Username = username.Text;
                        admin.Password = userpass.Text;
                        admin.accessCode = accesscode.Text;
                    }
                    else
                    {
                        BAdmin admin = dbc.bAdmins.Where(c => c.id == ID).FirstOrDefault();
                        admin.Name = nametxt.Text;
                        admin.Family = familytxt.Text;
                        admin.Phone = Int64.Parse(phonetxt.Text);
                        admin.Email = emailtxt.Text;
                        admin.Address = addresstxt.Text;
                        admin.Username = username.Text;
                        admin.Password = userpass.Text;
                        admin.accessCode = accesscode.Text;
                    }
                    dbc.SaveChanges();
                    SW = true;
                    Savebtn.Text = "ذخیره";
                }
            }
            catch
            {
                MessageBox.Show("اطلاعات درست وارد نشده است");
            }
            Printdata(ADMINNUMBER.Text);
            
        }

    }
}
