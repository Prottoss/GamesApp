using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesApp.Migrations
{
    public partial class images2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "imgurl",
                value: "4fa3dcb2-a0e3-4a84-891b-6368a9d1b667_co4hk8.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "imgurl",
                value: "83885bc8-aaef-4f39-a09c-292dce442bdc_co4hb5.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "imgurl",
                value: "86c62277-6cf4-4b61-a426-4cc632485523_co2dhb.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "imgurl",
                value: "b8eb6138-17ea-49c5-975b-1f3598d4c91f_co2558.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "imgurl",
                value: "53598ccb-fda5-4f0d-ab35-25e3b4d1cbc0_co2x61.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "imgurl",
                value: "443124b2-e794-4b89-a207-4e541b59e3b2_co1v7g.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "imgurl",
                value: "2c349b4e-0bb4-4189-b1ce-3e48402764cc_co2mvt.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "imgurl",
                value: "71815838-9931-442c-9bca-b720cbf3d988_co1rst.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
