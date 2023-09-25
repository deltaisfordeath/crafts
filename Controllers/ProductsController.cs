using ContosoCrafts.WebSite.Services;
using crafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace crafts.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        public ProductsController(ProductJsonFileService productService)
        {
            this.ProductService = productService;
        }

        public ProductJsonFileService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}