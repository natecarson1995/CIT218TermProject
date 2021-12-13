using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class FinalizedReactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "3ff26bad-4379-4890-a805-a92fc1b06aa1");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "70ac696b-961a-401e-9a74-0ac5d9fd8753");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "c02176ba-8851-48c3-8b16-a37457a7a188");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "f317f9c3-aba4-4f81-a1f1-d5c12c7e2735");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "488f2e68-0c69-48e0-8e66-69dc2bc1995b");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "5d54ae46-6b33-4eb2-8cab-01e5201a31f9");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "d9d5fd7f-f1f2-41c8-8ead-05d999e2a2d5");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "f8e55433-64b4-4d8f-99b7-a5191797d4ab");

            migrationBuilder.DropColumn(
                name: "Dislikes",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Comments");

            migrationBuilder.CreateTable(
                name: "CommentReaction",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CommentID = table.Column<string>(nullable: false),
                    Reaction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CommentReaction_Comments_CommentID",
                        column: x => x.CommentID,
                        principalTable: "Comments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CommentReaction_CommentID",
                table: "CommentReaction",
                column: "CommentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentReaction");

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

            migrationBuilder.AddColumn<int>(
                name: "Dislikes",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { "f8e55433-64b4-4d8f-99b7-a5191797d4ab", "System", "Content for short story #1", new DateTime(2021, 12, 13, 12, 24, 49, 951, DateTimeKind.Local).AddTicks(9076), "Short story #1" },
                    { "d9d5fd7f-f1f2-41c8-8ead-05d999e2a2d5", "System", "Content for short story #2", new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(5122), "Short story #2" },
                    { "5d54ae46-6b33-4eb2-8cab-01e5201a31f9", "System", "Content for short story #3", new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(5170), "Short story #3" },
                    { "488f2e68-0c69-48e0-8e66-69dc2bc1995b", "System", "Content for short story #4", new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(5177), "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Dislikes", "Likes", "ShortStoryID" },
                values: new object[,]
                {
                    { "3ff26bad-4379-4890-a805-a92fc1b06aa1", "System", "Comment on short story #1", new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(6084), 0, 0, "f8e55433-64b4-4d8f-99b7-a5191797d4ab" },
                    { "c02176ba-8851-48c3-8b16-a37457a7a188", "System", "Comment on short story #2", new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(7099), 0, 0, "d9d5fd7f-f1f2-41c8-8ead-05d999e2a2d5" },
                    { "f317f9c3-aba4-4f81-a1f1-d5c12c7e2735", "System", "Comment on short story #3", new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(7143), 0, 0, "5d54ae46-6b33-4eb2-8cab-01e5201a31f9" },
                    { "70ac696b-961a-401e-9a74-0ac5d9fd8753", "System", "Comment on short story #4", new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(7149), 0, 0, "488f2e68-0c69-48e0-8e66-69dc2bc1995b" }
                });
        }
    }
}
