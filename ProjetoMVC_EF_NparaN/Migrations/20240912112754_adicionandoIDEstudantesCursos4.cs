using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoMVC_EF_NparaN.Migrations
{
    /// <inheritdoc />
    public partial class adicionandoIDEstudantesCursos4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EstudantesCursos",
                table: "EstudantesCursos");

            migrationBuilder.AlterColumn<int>(
                name: "EstudantesCursosId",
                table: "EstudantesCursos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstudantesCursos",
                table: "EstudantesCursos",
                column: "EstudantesCursosId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudantesCursos_EstudanteID",
                table: "EstudantesCursos",
                column: "EstudanteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EstudantesCursos",
                table: "EstudantesCursos");

            migrationBuilder.DropIndex(
                name: "IX_EstudantesCursos_EstudanteID",
                table: "EstudantesCursos");

            migrationBuilder.AlterColumn<int>(
                name: "EstudantesCursosId",
                table: "EstudantesCursos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstudantesCursos",
                table: "EstudantesCursos",
                columns: new[] { "EstudanteID", "CursoId" });
        }
    }
}
