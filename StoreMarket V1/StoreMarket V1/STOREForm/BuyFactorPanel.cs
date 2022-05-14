using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEE;
using BLL;
namespace StoreMarket_V1
{
    public partial class BuyFactorPanel : UserControl
    {
        public BuyFactorPanel()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        public void GetAgentNameForCompanyNameinComboBox(String Admin,String CompanyName1)
        {
            CompanyName.Items.Clear();
            if (Admin == "1")
            {
                var DB = blc.GetAgentNameforCompanyA(CompanyName1);
                foreach (var item in DB)
                {
                    AgentName.Items.Add(item);
                }
            }
            else
            {
                var DB = blc.GetAgentNameforCompanyB(CompanyName1);
                foreach (var item in DB)
                {
                    AgentName.Items.Add(item);
                }
            }
        }
        public void GetAgentName(String Admin)
        {
            AgentName.Items.Clear();
            if (Admin=="1")
            {
                var DB=blc.GetAgentNameA();
                foreach (var item in DB)
                {
                    AgentName.Items.Add(item);
                }
            }
            else
            {
                var DB = blc.GetAgentNameB();
                foreach (var item in DB)
                {
                    AgentName.Items.Add(item);
                }
            }
        }
        public void GetCompanyName(String Admin)
        {
            CompanyName.Items.Clear();
            if (Admin == "1")
            {
                var DB = blc.GetCompanyA();
                foreach (var item in DB)
                {
                    CompanyName.Items.Add(item);
                }
            }
            else
            {
                var DB = blc.GetCompanyB();
                foreach (var item in DB)
                {
                    CompanyName.Items.Add(item);
                }
            }
        }
        private void BuyFactorPanel_Load(object sender, EventArgs e)
        {
            DayDate.Text = Fun.CLOCK();
            GetAgentName(ADMIN.Text);
            GetCompanyName(ADMIN.Text);
        }

        private void CashType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
