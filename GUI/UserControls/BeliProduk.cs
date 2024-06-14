using Admin.ProdukSpek;
using Authentication.Controllers;
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
    public partial class BeliProduk : UserControl
    {
        Thread th;
        public static List<Produk> products = new List<Produk>();
        public BeliProduk()
        {
            InitializeComponent();
            LoadDataIntoListView();
        }

        public void openPayment(object obj)
        {
            //Application.Run(new Payment(produk));
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

        private void ButtonBeli_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Buat objek produk dari item yang dipilih
                Produk selectedProduct = new Produk
                (
                    selectedItem.SubItems[0].Text,
                    selectedItem.SubItems[1].Text,
                    selectedItem.SubItems[2].Text,
                    selectedItem.SubItems[3].Text,
                    selectedItem.SubItems[4].Text,
                    selectedItem.SubItems[5].Text,
                    int.Parse(selectedItem.SubItems[6].Text),
                    selectedItem.SubItems[7].Text
                );

                // Tampilkan form edit produk
                Payment paymentForm = new Payment(selectedProduct);
                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    // Update data di ListView
                    selectedItem.SubItems[1].Text = selectedProduct.namaproduk;
                    selectedItem.SubItems[2].Text = selectedProduct.jenis;
                    selectedItem.SubItems[3].Text = selectedProduct.hargaProduk;
                    selectedItem.SubItems[4].Text = selectedProduct.panjangProduk;
                    selectedItem.SubItems[5].Text = selectedProduct.lebarProduk;
                    selectedItem.SubItems[6].Text = selectedProduct.stokProduk.ToString();
                    selectedItem.SubItems[7].Text = selectedProduct.deskripsiProduk;
                }
                th = new Thread(openPayment);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            } else
            {
                MessageBox.Show(
                    "Silahkan pilih produk",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
           
        }
    }
}
