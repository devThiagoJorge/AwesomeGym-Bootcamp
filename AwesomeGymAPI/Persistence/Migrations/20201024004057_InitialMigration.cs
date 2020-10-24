using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AwesomeGymAPI.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    Endereco = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    IdUnidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professor_Unidade_IdUnidade",
                        column: x => x.IdUnidade,
                        principalTable: "Unidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    DataNasicmento = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    IdUnidade = table.Column<int>(nullable: false),
                    IdProfessor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluno_Professor_IdProfessor",
                        column: x => x.IdProfessor,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aluno_Unidade_IdUnidade",
                        column: x => x.IdUnidade,
                        principalTable: "Unidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_IdProfessor",
                table: "Aluno",
                column: "IdProfessor");

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_IdUnidade",
                table: "Aluno",
                column: "IdUnidade");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_IdUnidade",
                table: "Professor",
                column: "IdUnidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Unidade");
        }
    }
}
