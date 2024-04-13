namespace FitLife.Core.Contracts
{
    public interface ITrainerService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<bool> TrainerHasTrainingProgramsAsync(string trainerId);
        Task<string?> GetTrainerByIdAsync(string userId);
    }
}
