using Lab1_netcore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1_netcore.Controllers
{
    public class HomeController : Controller
    {
        List<Product> products;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
