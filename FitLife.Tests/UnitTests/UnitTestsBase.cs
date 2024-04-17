using FitLife.Data;
using FitLife.Data.Models;
using FitLife.GlobalConstants;
using FitLife.Tests.Mocks;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace FitLife.Tests.UnitTests
{
	public class UnitTestsBase
	{
		protected FitLifeDbContext _data;

		public Participant Participant { get; private set; }
		public Trainer Trainer { get; private set; }
		public Event Event { get; private set; }
		public TrainingProgram TrainingProgram { get;private set;}

		public EventCategory EventCategory { get; private set; }

		public TrainingProgramCategory TrainingProgramCategory { get; private set; }

		public Product Product { get; private set; }



		[OneTimeSetUp]
		public void SetUpBase()
		{
			_data = DatabaseMock.Instance;
			SeedDatabase();
		}

		private void SeedDatabase()
		{
			var hasher = new PasswordHasher<Participant>();

			Participant = new Participant()
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

			Participant.PasswordHash = hasher.HashPassword(Participant, "A123456b");

			_data.Participants.Add(Participant);

			Trainer = new Trainer()
			{
				Id = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
				FirstName = "Tom",
				LastName = "Johnson",
				Email = "first@gmail.com",
				UserId = "dea12856-c198-4129-b3f3-b893d8395082",

			};

			_data.Trainers.Add(Trainer);

			Event = new Event()
			{
				Id = "5526ab8f-3107-4466-a27b-463fb35ad0e9",
				Title = "Morning Run",
				Description = "Starting our run together at 7 oclock in the central park. Prepare yourself with comfortable shoes and big smile. The run will be 3km long and if it is needed, we will take a break and then continue our training!",
				ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/running-is-one-of-the-best-ways-to-stay-fit-royalty-free-image-1036780592-1553033495.jpg?crop=0.88976xw:1xh;center,top&resize=1200:*",
				City = "Varna",
				Address = "At the beginning of the sea garden, Varna",
				StartTime = DateTime.ParseExact("04/12/2024 07:00", DataConstants.DateFormat, CultureInfo.InvariantCulture),
				CategoryId = 1,
				CreatorId = "5525ab8f-3107-4466-a27b-463fb35ad0eo",
			};

			_data.Events.Add(Event);

			TrainingProgram = new TrainingProgram()
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

			_data.TrainingPrograms.Add(TrainingProgram);

			EventCategory = new EventCategory()
			{
				Id = 1,
				Name = "Sport",

			};

			_data.EventCategories.Add(EventCategory);

			TrainingProgramCategory = new TrainingProgramCategory()
			{
				Id = 1,
				Name = "Beginner",

			};

			_data.TrainingProgramCategories.Add(TrainingProgramCategory);

			Product = new Product()
			{
				Id = "eea12856-c198-4129-b3f3-b893d8395022",
				Name = "Protein cookie",
				Description = "30g of protein, 230 calories",
				ImageUrl = "https://www.wellplated.com/wp-content/uploads/2018/04/Peanut-Butter-Protein-Cookies.jpg",
				Price = 3.20m,
				IsAvailable = true,
				AvailableStockCount = 250,
				Count = 1,
			};

			_data.Products.Add(Product);
			_data.SaveChanges();
		}

		[OneTimeTearDown]
		public void TearDownBase() => _data.Dispose();


	}
}
