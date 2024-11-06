using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InstituicaoAluno",
                table: "Alunos",
                newName: "InstituicaoAlunoCodigoInstituicao");

            migrationBuilder.RenameColumn(
                name: "CursoAluno",
                table: "Alunos",
                newName: "CursoAlunoCodigoCurso");

            migrationBuilder.AlterColumn<int>(
                name: "InstituicaoAlunoCodigoInstituicao",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "CursoAlunoCodigoCurso",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoAlunoCodigoCurso",
                table: "Alunos",
                column: "CursoAlunoCodigoCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_InstituicaoAlunoCodigoInstituicao",
                table: "Alunos",
                column: "InstituicaoAlunoCodigoInstituicao");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Curso_CursoAlunoCodigoCurso",
                table: "Alunos",
                column: "CursoAlunoCodigoCurso",
                principalTable: "Curso",
                principalColumn: "CodigoCurso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Instituicoes_InstituicaoAlunoCodigoInstituicao",
                table: "Alunos",
                column: "InstituicaoAlunoCodigoInstituicao",
                principalTable: "Instituicoes",
                principalColumn: "CodigoInstituicao",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Curso_CursoAlunoCodigoCurso",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Instituicoes_InstituicaoAlunoCodigoInstituicao",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_CursoAlunoCodigoCurso",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_InstituicaoAlunoCodigoInstituicao",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "InstituicaoAlunoCodigoInstituicao",
                table: "Alunos",
                newName: "InstituicaoAluno");

            migrationBuilder.RenameColumn(
                name: "CursoAlunoCodigoCurso",
                table: "Alunos",
                newName: "CursoAluno");

            migrationBuilder.AlterColumn<int>(
                name: "InstituicaoAluno",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "CursoAluno",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 10);
        }
    }
}
