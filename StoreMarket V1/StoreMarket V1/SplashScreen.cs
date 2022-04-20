using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BEE;

namespace StoreMarket_V1
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();

        #region Function()
        public void ADMIN1()
        {
            OWNER owner1 = new OWNER();
            owner1.access = "ADMIN1";
            owner1.password = "ADMIN1";
            owner1.Status = true;
            blc.CreateNewOwner(owner1);
            progressBar1.Value += 50;
        }
        public void ADMIN2()
        {
            OWNER owner2 = new OWNER();
            owner2.access = "ADMIN2";
            owner2.password = "ADMIN2";
            owner2.Status = true;
            blc.CreateNewOwner(owner2);
            progressBar1.Value += 50;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            LoginForm Lg = new LoginForm();
            this.Hide();
            Lg.Show();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public int Progress(DateTime Now1)
        {
            return (Now1.Second);
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            ADMIN1();
            ADMIN2();
        }

    }
}
