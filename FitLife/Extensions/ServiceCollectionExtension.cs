using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.Data;
using FitLife.Data.Common;
using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ITrainingProgramService, TrainingProgramService>(); 
            services.AddScoped<ITrainerService, TrainerService>();  
            services.AddScoped<IParticipantService, ParticipantService>();
            services.AddScoped<IEventService, EventService>();  
                        
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<FitLifeDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<Participant>(options => 
            { 
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
            })
                    .AddEntityFrameworkStores<FitLifeDbContext>();
            return services;
        }
    }
}
