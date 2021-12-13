using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class AddedAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "ShortStories",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Comments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Dislikes", "Likes", "Title" },
                values: new object[,]
                {
                    { "93043cd9-80b3-4cab-a359-80de99d439be", "System", "Content for short story #1", new DateTime(2021, 12, 13, 11, 50, 3, 136, DateTimeKind.Local).AddTicks(707), 0, 0, "Short story #1" },
                    { "a703b46c-27b4-4542-aae4-4fbf4364d55e", "System", "Content for short story #2", new DateTime(2021, 12, 13, 11, 50, 3, 138, DateTimeKind.Local).AddTicks(5727), 0, 0, "Short story #2" },
                    { "6779f4f7-877f-4e2c-8613-b3e7b97dda66", "System", "Content for short story #3", new DateTime(2021, 12, 13, 11, 50, 3, 138, DateTimeKind.Local).AddTicks(5778), 0, 0, "Short story #3" },
                    { "175c0a01-59fb-4921-8573-3424c2b300e7", "System", "Content for short story #4", new DateTime(2021, 12, 13, 11, 50, 3, 138, DateTimeKind.Local).AddTicks(5836), 0, 0, "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Dislikes", "Likes", "ShortStoryID" },
                values: new object[,]
                {
                    { "a76a66f9-88d4-493e-a6e4-9f29aa6592e6", "System", "Comment on short story #1", new DateTime(2021, 12, 13, 11, 50, 3, 138, DateTimeKind.Local).AddTicks(6852), 0, 0, "93043cd9-80b3-4cab-a359-80de99d439be" },
                    { "0dcb7f93-d0e7-443e-832f-d122f7f55bb4", "System", "Comment on short story #2", new DateTime(2021, 12, 13, 11, 50, 3, 138, DateTimeKind.Local).AddTicks(7891), 0, 0, "a703b46c-27b4-4542-aae4-4fbf4364d55e" },
                    { "5197d04c-6854-4dfd-88f0-481aa140cd10", "System", "Comment on short story #3", new DateTime(2021, 12, 13, 11, 50, 3, 138, DateTimeKind.Local).AddTicks(7945), 0, 0, "6779f4f7-877f-4e2c-8613-b3e7b97dda66" },
                    { "7c05510d-a8d2-4061-9995-9e4f173d73a2", "System", "Comment on short story #4", new DateTime(2021, 12, 13, 11, 50, 3, 138, DateTimeKind.Local).AddTicks(7951), 0, 0, "175c0a01-59fb-4921-8573-3424c2b300e7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "0dcb7f93-d0e7-443e-832f-d122f7f55bb4");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "5197d04c-6854-4dfd-88f0-481aa140cd10");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "7c05510d-a8d2-4061-9995-9e4f173d73a2");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "a76a66f9-88d4-493e-a6e4-9f29aa6592e6");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "175c0a01-59fb-4921-8573-3424c2b300e7");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "6779f4f7-877f-4e2c-8613-b3e7b97dda66");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "93043cd9-80b3-4cab-a359-80de99d439be");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "a703b46c-27b4-4542-aae4-4fbf4364d55e");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "ShortStories");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Comments");

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
    }
}
