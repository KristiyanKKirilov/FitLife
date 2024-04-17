using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class CountColumnToParticipantsProductsTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "ParticipantsProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5edfc58-55c2-468b-ba6e-b457cafbb9b0", "AQAAAAEAACcQAAAAENKrMe6WCjwXzB+lMUFU5SgYjH4cjfq3ZOZ5O+7g5eOYP5Ckv2Z+KVg1j/Jn6BBcxA==", "c01c1190-d5ba-4ef9-af21-44a2f6672ae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1cc9c3-9fda-440a-a729-1baa02aef94d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5c3cf9d-dc97-464e-9dc6-4eaf536bfc50", "AQAAAAEAACcQAAAAEPUAgV5TKK2uv2hvjE5vMIa4flyIYc76iW+6g7Mb5gLtGg7NI/TyKMiXNfkSGSxL9A==", "18bb49a5-3f18-45fa-9622-651dd651897f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fbd2c09-547f-4f9b-a2f0-2b0e96517aa7", "AQAAAAEAACcQAAAAEGQ1Tm2dp11MHSAj+bpQ/DBWiG+x4jzgq3b+OgUGgyGEbfleiyzPD/RQ+N5ZpQ9+jA==", "fcfd1eb1-9085-4d97-b7f9-f1dadbde875f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18de007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c4940b0-1d8e-48dd-b3ba-0416df33973a", "AQAAAAEAACcQAAAAEFWcEQrI0tUgWP6E10AfbIVV6b7HbD23Oa32uV2DpRBz/ufHUxG+KhaeZwhIwptGEg==", "6c9daf23-fcf4-4604-b8e0-f85085b695f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18debd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bb8057b-e083-458b-a85f-e87eaac03c37", "AQAAAAEAACcQAAAAEDRwcr02rxDzcpgFhe0me4qSgbstkFgVn8UvlmmGwVRTypXOK1AHSDfifKYgxYZ4Nw==", "7e0e7292-c3ef-4caf-a0fc-8741887da082" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "ParticipantsProducts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d33b109d-eaa2-486e-832e-4c3bca9cd30a", "AQAAAAEAACcQAAAAEEOlbuQK3USATq5WSFZAJeSx7la7KQpljeRVPwgpdKDeSriO6CoftORTmoWyVav1QQ==", "943cb651-ba73-4fcb-a456-d8a256470584" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1cc9c3-9fda-440a-a729-1baa02aef94d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a268db85-fb7a-4519-911f-222a658f15fd", "AQAAAAEAACcQAAAAEBKZxIunCubdkLuI2KW9QBoqpIQkDOgV+R2/RsKpF3+jpRIhBZwYbDP5JeTRjkHHaQ==", "67e13737-06e8-483e-9043-4abe7d38dc25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e21b49f-b5a9-4925-bc7a-fbfe217b92fb", "AQAAAAEAACcQAAAAEJwDD7xQpGcf8nFBx1fFOlqJYKWQ17akkwQxKsTJiM4fPmTO1GHNx9oDlcmYQ1M7Sw==", "dc5e3ce9-ed3a-43ce-9392-25a40eb3b97d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18de007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6fd88f5-07cb-43c1-af63-45901c36a71a", "AQAAAAEAACcQAAAAEI8G1u7Ih9gRIZCAnOKaCrJL+C41S0DIiud/Go7ECr6d34HWGZFVgKZo1YTJ5D6+1g==", "f8b056c1-b576-4046-9dbb-8f771afe1270" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18debd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40f0651a-b064-421e-95b1-085209f9727f", "AQAAAAEAACcQAAAAELbVEVc6IZm0fCNCkFTn8Zuu2QhvY+Tj3FQtdKiRU7giUj5z4Dmc8fOOlmQb6nP6kw==", "6edd00d3-f3ff-443f-a5e9-9d67f3c77fe8" });
        }
    }
}
