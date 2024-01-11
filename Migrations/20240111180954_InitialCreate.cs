using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeitorNfe.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotaFiscal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeArquivo = table.Column<string>(type: "TEXT", nullable: false),
                    NumPedidoCompra = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    DataEmissao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumNota = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    Emitente = table.Column<string>(type: "TEXT", nullable: false),
                    Destinatario = table.Column<string>(type: "TEXT", nullable: false),
                    ChaveAcesso = table.Column<string>(type: "TEXT", nullable: false),
                    EmitCNPJ = table.Column<double>(type: "REAL", nullable: false),
                    EmitEndereco = table.Column<string>(type: "TEXT", nullable: false),
                    EmitEmail = table.Column<string>(type: "TEXT", nullable: true),
                    DestCNPJ = table.Column<double>(type: "REAL", nullable: true),
                    DestCPF = table.Column<double>(type: "REAL", nullable: true),
                    DestEmail = table.Column<string>(type: "TEXT", nullable: true),
                    DestEndereco = table.Column<string>(type: "TEXT", nullable: false),
                    TotalNotaFiscal = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscalItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumItem = table.Column<int>(type: "INTEGER", nullable: true),
                    CodProd = table.Column<string>(type: "TEXT", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    QuantidadeComprada = table.Column<double>(type: "REAL", nullable: false),
                    ValUnit = table.Column<double>(type: "REAL", nullable: false),
                    ValTotal = table.Column<double>(type: "REAL", nullable: false),
                    NotaFiscalId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscalItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaFiscalItem_NotaFiscal_NotaFiscalId",
                        column: x => x.NotaFiscalId,
                        principalTable: "NotaFiscal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscalItem_NotaFiscalId",
                table: "NotaFiscalItem",
                column: "NotaFiscalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaFiscalItem");

            migrationBuilder.DropTable(
                name: "NotaFiscal");
        }
    }
}
