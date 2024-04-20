using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeStyle.Migrations
{
    /// <inheritdoc />
    public partial class changeName2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_YearGoals_T",
                table: "YearGoals_T");

            migrationBuilder.RenameTable(
                name: "YearGoals_T",
                newName: "yearGoals_Ts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yearGoals_Ts",
                table: "yearGoals_Ts",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_yearGoals_Ts",
                table: "yearGoals_Ts");

            migrationBuilder.RenameTable(
                name: "yearGoals_Ts",
                newName: "YearGoals_T");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YearGoals_T",
                table: "YearGoals_T",
                column: "Id");
        }
    }
}
