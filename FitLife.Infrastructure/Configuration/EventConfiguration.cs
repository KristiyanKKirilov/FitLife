using FitLife.Data.Models;
using FitLife.GlobalConstants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

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
                    Description = "Starting our run together at 7 oclock in the central park. Prepare yourself with comfortable shoes and big smile. The run will be 3km long and if it is needed, we will take a break and then continue our training!",
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/running-is-one-of-the-best-ways-to-stay-fit-royalty-free-image-1036780592-1553033495.jpg?crop=0.88976xw:1xh;center,top&resize=1200:*",
                    City = "Varna",
                    Address = "At the beginning of the sea garden, Varna",
                    StartTime = DateTime.ParseExact("04/12/2024 07:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
                    CategoryId = 1,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
                   
                },
                new Event()
                {
                    Id ="1525ab8f-3107-4466-a27b-463fb35ad0e9",
                    Title = "Healthy Food",
                    Description = "Seminar at the new business building in Sofia, we are going to discuss calorie deficit and proper training program depending on everyone's lifestyle! Don't be shy to participate and help us improve our seminars! We are waiting for you!",
                    ImageUrl = "https://images.squarespace-cdn.com/content/v1/5e113e254eae7b30460a0fba/1585970390295-ASEJJYD8ZYPY28IO48SE/IMG_6324.jpg",
                    City = "Sofia",
                    Address = "street. Bulgaria",
                    StartTime = DateTime.ParseExact("04/12/2024 10:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
                    CategoryId = 2,
                    CreatorId = "5525ab80-3107-4466-a27b-463fb35ad0eo",
                    
                },
                 new Event()
                {
                    Id ="f4130617-4f66-4775-8c6a-e80be1ea8380",
                    Title = "Coffee Time and Relax",
                    Description = "Get a coffee and meet a new friend in our new designed healthy bar food!",
                    ImageUrl = "https://ucare.inhersight.com/ff031afb-60c7-4bc4-ad17-bf3b1dac93f3/-/format/auto/-/quality/lighter/-/progressive/yes/-/resize/800x/",
                    City = "Varna",
                    Address = "Varna Center, near Starbucks",
                    StartTime = DateTime.ParseExact("09/05/2024 08:30", DataConstants.DateFormat, CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

                }
            };
        }
    }
}
