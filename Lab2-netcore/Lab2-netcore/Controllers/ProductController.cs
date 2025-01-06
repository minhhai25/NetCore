using Microsoft.AspNetCore.Mvc;
using Lab2_netcore.Models;
namespace Lab2_netcore.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products ;
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/01.jpg"
                },
                 new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/02.jpg"
                },
                  new Product()
                {
                    Id = 3,
                    Name = "Product 3",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/03.jpg"
                },
                   new Product()
                {
                    Id = 4,
                    Name = "Product 4",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/04.jpg"
                },
                    new Product()
                {
                    Id = 5,
                    Name = "Product 5",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/05.jpg"
                },
                     new Product()
                {
                    Id = 6,
                    Name = "Product 6",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/06.jpg"
                }
            };
            ViewBag.Products = products ;   
            return View();
        }
        [ Route("chi-tiet-san-pham",Name = "chitiet")]
        public IActionResult ChiTietSP(int id)
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/01.jpg"
                },
                 new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/02.jpg"
                },
                  new Product()
                {
                    Id = 3,
                    Name = "Product 3",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/03.jpg"
                },
                   new Product()
                {
                    Id = 4,
                    Name = "Product 4",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/04.jpg"
                },
                    new Product()
                {
                    Id = 5,
                    Name = "Product 5",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/05.jpg"
                },
                     new Product()
                {
                    Id = 6,
                    Name = "Product 6",
                    Description= "Đẹp handmade",
                    Price= 30000,
                    Image= "/Images/06.jpg"
                }
            };
            Product product = products.FirstOrDefault(pro => pro.Id == id);
            ViewBag.Product = product;
            return View();
        }
    }
}
