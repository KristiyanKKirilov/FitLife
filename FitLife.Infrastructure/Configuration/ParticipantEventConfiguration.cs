using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class ParticipantEventConfiguration : IEntityTypeConfiguration<ParticipantEvent>
    {
        public void Configure(EntityTypeBuilder<ParticipantEvent> builder)
        {
            builder
                .HasKey(pe => new { pe.ParticipantId, pe.EventId });

            builder
                .HasOne(e => e.Participant)
                .WithMany(p => p.ParticipantsEvents)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(pe => pe.Event)
                .WithMany(e => e.ParticipantsEvents)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
