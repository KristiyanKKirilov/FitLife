using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class TrainingProgramCategoryConfiguration : IEntityTypeConfiguration<TrainingProgramCategory>
    {
        public void Configure(EntityTypeBuilder<TrainingProgramCategory> builder)
        {
            throw new NotImplementedException();
        }
    }
}
