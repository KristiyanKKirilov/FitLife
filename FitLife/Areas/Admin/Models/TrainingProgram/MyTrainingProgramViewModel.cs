using FitLife.Web.ViewModels.TrainingProgram;

namespace FitLife.Web.Areas.Admin.Models.TrainingProgram
{
    public class MyTrainingProgramViewModel
    {
        public MyTrainingProgramViewModel()
        {
            AddedTrainingPrograms = new List<TrainingProgramServiceModel>();
            SubscribedTrainingPrograms = new List<TrainingProgramServiceModel>();
        }

        public IEnumerable<TrainingProgramServiceModel> AddedTrainingPrograms { get; set; }

        public IEnumerable<TrainingProgramServiceModel> SubscribedTrainingPrograms { get; set; }
    }
}
