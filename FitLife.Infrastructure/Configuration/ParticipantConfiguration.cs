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
                FirstName = "Tom",
                LastName = "Johnson",
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
                FirstName = "Freddy",
                LastName = "Philips",
                UserName = "second@gmail.com",
                NormalizedUserName = "second@gmail.com",
                Email = "second@gmail.com",
                NormalizedEmail = "second@gmail.com",
                City = "Varna",
                      
            };

            secondUser.PasswordHash = hasher.HashPassword(secondUser, "A123456b");

            Participant thirdUser = new Participant()
            {
                Id = "ad1cc9c3-9fda-440a-a729-1baa02aef94d",
                FirstName = "Chris",
                LastName = "Stevens",
                UserName = "third@gmail.com",
                NormalizedUserName = "THIRD@GMAIL.COM",
                Email = "third@gmail.com",
                NormalizedEmail = "THIRD@GMAIL.COM",
                City = "Ruse",

            };

            thirdUser.PasswordHash = hasher.HashPassword(thirdUser, "A123456b");

            Participant fourthUser = new Participant()
            {
                Id = "e04b5ff6-29e7-44d5-9b3b-0099d18debd7",
                FirstName = "TEST",
                LastName = "SOFTUNI",
                UserName = "test@softuni.bg",
                NormalizedUserName = "TEST@SOFTUNI.BG",
                Email = "test@softuni.bg",
                NormalizedEmail = "TEST@SOFTUNI.BG",
                City = "SOFIA",

            };

            fourthUser.PasswordHash = hasher.HashPassword(fourthUser, "A123456b");

            Participant[] participants = new Participant[] { firstUser, secondUser, thirdUser, fourthUser };

            return participants;

        }

    }
}
