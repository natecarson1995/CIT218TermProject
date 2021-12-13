using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class ChangedLikesAndDislikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Dislikes",
                table: "ShortStories");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "ShortStories");

            migrationBuilder.CreateTable(
                name: "ShortStoryReaction",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ShortStoryID = table.Column<string>(nullable: false),
                    Reaction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortStoryReaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShortStoryReaction_ShortStories_ShortStoryID",
                        column: x => x.ShortStoryID,
                        principalTable: "ShortStories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ShortStoryReaction_ShortStoryID",
                table: "ShortStoryReaction",
                column: "ShortStoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShortStoryReaction");

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

            migrationBuilder.AddColumn<int>(
                name: "Dislikes",
                table: "ShortStories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "ShortStories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
