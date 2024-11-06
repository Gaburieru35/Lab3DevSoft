using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class mudancas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrigemTransferencia",
                table: "Transferencias",
                newName: "OrigemTransferenciaCodigoProfessor");

            migrationBuilder.RenameColumn(
                name: "DestinoTransferencia",
                table: "Transferencias",
                newName: "DestinoTransferenciaCodigoAluno");

            migrationBuilder.AlterColumn<int>(
                name: "OrigemTransferenciaCodigoProfessor",
                table: "Transferencias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "DestinoTransferenciaCodigoAluno",
                table: "Transferencias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_DestinoTransferenciaCodigoAluno",
                table: "Transferencias",
                column: "DestinoTransferenciaCodigoAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_OrigemTransferenciaCodigoProfessor",
                table: "Transferencias",
                column: "OrigemTransferenciaCodigoProfessor");

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Alunos_DestinoTransferenciaCodigoAluno",
                table: "Transferencias",
                column: "DestinoTransferenciaCodigoAluno",
                principalTable: "Alunos",
                principalColumn: "CodigoAluno",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Professor_OrigemTransferenciaCodigoProfessor",
                table: "Transferencias",
                column: "OrigemTransferenciaCodigoProfessor",
                principalTable: "Professor",
                principalColumn: "CodigoProfessor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Alunos_DestinoTransferenciaCodigoAluno",
                table: "Transferencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Professor_OrigemTransferenciaCodigoProfessor",
                table: "Transferencias");

            migrationBuilder.DropIndex(
                name: "IX_Transferencias_DestinoTransferenciaCodigoAluno",
                table: "Transferencias");

            migrationBuilder.DropIndex(
                name: "IX_Transferencias_OrigemTransferenciaCodigoProfessor",
                table: "Transferencias");

            migrationBuilder.RenameColumn(
                name: "OrigemTransferenciaCodigoProfessor",
                table: "Transferencias",
                newName: "OrigemTransferencia");

            migrationBuilder.RenameColumn(
                name: "DestinoTransferenciaCodigoAluno",
                table: "Transferencias",
                newName: "DestinoTransferencia");

            migrationBuilder.AlterColumn<int>(
                name: "OrigemTransferencia",
                table: "Transferencias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "DestinoTransferencia",
                table: "Transferencias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 2);
        }
    }
}
