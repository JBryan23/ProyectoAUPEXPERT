using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUPExpert.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PropiedadIdProyectoEnFlujoTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProyecto",
                table: "Tbl_Iteraciones",
                newName: "ProyectoId");

            migrationBuilder.AddColumn<int>(
                name: "ProyectoId",
                table: "Tbl_FlujoTrabajo",
                type: "int(11)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ProyectoId",
                table: "Tbl_FlujoTrabajo",
                column: "ProyectoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ProyectoId",
                table: "Tbl_FlujoTrabajo");

            migrationBuilder.DropColumn(
                name: "ProyectoId",
                table: "Tbl_FlujoTrabajo");

            migrationBuilder.RenameColumn(
                name: "ProyectoId",
                table: "Tbl_Iteraciones",
                newName: "IdProyecto");
        }
    }
}
