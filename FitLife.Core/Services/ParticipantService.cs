using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Web.ViewModels.Participant;
using Microsoft.EntityFrameworkCore;
using System.Liq;

namespace FitLife.Core.Services
{
    public class ParticipantService : IParticipantService
    {
        private readonly IRepository repository;

        public ParticipantService(IRepository _repository)
        {
            repository = _repository;
        }
       

		public async Task<string> ParticipantCity(string userId)
		{
			var participant = await repository
				.AllReadOnly<Participant>()
				.FirstAsync(p => p.Id == userId);

			if (string.IsNullOrEmpty(participant.FirstName))
			{
				return null;
			}

			return participant.City;
		}

		public async Task<ParticipantQueryServiceModel> AllAsync(string? searchTerm = null)
		{
			List<string> trainers = repository
				.AllReadOnly<Trainer>()
				.Select(t => t.UserId)
				.ToList();

			var participantsToShow = repository
				.AllReadOnly<Participant>()
				.Where(p => !trainers.Contains(p.Id));
				
			

			if (searchTerm != null)
			{
				string normalizedSearchTerm = searchTerm.ToLower();

				participantsToShow = participantsToShow
					.Where(p => p.FirstName.ToLower().Contains(normalizedSearchTerm)
							|| p.LastName.ToLower().Contains(normalizedSearchTerm)
							|| p.Email.ToLower().Contains(normalizedSearchTerm));
			}			

			var participants = await participantsToShow				
				.ProjectToParticipantServiceModel()
				.ToListAsync();

			int totalParticipants = await participantsToShow.CountAsync();

			return new ParticipantQueryServiceModel()
			{
				TotalParticipantsCount = totalParticipants,
				Participants = participants
			};
		}

        public async Task<bool> ExistsByIdAsync(string userId)
        {            
                return await repository
                     .AllReadOnly<Participant>()
                     .AnyAsync(p => p.Id == userId);            
        }

        public async Task<Participant> GetByIdAsync(string userId)
        {
			return await repository
				.AllReadOnly<Participant>()
				.FirstAsync(p => p.Id == userId);
        }
    }
}
