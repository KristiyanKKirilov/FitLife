using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class TrainingProgramConfiguration : IEntityTypeConfiguration<TrainingProgram>
    {
        public void Configure(EntityTypeBuilder<TrainingProgram> builder)
        {
            builder.HasOne(tp => tp.Category)
                .WithMany(c => c.TrainingPrograms)
                .OnDelete(DeleteBehavior.Restrict);

           builder.HasData(SeedTrainingPrograms());
        }
        private TrainingProgram[] SeedTrainingPrograms()
        {
            return new TrainingProgram[]
            {
                new TrainingProgram()
                {
                    Id = "dea11856-c198-4129-b3f3-a893d8395022",
                    Title = "Jumping Month",
                    Description = "Burpies and jumping jacks to do in the morning and 20 minutes cardio afternoon are only the begining. Join us to be fit for the summer!",
                    ImageUrl = "https://media.istockphoto.com/id/637772834/photo/set-your-fitness-goals-high-and-reach-them.jpg?s=612x612&w=0&k=20&c=w0ZkUVwEOm6AUJO8eGqxeHt-Jrx5us5uK4BfWW9HDy8=",
                    StartDate = DateTime.Parse("04/22/2024"),
                    DurationDays = 14,
                    CategoryId = 2,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
                    
                },
                new TrainingProgram()
                {
                    Id = "dea22856-c198-4129-b3f3-a893d8395022",
                    Title = "Mass gain",
                    Description = "Gym is your second home and you want to achieve even more? Subscribe for our program to become better version of yourself only for 3 months!",
                    ImageUrl = "https://img.freepik.com/free-photo/low-angle-view-unrecognizable-muscular-build-man-preparing-lifting-barbell-health-club_637285-2497.jpg?size=626&ext=jpg&ga=GA1.1.1700460183.1712793600&semt=sph",
                    StartDate = DateTime.Parse("04/22/2024"),
                    DurationDays = 90,
                    CategoryId = 3,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
                                        
                },
            };
        }
    }
}
