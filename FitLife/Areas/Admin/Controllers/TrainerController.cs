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
        public async Task<IActionResult> All()
        {
            var allTrainers = await trainerService.AllAsync();
            return View(allTrainers);
        }

        
	}
}
