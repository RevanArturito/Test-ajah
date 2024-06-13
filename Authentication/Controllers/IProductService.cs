using Admin.ProdukSpek;

namespace Authentication.Controllers
{
    public interface IProductService
    {
        List<Produk> GetProducts();
        void AddProducts(Produk produk);
        Produk GetProductsById(int id);
        void DeleteProduct(int id);
    }
}
