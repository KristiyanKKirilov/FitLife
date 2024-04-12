using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class TrainingProgramCategoryConfiguration : IEntityTypeConfiguration<TrainingProgramCategory>
    {
        public void Configure(EntityTypeBuilder<TrainingProgramCategory> builder)
        {
            builder.HasData(SeedTrainingProgramCategories());
        }

        private TrainingProgramCategory[] SeedTrainingProgramCategories()
        {
            return new TrainingProgramCategory[]
                {
                new TrainingProgramCategory()
                {
                    Id = 1,
                    Name = "Beginner",
                    CreatedOn = DateTime.Parse("04/11/2024"),
                    IsDeleted = false
                },
                new TrainingProgramCategory()
                {
                    Id = 2,
                    Name = "Intermediate",
                    CreatedOn = DateTime.Parse("04/11/2024"),
                    IsDeleted = false
                },
                new TrainingProgramCategory()
                {
                    Id = 3,
                    Name = "Expert",
                    CreatedOn = DateTime.Parse("04/11/2024"),
                    IsDeleted = false
                },

            };
        }
    }
}
