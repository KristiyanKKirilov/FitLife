using FitLife.Core.Contracts;
using FitLife.Web.Areas.Admin.Models;
using FitLife.Web.Areas.Admin.Models.TrainingProgram;
using FitLife.Web.ViewModels.TrainingProgram;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitLife.Web.Areas.Admin.Controllers
{
	public class TrainingProgramController : AdminBaseController
	{
		private readonly ITrainerService trainerService;
		private readonly ITrainingProgramService trainingProgramService;

		public TrainingProgramController(ITrainerService _trainerService,
			ITrainingProgramService _trainingProgramService)
		{
			trainerService = _trainerService;
			trainingProgramService = _trainingProgramService;
		}

        public async Task<IActionResult> Mine()
        {
            var myTrainingPrograms = new MyTrainingProgramViewModel();
            myTrainingPrograms.SubscribedTrainingPrograms = await trainingProgramService.AllTrainingProgramsByParticipantAsync(User.Id());

            var trainerId = await trainerService.GetTrainerByIdAsync(User.Id());

            if (trainerId != null)
            {
                myTrainingPrograms.AddedTrainingPrograms = await trainingProgramService.AllTrainingProgramsByTrainerAsync(trainerId);

            }

            return View(myTrainingPrograms);
        }
    }
}
