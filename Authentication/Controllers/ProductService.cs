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
            List<Produk> products = GetProducts();
            if (products != null)
            {
                products.RemoveAt(id);
            }

            var HasilKonversi = JsonConvert.SerializeObject(products);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            using (StreamWriter write = new StreamWriter(_filePath))
            {
                write.Write(HasilKonversi);
            }
        }
    }
}
