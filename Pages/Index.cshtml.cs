using crafts.WebSite.Services;
using crafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace crafts.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public ProductJsonFileService ProductService;
    public IEnumerable<Product> Products { get; private set; } = default!;

    public IndexModel(ILogger<IndexModel> logger, ProductJsonFileService productService)
    {
        _logger = logger;
        ProductService = productService;
    }

    public void OnGet()
    {
        Products = ProductService.GetProducts();
    }
}
