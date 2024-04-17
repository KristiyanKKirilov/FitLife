using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class CoffeImageSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71992194-bb24-40ae-a87e-4c91ae81f54b", "AQAAAAEAACcQAAAAELXn4WMM3Sfp/5CcG7aM+TEQb80Juh3ZC66VZDuqgSXQfv/SQzogKq3DtWn5Rz0wqg==", "a55a1b1e-5d14-4f6e-8c67-9479c0a5f914" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1cc9c3-9fda-440a-a729-1baa02aef94d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "214eb620-d5ed-499d-8b29-cb8e003aa47b", "AQAAAAEAACcQAAAAEFjq22ailkVjtwJwe+spgqLaqgXNItKG842JQ0ECXKospOvh3k8kCPg9teGSktcXMQ==", "8decf81a-1b56-42b1-9643-89b849b055ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b41a64f8-033e-42c4-8195-82aaa3bb2e39", "AQAAAAEAACcQAAAAEAqU5Y7oFTFVSrfOt9pIkzC95FeEJi+HGS8Sy/FRGwVm/0Wfy1Prr1OsoNDPkQXKXg==", "43f99984-4a9f-4cf2-955d-373d1b52c8ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18de007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a1b29a4-c1c9-4b0e-9f14-4f81e0c71a2a", "AQAAAAEAACcQAAAAEEvcSLtRaMb7Havb1r1Dl4ZcE9qG5QGSDuUFlThupwVHunHm36KGtpMviG7X0HoNVw==", "f46f07c0-e05e-464e-91a0-e5c7381d5f68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18debd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b5130e9-c466-41be-b097-aa6e91a26627", "AQAAAAEAACcQAAAAEOS1ENLG5cqyGJHIkWddRdENCEttSMdGWZ9NzmljtOEpKDPJF4eWs0zH+eaRqm/HvQ==", "710d1e13-56c2-47bd-b3b8-9fe34a23b2a6" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "1525ab8f-3107-4466-a27b-463fb35ad0e9",
                column: "StartTime",
                value: new DateTime(2024, 12, 4, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "5526ab8f-3107-4466-a27b-463fb35ad0e9",
                column: "StartTime",
                value: new DateTime(2024, 12, 4, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "f4130617-4f66-4775-8c6a-e80be1ea8380",
                column: "StartTime",
                value: new DateTime(2024, 5, 9, 8, 30, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "206472d8-8970-4006-91db-f61d785a43ad", "AQAAAAEAACcQAAAAELOGQpcGVty7WDtle7p+FACtkK68EO1mE/u7JKckVbwzM1xpubh3w4zy54Fi6QIIhA==", "c7203f4d-fd5d-4b36-b685-b8b70144e3ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1cc9c3-9fda-440a-a729-1baa02aef94d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c883d899-c2ff-4ec2-b936-282e8f94a953", "AQAAAAEAACcQAAAAEIQOSX1QU6j/ml7VLUkfgL5cdUnvewxBwLKn2vH9AXdZJHWkp7LXOEnik1itAI9RIw==", "52854cd6-d6d5-4beb-958f-1cda9892b04f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3285dc37-c9df-43bc-914b-8bc1e60c7343", "AQAAAAEAACcQAAAAEBx1xaGSWMWl5Ii0ZmD9BHvP7bjDzMsaHRNR1tt4M2CKLddRl9BMzGGKN0ZG2wGKSA==", "a0d7eee5-1b22-4b47-b6f1-a7d0dc2dc489" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18de007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01009c21-33ad-471e-a21f-bfda9b62aab8", "AQAAAAEAACcQAAAAEFU2tFQz6/3uSW2oWb/fOoaDgWW6Es8y1jOaASz+vIQXpdkALEiLOZF9vciT5TGnUQ==", "21315495-555f-427c-b82c-e72cb57a8e42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18debd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef92bc6-9b16-42e6-a83c-190bf8ea9196", "AQAAAAEAACcQAAAAENRDC0Gd6oDjaIkWLfecPjdV0SSGYj7xBfJw0jRwrMw1y1eYbA7TYmsonKmH9mEmiA==", "d4496149-3f94-4a2e-a0e9-5b88591eb83f" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "1525ab8f-3107-4466-a27b-463fb35ad0e9",
                column: "StartTime",
                value: new DateTime(2024, 4, 12, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "5526ab8f-3107-4466-a27b-463fb35ad0e9",
                column: "StartTime",
                value: new DateTime(2024, 4, 12, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "f4130617-4f66-4775-8c6a-e80be1ea8380",
                column: "StartTime",
                value: new DateTime(2024, 9, 5, 8, 30, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
