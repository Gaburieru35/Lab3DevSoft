using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMoedas.Migrations
{
    /// <inheritdoc />
    public partial class novosCamposTransferencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transferencias",
                columns: table => new
                {
                    CodigoTransferencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrigemTransferencia = table.Column<int>(type: "int", nullable: false),
                    DestinoTransferencia = table.Column<int>(type: "int", nullable: false),
                    DataHoraTransferencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorTransferencia = table.Column<int>(type: "int", nullable: false),
                    TipoTransferencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferencias", x => x.CodigoTransferencia);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transferencias");
        }
    }
}
