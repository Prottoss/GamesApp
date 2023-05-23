using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesApp.Migrations
{
    public partial class imgudate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "imgurl",
                value: "8b7d79cc-8630-46dd-bdcf-68fdefcff234_profilepic.jpg");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "imgurl",
                value: "https://images.igdb.com/igdb/image/upload/t_cover_big/co4hk8.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "imgurl",
                value: "https://images.igdb.com/igdb/image/upload/t_cover_big/co4hb5.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "imgurl",
                value: "https://images.igdb.com/igdb/image/upload/t_cover_big/co2dhb.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "imgurl",
                value: "https://images.igdb.com/igdb/image/upload/t_cover_big/co2558.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "imgurl",
                value: "https://images.igdb.com/igdb/image/upload/t_cover_big/co2x61.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "imgurl",
                value: "https://images.igdb.com/igdb/image/upload/t_cover_big/co1v7g.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "imgurl",
                value: "https://images.igdb.com/igdb/image/upload/t_cover_big/co2mvt.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "imgurl",
                value: "https://images.igdb.com/igdb/image/upload/t_cover_big/co1rst.png");
        }
    }
}
