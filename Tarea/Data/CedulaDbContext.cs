using Microsoft.EntityFrameworkCore;
using Tarea.Models;
using static Azure.Core.HttpHeader;

namespace Tarea.Data
{
    public class CedulaDbContext : DbContext
    {
        public CedulaDbContext(DbContextOptions<CedulaDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cedula> Personas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cedula>().HasData(
               new Cedula
               {
                   Id = 1,
                   Nombre = "Carlos",
                   CedulaPersona = "8424668873",
               },
               new Cedula
               {
                   Id = 2,
                   Nombre = "Daniel",
                   CedulaPersona = "7014641144",
               },
               new Cedula
               {
                   Id = 3,
                   Nombre = "David",
                   CedulaPersona = "5517840648",
               },
               new Cedula
               {
                   Id = 4,
                   Nombre = "Exaul",
                   CedulaPersona = "3694639581",
               },
               new Cedula
               {
                   Id = 5,
                   Nombre = "David",
                   CedulaPersona = "9998908281",
               });
        }
    }
}
