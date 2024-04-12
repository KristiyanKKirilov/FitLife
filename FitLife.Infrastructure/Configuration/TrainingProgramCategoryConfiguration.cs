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
                    
                },
                new TrainingProgramCategory()
                {
                    Id = 2,
                    Name = "Intermediate",
                    
                },
                new TrainingProgramCategory()
                {
                    Id = 3,
                    Name = "Expert",
                   
                },

            };
        }
    }
}
