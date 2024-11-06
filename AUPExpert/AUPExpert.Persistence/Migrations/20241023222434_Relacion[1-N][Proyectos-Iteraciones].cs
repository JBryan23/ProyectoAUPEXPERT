using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUPExpert.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Relacion1NProyectosIteraciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "project_iteration_fk",
                table: "Tbl_Iteraciones",
                column: "IdProyecto",
                principalTable: "Tbl_Proyectos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "project_iteration_fk",
                table: "Tbl_Iteraciones");
        }
    }
}
