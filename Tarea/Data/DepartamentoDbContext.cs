using Microsoft.EntityFrameworkCore;
using Tarea.Models;
using static Azure.Core.HttpHeader;

namespace Tarea.Data
{
    public class DepartamentoDbContext : DbContext
    {
        public DepartamentoDbContext(DbContextOptions<DepartamentoDbContext> options)
            : base(options)
        {
        }
        public DbSet<Departamento> Integrantes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>().HasData(
               new Departamento
               {
                   Id = 1,
                   NombreDepartamento = "Ventas",
                   NombrePersonal = "Daniel, David, Exaul",   
               },
               new Departamento
               {
                   Id = 2,
                   NombreDepartamento = "Logistica",
                   NombrePersonal = "Carlos, Samuel, Ana",
               },
               new Departamento
               {
                   Id = 3,
                   NombreDepartamento = "Seguridad",
                   NombrePersonal = "Pepe, Juan , Alex",
               },
               new Departamento
               {
                   Id = 4,
                   NombreDepartamento = "Software",
                   NombrePersonal = "Betsabet, Luis, Lupe",
               },
               new Departamento
               {
                   Id = 5,
                   NombreDepartamento = "Limpieza",
                   NombrePersonal = "Pedro, Lucas, Angel",
               });
        }
    }
}
