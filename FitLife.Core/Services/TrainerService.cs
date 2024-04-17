﻿using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
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
