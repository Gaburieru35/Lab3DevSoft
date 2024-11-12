using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
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
                    EnderecoAluno = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    CpfAluno = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    RGAluno = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false),
                    NomeAluno = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    SenhaAluno = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    QuantidadeMoedasAluno = table.Column<int>(type: "int", nullable: false),
                    DataCadastroAluno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstituicaoAluno = table.Column<int>(type: "int", nullable: false),
                    CursoAluno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.CodigoAluno);
                });

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
                    CnpjParceiro = table.Column<string>(type: "VARCHAR(22)", maxLength: 22, nullable: false),
                    EmailParceiro = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    SenhaParceiro = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    DataCadastroParceiro = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    MoedasProfessor = table.Column<int>(type: "int", nullable: false),
                    NomeProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.CodigoProfessor);
                });

            migrationBuilder.CreateTable(
                name: "Vantagens",
                columns: table => new
                {
                    CodigoVantagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoVantagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorVantagem = table.Column<int>(type: "int", nullable: false),
                    TituloVantagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vantagens", x => x.CodigoVantagem);
                });

            migrationBuilder.CreateTable(
                name: "Transferencias",
                columns: table => new
                {
                    CodigoTransferencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrigemTransferenciaCodigoProfessor = table.Column<int>(type: "int", nullable: false),
                    DestinoTransferenciaCodigoAluno = table.Column<int>(type: "int", nullable: false),
                    DataHoraTransferencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorTransferencia = table.Column<int>(type: "int", nullable: false),
                    TipoTransferencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferencias", x => x.CodigoTransferencia);
                    table.ForeignKey(
                        name: "FK_Transferencias_Alunos_DestinoTransferenciaCodigoAluno",
                        column: x => x.DestinoTransferenciaCodigoAluno,
                        principalTable: "Alunos",
                        principalColumn: "CodigoAluno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transferencias_Professor_OrigemTransferenciaCodigoProfessor",
                        column: x => x.OrigemTransferenciaCodigoProfessor,
                        principalTable: "Professor",
                        principalColumn: "CodigoProfessor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_DestinoTransferenciaCodigoAluno",
                table: "Transferencias",
                column: "DestinoTransferenciaCodigoAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_OrigemTransferenciaCodigoProfessor",
                table: "Transferencias",
                column: "OrigemTransferenciaCodigoProfessor");
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
                name: "Transferencias");

            migrationBuilder.DropTable(
                name: "Vantagens");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
