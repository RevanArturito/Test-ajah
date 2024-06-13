using Admin.ProdukSpek;
using Newtonsoft.Json;
using System.Security.Principal;
using System.Text.Json;

namespace Authentication.Controllers
{
    public class ProductService : IProductService
    {
        private readonly string _filePath;

        public ProductService()
        {
            // Define the path to the account data file
            _filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\KONSTRUKSI PERANGKAT LUNAK\\TUBES2\\Authentication\\ProductsSolarPanels.json";
        }

        public void AddProducts(Produk produk)
        {
            List<Produk> product = GetProducts();
            product.Add(produk);

            var HasilKonversi = JsonConvert.SerializeObject(product);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            using (StreamWriter write = new StreamWriter(_filePath))
            {
                write.Write(HasilKonversi);
            }
        }

        public Produk GetProdukById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produk> GetProducts()
        {
            try
            {
                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<Produk>>(json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading Product data: {ex.Message}");
            }
        }

        public Produk GetProductsById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            // Mendeklarasikan daftar produk yang ada.
            List<Produk> productList = GetProducts();
            // Jika daftar produk tidak null, hapus produk pada indeks yang diberikan.
            if (productList != null)
            {
                // Menghapus produk pada indeks 'id' dari daftar produk.
                productList.RemoveAt(id);
            }

            // Mengonversi daftar produk yang telah diperbarui menjadi string JSON.
            var HasilKonversi = JsonConvert.SerializeObject(productList);

            // Membuat opsi untuk JSON Serializer, termasuk format indented untuk meningkatkan keterbacaan.
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            // Membuka file dengan StreamWriter pada jalur file yang ditentukan untuk menulis data yang diperbarui.
            using (StreamWriter write = new StreamWriter(_filePath))
            {
                // Menulis string JSON hasil konversi ke dalam file.
                write.Write(HasilKonversi);
            }
        }
    }
}
