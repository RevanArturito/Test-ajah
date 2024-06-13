using Admin.ProdukSpek;
using Authentication.Controllers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ListProduct : UserControl
    {
        public static List<Produk> products = new List<Produk>();

        public ListProduct()
        {
            InitializeComponent();
            LoadDataIntoListView();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadDataIntoListView()
        {
            IProductService productService = new ProductService();
            products = productService.GetProducts();
            foreach (var produk in products)
            {
                ListViewItem item = new ListViewItem(produk.namaproduk);
                item.SubItems.Add(produk.jenis);
                item.SubItems.Add(produk.idProduk);
                item.SubItems.Add(produk.hargaProduk);
                item.SubItems.Add(produk.panjangProduk);
                item.SubItems.Add(produk.lebarProduk);
                item.SubItems.Add(produk.stokProduk.ToString());
                item.SubItems.Add(produk.deskripsiProduk);

                listView1.Items.Add(item);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Konfirmasi hapus produk ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (r == DialogResult.OK)
            {
                int nomorYangAkandiHapus = listView1.SelectedIndices[0];
                IProductService productService = new ProductService();
                productService.DeleteProduct(nomorYangAkandiHapus);
                listView1.Items.Clear();
                LoadDataIntoListView();
            }
            
        }
    }
}
