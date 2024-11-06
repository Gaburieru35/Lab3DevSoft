using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class newFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroAluno",
                table: "Alunos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<string>(
                name: "QuantidadeMoedasAluno",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastroAluno",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "QuantidadeMoedasAluno",
                table: "Alunos");
        }
    }
}
