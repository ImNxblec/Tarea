﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea.Data.ClaseEstudiante;

#nullable disable

namespace Tarea.Migrations
{
    [DbContext(typeof(ClaseDbContext))]
    partial class ClaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tarea.Models.ClaseEstudiante.Clase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EstudiantesClase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreClase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Integrantes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstudiantesClase = "Ana, Pedro, Juan",
                            NombreClase = "Matematicas 1"
                        },
                        new
                        {
                            Id = 2,
                            EstudiantesClase = "Carlos, David, Exaul",
                            NombreClase = "Matematicas 2"
                        },
                        new
                        {
                            Id = 3,
                            EstudiantesClase = "Emilie, Melanie, Betsabet",
                            NombreClase = "Ciencias"
                        },
                        new
                        {
                            Id = 4,
                            EstudiantesClase = "Ana, Emilie, Exaul",
                            NombreClase = "Lenguaje"
                        },
                        new
                        {
                            Id = 5,
                            EstudiantesClase = "Carlos, Melanie, David",
                            NombreClase = "Filosofia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
