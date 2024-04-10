using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class Initial : Migration
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Participant's state"),
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Event category's name"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Event category's state")
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "TrainingProgram category's name"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Training program category's state")
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
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Order's total price"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Order's state")
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Trainer's user identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Trainer's state")
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product's price"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, comment: "Product's state"),
                    AvailableStockCount = table.Column<int>(type: "int", nullable: false, comment: "Product's available count in storage"),
                    Count = table.Column<int>(type: "int", nullable: false, comment: "Product's count in a participant's order"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Product's state"),
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
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Event's creator identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Event's state")
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
                        onDelete: ReferentialAction.Cascade);
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
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Training program's creator"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Training program's state")
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
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Event's identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Order's state")
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
                name: "TrainersEvents",
                columns: table => new
                {
                    TrainerId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Trainer's identifier"),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Event's identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Order's state")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainersEvents", x => new { x.TrainerId, x.EventId });
                    table.ForeignKey(
                        name: "FK_TrainersEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainersEvents_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "TrainersEvents");

            migrationBuilder.CreateTable(
                name: "TrainingProgramParticipant",
                columns: table => new
                {
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Participant's identifier"),
                    TrainingProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Training program's identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "TrainingProgramParticipant's state")
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

            migrationBuilder.CreateTable(
                name: "TrainingProgramsTrainers",
                columns: table => new
                {
                    TrainerId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Trainer's identifier"),
                    TrainingProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Training program's identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time of creation"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "TrainingProgramsTrainers state")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramsTrainers", x => new { x.TrainerId, x.TrainingProgramId });
                    table.ForeignKey(
                        name: "FK_TrainingProgramsTrainers_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingProgramsTrainers_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "TrainingProgramsTrainers");

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
                name: "IX_TrainersEvents_EventId",
                table: "TrainersEvents",
                column: "EventId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramsTrainers_TrainingProgramId",
                table: "TrainingProgramsTrainers",
                column: "TrainingProgramId");
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
                name: "TrainersEvents");

            migrationBuilder.DropTable(
                name: "TrainingProgramParticipant");

            migrationBuilder.DropTable(
                name: "TrainingProgramsTrainers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Events");

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
