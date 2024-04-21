using FitLife.Data.Models;
using FitLife.Web.ViewModels.Participant;

namespace FitLife.Core.Contracts
{
    public interface IParticipantService
    {
        
        Task<string> ParticipantCity(string userId);
        Task<bool> ExistsByIdAsync(string userId);
        Task<ParticipantQueryServiceModel> GetParticipantsAsync(string? searchTerm = null);
        Task<IEnumerable<AllParticipantsServiceModel>> AllAsync();
        Task<Participant> GetByIdAsync(string userId);

    }
}
