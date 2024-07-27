using FitLife.Core.Contracts;
using FitLife.Web.Areas.Admin.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Web.Areas.Admin.Controllers
{
    public class ProductController : AdminBaseController
    {
        private IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        public async Task<IActionResult> Options()
        {
            var model = new ProductOptionsModel
            {
                Products = await productService
                .AllAsync()
            };

            return View(model);

        }
    }
}
