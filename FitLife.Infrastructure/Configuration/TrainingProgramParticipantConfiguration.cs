using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class TrainingProgramParticipantConfiguration : IEntityTypeConfiguration<TrainingProgramParticipant>
    {
        public void Configure(EntityTypeBuilder<TrainingProgramParticipant> builder)
        {
            builder.HasKey(tpt => new {tpt.ParticipantId, tpt.TrainingProgramId});  

            builder
                .HasOne(tpt => tpt.Participant)
                .WithMany(p => p.TrainingProgramsParticipants)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(tpt => tpt.TrainingProgram)
                .WithMany(t => t.TrainingProgramsParticipants)
                .OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
