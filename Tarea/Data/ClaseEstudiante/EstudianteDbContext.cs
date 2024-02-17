using Microsoft.EntityFrameworkCore;
using Tarea.Models.ClaseEstudiante;
using static Azure.Core.HttpHeader;

namespace Tarea.Data.ClaseEstudiante
{
    public class EstudianteDbContext : DbContext
    {
        public EstudianteDbContext(DbContextOptions<EstudianteDbContext> options)
            : base(options)
        {
        }
        public DbSet<Estudiante> Clases { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>().HasData(
               new Estudiante
               {
                   Id = 1,
                   NombreEstudiante = "Ana",
                   NombreClases = "Matematicas 1, Lenguaje",
               },
               new Estudiante
               {
                   Id = 2,
                   NombreEstudiante = "Carlos",
                   NombreClases = "Matematicas 2, Filosofia",
               },
               new Estudiante
               {
                   Id = 3,
                   NombreEstudiante = "Melanie",
                   NombreClases = "Ciencias, Filosofia",
               },
               new Estudiante
               {
                   Id = 4,
                   NombreEstudiante = "Exaul",
                   NombreClases = "Matematicas 2, Lenguaje",
               },
               new Estudiante
               {
                   Id = 5,
                   NombreEstudiante = "David",
                   NombreClases = "Matematicas 2, Filosofia",
               });
        }
    }
}
