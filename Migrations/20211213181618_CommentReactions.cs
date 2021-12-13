using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class CommentReactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentReaction_Comments_CommentID",
                table: "CommentReaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentReaction",
                table: "CommentReaction");

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
                name: "CommentReaction",
                newName: "CommentReactions");

            migrationBuilder.RenameIndex(
                name: "IX_CommentReaction_CommentID",
                table: "CommentReactions",
                newName: "IX_CommentReactions_CommentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentReactions",
                table: "CommentReactions",
                column: "ID");

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { "a5ed9673-4c76-4a78-90a8-3474c1978b50", "System", "Content for short story #1", new DateTime(2021, 12, 13, 13, 16, 18, 548, DateTimeKind.Local).AddTicks(305), "Short story #1" },
                    { "27c54a83-6848-4da4-bd91-7a8b54c29bda", "System", "Content for short story #2", new DateTime(2021, 12, 13, 13, 16, 18, 550, DateTimeKind.Local).AddTicks(5513), "Short story #2" },
                    { "bb7828f9-4568-47bb-84ed-5730601c5589", "System", "Content for short story #3", new DateTime(2021, 12, 13, 13, 16, 18, 550, DateTimeKind.Local).AddTicks(5604), "Short story #3" },
                    { "934e1f3e-8ab9-45e6-a9bf-6f69dd5852b7", "System", "Content for short story #4", new DateTime(2021, 12, 13, 13, 16, 18, 550, DateTimeKind.Local).AddTicks(5613), "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "ShortStoryID" },
                values: new object[,]
                {
                    { "2b0b2c64-2ded-47f8-9fd4-f82d50c8e9df", "System", "Comment on short story #1", new DateTime(2021, 12, 13, 13, 16, 18, 550, DateTimeKind.Local).AddTicks(6740), "a5ed9673-4c76-4a78-90a8-3474c1978b50" },
                    { "53f6faeb-b4fc-47ae-b912-9c4cb0b7757f", "System", "Comment on short story #2", new DateTime(2021, 12, 13, 13, 16, 18, 550, DateTimeKind.Local).AddTicks(7800), "27c54a83-6848-4da4-bd91-7a8b54c29bda" },
                    { "c1d05497-f47d-4a3e-b6f3-6272a597e543", "System", "Comment on short story #3", new DateTime(2021, 12, 13, 13, 16, 18, 550, DateTimeKind.Local).AddTicks(7847), "bb7828f9-4568-47bb-84ed-5730601c5589" },
                    { "1a05f3aa-5859-41cc-9aef-f3f9e5a32456", "System", "Comment on short story #4", new DateTime(2021, 12, 13, 13, 16, 18, 550, DateTimeKind.Local).AddTicks(7854), "934e1f3e-8ab9-45e6-a9bf-6f69dd5852b7" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CommentReactions_Comments_CommentID",
                table: "CommentReactions",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentReactions_Comments_CommentID",
                table: "CommentReactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentReactions",
                table: "CommentReactions");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "1a05f3aa-5859-41cc-9aef-f3f9e5a32456");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "2b0b2c64-2ded-47f8-9fd4-f82d50c8e9df");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "53f6faeb-b4fc-47ae-b912-9c4cb0b7757f");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "c1d05497-f47d-4a3e-b6f3-6272a597e543");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "27c54a83-6848-4da4-bd91-7a8b54c29bda");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "934e1f3e-8ab9-45e6-a9bf-6f69dd5852b7");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "a5ed9673-4c76-4a78-90a8-3474c1978b50");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "bb7828f9-4568-47bb-84ed-5730601c5589");

            migrationBuilder.RenameTable(
                name: "CommentReactions",
                newName: "CommentReaction");

            migrationBuilder.RenameIndex(
                name: "IX_CommentReactions_CommentID",
                table: "CommentReaction",
                newName: "IX_CommentReaction_CommentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentReaction",
                table: "CommentReaction",
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

            migrationBuilder.AddForeignKey(
                name: "FK_CommentReaction_Comments_CommentID",
                table: "CommentReaction",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
