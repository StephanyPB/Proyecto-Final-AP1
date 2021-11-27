﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Final_AP1.DAL;

namespace Proyecto_Final_AP1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

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

                    b.Property<string>("Dependientes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstadoCivilId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GaranteId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NegocioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OcupacionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SexoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TipoViviendasId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClienteId");

                    b.HasIndex("EstadoCivilId");

                    b.HasIndex("GaranteId");

                    b.HasIndex("NegocioId")
                        .IsUnique();

                    b.HasIndex("OcupacionId");

                    b.HasIndex("SexoId");

                    b.HasIndex("TipoViviendasId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Cobros", b =>
                {
                    b.Property<int>("CobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Monto")
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

                    b.Property<int?>("CobroId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("CobroId");

                    b.ToTable("CobrosDetalle");
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

                    b.Property<int>("Ingresos")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Parentesco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GaranteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Garantes");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Moras", b =>
                {
                    b.Property<int>("MoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int?>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MoraId");

                    b.HasIndex("PrestamoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Moras");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Negocios", b =>
                {
                    b.Property<int>("NegocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoNegocioId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("NegocioId");

                    b.HasIndex("ClientesId");

                    b.HasIndex("TipoNegocioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Negocios");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Ocupaciones", b =>
                {
                    b.Property<int>("OcupacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("OcupacionId");

                    b.ToTable("Ocupaciones");

                    b.HasData(
                        new
                        {
                            OcupacionId = 1,
                            Descripcion = "Ingeniero/a"
                        },
                        new
                        {
                            OcupacionId = 2,
                            Descripcion = "Doctor/a"
                        },
                        new
                        {
                            OcupacionId = 3,
                            Descripcion = "Abogado/a"
                        },
                        new
                        {
                            OcupacionId = 4,
                            Descripcion = "Arquitecto/a"
                        },
                        new
                        {
                            OcupacionId = 5,
                            Descripcion = "Contable"
                        },
                        new
                        {
                            OcupacionId = 6,
                            Descripcion = "Desarrolador Web"
                        },
                        new
                        {
                            OcupacionId = 7,
                            Descripcion = "Asistente Medico"
                        },
                        new
                        {
                            OcupacionId = 8,
                            Descripcion = "Diseñador Grafico"
                        },
                        new
                        {
                            OcupacionId = 9,
                            Descripcion = "Consultor de Ciberseguridad"
                        },
                        new
                        {
                            OcupacionId = 10,
                            Descripcion = "Asesor Financiero"
                        },
                        new
                        {
                            OcupacionId = 11,
                            Descripcion = "Representante de ventas"
                        },
                        new
                        {
                            OcupacionId = 12,
                            Descripcion = "Odontologo"
                        });
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("PermisoId");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisoId = 1,
                            Descripcion = "Este permiso puede modificar datos",
                            Nombre = "Modifica"
                        },
                        new
                        {
                            PermisoId = 2,
                            Descripcion = "Este permiso puede eliminar datos",
                            Nombre = "Elimina"
                        },
                        new
                        {
                            PermisoId = 3,
                            Descripcion = "Este permiso puede agregar datos",
                            Nombre = "Agrega"
                        });
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cuotas")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Interes")
                        .HasColumnType("REAL");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrestamoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.PrestamosDetalle", b =>
                {
                    b.Property<int>("CuotaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BalanceCapital")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BalanceInteres")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capital")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCuota")
                        .HasColumnType("TEXT");

                    b.Property<double>("Interes")
                        .HasColumnType("REAL");

                    b.Property<int>("NumeroCuota")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CuotaId");

                    b.HasIndex("PrestamoId");

                    b.ToTable("PrestamosDetalle");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
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

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.TipoNegocios", b =>
                {
                    b.Property<int>("TipoNegocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoNegocioId");

                    b.ToTable("TipoNegocios");

                    b.HasData(
                        new
                        {
                            TipoNegocioId = 1,
                            Descripcion = "Colmado"
                        },
                        new
                        {
                            TipoNegocioId = 2,
                            Descripcion = "Hospital"
                        },
                        new
                        {
                            TipoNegocioId = 3,
                            Descripcion = "Almacen"
                        },
                        new
                        {
                            TipoNegocioId = 4,
                            Descripcion = "Oficina"
                        },
                        new
                        {
                            TipoNegocioId = 5,
                            Descripcion = "Banco"
                        },
                        new
                        {
                            TipoNegocioId = 6,
                            Descripcion = "Guarderia"
                        },
                        new
                        {
                            TipoNegocioId = 7,
                            Descripcion = "Supermercado"
                        },
                        new
                        {
                            TipoNegocioId = 8,
                            Descripcion = "Libreria"
                        },
                        new
                        {
                            TipoNegocioId = 9,
                            Descripcion = "Veterinaria"
                        },
                        new
                        {
                            TipoNegocioId = 10,
                            Descripcion = "Botica"
                        },
                        new
                        {
                            TipoNegocioId = 11,
                            Descripcion = "Farmacia"
                        },
                        new
                        {
                            TipoNegocioId = 12,
                            Descripcion = "Clinica"
                        });
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.TipoViviendas", b =>
                {
                    b.Property<int>("TipoViviendasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoViviendasId");

                    b.ToTable("TipoViviendas");

                    b.HasData(
                        new
                        {
                            TipoViviendasId = 1,
                            Descripcion = "Alquilada"
                        },
                        new
                        {
                            TipoViviendasId = 2,
                            Descripcion = "Casa propia"
                        });
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.UsuariosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UsuariosUsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.HasIndex("UsuariosUsuarioId");

                    b.ToTable("UsuariosDetalle");
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
                        .WithOne()
                        .HasForeignKey("Proyecto_Final_AP1.Entidades.Clientes", "NegocioId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Ocupaciones", "Ocupaciones")
                        .WithMany()
                        .HasForeignKey("OcupacionId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Sexos", "Sexos")
                        .WithMany()
                        .HasForeignKey("SexoId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.TipoViviendas", "Viviendas")
                        .WithMany()
                        .HasForeignKey("TipoViviendasId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("EstadosCiviles");

                    b.Navigation("Garantes");

                    b.Navigation("Negocios");

                    b.Navigation("Ocupaciones");

                    b.Navigation("Sexos");

                    b.Navigation("Usuarios");

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
                    b.HasOne("Proyecto_Final_AP1.Entidades.Cobros", "Cobros")
                        .WithMany()
                        .HasForeignKey("CobroId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Cobros", null)
                        .WithMany("Detalle")
                        .HasForeignKey("DetalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cobros");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Garantes", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Moras", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Prestamos", "Prestamos")
                        .WithMany()
                        .HasForeignKey("PrestamoId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Prestamos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Negocios", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Clientes", "Clientes")
                        .WithMany()
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Final_AP1.Entidades.TipoNegocios", "TipoNegocios")
                        .WithMany()
                        .HasForeignKey("TipoNegocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Final_AP1.Entidades.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Clientes");

                    b.Navigation("TipoNegocios");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Prestamos", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Clientes", "Clientes")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Proyecto_Final_AP1.Entidades.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Clientes");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.PrestamosDetalle", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Prestamos", null)
                        .WithMany("Detalle")
                        .HasForeignKey("CuotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Final_AP1.Entidades.Prestamos", "Prestamos")
                        .WithMany()
                        .HasForeignKey("PrestamoId");

                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.UsuariosDetalle", b =>
                {
                    b.HasOne("Proyecto_Final_AP1.Entidades.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Final_AP1.Entidades.Usuarios", null)
                        .WithMany("Detalle")
                        .HasForeignKey("UsuariosUsuarioId");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Cobros", b =>
                {
                    b.Navigation("Detalle");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Prestamos", b =>
                {
                    b.Navigation("Detalle");
                });

            modelBuilder.Entity("Proyecto_Final_AP1.Entidades.Usuarios", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
