using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class FinalizedReactions3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShortStoryReaction_ShortStories_ShortStoryID",
                table: "ShortStoryReaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShortStoryReaction",
                table: "ShortStoryReaction");

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

            migrationBuilder.RenameTable(
                name: "ShortStoryReaction",
                newName: "ShortStoryReactions");

            migrationBuilder.RenameIndex(
                name: "IX_ShortStoryReaction_ShortStoryID",
                table: "ShortStoryReactions",
                newName: "IX_ShortStoryReactions_ShortStoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShortStoryReactions",
                table: "ShortStoryReactions",
                column: "ID");

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { "0042ae2a-a45f-47cd-84d8-b862d38ba5e9", "System", "Content for short story #1", new DateTime(2021, 12, 13, 12, 57, 37, 76, DateTimeKind.Local).AddTicks(9705), "Short story #1" },
                    { "41613919-ddd8-4db0-badb-68ce5e452bbd", "System", "Content for short story #2", new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(5171), "Short story #2" },
                    { "0604bee3-a6ae-48d3-9473-95fffcc0e310", "System", "Content for short story #3", new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(5266), "Short story #3" },
                    { "8c8c36bd-822f-4041-9b44-bbf0704789a2", "System", "Content for short story #4", new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(5274), "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "ShortStoryID" },
                values: new object[,]
                {
                    { "d3074dc1-7d88-42e2-915d-9ae567a4d2ed", "System", "Comment on short story #1", new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(6417), "0042ae2a-a45f-47cd-84d8-b862d38ba5e9" },
                    { "cbdf6198-c20e-499c-b910-9bf48577284e", "System", "Comment on short story #2", new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(7483), "41613919-ddd8-4db0-badb-68ce5e452bbd" },
                    { "64400894-44a1-4d48-99ae-238998a122f8", "System", "Comment on short story #3", new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(7527), "0604bee3-a6ae-48d3-9473-95fffcc0e310" },
                    { "b7e20c32-90c9-42ae-b888-5b12059c24de", "System", "Comment on short story #4", new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(7533), "8c8c36bd-822f-4041-9b44-bbf0704789a2" }
                });

            /*migrationBuilder.AddForeignKey(
                name: "FK_ShortStoryReactions_ShortStories_ShortStoryID",
                table: "ShortStoryReactions",
                column: "ShortStoryID",
                principalTable: "ShortStories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShortStoryReactions_ShortStories_ShortStoryID",
                table: "ShortStoryReactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShortStoryReactions",
                table: "ShortStoryReactions");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "64400894-44a1-4d48-99ae-238998a122f8");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "b7e20c32-90c9-42ae-b888-5b12059c24de");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "cbdf6198-c20e-499c-b910-9bf48577284e");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "d3074dc1-7d88-42e2-915d-9ae567a4d2ed");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "0042ae2a-a45f-47cd-84d8-b862d38ba5e9");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "0604bee3-a6ae-48d3-9473-95fffcc0e310");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "41613919-ddd8-4db0-badb-68ce5e452bbd");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "8c8c36bd-822f-4041-9b44-bbf0704789a2");

            migrationBuilder.RenameTable(
                name: "ShortStoryReactions",
                newName: "ShortStoryReaction");

            migrationBuilder.RenameIndex(
                name: "IX_ShortStoryReactions_ShortStoryID",
                table: "ShortStoryReaction",
                newName: "IX_ShortStoryReaction_ShortStoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShortStoryReaction",
                table: "ShortStoryReaction",
                column: "ID");

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

            /*migrationBuilder.AddForeignKey(
                name: "FK_ShortStoryReaction_ShortStories_ShortStoryID",
                table: "ShortStoryReaction",
                column: "ShortStoryID",
                principalTable: "ShortStories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);*/
        }
    }
}
