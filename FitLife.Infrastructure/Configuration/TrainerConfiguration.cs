using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasData(SeedTrainers());
        }

        private Trainer[] SeedTrainers()
        {
            return new Trainer[]
            {
                new Trainer()
                {
                    Id = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
                    FirstName = "Tom",
                    LastName = "Johnson",
                    Email = "first@gmail.com",
                    UserId = "dea12856-c198-4129-b3f3-b893d8395082",
                    
                },
                new Trainer()
                {
                    Id = "5525ab80-3107-4466-a27b-463fb35ad0eo",
                    FirstName = "Freddy",
                    LastName = "Philips",
                    Email = "second@gmail.com",
                    UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    
                }
            };
        }
    }
}
