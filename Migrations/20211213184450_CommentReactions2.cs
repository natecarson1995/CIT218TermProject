using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class CommentReactions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { "3a2ddc80-c28f-420d-90b1-f950e907f734", "System", "Content for short story #1", new DateTime(2021, 12, 13, 13, 44, 50, 295, DateTimeKind.Local).AddTicks(8151), "Short story #1" },
                    { "437c0cf1-ecb9-414e-8826-3161797eafee", "System", "Content for short story #2", new DateTime(2021, 12, 13, 13, 44, 50, 298, DateTimeKind.Local).AddTicks(2544), "Short story #2" },
                    { "0f3cd69e-cb7b-4474-8c2b-fcc61c31615b", "System", "Content for short story #3", new DateTime(2021, 12, 13, 13, 44, 50, 298, DateTimeKind.Local).AddTicks(2591), "Short story #3" },
                    { "7d422612-77c7-4a9f-84ab-cb64dee0ef59", "System", "Content for short story #4", new DateTime(2021, 12, 13, 13, 44, 50, 298, DateTimeKind.Local).AddTicks(2599), "Short story #4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Author", "Content", "CreatedAt", "ShortStoryID" },
                values: new object[,]
                {
                    { "c21eb9b3-76f6-4f55-855d-75be430ecaed", "System", "Comment on short story #1", new DateTime(2021, 12, 13, 13, 44, 50, 298, DateTimeKind.Local).AddTicks(3674), "3a2ddc80-c28f-420d-90b1-f950e907f734" },
                    { "508b05d9-1165-4ea3-aacd-d82e02798ab0", "System", "Comment on short story #2", new DateTime(2021, 12, 13, 13, 44, 50, 298, DateTimeKind.Local).AddTicks(4698), "437c0cf1-ecb9-414e-8826-3161797eafee" },
                    { "a956c7fe-ba2f-4d81-ba13-1fa29618f1d5", "System", "Comment on short story #3", new DateTime(2021, 12, 13, 13, 44, 50, 298, DateTimeKind.Local).AddTicks(4749), "0f3cd69e-cb7b-4474-8c2b-fcc61c31615b" },
                    { "d9ffa0d5-3035-44d1-9310-9ea6f2092ee6", "System", "Comment on short story #4", new DateTime(2021, 12, 13, 13, 44, 50, 298, DateTimeKind.Local).AddTicks(4755), "7d422612-77c7-4a9f-84ab-cb64dee0ef59" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "508b05d9-1165-4ea3-aacd-d82e02798ab0");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "a956c7fe-ba2f-4d81-ba13-1fa29618f1d5");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "c21eb9b3-76f6-4f55-855d-75be430ecaed");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "d9ffa0d5-3035-44d1-9310-9ea6f2092ee6");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "0f3cd69e-cb7b-4474-8c2b-fcc61c31615b");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "3a2ddc80-c28f-420d-90b1-f950e907f734");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "437c0cf1-ecb9-414e-8826-3161797eafee");

            migrationBuilder.DeleteData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "7d422612-77c7-4a9f-84ab-cb64dee0ef59");

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
        }
    }
}
