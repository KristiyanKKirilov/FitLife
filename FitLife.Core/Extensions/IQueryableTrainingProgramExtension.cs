using FitLife.Data.Models;
using FitLife.Web.ViewModels.TrainingProgram;

namespace System.Linq
{
    public static class IQueryableTrainingProgramExtension
    {
        public static IQueryable<TrainingProgramServiceModel> ProjectToTrainingProgramServiceModel(this IQueryable<TrainingProgram> trainingPrograms)
        {
            return trainingPrograms
                .Select(tp => new TrainingProgramServiceModel()
                {
                    Id = tp.Id,
                    ImageUrl = tp.ImageUrl,
                    StartDate = tp.StartDate,
                    CategoryName = tp.Category.Name,
                    Title = tp.Title,
                    Duration = tp.DurationDays,
                    CreatorName = tp.Creator.FirstName + " " + tp.Creator.LastName
                });
        }
    }
}
