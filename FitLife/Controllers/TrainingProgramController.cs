using FitLife.Core.Contracts;
using FitLife.GlobalConstants;
using FitLife.Web.ViewModels.TrainingProgram;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace FitLife.Controllers
{
    public class TrainingProgramController : BaseController
    {
        private readonly ITrainingProgramService trainingProgramService;

        public TrainingProgramController(ITrainingProgramService _trainingProgramService)
        {
            trainingProgramService = _trainingProgramService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            TrainingProgramFormModel model = new()
            {
                TrainingProgramCategories = await trainingProgramService.AllCategoriesAsync()
            };
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TrainingProgramFormModel model)
        {
            DateTime date = DateTime.Now;   

            if (!DateTime.TryParseExact(model.StartDate,
                DataConstants.DateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date))
            {
                ModelState.AddModelError(nameof(model.StartDate), ErrorMessages.InvalidDateFormatError);
            }

            return RedirectToAction(nameof(All));
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Modify(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Modify()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int it)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe()
        {
            return RedirectToAction(nameof(All));
        }
    }
}
