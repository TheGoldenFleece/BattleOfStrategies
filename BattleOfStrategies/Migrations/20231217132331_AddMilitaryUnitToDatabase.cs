using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BattleOfStrategies.Migrations
{
    /// <inheritdoc />
    public partial class AddMilitaryUnitToDatabase : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Range = table.Column<float>(type: "real", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<float>(type: "real", nullable: false),
                    HP = table.Column<float>(type: "real", nullable: false),
                    Aim = table.Column<float>(type: "real", nullable: false),
                    AffectedArea = table.Column<float>(type: "real", nullable: false)
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
