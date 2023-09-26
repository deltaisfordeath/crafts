using crafts.WebSite.Services;
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

        //[HttpPatch] "[FromBodyj]"
        [Route("rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string ProductId, 
            [FromQuery] int Rating
            )
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}