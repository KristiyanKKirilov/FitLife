namespace FitLife.Core.Contracts
{
    public interface IParticipantService
    {
        Task<string> ParticipantFirstName(string userId);
    }
}
