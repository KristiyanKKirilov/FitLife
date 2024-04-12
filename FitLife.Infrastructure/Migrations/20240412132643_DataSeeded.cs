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
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "Varna", "a083e548-25f4-4d99-828d-f593dbbe57ad", new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "second@gmail.com", false, "Nikola", false, "Nikolaev", false, null, "second@gmail.com", "second@gmail.com", "AQAAAAEAACcQAAAAEOBkbWl3rr8naQIkbXGaINLAExtVkMA7raBJ8eXxIuZSwc5xSGGoVr5zi0fp/jEovg==", null, false, "262b704e-1ef3-44e4-9d27-ca0249e8ef51", false, "second@gmail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "Sofia", "5b9bdff6-6a12-41d6-a7f6-a3882b93c432", new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "first@gmail.com", false, "Ivan", false, "Ivanov", false, null, "first@gmail.com", "first@gmail.com", "AQAAAAEAACcQAAAAEOhj0MaBHcjqWYlNsxT0kruZpT9TN5hbH9f+imbwgTfQiBu/mRZ8y7WGP7ULB9XRqA==", null, false, "37e7871b-66e3-4d7c-9261-3f795cca357e", false, "first@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Sport" },
                    { 2, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Seminar" },
                    { 3, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Entertainment" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStockCount", "Count", "CreatedOn", "Description", "IsAvailable", "IsDeleted", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { "dea12856-c198-4129-b3f3-b803d8395022", 100, 1, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ideal for diets, 0% sugar, 30 calories per 100g", true, false, "Sugarfree chocolate", null, 12m },
                    { "eea12856-c198-4129-b3f3-b893d8395022", 250, 1, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "30g of protein, 230 calories", true, false, "Protein cookie", null, 3.20m }
                });

            migrationBuilder.InsertData(
                table: "TrainingProgramCategories",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Beginner" },
                    { 2, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Intermediate" },
                    { 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Expert" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CreatedOn", "Email", "FirstName", "IsDeleted", "LastName", "UserId" },
                values: new object[] { "5525ab80-3107-4466-a27b-463fb35ad0eo", new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "second@gmail.com", "Nikola", false, "Nikolaev", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CreatedOn", "Email", "FirstName", "IsDeleted", "LastName", "UserId" },
                values: new object[] { "5525ab8f-3107-4466-a27b-463fb35ad0eo", new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "first@gmail.com", "Ivan", false, "Ivanov", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Address", "CategoryId", "City", "CreatedOn", "CreatorId", "Description", "ImageUrl", "IsDeleted", "StartTime", "Title" },
                values: new object[,]
                {
                    { "1525ab8f-3107-4466-a27b-463fb35ad0e9", "street. Bulgaria", 2, "Sofia", new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "5525ab80-3107-4466-a27b-463fb35ad0eo", "Seminar at the new bussines building in Sofia, we are going to discuss calorie deficit and proper training program", "https://images.squarespace-cdn.com/content/v1/5e113e254eae7b30460a0fba/1585970390295-ASEJJYD8ZYPY28IO48SE/IMG_6324.jpg", false, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy Food" },
                    { "5526ab8f-3107-4466-a27b-463fb35ad0e9", "Park", 1, "Varna", new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Starting our run together at 8 am in the central park. Prepare yourself with comfortable shoes and big smile.", "https://hips.hearstapps.com/hmg-prod/images/running-is-one-of-the-best-ways-to-stay-fit-royalty-free-image-1036780592-1553033495.jpg?crop=0.88976xw:1xh;center,top&resize=1200:*", false, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning Run" }
                });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "CreatorId", "Description", "DurationDays", "ImageUrl", "IsDeleted", "StartDate", "Title" },
                values: new object[,]
                {
                    { "dea11856-c198-4129-b3f3-a893d8395022", 2, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Burpies and jumping jacks to do in the morning and 20 minutes cardio afternoon are only the begining. Join us to be fit for the summer!", 14, "https://media.istockphoto.com/id/637772834/photo/set-your-fitness-goals-high-and-reach-them.jpg?s=612x612&w=0&k=20&c=w0ZkUVwEOm6AUJO8eGqxeHt-Jrx5us5uK4BfWW9HDy8=", false, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jumping Month" },
                    { "dea22856-c198-4129-b3f3-a893d8395022", 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "5525ab8f-3107-4466-a27b-463fb35ad0eo", "Gym is your second home and you want to achieve even more? Subscribe for our program to become better version of yourself only for 3 months!", 90, "https://img.freepik.com/free-photo/low-angle-view-unrecognizable-muscular-build-man-preparing-lifting-barbell-health-club_637285-2497.jpg?size=626&ext=jpg&ga=GA1.1.1700460183.1712793600&semt=sph", false, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass gain" }
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
