using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tarea.Migrations
{
    /// <inheritdoc />
    public partial class Primer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Integrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreClase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstudiantesClase = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrantes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Integrantes",
                columns: new[] { "Id", "EstudiantesClase", "NombreClase" },
                values: new object[,]
                {
                    { 1, "Ana, Pedro, Juan", "Matematicas 1" },
                    { 2, "Carlos, David, Exaul", "Matematicas 2" },
                    { 3, "Emilie, Melanie, Betsabet", "Ciencias" },
                    { 4, "Ana, Emilie, Exaul", "Lenguaje" },
                    { 5, "Carlos, Melanie, David", "Filosofia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Integrantes");
        }
    }
}
