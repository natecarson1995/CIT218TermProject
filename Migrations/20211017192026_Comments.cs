using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class Comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ShortStoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(maxLength: 1024, nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Dislikes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey("FK_ShortStoryID", comment => comment.ShortStoryID, "ShortStories", "ID");
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Content", "Dislikes", "Likes", "ShortStoryID" },
                values: new object[,]
                {
                    { "A", "Comment on short story #1", 0, 0, "A" },
                    { "B", "Comment on short story #2", 0, 0, "B" },
                    { "C", "Comment on short story #3", 0, 0, "C" },
                    { "D", "Comment on short story #4", 0, 0, "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
