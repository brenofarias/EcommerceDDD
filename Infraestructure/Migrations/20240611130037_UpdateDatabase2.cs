using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PRD_URL_IMG",
                table: "TB_PRODUTO",
                newName: "PRD_URL");

            migrationBuilder.AlterColumn<string>(
                name: "PRD_URL",
                table: "TB_PRODUTO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PRD_URL",
                table: "TB_PRODUTO",
                newName: "PRD_URL_IMG");

            migrationBuilder.AlterColumn<string>(
                name: "PRD_URL_IMG",
                table: "TB_PRODUTO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
