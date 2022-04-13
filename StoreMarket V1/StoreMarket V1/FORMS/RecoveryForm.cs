using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BEE;

namespace StoreMarket_V1
{
    public partial class RecoveryForm : Form
    {
        public RecoveryForm()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        private void button1_Click(object sender, EventArgs e)
        {
            AAdmin adminA = new AAdmin();
            BAdmin adminB = new BAdmin();

            adminA.accessCode = accesscodetxt.Text;
            adminA.Username = usernametxt.Text;
            adminA.Phone = Int64.Parse(phonetxt.Text);
            
            adminB.accessCode = accesscodetxt.Text;
            adminB.Username = usernametxt.Text;
            adminB.Phone = Int64.Parse(phonetxt.Text);

            String Pass = blc.ResetAdminPassword(adminA, adminB);

            if(Pass != "0")
            {
                OLDPASS.Text = Pass;
            }
            else
            {
                OLDPASS.Text = "اطلاعات اشتباه است";
            }
            

        }

        private void changebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
