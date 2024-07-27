using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Web.ViewModels.Participant;
using FitLife.Web.ViewModels.Trainer;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Core.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly IRepository repository;

        public TrainerService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<AllTrainersServiceModel>> AllAsync()
        {
            return await repository
                .AllReadOnly<Trainer>()
                .Select(p => new AllTrainersServiceModel()
                {
                    Id = p.Id,                    
                    FullName = p.FirstName + " " + p.LastName,
                    City = p.User.City,
                    Email = p.Email
                }).ToListAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
           return await repository
                .AllReadOnly<Trainer>()
                .AnyAsync(t => t.UserId == userId);
        }

        public async Task<string?> GetTrainerByIdAsync(string userId)
        {
            return (await repository.AllReadOnly<Trainer>()
                .FirstOrDefaultAsync(t => t.UserId == userId))?.Id;
        }

        public async Task HireParticipantAsync(Participant participant)
        {
            var newTrainer = new Trainer()
            {
                FirstName = participant.FirstName,
                LastName = participant.LastName,
                Email = participant.Email,
                UserId = participant.Id
            };

            await repository.AddAsync(newTrainer);
            await repository.SaveChangesAsync();
        }
    }
}
