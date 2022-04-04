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
    public partial class AccessCodeForm : Form
    {
        public AccessCodeForm()
        {
            InitializeComponent();
        }
        public bool AccessCodeForAdminENTER(String Code)
        {
            DBCLASS dbc = new DBCLASS();
            foreach (var item in dbc.Owner)
            {
                if ( item.access == Code && item.password == Code && item.Status == true )
                {
                    return true;
                }
            }
            foreach (var item in dbc.aAdmins)
            {
                if (item.accessCode == textBox1.Text)
                {
                    return true;
                }
            }
            foreach (var item in dbc.bAdmins)
            {
                if (item.accessCode == textBox1.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (AccessCodeForAdminENTER(textBox1.Text))
            {
                StoreManagmentForm RGF = new StoreManagmentForm();
                RGF.ADMINNAME.Text = ADMINNAME.Text;
                RGF.ADMINNUMBER.Text = ADMINNUMBER.Text;
                RGF.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("دسترسی ندارید");
            }
        }
    }
}
