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
using BLL;
using BEE;
namespace StoreMarket_V1
{
    public partial class Store : Form
    {
        #region Code
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        Timer timer = new Timer();

        public Store()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            date.Text = DateTime.Now.ToString("yyyy/MM/dd");//tarikh feli ro mide
            clock.Text = DateTime.Now.ToString("HH:mm:ss dddd");
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 800;
            timer.Start();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        BackUpBLL bbll = new BackUpBLL();
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        int Tap=0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBoxForm message = new MessageBoxForm();
            message.Subject.Location= new Point(196, 60);
            message.title.Text = "تایید درخواست خروج";
            message.Subject.Text = "میخواهید برنامه بسته شود؟";
            message.question.Visible = true;
            message.ShowDialog();
            if (message.Sw)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss dddd");//zaman ro mide
        }

        private void Store_Load(object sender, EventArgs e)
        {
            ProductPanel panel = new ProductPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMIN.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPanel panel = new CustomerPanel();
            if (MainPanel.Controls.Count>0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMIN.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductPanel panel = new ProductPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMIN.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductPanelControl panel = new ProductPanelControl();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMINNAME.Text = ADMINNAME.Text;
            panel.ADMINNUMBER.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ControlTranSectionForm CTSF = new ControlTranSectionForm();
            CTSF.ADMINNAME.Text = ADMINNAME.Text;
            CTSF.ADMINNUMBER.Text = ADMINNUMBER.Text;
            CTSF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuyFactorPanel panel = new BuyFactorPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.AdminName.Text = ADMINNAME.Text;
            panel.AdminNumber.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SellFactor panel = new SellFactor();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.AdminName.Text = ADMINNAME.Text;
            panel.AdminNumber.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InventoryPanel panel = new InventoryPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMINNAME.Text = ADMINNAME.Text;
            panel.ADMINNUMBER.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportationProduct panel = new ReportationProduct();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMINNAME.Text = ADMINNAME.Text;
            panel.ADMINNUMBER.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            (new AdminBankAccount()).ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CheckBankPanel panel = new CheckBankPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMINNAME.Text = ADMINNAME.Text;
            panel.ADMINNUMBER.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AccessCode.Visible = true;
            Tap = 1;
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AccessCode.Visible = true;
            Tap = 2;
        }

        private void ClosePanel_Click(object sender, EventArgs e)
        {
            AccessCode.Visible = false;
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            if (ADMINNUMBER.Text=="1")
            {
                if (blc.CheckAccessCodeAdminA(AccessCodetxt.Text,ADMINNAME.Text))
                {
                    if (Tap == 1)
                    {
                        MessageBoxForm message = new MessageBoxForm();
                        message.title.Text = "پشتیبان گیری";
                        message.Subject.Location = new Point(130, 70);
                        message.Subject.Text = "آیا مطمیین هستید ؟؟؟";
                        message.question.Visible = true;
                        message.ShowDialog();
                        if (message.Sw)
                        {
                            FolderBrowserDialog fbd = new FolderBrowserDialog();
                            fbd.ShowDialog();
                            bbll.BackUp(fbd.SelectedPath);
                            AccessCode.Visible = false;
                            MessageBoxForm message1 = new MessageBoxForm();
                            message1.title.Text = "پشتیبان گیری اطلاعات";
                            message1.Subject.Location = new Point(130, 70);
                            message1.Subject.Text = "با موفقیت پشتیبان گیری انجام شد";
                            message1.OKbtn.Visible = false;
                            message1.Cancelbtn.Visible = false;
                            message1.tick.Visible = true;
                            message1.OKAYBTN.Visible = true;
                            message1.ShowDialog();
                        }
                    }
                    else if(Tap == 2)
                    {
                        MessageBoxForm message = new MessageBoxForm();
                        message.title.Text = " بازگردانی اطلاعات";
                        message.Subject.Location = new Point(130,70);
                        message.Subject.Text = "اطلاعاتی که بعد از پشتیبان گیری \nاضافه شده است پاک میشود\nآیا مطمیین هستید ؟؟؟";
                        message.question.Visible = true;
                        message.ShowDialog();
                        if (message.Sw)
                        {
                            OpenFileDialog ofd = new OpenFileDialog();
                            ofd.ShowDialog();
                            bbll.Restore(ofd.FileName);
                            AccessCode.Visible = false;
                            MessageBoxForm message1 = new MessageBoxForm();
                            message1.title.Text = "بازگردانی اطلاعات";
                            message1.Subject.Location = new Point(120, 70);
                            message1.Subject.Text = "با موفقیت بازگردانی اطلاعات انجام شد";
                            message1.OKbtn.Visible = false;
                            message1.Cancelbtn.Visible = false;
                            message1.tick.Visible = true;
                            message1.OKAYBTN.Visible = true;
                            message1.ShowDialog();
                        }
                    }
                }

            }
            else
            {
                if (blc.CheckAccessCodeAdminB(AccessCodetxt.Text, ADMINNAME.Text))
                {
                    if (Tap == 1)
                    {
                        MessageBoxForm message = new MessageBoxForm();
                        message.title.Text = "پشتیبان گیری";
                        message.Subject.Location = new Point(130, 70);
                        message.Subject.Text = "آیا مطمیین هستید ؟؟؟";
                        message.question.Visible = true;
                        message.ShowDialog();
                        if (message.Sw)
                        {
                            FolderBrowserDialog fbd = new FolderBrowserDialog();
                            fbd.ShowDialog();
                            bbll.BackUp(fbd.SelectedPath);
                            AccessCode.Visible = false;
                            MessageBoxForm message1 = new MessageBoxForm();
                            message1.title.Text = "بازگردانی اطلاعات";
                            message1.Subject.Location = new Point(130, 70);
                            message1.Subject.Text = "با موفقیت پشتیبان گیری انجام شد";
                            message1.OKbtn.Visible = false;
                            message1.Cancelbtn.Visible = false;
                            message1.tick.Visible = true;
                            message1.OKAYBTN.Visible = true;
                            message1.ShowDialog();
                        }
                    }
                    else if (Tap == 2)
                    {
                        MessageBoxForm message = new MessageBoxForm();
                        message.title.Text = "بازگردانی اطلاعات";
                        message.Subject.Location = new Point(130, 70);
                        message.Subject.Text = "اطلاعاتی که بعد از پشتیبان گیری \nاضافه شده است پاک میشود\nآیا مطمیین هستید ؟؟؟";
                        message.question.Visible = true;
                        message.ShowDialog();

                        if (message.Sw)
                        {
                            OpenFileDialog ofd = new OpenFileDialog();
                            ofd.ShowDialog();
                            bbll.Restore(ofd.FileName);
                            AccessCode.Visible = false;
                            MessageBoxForm message1 = new MessageBoxForm();
                            message1.title.Text = "بازگردانی اطلاعات";
                            message1.Subject.Location = new Point(120, 70);
                            message1.Subject.Text = "با موفقیت بازگردانی اطلاعات انجام شد";
                            message1.OKbtn.Visible = false;
                            message1.Cancelbtn.Visible = false;
                            message1.tick.Visible = true;
                            message1.OKAYBTN.Visible = true;
                            message1.ShowDialog();
                        }
                    }
                }

            }
            AccessCodetxt.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChartsPanel panel = new ChartsPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            panel.ADMINNAME.Text = ADMINNAME.Text;
            panel.ADMINNUMBER.Text = ADMINNUMBER.Text;
            MainPanel.Controls.Add(panel);
        }
    }
}
