using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeStyle.Migrations
{
    /// <inheritdoc />
    public partial class AddTblsGoal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "goalsMonth_Ts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfMonth = table.Column<int>(type: "int", nullable: false),
                    NumberOfYear = table.Column<int>(type: "int", nullable: false),
                    FirstGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourthGoals = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goalsMonth_Ts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "goalsWeek_Ts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfYear = table.Column<int>(type: "int", nullable: false),
                    NumberOfMonth = table.Column<int>(type: "int", nullable: false),
                    NumberOfWeek = table.Column<int>(type: "int", nullable: false),
                    FirstGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourthGoals = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goalsWeek_Ts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "goalsMonth_Ts");

            migrationBuilder.DropTable(
                name: "goalsWeek_Ts");
        }
    }
}
