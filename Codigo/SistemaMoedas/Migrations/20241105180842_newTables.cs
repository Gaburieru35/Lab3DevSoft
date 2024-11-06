using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class newTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    CodigoCurso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCurso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.CodigoCurso);
                });

            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    CodigoInstituicao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeInstituicao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.CodigoInstituicao);
                });

            migrationBuilder.CreateTable(
                name: "Parceiro",
                columns: table => new
                {
                    CodigoParceiro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeParceiro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CnpjParceiro = table.Column<string>(type: "VARCHAR(22)", maxLength: 22, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parceiro", x => x.CodigoParceiro);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    CodigoProfessor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpfProfessor = table.Column<int>(type: "int", nullable: false),
                    DepartamentoProfessor = table.Column<int>(type: "int", nullable: false),
                    InstituicaoProfessor = table.Column<int>(type: "int", nullable: false),
                    MoedasProfessor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.CodigoProfessor);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Instituicoes");

            migrationBuilder.DropTable(
                name: "Parceiro");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
