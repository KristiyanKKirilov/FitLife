using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class TrainingProgramTrainerConfiguration : IEntityTypeConfiguration<TrainingProgramTrainer>
    {
        public void Configure(EntityTypeBuilder<TrainingProgramTrainer> builder)
        {
            builder.HasKey(tpt => new { tpt.TrainerId, tpt.TrainingProgramId });

            builder.HasOne(tpt => tpt.Trainer)
            .WithMany(t => t.TrainingProgramsTrainers)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(tpt => tpt.TrainingProgram)
            .WithMany(tp => tp.TrainingProgramsTrainers)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
