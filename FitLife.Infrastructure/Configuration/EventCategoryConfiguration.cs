using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class EventCategoryConfiguration : IEntityTypeConfiguration<EventCategory>
    {
        public void Configure(EntityTypeBuilder<EventCategory> builder)
        {
            builder.HasData(SeedEventCategories());
        }

        private EventCategory[] SeedEventCategories()
        {
            return new EventCategory[]
            {
                new EventCategory()
                {
                    Id = 1,
                    Name = "Sport",
                    CreatedOn = DateTime.Parse("11/04/2024"),
                    IsDeleted = false
                },
                new EventCategory()
                {
                    Id = 2,
                    Name = "Seminar",
                    CreatedOn = DateTime.Parse("11/04/2024"),
                    IsDeleted = false
                },
                new EventCategory()
                {
                    Id = 3,
                    Name = "Entertainment",
                    CreatedOn = DateTime.Parse("11/04/2024"),
                    IsDeleted = false
                }
            };
        }
    }
}
