using Lession7NETCORE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using XSystem.Security.Cryptography;

namespace Lession7NETCORE.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class LoginController : Controller
    {
        private readonly Tes1Context _context;
		public LoginController(Tes1Context context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Login model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var pass = getHashSha256(model.Password);

            var login = _context.Adminusers.Where(x=>x.UserName.Equals(model.UserName)&& x.Password.Equals(pass)).FirstOrDefault();
            if(login!=null)
            {
				HttpContext.Session.SetString("AdminLogin", model.UserName);
				return RedirectToAction("Index", "Dashboard");
			}
           return View();
        }
		public static string getHashSha256(string text)
		{
			string hash = "";
			using (var sha256 = new SHA256Managed())
			{
				var hashdBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
				hash = BitConverter.ToString(hashdBytes).Replace("-", "").ToLower();
			}
			return hash;
		}
		public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin");

            return RedirectToAction("Index");
        }
    }
}
