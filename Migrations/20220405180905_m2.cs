using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesApp.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "developer",
                value: "CD Project Red");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "developer",
                value: "CD Project");
        }
    }
}
