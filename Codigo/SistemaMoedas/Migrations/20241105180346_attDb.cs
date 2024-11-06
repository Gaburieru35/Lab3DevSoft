using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class attDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "QuantidadeMoedasAluno",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CpfAluno",
                table: "Alunos",
                type: "VARCHAR(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(14)",
                oldMaxLength: 14)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AddColumn<int>(
                name: "CursoAluno",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoAluno",
                table: "Alunos",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AddColumn<int>(
                name: "InstituicaoAluno",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<string>(
                name: "RGAluno",
                table: "Alunos",
                type: "VARCHAR(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CursoAluno",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "EnderecoAluno",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "InstituicaoAluno",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "RGAluno",
                table: "Alunos");

            migrationBuilder.AlterColumn<string>(
                name: "QuantidadeMoedasAluno",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CpfAluno",
                table: "Alunos",
                type: "VARCHAR(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(14)",
                oldMaxLength: 14)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);
        }
    }
}
