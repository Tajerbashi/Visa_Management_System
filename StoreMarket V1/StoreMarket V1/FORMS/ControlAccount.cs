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
using BEE;
using BLL;
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
        Functions Fun = new Functions();
        BLLCode blc = new BLLCode();

        int ID = -1;
        bool SW = true; // ذخیره

        public void Printdata(String Number)
        {
            #region CodeShow
            dataGridView1.Rows.Clear();
            if (Number == "1")
            {
                var DB = blc.ReadAdminA().ToList();
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            else if (Number == "2")
            {
                var DB = blc.ReadAdminB().ToList();
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            #endregion
        }
        public void PrintALLdata(String Number)
        {
            #region CodeShow
            dataGridView1.Rows.Clear();
            if (Number == "1")
            {
                var DB = blc.ShowAllAdminDataA().ToList();
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            else if (Number == "2")
            {
                var DB = blc.ShowAllAdminDataB().ToList();
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            #endregion
        }
        public void PrintActiveData(String Number)
        {
            #region CodeShow
            dataGridView1.Rows.Clear();
            if (Number == "1")
            {
                var DB = blc.ShowActiveDataA().ToList();
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            else if (Number == "2")
            {
                var DB = blc.ShowActiveDataA().ToList();
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            #endregion
        }
        public void PrintSearchResult(String Number,String Word)
        {
            #region CodeShow
            dataGridView1.Rows.Clear();
            if (Number == "1")
            {
                var DB = blc.ShowSearchResultA(Number,Word).ToList();
                foreach (var item in DB)
                {
                    String status = (item.IsActive) == true ? "فعال" : "غیر فعال";
                    dataGridView1.Rows.Add(item.id, status, item.Name, item.Family, item.Phone, item.Email, item.Address, item.Username, item.Password, item.accessCode);
                }
            }
            else if (Number == "2")
            {
                var DB = blc.ShowSearchResultB(Number, Word).ToList();
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
                dataGridView1.CurrentRow.Selected = true;
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = "Null";
            bool sws = false;
            if (ADMINNUMBER.Text == "1")
            {
                name = blc.FullNameA(ID);
                DialogResult = MessageBox.Show("آیا میخواهید اطلاعات\n " + name + " \nرا ویرایش کنید؟", "تایید درخواست", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == DialogResult)
                {
                    sws = true;
                }
            }
            else
            {
                name = blc.FullNameB(ID);
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
                phonetxt.Text = ConvertArabicNumberToEnglish.toEnglishNumber(dataGridView1.CurrentRow.Cells[4].Value.ToString());
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
            if (ADMINNUMBER.Text == "1")
            {
                blc.ChangeStatusAdminA(ID);
            }
            else
            {
                blc.ChangeStatusAdminB(ID);
            }
            Printdata(ADMINNUMBER.Text);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Name = "NULL";
            if (ID != 1)
            {
                if (ADMINNUMBER.Text == "1")
                {
                    Name = blc.FullNameA(ID);

                    if (DialogResult.Yes == MessageBox.Show("اطلاعات " + Name + "  پاک شود ؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        blc.DeleteAdminA(ID);
                    }
                }
                else if (ADMINNUMBER.Text == "2")
                {
                    Name = blc.FullNameB(ID);

                    if (DialogResult.Yes == MessageBox.Show("اطلاعات " + Name + "  پاک شود ؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        blc.DeleteAdminB(ID);
                    }
                }
            }
            else
            {
                MessageBox.Show("اطلاعات ادمین حذف نمیشود", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Printdata(ADMINNUMBER.Text);
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
            if ((searchtxt.Text).Trim().Equals("TAJERBASHI1"))
            {
                PrintALLdata(ADMINNUMBER.Text);
            }
            else
            if ((searchtxt.Text).Trim().Equals("TAJERBASHI2"))
            {
                PrintALLdata(ADMINNUMBER.Text);
            }
            else
            if (searchtxt.Text == "1")
            {
                Printdata(ADMINNUMBER.Text);
            }
            else
            if(searchtxt.Text == "2")
            {
                Printdata(ADMINNUMBER.Text);
            }
            else
            {
                PrintSearchResult(ADMINNUMBER.Text, searchtxt.Text);
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("از درج اطلاعات مطمیین هستید؟؟؟", "اطلاعیه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                try
                {
                    if (SW)
                    {   // ذخیره
                        if (ADMINNUMBER.Text == "1")
                        {
                            OWNER owner = blc.SelectOwner("ADMIN1");
                            AAdmin admin = new AAdmin();

                            admin.Name = nametxt.Text;
                            admin.Family = familytxt.Text;
                            admin.Phone = Int64.Parse(ConvertArabicNumberToEnglish.toEnglishNumber(phonetxt.Text));
                            admin.Email = emailtxt.Text;
                            admin.Address = addresstxt.Text;
                            admin.Username = username.Text;
                            admin.Password = userpass.Text;
                            admin.accessCode = accesscode.Text;
                            admin.DeleteStatus = false;
                            admin.IsActive = true;
                            admin.OwnerName = ADMINNAME.Text;

                            blc.RegisterAdminA(admin);
                            if (owner.Status)
                            {
                                blc.ChangeOwnerStatus(owner);
                                Application.Exit();
                            }
                            Fun.ClearTextBoxes(this.Controls);
                        }
                        else
                        {
                            OWNER owner = blc.SelectOwner("ADMIN2");

                            BAdmin admin = new BAdmin();
                            admin.Name = nametxt.Text;
                            admin.Family = familytxt.Text;
                            admin.Phone = Int64.Parse(ConvertArabicNumberToEnglish.toEnglishNumber(phonetxt.Text));
                            admin.Email = emailtxt.Text;
                            admin.Address = addresstxt.Text;
                            admin.Username = username.Text;
                            admin.Password = userpass.Text;
                            admin.accessCode = accesscode.Text;
                            admin.DeleteStatus = false;
                            admin.IsActive = true;
                            admin.OwnerName = ADMINNAME.Text;

                            blc.RegisterAdminB(admin);
                            if (owner.Status)
                            {
                                blc.ChangeOwnerStatus(owner);
                                Application.Exit();
                            }
                            Fun.ClearTextBoxes(this.Controls);
                        }
                    }
                    else
                    {   // ویرایش
                        if (ADMINNUMBER.Text == "1")
                        {
                            AAdmin admin = blc.EditAdminA(ID);
                            admin.Name = nametxt.Text;
                            admin.Family = familytxt.Text;
                            admin.Phone = Int64.Parse(ConvertArabicNumberToEnglish.toEnglishNumber(phonetxt.Text));
                            admin.Email = emailtxt.Text;
                            admin.Address = addresstxt.Text;
                            admin.Username = username.Text;
                            admin.Password = userpass.Text;
                            admin.accessCode = accesscode.Text;
                            blc.SelectAdminA(admin);
                        }
                        else
                        {
                            BAdmin admin = blc.EditAdminB(ID);
                            admin.Name = nametxt.Text;
                            admin.Family = familytxt.Text;
                            admin.Phone = Int64.Parse(ConvertArabicNumberToEnglish.toEnglishNumber(phonetxt.Text));
                            admin.Email = emailtxt.Text;
                            admin.Address = addresstxt.Text;
                            admin.Username = username.Text;
                            admin.Password = userpass.Text;
                            admin.accessCode = accesscode.Text;
                            blc.SelectAdminB(admin);
                        }
                        Fun.ClearTextBoxes(this.Controls);
                        SW = true;
                        Savebtn.Text = "ذخیره";
                    }
                    Printdata(ADMINNUMBER.Text);
                }
                catch
                {
                    MessageBox.Show("اطلاعات درست وارد نشده است");
                }
            }


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrintActiveData(ADMINNUMBER.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Printdata(ADMINNUMBER.Text);
        }
    }
}
