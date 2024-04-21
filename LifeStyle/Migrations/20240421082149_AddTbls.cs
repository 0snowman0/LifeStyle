using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeStyle.Migrations
{
    /// <inheritdoc />
    public partial class AddTbls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "textMonth_Ts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfYear = table.Column<int>(type: "int", nullable: false),
                    NumberOfMonth = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_textMonth_Ts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "textThreeMonth_Ts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfYear = table.Column<int>(type: "int", nullable: false),
                    NumberOfThreeMonth = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_textThreeMonth_Ts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "textWeek_Ts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfYear = table.Column<int>(type: "int", nullable: false),
                    numberOfWeek = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_textWeek_Ts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "textYear_Ts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfYear = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_textYear_Ts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "textMonth_Ts");

            migrationBuilder.DropTable(
                name: "textThreeMonth_Ts");

            migrationBuilder.DropTable(
                name: "textWeek_Ts");

            migrationBuilder.DropTable(
                name: "textYear_Ts");
        }
    }
}
