using Admin.ProdukSpek;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produk>> Get()
        {
            return Ok(_productService.GetProducts());
        }


        [HttpPost]
        public IActionResult Post([FromBody] Produk newProduct)
        {
            if (newProduct == null)
            {
                return BadRequest("Product data is null.");
            }

            _productService.AddProducts(newProduct);
            return Ok(newProduct);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var account = _productService.GetProductsById(id);
            if (account == null)
            {
                return NotFound("Account not found.");
            }

            return Ok(account);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var products = _productService.GetProducts();
            if (products == null)
            {
                return NotFound("Account not found.");
            }

            _productService.DeleteProduct(id);
            return Ok(products);
        }
    }
}
