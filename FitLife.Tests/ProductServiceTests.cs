using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitLife.Core.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FitLife.Web.ViewModels.Product;

namespace FitLife.Tests
{
	public class ProductServiceTests
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
		private IEnumerable<Product> products;

		//Users
		private Product productOne;
		private Product productTwo;
		private Product productThree;


		//Roles
		private Trainer traniner;
		[SetUp]
		public async Task Setup()
		{
			productOne = new Product()
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
			productTwo = new Product()
			{
				Id = "dea12856-c198-4129-b3f3-b803d8395022",
				Name = "Sugarfree chocolate",
				Description = "Ideal for diets, 0% sugar, 30 calories per 100g",
				ImageUrl = "https://cdn.shopify.com/s/files/1/2090/1141/files/bepure-perfect-plant-protein-chocolate-flavour-600g-jar_3125x.png?v=1690512984",
				Price = 12m,
				IsAvailable = true,
				AvailableStockCount = 100,
				Count = 1,

			};
			productThree = new Product()
			{
				Id = "d2a12856-c198-4129-b3f3-b803d8395022",
				Name = "Strawberry smoothie",
				Description = "Refreshing drink, 100% natural flavour, 0% sugar, 230 calories",
				ImageUrl = "https://smartymockups.com/wp-content/uploads/2019/05/Smoothie_Bottle_Mockup_2.jpg",
				Price = 7m,
				IsAvailable = true,
				AvailableStockCount = 50,
				Count = 1,

			};

			products = new List<Product>() { productOne, productTwo, productThree };

			var options = new DbContextOptionsBuilder<FitLifeDbContext>()
				.UseInMemoryDatabase(databaseName: "FitLifeInMemoryDb" + Guid.NewGuid().ToString())
				.Options;

			dbContext = new FitLifeDbContext(options);

			dbContext.AddRangeAsync(products);
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
		public void Product_ReturnsCorrectCoutnAll()
		{
			// Arrange
			var productId = "eea12856-c198-4129-b3f3-b893d8395022";
			var userId = "dea12856-c198-4129-b3f3-b893d8395082";
			var expected = 3;

			// Act
			var result = productService.AllAsync().Result;
			// Assert
			Assert.AreEqual(expected, result.Count());
		}

		[Test]
		public void Product_ReturnsCorrectParticipantById()
		{
			// Arrange
			var productId = "eea12856-c198-4129-b3f3-b893d8395022";
			var userId = "dea12856-c198-4129-b3f3-b893d8395082";
			var expected = 3;

			// Act
			var result = productService.ExistsAsync(productId).Result;
			// Assert
			Assert.IsNotNull(result);
		}

		[Test]
		public void Product_ReturnsCorrectAllProductNames()
		{
			// Arrange

			var expected = 3;

			// Act
			var result = productService.GetAllProductsNamesAsync().Result;
			// Assert
			Assert.AreEqual(expected, result.Count());

		}

		[Test]
		public void Product_ReturnsCorrectProductIdByName()
		{
			// Arrange

			var expected = "d2a12856-c198-4129-b3f3-b803d8395022";
			var productName = "Strawberry smoothie";
			// Act
			var result = productService.GetProductIdByNameAsync(productName).Result;
			// Assert
			Assert.AreEqual(expected, result);

		}

		[Test]
		public void Product_ReturnsCorrectModifyModelById()
		{
			// Arrange

			var productId = "eea12856-c198-4129-b3f3-b893d8395022";
			var expectedPrice = 3.20m;
			// Act
			var result = productService.GetProductModifyModelByIdAsync(productId).Result;
			// Assert
			Assert.AreEqual(expectedPrice, result.Price);
		}

		[Test]
		public void Product_ReturnsCorrectModify()
		{
			// Arrange

			var productId = "dea12856-c198-4129-b3f3-b803d8395022";
			var expectedId = "dea12856-c198-4129-b3f3-b803d8395022";
			// Act
			var result = productService.GetProductModifyModelByIdAsync(productId).Result;

			// Assert
			Assert.AreEqual(expectedId, result.Id);
		}

		[Test]
		public void Product_ReturnsCorrectModelDetails()
		{
			// Arrange

			var productId = "dea12856-c198-4129-b3f3-b803d8395022";
			var expectedId = "dea12856-c198-4129-b3f3-b803d8395022";
			// Act
			var result = productService.ProductDetailsByIdAsync(productId).Result;

			// Assert
			Assert.AreEqual(expectedId, result.Id);
		}

		[Test]
		public void Product_CorrectModify()
		{
			// Arrange
			ProductModifyModel model = new()
			{
				Id = "dea12856-c198-4129-b3f3-b803d8395022",
				Name = "Sugarfree chocolate",
				Description = "Ideal for diets, 0% sugar, 30 calories per 100g",
				ImageUrl = "https://cdn.shopify.com/s/files/1/2090/1141/files/bepure-perfect-plant-protein-chocolate-flavour-600g-jar_3125x.png?v=1690512984",
				Price = 14m,
				IsAvailable = 0,
				AvailableStockCount = 100,
				Count = 2,
			};
			var productId = "dea12856-c198-4129-b3f3-b803d8395022";
			var expectedPrice = 14m;
			// Act
			var result = productService.ModifyAsync(productId, model);
			var resultTwo = productService.ProductDetailsByIdAsync(productId).Result;
			// Assert
			Assert.AreEqual(expectedPrice, resultTwo.Price);
		}
	}
}
