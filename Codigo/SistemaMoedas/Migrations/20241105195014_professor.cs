using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class professor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailProfessor",
                table: "Professor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<string>(
                name: "NomeProfessor",
                table: "Professor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<string>(
                name: "SenhaProfessor",
                table: "Professor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailProfessor",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "NomeProfessor",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "SenhaProfessor",
                table: "Professor");
        }
    }
}
