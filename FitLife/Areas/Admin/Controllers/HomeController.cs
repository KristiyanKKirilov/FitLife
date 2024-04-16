using FitLife.Core.Contracts;
using FitLife.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Web.Areas.Admin.Controllers
{
	public class HomeController : AdminBaseController
	{
		private readonly IProductService productService;

		public HomeController(IProductService _productService)
		{
			productService = _productService;
		}

		public IActionResult DashBoard()
		{
			return View();
		}

		public async Task<IActionResult> ProductOptions()
		{
			var model = new ProductOptionsModel()
			{
				ProductNames = await productService.GetAllProductsNamesAsync()
			};

			return View(model);
		}
	}
}
