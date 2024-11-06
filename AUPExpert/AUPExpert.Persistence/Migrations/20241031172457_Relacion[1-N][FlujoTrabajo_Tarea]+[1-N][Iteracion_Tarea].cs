using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUPExpert.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Relacion1NFlujoTrabajo_Tarea1NIteracion_Tarea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "flujoTrabajo_tarea_fk",
                table: "Tbl_Tareas",
                column: "FlujoTrabajoId",
                principalTable: "Tbl_FlujoTrabajo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "iteracion_tarea_fk",
                table: "Tbl_Tareas",
                column: "IteracionId",
                principalTable: "Tbl_Iteraciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "flujoTrabajo_tarea_fk",
                table: "Tbl_Tareas");

            migrationBuilder.DropForeignKey(
                name: "iteracion_tarea_fk",
                table: "Tbl_Tareas");
        }
    }
}
