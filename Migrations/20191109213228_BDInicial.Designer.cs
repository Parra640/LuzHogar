﻿// <auto-generated />
using LuzHogar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LuzHogar.Migrations
{
    [DbContext(typeof(LuzHogarContext))]
    [Migration("20191109213228_BDInicial")]
    partial class BDInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LuzHogar.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<int>("Dni");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Referencia")
                        .IsRequired();

                    b.Property<int>("Telefono");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LuzHogar.Models.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<int>("ClienteId");

                    b.Property<int>("MuebleId");

                    b.Property<string>("Progreso");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MuebleId");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("LuzHogar.Models.Mueble", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Foto");

                    b.Property<string>("Nombre");

                    b.Property<float>("Precio");

                    b.Property<int>("Stock");

                    b.HasKey("Id");

                    b.ToTable("Muebles");
                });

            modelBuilder.Entity("LuzHogar.Models.Contrato", b =>
                {
                    b.HasOne("LuzHogar.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LuzHogar.Models.Mueble", "Mueble")
                        .WithMany()
                        .HasForeignKey("MuebleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}