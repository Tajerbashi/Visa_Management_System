using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BEE;
using BLL;

namespace StoreMarket_V1
{
    public partial class ChartsPanel : UserControl
    {
        public ChartsPanel()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Functions Fun = new Functions();
        List<String> Numbers = new List<String>();
        List<String> Names = new List<string>();
        public void ShowAllProduct()
        {
            int i = 1;
            if (ADMINNUMBER.Text=="1")
            {
                var db = blc.GetProductsA();
                foreach (var item in db)
                {
                    DGV.Rows.Add(item.id,i,item.Name,item.Type,item.Brand,item.newBuyPrice,item.sellPrice);
                    i++;
                }
            }
            else
            {
                var db = blc.GetProductsB();
                foreach (var item in db)
                {
                    DGV.Rows.Add(item.id, i, item.Name, item.Type, item.Brand, item.newBuyPrice, item.sellPrice);
                    i++;
                }
            }
        }


        private void ChartsPanel_Load(object sender, EventArgs e)
        {
            ShowAllProduct();
            //  Banki
            foreach (var series in Banking.Series)
            {
                series.Points.Clear();
            }
            try
            {
                if (ADMINNUMBER.Text=="1")
                {
                    int Banki = blc.GetAllBankiCashTypeA();
                    int Money = blc.GetAllMoneyCashTypeA();
                    List<int> Numbers = new List<int>();
                    List<String> Names = new List<String>();
                    Numbers.Add(Banki);
                    Names.Add("بانکی");
                    Names.Add("نقدی");
                    Numbers.Add(Money);
                    //TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        Banking.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
                else
                {
                    int Banki = blc.GetAllBankiCashTypeB();
                    int Money = blc.GetAllMoneyCashTypeB();
                    List<int> Numbers = new List<int>();
                    List<String> Names = new List<String>();
                    Numbers.Add(Banki);
                    Names.Add("بانکی");
                    Names.Add("نقدی");
                    Numbers.Add(Money);
                    //TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        Banking.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
            }
            catch
            {

                MessageBox.Show("خطا");
            }
            //  Total
            foreach (var series in TotalCounter.Series)
            {
                series.Points.Clear();
            }
            try
            {
                if (ADMINNUMBER.Text=="1")
                {
                    int Sell = blc.GetAllSellCountA();
                    int Buy = blc.GetAllBuyCountA();
                    List<int> Numbers = new List<int>();
                    List<String> Names = new List<String>();
                    Numbers.Add(Sell);
                    Numbers.Add(Buy);
                    Names.Add("خریده شده");
                    Names.Add("فروخته شده");
                    //TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        TotalCounter.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
                else
                {
                    int Sell = blc.GetAllSellCountB();
                    int Buy = blc.GetAllBuyCountB();
                    List<int> Numbers = new List<int>();
                    List<String> Names = new List<String>();
                    Numbers.Add(Sell);
                    Numbers.Add(Buy);
                    Names.Add("خریده شده");
                    Names.Add("فروخته شده");
                    //TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        TotalCounter.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
            }
            catch
            {

                MessageBox.Show("خطا");
            }

        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = 0;
            if (e.Button==MouseButtons.Left || e.Button==MouseButtons.Right)
            {
                ID = int.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            }
            foreach (var series in Counter.Series)
            {
                series.Points.Clear();
            }
            try
            {
                if (ADMINNUMBER.Text=="1")
                {
                    int Sell = blc.GetProductsSellCountA(ID);
                    int Mojodi = blc.GetProductsMojodiCountA(ID);
                    List<String> Names = new List<String>();
                    Names.Add("فروخته شده");
                    Names.Add("موجود در انبار");
                    List<int> Numbers = new List<int>();
                    Numbers.Add(Sell);
                    Numbers.Add(Mojodi);
                    TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        Counter.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
                else
                {
                    int Sell = blc.GetProductsSellCountB(ID);
                    int Mojodi = blc.GetProductsMojodiCountB(ID);
                    List<String> Names = new List<String>();
                    Names.Add("فروخته شده");
                    Names.Add("موجود در انبار");
                    List<int> Numbers = new List<int>();
                    Numbers.Add(Sell);
                    Numbers.Add(Mojodi);
                    TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        Counter.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
            }
            catch
            {

                MessageBox.Show("خطا");
            }

        }

        private void AddValue_Click(object sender, EventArgs e)
        {
            foreach (var series in Analizy.Series)
            {
                series.Points.Clear();
                series.ChartType = SeriesChartType.Column;
            }
            try
            {
                if (ADMINNUMBER.Text=="1")
                {
                    Numbers.Add(Fun.ChangeToEnglishNumber(Valuetxt.Text));
                    Names.Add(NameM.Text);
                    for (int i = 0; i < Numbers.Count; i++)
                    {
                        Analizy.Series["آمار"].Points.AddXY(Names[i], Numbers[i]);
                    }

                }
                else
                {
                    Numbers.Add(Fun.ChangeToEnglishNumber(Valuetxt.Text));
                    Names.Add(NameM.Text);
                    for (int i = 0; i < Numbers.Count; i++)
                    {
                        Analizy.Series["آمار"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("خطا");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                Numbers.RemoveAt(Numbers.Count - 1);
                Names.RemoveAt(Names.Count - 1);
                foreach (var series in Analizy.Series)
                {
                    series.Points.Clear();
                    series.ChartType = SeriesChartType.Column;
                }
                for (int i = 0; i < Numbers.Count; i++)
                {
                    Analizy.Series["آمار"].Points.AddXY(Names[i], Numbers[i]);
                }
            }
            catch
            {
                foreach (var series in Analizy.Series)
                {
                    series.Points.Clear();
                    series.ChartType = SeriesChartType.Column;
                }
                MessageBox.Show("محدوده خالی شده مقدار جدید اضافه کنید");
            }
            
        }

        private void Valuetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DGV_KeyDown(object sender, KeyEventArgs e)
        {
            int ID;
            ID = int.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            foreach (var series in Counter.Series)
            {
                series.Points.Clear();
            }
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    int Sell = blc.GetProductsSellCountA(ID);
                    int Mojodi = blc.GetProductsMojodiCountA(ID);
                    List<String> Names = new List<String>();
                    Names.Add("فروخته شده");
                    Names.Add("موجود در انبار");
                    List<int> Numbers = new List<int>();
                    Numbers.Add(Sell);
                    Numbers.Add(Mojodi);
                    TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        Counter.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
                else
                {
                    int Sell = blc.GetProductsSellCountB(ID);
                    int Mojodi = blc.GetProductsMojodiCountB(ID);
                    List<String> Names = new List<String>();
                    Names.Add("فروخته شده");
                    Names.Add("موجود در انبار");
                    List<int> Numbers = new List<int>();
                    Numbers.Add(Sell);
                    Numbers.Add(Mojodi);
                    TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        Counter.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
            }
            catch
            {

                MessageBox.Show("خطا");
            }
        }

        private void DGV_KeyUp(object sender, KeyEventArgs e)
        {
            int ID;
            ID = int.Parse(DGV.CurrentRow.Cells[0].Value.ToString());
            foreach (var series in Counter.Series)
            {
                series.Points.Clear();
            }
            try
            {
                if (ADMINNUMBER.Text == "1")
                {
                    int Sell = blc.GetProductsSellCountA(ID);
                    int Mojodi = blc.GetProductsMojodiCountA(ID);
                    List<String> Names = new List<String>();
                    Names.Add("فروخته شده");
                    Names.Add("موجود در انبار");
                    List<int> Numbers = new List<int>();
                    Numbers.Add(Sell);
                    Numbers.Add(Mojodi);
                    TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        Counter.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
                else
                {
                    int Sell = blc.GetProductsSellCountB(ID);
                    int Mojodi = blc.GetProductsMojodiCountB(ID);
                    List<String> Names = new List<String>();
                    Names.Add("فروخته شده");
                    Names.Add("موجود در انبار");
                    List<int> Numbers = new List<int>();
                    Numbers.Add(Sell);
                    Numbers.Add(Mojodi);
                    TotalCounter.Palette = ChartColorPalette.Berry;

                    for (int i = 0; i < 2; i++)
                    {
                        Counter.Series["SellCount"].Points.AddXY(Names[i], Numbers[i]);
                    }
                }
            }
            catch
            {

                MessageBox.Show("خطا");
            }
        }
    }
}
