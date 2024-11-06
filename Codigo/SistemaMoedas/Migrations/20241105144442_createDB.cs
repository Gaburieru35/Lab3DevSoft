using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class createDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    CodigoAluno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAluno = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    CpfAluno = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    NomeAluno = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    SenhaAluno = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.CodigoAluno);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
