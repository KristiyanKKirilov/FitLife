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

        public async Task<TrainingProgramQueryServiceModel> AllAsync(int currentPage = 1, int housesPerPage = 1)
        {
            var trainingProgramsToShow = repository.AllReadOnly<TrainingProgram>();

            var trainingPrograms = await trainingProgramsToShow
                .Skip((currentPage - 1) * housesPerPage)
                .Take(housesPerPage)
                .ProjectToTrainingProgramServiceModel()
                .ToListAsync();

            int totalTrainingPrograms = await trainingProgramsToShow.CountAsync();

            return new TrainingProgramQueryServiceModel()
            {
                TotalTrainingPrograms = totalTrainingPrograms,
                TrainingPrograms = trainingPrograms
            };
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

        public async Task<bool> ExistsAsync(string trainingProgramId)
        {
            return await repository
                .AllReadOnly<TrainingProgram>()
                .AnyAsync(tp => tp.Id == trainingProgramId);
        }

        public async Task<bool> HasTrainerWithIdAsync(string trainingProgramId, string userId)
        {
            return await repository
                .AllReadOnly<TrainingProgram>()
                .AnyAsync(tp => tp.Id == trainingProgramId && tp.Creator.UserId == userId);
        }

        public async Task<TrainingProgramDetailsServiceModel> TrainingProgramDetailsByIdAsync(string trainingProgramId)
        {
            return await repository
                .AllReadOnly<TrainingProgram>()
                .Where(tp => tp.Id == trainingProgramId)
                .Select(tp => new TrainingProgramDetailsServiceModel()
                {
                    Id = tp.Id,
                    Title = tp.Title,
                    ImageUrl = tp.ImageUrl,
                    Description = tp.Description,
                    Duration = tp.DurationDays,
                    StartDate = tp.StartDate,
                    CategoryName = tp.Category.Name,
                    CreatorEmail = tp.Creator.Email,
                    CreatorName = tp.Creator.FirstName + " " + tp.Creator.LastName,
                }).FirstAsync();
        }
    }
}
