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
        #endregion
    }
}
