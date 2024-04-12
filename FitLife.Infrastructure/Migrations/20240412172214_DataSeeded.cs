using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class DataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "Varna", "9b6fb58b-0ca0-45db-b0e8-4ae47ccaa0cc", "second@gmail.com", false, "Nikola", "Nikolaev", false, null, "second@gmail.com", "second@gmail.com", "AQAAAAEAACcQAAAAEDDQlAuOQnOe74ynNyS4OoflkOqjetBkeV7lsZFvvTNSshruZ2cbQ/lZmmoDqASCug==", null, false, "4f774f84-c2d2-4307-9231-e5e8bdbf7fcf", false, "second@gmail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "Sofia", "cb17bba8-8e30-4585-bda5-84c8a1e1a4b4", "first@gmail.com", false, "Ivan", "Ivanov", false, null, "first@gmail.com", "first@gmail.com", "AQAAAAEAACcQAAAAED6EsV6f10r0mIGLldRAG0YR6pOcSVR2c/Kky2oxSPLFQs3kyV49mdWO7jPwJT36Ag==", null, false, "f330b055-d221-4371-bad2-f60b21d31e62", false, "first@gmail.com" }
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
                columns: new[] { "Id", "AvailableStockCount", "Count", "Description", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { "dea12856-c198-4129-b3f3-b803d8395022", 100, 1, "Ideal for diets, 0% sugar, 30 calories per 100g", true, "Sugarfree chocolate", null, 12m },
                    { "eea12856-c198-4129-b3f3-b893d8395022", 250, 1, "30g of protein, 230 calories", true, "Protein cookie", null, 3.20m }
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
                values: new object[] { "5525ab80-3107-4466-a27b-463fb35ad0eo", "second@gmail.com", "Nikola", "Nikolaev", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserId" },
                values: new object[] { "5525ab8f-3107-4466-a27b-463fb35ad0eo", "first@gmail.com", "Ivan", "Ivanov", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Address", "CategoryId", "City", "CreatorId", "Description", "ImageUrl", "StartTime", "Title" },
                values: new object[,]
                {
                    { "1525ab8f-3107-4466-a27b-463fb35ad0e9", "street. Bulgaria", 2, "Sofia", "5525ab80-3107-4466-a27b-463fb35ad0eo", "Seminar at the new bussines building in Sofia, we are going to discuss calorie deficit and proper training program", "https://images.squarespace-cdn.com/content/v1/5e113e254eae7b30460a0fba/1585970390295-ASEJJYD8ZYPY28IO48SE/IMG_6324.jpg", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy Food" },
                    { "5526ab8f-3107-4466-a27b-463fb35ad0e9", "Park", 1, "Varna", "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Starting our run together at 8 am in the central park. Prepare yourself with comfortable shoes and big smile.", "https://hips.hearstapps.com/hmg-prod/images/running-is-one-of-the-best-ways-to-stay-fit-royalty-free-image-1036780592-1553033495.jpg?crop=0.88976xw:1xh;center,top&resize=1200:*", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning Run" }
                });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Description", "DurationDays", "ImageUrl", "StartDate", "Title" },
                values: new object[,]
                {
                    { "dea11856-c198-4129-b3f3-a893d8395022", 2, "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Burpies and jumping jacks to do in the morning and 20 minutes cardio afternoon are only the begining. Join us to be fit for the summer!", 14, "https://media.istockphoto.com/id/637772834/photo/set-your-fitness-goals-high-and-reach-them.jpg?s=612x612&w=0&k=20&c=w0ZkUVwEOm6AUJO8eGqxeHt-Jrx5us5uK4BfWW9HDy8=", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jumping Month" },
                    { "dea22856-c198-4129-b3f3-a893d8395022", 3, "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Gym is your second home and you want to achieve even more? Subscribe for our program to become better version of yourself only for 3 months!", 90, "https://img.freepik.com/free-photo/low-angle-view-unrecognizable-muscular-build-man-preparing-lifting-barbell-health-club_637285-2497.jpg?size=626&ext=jpg&ga=GA1.1.1700460183.1712793600&semt=sph", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass gain" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "1525ab8f-3107-4466-a27b-463fb35ad0e9");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "5526ab8f-3107-4466-a27b-463fb35ad0e9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b803d8395022");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eea12856-c198-4129-b3f3-b893d8395022");

            migrationBuilder.DeleteData(
                table: "TrainingProgramCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: "dea11856-c198-4129-b3f3-a893d8395022");

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: "dea22856-c198-4129-b3f3-a893d8395022");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: "5525ab80-3107-4466-a27b-463fb35ad0eo");

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: "5525ab8f-3107-4466-a27b-463fb35ad0eo");

            migrationBuilder.DeleteData(
                table: "TrainingProgramCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingProgramCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");
        }
    }
}
