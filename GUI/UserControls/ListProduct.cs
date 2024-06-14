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
            //Application.Run(new EditProduct());
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

            if (listView1.SelectedItems.Count > 0)
            {
                // Menampilkan kotak dialog konfirmasi kepada pengguna saat tombol hapus diklik.
                DialogResult r = MessageBox.Show("Konfirmasi hapus produk ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // Memeriksa apakah pengguna mengklik tombol 'OK' di kotak dialog konfirmasi.
                //(ini merupakan penerapan bagian dari secure code yang dimana jika ingin delete user diberikan konfirmasi tambahan untuk delete produk tersebut )
                if (r == DialogResult.OK)
                {
                    // Mendapatkan indeks dari item yang dipilih di ListView untuk menentukan produk mana yang akan dihapus.
                    //Penggunaan camelCase pada variable baru
                    int nomorYangAkandiHapus = listView1.SelectedIndices[0];

                    // Membuat instance dari ProductService, yang menangani penghapusan produk.
                    IProductService productService = new ProductService();

                    // Memanggil metode DeleteProduct untuk menghapus produk pada indeks yang dipilih.
                    productService.DeleteProduct(nomorYangAkandiHapus);
                    listView1.Items.Clear();

                    // Memuat ulang data ke dalam ListView untuk mencerminkan perubahan.
                    LoadDataIntoListView();
                }
            }
            else
            {
                MessageBox.Show(
                    "Silahkan pilih produk",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
            else
            {
                MessageBox.Show(
                    "Silahkan pilih produk",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }


            th = new Thread(openEditor);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void UpdateJsonFile()
        {
            string filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\KONSTRUKSI PERANGKAT LUNAK\\TUBES2\\Authentication\\ProductsSolarPanels.json"; // Sesuaikan dengan path file JSON Anda

            // Buat daftar produk dari ListView
            List<Produk> produkList = new List<Produk>();
            foreach (ListViewItem item in listView1.Items)
            {
                Produk produk = new Produk
                (
                    item.SubItems[0].Text,
                    item.SubItems[1].Text,
                    item.SubItems[2].Text,
                    item.SubItems[3].Text,
                    item.SubItems[4].Text,
                    item.SubItems[5].Text,
                    int.Parse(item.SubItems[6].Text),
                    item.SubItems[7].Text
                );
                produkList.Add(produk);
            }

            // Serialisasi daftar produk ke JSON
            string json = JsonConvert.SerializeObject(produkList, Formatting.Indented);

            // Tulis data JSON ke file
            File.WriteAllText(filePath, json);
        }
    }
}
