using FitLife.Core.Contracts;
using FitLife.Data.Models;
using FitLife.GlobalConstants;
using FitLife.Web.ViewModels.TrainingProgram;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Security.Claims;

namespace FitLife.Controllers
{
    public class TrainingProgramController : BaseController
    {
        private readonly ITrainingProgramService trainingProgramService;
        private readonly ITrainerService trainerService;

        public TrainingProgramController(ITrainingProgramService _trainingProgramService, ITrainerService _trainerService)
        {
            trainingProgramService = _trainingProgramService;
            trainerService = _trainerService;

        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllTrainingProgramsQueryModel model)
        {
            var trainingPrograms = await trainingProgramService.AllAsync(
                model.CurrentPage,
                model.TrainingProgramsPerPage);

            model.TotalTrainingProgramsCount = trainingPrograms.TotalTrainingPrograms;
            model.TrainingPrograms = trainingPrograms.TrainingPrograms;

            return View(model);

        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            if(await trainingProgramService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await trainingProgramService.TrainingProgramDetailsByIdAsync(id);


            return View(model);
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

            if(ModelState.IsValid == false)
            {
                model.TrainingProgramCategories = await trainingProgramService.AllCategoriesAsync();
                return View(model);
            }

            string trainerId = await trainerService.GetTrainerByIdAsync(User.Id());

            if(trainerId != null)
            {
                string newTrainingProgram = await trainingProgramService.CreateAsync(model, trainerId);
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
