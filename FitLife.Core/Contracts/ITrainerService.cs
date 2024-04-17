using FitLife.Data.Models;

namespace FitLife.Core.Contracts
{
    public interface ITrainerService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<string?> GetTrainerByIdAsync(string userId);

        Task HireParticipantAsync(Participant participant);
    }
}
