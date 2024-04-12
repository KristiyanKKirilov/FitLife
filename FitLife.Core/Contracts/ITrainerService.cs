namespace FitLife.Core.Contracts
{
    public interface ITrainerService
    {
        Task<bool> ExistsByIdAsync(string trainerId);
        Task<bool> TrainerHasTrainingProgramsAsync(string trainerId);
        Task<string?> GetTrainerByIdAsync(string userId);
    }
}
