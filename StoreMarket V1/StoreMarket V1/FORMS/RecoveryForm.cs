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
    public partial class RecoveryForm : Form
    {
        public RecoveryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBCLASS dbc = new DBCLASS();
            Int64 phone = Int64.Parse(phonetxt.Text);
            AAdmin aAdmin=dbc.aAdmins.Where(c =>c.Phone==phone && c.Username == usernametxt.Text && c.Name==nametxt.Text && c.Family == familytxt.Text).First();
            OLDPASS.Text = aAdmin.Password;
        }

        private void changebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
