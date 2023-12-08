using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalJulia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoColaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoColaboradorNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoColaborador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPocedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoProcedimentoNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPocedimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidadeNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Procedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcedimentoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcedimentoObservacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoProcedimentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Procedimento_TipoPocedimento_TipoProcedimentoId",
                        column: x => x.TipoProcedimentoId,
                        principalTable: "TipoPocedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteCpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteEndereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColaboradorNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColaboradorCpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColaboradorSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColaboradorTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false),
                    TipoColaboradorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaborador_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_TipoColaborador_TipoColaboradorId",
                        column: x => x.TipoColaboradorId,
                        principalTable: "TipoColaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalRealizacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalRealizacaoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalRealizacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalRealizacao_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedimentoRealizado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    ProcedimentoId = table.Column<int>(type: "int", nullable: true),
                    ColaboradorId = table.Column<int>(type: "int", nullable: true),
                    LocalRealizacaoId = table.Column<int>(type: "int", nullable: true),
                    LocaRealizacaoId = table.Column<int>(type: "int", nullable: true),
                    DataRealizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObservacaoRealizacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimentoRealizado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcedimentoRealizado_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProcedimentoRealizado_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProcedimentoRealizado_LocalRealizacao_LocaRealizacaoId",
                        column: x => x.LocaRealizacaoId,
                        principalTable: "LocalRealizacao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProcedimentoRealizado_Procedimento_ProcedimentoId",
                        column: x => x.ProcedimentoId,
                        principalTable: "Procedimento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_EstadoId",
                table: "Cidade",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CidadeId",
                table: "Cliente",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_CidadeId",
                table: "Colaborador",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_TipoColaboradorId",
                table: "Colaborador",
                column: "TipoColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalRealizacao_CidadeId",
                table: "LocalRealizacao",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedimento_TipoProcedimentoId",
                table: "Procedimento",
                column: "TipoProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoRealizado_ClienteId",
                table: "ProcedimentoRealizado",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoRealizado_ColaboradorId",
                table: "ProcedimentoRealizado",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoRealizado_LocaRealizacaoId",
                table: "ProcedimentoRealizado",
                column: "LocaRealizacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoRealizado_ProcedimentoId",
                table: "ProcedimentoRealizado",
                column: "ProcedimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcedimentoRealizado");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "LocalRealizacao");

            migrationBuilder.DropTable(
                name: "Procedimento");

            migrationBuilder.DropTable(
                name: "TipoColaborador");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "TipoPocedimento");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
