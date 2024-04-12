using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasOne(e => e.Category)
                .WithMany(c => c.Events)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Creator)
                .WithMany(c => c.Events)
                .OnDelete(DeleteBehavior.Restrict);

           builder.HasData(SeedEvents());
        }

        private Event[] SeedEvents()
        {
            return new Event[]
            {
                new Event()
                {
                    Id = "5526ab8f-3107-4466-a27b-463fb35ad0e9",
                    Title = "Morning Run",
                    Description = "Starting our run together at 8 am in the central park. Prepare yourself with comfortable shoes and big smile.",
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/running-is-one-of-the-best-ways-to-stay-fit-royalty-free-image-1036780592-1553033495.jpg?crop=0.88976xw:1xh;center,top&resize=1200:*",
                    City = "Varna",
                    Address = "Park",
                    StartTime = DateTime.Parse("04/12/2024"),
                    CategoryId = 1,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
                    CreatedOn = DateTime.Parse("04/11/2024"),
                    IsDeleted = false
                },
                new Event()
                {
                    Id ="1525ab8f-3107-4466-a27b-463fb35ad0e9",
                    Title = "Healthy Food",
                    Description = "Seminar at the new bussines building in Sofia, we are going to discuss calorie deficit and proper training program",
                    ImageUrl = "https://images.squarespace-cdn.com/content/v1/5e113e254eae7b30460a0fba/1585970390295-ASEJJYD8ZYPY28IO48SE/IMG_6324.jpg",
                    City = "Sofia",
                    Address = "street. Bulgaria",
                    StartTime = DateTime.Parse("04/12/2024"),
                    CategoryId = 2,
                    CreatorId = "5525ab80-3107-4466-a27b-463fb35ad0eo",
                    CreatedOn = DateTime.Parse("04/11/2024"),
                    IsDeleted = false
                },
            };
        }
    }
}
