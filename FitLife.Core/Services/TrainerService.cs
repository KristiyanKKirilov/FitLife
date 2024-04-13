using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<bool> TrainerHasTrainingProgramsAsync(string trainerId)
        {
            throw new NotImplementedException();
        }
    }
}
