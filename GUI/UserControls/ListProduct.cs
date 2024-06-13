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
        Thread th;
        public static List<Produk> products = new List<Produk>();

        public void openEditor(object obj)
        {
            Application.Run(new EditProduct());
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Ambil item yang dipilih
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Buat objek produk dari item yang dipilih
                Produk selectedProduct = new Produk
                {
                    idProduk = selectedItem.SubItems[0].Text,
                    namaproduk = selectedItem.SubItems[1].Text,
                    jenis = selectedItem.SubItems[2].Text,
                    hargaProduk = selectedItem.SubItems[3].Text,
                    panjangProduk = selectedItem.SubItems[4].Text,
                    lebarProduk = selectedItem.SubItems[5].Text,
                    stokProduk = int.Parse(selectedItem.SubItems[6].Text),
                    deskripsiProduk = selectedItem.SubItems[7].Text
                };

                // Tampilkan form edit produk
                EditProduct editForm = new EditProduct(selectedProduct);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update data di ListView
                    selectedItem.SubItems[1].Text = selectedProduct.namaproduk;
                    selectedItem.SubItems[2].Text = selectedProduct.jenis;
                    selectedItem.SubItems[3].Text = selectedProduct.hargaProduk;
                    selectedItem.SubItems[4].Text = selectedProduct.panjangProduk;
                    selectedItem.SubItems[5].Text = selectedProduct.lebarProduk;
                    selectedItem.SubItems[6].Text = selectedProduct.stokProduk.ToString();
                    selectedItem.SubItems[7].Text = selectedProduct.deskripsiProduk;

                    // Update file JSON
                    UpdateJsonFile();
                }
            }

            th = new Thread(openEditor);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void UpdateJsonFile()
        {
            string filePath = "D:\\codingan\\Admin\\Admin\\ProductsSolarPanel.json"; // Sesuaikan dengan path file JSON Anda

            // Buat daftar produk dari ListView
            List<Produk> produkList = new List<Produk>();
            foreach (ListViewItem item in listView1.Items)
            {
                Produk produk = new Produk
                {
                    idProduk = item.SubItems[0].Text,
                    namaproduk = item.SubItems[1].Text,
                    jenis = item.SubItems[2].Text,
                    hargaProduk = item.SubItems[3].Text,
                    panjangProduk = item.SubItems[4].Text,
                    lebarProduk = item.SubItems[5].Text,
                    stokProduk = int.Parse(item.SubItems[6].Text),
                    deskripsiProduk = item.SubItems[7].Text
                };
                produkList.Add(produk);
            }

            // Serialisasi daftar produk ke JSON
            string json = JsonConvert.SerializeObject(produkList, Formatting.Indented);

            // Tulis data JSON ke file
            File.WriteAllText(filePath, json);
        }
    }
}
