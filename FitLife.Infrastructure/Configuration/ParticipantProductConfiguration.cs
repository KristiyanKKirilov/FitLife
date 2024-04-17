using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class ParticipantProductConfiguration : IEntityTypeConfiguration<ParticipantProduct>
    {
        public void Configure(EntityTypeBuilder<ParticipantProduct> builder)
        {            

            builder
                .HasOne(pp => pp.Product)
                .WithMany(p => p.ParticipantsProducts)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(pp => pp.Participant)
               .WithMany(p => p.ParticipantsProducts)
               .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
