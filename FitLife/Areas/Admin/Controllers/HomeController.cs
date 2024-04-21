using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitLife.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        private readonly IProductService productService;
        private readonly ITrainerService trainerService;
        private readonly ITrainingProgramService trainingProgramService;


        public HomeController(IProductService _productService,
            ITrainerService _trainerService,
            ITrainingProgramService _trainingProgramService)
        {
            productService = _productService;
            trainerService = _trainerService;
            trainingProgramService = _trainingProgramService;
        }

        public IActionResult DashBoard()
        {
            return View();
        }

        public async Task<IActionResult> ProductOptions()
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
