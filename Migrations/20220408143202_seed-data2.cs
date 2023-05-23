using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesApp.Migrations
{
    public partial class seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GenreId", "developer", "imgurl", "multiplayer", "name", "price", "release" },
                values: new object[] { 16, 5, "Riot Games", "https://images.igdb.com/igdb/image/upload/t_cover_big/co2mvt.png", true, "Valorant", 0m, 2020 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GenreId", "developer", "imgurl", "multiplayer", "name", "price", "release" },
                values: new object[] { 17, 3, "Capcom", "https://images.igdb.com/igdb/image/upload/t_cover_big/co1rst.png", true, "Monster Hunter: World", 39m, 2018 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
