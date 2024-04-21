using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.Data.Models;
using FitLife.Web.ViewModels.Event;
using FitLife.Web.ViewModels.Participant;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitLife.Web.Areas.Admin.Controllers
{
	public class TrainerController : AdminBaseController
	{		
		private readonly IParticipantService participantService;
		private readonly ITrainerService trainerService;

        public TrainerController(IParticipantService _participantService, ITrainerService _trainerService)
        {
			participantService = _participantService;
			trainerService = _trainerService;
        }

        [HttpGet]
		public async Task<IActionResult> Hire([FromQuery] AllParticipantsQueryModel model)
		{			

			var participants = await participantService.GetParticipantsAsync(model.SearchTerm);


			model.TotalParticipantsCount = participants.TotalParticipantsCount;
			model.Participants = participants.Participants;

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Hire(string id)
		{
			if(await participantService.ExistsByIdAsync(id) == false)
			{
				return BadRequest();
			}

			if(await trainerService.ExistsByIdAsync(id))
			{
				return BadRequest();
			}

			var participant = await participantService.GetByIdAsync(id);

			if(participant != null)
			{
                await trainerService.HireParticipantAsync(participant);
            }

			return RedirectToAction(nameof(Hire));	

		}
	}
}
