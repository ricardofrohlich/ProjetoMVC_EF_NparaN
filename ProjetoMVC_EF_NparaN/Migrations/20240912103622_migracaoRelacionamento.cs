using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoMVC_EF_NparaN.Migrations
{
    /// <inheritdoc />
    public partial class migracaoRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudantesCursos_Cursos_CursosCursoID",
                table: "EstudantesCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudantesCursos_Estudantes_EstudantesEstudanteId",
                table: "EstudantesCursos");

            migrationBuilder.RenameColumn(
                name: "EstudantesEstudanteId",
                table: "EstudantesCursos",
                newName: "CursoId");

            migrationBuilder.RenameColumn(
                name: "CursosCursoID",
                table: "EstudantesCursos",
                newName: "EstudanteID");

            migrationBuilder.RenameIndex(
                name: "IX_EstudantesCursos_EstudantesEstudanteId",
                table: "EstudantesCursos",
                newName: "IX_EstudantesCursos_CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudantesCursos_Cursos_CursoId",
                table: "EstudantesCursos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudantesCursos_Estudantes_EstudanteID",
                table: "EstudantesCursos",
                column: "EstudanteID",
                principalTable: "Estudantes",
                principalColumn: "EstudanteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudantesCursos_Cursos_CursoId",
                table: "EstudantesCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_EstudantesCursos_Estudantes_EstudanteID",
                table: "EstudantesCursos");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "EstudantesCursos",
                newName: "EstudantesEstudanteId");

            migrationBuilder.RenameColumn(
                name: "EstudanteID",
                table: "EstudantesCursos",
                newName: "CursosCursoID");

            migrationBuilder.RenameIndex(
                name: "IX_EstudantesCursos_CursoId",
                table: "EstudantesCursos",
                newName: "IX_EstudantesCursos_EstudantesEstudanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudantesCursos_Cursos_CursosCursoID",
                table: "EstudantesCursos",
                column: "CursosCursoID",
                principalTable: "Cursos",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstudantesCursos_Estudantes_EstudantesEstudanteId",
                table: "EstudantesCursos",
                column: "EstudantesEstudanteId",
                principalTable: "Estudantes",
                principalColumn: "EstudanteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
