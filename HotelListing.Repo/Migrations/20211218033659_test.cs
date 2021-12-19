using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shortname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Countryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Countries_Countryid",
                        column: x => x.Countryid,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Shortname" },
                values: new object[] { 1, "egypt", "egp" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Shortname" },
                values: new object[] { 2, "italy", "ity" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Shortname" },
                values: new object[] { 3, "german", "ger" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Countryid", "Name", "Rating" },
                values: new object[] { 1, "downtown", 1, "king", 2.0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Countryid", "Name", "Rating" },
                values: new object[] { 2, "east", 2, "master", 3.0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Countryid", "Name", "Rating" },
                values: new object[] { 3, "north", 3, "legend", 5.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_Countryid",
                table: "Hotels",
                column: "Countryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
