using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Web.ViewModels.TrainingProgram;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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

        public async Task<string> CreateAsync(TrainingProgramFormModel model, string trainerId)
        {
            var date = DateTime.Now;
           

            if(!DateTime.TryParseExact(model.StartDate, "dd/MM/yyyy hh:mm", 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None,
                out date))
            {
                throw new ArgumentException();
            }

            var trainingProgram = new TrainingProgram()
            {
                Title = model.Title,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                StartDate = date,
                DurationDays = model.DurationDays,
                CategoryId = model.CategoryId,
                CreatorId = trainerId
            };
            await repository.AddAsync(trainingProgram);
            await repository.SaveChangesAsync();

            return trainingProgram.Id;


        }
    }
}
