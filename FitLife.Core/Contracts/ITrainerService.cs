using FitLife.Data.Models;
using FitLife.Web.ViewModels.Trainer;

namespace FitLife.Core.Contracts
{
    public interface ITrainerService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<string?> GetTrainerByIdAsync(string userId);

        Task HireParticipantAsync(Participant participant);
        Task<IEnumerable<AllTrainersServiceModel>> AllAsync();
    }
}
