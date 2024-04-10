using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class TrainingProgramConfiguration : IEntityTypeConfiguration<TrainingProgram>
    {
        public void Configure(EntityTypeBuilder<TrainingProgram> builder)
        {
            builder.HasOne(tp => tp.Category)
                .WithMany(c => c.TrainingPrograms)
                .OnDelete(DeleteBehavior.Restrict);            
        }
    }
}
