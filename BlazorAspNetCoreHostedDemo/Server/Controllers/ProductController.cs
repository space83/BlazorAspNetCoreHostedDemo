using BlazorAspNetCoreHostedDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAspNetCoreHostedDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetProducts")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _productService.GetProducts();
        }

        [HttpGet]
        [Route("GetProduct")]
        public ActionResult<Product> DeleteProduct([FromQuery] int productCode)
        {
            return _productService.GetProduct(productCode);
        }

        [HttpPost]
        [Route("AddProduct")]
        public ActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                _productService.AddProduct(product);
                return Ok(product);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }

        }
    }
}
