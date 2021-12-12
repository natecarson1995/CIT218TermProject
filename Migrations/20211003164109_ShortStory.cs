using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class ShortStory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShortStories",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislikes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortStories", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ShortStories",
                columns: new[] { "ID", "Content", "Dislikes", "Likes" },
                values: new object[,]
                {
                    { "A", "Short story #1", 0, 0 },
                    { "B", "Short story #2", 0, 0 },
                    { "C", "Short story #3", 0, 0 },
                    { "D", "Short story #4", 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShortStories");
        }
    }
}
