using FitLife.Web.ViewModels.TrainingProgram;

namespace FitLife.Core.Contracts
{
    public interface ITrainingProgramService
    {
        Task<TrainingProgramQueryServiceModel> AllAsync(int currentPage = 1, int housesPerPage = 1);
        Task<IEnumerable<TrainingProgramCategoryServiceModel>> AllCategoriesAsync();
        Task<TrainingProgramModifyModel?> GetTrainingProgramModifyModelByIdAsync(string trainingProgramId);
        //Task<IEnumerable<TrainingProgramServiceModel>> AllTrainingProgramsByTrainerAsync(string trainerId);
        //Task<IEnumerable<TrainingProgramServiceModel>> AllTrainingProgramsByParticipantAsync(string participantId);
        Task<TrainingProgramDetailsServiceModel> TrainingProgramDetailsByIdAsync(string trainingProgramId);

        Task<bool> HasParticipantWithIdAsync(string trainingProgramId, string participantId);
        Task<string> CreateAsync(TrainingProgramFormModel model, string trainerId);
        Task DeleteAsync(string trainingProgramId);
        Task<bool> CategoryExistsAsync(int categoryId);
        Task ModifyAsync(string trainingProgramId, TrainingProgramModifyModel model);

        Task<bool> ExistsAsync(string trainingProgramId);

        Task SubscribeAsync(string trainingProgramId, string userId);
        Task<bool> HasTrainerWithIdAsync(string trainingProgramId, string userId);


    }
}
