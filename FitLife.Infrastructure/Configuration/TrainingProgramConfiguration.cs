using FitLife.Data.Models;
using FitLife.GlobalConstants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

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
                    StartDate = DateTime.ParseExact("08/09/2024 10:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
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
                    StartDate = DateTime.ParseExact("22/04/2024 13:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
                    DurationDays = 90,
                    CategoryId = 3,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
                                        
                },
                 new TrainingProgram()
                {
                    Id = "dd87ea80-b2fe-4034-aa6a-63d505837a15",
                    Title = "Summer body",
                    Description = "Beach training every afternoon to get 6 pack for the summer!",
                    ImageUrl = "https://thumbs.dreamstime.com/b/fitness-people-jumping-fitness-workout-beach-group-fitness-people-jumping-fitness-workout-beach-192257084.jpg",
                    StartDate = DateTime.ParseExact("21/06/2024 13:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
                    DurationDays = 7,
                    CategoryId = 1,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

                },
                 new TrainingProgram()
                {
                    Id = "8bb2f74c-dde5-4217-b985-0f623ec4349f",
                    Title = "Rock Climbers",
                    Description = "Be prepared for the montains in Bulgaria every year!",
                    ImageUrl = "https://i.namu.wiki/i/z4SlzF00Hi7dzXpkkj_mdNnXyY2WTHD6hmxzCks5e6PxQ7KwHosVlzQatl42tPiui_EICYUhL-iEBxxbRQUN7w.webp",
                    StartDate = DateTime.ParseExact("20/01/2024 11:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
                    DurationDays = 7,
                    CategoryId = 2,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

                },
                new TrainingProgram()
                {
                    Id = "dea22806-c198-4129-b3f3-a893d8395022",
                    Title = "Swim like a pro",
                    Description = "Summer swim trainings for people with a little bit of experience. We will teach you some techniques to improve your swimming skills.",
                    ImageUrl = "https://media.istockphoto.com/id/465383082/photo/female-swimmer-at-the-swimming-pool.webp?b=1&s=612x612&w=0&k=20&c=I4TM5zIDe-19EWq6OlzwZ1eqr8_tlEQ86SC-0eomEhU=",
                    StartDate = DateTime.ParseExact("19/07/2024 10:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
                    DurationDays = 28,
                    CategoryId = 2,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

                },
                 new TrainingProgram()
                {
                    Id = "dd87ea99-b2fe-4034-aa6a-63d505837a15",
                    Title = "Strong and flexible",
                    Description = "Crossfit gives you the opportunity to look good, feel good and train different from others. If you are bored from the gym and you are looking to start some new challenge, our crossfit program is the right place for you!",
                    ImageUrl = "https://www.crossfit.com/wp-content/uploads/2023/11/13131232/crossfit-coach-led-fitness-training-adapted-for-you-handstand-hold.jpg",
                    StartDate = DateTime.ParseExact("05/11/2024 20:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
                    DurationDays = 60,
                    CategoryId = 2,
                    CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

                },
            };
        }
    }
}
