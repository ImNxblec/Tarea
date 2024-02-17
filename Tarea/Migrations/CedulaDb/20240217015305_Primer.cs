using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tarea.Migrations.CedulaDb
{
    /// <inheritdoc />
    public partial class Primer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CedulaPersona = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "CedulaPersona", "Nombre" },
                values: new object[,]
                {
                    { 1, "8424668873", "Carlos" },
                    { 2, "7014641144", "Daniel" },
                    { 3, "5517840648", "David" },
                    { 4, "3694639581", "Exaul" },
                    { 5, "9998908281", "David" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
