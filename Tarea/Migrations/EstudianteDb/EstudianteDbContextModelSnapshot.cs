﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea.Data.ClaseEstudiante;

#nullable disable

namespace Tarea.Migrations.EstudianteDb
{
    [DbContext(typeof(EstudianteDbContext))]
    partial class EstudianteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tarea.Models.ClaseEstudiante.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NombreClases")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEstudiante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NombreClases = "Matematicas 1, Lenguaje",
                            NombreEstudiante = "Ana"
                        },
                        new
                        {
                            Id = 2,
                            NombreClases = "Matematicas 2, Filosofia",
                            NombreEstudiante = "Carlos"
                        },
                        new
                        {
                            Id = 3,
                            NombreClases = "Ciencias, Filosofia",
                            NombreEstudiante = "Melanie"
                        },
                        new
                        {
                            Id = 4,
                            NombreClases = "Matematicas 2, Lenguaje",
                            NombreEstudiante = "Exaul"
                        },
                        new
                        {
                            Id = 5,
                            NombreClases = "Matematicas 2, Filosofia",
                            NombreEstudiante = "David"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
