using FitLife.Controllers;
using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.GlobalConstants;
using FitLife.Web.ViewModels.Event;
using FitLife.Web.ViewModels.TrainingProgram;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Security.Claims;

namespace FitLife.Web.Controllers
{
    public class EventController : BaseController
    {
        private readonly IEventService eventService;
        private readonly ITrainerService trainerService;
        private readonly IParticipantService participantService;

        public EventController(IEventService _eventService,
            ITrainerService _trainerService,
            IParticipantService _participantService)
        {
            eventService = _eventService;
            trainerService = _trainerService;
            participantService = _participantService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllEventsQueryModel model)
        {
            var userId = User.Id();
            string userCity = string.Empty;

            if (userId != null)
            {
                userCity = await participantService.ParticipantCity(User.Id());


            }

            var events = await eventService.AllAsync(
                userCity,
                model.Category,
                model.SearchTerm,
                model.Sorting,
                model.CurrentPage,
                model.EventsPerPage);


            model.TotalEventsCount = events.TotalEventsCount;
            model.Events = events.Events;

            model.Categories = await eventService.AllCategoriesNamesAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            EventFormModel model = new()
            {
                EventCategories = await eventService.AllCategoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventFormModel model)
        {
            DateTime date = DateTime.Now;

            if (!DateTime.TryParseExact(model.StartTime,
                DataConstants.DateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date))
            {
                ModelState.AddModelError(nameof(model.StartTime), $"Invalid date format! Format should be {DataConstants.DateFormat}");
            }

            if (ModelState.IsValid == false)
            {
                model.EventCategories = await eventService.AllCategoriesAsync();
                return View(model);
            }

            string trainerId = await trainerService.GetTrainerByIdAsync(User.Id());

            if (trainerId != null)
            {
                string newEvent = await eventService.CreateAsync(model, trainerId);
            }

            return RedirectToAction(nameof(All));
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (await eventService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await eventService.EventDetailsByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Modify(string id)
        {
            if (await eventService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await eventService.HasTrainerWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            var model = await eventService.GetEventModifyModelByIdAsync(id);

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Modify(EventModifyModel model)
        {
            if (await eventService.ExistsAsync(model.Id) == false)
            {
                return BadRequest();
            }

            if (await eventService.HasTrainerWithIdAsync(model.Id, User.Id()) == false)
            {
                return Unauthorized();
            }

            if (await eventService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist!");
            }

            if (ModelState.IsValid == false)
            {
                model.EventCategories = await eventService.AllCategoriesAsync();
                return View(model);
            }

            await eventService.ModifyAsync(model.Id, model);

            return RedirectToAction(nameof(Details), new { model.Id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            if (await eventService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await eventService.HasTrainerWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            await eventService.DeleteAsync(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            string userId = User.Id();
            IEnumerable<EventServiceModel> events;

            if (await trainerService.ExistsByIdAsync(userId))
            {
                string? trainerId = await trainerService.GetTrainerByIdAsync(userId);

                events = await eventService.AllEventsByTrainerAsync(trainerId);


            }
            else
            {
                events = await eventService.AllEventsByParticipantAsync(userId);
            }

            return View(events);
        }

        [HttpPost]
        public async Task<IActionResult> Join(string id)
        {
            if (await eventService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await trainerService.ExistsByIdAsync(User.Id()))
            {
                return BadRequest();
            }

            if (await eventService.HasParticipantWithIdAsync(id, User.Id()))
            {
                return BadRequest();
            }

            await eventService.JoinAsync(id, User.Id());

            return RedirectToAction(nameof(All));
        }
    }
}
