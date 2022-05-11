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

        }
    }
}
