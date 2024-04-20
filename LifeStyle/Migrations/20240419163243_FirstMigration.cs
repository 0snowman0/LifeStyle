using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeStyle.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "yearGoals_Ts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourthGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yearGoals_Ts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "yearGoals_Ts");
        }
    }
}
