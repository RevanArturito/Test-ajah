using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Admin.UserControls
{
    public partial class UC_ListProduk : UserControl
    {
        public UC_ListProduk()
        {
            InitializeComponent();
            LoadDataIntoListView();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class Produk
        {
            public string namaproduk { get; set; }
            public string jenis { get; set; }
            public string idProduk { get; set; }
            public string hargaProduk { get; set; }
            public string panjangProduk { get; set; }
            public string lebarProduk { get; set; }
            public int stokProduk { get; set; }
            public string deskripsiProduk { get; set; }
        }

        private void LoadDataIntoListView()
        {
            string filePath = "C:\\Programing\\C#\\12 JUNI PROGRES\\DeletDone\\Admin\\Admin\\bin\\Debug\\ProductsSolarPanels.JSON"; // Sesuaikan dengan path file JSON Anda

            // Membaca data dari file JSON
            string json = File.ReadAllText(filePath);

            // Deserialisasi data JSON menjadi daftar objek Produk
            List<Produk> produkList = JsonConvert.DeserializeObject<List<Produk>>(json);

            // Menambahkan setiap produk ke listView1
            foreach (var produk in produkList)
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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Menghapus item berdasarkan indeks
                int indexToRemove = listView1.SelectedIndices[0]; // Mengambil indeks item yang dipilih

                // Memuat ulang data dari JSON
                string filePath = "C:\\Programing\\C#\\12 JUNI PROGRES\\DeletDone\\Admin\\Admin\\bin\\Debug\\ProductsSolarPanels.JSON"; // Sesuaikan dengan path file JSON Anda
                string json = File.ReadAllText(filePath);
                List<Produk> produkList = JsonConvert.DeserializeObject<List<Produk>>(json);

                // Menghapus item dari list produk
                string namaProduk = produkList[indexToRemove].namaproduk;
                DeleteAdmin<Produk> delet = new DeleteAdmin<Produk>(produkList);
                delet.DeleteByIndex(indexToRemove);

                // Memperbarui listView1
                listView1.Items.RemoveAt(indexToRemove);

                // Menyimpan perubahan kembali ke file JSON
                string updatedJson = JsonConvert.SerializeObject(produkList, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);

                // Menampilkan pesan konfirmasi
                MessageBox.Show($"Produk {namaProduk} telah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pilih item yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
        public class DeleteAdmin<T>
        {
            private List<T> items;

            public DeleteAdmin(List<T> items)
            {
                this.items = items;
            }

            public void DeleteByIndex(int index)
            {

            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Indeks tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }
}
