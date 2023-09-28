using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommunityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: true),
                    ProvinceCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.CityId);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "AB", "Alberta" },
                    { "BC", "British Columbia" },
                    { "ON", "Ontario" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Vancouver", 200000, "British Columbia", "BC" },
                    { 2, "Kelowna", 20000, "British Columbia", "BC" },
                    { 3, "Surrey", 2000000, "British Columbia", "BC" },
                    { 4, "Edmonton", 200000, "Alberta", "AB" },
                    { 5, "Calgary", 325461, "Alberta", "AB" },
                    { 6, "Red Deer", 35643, "Alberta", "AB" },
                    { 7, "Toronto", 20000000, "Ontario", "ON" },
                    { 8, "Brampton", 896709, "Ontario", "ON" },
                    { 9, "London", 5447647, "Ontario", "ON" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
