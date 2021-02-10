using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuPlanejamentoFinanceiroAPI.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "varchar(20)", nullable: true),
                    Senha = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    PessoaCpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantidadeMeses = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => new { x.Descricao, x.PessoaCpf });
                    table.ForeignKey(
                        name: "FK_Gastos_Pessoas_PessoaCpf",
                        column: x => x.PessoaCpf,
                        principalTable: "Pessoas",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_PessoaCpf",
                table: "Gastos",
                column: "PessoaCpf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
