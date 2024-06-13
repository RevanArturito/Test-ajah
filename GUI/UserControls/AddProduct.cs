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
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            CurrentUser currentUser = new CurrentUser();
            InitializeComponent();
            //InputNama.Text = $"{currentUser.GetCurrentUserName()}, {currentUser.getCurrentRoleUser()}, {currentUser.getCurrentEmailUser()} , {currentUser.getCurrentPhoneUser()}";
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            IProductService productService = new ProductService();

            // Retrieve input values from textboxes
            string inputNamaProduk = InputNama.Text;
            string inputTipeProduk = InputTipe.Text;
            string inputHargaProduk = InputHarga.Text;
            string inputPanjangProduk = InputPanjang.Text;
            string inputLebarProduk = InputLebar.Text;
            string inputStokProdukText = InputStok.Text;
            string inputDeskripsiProduk = InputDeskripsi.Text;

            // Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(inputNamaProduk) ||
                string.IsNullOrWhiteSpace(inputTipeProduk) ||
                string.IsNullOrWhiteSpace(inputHargaProduk) ||
                string.IsNullOrWhiteSpace(inputPanjangProduk) ||
                string.IsNullOrWhiteSpace(inputLebarProduk) ||
                string.IsNullOrWhiteSpace(inputStokProdukText) ||
                string.IsNullOrWhiteSpace(inputDeskripsiProduk))
            {
                MessageBox.Show(
                    "Input tidak boleh kosong",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Stop further execution
            }
            // Validate numeric fields
            if (!decimal.TryParse(inputHargaProduk, out decimal inputHargaProdukDecimal))
            {
                MessageBox.Show(
                    "Harga produk harus berupa angka desimal yang valid.",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Stop further execution
            }

            if (!decimal.TryParse(inputPanjangProduk, out decimal inputPanjangProdukDecimal))
            {
                MessageBox.Show(
                    "Panjang produk harus berupa angka desimal yang valid.",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Stop further execution
            }

            if (!decimal.TryParse(inputLebarProduk, out decimal inputLebarProdukDecimal))
            {
                MessageBox.Show(
                    "Lebar produk harus berupa angka desimal yang valid.",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Stop further execution
            }

            // Attempt to parse the stock input as an integer
            if (!int.TryParse(inputStokProdukText, out int inputStokProduk))
            {
                MessageBox.Show(
                    "Stok produk harus berupa angka.",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Stop further execution
            }

            // Additional length and format checks (example: max length 100 for name and description)
            if (inputNamaProduk.Length > 100)
            {
                MessageBox.Show(
                    "Nama produk tidak boleh lebih dari 100 karakter.",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Stop further execution
            }

            if (inputDeskripsiProduk.Length > 1000)
            {
                MessageBox.Show(
                    "Deskripsi produk tidak boleh lebih dari 1000 karakter.",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Stop further execution
            }
            // Initialize Random object for ID generation
            Random inputID = new Random();

            // Generate a 4-digit random number
            string randomText = "";
            for (int i = 0; i < 4; i++)
            {
                int randomNumber = inputID.Next(10);
                randomText += randomNumber.ToString();
            }

            DialogResult r = MessageBox.Show("Konfirmasi penambahan produk ?" , "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (r == DialogResult.OK)
            {
                // Display success message
                DialogResult result = MessageBox.Show(
                    $"Produk berhasil ditambahkan!" +
                    $"\n\nID Produk: {randomText}" +
                    $"\nNama Produk: {inputNamaProduk}" +
                    $"\nJenis: {inputTipeProduk}" +
                    $"\nHarga: Rp. {inputHargaProdukDecimal}" +
                    $"\nPanjang: {inputPanjangProdukDecimal} mm" +
                    $"\nLebar: {inputLebarProdukDecimal} mm" +
                    $"\nStok: {inputStokProduk} Unit" +
                    $"\nDeskripsi: {inputDeskripsiProduk}",
                    "Produk Ditambahkan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                productService.AddProducts(new Produk(randomText, inputNamaProduk, inputTipeProduk, inputHargaProduk, inputPanjangProduk, inputLebarProduk, inputStokProduk, inputDeskripsiProduk));

                InputNama.Text = "";
                InputTipe.Text = "";
                InputPanjang.Text = "";
                InputLebar.Text = "";
                InputHarga.Text = "";
                InputStok.Text = "";
                InputDeskripsi.Text = "";
            }
        }
    }
}
