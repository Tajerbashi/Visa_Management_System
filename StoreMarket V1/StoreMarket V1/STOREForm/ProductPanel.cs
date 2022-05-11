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
    public partial class ProductPanel : UserControl
    {
        public ProductPanel()
        {
            InitializeComponent();
        }

        private void ProductPanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ProductControlForm pcf = new ProductControlForm();
            pcf.ADMINNUMBER.Text = ADMIN.Text;
            pcf.ShowDialog();
        }
    }
}
