using FitLife.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasData(SeedParticipants());
        }

        private Participant[] SeedParticipants()
        {
            var hasher = new PasswordHasher<Participant>();

            Participant firstUser = new Participant()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                FirstName = "Ivan",
                LastName = "Ivanov",
                UserName = "first@gmail.com",
                NormalizedUserName = "first@gmail.com",
                Email = "first@gmail.com",
                NormalizedEmail = "first@gmail.com",
                City = "Sofia",
                
            };

            firstUser.PasswordHash = hasher.HashPassword(firstUser, "A123456b");

            Participant secondUser = new Participant()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                FirstName = "Nikola",
                LastName = "Nikolaev",
                UserName = "second@gmail.com",
                NormalizedUserName = "second@gmail.com",
                Email = "second@gmail.com",
                NormalizedEmail = "second@gmail.com",
                City = "Varna",
                      
            };

            secondUser.PasswordHash = hasher.HashPassword(secondUser, "A123456b");

            Participant[] participants = new Participant[] { firstUser, secondUser };

            return participants;

        }

    }
}
