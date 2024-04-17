using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitLife.Data.Migrations
{
    public partial class ParticipantProductTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ParticipantsProducts",
                columns: table => new
                {
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Participant's identifier"),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Product's identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantsProducts", x => new { x.ParticipantId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ParticipantsProducts_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParticipantsProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantsProducts_ProductId",
                table: "ParticipantsProducts",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParticipantsProducts");

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ParticipantId",
                table: "Orders",
                column: "ParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
