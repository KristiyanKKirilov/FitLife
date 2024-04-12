using FitLife.Web.ViewModels.TrainingProgram;

namespace FitLife.Core.Contracts
{
    public interface ITrainingProgramService
    {
        //Task<TrainingProgramQueryServiceModel> AllAsync(int currentPage = 1, int housesPerPage = 1);
        Task<IEnumerable<TrainingProgramCategoryServiceModel>> AllCategoriesAsync();
        Task DeleteAsync(string trainingProgramCategoryId);
        //Task<IEnumerable<TrainingProgramServiceModel>> AllTrainingProgramsByTrainerAsync(string trainerId);
        //Task<IEnumerable<TrainingProgramServiceModel>> AllTrainingProgramsByParticipantAsync(string participantId);

        //Task<int> CreateAsync(TrainingProgramFormModel model, int trainerId);
        //Task DeleteAsync(int trainingProgramId);
        //Task EditAsync(int trainingProgramId, TrainingProgramFormModel model);

        //Task<bool> ExistsAsync(int trainingProgramId);

        //Task<bool> HasTrainerWithIdAsync(string trainingProgramId, string trainerId);


    }
}
