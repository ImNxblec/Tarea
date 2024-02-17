using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tarea.Migrations.DepartamentoDb
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
                    NombreDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombrePersonal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrantes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Integrantes",
                columns: new[] { "Id", "NombreDepartamento", "NombrePersonal" },
                values: new object[,]
                {
                    { 1, "Ventas", "Daniel, David, Exaul" },
                    { 2, "Logistica", "Carlos, Samuel, Ana" },
                    { 3, "Seguridad", "Pepe, Juan , Alex" },
                    { 4, "Software", "Betsabet, Luis, Lupe" },
                    { 5, "Limpieza", "Pedro, Lucas, Angel" }
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
