using FitLife.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Web.Areas.Admin.Controllers
{
	public class ParticipantController : AdminBaseController
	{
		private readonly IParticipantService participantService;

		public ParticipantController(IParticipantService _participantService)
		{
			participantService = _participantService;
		}

		public async Task<IActionResult> All()
		{
			var allParticipants = await participantService.AllAsync();
			return View(allParticipants);
		}
	}
}
