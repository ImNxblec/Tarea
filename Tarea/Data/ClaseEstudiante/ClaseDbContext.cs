using Microsoft.EntityFrameworkCore;
using Tarea.Models.ClaseEstudiante;
using static Azure.Core.HttpHeader;

namespace Tarea.Data.ClaseEstudiante
{
    public class ClaseDbContext : DbContext
    {
        public ClaseDbContext(DbContextOptions<ClaseDbContext> options)
            : base(options)
        {
        }
        public DbSet<Clase> Integrantes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clase>().HasData(
               new Clase
               {
                   Id = 1,
                   NombreClase = "Matematicas 1",
                   EstudiantesClase = "Ana, Pedro, Juan",
               },
               new Clase
               {
                   Id = 2,
                   NombreClase = "Matematicas 2",
                   EstudiantesClase = "Carlos, David, Exaul",
               },
               new Clase
               {
                   Id = 3,
                   NombreClase = "Ciencias",
                   EstudiantesClase = "Emilie, Melanie, Betsabet",
               },
               new Clase
               {
                   Id = 4,
                   NombreClase = "Lenguaje",
                   EstudiantesClase = "Ana, Emilie, Exaul",
               },
               new Clase
               {
                   Id = 5,
                   NombreClase = "Filosofia",
                   EstudiantesClase = "Carlos, Melanie, David",
               });
        }
    }
}
