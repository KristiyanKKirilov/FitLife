using FitLife.Core.Contracts;
using FitLife.Data.Models;
using FitLife.GlobalConstants;
using FitLife.Web.ViewModels.TrainingProgram;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Runtime.InteropServices;
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

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            IEnumerable<TrainingProgramServiceModel> model;

            if (await trainerService.ExistsByIdAsync(userId))
            {
                string? trainerId = await trainerService.GetTrainerByIdAsync(userId);
                model = await trainingProgramService.AllTrainingProgramsByTrainerAsync(userId);
            }
            else
            {
                model = await trainingProgramService.AllTrainingProgramsByParticipantAsync(userId);
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Modify(string id)
        {
            if(await trainingProgramService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.Id();

            if(await trainingProgramService.HasTrainerWithIdAsync(id, userId) == false)
            {
                return Unauthorized();
            }

            var trainingProgram = await trainingProgramService.GetTrainingProgramModifyModelByIdAsync(id);
                        
            return View(trainingProgram);
        }

        [HttpPost]
        public async Task<IActionResult> Modify(TrainingProgramModifyModel model)
        {
            if (!await trainingProgramService.ExistsAsync(model.Id))
            {
                return BadRequest();
            }

            string userId = User.Id();

            if (!await trainingProgramService.HasTrainerWithIdAsync(model.Id, userId))
            {
                return Unauthorized();
            }

            if (await trainingProgramService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
            }

            if (!ModelState.IsValid)
            {
                model.TrainingProgramCategories = await trainingProgramService.AllCategoriesAsync();
                return View(model);
            }

            await trainingProgramService.ModifyAsync(model.Id, model);
            return RedirectToAction(nameof(Details), new { model.Id });            
            
        }
        

        [HttpPost]
        public async Task<IActionResult> Subscribe(string id)
        {
            if(await trainingProgramService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.Id();

            if(await trainerService.ExistsByIdAsync(userId))
            {
                return Unauthorized();
            }

            if(await trainingProgramService.HasParticipantWithIdAsync(id, userId))
            {
                return BadRequest();
            }

            await trainingProgramService.SubscribeAsync(id, userId);

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            if(await trainingProgramService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.Id();

            if(await trainingProgramService.HasTrainerWithIdAsync(id, userId) == false)
            {
                return Unauthorized();
            }

            await trainingProgramService.DeleteAsync(id);

            return RedirectToAction(nameof(All));
        }
    }
}
