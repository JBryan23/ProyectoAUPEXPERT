using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUPExpert.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PropiedadÇodigoEnIteracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Tbl_Iteraciones",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Tbl_Iteraciones");
        }
    }
}
