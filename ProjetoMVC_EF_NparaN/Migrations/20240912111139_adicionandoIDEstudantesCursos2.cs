using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoMVC_EF_NparaN.Migrations
{
    /// <inheritdoc />
    public partial class adicionandoIDEstudantesCursos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstudantesCrusosId",
                table: "EstudantesCursos",
                newName: "EstudantesCursosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstudantesCursosId",
                table: "EstudantesCursos",
                newName: "EstudantesCrusosId");
        }
    }
}
