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
    public partial class ReportationProduct : UserControl
    {
        public ReportationProduct()
        {
            InitializeComponent();
        }

        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        double TotalListN = 0, TotalBankN = 0, TotalMoneyN = 0, TotalMojodiN = 0;

        public void ShowAllProducts()
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowAllProductA();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowAllProductB();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion

        }
        public void ShowSearchResult(String Word)
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowSearchResultA(Word);
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowSearchResultB(Word);
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion

        }
        public void ShowSearchResultForYear(String Start,String End)
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowSearchResultForYearA(Start,End);
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowSearchResultForYearB(Start,End);
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion

        }

        public void ShowMoreSellProduct()
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowMoreSellProductA();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowMoreSellProductB();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion
        }
        public void ShowLessSellProduct()
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowLessSellProductA();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowLessSellProductB();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion
        }

        public void ShowMoreMoneySellProduct()
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowMoreMoneySellProductA();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowMoreMoneySellProductB();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion

        }
        public void ShowLessMoneySellProduct()
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowLessMoneySellProductA();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowLessMoneySellProductB();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion

        }

        public void ShowMoreBankiSellProduct()
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowMoreBankiSellProductA();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowMoreBankiSellProductB();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion

        }
        public void ShowLessBankiSellProduct()
        {
            #region Code
            TotalListN = TotalBankN = TotalMoneyN = TotalMojodiN = 0;
            DGV.Rows.Clear();
            if (ADMINNUMBER.Text == "1")
            {
                var DB = blc.ShowLessBankiSellProductA();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductA(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            else
            {
                var DB = blc.ShowLessBankiSellProductB();
                foreach (var item in DB)
                {
                    int FactorCode = blc.GetIDBuyFactorForProductB(item.id);
                    double Total = item.newBuyPrice * item.Mojodi;
                    TotalListN += Total;
                    TotalMojodiN += item.Mojodi;
                    if (item.CashType == 1)
                    {
                        TotalMoneyN += Total;
                    }
                    else
                    {
                        TotalBankN += Total;
                    }
                    DGV.Rows.Add(item.Name, item.Brand, item.Type, item.Mojodi, item.SellCount, item.newBuyPrice, item.ExpireDate, item.AgentName, FactorCode, Total);
                }
                TotalList.Text = TotalListN.ToString();
                TotalMoney.Text = TotalMoneyN.ToString();
                TotalBank.Text = TotalBankN.ToString();
                TotalMojodi.Text = TotalMojodiN.ToString();
            }
            #endregion

        }


        #region Code
        private void ReportationProduct_Load(object sender, EventArgs e)
        {
            ShowAllProducts();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ShowSearchResult(Fun.ChangeToEnglishNumber(Searchtxt.Text));
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            ShowSearchResultForYear(Fun.ChangeToEnglishNumber( (Yeartxt.Value.ToString()+"/00/00") ), Fun.ChangeToEnglishNumber(((Yeartxt.Value)+1).ToString() + "/00/00"));
            //MessageBox.Show(Fun.ChangeToEnglishNumber((Yeartxt.Value.ToString() + "/00/00")));
        }

        private void noAdd_Click(object sender, EventArgs e)
        {
            if (Price.Text.Trim().Length != 0)
            {
                DGV.CurrentRow.Cells[5].Value = Fun.ChangeToEnglishNumber(Price.Text);
                int N1 = int.Parse(Fun.ChangeToEnglishNumber(Price.Text));
                int N2 = int.Parse(DGV.CurrentRow.Cells[3].Value.ToString());
                int TotalP = N1 * N2;
                DGV.CurrentRow.Cells[9].Value=TotalP;
            }
            TotalListN = 0;
            for (int i=0;i<DGV.RowCount;i++)
            {
                TotalListN += Convert.ToDouble( DGV.Rows[i].Cells[9].Value.ToString());
            }
            TotalList.Text = TotalListN.ToString();
        }
        #endregion
        private void buttonX1_Click(object sender, EventArgs e)
        {
            // پرفروش ترین
            ShowMoreSellProduct();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //  کم فروش ترین
            ShowLessSellProduct();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            //  محصولات پر فروش نقدی
            ShowMoreMoneySellProduct();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            //  محصولات کم فروش نقدی
            ShowLessMoneySellProduct();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            //  محصولات پر فروش فروش بانکی
            ShowMoreBankiSellProduct();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            //  محصولات کم فروش فروش بانکی
            ShowLessBankiSellProduct();
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
