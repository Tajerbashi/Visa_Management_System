using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;
using BEE;
using System.Diagnostics;

namespace StoreMarket_V1
{
    public partial class ProductPanel : UserControl
    {
        public ProductPanel()
        {
            InitializeComponent();
        }
        BLLCode blc = new BLLCode();
        Image img;
        OpenFileDialog file = new OpenFileDialog();
        int IDP = 0;
        public String SavePic(String Code)
        {
            String AppPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Pictures\";
            if (Directory.Exists(AppPath) == false)
            {
                Directory.CreateDirectory(AppPath);
            }
            String iName = Code + ".jpg";
            try
            {
                String filepath = file.FileName;
                File.Copy(filepath, AppPath + iName);
            }
            catch
            {
                //String filepath = file.FileName;
                //File.Replace(filepath, AppPath + iName,AppPath+iName+"DEL");
                //MessageBox.Show("تصویر ذخیره نشد" + exp.Message);
                ResultPic.Visible = true;
                ResultPic.Text = "تصویر ذخیره نشد";
            }
            return AppPath + iName;
        }
        public void ShowProduct()
        {
            DGV1.Rows.Clear();
            int N = 1;
            if (ADMIN.Text=="1")
            {
                var DB = blc.GetProductsA();
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id,N,item.Name,item.Brand,item.Type,item.Mojodi,item.sellPrice);
                    N++;
                }
            }
            else
            {
                var DB = blc.GetProductsB();
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, N, item.Name, item.Brand, item.Type, item.Mojodi, item.sellPrice);
                    N++;
                }
            }
        }
        
        public void ShowResultSearch(String Word)
        {
            DGV1.Rows.Clear();

            int N = 1;
            if (ADMIN.Text == "1")
            {
                var DB = blc.ShowSearchResultA(Word);
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, N, item.Name, item.Brand, item.Type, item.Mojodi, item.sellPrice);
                    N++;
                }
            }
            else
            {
                var DB = blc.ShowSearchResultB(Word);
                foreach (var item in DB)
                {
                    DGV1.Rows.Add(item.id, N, item.Name, item.Brand, item.Type, item.Mojodi, item.sellPrice);
                    N++;
                }
            }
        }

        public void ShowPic()
        {
            IDP = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());

            if (ADMIN.Text == "1")
            {
                try
                {
                    AProduct product = blc.GetProductA(IDP);
                    if (product.Picture != null)
                    {
                        PicS.Visible = false;
                        Pic.Image = Image.FromFile(product.Picture);
                    }
                    else
                    {
                        PicS.Visible = true;
                    }
                    Details.Text = product.Details;
                }
                catch
                {
                    PicS.Visible = true;
                    ResultPic.Text = "تصویر موجود نیست جدیدی اضافه کنید";
                }
            }
            else
            {
                try
                {
                    BProduct product = blc.GetProductB(IDP);
                    if (product.Picture != null)
                    {
                        PicS.Visible = false;
                        Pic.Image = Image.FromFile(product.Picture);
                    }
                    else
                    {
                        PicS.Visible = true;
                    }
                    Details.Text = product.Details;

                }
                catch
                {
                    PicS.Visible = true;
                    ResultPic.Text = "تصویر موجود نیست جدیدی اضافه کنید";
                }
            }

        }

        private void ProductPanel_Load(object sender, EventArgs e)
        {
            ShowProduct();
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ADMIN.Text=="1")
            {
                AProduct product = blc.GetProductA(IDP);
                product.Picture = SavePic(product.id+"محصول");
                product.Details = Details.Text;
                blc.SavePicForProductA(product,IDP);
            }
            else
            {
                BProduct product = blc.GetProductB(IDP);
                product.Picture = SavePic(product.id + "محصول");
                product.Details = Details.Text;
                blc.SavePicForProductB(product,IDP);
            }
        }

        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right || e.Button==MouseButtons.Left)
            {
                DGV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                IDP = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());
            }
            ShowPic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file.Filter = "JPG(*.JPG)|*.JPG";
            if (file.ShowDialog() == DialogResult.OK)
            {
                PicS.Visible = false;
                img = Image.FromFile(file.FileName);
                Pic.Image = img;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String AppPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Pictures\";
            file.InitialDirectory = AppPath;
            file.ShowDialog();
            //if (File.Exists(AppPath))
            //{
                
            //}
        }

        private void DGV1_KeyDown(object sender, KeyEventArgs e)
        {
            ShowPic();

        }

        private void DGV1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DGV1_KeyUp(object sender, KeyEventArgs e)
        {
            ShowPic();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            ShowResultSearch(SearchTxt.Text);
        }

        private void Reloadbtn_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }

    }
}
