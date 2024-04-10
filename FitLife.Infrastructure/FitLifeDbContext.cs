using FitLife.Data.Configuration;
using FitLife.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Data
{
    public class FitLifeDbContext : IdentityDbContext<Participant>
    {
        public FitLifeDbContext(DbContextOptions<FitLifeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; } = null!;

        public DbSet<EventCategory> EventCategories { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Participant> Participants { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Trainer> Trainers { get; set; } = null!;

        public DbSet<TrainerEvent> TrainersEvents { get; set; } = null!;

        public DbSet<TrainingProgram> TrainingPrograms { get; set; } = null!;

       public DbSet<TrainingProgramCategory> TrainingProgramCategories { get; set; } = null!;

        public DbSet<TrainingProgramTrainer> TrainingProgramsTrainers { get; set; } = null!;  


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new EventConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new TrainingProgramConfiguration());
            builder.ApplyConfiguration(new ParticipantEventConfiguration());
            builder.ApplyConfiguration(new TrainerEventConfiguration());
            builder.ApplyConfiguration(new TrainingProgramParticipantConfiguration());
            builder.ApplyConfiguration(new TrainingProgramTrainerConfiguration());
            
            base.OnModelCreating(builder);            

           
        }
        
    }
}