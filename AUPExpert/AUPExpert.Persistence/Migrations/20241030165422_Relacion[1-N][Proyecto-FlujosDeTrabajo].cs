using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUPExpert.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Relacion1NProyectoFlujosDeTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "project_workflow_fk",
                table: "Tbl_FlujoTrabajo",
                column: "ProyectoId",
                principalTable: "Tbl_Proyectos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "project_workflow_fk",
                table: "Tbl_FlujoTrabajo");
        }
    }
}
