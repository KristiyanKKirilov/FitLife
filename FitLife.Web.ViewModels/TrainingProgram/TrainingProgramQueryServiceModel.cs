namespace FitLife.Web.ViewModels.TrainingProgram
{
    public class TrainingProgramQueryServiceModel
    {
        public TrainingProgramQueryServiceModel()
        {
            TrainingPrograms = new List<TrainingProgramServiceModel>();
        }
        public int TotalTrainingPrograms { get; set; }

        public IEnumerable<TrainingProgramServiceModel> TrainingPrograms { get; set; }
    }
}
