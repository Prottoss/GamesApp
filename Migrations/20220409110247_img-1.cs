using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesApp.Migrations
{
    public partial class img1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "imgurl",
                value: "8b7d79cc-8630-46dd-bdcf-68fdefcff234_profilepic.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "imgurl",
                value: "8b7d79cc-8630-46dd-bdcf-68fdefcff234_profilepic.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "imgurl",
                value: "8b7d79cc-8630-46dd-bdcf-68fdefcff234_profilepic.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "imgurl",
                value: "8b7d79cc-8630-46dd-bdcf-68fdefcff234_profilepic.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "imgurl",
                value: "8b7d79cc-8630-46dd-bdcf-68fdefcff234_profilepic.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "imgurl",
                value: "8b7d79cc-8630-46dd-bdcf-68fdefcff234_profilepic.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "imgurl",
                value: "8b7d79cc-8630-46dd-bdcf-68fdefcff234_profilepic.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "imgurl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "imgurl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "imgurl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "imgurl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "imgurl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "imgurl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "imgurl",
                value: "");
        }
    }
}
