using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Web.ViewModels.TrainingProgram;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Core.Services
{
    public class TrainingProgramService : ITrainingProgramService
    {
        private readonly IRepository repository;

        public TrainingProgramService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<TrainingProgramCategoryServiceModel>> AllCategoriesAsync()
        {           

            return await repository.All<TrainingProgramCategory>()                
                 .Select(tpc => new TrainingProgramCategoryServiceModel()
                 {
                     Id = tpc.Id,
                     Name = tpc.Name
                 }).ToListAsync();
        }

        public async Task DeleteAsync(string trainingProgramCategoryId)
        {
            var model = await repository.GetByIdAsync<TrainingProgramCategory>(trainingProgramCategoryId);

            
        }
    }
}
