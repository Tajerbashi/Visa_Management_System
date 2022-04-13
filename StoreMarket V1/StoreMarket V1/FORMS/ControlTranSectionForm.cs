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
    public partial class ControlTranSectionForm : Form
    {
        #region CodeClick
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public ControlTranSectionForm()
        {
            InitializeComponent();
        }

        private void ControlTranSectionForm_Load(object sender, EventArgs e)
        {

        }

        private void ControlTranSectionForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    ACompany company = new ACompany();
                    company.CompanyName = companyname1.Text;
                    company.CompanyManager = managername1.Text;
                    company.Phone1 = phoneC1.Text;
                    company.Phone2 = phoneC2.Text;
                    company.Address = address1.Text;
                    company.Site = site1.Text;
                    company.isActive = (status1.Text) == "فعال" ? true:false;
                    company.DeleteStatus = false;
                    BLLCode bll = new BLLCode();
                    if (!bll.CreatCompanyA(company))
                    {
                        MessageBox.Show("ثبت نام انجام شد");
                    }
                }
                else if(ADMINNUMBER.Text == "2")
                {
                    BCompany company = new BCompany();
                    company.CompanyName = companyname1.Text;
                    company.CompanyManager = managername1.Text;
                    company.Phone1 = phoneC1.Text;
                    company.Phone2 = phoneC2.Text;
                    company.Address = address1.Text;
                    company.Site = site1.Text;
                    company.isActive = (status1.Text) == "فعال" ? true : false;
                    company.DeleteStatus = false;
                    BLLCode bll = new BLLCode();
                    if (!bll.CreatCompanyB(company))
                    {
                        MessageBox.Show("ثبت نام انجام شد");
                    }
                }
            }
            catch
            {
                MessageBox.Show("اطلاعات درست وارد نشده است");
            }
        }

    }
}
