using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class CoffeImageChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb9a8caf-470d-420f-ba43-a54e827acb70", "AQAAAAEAACcQAAAAENtcx1zDVv6NB6ATC7GLefP5YKkagx0uUfr1pP85XeLxkYDvkFGD34JDSHf4MENUjQ==", "731109f4-246a-4147-beef-8862e7f92b40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1cc9c3-9fda-440a-a729-1baa02aef94d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b2cf2a0-30cc-469c-8c19-0f7e23821dd7", "AQAAAAEAACcQAAAAEEQFP7n6I5tslbwgfFJsILNgvW6fKvWkXKon03hsvol+/DXpwq+rfh7QLEahNrc6HQ==", "4c577bfc-ccfb-4afd-a14c-af1d9b1b72ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "561d27a7-8278-4bbb-b656-f0dffd72c610", "AQAAAAEAACcQAAAAEKx1eztL0OCuQz8pd7KrUvGZ5aLUrazZa0ym2oQd8RMuF9c7naaPG8K0UcaYnA3Kkw==", "9c99acf8-2de5-47e3-8b94-87c9d116bdee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18de007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d294eedb-6351-4204-befe-de27950b7755", "AQAAAAEAACcQAAAAEFF/desxA6OiPyUOZd+biUqkJexL7gxE4XQ72fuoad6l/SQkf0EiGTSu+gKAjfwwIg==", "0f3f294a-da7e-472a-958e-403db53da4e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18debd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb649bda-4046-483c-be38-f9041e52d4a0", "AQAAAAEAACcQAAAAEHU10WqNyyDEOG0hDB6DWZMfy7AOLaOY39ZYPndxb5zHrgf1PnCBKGbftoIKkrSkkg==", "a170d831-0ffd-4446-b1cd-6e0a5ab06c1c" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "f4130617-4f66-4775-8c6a-e80be1ea8380",
                column: "ImageUrl",
                value: "https://ucare.inhersight.com/ff031afb-60c7-4bc4-ad17-bf3b1dac93f3/-/format/auto/-/quality/lighter/-/progressive/yes/-/resize/800x/");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "f4130617-4f66-4775-8c6a-e80be1ea8380",
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRnrnGh9dQ-ktCzYC-Bxd0ixhza-1uaa7xU2a1V6nKK4g&s");
        }
    }
}
