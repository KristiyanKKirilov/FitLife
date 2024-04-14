using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Core.Services
{
    public class ParticipantService : IParticipantService
    {
        private readonly IRepository repository;

        public ParticipantService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<string> ParticipantFirstName(string userId)
        {
            var participant = await repository
                .AllReadOnly<Participant>()
                .FirstAsync(p => p.Id ==  userId);

            if(string.IsNullOrEmpty(participant.FirstName))
            {
                return null;
            }

            return participant.FirstName;
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
	}
}
