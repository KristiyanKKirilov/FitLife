using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.Data;
using FitLife.Data.Common;
using FitLife.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FitLife.Tests
{
	public class ParticipantServiceTests
	{
		//Database and Services
		private FitLifeDbContext dbContext;

		private UserManager<Participant> userManager;
		private IRepository repository;
		private ITrainingProgramService trainingProgramService;
		private IParticipantService participantService;
		private ITrainerService trainerService;

		//Collections
		private IEnumerable<Participant> users;

		//Users
		private Participant userOne;
		private Participant userTwo;
		private Participant userThree;
		private Participant userFour;
		private Participant userFive;

		//Roles
		private Trainer traniner;
		[SetUp]
		public async Task Setup()
		{

			var hasher = new PasswordHasher<Participant>();

			userOne = new Participant()
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

			userOne.PasswordHash = hasher.HashPassword(userOne, "A123456b");

			userTwo = new Participant()
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

			userTwo.PasswordHash = hasher.HashPassword(userTwo, "A123456b");

			userThree = new Participant()
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

			userThree.PasswordHash = hasher.HashPassword(userThree, "A123456b");

			userFour = new Participant()
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

			userFour.PasswordHash = hasher.HashPassword(userFour, "A123456b");

			userFive = new Participant()
			{
				Id = "e04b5ff6-29e7-44d5-9b3b-0099d18de007",
				FirstName = "Admin",
				LastName = "ItSelf",
				UserName = "admin@gmail.com",
				NormalizedUserName = "ADMIN@GMAIL.COM",
				Email = "admin@gmail.com",
				NormalizedEmail = "ADMIN@GMAIL.COM",
				City = "Varna",

			};

			userFive.PasswordHash = hasher.HashPassword(userFive, "A123456b");

			users = new List<Participant>() { userOne, userTwo, userThree, userFour, userFive};

			var options = new DbContextOptionsBuilder<FitLifeDbContext>()
				.UseInMemoryDatabase(databaseName: "NovelNestInMemoryDb" + Guid.NewGuid().ToString())
				.Options;

			dbContext = new FitLifeDbContext(options);

			dbContext.AddRangeAsync(users);
			dbContext.SaveChanges();

			var userStore = new UserStore<Participant>(dbContext);
			var passwordHasher = new PasswordHasher<Participant>();
			var optionsUserManager = Options.Create<IdentityOptions>(new IdentityOptions());
			userManager = new UserManager<Participant>(userStore, optionsUserManager, passwordHasher, null, null, null, null, null, null);

			repository = new Repository(dbContext);
			trainingProgramService = new TrainingProgramService(repository);
			trainerService = new TrainerService(repository);
			participantService = new ParticipantService(repository);
		}

		[TearDown]
		public async Task Teardown()
		{
			await this.dbContext.Database.EnsureDeletedAsync();
			await this.dbContext.DisposeAsync();
		}

		[Test]
        public async Task Test_UserShouldExists_ReturnsTheCorrectResult()
		{
			// Act
			var result = participantService.ExistsByIdAsync(userOne.Id).Result;

			//Assert
			Assert.IsTrue(result);
		}

		[Test]
		public async Task Test_ReturnRightUser_ReturnsTheCorrectResult()
		{
			// Act
			var result =  participantService.GetByIdAsync("dea12856-c198-4129-b3f3-b893d8395082");

			//Assert
			Assert.IsNotNull(result);
		}

		[Test]
		public void ParticipantCity_ReturnsCorrectCity()
		{
			// Arrange
			var userId = "dea12856-c198-4129-b3f3-b893d8395082";
			var expectedCity = "Sofia";

			// Act
			var result = participantService.ParticipantCity(userId).Result;

			// Assert
			Assert.AreEqual(expectedCity, result);
		}

		[Test]
		public void ParticipantCount_ReturnsCorrectCount()
		{
			// Arrange
			
			var expectedCount = 5;

			// Act
			var result = participantService.AllAsync().Result;

			// Assert
			Assert.AreEqual(expectedCount, result.TotalParticipantsCount);
		}

		[Test]
		public void Participant_ReturnsCorrectParticipantById()
		{
			// Arrange
			var userId = "dea12856-c198-4129-b3f3-b893d8395082";
			var expectedName = "Tom";

			// Act
			var result = participantService.GetByIdAsync(userId).Result;

			// Assert
			Assert.AreEqual(expectedName, result.FirstName);
		}




	}
}
