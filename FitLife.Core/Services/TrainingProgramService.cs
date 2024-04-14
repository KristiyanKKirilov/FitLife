using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.GlobalConstants;
using FitLife.Web.ViewModels.TrainingProgram;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository
                .AllReadOnly<TrainingProgramCategory>()
                .AnyAsync(tpc => tpc.Id == categoryId);
        }

        public async Task<string> CreateAsync(TrainingProgramFormModel model, string trainerId)
        {
            var date = DateTime.Now;


            if (!DateTime.TryParseExact(model.StartDate, "dd/MM/yyyy hh:mm",
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

        public async Task DeleteAsync(string trainingProgramId)
        {
            var trainingProgram = await repository
                .GetByIdAsync<TrainingProgram>(trainingProgramId);

            if (trainingProgram != null)
            {
                repository.Remove(trainingProgram);
                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(string trainingProgramId)
        {
            return await repository
                .AllReadOnly<TrainingProgram>()
                .AnyAsync(tp => tp.Id == trainingProgramId);
        }

        public async Task<TrainingProgramModifyModel?> GetTrainingProgramModifyModelByIdAsync(string trainingProgramId)
        {
            var categories = AllCategoriesAsync();

            var trainingProgram = await repository
                .AllReadOnly<TrainingProgram>()
                .Where(tp => tp.Id == trainingProgramId)
                .Select(tp => new TrainingProgramModifyModel()
                {
                    Id = tp.Id,
                    Title = tp.Title,
                    ImageUrl = tp.ImageUrl,
                    StartDate = tp.StartDate.ToString(FitLife.GlobalConstants.DataConstants.DateFormat),
                    CategoryId = tp.CategoryId,
                    Description = tp.Description,
                    DurationDays = tp.DurationDays
                }).FirstOrDefaultAsync();

            if (trainingProgram != null)
            {
                trainingProgram.TrainingProgramCategories = await AllCategoriesAsync();
            }

            return trainingProgram;
        }

        public async Task<bool> HasParticipantWithIdAsync(string trainingProgramId, string participantId)
        {
            var trainingProgram = await repository
                .AllReadOnly<TrainingProgram>()
                .Where(tp => tp.Id == trainingProgramId)
                .Include(tp => tp.TrainingProgramsParticipants)
                .FirstOrDefaultAsync();
            if (trainingProgram != null)
            {
                if (trainingProgram.TrainingProgramsParticipants
                .Any(tp => tp.ParticipantId == participantId && tp.TrainingProgramId == trainingProgramId))
                {
                    return true;
                }
            }

            return false;

        }

        public async Task<bool> HasTrainerWithIdAsync(string trainingProgramId, string userId)
        {
            return await repository
                .AllReadOnly<TrainingProgram>()
                .AnyAsync(tp => tp.Id == trainingProgramId && tp.Creator.UserId == userId);
        }

        public async Task ModifyAsync(string trainingProgramId, TrainingProgramModifyModel model)
        {
            var trainingProgram = await repository
                .GetByIdAsync<TrainingProgram>(trainingProgramId);

            var date = DateTime.Now;

            if (!DateTime.TryParseExact(model.StartDate,
                DataConstants.DateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date))
            {
                throw new Exception();
            }

            if (trainingProgram != null)
            {
                trainingProgram.Title = model.Title;
                trainingProgram.ImageUrl = model.ImageUrl;
                trainingProgram.Description = model.Description;
                trainingProgram.StartDate = date;
                trainingProgram.DurationDays = model.DurationDays;
                trainingProgram.CategoryId = model.CategoryId;

                await repository.SaveChangesAsync();
            }
        }

        public async Task SubscribeAsync(string trainingProgramId, string userId)
        {
            var trainingProgram = await repository
                .GetByIdAsync<TrainingProgram>(trainingProgramId);

            if (trainingProgram != null)
            {
                trainingProgram.TrainingProgramsParticipants.Add(new TrainingProgramParticipant()
                {
                    ParticipantId = userId,
                    TrainingProgramId = trainingProgramId
                });

                await repository.SaveChangesAsync();
            }
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
