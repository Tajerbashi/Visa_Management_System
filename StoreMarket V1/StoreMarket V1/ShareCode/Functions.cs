using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Entity;

namespace StoreMarket_V1
{
    public class Functions
    {
        public string GetPersianDate(DateTime date)
        {
            System.Globalization.PersianCalendar jc = new System.Globalization.PersianCalendar();
            int hr = int.Parse(jc.GetHour(date).ToString()) > 12 ? int.Parse(jc.GetHour(date).ToString()) - 12 : int.Parse(jc.GetHour(date).ToString());
            return string.Format("{0:0000}/{1:00}/{2:00}  {3:00}:{4:00}:{5:00}  ", jc.GetYear(date), jc.GetMonth(date), jc.GetDayOfMonth(date), hr, jc.GetMinute(date), jc.GetSecond(date));
        }
        public String CLOCK()
        {
            string ToDayShamsiDate = GetPersianDate(DateTime.Now);

            return ToDayShamsiDate;
        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        #region FunctionsProduct
        public void digitonly(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("کیبورد را عوض کنید", "Alert!");
            }
        }
        public string GetEnglishNumber(string persianNumber)
        {
            string englishNumber = "";
            foreach (char ch in persianNumber)
            {
                englishNumber += char.GetNumericValue(ch);
            }
            return englishNumber;
        }
        public bool SelecttypePA(String atp)
        {
            var q = from i in dbc.atypeProducts select i;
            foreach (var item in q)
            {
                if (item.Name == atp)
                {
                    return true;
                }
            }

            return false;
        }
        public bool SelecttypePB(String atp)
        {
            var q = from i in dbc.btypeProducts select i;
            foreach (var item in q)
            {
                if (item.Name == atp)
                {
                    return true;
                }
            }

            return false;
        }
        public bool savetpA(ATypeProduct atp)
        {
            if (!SelecttypePA(atp.Name))
            {
                dbc.atypeProducts.Add(new ATypeProduct
                {
                    Name = atp.Name
                });
                dbc.SaveChanges();
                return true;
            }
            return false;
        }
        public bool savetpB(BTypeProduct atp)
        {
            if (!SelecttypePB(atp.Name))
            {
                dbc.btypeProducts.Add(new BTypeProduct
                {
                    Name = atp.Name
                });
                dbc.SaveChanges();
                return true;
            }
            return false;
        }
        public bool selectPro(String code, String Name, String type)
        {
            if (code == "1")
            {
                foreach (var item in dbc.aProducts)
                {
                    if (item.Name == Name && item.Type == type)
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (var item in dbc.bProducts)
                {
                    if (item.Name == Name && item.Type == type)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool RegisterProductA(AProduct aProduct)
        {
            if (!selectPro("1", aProduct.Name, aProduct.Type))
            {
                dbc.aProducts.Add(new AProduct
                {
                    Name = aProduct.Name,
                    Type = aProduct.Type,
                    buyPrice = aProduct.buyPrice,
                    newBuyPrice = aProduct.buyPrice,
                    sellPrice = aProduct.sellPrice,
                    ManyP = aProduct.ManyP,
                    RegisterDate = aProduct.RegisterDate,
                    EndDate = aProduct.EndDate,
                    AgentName = aProduct.AgentName,
                    CashType = aProduct.CashType
                });
                dbc.SaveChanges();
                return true;
            }
            return false;
        }
        public bool RegisterProductB(BProduct bProduct)
        {
            if (!selectPro("2", bProduct.Name, bProduct.Type))
            {
                dbc.bProducts.Add(new BProduct
                {
                    Name = bProduct.Name,
                    Type = bProduct.Type,
                    buyPrice = bProduct.buyPrice,
                    newBuyPrice = bProduct.buyPrice,
                    sellPrice = bProduct.sellPrice,
                    ManyP = bProduct.ManyP,
                    RegisterDate = bProduct.RegisterDate,
                    EndDate = bProduct.EndDate,
                    AgentName = bProduct.AgentName,
                    CashType = bProduct.CashType
                });
                dbc.SaveChanges();
                return true;
            }
            return false;
        }

        #endregion
    }
}
