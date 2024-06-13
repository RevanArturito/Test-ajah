using Admin.ProdukSpek;
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
    public partial class EditProduct : Form
    {
        public Produk Produk { get; set; }
        public EditProduct(Produk produk)
        {
            InitializeComponent();
            Produk = produk;

            // Isi kontrol dengan data produk
            InputNama.Text = Produk.namaproduk;
            InputTipe.Text = Produk.jenis;
            InputHarga.Text = Produk.hargaProduk;
            InputPanjang.Text = Produk.panjangProduk;
            InputLebar.Text = Produk.lebarProduk;
            InputStok.Text = Produk.stokProduk.ToString();
            InputDeskripsi.Text = Produk.deskripsiProduk;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(InputHarga.Text, out _) ||
                !int.TryParse(InputPanjang.Text, out _) ||
                !int.TryParse(InputLebar.Text, out _) ||
                !int.TryParse(InputStok.Text, out _))
            {

                MessageBox.Show("Input harga, panjang, lebar, dan stok harus berupa angka.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Produk.hargaProduk = InputHarga.Text;
                Produk.panjangProduk = InputPanjang.Text;
                Produk.lebarProduk = InputLebar.Text;
                Produk.stokProduk = int.Parse(InputStok.Text);
                Produk.namaproduk = InputNama.Text;
                Produk.jenis = InputTipe.Text;
                Produk.deskripsiProduk = InputDeskripsi.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
