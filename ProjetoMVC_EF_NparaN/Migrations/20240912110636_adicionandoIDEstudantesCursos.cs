using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoMVC_EF_NparaN.Migrations
{
    /// <inheritdoc />
    public partial class adicionandoIDEstudantesCursos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstudantesCrusosId",
                table: "EstudantesCursos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstudantesCrusosId",
                table: "EstudantesCursos");
        }
    }
}
