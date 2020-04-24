using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcialesWeb.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstudianteK",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteK", x => x.Id);
                    table.UniqueConstraint("AK_EstudianteK_Email", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "MateriaK",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Creditos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaK", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CursoK",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Grupo = table.Column<int>(nullable: false),
                    AñoSem = table.Column<int>(nullable: false),
                    Profesor = table.Column<string>(maxLength: 50, nullable: false),
                    MateriaKId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoK", x => x.Id);
                    table.UniqueConstraint("AK_CursoK_MateriaKId_AñoSem_Grupo", x => new { x.MateriaKId, x.AñoSem, x.Grupo });
                    table.ForeignKey(
                        name: "FK_CursoK_MateriaK_MateriaKId",
                        column: x => x.MateriaKId,
                        principalTable: "MateriaK",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParcialK",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Número = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Nota = table.Column<double>(nullable: false),
                    Porcentaje = table.Column<double>(nullable: false),
                    EstudianteKId = table.Column<int>(nullable: false),
                    CursoKId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcialK", x => x.Id);
                    table.UniqueConstraint("AK_ParcialK_EstudianteKId_CursoKId_Número", x => new { x.EstudianteKId, x.CursoKId, x.Número });
                    table.ForeignKey(
                        name: "FK_ParcialK_CursoK_CursoKId",
                        column: x => x.CursoKId,
                        principalTable: "CursoK",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParcialK_EstudianteK_EstudianteKId",
                        column: x => x.EstudianteKId,
                        principalTable: "EstudianteK",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParcialK_CursoKId",
                table: "ParcialK",
                column: "CursoKId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParcialK");

            migrationBuilder.DropTable(
                name: "CursoK");

            migrationBuilder.DropTable(
                name: "EstudianteK");

            migrationBuilder.DropTable(
                name: "MateriaK");
        }
    }
}
