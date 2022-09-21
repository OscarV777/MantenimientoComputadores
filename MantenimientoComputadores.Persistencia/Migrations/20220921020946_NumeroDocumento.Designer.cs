﻿// <auto-generated />
using System;
using MantenimientoComputadores.Persistencia.AppRepositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MantenimientoContext = MantenimientoComputadores.Persistencia.AppRepositorios.MantenimientoContext;

namespace MantenimientoComputadores.Persistencia.Migrations
{
    [DbContext(typeof(MantenimientoContext))]
    [Migration("20220921020946_NumeroDocumento")]
    partial class NumeroDocumento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MantCompu.App.Dominio.Administrador", b =>
                {
                    b.Property<int>("AdministradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("AdministradorId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Administradors");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Cita", b =>
                {
                    b.Property<int>("CitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AgendaId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoServicioId")
                        .HasColumnType("int");

                    b.HasKey("CitaId");

                    b.HasIndex("AgendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("TipoServicioId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Condicion")
                        .HasColumnType("bit");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("password_hash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("password_salt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("PersonaId");

                    b.HasIndex("RolId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Tecnico", b =>
                {
                    b.Property<int>("TecnicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("TarjetaProfesional")
                        .HasColumnType("int");

                    b.HasKey("TecnicoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.TipoServicio", b =>
                {
                    b.Property<int>("TipoServicioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Costo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoServicioId");

                    b.ToTable("TipoServicios");
                });

            modelBuilder.Entity("MantenimientoComputadores.Dominio.Entidades.Agenda", b =>
                {
                    b.Property<int>("AgendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TecnicoId")
                        .HasColumnType("int");

                    b.HasKey("AgendaId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("MantenimientoComputadores.Dominio.Entidades.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("MantenimientoComputadores.Dominio.Entidades.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Condicion")
                        .HasColumnType("bit");

                    b.Property<string>("Descricion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Administrador", b =>
                {
                    b.HasOne("MantCompu.App.Dominio.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Cita", b =>
                {
                    b.HasOne("MantenimientoComputadores.Dominio.Entidades.Agenda", "Agenda")
                        .WithMany()
                        .HasForeignKey("AgendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MantCompu.App.Dominio.Cliente", "Cliente")
                        .WithMany("Citas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MantenimientoComputadores.Dominio.Entidades.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MantCompu.App.Dominio.TipoServicio", "TipoServicio")
                        .WithMany()
                        .HasForeignKey("TipoServicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agenda");

                    b.Navigation("Cliente");

                    b.Navigation("Estado");

                    b.Navigation("TipoServicio");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Cliente", b =>
                {
                    b.HasOne("MantCompu.App.Dominio.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Persona", b =>
                {
                    b.HasOne("MantenimientoComputadores.Dominio.Entidades.Rol", "Rol")
                        .WithMany("personas")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Tecnico", b =>
                {
                    b.HasOne("MantCompu.App.Dominio.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("MantenimientoComputadores.Dominio.Entidades.Agenda", b =>
                {
                    b.HasOne("MantCompu.App.Dominio.Tecnico", "Tecnico")
                        .WithMany("Agendas")
                        .HasForeignKey("TecnicoId");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Cliente", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("MantCompu.App.Dominio.Tecnico", b =>
                {
                    b.Navigation("Agendas");
                });

            modelBuilder.Entity("MantenimientoComputadores.Dominio.Entidades.Rol", b =>
                {
                    b.Navigation("personas");
                });
#pragma warning restore 612, 618
        }
    }
}