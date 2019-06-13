﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Conectar_Tablas.Migrations
{
    [DbContext(typeof(ConectarTablasContext))]
    [Migration("20190613102918_Migracion")]
    partial class Migracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Conectar_Tablas.Models.Dni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaExpiracion");

                    b.Property<string>("Identificador");

                    b.Property<int>("PersonaId");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Dni");
                });

            modelBuilder.Entity("Conectar_Tablas.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("Conectar_Tablas.Models.Dni", b =>
                {
                    b.HasOne("Conectar_Tablas.Models.Persona", "Persona")
                        .WithOne("Dni")
                        .HasForeignKey("Conectar_Tablas.Models.Dni", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
