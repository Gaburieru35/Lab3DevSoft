using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class novosCamposParceiros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroParceiro",
                table: "Parceiro",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<string>(
                name: "EmailParceiro",
                table: "Parceiro",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "SenhaParceiro",
                table: "Parceiro",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastroParceiro",
                table: "Parceiro");

            migrationBuilder.DropColumn(
                name: "EmailParceiro",
                table: "Parceiro");

            migrationBuilder.DropColumn(
                name: "SenhaParceiro",
                table: "Parceiro");
        }
    }
}
