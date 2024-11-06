using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUPExpert.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PropiedadDeEstadoYFasesEnProyectos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Tbl_Proyectos",
                type: "enum('PENDIENTE','FINALIZADO')",
                nullable: false,
                defaultValue: "PENDIENTE")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<ulong>(
                name: "FaseConstruccionCompletada",
                table: "Tbl_Proyectos",
                type: "bit(1)",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.AddColumn<ulong>(
                name: "FaseElaboracionCompletada",
                table: "Tbl_Proyectos",
                type: "bit(1)",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.AddColumn<ulong>(
                name: "FaseInicialCompletada",
                table: "Tbl_Proyectos",
                type: "bit(1)",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.AddColumn<ulong>(
                name: "FaseTransitionCompletada",
                table: "Tbl_Proyectos",
                type: "bit(1)",
                nullable: false,
                defaultValue: 0ul);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Tbl_Proyectos");

            migrationBuilder.DropColumn(
                name: "FaseConstruccionCompletada",
                table: "Tbl_Proyectos");

            migrationBuilder.DropColumn(
                name: "FaseElaboracionCompletada",
                table: "Tbl_Proyectos");

            migrationBuilder.DropColumn(
                name: "FaseInicialCompletada",
                table: "Tbl_Proyectos");

            migrationBuilder.DropColumn(
                name: "FaseTransitionCompletada",
                table: "Tbl_Proyectos");
        }
    }
}
