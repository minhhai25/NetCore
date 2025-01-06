using Lab1_netcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1_netcore.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products;
        public IActionResult Index()
        {

            products = new List<Product>() {
            new Product(1, "SP1", "Sản phẩm làm đẹp", 2000),
            new Product(2, "SP2", "Sản phẩm làm đẹp", 6000),
            new Product(3, "SP3", "Sản phẩm gia đình", 4000),
            new Product(3, "SP3", "Sản phẩm gia đình", 4000),};
            ViewBag.Products = products;
            return View();
        }
    }
}
