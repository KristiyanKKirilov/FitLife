using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Data;
using Microsoft.AspNetCore.Identity;
using FitLife.Core.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static FitLife.GlobalConstants.DataConstants;

namespace FitLife.Tests
{
	public class TrainerServiceTests
	{
		//Database and Services
		private FitLifeDbContext dbContext;

		private UserManager<Participant> userManager;
		private IRepository repository;
		private ITrainingProgramService trainingProgramService;
		private IParticipantService participantService;
		private ITrainerService trainerService;
		private IProductService productService;

		//Collections
		private IEnumerable<Trainer> trainers;

		//Users
		private Trainer trainerOne;
		private Trainer trainerTwo;
		private Trainer trainerThree;


		//Roles
		private Trainer traniner;
		[SetUp]
		public async Task Setup()
		{
			trainerOne = new Trainer()
			{
				Id = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
				FirstName = "Tom",
				LastName = "Johnson",
				Email = "first@gmail.com",
				UserId = "dea12856-c198-4129-b3f3-b893d8395082",

			};
			trainerTwo = new Trainer()
			{
				Id = "5525ab80-3107-4466-a27b-463fb35ad0eo",
				FirstName = "Freddy",
				LastName = "Philips",
				Email = "second@gmail.com",
				UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",

			};
			trainerThree = new Trainer()
			{
				Id = "5525ab80-3107-4466-a27b-463fb35ad0bb",
				FirstName = "Admin",
				LastName = "ItSelf",
				Email = "admin@gmail.com",
				UserId = "e04b5ff6-29e7-44d5-9b3b-0099d18de007",

			};

			trainers = new List<Trainer>() { trainerOne, trainerTwo, trainerThree };

			var options = new DbContextOptionsBuilder<FitLifeDbContext>()
				.UseInMemoryDatabase(databaseName: "FitLifeInMemoryDb" + Guid.NewGuid().ToString())
				.Options;

			dbContext = new FitLifeDbContext(options);

			dbContext.AddRangeAsync(trainers);
			dbContext.SaveChanges();

			var userStore = new UserStore<Participant>(dbContext);
			var passwordHasher = new PasswordHasher<Participant>();
			var optionsUserManager = Options.Create<IdentityOptions>(new IdentityOptions());
			userManager = new UserManager<Participant>(userStore, optionsUserManager, passwordHasher, null, null, null, null, null, null);

			repository = new Repository(dbContext);
			trainingProgramService = new TrainingProgramService(repository);
			trainerService = new TrainerService(repository);
			participantService = new ParticipantService(repository);
			productService = new ProductService(repository);
		}

		[TearDown]
		public async Task Teardown()
		{
			await this.dbContext.Database.EnsureDeletedAsync();
			await this.dbContext.DisposeAsync();
		}


		[Test]
		public void Trainer_ReturnsCorrect()
		{
			// Arrange

			var trainerId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e";
			var expected = true;
			// Act
			var result = trainerService.ExistsByIdAsync(trainerId).Result;

			// Assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Trainer_ReturnsCorrectTrainerByUserId()
		{
			// Arrange

			var userId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e";
			var expected = "5525ab80-3107-4466-a27b-463fb35ad0eo";
			// Act
			var result = trainerService.GetTrainerByIdAsync(userId).Result;

			// Assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Trainer_HireTrainerCorrectResult()
		{
			// Arrange
			var user = new Participant()
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
			var userId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e";
			var expected = true;
			// Act
			var result = trainerService.HireParticipantAsync(user);
			var resultTwo = trainerService.ExistsByIdAsync(user.Id).Result;
			// Assert
			Assert.AreEqual(expected, resultTwo);
		}
	}
}
