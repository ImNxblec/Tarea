using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tarea.Migrations.EstudianteDb
{
    /// <inheritdoc />
    public partial class Primer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreClases = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clases",
                columns: new[] { "Id", "NombreClases", "NombreEstudiante" },
                values: new object[,]
                {
                    { 1, "Matematicas 1, Lenguaje", "Ana" },
                    { 2, "Matematicas 2, Filosofia", "Carlos" },
                    { 3, "Ciencias, Filosofia", "Melanie" },
                    { 4, "Matematicas 2, Lenguaje", "Exaul" },
                    { 5, "Matematicas 2, Filosofia", "David" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clases");
        }
    }
}
