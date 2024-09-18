using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FociWebApp_2.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_325 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meccsek",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fordulo = table.Column<int>(type: "INTEGER", nullable: false),
                    VendegGolFelido = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiGolFelido = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiGolok = table.Column<int>(type: "INTEGER", nullable: false),
                    VendegGolok = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiNev = table.Column<string>(type: "TEXT", nullable: true),
                    VendegNev = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meccsek", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meccsek");
        }
    }
}
