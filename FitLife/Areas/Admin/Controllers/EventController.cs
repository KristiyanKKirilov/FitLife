using FitLife.Core.Contracts;
using FitLife.Web.Areas.Admin.Models;
using FitLife.Web.Areas.Admin.Models.Event;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitLife.Web.Areas.Admin.Controllers
{
    public class EventController : AdminBaseController
    {
        private readonly ITrainerService trainerService;
        private readonly IEventService eventService;

        public EventController(ITrainerService _trainerService,
            IEventService _eventService)
        {
            trainerService = _trainerService;
            eventService = _eventService;
        }

        public async Task<IActionResult> Mine()
        {
            var myEvents = new MyEventViewModel();
            myEvents.JoinedEvents = await eventService.AllEventsByParticipantAsync(User.Id());

            var trainerId = await trainerService.GetTrainerByIdAsync(User.Id());

            if (trainerId != null)
            {
                myEvents.AddedEvents = await eventService.AllEventsByTrainerAsync(trainerId);

            }

            return View(myEvents);
        }
    }
}
