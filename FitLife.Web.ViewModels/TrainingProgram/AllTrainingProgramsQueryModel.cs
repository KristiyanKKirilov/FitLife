using System.ComponentModel.DataAnnotations;

namespace FitLife.Web.ViewModels.TrainingProgram
{
    public class AllTrainingProgramsQueryModel
    {
        public AllTrainingProgramsQueryModel()
        {
            TrainingPrograms = new List<TrainingProgramServiceModel>();
        }

        public int TrainingProgramsPerPage { get; } = 6;       

        public int CurrentPage { get; init; } = 1;

        public int TotalTrainingProgramsCount { get; set; }       

        public IEnumerable<TrainingProgramServiceModel> TrainingPrograms { get; set; }
       
    }
}
