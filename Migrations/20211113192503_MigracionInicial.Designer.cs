﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Final_AP1.Data;

namespace Proyecto_Final_AP1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211113192503_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Administradores", b =>
                {
                    b.Property<int>("AdministradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contraseña")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("AdministradorId");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apodo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cedula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dependientes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstadoCivilId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaIngresos")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GaranteId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NegocioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ocupacion")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SexoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ViviendaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClienteId");

                    b.HasIndex("EstadoCivilId");

                    b.HasIndex("GaranteId");

                    b.HasIndex("NegocioId");

                    b.HasIndex("SexoId");

                    b.HasIndex("ViviendaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Cobros", b =>
                {
                    b.Property<int>("CobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cobro")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CobroId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PrestamoId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.CobrosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("DetalleId");

                    b.ToTable("CobrosDetalle");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CobroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contraseña")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GaranteId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NegocioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CobroId");

                    b.HasIndex("GaranteId");

                    b.HasIndex("NegocioId");

                    b.HasIndex("PrestamoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.EstadosCiviles", b =>
                {
                    b.Property<int>("EstadoCivilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("EstadoCivilId");

                    b.ToTable("EstadosCiviles");

                    b.HasData(
                        new
                        {
                            EstadoCivilId = 1,
                            Descripcion = "Soltero/a"
                        },
                        new
                        {
                            EstadoCivilId = 2,
                            Descripcion = "Casado/a"
                        },
                        new
                        {
                            EstadoCivilId = 3,
                            Descripcion = "Divorciado/a"
                        },
                        new
                        {
                            EstadoCivilId = 4,
                            Descripcion = "Viuda/o"
                        },
                        new
                        {
                            EstadoCivilId = 5,
                            Descripcion = "Union Libre"
                        });
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Garantes", b =>
                {
                    b.Property<int>("GaranteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InformacionContableId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Parentesco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("GaranteId");

                    b.HasIndex("InformacionContableId");

                    b.ToTable("Garantes");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.InformacionesContables", b =>
                {
                    b.Property<int>("InformacionContableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaIngresos")
                        .HasColumnType("TEXT");

                    b.Property<float>("Ingresos")
                        .HasColumnType("REAL");

                    b.HasKey("InformacionContableId");

                    b.ToTable("InformacionesContables");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Negocios", b =>
                {
                    b.Property<int>("NegocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Actividad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<double>("Ingresos")
                        .HasColumnType("REAL");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int>("TiempoLaborando")
                        .HasColumnType("INTEGER");

                    b.HasKey("NegocioId");

                    b.ToTable("Negocios");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cuotas")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Interes")
                        .HasColumnType("REAL");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("PrestamoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.PrestamosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("DetalleId");

                    b.ToTable("PrestamosDetalle");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Sexos", b =>
                {
                    b.Property<int>("SexoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("SexoId");

                    b.ToTable("Sexos");

                    b.HasData(
                        new
                        {
                            SexoId = 1,
                            Descripcion = "Masculino"
                        },
                        new
                        {
                            SexoId = 2,
                            Descripcion = "Femenino"
                        });
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Viviendas", b =>
                {
                    b.Property<int>("ViviendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("ViviendaId");

                    b.ToTable("Viviendas");

                    b.HasData(
                        new
                        {
                            ViviendaId = 1,
                            Descripcion = "Alquilada"
                        },
                        new
                        {
                            ViviendaId = 2,
                            Descripcion = "Casa propia"
                        });
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Administradores", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Empleados", "Empleados")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Clientes", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.EstadosCiviles", "EstadosCiviles")
                        .WithMany()
                        .HasForeignKey("EstadoCivilId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Garantes", "Garantes")
                        .WithMany()
                        .HasForeignKey("GaranteId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Negocios", "Negocios")
                        .WithMany()
                        .HasForeignKey("NegocioId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Sexos", "Sexos")
                        .WithMany()
                        .HasForeignKey("SexoId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Viviendas", "Viviendas")
                        .WithMany()
                        .HasForeignKey("ViviendaId");

                    b.Navigation("EstadosCiviles");

                    b.Navigation("Garantes");

                    b.Navigation("Negocios");

                    b.Navigation("Sexos");

                    b.Navigation("Viviendas");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Cobros", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Clientes", "Clientes")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Prestamos", "Prestamos")
                        .WithMany()
                        .HasForeignKey("PrestamoId");

                    b.Navigation("Clientes");

                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.CobrosDetalle", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Cobros", null)
                        .WithMany("Detalle")
                        .HasForeignKey("DetalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Empleados", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Clientes", "Clientes")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Cobros", "Cobros")
                        .WithMany()
                        .HasForeignKey("CobroId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Garantes", "Garantes")
                        .WithMany()
                        .HasForeignKey("GaranteId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Negocios", "Negocios")
                        .WithMany()
                        .HasForeignKey("NegocioId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Prestamos", "Prestamos")
                        .WithMany()
                        .HasForeignKey("PrestamoId");

                    b.Navigation("Clientes");

                    b.Navigation("Cobros");

                    b.Navigation("Garantes");

                    b.Navigation("Negocios");

                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Garantes", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.InformacionesContables", "InformacionesContables")
                        .WithMany()
                        .HasForeignKey("InformacionContableId");

                    b.Navigation("InformacionesContables");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Prestamos", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Clientes", "Clientes")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.PrestamosDetalle", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Prestamos", null)
                        .WithMany("Detalle")
                        .HasForeignKey("DetalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Cobros", b =>
                {
                    b.Navigation("Detalle");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Prestamos", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
