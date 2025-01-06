using Microsoft.AspNetCore.Mvc;
using NETCORE_Lesion01_MVC.Models;

namespace NETCORE_Lesion01_MVC.Controllers
{
	public class ProductController : Controller
	{
		List<Product> products;
		public IActionResult Index()
		{
			return View();
		}
        public IActionResult ListProduct()
        {
			products = new List<Product>() {
			new Product(1, "SP1", "Sản phẩm làm đẹp", 2000),
			new Product(2, "SP2", "Sản phẩm làm đẹp", 6000),
			new Product(3, "SP3", "Sản phẩm gia đình", 4000),
            new Product(4, "SP4", "Sản phẩm gia đình", 4000),
        };
		Product	product2 = new Product();
			product2.Name = "Test";
			products.Add(product2);
			
			
			ViewBag.Products = products;
            return View();
        }
		[Route("demo")]
        public IActionResult DemoDuLieu()
		{
			ViewData["viewData"] = "Dữ liệu đưuọc truyền qua viewData";
			ViewBag.viewBag = "Dữu liệu đươc truyền qua View Bag";
			TempData["tempData"] = "Dữ liệu được truyền qua tempData";
			return View();
		}

        public IActionResult ListProduct2()
        {
            products = new List<Product>() {
            new Product(1, "SP1", "Sản phẩm làm đẹp", 2000),
            new Product(2, "SP2", "Sản phẩm làm đẹp", 6000),
            new Product(3, "SP3", "Sản phẩm gia đình", 4000),
        
        };
           
            ViewData["Products"] = products;
            return View();
        }
    }
}
