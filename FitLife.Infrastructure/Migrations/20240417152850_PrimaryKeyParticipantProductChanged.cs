using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class PrimaryKeyParticipantProductChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParticipantsProducts",
                table: "ParticipantsProducts");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "ParticipantsProducts");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ParticipantsProducts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParticipantsProducts",
                table: "ParticipantsProducts",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantsProducts_ParticipantId",
                table: "ParticipantsProducts",
                column: "ParticipantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParticipantsProducts",
                table: "ParticipantsProducts");

            migrationBuilder.DropIndex(
                name: "IX_ParticipantsProducts_ParticipantId",
                table: "ParticipantsProducts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ParticipantsProducts");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "ParticipantsProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParticipantsProducts",
                table: "ParticipantsProducts",
                columns: new[] { "ParticipantId", "ProductId" });

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
    }
}
