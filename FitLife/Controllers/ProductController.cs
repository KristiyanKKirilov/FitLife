using FitLife.Controllers;
using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.Web.ViewModels.Event;
using FitLife.Web.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
using static FitLife.GlobalConstants.RoleConstants;

namespace FitLife.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly IParticipantService participantService;

        public ProductController(IProductService _productService,
            IParticipantService _participantService)
        {
            productService = _productService;
            participantService = _participantService;

        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllProductsQueryModel model)
        {

            var products = await productService.AllAsync(model.SearchTerm, model.Sorting);


            model.TotalProductsCount = products.TotalProductsCount;
            model.Products = products.Products;

            return View(model);
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (await productService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await productService.ProductDetailsByIdAsync(id);

            return View(model);
        }

        [Authorize(Roles = AdminRole)]
        [HttpGet]
        public IActionResult Add()
        {
            var model = new ProductFormModel();

            return View(model);
		}

		[Authorize(Roles = AdminRole)]
        [HttpPost]
		public async Task<IActionResult> Add(ProductFormModel model)
		{
		    if(ModelState.IsValid == false)
            {
                return BadRequest();
            }

            string newProduct = await productService.CreateAsync(model);

            return RedirectToAction(nameof(All));
		}

		[Authorize(Roles = AdminRole)]
		[HttpGet]
		public async Task<IActionResult> Modify(string name)
		{
            string id = string.Empty;

            if (name != null)
            {
                id = await productService.GetProductIdByNameAsync(name);
            }

            if (await productService.ExistsAsync(id) == false)
			{
				return BadRequest();
			}			
            if(id == "")
            {
                return BadRequest();
            }
			var model = await productService.GetProductModifyModelByIdAsync(id);

			return View(model);
		}

		//[HttpPost]
		//public async Task<IActionResult> Modify(EventModifyModel model)
		//{
		//	if (await eventService.ExistsAsync(model.Id) == false)
		//	{
		//		return BadRequest();
		//	}

		//	if (await eventService.HasTrainerWithIdAsync(model.Id, User.Id()) == false
		//		 && User.IsAdmin() == false)
		//	{
		//		return Unauthorized();
		//	}

		//	if (await eventService.CategoryExistsAsync(model.CategoryId) == false)
		//	{
		//		ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist!");
		//	}

		//	if (ModelState.IsValid == false)
		//	{
		//		model.EventCategories = await eventService.AllCategoriesAsync();
		//		return View(model);
		//	}

		//	await eventService.ModifyAsync(model.Id, model);

		//	return RedirectToAction(nameof(Details), new { model.Id });
		//}
	}
}
