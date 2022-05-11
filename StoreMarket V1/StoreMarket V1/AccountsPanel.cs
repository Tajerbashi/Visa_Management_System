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
    public partial class AccountsPanel : UserControl
    {

        //#region CodeClick
        //const int HT_CAPTION = 0x2;
        //const int WM_NCLBUTTONDOWN = 0xA1;

        //[DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[DllImportAttribute("user32.dll")]
        //public static extern bool ReleaseCapture();
        //#endregion

        public AccountsPanel()
        {
            InitializeComponent();
        }
        BLLCode bll = new BLLCode();
        Functions Fun = new Functions();
        int ID = -1;
        bool SW = true;
        public void PrintCustomer(String Name)
        {
            DGV1.Rows.Clear();
            if (Name == "1")
            {
                var DB = bll.ShowAllCustomerA();
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, item.FullName, item.Phone, item.BuyCost);
                }
            }
            else
            {
                var DB = bll.ShowAllCustomerB();
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, item.FullName, item.Phone, item.BuyCost);
                }
            }
        }
        public void PrintSerchResult(String Admin, String Word)
        {
            DGV1.Rows.Clear();
            if (Admin == "1")
            {
                var DB = bll.PrintSerchResultCustomerA(Word);
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, item.FullName, item.Phone, item.BuyCost);
                }
            }
            else
            {
                var DB = bll.PrintSerchResultCustomerB(Word);
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, item.FullName, item.Phone, item.BuyCost);
                }
            }
        }
    }
}