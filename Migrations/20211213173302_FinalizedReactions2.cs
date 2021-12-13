using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class FinalizedReactions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "704b666c-c39f-487d-b79f-ae1cb6d2f0fb");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "767934e0-c131-4687-a812-33dfe2b99c31");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "e00f727c-638b-473c-960c-3e7115919e66");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "eed9ace6-fc57-4f89-8ee3-d5fd4e5c71bb");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "251f0f30-e6d7-4272-9751-08c725f56b03");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "3dec8cfb-4c3d-4ff6-b0fd-a215b0547ef1");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "caf5b232-231c-404d-8130-29d3dd219cf6");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "e2ef98f0-a580-4049-83bf-2009b6907cea");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "ShortStoryReaction",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "CommentReaction",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { "f241ce49-1a4b-4639-a0c8-3044c049bcd4", "System", "Content for short story #1", new DateTime(2021, 12, 13, 12, 33, 2, 27, DateTimeKind.Local).AddTicks(6409), "Short story #1" },
                    { "00864378-27c4-4578-b04a-80f37f842ebf", "System", "Content for short story #2", new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(1192), "Short story #2" },
                    { "7666cc7c-43c3-4a61-ba27-df1d29058f6b", "System", "Content for short story #3", new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(1238), "Short story #3" },
                    { "fabfd36a-823e-49f2-92c7-33e85827f123", "System", "Content for short story #4", new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(1245), "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "ShortStoryID" },
                values: new object[,]
                {
                    { "16e7fbf5-a77a-49ac-8c96-33da1083e489", "System", "Comment on short story #1", new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(2334), "f241ce49-1a4b-4639-a0c8-3044c049bcd4" },
                    { "d0b5384d-645d-48ae-a053-9fd44a6d4ba6", "System", "Comment on short story #2", new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(3396), "00864378-27c4-4578-b04a-80f37f842ebf" },
                    { "a140bbd4-2f37-4e61-a0e5-525b6b43be76", "System", "Comment on short story #3", new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(3444), "7666cc7c-43c3-4a61-ba27-df1d29058f6b" },
                    { "7ad6d37d-6493-4941-9763-723a631db603", "System", "Comment on short story #4", new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(3451), "fabfd36a-823e-49f2-92c7-33e85827f123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "16e7fbf5-a77a-49ac-8c96-33da1083e489");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "7ad6d37d-6493-4941-9763-723a631db603");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "a140bbd4-2f37-4e61-a0e5-525b6b43be76");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "d0b5384d-645d-48ae-a053-9fd44a6d4ba6");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "00864378-27c4-4578-b04a-80f37f842ebf");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "7666cc7c-43c3-4a61-ba27-df1d29058f6b");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "f241ce49-1a4b-4639-a0c8-3044c049bcd4");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "fabfd36a-823e-49f2-92c7-33e85827f123");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "ShortStoryReaction");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "CommentReaction");

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { "e2ef98f0-a580-4049-83bf-2009b6907cea", "System", "Content for short story #1", new DateTime(2021, 12, 13, 12, 28, 6, 503, DateTimeKind.Local).AddTicks(4139), "Short story #1" },
                    { "251f0f30-e6d7-4272-9751-08c725f56b03", "System", "Content for short story #2", new DateTime(2021, 12, 13, 12, 28, 6, 505, DateTimeKind.Local).AddTicks(9005), "Short story #2" },
                    { "caf5b232-231c-404d-8130-29d3dd219cf6", "System", "Content for short story #3", new DateTime(2021, 12, 13, 12, 28, 6, 505, DateTimeKind.Local).AddTicks(9060), "Short story #3" },
                    { "3dec8cfb-4c3d-4ff6-b0fd-a215b0547ef1", "System", "Content for short story #4", new DateTime(2021, 12, 13, 12, 28, 6, 505, DateTimeKind.Local).AddTicks(9067), "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "ShortStoryID" },
                values: new object[,]
                {
                    { "eed9ace6-fc57-4f89-8ee3-d5fd4e5c71bb", "System", "Comment on short story #1", new DateTime(2021, 12, 13, 12, 28, 6, 506, DateTimeKind.Local).AddTicks(211), "e2ef98f0-a580-4049-83bf-2009b6907cea" },
                    { "704b666c-c39f-487d-b79f-ae1cb6d2f0fb", "System", "Comment on short story #2", new DateTime(2021, 12, 13, 12, 28, 6, 506, DateTimeKind.Local).AddTicks(1265), "251f0f30-e6d7-4272-9751-08c725f56b03" },
                    { "767934e0-c131-4687-a812-33dfe2b99c31", "System", "Comment on short story #3", new DateTime(2021, 12, 13, 12, 28, 6, 506, DateTimeKind.Local).AddTicks(1312), "caf5b232-231c-404d-8130-29d3dd219cf6" },
                    { "e00f727c-638b-473c-960c-3e7115919e66", "System", "Comment on short story #4", new DateTime(2021, 12, 13, 12, 28, 6, 506, DateTimeKind.Local).AddTicks(1319), "3dec8cfb-4c3d-4ff6-b0fd-a215b0547ef1" }
                });
        }
    }
}
