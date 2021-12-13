using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class AddedTitleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "B");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "C");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "D");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "B");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "C");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "D");

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Content", "CreatedAt", "Dislikes", "Likes", "Title" },
                values: new object[,]
                {
                    { "fa2ffe69-3726-46d4-aebf-90d1a341b256", "Content for short story #1", new DateTime(2021, 12, 13, 11, 22, 55, 171, DateTimeKind.Local).AddTicks(2107), 0, 0, "Short story #1" },
                    { "0b352754-2d76-4a18-99a3-dbb83d999b9a", "Content for short story #2", new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(7116), 0, 0, "Short story #2" },
                    { "fc03d7b0-1109-453f-9e76-ebfa1fd475c4", "Content for short story #3", new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(7158), 0, 0, "Short story #3" },
                    { "35c3d70f-22f5-4811-a10c-497814335f8f", "Content for short story #4", new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(7165), 0, 0, "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Content", "CreatedAt", "Dislikes", "Likes", "ShortStoryID" },
                values: new object[,]
                {
                    { "453c6404-a603-44aa-a4de-426959806b0b", "Comment on short story #1", new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(8125), 0, 0, "fa2ffe69-3726-46d4-aebf-90d1a341b256" },
                    { "2c63bf99-e1c1-4157-9078-e3b4623b1c51", "Comment on short story #2", new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(8945), 0, 0, "0b352754-2d76-4a18-99a3-dbb83d999b9a" },
                    { "36a577c1-cc3b-4fa0-9e7d-209c9c1a3c36", "Comment on short story #3", new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(8979), 0, 0, "fc03d7b0-1109-453f-9e76-ebfa1fd475c4" },
                    { "bcadf907-9112-47cf-8ad7-7e5e06c351dc", "Comment on short story #4", new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(8985), 0, 0, "35c3d70f-22f5-4811-a10c-497814335f8f" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "2c63bf99-e1c1-4157-9078-e3b4623b1c51");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "36a577c1-cc3b-4fa0-9e7d-209c9c1a3c36");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "453c6404-a603-44aa-a4de-426959806b0b");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "bcadf907-9112-47cf-8ad7-7e5e06c351dc");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "0b352754-2d76-4a18-99a3-dbb83d999b9a");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "35c3d70f-22f5-4811-a10c-497814335f8f");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "fa2ffe69-3726-46d4-aebf-90d1a341b256");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "fc03d7b0-1109-453f-9e76-ebfa1fd475c4");

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Content", "CreatedAt", "Dislikes", "Likes", "Title" },
                values: new object[,]
                {
                    { "A", "Short story #1", new DateTime(2021, 12, 13, 11, 2, 0, 39, DateTimeKind.Local).AddTicks(4820), 0, 0, null },
                    { "B", "Short story #2", new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(369), 0, 0, null },
                    { "C", "Short story #3", new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(422), 0, 0, null },
                    { "D", "Short story #4", new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(429), 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Content", "CreatedAt", "Dislikes", "Likes", "ShortStoryID" },
                values: new object[,]
                {
                    { "A", "Comment on short story #1", new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(1349), 0, 0, "A" },
                    { "B", "Comment on short story #2", new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(2569), 0, 0, "B" },
                    { "C", "Comment on short story #3", new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(2622), 0, 0, "C" },
                    { "D", "Comment on short story #4", new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(2640), 0, 0, "D" }
                });
        }
    }
}
