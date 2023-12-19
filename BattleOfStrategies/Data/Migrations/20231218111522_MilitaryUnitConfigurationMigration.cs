using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BattleOfStrategies.Migrations
{
    /// <inheritdoc />
    public partial class MilitaryUnitConfigurationMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MilitaryUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Infantryman"),
                    Range = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Level = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Damage = table.Column<float>(type: "real", nullable: false, defaultValue: 0.2f),
                    HP = table.Column<float>(type: "real", nullable: false, defaultValue: 1f),
                    Aim = table.Column<float>(type: "real", nullable: false, defaultValue: 0.1f),
                    AffectedArea = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryUnits", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MilitaryUnits");
        }
    }
}
