using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estate_Agency.Migrations
{
    /// <inheritdoc />
    public partial class addedSearchOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beds = table.Column<int>(type: "int", nullable: true),
                    Garages = table.Column<int>(type: "int", nullable: true),
                    Washrooms = table.Column<int>(type: "int", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchOrders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchOrders");
        }
    }
}
