using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class InitialMigrationWithDataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Participant's first name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Participant's last name"),
                    City = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Participant's living town"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                },
                comment: "Participants");

            migrationBuilder.CreateTable(
                name: "EventCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Event category's identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Event category's name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCategories", x => x.Id);
                },
                comment: "EventCategories");

            migrationBuilder.CreateTable(
                name: "TrainingProgramCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "TrainingProgram category's identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "TrainingProgram category's name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramCategories", x => x.Id);
                },
                comment: "TrainingProgramCategories");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Order identifier"),
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Order's participant identifier"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Order's total price")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Orders");

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Trainer's identifier"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Trainer's first name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Trainer's last name"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Trainer's email address"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Trainer's user identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Trainers");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Product's identifier"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Product's name"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Product's nutrition described"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Product's image url"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product's price"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, comment: "Product's state"),
                    AvailableStockCount = table.Column<int>(type: "int", nullable: false, comment: "Product's available count in storage"),
                    Count = table.Column<int>(type: "int", nullable: false, comment: "Product's count in a participant's order"),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                },
                comment: "Products");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Event's identifier"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Event's title"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Event's description"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Event's image url"),
                    City = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Event's city"),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Event's address in detail described"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Event's start time in format dd/MM/yyyy hh:mm"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Event's category identifier"),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Event's creator identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "EventCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Trainers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Events");

            migrationBuilder.CreateTable(
                name: "TrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Training program's identifier"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Training program's title"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Training program's description"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Training program's image url"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Training program's date of start in format dd/MM/yyyy hh:mm"),
                    DurationDays = table.Column<int>(type: "int", nullable: false, comment: "Training program's duration in days"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Training program's category identifier"),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Training program's creator")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_Trainers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_TrainingProgramCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TrainingProgramCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "TrainingPrograms");

            migrationBuilder.CreateTable(
                name: "ParticipantEvent",
                columns: table => new
                {
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Participant's identifier"),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Event's identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantEvent", x => new { x.ParticipantId, x.EventId });
                    table.ForeignKey(
                        name: "FK_ParticipantEvent_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParticipantEvent_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "ParticipantsEvents");

            migrationBuilder.CreateTable(
                name: "TrainingProgramParticipant",
                columns: table => new
                {
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Participant's identifier"),
                    TrainingProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Training program's identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramParticipant", x => new { x.ParticipantId, x.TrainingProgramId });
                    table.ForeignKey(
                        name: "FK_TrainingProgramParticipant_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingProgramParticipant_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "TrainingProgramsParticipants");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "Varna", "7b43e891-d8e3-4e07-8439-10cdb0a5236b", "second@gmail.com", false, "Freddy", "Philips", false, null, "second@gmail.com", "second@gmail.com", "AQAAAAEAACcQAAAAEIc4gOpBmfI3TG9LZz9Zkedylx2daNtDhhPa9RuGcMCvsFYQpyqehGXqzkcHPj/6YQ==", null, false, "fb1a2b01-8295-4fc3-85ea-956a124427c4", false, "second@gmail.com" },
                    { "ad1cc9c3-9fda-440a-a729-1baa02aef94d", 0, "Ruse", "486c20dd-9c8f-4b75-a278-224a4ae745ca", "third@gmail.com", false, "Chris", "Stevens", false, null, "THIRD@GMAIL.COM", "THIRD@GMAIL.COM", "AQAAAAEAACcQAAAAEPfwMx+8vSn57NHykXozPX6LHOmMtGFAH+8IAZy9/hMQFe6BXxzCLJy9sZNCBfqsbQ==", null, false, "d4b9c4c9-6ab6-4df1-89b3-a59e303d4b13", false, "third@gmail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "Sofia", "d0d667d0-3999-4e7a-a9cd-dbcfefc76be8", "first@gmail.com", false, "Tom", "Johnson", false, null, "first@gmail.com", "first@gmail.com", "AQAAAAEAACcQAAAAENQPG0SUtTDDk4dKqkvO4xfK1m5fhflHtfWe1Z+7Gsb8KGvH+5UcDpjOmFmCIDhEFQ==", null, false, "4ea9af59-a44d-43ac-9264-a3a8ca89a713", false, "first@gmail.com" },
                    { "e04b5ff6-29e7-44d5-9b3b-0099d18de007", 0, "Varna", "0153a984-aa4e-41b9-ad37-6dbeb467f450", "admin@gmail.com", false, "Admin", "ItSelf", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBYL2VKD4rrIZdkFOfcZ+S7lRxEDr6hDQwUcWnhsPFabd/Dn6GLuCfwx0bEk/chypA==", null, false, "bc7da542-537c-4a40-b63e-98189bf23ff5", false, "admin@gmail.com" },
                    { "e04b5ff6-29e7-44d5-9b3b-0099d18debd7", 0, "SOFIA", "c392c91b-993d-4806-b0fd-a88753914234", "test@softuni.bg", false, "TEST", "SOFTUNI", false, null, "TEST@SOFTUNI.BG", "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAEK8mRSeNJ9S6EahcbvrYIzwWmo6ZuRgx1kqVAXABudFTaoMq3/Bl1cq+B58IL2slxQ==", null, false, "16857607-f38c-4403-a0fa-3a90e09c766c", false, "test@softuni.bg" }
                });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sport" },
                    { 2, "Seminar" },
                    { 3, "Entertainment" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStockCount", "Count", "Description", "ImageUrl", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { "d2a12856-c198-4129-b3f3-b803d8395022", 50, 1, "Refreshing drink, 100% natural flavour, 0% sugar, 230 calories", "https://smartymockups.com/wp-content/uploads/2019/05/Smoothie_Bottle_Mockup_2.jpg", true, "Strawberry smoothie", null, 7m },
                    { "dea12856-c198-4129-b3f3-b803d8395022", 100, 1, "Ideal for diets, 0% sugar, 30 calories per 100g", "https://cdn.shopify.com/s/files/1/2090/1141/files/bepure-perfect-plant-protein-chocolate-flavour-600g-jar_3125x.png?v=1690512984", true, "Sugarfree chocolate", null, 12m },
                    { "eea12856-c198-4129-b3f3-b893d8395022", 250, 1, "30g of protein, 230 calories", "https://www.wellplated.com/wp-content/uploads/2018/04/Peanut-Butter-Protein-Cookies.jpg", true, "Protein cookie", null, 3.20m }
                });

            migrationBuilder.InsertData(
                table: "TrainingProgramCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Beginner" },
                    { 2, "Intermediate" },
                    { 3, "Expert" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserId" },
                values: new object[] { "5525ab80-3107-4466-a27b-463fb35ad0bb", "admin@gmail.com", "Admin", "ItSelf", "e04b5ff6-29e7-44d5-9b3b-0099d18de007" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserId" },
                values: new object[] { "5525ab80-3107-4466-a27b-463fb35ad0eo", "second@gmail.com", "Freddy", "Philips", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserId" },
                values: new object[] { "5525ab8f-3107-4466-a27b-463fb35ad0eo", "first@gmail.com", "Tom", "Johnson", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Address", "CategoryId", "City", "CreatorId", "Description", "ImageUrl", "StartTime", "Title" },
                values: new object[,]
                {
                    { "1525ab8f-3107-4466-a27b-463fb35ad0e9", "street. Bulgaria", 2, "Sofia", "5525ab80-3107-4466-a27b-463fb35ad0eo", "Seminar at the new business building in Sofia, we are going to discuss calorie deficit and proper training program depending on everyone's lifestyle! Don't be shy to participate and help us improve our seminars! We are waiting for you!", "https://images.squarespace-cdn.com/content/v1/5e113e254eae7b30460a0fba/1585970390295-ASEJJYD8ZYPY28IO48SE/IMG_6324.jpg", new DateTime(2024, 4, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Healthy Food" },
                    { "5526ab8f-3107-4466-a27b-463fb35ad0e9", "At the beginning of the sea garden, Varna", 1, "Varna", "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Starting our run together at 7 oclock in the central park. Prepare yourself with comfortable shoes and big smile. The run will be 3km long and if it is needed, we will take a break and then continue our training!", "https://hips.hearstapps.com/hmg-prod/images/running-is-one-of-the-best-ways-to-stay-fit-royalty-free-image-1036780592-1553033495.jpg?crop=0.88976xw:1xh;center,top&resize=1200:*", new DateTime(2024, 4, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), "Morning Run" },
                    { "f4130617-4f66-4775-8c6a-e80be1ea8380", "Varna Center, near Starbucks", 3, "Varna", "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Get a coffee and meet a new friend in our new designed healthy bar food!", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRnrnGh9dQ-ktCzYC-Bxd0ixhza-1uaa7xU2a1V6nKK4g&s", new DateTime(2024, 9, 5, 8, 30, 0, 0, DateTimeKind.Unspecified), "Coffee Time and Relax" }
                });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "DurationDays", "ImageUrl", "StartDate", "Title" },
                values: new object[,]
                {
                    { "8bb2f74c-dde5-4217-b985-0f623ec4349f", 2, "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Be prepared for the montains in Bulgaria every year!", 7, "https://i.namu.wiki/i/z4SlzF00Hi7dzXpkkj_mdNnXyY2WTHD6hmxzCks5e6PxQ7KwHosVlzQatl42tPiui_EICYUhL-iEBxxbRQUN7w.webp", new DateTime(2024, 1, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "Rock Climbers" },
                    { "dd87ea80-b2fe-4034-aa6a-63d505837a15", 1, "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Beach training every afternoon to get 6 pack for the summer!", 7, "https://thumbs.dreamstime.com/b/fitness-people-jumping-fitness-workout-beach-group-fitness-people-jumping-fitness-workout-beach-192257084.jpg", new DateTime(2024, 6, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "Summer body" },
                    { "dd87ea99-b2fe-4034-aa6a-63d505837a15", 2, "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Crossfit gives you the opportunity to look good, feel good and train different from others. If you are bored from the gym and you are looking to start some new challenge, our crossfit program is the right place for you!", 60, "https://www.crossfit.com/wp-content/uploads/2023/11/13131232/crossfit-coach-led-fitness-training-adapted-for-you-handstand-hold.jpg", new DateTime(2024, 11, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), "Strong and flexible" },
                    { "dea11856-c198-4129-b3f3-a893d8395022", 2, "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Burpies and jumping jacks to do in the morning and 20 minutes cardio afternoon are only the begining. Join us to be fit for the summer!", 14, "https://media.istockphoto.com/id/637772834/photo/set-your-fitness-goals-high-and-reach-them.jpg?s=612x612&w=0&k=20&c=w0ZkUVwEOm6AUJO8eGqxeHt-Jrx5us5uK4BfWW9HDy8=", new DateTime(2024, 9, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Jumping Month" },
                    { "dea22806-c198-4129-b3f3-a893d8395022", 2, "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Summer swim trainings for people with a little bit of experience. We will teach you some techniques to improve your swimming skills.", 28, "https://media.istockphoto.com/id/465383082/photo/female-swimmer-at-the-swimming-pool.webp?b=1&s=612x612&w=0&k=20&c=I4TM5zIDe-19EWq6OlzwZ1eqr8_tlEQ86SC-0eomEhU=", new DateTime(2024, 7, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "Swim like a pro" },
                    { "dea22856-c198-4129-b3f3-a893d8395022", 3, "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Gym is your second home and you want to achieve even more? Subscribe for our program to become better version of yourself only for 3 months!", 90, "https://img.freepik.com/free-photo/low-angle-view-unrecognizable-muscular-build-man-preparing-lifting-barbell-health-club_637285-2497.jpg?size=626&ext=jpg&ga=GA1.1.1700460183.1712793600&semt=sph", new DateTime(2024, 4, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), "Mass gain" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatorId",
                table: "Events",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ParticipantId",
                table: "Orders",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantEvent_EventId",
                table: "ParticipantEvent",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_UserId",
                table: "Trainers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramParticipant_TrainingProgramId",
                table: "TrainingProgramParticipant",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_CategoryId",
                table: "TrainingPrograms",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_CreatorId",
                table: "TrainingPrograms",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ParticipantEvent");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "TrainingProgramParticipant");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");

            migrationBuilder.DropTable(
                name: "EventCategories");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "TrainingProgramCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
