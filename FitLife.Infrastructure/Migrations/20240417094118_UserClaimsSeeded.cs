using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class UserClaimsSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Tom Johnson", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "user:fullname", "Freddy Philips", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "user:fullname", "Chris Stevens", "ad1cc9c3-9fda-440a-a729-1baa02aef94d" },
                    { 4, "user:fullname", "TEST SOFTUNI", "e04b5ff6-29e7-44d5-9b3b-0099d18debd7" },
                    { 5, "user:fullname", "Admin ItSelf", "e04b5ff6-29e7-44d5-9b3b-0099d18de007" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c98ebc4-767a-4754-95dd-4061dbc4e728", "AQAAAAEAACcQAAAAECsLYYwdr5dMN7Jy0l8Us4Tpzr+rMH8eFwlQzufpHVCS0YBPf/WxrBCEAAfhrUEekw==", "aaa98988-3141-43f9-be36-e6273a445623" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1cc9c3-9fda-440a-a729-1baa02aef94d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c61861b-c4f7-4e90-847a-19495788a411", "AQAAAAEAACcQAAAAEHSy0Fv2UQgenfGOXXiPCdehWpBOC1h7ZqHZvetw3mi24P+R40U69xqD1mzd6/Af/w==", "c9fbaf8d-7106-4287-9277-bbf1b57929ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81e222c7-0a8c-44a0-8712-a9f094257361", "AQAAAAEAACcQAAAAEKDpgMy9di3Q9Xaw5s1q3yTx09psz3L5LsSEayadXnC3qvb6nI1co/Vj3SCI/0OshQ==", "ed827b0a-47a6-4557-be4e-da5b050f06cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18de007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9513903e-55fb-49f7-888b-f10c96960e25", "AQAAAAEAACcQAAAAENopDhCXJLOb/TgmdDJYTjbrfe0Wyyco5tGwINnI6gQcmsaUWwajXcvBTXzxg6aRgg==", "732d0f18-6167-4425-bef2-574115df2fb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18debd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a177db0d-4f00-433a-9412-a9bcddd9b25e", "AQAAAAEAACcQAAAAEG/YPNcVjLNfJ4ERsrXWJXij9ZSGsAE+0sgYUx2tA8v8n91zYFfGl4nObEtGPaeiTA==", "2ece4922-41d1-487a-a4e8-293a3c8c30df" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b43e891-d8e3-4e07-8439-10cdb0a5236b", "AQAAAAEAACcQAAAAEIc4gOpBmfI3TG9LZz9Zkedylx2daNtDhhPa9RuGcMCvsFYQpyqehGXqzkcHPj/6YQ==", "fb1a2b01-8295-4fc3-85ea-956a124427c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1cc9c3-9fda-440a-a729-1baa02aef94d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "486c20dd-9c8f-4b75-a278-224a4ae745ca", "AQAAAAEAACcQAAAAEPfwMx+8vSn57NHykXozPX6LHOmMtGFAH+8IAZy9/hMQFe6BXxzCLJy9sZNCBfqsbQ==", "d4b9c4c9-6ab6-4df1-89b3-a59e303d4b13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0d667d0-3999-4e7a-a9cd-dbcfefc76be8", "AQAAAAEAACcQAAAAENQPG0SUtTDDk4dKqkvO4xfK1m5fhflHtfWe1Z+7Gsb8KGvH+5UcDpjOmFmCIDhEFQ==", "4ea9af59-a44d-43ac-9264-a3a8ca89a713" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18de007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0153a984-aa4e-41b9-ad37-6dbeb467f450", "AQAAAAEAACcQAAAAEBYL2VKD4rrIZdkFOfcZ+S7lRxEDr6hDQwUcWnhsPFabd/Dn6GLuCfwx0bEk/chypA==", "bc7da542-537c-4a40-b63e-98189bf23ff5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e04b5ff6-29e7-44d5-9b3b-0099d18debd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c392c91b-993d-4806-b0fd-a88753914234", "AQAAAAEAACcQAAAAEK8mRSeNJ9S6EahcbvrYIzwWmo6ZuRgx1kqVAXABudFTaoMq3/Bl1cq+B58IL2slxQ==", "16857607-f38c-4403-a0fa-3a90e09c766c" });
        }
    }
}
