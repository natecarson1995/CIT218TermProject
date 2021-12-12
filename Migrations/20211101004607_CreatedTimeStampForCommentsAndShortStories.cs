using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class CreatedTimeStampForCommentsAndShortStories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ShortStories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "A",
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 20, 46, 6, 846, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "B",
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 20, 46, 6, 847, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "C",
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 20, 46, 6, 847, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "D",
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 20, 46, 6, 847, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "A",
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 20, 46, 6, 844, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "B",
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 20, 46, 6, 846, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "C",
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 20, 46, 6, 846, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "D",
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 20, 46, 6, 846, DateTimeKind.Local).AddTicks(8653));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ShortStories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Comments");
        }
    }
}
