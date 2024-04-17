using FitLife.Data.Models;
using FitLife.Web.ViewModels.Participant;

namespace FitLife.Core.Contracts
{
    public interface IParticipantService
    {
        
        Task<string> ParticipantCity(string userId);
        Task<bool> ExistsByIdAsync(string userId);
        Task<ParticipantQueryServiceModel> AllAsync(string? searchTerm = null);

        Task<Participant> GetByIdAsync(string userId);

    }
}
