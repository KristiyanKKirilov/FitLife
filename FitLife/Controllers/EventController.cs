using FitLife.Controllers;
using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.Web.ViewModels.Event;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> All([FromQuery]AllEventsQueryModel model)
		{
			var userId = User.Id();
			string userCity = string.Empty;

			if(userId != null)
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
	}
}
