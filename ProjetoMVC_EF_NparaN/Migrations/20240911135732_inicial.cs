using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoMVC_EF_NparaN.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCurso = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoID);
                });

            migrationBuilder.CreateTable(
                name: "Estudantes",
                columns: table => new
                {
                    EstudanteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudantes", x => x.EstudanteId);
                });

            migrationBuilder.CreateTable(
                name: "EstudantesCursos",
                columns: table => new
                {
                    CursosCursoID = table.Column<int>(type: "INTEGER", nullable: false),
                    EstudantesEstudanteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudantesCursos", x => new { x.CursosCursoID, x.EstudantesEstudanteId });
                    table.ForeignKey(
                        name: "FK_EstudantesCursos_Cursos_CursosCursoID",
                        column: x => x.CursosCursoID,
                        principalTable: "Cursos",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstudantesCursos_Estudantes_EstudantesEstudanteId",
                        column: x => x.EstudantesEstudanteId,
                        principalTable: "Estudantes",
                        principalColumn: "EstudanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudantesCursos_EstudantesEstudanteId",
                table: "EstudantesCursos",
                column: "EstudantesEstudanteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstudantesCursos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Estudantes");
        }
    }
}
