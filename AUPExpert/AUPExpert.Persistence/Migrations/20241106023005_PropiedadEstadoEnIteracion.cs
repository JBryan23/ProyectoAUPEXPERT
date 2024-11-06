using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUPExpert.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PropiedadEstadoEnIteracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Tbl_Iteraciones",
                type: "enum('PENDIENTE','FINALIZADO')",
                nullable: false,
                defaultValue: "PENDIENTE")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Tbl_Iteraciones");
        }
    }
}
