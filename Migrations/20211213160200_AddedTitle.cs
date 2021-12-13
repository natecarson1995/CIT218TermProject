using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class AddedTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ShortStories",
                maxLength: 24,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "A",
                column: "CreatedAt",
                value: new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "B",
                column: "CreatedAt",
                value: new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "C",
                column: "CreatedAt",
                value: new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: "D",
                column: "CreatedAt",
                value: new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "A",
                column: "CreatedAt",
                value: new DateTime(2021, 12, 13, 11, 2, 0, 39, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "B",
                column: "CreatedAt",
                value: new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "C",
                column: "CreatedAt",
                value: new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "ShortStories",
                keyColumn: "ID",
                keyValue: "D",
                column: "CreatedAt",
                value: new DateTime(2021, 12, 13, 11, 2, 0, 42, DateTimeKind.Local).AddTicks(429));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "ShortStories");

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
    }
}
