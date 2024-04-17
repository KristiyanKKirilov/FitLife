using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FitLife.GlobalConstants;
using System.Globalization;

namespace FitLife.Tests
{
	[TestFixture]
	public class TrainingProgramServiceTests
	{
		//Database and Services
		private FitLifeDbContext dbContext;

		private UserManager<Participant> userManager;
		private IRepository repository;
		private ITrainingProgramService trainingProgramService;
		private IParticipantService participantService;
		private ITrainerService trainerService;
		private IProductService productService;
		private IEventService eventService;

		//Collections
		private IEnumerable<TrainingProgram> trainings;
		private IEnumerable<TrainingProgramCategory> trainCategories;

		//Users
		private TrainingProgram trainOne;
		private TrainingProgram trainTwo;
		private TrainingProgram trainThree; 
		private TrainingProgram trainFour;
		private TrainingProgram trainFive;
		private TrainingProgram trainSix;

		private TrainingProgramCategory catOne;
		private TrainingProgramCategory catTwo;
		private TrainingProgramCategory catThree;


		//Roles
		private Trainer traniner;
		[SetUp]
		public async Task Setup()
		{
			trainOne = new TrainingProgram()
			{
				Id = "dea11856-c198-4129-b3f3-a893d8395022",
				Title = "Jumping Month",
				Description = "Burpies and jumping jacks to do in the morning and 20 minutes cardio afternoon are only the begining. Join us to be fit for the summer!",
				ImageUrl = "https://media.istockphoto.com/id/637772834/photo/set-your-fitness-goals-high-and-reach-them.jpg?s=612x612&w=0&k=20&c=w0ZkUVwEOm6AUJO8eGqxeHt-Jrx5us5uK4BfWW9HDy8=",
				StartDate = DateTime.ParseExact("08/09/2024 10:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
				DurationDays = 14,
				CategoryId = 2,
				CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

			};
			trainTwo = new TrainingProgram()
			{
				Id = "dea22856-c198-4129-b3f3-a893d8395022",
				Title = "Mass gain",
				Description = "Gym is your second home and you want to achieve even more? Subscribe for our program to become better version of yourself only for 3 months!",
				ImageUrl = "https://img.freepik.com/free-photo/low-angle-view-unrecognizable-muscular-build-man-preparing-lifting-barbell-health-club_637285-2497.jpg?size=626&ext=jpg&ga=GA1.1.1700460183.1712793600&semt=sph",
				StartDate = DateTime.ParseExact("22/04/2024 13:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
				DurationDays = 90,
				CategoryId = 3,
				CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

			};
			trainThree = new TrainingProgram()
			{
				Id = "dd87ea80-b2fe-4034-aa6a-63d505837a15",
				Title = "Summer body",
				Description = "Beach training every afternoon to get 6 pack for the summer!",
				ImageUrl = "https://thumbs.dreamstime.com/b/fitness-people-jumping-fitness-workout-beach-group-fitness-people-jumping-fitness-workout-beach-192257084.jpg",
				StartDate = DateTime.ParseExact("21/06/2024 13:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
				DurationDays = 7,
				CategoryId = 1,
				CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

			};

			trainFour = new TrainingProgram()
			{
				Id = "8bb2f74c-dde5-4217-b985-0f623ec4349f",
				Title = "Rock Climbers",
				Description = "Be prepared for the montains in Bulgaria every year!",
				ImageUrl = "https://i.namu.wiki/i/z4SlzF00Hi7dzXpkkj_mdNnXyY2WTHD6hmxzCks5e6PxQ7KwHosVlzQatl42tPiui_EICYUhL-iEBxxbRQUN7w.webp",
				StartDate = DateTime.ParseExact("20/01/2024 11:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
				DurationDays = 7,
				CategoryId = 2,
				CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

			};
			trainFive = new TrainingProgram()
			{
				Id = "dea22806-c198-4129-b3f3-a893d8395022",
				Title = "Swim like a pro",
				Description = "Summer swim trainings for people with a little bit of experience. We will teach you some techniques to improve your swimming skills.",
				ImageUrl = "https://media.istockphoto.com/id/465383082/photo/female-swimmer-at-the-swimming-pool.webp?b=1&s=612x612&w=0&k=20&c=I4TM5zIDe-19EWq6OlzwZ1eqr8_tlEQ86SC-0eomEhU=",
				StartDate = DateTime.ParseExact("19/07/2024 10:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
				DurationDays = 28,
				CategoryId = 2,
				CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

			};
			trainSix = new TrainingProgram()
			{
				Id = "dd87ea99-b2fe-4034-aa6a-63d505837a15",
				Title = "Strong and flexible",
				Description = "Crossfit gives you the opportunity to look good, feel good and train different from others. If you are bored from the gym and you are looking to start some new challenge, our crossfit program is the right place for you!",
				ImageUrl = "https://www.crossfit.com/wp-content/uploads/2023/11/13131232/crossfit-coach-led-fitness-training-adapted-for-you-handstand-hold.jpg",
				StartDate = DateTime.ParseExact("05/11/2024 20:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
				DurationDays = 60,
				CategoryId = 2,
				CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",

			};

			catOne = new TrainingProgramCategory()
			{
				Id = 1,
				Name = "Beginner",

			};
			catTwo = new TrainingProgramCategory()
			{
				Id = 2,
				Name = "Intermediate",

			};
			catThree = new TrainingProgramCategory()
			{
				Id = 3,
				Name = "Expert",

			};

			trainings = new List<TrainingProgram>() { trainOne, trainTwo, trainThree, trainFour, trainFive , trainSix };
			trainCategories = new List<TrainingProgramCategory>() { catOne, catTwo, catThree };
			var options = new DbContextOptionsBuilder<FitLifeDbContext>()
				.UseInMemoryDatabase(databaseName: "FitLifeInMemoryDb" + Guid.NewGuid().ToString())
				.Options;

			dbContext = new FitLifeDbContext(options);

			dbContext.AddRangeAsync(trainings);
			dbContext.AddRangeAsync(trainCategories);
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
			eventService = new EventService(repository);
		}

		[TearDown]
		public async Task Teardown()
		{
			await this.dbContext.Database.EnsureDeletedAsync();
			await this.dbContext.DisposeAsync();
		}

		[Test]
		public void Train_ReturnsCorrectNumber()
		{
			// Arrange
			
			var expected = 6;
			// Act
			var result = trainingProgramService.AllAsync().Result;

			// Assert
			Assert.AreEqual(expected, result.TotalTrainingPrograms);
		}

		[Test]
		public void Train_ReturnsCorrectNumberCategories()
		{
			// Arrange

			var expected = 3;
			// Act
			var result = trainingProgramService.AllCategoriesAsync().Result;

			// Assert
			Assert.AreEqual(expected, result.Count());
		}

		[Test]
		public void Train_ReturnsCorrectExistenceCAtegory()
		{
			// Arrange
			int categoryId = 1;
			var expected = 3;
			// Act
			var result = trainingProgramService.CategoryExistsAsync(categoryId).Result;

			// Assert
			Assert.True(result);
		}

		[Test]
		public void Train_ReturnsCorrectExistenceTrainingProgram()
		{
			// Arrange
			string trainId = "dea22806-c198-4129-b3f3-a893d8395022";
			var expected = 3;
			// Act
			var result = trainingProgramService.ExistsAsync(trainId).Result;

			// Assert
			Assert.True(result);
		}

		[Test]
		public void Train_ReturnsCorrectModifyModel()
		{
			// Arrange
			string trainId = "dea22806-c198-4129-b3f3-a893d8395022";
			var expected = "dea22806-c198-4129-b3f3-a893d8395022";
			// Act
			var result = trainingProgramService.GetTrainingProgramModifyModelByIdAsync(trainId).Result;

			// Assert
			Assert.AreEqual(expected, result.Id);
		}

		
	}
}
