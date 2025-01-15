using Lession02_Netcore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lession02_Netcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //List<Product> products = new List<Product>()
            //{
            //    new Product()
            //    {
            //        Id = 1,
            //        Name = "Product 1",
            //        Description= "Đẹp handmade",
            //        Price= 30000,
            //    },
            //     new Product()
            //    {
            //        Id = 2,
            //        Name = "Product 2",
            //        Description= "Đẹp handmade",
            //        Price= 30000,
            //    },
            //      new Product()
            //    {
            //        Id = 3,
            //        Name = "Product 3",
            //        Description= "Đẹp handmade",
            //        Price= 30000,
            //    },
            //       new Product()
            //    {
            //        Id = 4,
            //        Name = "Product 4",
            //        Description= "Đẹp handmade",
            //        Price= 30000,

            //    },
            //        new Product()
            //    {
            //        Id = 5,
            //        Name = "Product 5",
            //        Description= "Đẹp handmade",
            //        Price= 30000,
            //    },
            //         new Product()
            //    {
            //        Id = 6,
            //        Name = "Product 6",
            //        Description= "Đẹp handmade",
            //        Price= 30000,
            //    }
            ////};
            //ViewBag.Products = products;
            return View();
        }

        public IActionResult Privacy()
        {
            getProduct();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public PartialViewResult getProduct()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1",
                    Description= "Đẹp handmade",
                    Price= 30000,
                },
                 new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    Description= "Đẹp handmade",
                    Price= 30000,
                },
                  new Product()
                {
                    Id = 3,
                    Name = "Product 3",
                    Description= "Đẹp handmade",
                    Price= 30000,
                },
                   new Product()
                {
                    Id = 4,
                    Name = "Product 4",
                    Description= "Đẹp handmade",
                    Price= 30000,
                   
                },
                    new Product()
                {
                    Id = 5,
                    Name = "Product 5",
                    Description= "Đẹp handmade",
                    Price= 30000,
                },
                     new Product()
                {
                    Id = 6,
                    Name = "Product 6",
                    Description= "Đẹp handmade",
                    Price= 30000,
                }
            };
            return PartialView("_ProductsPatialView", products);
        }
    }
}
