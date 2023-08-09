﻿// <auto-generated />
using ApiPetshopProgreso2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiPetshopProgreso2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230605193028_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiPetshopProgreso2.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Merizalde",
                            Cedula = "1720380052",
                            Email = "e@gmail.com",
                            Nombre = "Enrique",
                            Telefono = "0997357707"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Perez",
                            Cedula = "1720380053",
                            Email = "j@gmail.com",
                            Nombre = "Jose",
                            Telefono = "0997352658"
                        });
                });

            modelBuilder.Entity("ApiPetshopProgreso2.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 5,
                            Descripcion = "Collar para Perro",
                            Nombre = "Collar",
                            Precio = 3.5
                        },
                        new
                        {
                            Id = 2,
                            Cantidad = 10,
                            Descripcion = "Collar para Perro o Gato",
                            Nombre = "Correa",
                            Precio = 5.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
