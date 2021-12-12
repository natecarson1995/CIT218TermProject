using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class CommentBlogRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShortStoryID",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ShortStoryID",
                table: "Comments",
                column: "ShortStoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ShortStories_ShortStoryID",
                table: "Comments",
                column: "ShortStoryID",
                principalTable: "ShortStories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ShortStories_ShortStoryID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ShortStoryID",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "ShortStoryID",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
