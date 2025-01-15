using Lession02_Netcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lession02_Netcore.ViewComponents
{
	public class CategoryViewComponent: ViewComponent
	{
		public IViewComponentResult Invoke(int? n) {
			List<Category> categories = new List<Category>()
			{
				new Category()
				{
					Id = 1,
					Name = "Category 1",
					Description= "Đẹp handmade",
				},
				 new Category()
				{
					Id = 2,
					Name = "Category 2",
					Description= "Đẹp handmade",
				},
				  new Category()
				{
					Id = 3,
					Name = "Category 3",
					Description= "Đẹp handmade",
				},
				   new Category()
				{
					Id = 4,
					Name = "Category 4",
					Description= "Đẹp handmade",

				},
					new Category()
				{
					Id = 5,
					Name = "Category 5",
					Description= "Đẹp handmade",
				},
					 new Category()
				{
					Id = 6,
					Name = "Category 6",
					Description= "Đẹp handmade",
				}
			};
			if (n != null)
			{
				var search = categories.Where(x => x.Id == n);
				return View(search);
			}
			else
			{
				return View(categories);
			}
		}
	}
}
