using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class TrainerEventConfiguration : IEntityTypeConfiguration<TrainerEvent>
    {
        public void Configure(EntityTypeBuilder<TrainerEvent> builder)
        {
            builder.HasKey(te => new { te.TrainerId, te.EventId });

            builder
                .HasOne(te => te.Trainer)
                .WithMany(t => t.TrainersEvents)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(te => te.Event)
                .WithMany(e => e.TrainersEvents)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
