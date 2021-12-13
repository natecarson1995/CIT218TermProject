using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Dislikes", "Likes", "Title" },
                values: new object[,]
                {
                    { "af63e992-ec45-4110-965d-12ab0d2c8dd3", "System", "Content for short story #1", new DateTime(2021, 12, 13, 12, 6, 38, 391, DateTimeKind.Local).AddTicks(2972), 0, 0, "Short story #1" },
                    { "a28fd4d4-3549-499c-a503-4ff446cea506", "System", "Content for short story #2", new DateTime(2021, 12, 13, 12, 6, 38, 393, DateTimeKind.Local).AddTicks(8025), 0, 0, "Short story #2" },
                    { "ea8d9a56-ae55-4c57-9787-6474205052ad", "System", "Content for short story #3", new DateTime(2021, 12, 13, 12, 6, 38, 393, DateTimeKind.Local).AddTicks(8076), 0, 0, "Short story #3" },
                    { "29c69861-3c82-4a10-818e-226e2a763f3d", "System", "Content for short story #4", new DateTime(2021, 12, 13, 12, 6, 38, 393, DateTimeKind.Local).AddTicks(8083), 0, 0, "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Dislikes", "Likes", "ShortStoryID" },
                values: new object[,]
                {
                    { "6cd70322-8463-458b-a9c4-e2c3dfa25b1b", "System", "Comment on short story #1", new DateTime(2021, 12, 13, 12, 6, 38, 393, DateTimeKind.Local).AddTicks(9061), 0, 0, "af63e992-ec45-4110-965d-12ab0d2c8dd3" },
                    { "3c18a16c-6895-4910-9765-25039ad6c059", "System", "Comment on short story #2", new DateTime(2021, 12, 13, 12, 6, 38, 394, DateTimeKind.Local).AddTicks(68), 0, 0, "a28fd4d4-3549-499c-a503-4ff446cea506" },
                    { "6faf8db8-5620-4f34-a5e5-a8e3d299a5bd", "System", "Comment on short story #3", new DateTime(2021, 12, 13, 12, 6, 38, 394, DateTimeKind.Local).AddTicks(129), 0, 0, "ea8d9a56-ae55-4c57-9787-6474205052ad" },
                    { "05b1ff76-02b6-4ea2-bd66-5df644b34293", "System", "Comment on short story #4", new DateTime(2021, 12, 13, 12, 6, 38, 394, DateTimeKind.Local).AddTicks(182), 0, 0, "29c69861-3c82-4a10-818e-226e2a763f3d" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "05b1ff76-02b6-4ea2-bd66-5df644b34293");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "3c18a16c-6895-4910-9765-25039ad6c059");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "6cd70322-8463-458b-a9c4-e2c3dfa25b1b");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "6faf8db8-5620-4f34-a5e5-a8e3d299a5bd");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "29c69861-3c82-4a10-818e-226e2a763f3d");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "a28fd4d4-3549-499c-a503-4ff446cea506");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "af63e992-ec45-4110-965d-12ab0d2c8dd3");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "ea8d9a56-ae55-4c57-9787-6474205052ad");

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
    }
}
